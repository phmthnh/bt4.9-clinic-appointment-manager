using System.ComponentModel;

namespace ClinicAppointmentManager
{
    public partial class MainForm : Form
    {
        private ErrorProvider errors = null!;
        private readonly BindingList<Appointment> _appointments = new();
        private Appointment? _selected;
        private bool _ready;
        private bool _refreshing;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            if (_ready || DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            errors = new ErrorProvider(components) { ContainerControl = this, BlinkStyle = ErrorBlinkStyle.NeverBlink };
            grid.AutoGenerateColumns = false;
            grid.DataSource = recordsSource;
            cboFilterStatus.SelectedIndex = 0;
            dtpFilterDate.Value = DateTime.Today;
            ResetEditor();
            _ready = true;
            ApplyFilters();
        }

        private bool ReadEditor(out Appointment? appointment)
        {
            errors.Clear();
            appointment = null;
            bool valid = true;
            void Error(Control field, string message) { errors.SetError(field, message); valid = false; }
            string code = txtCode.Text.Trim();
            if (code.Length == 0) Error(txtCode, "Nhập mã lịch hẹn.");
            else if (_appointments.Any(x => !ReferenceEquals(x, _selected) && x.Code.Equals(code, StringComparison.OrdinalIgnoreCase)))
                Error(txtCode, "Mã lịch hẹn đã tồn tại.");
            if (string.IsNullOrWhiteSpace(txtPatient.Text)) Error(txtPatient, "Nhập họ tên bệnh nhân.");
            if (!InputRules.ValidPhone(txtPhone.Text)) Error(txtPhone, "Nhập số điện thoại hợp lệ: 10–11 chữ số bắt đầu bằng 0 hoặc mã +84.");
            if (dtpAppointment.Value < DateTime.Now) Error(dtpAppointment, "Ngày giờ hẹn không được nằm trong quá khứ.");
            if (cboDoctor.SelectedIndex < 0) Error(cboDoctor, "Chọn bác sĩ.");
            if (string.IsNullOrWhiteSpace(txtReason.Text)) Error(txtReason, "Nhập lý do khám.");
            if (cboStatus.SelectedIndex < 0) Error(cboStatus, "Chọn trạng thái.");
            if (!valid) return false;
            appointment = new Appointment(code, txtPatient.Text.Trim(), InputRules.CleanPhone(txtPhone.Text),
                dtpAppointment.Value, cboDoctor.Text, txtReason.Text.Trim(), cboStatus.Text);
            return true;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            // Thêm luôn kiểm tra trùng với tất cả bản ghi, kể cả dòng đang chọn.
            Appointment? previous = _selected;
            _selected = null;
            bool valid = ReadEditor(out var appointment);
            _selected = previous;
            if (!valid || appointment == null) return;
            _appointments.Add(appointment);
            ApplyFilters(appointment.Code);
            lblAction.Text = "Đã thêm lịch hẹn.";
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show(this, "Chọn lịch hẹn cần cập nhật.", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ReadEditor(out var appointment) || appointment == null) return;
            int index = _appointments.IndexOf(_selected);
            _appointments[index] = appointment;
            ApplyFilters(appointment.Code);
            lblAction.Text = "Đã cập nhật lịch hẹn.";
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (_selected == null) return;
            if (MessageBox.Show(this, $"Xóa lịch hẹn {_selected.Code} của {_selected.PatientName}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            _appointments.Remove(_selected);
            _selected = null;
            ResetEditor();
            ApplyFilters();
            lblAction.Text = "Đã xóa lịch hẹn.";
        }

        private void btnNew_Click(object? sender, EventArgs e) => ResetEditor();

        private void ResetEditor()
        {
            _selected = null;
            errors.Clear();
            _refreshing = true;
            grid.ClearSelection();
            grid.CurrentCell = null;
            _refreshing = false;
            txtCode.Text = InputRules.NewCode("LH");
            txtPatient.Clear();
            txtPhone.Clear();
            dtpAppointment.Value = DateTime.Now.AddHours(1);
            cboDoctor.SelectedIndex = 0;
            txtReason.Clear();
            cboStatus.SelectedIndex = 0;
            txtPatient.Focus();
        }

        private void FilterChanged(object? sender, EventArgs e)
        {
            if (!_ready) return;
            dtpFilterDate.Enabled = chkFilterDate.Checked;
            ApplyFilters();
        }

        private void ApplyFilters(string? selectCode = null)
        {
            if (!_ready) return;
            string? keepCode = selectCode ?? _selected?.Code;
            string query = txtSearch.Text.Trim();
            var visible = _appointments.Where(x =>
                (query.Length == 0 || InputRules.Matches(x.PatientName, query) || InputRules.Matches(x.Phone, InputRules.CleanPhone(query)))
                && (cboFilterStatus.SelectedIndex <= 0 || x.Status == cboFilterStatus.Text)
                && (!chkFilterDate.Checked || x.AppointmentTime.Date == dtpFilterDate.Value.Date)).ToList();
            _refreshing = true;
            recordsSource.DataSource = new BindingList<Appointment>(visible);
            grid.ClearSelection();
            grid.CurrentCell = null;
            _refreshing = false;
            lblCount.Text = $"Số lịch hẹn: {visible.Count}";
            var row = grid.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => x.DataBoundItem is Appointment a && a.Code == keepCode);
            if (row != null)
            {
                grid.CurrentCell = row.Cells[0];
                row.Selected = true;
                grid_SelectionChanged(grid, EventArgs.Empty);
            }
            else if (_selected != null) ResetEditor();
        }

        private void grid_SelectionChanged(object? sender, EventArgs e)
        {
            if (_refreshing || grid.SelectedRows.Count == 0 || grid.SelectedRows[0].DataBoundItem is not Appointment appointment) return;
            _selected = appointment;
            errors.Clear();
            txtCode.Text = appointment.Code;
            txtPatient.Text = appointment.PatientName;
            txtPhone.Text = appointment.Phone;
            dtpAppointment.Value = appointment.AppointmentTime;
            cboDoctor.SelectedItem = appointment.Doctor;
            txtReason.Text = appointment.Reason;
            cboStatus.SelectedItem = appointment.Status;
        }

        private void ExportCsv(string path)
        {
            CsvFile.Write(path, new[] { "Mã lịch hẹn", "Bệnh nhân", "Điện thoại", "Ngày giờ hẹn", "Bác sĩ", "Lý do khám", "Trạng thái" },
                recordsSource.List.Cast<Appointment>().Select(x => new[] { x.Code, x.PatientName, x.Phone,
                    CsvFile.Date(x.AppointmentTime, true), x.Doctor, x.Reason, x.Status }));
        }

        private void menuExport_Click(object? sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog { Filter = "CSV (*.csv)|*.csv", DefaultExt = "csv", AddExtension = true,
                FileName = "lich-hen.csv", Title = "Xuất lịch hẹn đang hiển thị" };
            if (dialog.ShowDialog(this) != DialogResult.OK) return;
            try { ExportCsv(dialog.FileName); lblAction.Text = "Đã xuất danh sách đang hiển thị ra CSV."; }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            { MessageBox.Show(this, "Không thể ghi CSV: " + ex.Message, "Lỗi xuất dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void menuExit_Click(object? sender, EventArgs e) => Close();
    }
}

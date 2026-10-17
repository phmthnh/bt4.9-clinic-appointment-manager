#nullable disable
namespace ClinicAppointmentManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private BindingSource recordsSource;

        private TableLayoutPanel layoutRoot;
        private GroupBox grpEditor;
        private Panel editorScroll;
        private TableLayoutPanel editorTable;
        private Label label0;
        private TextBox txtCode;
        private Label label1;
        private TextBox txtPatient;
        private Label label2;
        private TextBox txtPhone;
        private Label label3;
        private DateTimePicker dtpAppointment;
        private Label label4;
        private ComboBox cboDoctor;
        private Label label5;
        private TextBox txtReason;
        private Label label6;
        private ComboBox cboStatus;
        private TableLayoutPanel actionButtons;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnNew;
        private GroupBox grpList;
        private TableLayoutPanel listLayout;
        private TableLayoutPanel filterTable;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblFilter;
        private ComboBox cboFilterStatus;
        private CheckBox chkFilterDate;
        private DateTimePicker dtpFilterDate;
        private DataGridView grid;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colPatientName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAppointmentTime;
        private DataGridViewTextBoxColumn colDoctor;
        private DataGridViewTextBoxColumn colReason;
        private DataGridViewTextBoxColumn colStatus;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuExport;
        private ToolStripMenuItem menuExit;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblCount;
        private ToolStripStatusLabel lblAction;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            recordsSource = new BindingSource(components);
            layoutRoot = new TableLayoutPanel();
            grpEditor = new GroupBox();
            editorScroll = new Panel();
            editorTable = new TableLayoutPanel();
            label0 = new Label();
            txtCode = new TextBox();
            label1 = new Label();
            txtPatient = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            dtpAppointment = new DateTimePicker();
            label4 = new Label();
            cboDoctor = new ComboBox();
            label5 = new Label();
            txtReason = new TextBox();
            label6 = new Label();
            cboStatus = new ComboBox();
            actionButtons = new TableLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            grpList = new GroupBox();
            listLayout = new TableLayoutPanel();
            filterTable = new TableLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblFilter = new Label();
            cboFilterStatus = new ComboBox();
            chkFilterDate = new CheckBox();
            dtpFilterDate = new DateTimePicker();
            grid = new DataGridView();
            colCode = new DataGridViewTextBoxColumn();
            colPatientName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAppointmentTime = new DataGridViewTextBoxColumn();
            colDoctor = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            menuStrip = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuExport = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblCount = new ToolStripStatusLabel();
            lblAction = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)recordsSource).BeginInit();
            layoutRoot.SuspendLayout();
            grpEditor.SuspendLayout();
            editorScroll.SuspendLayout();
            editorTable.SuspendLayout();
            actionButtons.SuspendLayout();
            grpList.SuspendLayout();
            listLayout.SuspendLayout();
            filterTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            //
            // layoutRoot
            //
            layoutRoot.ColumnCount = 2;
            layoutRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 370F));
            layoutRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutRoot.Controls.Add(grpEditor, 0, 0);
            layoutRoot.Controls.Add(grpList, 1, 0);
            layoutRoot.Dock = DockStyle.Fill;
            layoutRoot.Location = new Point(0, 24);
            layoutRoot.Name = "layoutRoot";
            layoutRoot.Padding = new Padding(12);
            layoutRoot.RowCount = 1;
            layoutRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutRoot.Size = new Size(1280, 774);
            layoutRoot.TabIndex = 0;
            //
            // grpEditor
            //
            grpEditor.Controls.Add(editorScroll);
            grpEditor.Dock = DockStyle.Fill;
            grpEditor.Location = new Point(15, 15);
            grpEditor.Name = "grpEditor";
            grpEditor.Padding = new Padding(8, 22, 8, 8);
            grpEditor.Size = new Size(364, 744);
            grpEditor.TabIndex = 0;
            grpEditor.TabStop = false;
            grpEditor.Text = "Thông tin lịch hẹn";
            //
            // editorScroll
            //
            editorScroll.AutoScroll = true;
            editorScroll.Controls.Add(editorTable);
            editorScroll.Dock = DockStyle.Fill;
            editorScroll.Location = new Point(8, 38);
            editorScroll.Name = "editorScroll";
            editorScroll.Size = new Size(348, 698);
            editorScroll.TabIndex = 0;
            //
            // editorTable
            //
            editorTable.AutoSize = true;
            editorTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editorTable.ColumnCount = 2;
            editorTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            editorTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            editorTable.Controls.Add(label0, 0, 0);
            editorTable.Controls.Add(txtCode, 1, 0);
            editorTable.Controls.Add(label1, 0, 1);
            editorTable.Controls.Add(txtPatient, 1, 1);
            editorTable.Controls.Add(label2, 0, 2);
            editorTable.Controls.Add(txtPhone, 1, 2);
            editorTable.Controls.Add(label3, 0, 3);
            editorTable.Controls.Add(dtpAppointment, 1, 3);
            editorTable.Controls.Add(label4, 0, 4);
            editorTable.Controls.Add(cboDoctor, 1, 4);
            editorTable.Controls.Add(label5, 0, 5);
            editorTable.Controls.Add(txtReason, 1, 5);
            editorTable.Controls.Add(label6, 0, 6);
            editorTable.Controls.Add(cboStatus, 1, 6);
            editorTable.Controls.Add(actionButtons, 0, 7);
            editorTable.Dock = DockStyle.Top;
            editorTable.Location = new Point(0, 0);
            editorTable.Name = "editorTable";
            editorTable.RowCount = 8;
            editorTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            editorTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            editorTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            editorTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            editorTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            editorTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            editorTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            editorTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            editorTable.Size = new Size(348, 412);
            editorTable.TabIndex = 0;
            //
            // label0
            //
            label0.Dock = DockStyle.Fill;
            label0.Location = new Point(3, 0);
            label0.Name = "label0";
            label0.Size = new Size(106, 40);
            label0.TabIndex = 0;
            label0.Text = "Mã lịch hẹn";
            label0.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtCode
            //
            txtCode.Dock = DockStyle.Fill;
            txtCode.Location = new Point(115, 5);
            txtCode.Margin = new Padding(3, 5, 23, 5);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(210, 23);
            txtCode.TabIndex = 0;
            //
            // label1
            //
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 1;
            label1.Text = "Bệnh nhân";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtPatient
            //
            txtPatient.Dock = DockStyle.Fill;
            txtPatient.Location = new Point(115, 45);
            txtPatient.Margin = new Padding(3, 5, 23, 5);
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(210, 23);
            txtPatient.TabIndex = 1;
            //
            // label2
            //
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 80);
            label2.Name = "label2";
            label2.Size = new Size(106, 40);
            label2.TabIndex = 2;
            label2.Text = "Điện thoại";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtPhone
            //
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(115, 85);
            txtPhone.Margin = new Padding(3, 5, 23, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(210, 23);
            txtPhone.TabIndex = 2;
            //
            // label3
            //
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 120);
            label3.Name = "label3";
            label3.Size = new Size(106, 40);
            label3.TabIndex = 3;
            label3.Text = "Ngày giờ hẹn";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            //
            // dtpAppointment
            //
            dtpAppointment.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpAppointment.Dock = DockStyle.Fill;
            dtpAppointment.Format = DateTimePickerFormat.Custom;
            dtpAppointment.Location = new Point(115, 125);
            dtpAppointment.Margin = new Padding(3, 5, 23, 5);
            dtpAppointment.Name = "dtpAppointment";
            dtpAppointment.Size = new Size(210, 23);
            dtpAppointment.TabIndex = 3;
            //
            // label4
            //
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 160);
            label4.Name = "label4";
            label4.Size = new Size(106, 40);
            label4.TabIndex = 4;
            label4.Text = "Bác sĩ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            //
            // cboDoctor
            //
            cboDoctor.Dock = DockStyle.Fill;
            cboDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDoctor.Items.AddRange(new object[] { "BS. Nguyễn Minh Hải", "BS. Trần Thu Hà", "BS. Lê Hoàng Anh" });
            cboDoctor.Location = new Point(115, 165);
            cboDoctor.Margin = new Padding(3, 5, 23, 5);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(210, 23);
            cboDoctor.TabIndex = 4;
            //
            // label5
            //
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 200);
            label5.Name = "label5";
            label5.Size = new Size(106, 76);
            label5.TabIndex = 5;
            label5.Text = "Lý do khám";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtReason
            //
            txtReason.Dock = DockStyle.Fill;
            txtReason.Location = new Point(115, 205);
            txtReason.Margin = new Padding(3, 5, 23, 5);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ScrollBars = ScrollBars.Vertical;
            txtReason.Size = new Size(210, 66);
            txtReason.TabIndex = 5;
            //
            // label6
            //
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 276);
            label6.Name = "label6";
            label6.Size = new Size(106, 40);
            label6.TabIndex = 6;
            label6.Text = "Trạng thái";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            //
            // cboStatus
            //
            cboStatus.Dock = DockStyle.Fill;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboStatus.Location = new Point(115, 281);
            cboStatus.Margin = new Padding(3, 5, 23, 5);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(210, 23);
            cboStatus.TabIndex = 6;
            //
            // actionButtons
            //
            actionButtons.ColumnCount = 2;
            editorTable.SetColumnSpan(actionButtons, 2);
            actionButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            actionButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            actionButtons.Controls.Add(btnAdd, 0, 0);
            actionButtons.Controls.Add(btnUpdate, 1, 0);
            actionButtons.Controls.Add(btnDelete, 0, 1);
            actionButtons.Controls.Add(btnNew, 1, 1);
            actionButtons.Dock = DockStyle.Fill;
            actionButtons.Location = new Point(0, 324);
            actionButtons.Margin = new Padding(0, 8, 12, 0);
            actionButtons.Name = "actionButtons";
            actionButtons.RowCount = 2;
            actionButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            actionButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            actionButtons.Size = new Size(336, 88);
            actionButtons.TabIndex = 7;
            //
            // btnAdd
            //
            btnAdd.BackColor = Color.FromArgb(0, 130, 100);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 38);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            //
            // btnUpdate
            //
            btnUpdate.BackColor = Color.FromArgb(0, 110, 190);
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(171, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 38);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            //
            // btnDelete
            //
            btnDelete.BackColor = Color.FromArgb(175, 45, 45);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(3, 47);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(162, 38);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa dòng";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            //
            // btnNew
            //
            btnNew.BackColor = Color.FromArgb(90, 100, 115);
            btnNew.Dock = DockStyle.Fill;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(171, 47);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(162, 38);
            btnNew.TabIndex = 10;
            btnNew.Text = "Làm mới";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            //
            // grpList
            //
            grpList.Controls.Add(listLayout);
            grpList.Dock = DockStyle.Fill;
            grpList.Location = new Point(385, 15);
            grpList.Name = "grpList";
            grpList.Padding = new Padding(8, 22, 8, 8);
            grpList.Size = new Size(880, 744);
            grpList.TabIndex = 1;
            grpList.TabStop = false;
            grpList.Text = "Danh sách lịch hẹn";
            //
            // listLayout
            //
            listLayout.ColumnCount = 1;
            listLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            listLayout.Controls.Add(filterTable, 0, 0);
            listLayout.Controls.Add(grid, 0, 1);
            listLayout.Dock = DockStyle.Fill;
            listLayout.Location = new Point(8, 38);
            listLayout.Name = "listLayout";
            listLayout.RowCount = 2;
            listLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            listLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            listLayout.Size = new Size(864, 698);
            listLayout.TabIndex = 0;
            //
            // filterTable
            //
            filterTable.ColumnCount = 2;
            filterTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            filterTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            filterTable.Controls.Add(lblSearch, 0, 0);
            filterTable.Controls.Add(txtSearch, 1, 0);
            filterTable.Controls.Add(lblFilter, 0, 1);
            filterTable.Controls.Add(cboFilterStatus, 1, 1);
            filterTable.Controls.Add(chkFilterDate, 0, 2);
            filterTable.Controls.Add(dtpFilterDate, 1, 2);
            filterTable.Dock = DockStyle.Fill;
            filterTable.Location = new Point(3, 3);
            filterTable.Name = "filterTable";
            filterTable.RowCount = 3;
            filterTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            filterTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            filterTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            filterTable.Size = new Size(858, 110);
            filterTable.TabIndex = 0;
            //
            // lblSearch
            //
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(90, 36);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtSearch
            //
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(99, 5);
            txtSearch.Margin = new Padding(3, 5, 3, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tên bệnh nhân / điện thoại";
            txtSearch.Size = new Size(756, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += FilterChanged;
            //
            // lblFilter
            //
            lblFilter.Dock = DockStyle.Fill;
            lblFilter.Location = new Point(3, 36);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(90, 36);
            lblFilter.TabIndex = 2;
            lblFilter.Text = "Trạng thái";
            lblFilter.TextAlign = ContentAlignment.MiddleLeft;
            //
            // cboFilterStatus
            //
            cboFilterStatus.Dock = DockStyle.Fill;
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.Items.AddRange(new object[] { "Tất cả", "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboFilterStatus.Location = new Point(99, 41);
            cboFilterStatus.Margin = new Padding(3, 5, 3, 5);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(756, 23);
            cboFilterStatus.TabIndex = 3;
            cboFilterStatus.SelectedIndexChanged += FilterChanged;
            //
            // chkFilterDate
            //
            chkFilterDate.Dock = DockStyle.Fill;
            chkFilterDate.Location = new Point(3, 75);
            chkFilterDate.Name = "chkFilterDate";
            chkFilterDate.Size = new Size(90, 32);
            chkFilterDate.TabIndex = 4;
            chkFilterDate.Text = "Lọc ngày";
            chkFilterDate.CheckedChanged += FilterChanged;
            //
            // dtpFilterDate
            //
            dtpFilterDate.CustomFormat = "dd/MM/yyyy";
            dtpFilterDate.Dock = DockStyle.Fill;
            dtpFilterDate.Enabled = false;
            dtpFilterDate.Format = DateTimePickerFormat.Custom;
            dtpFilterDate.Location = new Point(99, 77);
            dtpFilterDate.Margin = new Padding(3, 5, 3, 5);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(756, 23);
            dtpFilterDate.TabIndex = 5;
            dtpFilterDate.ValueChanged += FilterChanged;
            //
            // grid
            //
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.White;
            grid.Columns.AddRange(new DataGridViewColumn[] { colCode, colPatientName, colPhone, colAppointmentTime, colDoctor, colReason, colStatus });
            grid.Dock = DockStyle.Fill;
            grid.Location = new Point(3, 119);
            grid.MultiSelect = false;
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(858, 576);
            grid.TabIndex = 1;
            grid.SelectionChanged += grid_SelectionChanged;
            //
            // colCode
            //
            colCode.DataPropertyName = "Code";
            colCode.HeaderText = "Mã lịch hẹn";
            colCode.MinimumWidth = 95;
            colCode.Name = "colCode";
            colCode.ReadOnly = true;
            //
            // colPatientName
            //
            colPatientName.DataPropertyName = "PatientName";
            colPatientName.FillWeight = 130F;
            colPatientName.HeaderText = "Bệnh nhân";
            colPatientName.MinimumWidth = 95;
            colPatientName.Name = "colPatientName";
            colPatientName.ReadOnly = true;
            //
            // colPhone
            //
            colPhone.DataPropertyName = "Phone";
            colPhone.FillWeight = 105F;
            colPhone.HeaderText = "Điện thoại";
            colPhone.MinimumWidth = 95;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            //
            // colAppointmentTime
            //
            colAppointmentTime.DataPropertyName = "AppointmentTime";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm";
            colAppointmentTime.DefaultCellStyle = dataGridViewCellStyle1;
            colAppointmentTime.FillWeight = 140F;
            colAppointmentTime.HeaderText = "Ngày giờ hẹn";
            colAppointmentTime.MinimumWidth = 95;
            colAppointmentTime.Name = "colAppointmentTime";
            colAppointmentTime.ReadOnly = true;
            //
            // colDoctor
            //
            colDoctor.DataPropertyName = "Doctor";
            colDoctor.FillWeight = 125F;
            colDoctor.HeaderText = "Bác sĩ";
            colDoctor.MinimumWidth = 95;
            colDoctor.Name = "colDoctor";
            colDoctor.ReadOnly = true;
            //
            // colReason
            //
            colReason.DataPropertyName = "Reason";
            colReason.FillWeight = 150F;
            colReason.HeaderText = "Lý do khám";
            colReason.MinimumWidth = 95;
            colReason.Name = "colReason";
            colReason.ReadOnly = true;
            //
            // colStatus
            //
            colStatus.DataPropertyName = "Status";
            colStatus.FillWeight = 110F;
            colStatus.HeaderText = "Trạng thái";
            colStatus.MinimumWidth = 95;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            //
            // menuStrip
            //
            menuStrip.Items.AddRange(new ToolStripItem[] { menuFile });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1280, 24);
            menuStrip.TabIndex = 2;
            //
            // menuFile
            //
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuExport, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(39, 20);
            menuFile.Text = "Tệp";
            //
            // menuExport
            //
            menuExport.Name = "menuExport";
            menuExport.ShortcutKeys = Keys.Control | Keys.E;
            menuExport.Size = new Size(228, 22);
            menuExport.Text = "Xuất danh sách CSV...";
            menuExport.Click += menuExport_Click;
            //
            // menuExit
            //
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(228, 22);
            menuExit.Text = "Thoát";
            menuExit.Click += menuExit_Click;
            //
            // statusStrip
            //
            statusStrip.Items.AddRange(new ToolStripItem[] { lblCount, lblAction });
            statusStrip.Location = new Point(0, 798);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1280, 22);
            statusStrip.TabIndex = 1;
            //
            // lblCount
            //
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(75, 17);
            lblCount.Text = "Số bản ghi: 0";
            //
            // lblAction
            //
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(1190, 17);
            lblAction.Spring = true;
            lblAction.TextAlign = ContentAlignment.MiddleRight;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 820);
            Controls.Add(layoutRoot);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(1080, 700);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BT4.9 - Quản lý lịch hẹn phòng khám";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)recordsSource).EndInit();
            layoutRoot.ResumeLayout(false);
            grpEditor.ResumeLayout(false);
            editorScroll.ResumeLayout(false);
            editorScroll.PerformLayout();
            editorTable.ResumeLayout(false);
            editorTable.PerformLayout();
            actionButtons.ResumeLayout(false);
            grpList.ResumeLayout(false);
            listLayout.ResumeLayout(false);
            filterTable.ResumeLayout(false);
            filterTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

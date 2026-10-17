using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ClinicAppointmentManager
{
    internal static class InputRules
    {
        public static string NewCode(string prefix) => prefix + "-" + DateTime.Now.ToString("MMddHHmmss") + "-" + Guid.NewGuid().ToString("N")[..4].ToUpperInvariant();
        public static string CleanPhone(string value) => Regex.Replace(value.Trim(), @"[\s().-]", "");
        public static bool ValidPhone(string value) => Regex.IsMatch(CleanPhone(value), @"^(0\d{9,10}|\+84\d{9,10})$");
        public static bool Matches(string value, string query) => value.Contains(query, StringComparison.CurrentCultureIgnoreCase);
    }

    internal static class CsvFile
    {
        private static string Cell(string text)
        {
            string trimmed = text.TrimStart();
            if (trimmed.Length > 0 && "=+-@\t\r".Contains(trimmed[0])) text = "'" + text;
            return "\"" + text.Replace("\"", "\"\"") + "\"";
        }

        public static void Write(string path, IEnumerable<string> headers, IEnumerable<IEnumerable<string>> rows)
        {
            var output = new StringBuilder();
            output.AppendLine(string.Join(",", headers.Select(Cell)));
            foreach (var row in rows) output.AppendLine(string.Join(",", row.Select(Cell)));
            File.WriteAllText(path, output.ToString(), new UTF8Encoding(true));
        }
        public static string Date(DateTime value, bool includeTime = false) => value.ToString(includeTime ? "dd/MM/yyyy HH:mm" : "dd/MM/yyyy", CultureInfo.InvariantCulture);
    }
}

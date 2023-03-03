using System.Diagnostics;

namespace OTOI_ADD.Code.Function
{
    internal static class Auxiliary
    {
        /// <summary>
        /// Holds the current selected directory.
        /// </summary>
        internal static string currDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        /// <summary>
        /// Converts the string representing a month to an equivalent integer.
        /// </summary>
        /// <param name="m">Month as string to be converted.</param>
        /// <returns>Month as integer.</returns>
        internal static int MonthToInt(string m)
        {
            Dictionary<string, int> month = new Dictionary<string, int>();
            month.Add("enero", 1);
            month.Add("febrero", 2);
            month.Add("marzo", 3);
            month.Add("abril", 4);
            month.Add("mayo", 5);
            month.Add("junio", 6);
            month.Add("julio", 7);
            month.Add("agosto", 8);
            month.Add("septiembre", 9);
            month.Add("octubre", 10);
            month.Add("noviembre", 11);
            month.Add("diciembre", 12);

            return month[m.ToLower()];
        }
        /// <summary>
        /// Converts the integer representing a month to an equivalent string.
        /// </summary>
        /// <param name="m">Month as integer to be converted.</param>
        /// <returns>Month as string.</returns>
        internal static int IntToMonth(int m)
        {
            Dictionary<string, int> month = new Dictionary<string, int>();
            month.Add("enero", 1);
            month.Add("febrero", 2);
            month.Add("marzo", 3);
            month.Add("abril", 4);
            month.Add("mayo", 5);
            month.Add("junio", 6);
            month.Add("julio", 7);
            month.Add("agosto", 8);
            month.Add("septiembre", 9);
            month.Add("octubre", 10);
            month.Add("noviembre", 11);
            month.Add("diciembre", 12);

            return month.ElementAt(m).Value;
        }
        /// <summary>
        /// Obtains the last day for the given month/year.
        /// </summary>
        /// <param name="month">Month to get the last day from</param>
        /// <param name="year">Corresponding year.</param>
        /// <returns>Last day for the month/year.</returns>
        internal static int LastDayOfMonth(int month, int year)
        {
            return DateTime.DaysInMonth(year, month); ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        internal static DateTime DateStart(DateTime start)
        {
            if (DateTime.Compare(start, DateTime.Today) > 0)
            {
                start = DateTime.Today.AddDays(-1);
            }
            if (DateTime.Compare(start, new DateTime(2018, 1, 1)) < 0){
                start = new DateTime(2018, 1, 1);
            }
            return start;
        }

        /// <summary>
        /// If the entered date is after [Today], returns the day before [Today].
        /// </summary>
        /// <param name="end">Entered date to compare.</param>
        /// <returns>[end] or [Today] - 1.</returns>
        internal static DateTime DateEnd(DateTime end)
        {
            if (DateTime.Compare(end, DateTime.Today) > 0)
            {
                end = DateTime.Today.AddDays(-1);
            }
            if (DateTime.Compare(end, new DateTime(2018, 1, 1)) < 0)
            {
                end = new DateTime(2018, 1, 1);
            }
            return end;
        }
        /// <summary>
        /// Formats a month given as a string with 2 characters.
        /// </summary>
        /// <param name="month">Month as integer to format.</param>
        /// <returns>Formatted month as a string.</returns>
        internal static string FormatMonth(int month)
        {
            string mth;
            if (month < 10)
            {
                mth = "0" + month;
            }
            else
            {
                mth = month.ToString();
            }
            return mth;
        }
        /// <summary>
        /// Formats a day given as a string with 2 characters.
        /// </summary>
        /// <param name="day">Day as integer to format.</param>
        /// <returns>Formatted day as a string.</returns>
        internal static string FormatDay(int day)
        {
            string dy;
            if (day < 10)
            {
                dy = "0" + day;
            }
            else
            {
                dy = day.ToString();
            }
            return dy;
        }
        
        /// <summary>
        /// Opens an URL according to the requesting Form.
        /// </summary>
        /// <param name="FID">Form ID.</param>
        /// <param name="lb_link">Label to be updated.</param>
        internal static void OpenLink(int FID, LinkLabel lb_link)
        {
            try
            {
                lb_link.LinkVisited = true;
                string url = "";
                switch (FID)
                {
                    case 0:
                        MessageBox.Show("Formulario genérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    case 1:
                        url = "https://www.omie.es/es/market-results/daily/average-final-prices/hourly-price-consumers?scope=daily&date=2023-01-01";
                        break;
                    case 2:
                        url = "https://www.omie.es/es/market-results/daily/average-final-prices/hourly-price-consumers?scope=daily&date=2023-01-01";
                        break;
                    case 3:
                        url = "https://www.omie.es/es/market-results/daily/daily-market/daily-hourly-price?scope=daily&date=2023-01-01";
                        break;
                    case 4:
                        url = "https://www.omie.es/es/market-results/daily/daily-market/daily-hourly-price?scope=daily&date=2023-01-01";
                        break;
                    case 5:
                        url = "https://www.esios.ree.es/es/descargas?date_type=publicacion&start_date=01-09-2022&end_date=12-01-2023";
                        break;
                }
                System.Diagnostics.Process.Start(new ProcessStartInfo() { FileName = url, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido abrir el enlace.\n"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Shows the directory selection dialog. If the result is OK, updates the corresponding label and tooltip.
        /// </summary>
        /// <param name="fb_directory">Dialog to be shown.</param>
        /// <param name="lb_bt_downloadDir">Label to be updated.</param>
        /// <param name="tt_folder">ToolTip to be updated.</param>
        internal static void DownloadDir(FolderBrowserDialog fb_directory, Label lb_bt_downloadDir, ToolTip tt_folder)
        {
            fb_directory.ShowNewFolderButton = true;
            fb_directory.InitialDirectory = currDir;
            if (fb_directory.ShowDialog() == DialogResult.OK)
            {
                lb_bt_downloadDir.Text = fb_directory.SelectedPath;
                tt_folder.SetToolTip(lb_bt_downloadDir, lb_bt_downloadDir.Text);
                currDir = fb_directory.SelectedPath;
            }
        }
        internal static void DLEnabler(object sender, Button bt_downloadDir, Label lb_bt_downloadDir)
        {
            CheckBox ch = (CheckBox)sender;
            if (ch.Checked)
            {
                bt_downloadDir.Enabled = true;
                lb_bt_downloadDir.Enabled = true;
            }
            else
            {
                bt_downloadDir.Enabled = false;
                lb_bt_downloadDir.Enabled = false;
            }
        }
        internal static void FileDest(SaveFileDialog sf_file, Label lb_bt_fileDest, ToolTip tt_file)
        {
            sf_file.Filter = "CSV file (*.csv)|*.csv|All files (*.*)|*.*";
            sf_file.RestoreDirectory = true;
            if (sf_file.ShowDialog() == DialogResult.OK)
            {
                lb_bt_fileDest.Text = sf_file.FileName;
                tt_file.SetToolTip(lb_bt_fileDest, lb_bt_fileDest.Text);
            }
        }
        /// <summary>
        /// Checks if an entered start date is valid. Current criteria: Valid if later than 1/1/2018.
        /// </summary>
        /// <param name="ca">Date to validate.</param>
        /// <returns>True if the date is valid, False otherwise.</returns>
        internal static bool IsValidCalendarStart(DateTimePicker ca)
        {
            if (DateTime.Compare(ca.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// </summary>
        /// <param name="ca">Date to validate.</param>
        /// <returns>True if the date is valid, False otherwise.</returns>
        internal static bool IsValidCalendarEnd(DateTimePicker ca)
        {
            if (DateTime.Compare(ca.Value, DateTime.Today) >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Checks if an entered start date is valid.
        /// Current criteria: Valid if earlier than [Today] and later than 1-1-2018.
        /// </summary>
        /// <param name="ca_date_start"></param>
        /// <param name="ep_error"></param>
        internal static void ValidateStart(DateTimePicker ca_date_start, ErrorProvider ep_error)
        {
            string err = "";
            if (DateTime.Compare(ca_date_start.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                err = err + "La fecha inicial debe ser posterior a 1-1-2018. ";
            }
            if (DateTime.Compare(ca_date_start.Value, DateTime.Today) >= 0)
            {
                err = err + "La fecha inicial debe ser previa a [" + DateTime.Today.ToString() + "]. ";
            }
            ep_error.SetError(ca_date_start, err);
        }

        /// <summary>
        /// Checks if an entered end date is valid. 
        /// Current criteria: Valid if earlier than [Today] and later than 1-1-2018.
        /// </summary>
        /// <param name="ca_date_end"></param>
        /// <param name="ep_error"></param>
        internal static void ValidateEnd(DateTimePicker ca_date_start, DateTimePicker ca_date_end, ErrorProvider ep_error)
        {
            string err = "";
            if (DateTime.Compare(ca_date_end.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                err = err + "La fecha final debe ser posterior a 1-1-2018. ";
            }
            if (DateTime.Compare(ca_date_end.Value, DateTime.Today) >= 0)
            {
                err = err + "La fecha final debe ser previa a [" + DateTime.Today.ToString() + "]. ";
            }
            if (DateTime.Compare(ca_date_start.Value, ca_date_end.Value) > 0)
            {
                err = err + "La fecha inicial no puede ser posterior a la fecha final.";
            }
            ep_error.SetError(ca_date_end, err);
        }
        internal static Dictionary<string, object> InitFields(int FID, DateTime start, DateTime end, string file, string download, bool keep, bool process)
        {
            Dictionary<string, object> fields = new Dictionary<string, object>();
            fields.Add("FID", FID);
            fields.Add("start", start);
            fields.Add("end", end);
            fields.Add("file", file);
            fields.Add("download", download);
            fields.Add("keep", keep);
            fields.Add("process", process);
            return fields;
        }
        internal static Dictionary<string, object> InitFields(int FID, DateTime start, DateTime end, string download, bool keep, bool unzip)
        {
            Dictionary<string, object> fields = new Dictionary<string, object>();
            fields.Add("FID", FID);
            fields.Add("start", start);
            fields.Add("end", end);
            fields.Add("download", download);
            fields.Add("keep", keep);
            fields.Add("unzip", unzip);
            return fields;
        }
    }
}
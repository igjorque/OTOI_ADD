using log4net;
using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Module.Download;
using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Asset;
using OTOI_ADD.View.ESIOS;
using OTOI_ADD.View.Generic.ESIOS;
using OTOI_ADD.View.Generic.OMIE;
using OTOI_ADD.View.OMIE;
using System.Diagnostics;
using System.Security.Cryptography;

namespace OTOI_ADD.Code.Module.Function
{
    internal static class FormManager
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Manages the click event on an accept button.
        /// </summary>
        /// <param name="f">Click event source form</param>
        /// <param name="FID">Form ID</param>
        internal static void FormAccept(Form f, int FID)
        {
            logger.Info(LOG.FORM_MANAGE);

            // Save user input to config
            SaveParams(f, FID);
            if (OTOI_ADD.Properties.Settings.Default.CFG_SAVE) AppConfigManager.Save();

            // Manage forms
            switch (FID)
            {
                case 1: // HPC
                case 3: // HM
                    ManageDayOMIE(f);
                    break;
                case 2: // HPCM
                case 4: // HMM
                    if (PreventMultiDownloadEvent(f)) ManageRangeOMIE(f);
                    break;
                case 5: // C2L
                    ManageMonthESIOS(f);
                    break;
                case 6: // C2LM
                    ManageMonthOMIE(f);
                    break;
            }
        }

        private static void SaveParams(Form f, int FID)
        {
            if(f is OGenericDay)
            {
                OGenericDay ogd = (OGenericDay)f;
                OTOI_ADD.Properties.Settings.Default.DAY = ogd.CADay.Value;
                OGenericParams(ogd);
            } 
            else if (f is OGenericMonth)
            {
                OGenericMonth ogm = (OGenericMonth)f;
                OTOI_ADD.Properties.Settings.Default.MONTH = ogm.MPMonth.Value;
                OGenericParams(ogm);
            }
            else if (f is OGenericRange)
            {
                OGenericRange ogr = (OGenericRange)f;
                OTOI_ADD.Properties.Settings.Default.START = ogr.CAStart.Value;
                OTOI_ADD.Properties.Settings.Default.END = ogr.CAEnd.Value;
                OGenericParams(ogr);
            }
            else if (f is EGenericMonth)
            {
                EGenericMonth egm = (EGenericMonth)f;
                OTOI_ADD.Properties.Settings.Default.DAY = egm.MPMonth.Value;
                EGenericParams(egm);
            }
        }

        /// <summary>
        /// Saves the common OMIE forms params.
        /// </summary>
        /// <param name="fo">OMIE form</param>
        private static void OGenericParams(OGeneric fo)
        {
            // DL
            OTOI_ADD.Properties.Settings.Default.DIRECTORY = fo.LBFolder.Text;
            // PR
            OTOI_ADD.Properties.Settings.Default.O_PROCESS = fo.CBProcess.Checked;
            // KP
            OTOI_ADD.Properties.Settings.Default.O_KEEP = fo.CBKeep.Checked;
        }

        /// <summary>
        /// Saves the common ESIOS forms params.
        /// </summary>
        /// <param name="fe">ESIOS form</param>
        private static void EGenericParams(EGeneric fe)
        {
            // DL
            OTOI_ADD.Properties.Settings.Default.DIRECTORY = fe.LBFolder.Text;
            // UZ
            OTOI_ADD.Properties.Settings.Default.E_UNZIP = fe.CBUnzip.Checked;
            // PR
            OTOI_ADD.Properties.Settings.Default.E_PROCESS = fe.CBProcess.Checked;
            // KP
            OTOI_ADD.Properties.Settings.Default.E_KEEP = fe.CBKeep.Checked;
        }

        /// <summary>
        /// Prevents a download if it's too big (more than 31 days).
        /// Asks for user confirmation.
        /// </summary>
        /// <param name="f">Source form</param>
        /// <returns>True if OK or accepted, False otherwise</returns>
        private static bool PreventMultiDownloadEvent(Form f)
        {
            bool r = false;
            OGenericRange m = (OGenericRange)f;
            int diff = Auxiliary.DaysDiff(m.Start, m.End);
            if (diff > 31)
            { // Date range too extense
                DialogResult dr = MessageBox.Show($"Va a descargar {diff} días en datos. ¿Está seguro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes) r = true;
            }
            else { r = true; }
            return r;
        }

        /// <summary>
        /// Manages the click event on an accept button for an OMIEs SingleGeneric type form.
        /// </summary>
        /// <param name="f">Click event source form</param>
        private static void ManageDayOMIE(Form f)
        {
            // Cast parameter
            OGenericDay sgf = (OGenericDay)f;
            // Init input
            InputOMIE inp = new(sgf);
            // Download file
            DL_OMIE.ManageDL(inp);
            // Close form
            f.Close();
        }

        /// <summary>
        /// Manages the click event on an accept button for an OMIEs MultiGeneric type form.
        /// </summary>
        /// <param name="f">Click event source form</param>
        private static void ManageRangeOMIE(Form f)
        {
            // Cast parameter
            OGenericRange mgf = (OGenericRange)f;
            // Init input
            InputOMIE inp = new(mgf);
            // Download files
            DL_OMIE.ManageDL(inp);
            // Close form
            f.Close();
        }

        /// <summary>
        /// Manages the click event on an accept button for an OMIEs MonthGeneric type form.
        /// </summary>
        /// <param name="f"></param>
        private static void ManageMonthOMIE(Form f)
        {
            // Cast parameter
            HMT hmt = (HMT)f;
            // Init input
            InputOMIE inp = new(hmt);
            // Download files
            DL_OMIE.ManageDL(inp);
            // Close form
            f.Close();
        }

        /// <summary>
        /// Manages the click event on an accept button for an ESIOSs MultiGeneric type form.
        /// </summary>
        /// <param name="f">Click event source form</param>
        private static void ManageMonthESIOS(Form f)
        {
            // Cast parameter
            C2L c2l = (C2L)f;
            // Init input
            InputESIOS inp = new(c2l);
            // Download files
            DL_ESIOS.ManageDL(inp);
            // Close form
            f.Close();
        }

        /// <summary>
        /// Enables or disables some controls based on an OMIE form process CheckBox status.
        /// </summary>
        /// <param name="cb_process">Object representing the sender CheckBox. TODO: update</param>
        /// <param name="cb_keep">Control to enable or disable</param>
        /// <param name="bt_file">Control to enable or disable</param>
        /// <param name="lb_file">Control to enable or disable</param>
        internal static void OP_Enabler(CheckBox cb_process, CheckBox cb_keep, Button bt_file, Label2 lb_file)
        {
            if (cb_process != null && cb_process.Checked)
            {
                cb_keep.Enabled = true;
                bt_file.Enabled = true;
                lb_file.Enabled = true;
            }
            else
            {
                cb_keep.Enabled = false;
                bt_file.Enabled = false;
                lb_file.Enabled = false;
            }
        }

        /// <summary>
        /// Enables or disables some controls based on an ESIOS form process CheckBox status.
        /// </summary>
        /// <param name="cb_process">Object representing the sender CheckBox.</param>
        /// <param name="bt_file">Control to enable or disable</param>
        /// <param name="lb_file">Control to enable or disable</param>
        internal static void EP_Enabler(CheckBox cb_process, Button bt_file, Label2 lb_file)
        {
            if (cb_process != null && cb_process.Checked)
            {
                bt_file.Enabled = true;
                lb_file.Enabled = true;
            }
            else
            {
                bt_file.Enabled = false;
                lb_file.Enabled = false;
            }
        }

        /// <summary>
        /// Enables or disables some controls based on an ESIOS form unzip CheckBox status.
        /// </summary>
        /// <param name="cb_unzip">Object representing the sender CheckBox. TODO: update</param>
        /// <param name="cb_process">Object representing the sender CheckBox. TODO: update</param>
        /// <param name="cb_keep">Control to enable or disable</param>
        /// <param name="bt_file">Control to enable or disable</param>
        /// <param name="lb_file">Control to enable or disable</param>
        internal static void EU_Enabler(CheckBox cb_unzip, CheckBox cb_process, CheckBox cb_keep, Button bt_file, Label2 lb_file)
        {
            if (cb_unzip.Checked)
            {
                cb_keep.Enabled = true;
                cb_process.Enabled = true;
                if (cb_process.Checked)
                {
                    bt_file.Enabled = true;
                    lb_file.Enabled = true;
                }
            }
            else
            {
                cb_keep.Enabled = false;
                cb_process.Enabled = false;
                bt_file.Enabled = false;
                lb_file.Enabled = false;
            }
        }

        /// <summary>
        /// Manages a link opening based on the form's ID.
        /// </summary>
        /// <param name="FID">Form ID</param>
        /// <param name="lb_link">Link clicked</param>
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
                    case 1: // HPC
                    case 2: // HPCM
                        url = "https://www.omie.es/es/market-results/daily/average-final-prices/hourly-price-consumers?scope=daily&date=2023-01-01";
                        break;
                    case 3: // HM
                    case 4: // HMM
                        url = "https://www.omie.es/es/market-results/daily/daily-market/daily-hourly-price?scope=daily&date=2023-01-01";
                        break;
                    case 5: // C2L
                        url = "https://www.esios.ree.es/es/descargas?date_type=publicacion&start_date=01-09-2022&end_date=12-01-2023";
                        break;
                    case 6: // HMT
                        url = "https://www.omie.es/es/market-results/monthly/daily-market/hourly-market?scope=monthly&year=2023&month=1&data=5";
                        break;
                }
                System.Diagnostics.Process.Start(new ProcessStartInfo() { FileName = url, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                logger.Warn("No se ha podido abrir el enlace.");
                MessageBox.Show("No se ha podido abrir el enlace.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Manages the directory selection dialog.
        /// </summary>
        /// <param name="fb_directory">Dialog to show</param>
        /// <param name="lb_download">Label to update</param>
        /// <param name="tt_folder">Tooltip to update</param>
        internal static void DownloadDir(FolderBrowserDialog fb_directory, Label2 lb_download, ToolTip tt_folder)
        {
            fb_directory.ShowNewFolderButton = true;
            fb_directory.InitialDirectory = OTOI_ADD.Properties.Settings.Default.DIRECTORY;
            if (fb_directory.ShowDialog() == DialogResult.OK)
            {
                lb_download.Text = fb_directory.SelectedPath;
                tt_folder.SetToolTip(lb_download, lb_download.Text);
                OTOI_ADD.Properties.Settings.Default.DIRECTORY = fb_directory.SelectedPath;
            }
        }

        /// <summary>
        /// Manages the file destination dialog.
        /// </summary>
        /// <param name="sf_file">Dialog to show</param>
        /// <param name="lb_file">Label to update</param>
        /// <param name="tt_file">Tooltip to update</param>
        internal static void DownloadFil(SaveFileDialog sf_file, Label2 lb_file, ToolTip tt_file)
        {
            sf_file.InitialDirectory = OTOI_ADD.Properties.Settings.Default.DIRECTORY;
            sf_file.Filter = "Archivos XLS | *.xls";
            sf_file.DefaultExt = "xls";

            if (sf_file.ShowDialog() == DialogResult.OK)
            {
                lb_file.Text = Path.GetFileName(sf_file.FileName);
                tt_file.SetToolTip(lb_file, sf_file.FileName);
            }
        }

        /// <summary>
        /// Manages the downloaded files deletion.
        /// </summary>
        internal static void Delete(List<string> files, ProgressBar pb_progress)
        {
            if (files != null)
            {
                pb_progress.Maximum = files.Count;
                pb_progress.Value = 0;
                foreach (string f in files)
                {
                    if (File.Exists(f))
                    {
                        try
                        {
                            File.Delete(f);
                            pb_progress.PerformStep();
                        }
                        catch (IOException e)
                        {
                            logger.Error(LOG.MANAGE_DEL + f);
                            MessageBox.Show(LOG.MANAGE_DEL + f);
                        }
                    }
                }
            }
        }
    }
}
using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Module.Download;
using OTOI_ADD.View.Asset;
using OTOI_ADD.View.ESIOS;
using OTOI_ADD.View.Generic;
using OTOI_ADD.Code.Variable;
using System.Diagnostics;
using OTOI_ADD.View.OMIE;

namespace OTOI_ADD.Code.Function
{
    internal static class FormManager
    {
        /// <summary>
        /// Manages the click event on an accept button.
        /// </summary>
        /// <param name="f">Click event source form</param>
        /// <param name="FID">Form ID</param>
        internal static void FormAccept(Form f, int FID)
        {
            // TODO: check saving
            // Save user input to config
            //AppConfigManager.Save();
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
                    ManageSingleESIOS(f);
                    break;
                case 6: // C2LM
                    ManageMonthOMIE(f); // TODO: revisar, refactorizar
                    break;
            }
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
            DL_OMIE.DLSwitch(inp);
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
            DL_OMIE.DLSwitch(inp);
            // Close form
            f.Close();
        }

        // TODO: check
        /// <summary>
        /// Manages the click event on an accept button for an OMIEs MonthGeneric type form.
        /// </summary>
        /// <param name="f"></param>
        private static void ManageMonthOMIE(Form f)
        {
            
            // Cast parameter
            HMT hmt = (HMT) f;
            // Init input
            InputOMIE inp = new(hmt);
            // Download files
            DL_OMIE.DLSwitch(inp);
            // Close form
            f.Close();
        }

        /// <summary>
        /// Manages the click event on an accept button for an ESIOSs MultiGeneric type form.
        /// </summary>
        /// <param name="f">Click event source form</param>
        private static void ManageSingleESIOS(Form f)
        {
            // Cast parameter
            C2L c2l = (C2L)f;
            // Init input
            InputESIOS inp = new(c2l);
            // Download file
            DL_ESIOS.ProcessDL(inp);
            // Process file
            //if (inp.Process) ProcessorESIOS.Process();
            // Delete? downloaded file
            // TODO: Check this code
            if (inp.Process && !inp.KeepDL) Delete();
            // Close form
            f.Close();
        }

        /// <summary>
        /// Enables or disables some controls based on a CheckBox's status.
        /// </summary>
        /// <param name="cb_process">Object representing the sender CheckBox. TODO: update</param>
        /// <param name="cb_keepDownload">Control to enable or disable</param>
        /// <param name="bt_fileDest">Control to enable or disable</param>
        /// <param name="lb_bt_fileDest">Control to enable or disable</param>
        internal static void DLEnabler(CheckBox cb_process, CheckBox cb_keepDownload, Button bt_fileDest, Label lb_bt_fileDest)
        {
            if (cb_process != null && cb_process.Checked)
            {
                cb_keepDownload.Enabled = true;
                if (bt_fileDest.Visible)
                {
                    bt_fileDest.Enabled = true;
                    lb_bt_fileDest.Enabled = true;
                }

            }
            else
            {
                cb_keepDownload.Enabled = false;
                bt_fileDest.Enabled = false;
                lb_bt_fileDest.Enabled = false;
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
                Process.Start(new ProcessStartInfo() { FileName = url, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido abrir el enlace.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Manages the directory selection dialog.
        /// </summary>
        /// <param name="fb_directory">Dialog to show</param>
        /// <param name="lb_bt_downloadDir">Label to update</param>
        /// <param name="tt_folder">Tooltip to update</param>
        internal static void DownloadDir(FolderBrowserDialog fb_directory, Label lb_bt_downloadDir, ToolTip tt_folder)
        {
            fb_directory.ShowNewFolderButton = true;
            fb_directory.InitialDirectory = VAR.CUR_DIR;
            if (fb_directory.ShowDialog() == DialogResult.OK)
            {
                lb_bt_downloadDir.Text = fb_directory.SelectedPath;
                tt_folder.SetToolTip(lb_bt_downloadDir, lb_bt_downloadDir.Text);
                VAR.CUR_DIR = fb_directory.SelectedPath;
            }
        }

        /// <summary>
        /// Manages the file destination dialog.
        /// </summary>
        /// <param name="sf_file">Dialog to show</param>
        /// <param name="lb_bt_file">Label to update</param>
        /// <param name="tt_file">Tooltip to update</param>
        internal static void DownloadFil(SaveFileDialog sf_file, Label lb_bt_file, ToolTip tt_file)
        {
            sf_file.InitialDirectory = VAR.CUR_DIR;
            sf_file.Filter = "Archivos XLS | *.xls";
            sf_file.DefaultExt = "xls";

            if (sf_file.ShowDialog() == DialogResult.OK)
            {
                lb_bt_file.Text = Path.GetFileName(sf_file.FileName);
                tt_file.SetToolTip(lb_bt_file, sf_file.FileName);
            }
        }

        /// <summary>
        /// Manages the downloaded files deletion.
        /// </summary>
        internal static void Delete()
        {
            if (ProgressDialog.FILES != null)
            {
                foreach (string f in ProgressDialog.FILES)
                {
                    if (File.Exists(f))
                    {
                        try
                        {
                            File.Delete(f);
                        }
                        catch (IOException e)
                        {
                            MessageBox.Show(e.StackTrace);
                            // TODO: Log exception in [FormManager.Delete]
                        }
                    }
                }
            }
        }
    }
}
using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Module.Download;
using OTOI_ADD.Code.Module.Process;
using OTOI_ADD.View.Asset;
using OTOI_ADD.View.Generic;
using System.Diagnostics;

namespace OTOI_ADD.Code.Function
{
    internal static class FormManager
    {

        /// <summary>
        /// Holds the current selected directory.
        /// </summary>
        internal static string CURR_DIR = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        internal static string CURR_FIL = "";
        internal static DateTime STR = DateTime.Today.AddDays(-2);
        internal static DateTime END = DateTime.Today.AddDays(-1);

        /// <summary>
        /// Manages the click event on an accept button.
        /// </summary>
        /// <param name="f">Click event source form</param>
        /// <param name="FID">Form ID</param>
        internal static void FormAccept(Form f, int FID)
        {
            switch (FID)
            {
                case 1: // HPC
                case 3: // HM
                    ManageSingleOMIE(f);
                    break;
                case 2: // HPCM
                case 4: // HMM
                    ManageMultiOMIE(f);
                    break;
                case 5: // C2L
                    ManageSingleESIOS(f);
                    break;
            }
        }

        /// <summary>
        /// Manages the click event on an accept button for an OMIEs SingleGeneric type form.
        /// </summary>
        /// <param name="f">Click event source form</param>
        private static void ManageSingleOMIE(Form f)
        {
            // Cast parameter
            SingleGeneric sgf = (SingleGeneric)f;
            // Init input
            InputOMIE inp = new (sgf);
            // Download file
            DL_OMIE.DLSwitch(inp);
            // Close form
            f.Close();
        }

        /// <summary>
        /// Manages the click event on an accept button for an OMIEs MultiGeneric type form.
        /// </summary>
        /// <param name="f">Click event source form</param>
        private static void ManageMultiOMIE(Form f)
        {
            // Cast parameter
            MultiGeneric mgf = (MultiGeneric)f;
            // Init input
            InputOMIE inp = new (mgf);
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
            SingleGeneric sgf = (SingleGeneric)f;
            // Init input
            InputESIOS inp = new (sgf);
            // Download file
            DL_ESIOS.ProcessDL(inp);
            // Process file
            //if (inp.Process) ProcessorESIOS.Process();
            // Delete? downloaded file
            if (inp.Process && !inp.KeepDL) Delete();
            // Close form
            f.Close();
        }

        /// <summary>
        /// Enables or disables some controls based on a CheckBox's status.
        /// </summary>
        /// <param name="sender">Object representing the sender CheckBox</param>
        /// <param name="cb_keepDownload">Control to enable or disable</param>
        /// <param name="bt_fileDest">Control to enable or disable</param>
        /// <param name="lb_bt_fileDest">Control to enable or disable</param>
        internal static void DLEnabler(object? sender, CheckBox cb_keepDownload, Button bt_fileDest, Label lb_bt_fileDest)
        {
            CheckBox ch;
            if (sender == null)
            {
                ch = new CheckBox();
            } else
            {
                ch = (CheckBox) sender;
            }
            if (ch != null && ch.Checked)
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
                }
                System.Diagnostics.Process.Start(new ProcessStartInfo() { FileName = url, UseShellExecute = true });
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
            fb_directory.InitialDirectory = CURR_DIR;
            if (fb_directory.ShowDialog() == DialogResult.OK)
            {
                lb_bt_downloadDir.Text = fb_directory.SelectedPath;
                tt_folder.SetToolTip(lb_bt_downloadDir, lb_bt_downloadDir.Text);
                CURR_DIR = fb_directory.SelectedPath;
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
            if (CURR_FIL != "")
            {
                int index = CURR_FIL.LastIndexOf("\\"), length = CURR_FIL.Length - index;
                sf_file.InitialDirectory = CURR_FIL.Remove(index, length);
                sf_file.FileName = CURR_FIL.Split("\\").Last();
            } else
            {
                sf_file.InitialDirectory = CURR_DIR;
                sf_file.FileName = "ejemplo.xls";
            }

            sf_file.Filter = "Archivos XLS | *.xls";
            sf_file.DefaultExt = "xls";

            if (sf_file.ShowDialog() == DialogResult.OK)
            {
                lb_bt_file.Text = Path.GetFileName(sf_file.FileName);
                tt_file.SetToolTip(lb_bt_file, sf_file.FileName);
                CURR_FIL = sf_file.FileName;
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
                        File.Delete(f);
                    }
                }
            }
        }
    }
}
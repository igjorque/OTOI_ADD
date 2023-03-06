using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Module.Download;
using OTOI_ADD.View.Generic;
using System.Diagnostics;

namespace OTOI_ADD.Code.Function
{
    internal static class FormManager
    {

        /// <summary>
        /// Holds the current selected directory.
        /// </summary>
        internal static string currDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        internal static void FormAccept(Form f, int FID)
        {
            switch (FID)
            {
                case 1: // HPC
                case 3: // HM
                    ManageSingleO(f);
                    break;
                case 2: // HPCM
                case 4: // HMM
                    ManageMultiO(f);
                    break;
                case 5: // C2L
                    ManageSingleE(f);
                    break;
            }
        }

        private static void ManageSingleO(Form f)
        {
            SingleGeneric sgf = (SingleGeneric)f;
            InputOMIE inp = new InputOMIE(sgf);
            DL_OMIE.DLSwitch(inp);
            f.Close();
        }

        private static void ManageMultiO(Form f)
        {
            MultiGeneric mgf = (MultiGeneric)f;
            InputOMIE inp = new InputOMIE(mgf);
            DL_OMIE.DLSwitch(inp);
            f.Close();
        }

        private static void ManageSingleE(Form f)
        {
            SingleGeneric sgf = (SingleGeneric)f;
            InputESIOS inp = new InputESIOS(sgf);
            DL_ESIOS.ProcessDL(inp);
            f.Close();
        }

        internal static void DLEnabler(object sender, CheckBox cb_keepDownload, Button bt_fileDest, Label lb_bt_fileDest)
        {
            CheckBox ch = (CheckBox)sender;
            if (ch.Checked)
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

    }
}

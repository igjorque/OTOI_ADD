using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Module.Download;
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
        internal static string CURR_FIL = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

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

        private static void ManageSingleOMIE(Form f)
        {
            SingleGeneric sgf = (SingleGeneric)f;
            InputOMIE inp = new (sgf);
            DL_OMIE.DLSwitch(inp);
            // Process files
            Delete(inp);
            f.Close();
        }

        private static void ManageMultiOMIE(Form f)
        {
            MultiGeneric mgf = (MultiGeneric)f;
            InputOMIE inp = new (mgf);
            DL_OMIE.DLSwitch(inp);
            //Process files
            Delete(inp);
            f.Close();
        }

        private static void ManageSingleESIOS(Form f)
        {
            SingleGeneric sgf = (SingleGeneric)f;
            InputESIOS inp = new (sgf);
            DL_ESIOS.ProcessDL(inp);
            //Process files
            Delete(inp);
            f.Close();
        }

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
            fb_directory.InitialDirectory = CURR_DIR;
            if (fb_directory.ShowDialog() == DialogResult.OK)
            {
                lb_bt_downloadDir.Text = fb_directory.SelectedPath;
                tt_folder.SetToolTip(lb_bt_downloadDir, lb_bt_downloadDir.Text);
                CURR_DIR = fb_directory.SelectedPath;
            }
        }

        internal static void DownloadFil(SaveFileDialog sf_file, Label lb_bt_file, ToolTip tt_file)
        {
            if (CURR_FIL != Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
            {
                int index = CURR_FIL.LastIndexOf("\\"), length = CURR_FIL.Length - index;
                sf_file.InitialDirectory = CURR_FIL.Remove(index, length);
                sf_file.FileName = CURR_FIL.Split("\\").Last()+".csv";
            } else
            {
                sf_file.InitialDirectory = CURR_FIL;
            }

            sf_file.Filter = "CSV Files | *.csv";
            sf_file.DefaultExt = "csv";

            if (sf_file.ShowDialog() == DialogResult.OK)
            {
                lb_bt_file.Text = sf_file.FileName + ".csv";
                tt_file.SetToolTip(lb_bt_file, sf_file.FileName);
                CURR_FIL = sf_file.FileName;
            }
        }

        internal static void Delete(Input inp)
        {
            if (inp.Process && !inp.KeepDL)
            {
                if(ProgressDialog.FILES != null)
                {
                    foreach(string f in ProgressDialog.FILES)
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
}

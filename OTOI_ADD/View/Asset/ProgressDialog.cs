using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Module.Download;
using OTOI_ADD.Code.Module.Function;
using OTOI_ADD.Code.Module.Process;
using OTOI_ADD.Code.Variable;
using System.IO.Compression;
using System.Reflection;

namespace OTOI_ADD.View.Asset
{
    /// <summary>
    /// ProgressDialog
    /// </summary>
    public partial class ProgressDialog : Form
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        internal static List<string> FILES = new();

        /// <summary>
        /// Base empty constructor.
        /// </summary>
        public ProgressDialog()
        {
            InitializeComponent();
            FILES = new();
        }

        /// <summary>
        /// Builds a ProgressDialog form and starts the OMIE data download process.
        /// </summary>
        /// <param name="inp">User input</param>
        /// <param name="l_uri">URI list</param>
        internal ProgressDialog(InputOMIE inp, List<Uri> l_uri) : this()
        {
            logger.Info(LOG.PROGRESS_BUILD_OMIE);
            DLProgress_OMIE(inp, l_uri);
        }

        /// <summary>
        /// Builds a ProgressDialog form and starts the ESIOS data download process.
        /// </summary>
        /// <param name="inp">User input</param>
        /// <param name="uri">URI list</param>
        /// <param name="filename"></param>
        internal ProgressDialog(InputESIOS inp, Uri uri, string filename) : this()
        {
            logger.Info(LOG.PROGRESS_BUILD_ESIOS);
            DLProgress_ESIOS(inp, uri, filename);
        }

        /// <summary>
        /// Manages the accept button click event.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void Bt_accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Manages the download process.
        /// </summary>
        /// <param name="inp">User input</param>
        /// <param name="l_uri">URI list</param>
        private async void DLProgress_OMIE(InputOMIE inp, List<Uri> l_uri)
        {
            logger.Info(LOG.PROGRESS_OMIE);
            DateTime daux = DateTime.Now;
            string file = "", auxpath = "";
            this.pb_progress.Minimum = 0;
            this.pb_progress.Maximum = l_uri.Count;
            this.pb_progress.Value = 0;
            this.pb_progress.Step = 1;

            // Prevent user from flooding the selected directory (default: desktop)
            auxpath = inp.DestDL + Path.DirectorySeparatorChar + "OMIE_" + daux.Day + "-" + daux.Month + "-" + daux.Year + "_" + daux.Hour + "-" + daux.Minute + "-" + daux.Second;
            Directory.CreateDirectory(auxpath);
            inp.DestDL = auxpath;

            // Download files
            foreach (Uri uri in l_uri)
            {
                file = FName(uri.ToString().Split("/").Last());
                this.lb_url_value.Text = file;
                file = inp.DestDL + Path.DirectorySeparatorChar + file;
                Downloader.Download(file, uri);
                FILES.Add(file);
                this.pb_progress.PerformStep();
                await Task.Delay(10);
            }
            this.lb_download.Text = "";
            this.lb_url_value.Text = "";
            this.lb_url.Text = "";

            // Process files
            if (inp.Process)
            {
                this.Text = "Procesando";
                this.lb_download.Text = "Procesando los datos descargados...";
                ProcessorOMIE.Process(FILES, this.pb_progress);
            }

            // Delete? downloaded files
            if (inp.Process && !inp.KeepDL)
            {
                this.Text = "Eliminando";
                this.lb_download.Text = "Eliminando archivos descargados...";
                FormManager.Delete(ProgressDialog.FILES, this.pb_progress);
                pb_progress.Maximum = 1;
                pb_progress.Value = 0;
                Directory.Delete(inp.DestDL);
                pb_progress.PerformStep();
            }
            this.Text = "Finalizado";
            this.lb_download.Text = "Operación completada con éxito.";
            this.lb_url.Text = "";
            this.bt_accept.Enabled = true;
            this.bt_accept.Visible = true;
        }

        /// <summary>
        /// Manages the download process.
        /// </summary>
        /// <param name="inp">User input</param>
        /// <param name="uri">Download URI</param>
        /// <param name="filename">Destination filename</param>
        private async void DLProgress_ESIOS(InputESIOS inp, Uri uri, string filename)
        {
            logger.Info(LOG.PROGRESS_ESIOS);
            List<string> zipContent = new();
            string file = "", auxpath = "";
            this.pb_progress.Minimum = 0;
            this.pb_progress.Maximum = 1;
            this.pb_progress.Value = 0;
            this.pb_progress.Step = 1;

            // Prevent user from flooding the selected directory (default: desktop)
            auxpath = inp.DestDL + Path.DirectorySeparatorChar + filename;
            Directory.CreateDirectory(auxpath);
            inp.DestDL = auxpath;

            // Build file path
            this.lb_url_value.Text = "C2 liquicomun - " + inp.DateStart.Month + "/" + inp.DateStart.Year;
            file = inp.DestDL + Path.DirectorySeparatorChar + filename;

            // Download file
            Downloader.Download(file, uri);
            FILES.Add(file);

            this.pb_progress.PerformStep();
            await Task.Delay(25);

            using (ZipArchive archive = ZipFile.OpenRead(file))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    zipContent.Add(inp.DestDL + Path.DirectorySeparatorChar + entry.Name);
                }
            }

            // Unzip?
            if (inp.Unzip)
            {
                this.lb_download.Text = "Extrayendo archivos...";
                ZipFile.ExtractToDirectory(file, inp.DestDL);

                // Keep?
                if (!inp.KeepDL)
                {
                    this.lb_download.Text = "Eliminando archivo...";
                    File.Delete(file);
                }

                // Process?
                if (inp.Process)
                {
                    this.lb_download.Text = "Procesando...";
                    // TODO: Process ESIOS files.
                    if (MessageBox.Show("¿Desea eliminar los archivos descomprimidos?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.lb_download.Text = "Eliminando archivos descomprimidos...";
                        foreach (string zf in zipContent)
                        {
                            File.Delete(zf);
                        }
                    }
                }
            }
            this.Text = "Finalizado";
            this.lb_download.Text = "";
            this.lb_url.Text = "";
            this.lb_url_value.TextAlign = ContentAlignment.BottomRight;
            this.lb_url_value.Text = "Operación completada con éxito.";
            this.bt_accept.Enabled = true;
            this.bt_accept.Visible = true;
        }

        /// <summary>
        /// Auxiliary - Builds OMIEs file name.
        /// </summary>
        /// <param name="file">Origin file name</param>
        /// <returns>Built file name</returns>
        private static string FName(string file)
        {
            string result = "";
            string[] aux = file.Split("_");

            if (file.Contains(GLB.HPC_URI)) // is HPC
            {
                result = "HPC_" + aux[7] + "-" + aux[5] + "-" + aux[6] + ".txt";
            }
            else if (file.Contains(GLB.HM_URI)) // is HM
            {
                result = "HM_" + aux[8] + "-" + aux[6] + "-" + aux[7] + ".txt";
            }
            else // GLB.HMT_URI - is HMT
            {
                result = "HMT_" + aux[5] + "-" + aux[6] + ".txt";
            }
            return result;
        }
    }
}

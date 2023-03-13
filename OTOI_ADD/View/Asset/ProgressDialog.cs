using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Module.Download;
using OTOI_ADD.Code.Module.Process;
using OTOI_ADD.Code.Function;

namespace OTOI_ADD.View.Asset
{
    public partial class ProgressDialog : Form
    {
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
        /// Builds a ProgressDialog form and starts the download process.
        /// </summary>
        /// <param name="inp">User input</param>
        /// <param name="l_uri">URI list</param>
        internal ProgressDialog(InputOMIE inp, List<Uri> l_uri) : this()
        {
            DLProgress_OMIE(inp, l_uri);
        }

        /// <summary>
        /// Builds a ProgressDialog form and starts the download process.
        /// </summary>
        /// <param name="inp">User input</param>
        /// <param name="uri">URI list</param>
        /// <param name="filename"></param>
        internal ProgressDialog(InputESIOS inp, Uri uri, string filename) : this()
        {
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
            string file = "";
            this.pb_progress.Minimum = 0;
            this.pb_progress.Maximum = l_uri.Count;
            this.pb_progress.Value = 0;
            this.pb_progress.Step = 1;

            foreach (Uri uri in l_uri)
            {
                file = FName(uri.ToString().Split("/").Last());
                this.lb_url_value.Text = file;
                file = inp.DestDL + Path.DirectorySeparatorChar + file;
                //file = inp.DestDL + Path.DirectorySeparatorChar + uri.ToString().Split("/").Last();//
                //this.lb_url_value.Text = uri.ToString().Split("/").Last();//
                Downloader.Download(file, uri);
                FILES.Add(file);
                this.pb_progress.PerformStep();
                await Task.Delay(25);
            }
            this.lb_url_value.Text = "";
            this.lb_url.Text = "";
            // Process file
            if (inp.Process)
            {
                this.Text = "Procesando";
                this.lb_download.Text = FormManager.CURR_FIL;
                this.pb_progress.Maximum = 1;
                this.pb_progress.Value = 0;
                ProcessorOMIE.Process(ProgressDialog.FILES, 2);
                this.pb_progress.PerformStep();
            }
            // Delete? downloaded files
            if (inp.Process && !inp.KeepDL)
            {
                this.Text = "Eliminando";
                this.lb_download.Text = "Eliminando archivos descargados...";
                this.pb_progress.Maximum = 1;
                this.pb_progress.Value = 0;
                FormManager.Delete();
                this.pb_progress.PerformStep();
            }
            this.Text = "Finalizado";
            this.lb_download.Text = "Operación completada con éxito.";
            this.lb_url.Text = "";
            this.lb_url_value.Text = "";
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
            String file = "";
            this.pb_progress.Minimum = 0;
            this.pb_progress.Maximum = 1;
            this.pb_progress.Value = 0;
            this.pb_progress.Step = 1;

            this.lb_url_value.Text = uri.ToString().Split("/").Last();
            file = inp.DestDL + Path.DirectorySeparatorChar + filename;
            Downloader.Download(file, uri);
            FILES.Add(file);
            this.pb_progress.PerformStep();
            await Task.Delay(25);

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
        private string FName(string file)
        {
            string result = "";
            string[] aux = file.Split("_");

            if (file.Contains("INT_MAJ_EV_H")) // is HPC
            {
                result = "HPC_" + aux[7] + "-" + aux[5] + "-" + aux[6] + ".txt";
            }
            else // "INT_PBC_EV_H_1" - is HM
            {
                result = "HM_" + aux[8] + "-" + aux[6] + "-" + aux[7] + ".txt";
            }

            return result;
        }
    }
}

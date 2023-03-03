using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Module.Download;

namespace OTOI_ADD.View.Asset
{
    public partial class ProgressDialog : Form
    {
        public ProgressDialog()
        {
            InitializeComponent();
        }

        internal ProgressDialog(InputOMIE inp, List<Uri> l_uri)
        {
            InitializeComponent();
            DLProgress_OMIE(inp, l_uri);
        }

        internal ProgressDialog(InputESIOS inp, Uri uri, string filename)
        {
            InitializeComponent();
            DLProgress_ESIOS(inp, uri, filename);
        }

        private void bt_accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void DLProgress_OMIE(InputOMIE inp, List<Uri> l_uri)
        {
            string file = "";
            System.Timers.Timer tm = new System.Timers.Timer(50);
            this.pb_progress.Minimum = 0;
            this.pb_progress.Maximum = l_uri.Count;
            this.pb_progress.Value = 0;
            this.pb_progress.Step = 1;

            foreach (Uri uri in l_uri)
            {
                file = inp.DestDL + Path.DirectorySeparatorChar + uri.ToString().Split("/").Last();
                this.lb_url_value.Text = uri.ToString().Split("/").Last();
                Downloader.Download(file, uri);
                this.pb_progress.PerformStep();
                await Task.Delay(50);
            }

            this.Text = "Finalizado";
            this.lb_download.Text = "";
            this.lb_url.Text = "";
            this.lb_url_value.TextAlign = ContentAlignment.BottomRight;
            this.lb_url_value.Text = "Completado";
            this.bt_accept.Enabled = true;
            this.bt_accept.Visible = true;
        }
        private async void DLProgress_ESIOS(InputESIOS inp, Uri uri, string filename)
        {
            System.Timers.Timer tm = new System.Timers.Timer(50);
            this.pb_progress.Minimum = 0;
            this.pb_progress.Maximum = 1;
            this.pb_progress.Value = 0;
            this.pb_progress.Step = 1;

            this.lb_url_value.Text = uri.ToString().Split("/").Last();
            Downloader.Download(inp.DestDL + Path.DirectorySeparatorChar + filename, uri);
            this.pb_progress.PerformStep();
            await Task.Delay(50);

            this.Text = "Finalizado";
            this.lb_download.Text = "";
            this.lb_url.Text = "";
            this.lb_url_value.TextAlign = ContentAlignment.BottomRight;
            this.lb_url_value.Text = "Completado";
            this.bt_accept.Enabled = true;
            this.bt_accept.Visible = true;
        }
    }
}

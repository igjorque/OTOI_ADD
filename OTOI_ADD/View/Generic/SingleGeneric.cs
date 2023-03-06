using OTOI_ADD.Code.Function;
using OTOI_ADD.View.Asset;

namespace OTOI_ADD.View.Generic
{
    public partial class SingleGeneric : Form
    {
        private int fid;
        internal int FID { get => this.fid; }
        internal string FormName { get => this.Text; set => this.Text = value; }
        internal string Title { get => this.uc_f.lb_title.Text; set => this.uc_f.lb_title.Text = value; }
        internal LinkLabel Link { get => this.uc_f.lb_link; set => this.uc_f.lb_link = value; }
        internal string Label { get => this.uc_f.lb_date.Text; set => this.uc_f.lb_date.Text = value; }
        internal DateTime Start { get => this.uc_f.ca_date_start.Value; set => this.uc_f.ca_date_start.Value = value; }
        internal Button Download { get => this.uc_f.bt_downloadDir; set => this.uc_f.bt_downloadDir = value; }
        internal Label LBDownload { get => this.uc_f.lb_bt_downloadDir; set => this.uc_f.lb_bt_downloadDir = value; }
        internal CheckBox Process { get => this.uc_f.cb_process; set => this.uc_f.cb_process = value; }
        internal CheckBox Keep { get => this.uc_f.cb_keepDownload; set => this.uc_f.cb_keepDownload = value; }
        internal Button File { get => this.uc_f.bt_fileDest; set => this.uc_f.bt_fileDest = value; }
        internal Label LBFile { get => this.uc_f.lb_bt_fileDest; set => this.uc_f.lb_bt_fileDest = value; }
        internal Button Accept { get => this.uc_f.bt_accept; set => this.uc_f.bt_accept = value; }
        internal Button Cancel { get => this.uc_f.bt_cancel; set => this.uc_f.bt_cancel = value; }
        protected Fields UCF { get => this.uc_f; set => this.uc_f = value; }

        public SingleGeneric()
        {
            this.fid = 0;
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        public SingleGeneric(int FID)
        {
            this.fid = FID;
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        private void LoadFields()
        {
            this.FormName = "SingleGeneric";
            this.Start = DateTime.Today.AddDays(-1);
            this.fb_directory.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.sf_file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void LoadEvents()
        {
            this.Process.CheckedChanged += new EventHandler(cb_enabler);
            this.Accept.Click += new EventHandler(accept);
            this.Cancel.Click += new EventHandler(cancel);
            this.Link.LinkClicked += new LinkLabelLinkClickedEventHandler(link);
            this.Download.Click += new EventHandler(downloadFolder);
            this.uc_f.ca_date_start.Validated += new EventHandler(validateStart);
        }

        private void cb_enabler(object sender, EventArgs e)
        {
            FormManager.DLEnabler(sender, this.uc_f.cb_keepDownload, this.uc_f.bt_fileDest, this.uc_f.lb_bt_downloadDir);
        }

        private void accept(object sender, EventArgs e)
        {
            FormManager.FormAccept(this, this.FID);
        }

        private void cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormManager.OpenLink(this.FID, this.Link);
        }

        private void downloadFolder(object sender, EventArgs e)
        {
            FormManager.DownloadDir(this.fb_directory, this.LBDownload, this.tt_folder);
        }

        private void validateStart(object sender, EventArgs e)
        {
            Auxiliary.ValidateStart(this.uc_f.ca_date_start, this.ep_error);
        }
    }
}

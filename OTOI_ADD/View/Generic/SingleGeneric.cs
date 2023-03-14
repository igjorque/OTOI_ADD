using OTOI_ADD.Code.Function;
using OTOI_ADD.View.Asset;

namespace OTOI_ADD.View.Generic
{
    public partial class SingleGeneric : Form
    {
        private readonly int fid;
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
            this.LBDownload.Text = FormManager.CURR_DIR;
            this.fb_directory.InitialDirectory = FormManager.CURR_DIR;
            this.LBFile.Text = FormManager.CURR_FIL;
            this.sf_file.InitialDirectory = FormManager.CURR_FIL;
        }

        private void LoadEvents()
        {
            this.Process.CheckedChanged += new EventHandler(EnableEvent);
            this.Accept.Click += new EventHandler(AcceptEvent);
            this.Cancel.Click += new EventHandler(CancelEvent);
            this.Link.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkEvent);
            this.Download.Click += new EventHandler(DownloadFolderEvent);
            this.File.Click += new EventHandler(DownloadFileEvent);
            this.uc_f.ca_date_start.Validated += new EventHandler(ValidateStartEvent);
        }

        private void EnableEvent(object? sender, EventArgs e)
        {
            FormManager.DLEnabler(sender, this.uc_f.cb_keepDownload, this.uc_f.bt_fileDest, this.uc_f.lb_bt_fileDest);
        }

        private void AcceptEvent(object? sender, EventArgs e)
        {
            FormManager.FormAccept(this, this.FID);
        }

        private void CancelEvent(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkEvent(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            FormManager.OpenLink(this.FID, this.Link);
        }

        private void DownloadFolderEvent(object? sender, EventArgs e)
        {
            FormManager.DownloadDir(this.fb_directory, this.LBDownload, this.tt_folder);
        }

        private void DownloadFileEvent(object? sender, EventArgs e)
        {
            FormManager.DownloadFil(this.sf_file, this.LBFile, this.tt_file);
        }

        private void ValidateStartEvent(object? sender, EventArgs e)
        {
            Auxiliary.ValidateStart(this.uc_f.ca_date_start, this.ep_error);
            if (this.ep_error.GetError(this.uc_f.ca_date_start) == "")
            {
                FormManager.STR = this.uc_f.ca_date_start.Value;
                this.Accept.Enabled = true;
            } else
            {
                this.Accept.Enabled = false;
            }
        }
    }
}

using OTOI_ADD.Code.Function;
using OTOI_ADD.View.Asset;
using System.Reflection;

namespace OTOI_ADD.View.Generic
{
    /// <summary>
    /// SingleGeneric
    /// </summary>
    public partial class SingleGeneric : Form
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

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
        internal Fields UCF { get => this.uc_f; set => this.uc_f = value; }

        /// <summary>
        /// Empty SingleGeneric form constructor.
        /// **DO NOT USE**
        /// </summary>
        public SingleGeneric()
        {
            logger.Info("SingleGeneric - Constructor");
            this.fid = 0;
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        /// <summary>
        /// SingleGeneric form constructor.
        /// Creates a new form with a specific Form ID (FID).
        /// </summary>
        /// <param name="FID">Created form unique ID</param>
        public SingleGeneric(int FID)
        {
            logger.Info("SingleGeneric - Constructor");
            this.fid = FID;
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.FormName = "SingleGeneric";
            this.Start = FormManager.STR;
            this.LBDownload.Text = FormManager.CURR_DIR;
            this.fb_directory.InitialDirectory = FormManager.CURR_DIR;
            if (FormManager.CURR_FIL != "") this.LBFile.Text = FormManager.CURR_FIL;
            else this.LBFile.Text = "Por defecto";
            this.sf_file.InitialDirectory = FormManager.CURR_DIR;
        }

        /// <summary>
        /// Auxiliary - Loads predefined events.
        /// </summary>
        private void LoadEvents()
        {
            logger.Info("SingleGeneric - Loading Events");
            this.AcceptButton = this.Accept;
            this.Process.CheckedChanged += new EventHandler(EnableEvent);
            this.Accept.Click += new EventHandler(AcceptEvent);
            this.Cancel.Click += new EventHandler(CancelEvent);
            this.Link.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkEvent);
            this.Download.Click += new EventHandler(DownloadFolderEvent);
            this.File.Click += new EventHandler(DownloadFileEvent);
            this.uc_f.ca_date_start.ValueChanged += new EventHandler(ValidateStartEvent);
            logger.Info("SingleGeneric - Events Loaded");
        }

        /// <summary>
        /// Manages the enabling/disabling of some controls based on the [cb_keepDownload] CheckBox current status.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void EnableEvent(object? sender, EventArgs e)
        {
            FormManager.DLEnabler(sender, this.uc_f.cb_keepDownload, this.uc_f.bt_fileDest, this.uc_f.lb_bt_fileDest);
        }

        /// <summary>
        /// Manages the click event onto the [bt_accept] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void AcceptEvent(object? sender, EventArgs e)
        {
            logger.Info("SingleGeneric - Form Accept");
            FormManager.FormAccept(this, this.FID);
        }

        /// <summary>
        /// Manages the click event onto the [bt_cancel] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void CancelEvent(object? sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Manages the click event onto the [lb_link] LinkLabel control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void LinkEvent(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            logger.Info("SingleGeneric - Opening Link");
            FormManager.OpenLink(this.FID, this.Link);
        }

        /// <summary>
        /// Manages the click event onto the [bt_downloadDir] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void DownloadFolderEvent(object? sender, EventArgs e)
        {
            FormManager.DownloadDir(this.fb_directory, this.LBDownload, this.tt_folder);
        }

        /// <summary>
        /// Manages the click event onto the [bt_fileDest] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void DownloadFileEvent(object? sender, EventArgs e)
        {
            FormManager.DownloadFil(this.sf_file, this.LBFile, this.tt_file);
        }

        /// <summary>
        /// Manages the validation of the [ca_date_start] DateTimePicker control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
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

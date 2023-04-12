using OTOI_ADD.Code.Function;
using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Asset;
using OTOI_ADD.View.Generic.ESIOS;
using System.Reflection;

namespace OTOI_ADD.View.Generic.OMIE
{
    /// <summary>
    /// OGeneric
    /// </summary>
    public partial class OGeneric : Form
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly int fid;
        internal int FID { get => this.fid; }
        internal string FormTitle { get => this.Text; set => this.Text = value; }
        internal Label LBTitle { get => this.uc_fo.lb_title; }
        internal LinkLabel LBLink { get => this.uc_fo.lb_link; }
        internal Button BTFolder { get => this.uc_fo.bt_downloadDir; }
        internal Label LBFolder { get => this.uc_fo.lb_bt_downloadDir; }
        internal CheckBox CBProcess { get => this.uc_fo.cb_process; }
        internal CheckBox CBKeep { get => this.uc_fo.cb_keepDownload; }
        internal Button BTFile { get => this.uc_fo.bt_fileDest; }
        internal Label LBFile { get => this.uc_fo.lb_bt_fileDest; }
        internal Button BTAccept { get => this.uc_fo.bt_accept; }
        internal Button BTCancel { get => this.uc_fo.bt_cancel; }
        internal Fields_OMIE UCFO { get => this.uc_fo; }

        /// <summary>
        /// Empty OGeneric form constructor.
        /// **DO NOT USE**
        /// </summary>
        public OGeneric(){ InitializeComponent(); }
        
        /// <summary>
        /// OGeneric form constructor.
        /// Creates a new form with a specific Form ID (FID).
        /// </summary>
        /// <param name="FID">Created form unique ID</param>
        public OGeneric(int FID)
        {
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
            this.Text = this.GetType().Name;
            this.LBFolder.Text = VAR.CURRENT_DIRECTORY;
            this.LBFile.Text = VAR.DEFAULT_FILE;
            this.fb_directory.InitialDirectory = VAR.CURRENT_DIRECTORY;
            this.tt_folder.SetToolTip(this.LBFolder, this.LBFolder.Text);
            this.tt_file.SetToolTip(this.LBFile, this.LBFile.Text);
            this.sf_file.InitialDirectory = VAR.CURRENT_DIRECTORY;
        }

        /// <summary>
        /// Auxiliary - Loads predefined events.
        /// </summary>
        private void LoadEvents()
        {
            this.AcceptButton = this.BTAccept;
            this.CBProcess.CheckedChanged += new EventHandler(ProcessEvent);
            this.BTAccept.Click += new EventHandler(AcceptEvent);
            this.BTCancel.Click += new EventHandler(CancelEvent);
            this.LBLink.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkEvent);
            this.BTFolder.Click += new EventHandler(DownloadFolderEvent);
            this.BTFile.Click += new EventHandler(DownloadFileEvent);
        }

        /// <summary>
        /// Manages the enabling/disabling of some controls based on the [cb_keepDownload] CheckBox current status.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void ProcessEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_PROCESS);
            FormManager.DLEnabler(this.CBProcess, this.CBKeep, this.BTFile, this.LBFile);
        }

        /// <summary>
        /// Manages the click event onto the [bt_accept] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void AcceptEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_ACCEPT);
            FormManager.FormAccept(this, this.FID);
        }

        /// <summary>
        /// Manages the click event onto the [bt_cancel] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void CancelEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_CANCEL);
            this.Close();
        }

        /// <summary>
        /// Manages the click event onto the [lb_link] LinkLabel control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void LinkEvent(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            logger.Info(LOG.LINK_OPEN);
            FormManager.OpenLink(this.FID, this.LBLink);
        }

        /// <summary>
        /// Manages the click event onto the [bt_downloadDir] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void DownloadFolderEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_FOLDER);
            FormManager.DownloadDir(this.fb_directory, this.LBFolder, this.tt_folder);
        }

        /// <summary>
        /// Manages the click event onto the [bt_fileDest] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void DownloadFileEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_FILE);
            FormManager.DownloadFil(this.sf_file, this.LBFile, this.tt_file);
        }
    }
}

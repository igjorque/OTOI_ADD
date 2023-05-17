using OTOI_ADD.Code.Interface;
using OTOI_ADD.Code.Module.Function;
using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Asset;
using System.Reflection;

namespace OTOI_ADD.View.Generic
{
    // TODO: comment
    /// <summary>
    /// 
    /// </summary>
    public partial class Generic : Form, IControls
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly int fid;
        internal int FID { get => this.fid; }
        internal string FormTitle { get => this.Text; set => this.Text = value; }
        internal Label LBTitle { get => this.uc_f.lb_title; }
        internal LinkLabel LBLink { get => this.uc_f.lb_link; }
        internal Button BTFolder { get => this.uc_f.bt_downloadDir; }
        internal Label2 LBFolder { get => this.uc_f.lb_download; }
        internal CheckBox CBProcess { get => this.uc_f.cb_process; }
        internal CheckBox CBKeep { get => this.uc_f.cb_keep; }
        internal Button BTFile { get => this.uc_f.bt_fileDest; }
        internal Label2 LBFile { get => this.uc_f.lb_file; }
        internal Button2 BTAccept { get => this.uc_f.bt_accept; }
        internal Button2 BTCancel { get => this.uc_f.bt_cancel; }

        /// <summary>
        /// Empty Generic form constructor.
        /// **DO NOT USE**
        /// </summary>
        public Generic() { InitializeComponent(); }

        /// <summary>
        /// Generic form constructor.
        /// Creates a new form with a specific Form ID (FID).
        /// </summary>
        /// <param name="FID"></param>
        public Generic(int FID)
        {
            this.fid = FID;
            InitializeComponent();
            LoadEvents();
        }

        /// <summary>
        /// IControls implementation.
        /// Gets this form's controls
        /// </summary>
        /// <returns>List of this form's controls</returns>
        public List<Object> GetControls()
        {
            return new List<Object>
            {
                this.uc_f, this.LBTitle, this.LBLink, this.BTFolder, this.LBFolder, this.CBProcess, this.CBKeep, this.BTFile, this.LBFile, this.BTAccept, this.BTCancel
            };
        }

        /// <summary>
        /// Auxiliary - Loads predefined events.
        /// </summary>
        private void LoadEvents()
        {
            this.LBLink.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkEvent);
            this.BTFolder.Click += new EventHandler(FolderEvent);
            this.BTFile.Click += new EventHandler(FileEvent);
            this.BTAccept.Click += new EventHandler(AcceptEvent);
            this.BTCancel.Click += new EventHandler(CancelEvent);
        }

        /// <summary>
        /// Manages the click event onto the [lb_link] LinkLabel control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void LinkEvent(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logger.Info(LOG.LINK_OPEN);
            FormManager.OpenLink(this.FID, this.LBLink);
        }

        /// <summary>
        /// Manages the click event ont the [bt_downloadDir] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void FolderEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_FOLDER);
            FormManager.DownloadDir(this.fb_directory, this.LBFolder, this.tt_folder);
        }

        
        /// <summary>
        /// Manages the enabling/disabling of some controls based on the [cb_process] CheckBox current status.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void ProcessEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_PROCESS);
            FormManager.OP_Enabler(this.CBProcess, this.CBKeep, this.BTFile, this.LBFile);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void FileEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_FILE);
            FormManager.DownloadFil(this.sf_file, this.LBFile, this.tt_file);
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
    }
}

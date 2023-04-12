using OTOI_ADD.Code.Function;
using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Asset;
using System.Reflection;

namespace OTOI_ADD.View.Generic.ESIOS
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EGeneric : Form
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly int fid;

        internal int FID { get => fid; }
        internal Label LBTitle { get => this.uc_fe.lb_title; }
        internal LinkLabel LBLink { get => this.uc_fe.lb_link; }
        internal Button BTFolder { get => this.uc_fe.bt_downloadDir; }
        internal Label LBFolder { get => this.uc_fe.lb_bt_downloadDir; }
        internal CheckBox CBUnzip { get => this.uc_fe.cb_unzip; }
        internal CheckBox CBKeep { get => this.uc_fe.cb_keep; }
        internal CheckBox CBProcess { get => this.uc_fe.cb_process; }
        internal Button BTFile { get => this.uc_fe.bt_fileDest; }
        internal Label LBFile { get => this.uc_fe.lb_bt_fileDest; }
        internal Button BTAccept { get => this.uc_fe.bt_accept; }
        internal Button BTCancel { get => this.uc_fe.bt_cancel; }
        internal Fields_ESIOS UCFE { get => this.uc_fe; }

        /// <summary>
        /// Empty EGeneric form constructor.
        /// **DO NOT USE**
        /// </summary>
        public EGeneric() { InitializeComponent(); }

        /// <summary>
        /// EGeneric form constructor.
        /// Creates a new form with a specific Form ID (FID).
        /// </summary>
        /// <param name="FID">Created form unique ID</param>
        public EGeneric(int FID)
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
            this.LBTitle.Text = "Generic ESIOS form";
            this.LBFolder.Text = VAR.CURRENT_DIRECTORY;
            this.LBFile.Text = VAR.DEFAULT_FILE;
            this.fb_directory.InitialDirectory = VAR.CURRENT_DIRECTORY;
            this.sf_file.InitialDirectory = VAR.CURRENT_DIRECTORY;
            this.tt_folder.SetToolTip(this.LBFolder, this.LBFolder.Text);
            this.tt_file.SetToolTip(this.LBFile, this.LBFile.Text);
        }

        /// <summary>
        /// Auxiliary - Loads predefined events.
        /// </summary>
        private void LoadEvents()
        {
            this.LBLink.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkEvent);
            this.BTFolder.Click += new EventHandler(FolderEvent);
            this.CBUnzip.CheckedChanged += new EventHandler(UnzipEvent);
            this.CBProcess.CheckedChanged += new EventHandler(ProcessEvent);
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
        /// Manages the enabling/disabling of some controls based on the [cb_unzip] CheckBox current status.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void UnzipEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_UNZIP);
            if (this.CBUnzip.Checked)
            {
                this.CBKeep.Enabled = true;
                this.CBProcess.Enabled = true;
                if (this.CBProcess.Checked)
                {
                    this.BTFile.Enabled = true;
                    this.LBFile.Enabled = true;
                }
            }
            else
            {
                this.CBKeep.Enabled = false;
                this.CBProcess.Enabled = false;
                this.BTFile.Enabled = false;
                this.LBFile.Enabled = false;
            }
        }

        /// <summary>
        /// Manages the enabling/disabling of some controls based on the [cb_process] CheckBox current status.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void ProcessEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_PROCESS);
            if (this.CBProcess.Checked)
            {
                this.BTFile.Enabled = true;
                this.LBFile.Enabled = true;
            }
            else
            {
                this.BTFile.Enabled = false;
                this.LBFile.Enabled = false;
            }
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

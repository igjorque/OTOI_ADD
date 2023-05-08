using OTOI_ADD.Code.Module.Function;
using OTOI_ADD.Code.Module.Style;
using OTOI_ADD.Code.Variable;
using System.Reflection;

namespace OTOI_ADD.View.Generic.ESIOS
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EGeneric : Generic
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        internal CheckBox CBUnzip { get => this.cb_unzip; }

        /// <summary>
        /// Empty EGeneric form constructor.
        /// **DO NOT USE**
        /// </summary>
        public EGeneric() : base()
        {
            InitializeComponent();
            ArrangeFields();
        }

        /// <summary>
        /// EGeneric form constructor.
        /// Creates a new form with a specific Form ID (FID).
        /// </summary>
        /// <param name="FID">Created form unique ID</param>
        public EGeneric(int FID) : base(FID)
        {
            InitializeComponent();
            ArrangeFields();
            LoadFields();
            LoadEvents();
        }


        /// <summary>
        /// IControls implementation.
        /// Gets this form's controls
        /// </summary>
        /// <returns>List of this form's controls</returns>
        public new List<Object> GetControls()
        {
            List<Object> parentControls = base.GetControls();
            List<Object> controls = new List<Object>
            {
                this.CBUnzip
            };
            return parentControls.Concat(controls).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        private void ArrangeFields()
        {
            // LBTitle
            this.LBTitle.Location = new System.Drawing.Point(1, 6);
            // LBLink
            this.LBLink.Location = new System.Drawing.Point(285, 18);

            // BTDownload
            this.BTFolder.Location = new System.Drawing.Point(1, 82);
            // LBDownload
            this.LBFolder.Location = new System.Drawing.Point(113, 83);

            // CBUnzip
            this.CBUnzip.Location = new System.Drawing.Point(8, 114);
            // CBKeep
            this.CBKeep.Location = new System.Drawing.Point(8, 142);
            // CBProcess
            this.CBProcess.Location = new System.Drawing.Point(8, 170);

            // BTFile
            this.BTFile.Location = new System.Drawing.Point(1, 202);
            // LBFile
            this.LBFile.Location = new System.Drawing.Point(113, 203);

            // BTAccept
            this.BTAccept.Location = new System.Drawing.Point(64, 232);
            // BTCancel
            this.BTCancel.Location = new System.Drawing.Point(176, 232);
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.LBTitle.Text = "Generic ESIOS form";
            this.LBFolder.Text = OTOI_ADD.Properties.Settings.Default.DIRECTORY;

            this.CBUnzip.Checked = OTOI_ADD.Properties.Settings.Default.E_UNZIP;
            this.CBKeep.Checked = OTOI_ADD.Properties.Settings.Default.E_KEEP;
            this.CBProcess.Checked = OTOI_ADD.Properties.Settings.Default.E_PROCESS;

            this.CBKeep.Enabled = this.CBUnzip.Checked;
            this.CBProcess.Enabled = this.CBUnzip.Checked;
            this.BTFile.Enabled = this.CBUnzip.Checked && this.CBProcess.Checked;
            this.LBFile.Enabled = this.CBUnzip.Checked && this.CBProcess.Checked;

            this.LBFile.Text = OTOI_ADD.Properties.Settings.Default.FILE;

            this.fb_directory.InitialDirectory = OTOI_ADD.Properties.Settings.Default.DIRECTORY;
            this.sf_file.InitialDirectory = OTOI_ADD.Properties.Settings.Default.DIRECTORY;
            this.tt_folder.SetToolTip(this.LBFolder, this.LBFolder.Text);
            this.tt_file.SetToolTip(this.LBFile, this.LBFile.Text);
        }

        private void LoadEvents()
        {
            this.CBUnzip.CheckedChanged += new EventHandler(UnzipEvent);
            this.CBProcess.CheckedChanged += new EventHandler(ProcessEvent);
        }
        /// <summary>
        /// Manages the enabling/disabling of some controls based on the [cb_unzip] CheckBox current status.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void UnzipEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_UNZIP);
            FormManager.EU_Enabler(this.CBUnzip, this.CBProcess, this.CBKeep, this.BTFile, this.LBFile);
        }

        /// <summary>
        /// Manages the enabling/disabling of some controls based on the [cb_keep] CheckBox current status.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void ProcessEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_PROCESS);
            FormManager.EP_Enabler(this.CBProcess, this.BTFile, this.LBFile);
        }
    }
}

using OTOI_ADD.Code.Module.Function;
using OTOI_ADD.Code.Module.Style;
using OTOI_ADD.Code.Variable;
using System.Reflection;

namespace OTOI_ADD.View.Generic.OMIE
{
    /// <summary>
    /// OGeneric
    /// </summary>
    public partial class OGeneric : Generic
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Empty OGeneric form constructor.
        /// **DO NOT USE**
        /// </summary>
        public OGeneric() : base() 
        {
            InitializeComponent();

            List<Object> controls = new List<Object>
            {
                
            };
            Styler.SetStyle(controls);

            ArrangeFields();
        }
        
        /// <summary>
        /// OGeneric form constructor.
        /// Creates a new form with a specific Form ID (FID).
        /// </summary>
        /// <param name="FID">Created form unique ID</param>
        public OGeneric(int FID) : base(FID)
        {
            InitializeComponent();
            ArrangeFields();
            LoadFields();
            LoadEvents();
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

            // BTFolder
            this.BTFolder.Location = new System.Drawing.Point(1, 82);
            // LBFolder
            this.LBFolder.Location = new System.Drawing.Point(113, 83);

            // CBProcess
            this.CBProcess.Location = new System.Drawing.Point(8, 110);

            // CBKeep
            this.CBKeep.Location = new System.Drawing.Point(8, 138);

            // BTFile
            this.BTFile.Location = new System.Drawing.Point(1, 166);
            // LBFile
            this.LBFile.Location = new System.Drawing.Point(113, 167);

            // BTAccept
            this.BTAccept.Location = new System.Drawing.Point(64, 198);
            // BTCancel
            this.BTCancel.Location = new System.Drawing.Point(176, 198);
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.CBProcess.Checked = true;
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
            this.CBProcess.CheckedChanged += new EventHandler(ProcessEvent);
        }

        /// <summary>
        /// Manages the enabling/disabling of some controls based on the [cb_keepDownload] CheckBox current status.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void ProcessEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_PROCESS);
            FormManager.OP_Enabler(this.CBProcess, this.CBKeep, this.BTFile, this.LBFile);
        }
    }
}

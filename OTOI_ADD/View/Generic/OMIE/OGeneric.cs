using OTOI_ADD.Code.Module.Function;
using OTOI_ADD.Code.Variable;
using System.Reflection;
using Prop = OTOI_ADD.Properties.Settings;

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
            ArrangeFields();
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
                // Empty list - currently no controls to add
            };
            return parentControls.Concat(controls).ToList();
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
        /// Organises this forms controls, setting their positions.
        /// </summary>
        private void ArrangeFields()
        {
            // LBTitle
            this.LBTitle.Location = new Point(1, 6);
            // LBLink
            this.LBLink.Location = new Point(285, 18);

            // BTFolder
            this.BTFolder.Location = new Point(1, 82);
            // LBFolder
            this.LBFolder.Location = new Point(113, 83);

            // CBProcess
            this.CBProcess.Location = new Point(8, 110);

            // CBKeep
            this.CBKeep.Location = new Point(8, 138);

            // BTFile
            this.BTFile.Location = new Point(1, 166);
            // LBFile
            this.LBFile.Location = new Point(113, 167);

            // BTAccept
            this.BTAccept.Location = new Point(64, 198);
            // BTCancel
            this.BTCancel.Location = new Point(176, 198);
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.CBProcess.Checked = Prop.Default.O_PROCESS;
            this.CBKeep.Checked = Prop.Default.O_KEEP;
            
            this.LBFolder.Text = Prop.Default.DIRECTORY;
            this.LBFile.Text = Prop.Default.FILE;

            this.CBKeep.Enabled = this.CBProcess.Checked;
            this.BTFile.Enabled = this.CBProcess.Checked;
            this.LBFile.Enabled = this.CBProcess.Checked;

            this.fb_directory.InitialDirectory = Prop.Default.DIRECTORY;
            this.tt_folder.SetToolTip(this.LBFolder, this.LBFolder.Text);
            this.tt_file.SetToolTip(this.LBFile, this.LBFile.Text);
            this.sf_file.InitialDirectory = Prop.Default.DIRECTORY;
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

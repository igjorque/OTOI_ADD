using ADD_Backend.Function;
using ADD_Frontend.Code.Module.Style;
using ADD_Backend.Variable;
using System.Reflection;

namespace ADD_Frontend.View.Generic.OMIE
{
    /// <summary>
    /// MultiGeneric
    /// </summary>
    public partial class OGenericRange : OGeneric
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        internal DateTimePicker CAStart { get => this.uc_range.ca_date_start; }
        internal DateTime Start { get => this.CAStart.Value; }
        internal DateTimePicker CAEnd { get => this.uc_range.ca_date_end; }
        internal DateTime End { get => this.CAEnd.Value; }

        /// <summary>
        /// Empty OGenericRange form constructor.
        /// **DO NOT USE**
        /// </summary>
        public OGenericRange() : base() { InitializeComponent(); }
        
        /// <summary>
        /// OGenericRange form constructor.
        /// Creates a new form with a specific Form ID (FID).
        /// </summary>
        /// <param name="FID">Created form unique ID</param>
        public OGenericRange(int FID) : base(FID)
        {
            InitializeComponent();
            Styler.SetStyle(this.GetControls());
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
                this.CAStart, this.CAEnd, this.uc_range
            };
            return parentControls.Concat(controls).ToList();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.CAStart.Value = ADD_Frontend.Properties.Settings.Default.START;
            this.CAEnd.Value = ADD_Frontend.Properties.Settings.Default.END;
        }

        /// <summary>
        /// Auxiliary - Loads predefined events.
        /// </summary>
        private void LoadEvents()
        {
            this.uc_range.ca_date_start.ValueChanged += new EventHandler(ValidateRangeEvent);
            this.uc_range.ca_date_end.ValueChanged += new EventHandler(ValidateRangeEvent);
        }

        /// <summary>
        /// Manages the validation of the entered date range.
        /// </summary>
        /// <param name="sender">Sender [ca_date_start] or [ca_date_end] DateTimePicker control</param>
        /// <param name="e">Event arguments</param>
        private void ValidateRangeEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_VALIDATE_RANGE);
            Auxiliary.ValidateRange(this.CAStart, this.CAEnd, this.ep_error);
            ErrorCheck();
        }

        /// <summary>
        /// Manages the enabling or disabling of some controls based on if an error exists/is set.
        /// Saves the entered date values and enables the Accept button if no error is found.
        /// </summary>
        private void ErrorCheck()
        {
            logger.Info(LOG.FORM_ERROR);
            if (this.ep_error.GetError(this.CAEnd) == "" && this.ep_error.GetError(this.CAStart) == "")
            {
                ADD_Frontend.Properties.Settings.Default.START = this.Start;
                ADD_Frontend.Properties.Settings.Default.END = this.End;
                this.BTAccept.Enabled = true;
            }
            else
            {
                this.BTAccept.Enabled = false;
            }
        }
    }
}

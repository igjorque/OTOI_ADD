using OTOI_ADD.Code.Function;
using OTOI_ADD.Code.Variable;
using System.Reflection;

namespace OTOI_ADD.View.Generic.OMIE
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
            LoadFields();
            LoadEvents();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.Text = this.GetType().Name;
            this.CAStart.Value = VAR.RANGE_START;
            this.CAEnd.Value = VAR.RANGE_END;
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
                VAR.RANGE_START = this.Start;
                VAR.RANGE_END = this.End;
                this.BTAccept.Enabled = true;
            }
            else
            {
                this.BTAccept.Enabled = false;
            }
        }
    }
}

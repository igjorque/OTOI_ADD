using OTOI_ADD.Code.Function;
using OTOI_ADD.Code.Variable;
using System.Reflection;

namespace OTOI_ADD.View.Generic.OMIE
{
    /// <summary>
    /// 
    /// </summary>
    public partial class OGenericDay : OGeneric
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        internal DateTimePicker CADay { get => this.uc_day.ca_date; }
        internal DateTime Day { get => this.CADay.Value; }

        /// <summary>
        /// Empty OGenericDay form constructor.
        /// ** DO NOT USE **
        /// </summary>
        public OGenericDay() : base() { InitializeComponent(); }

        /// <summary>
        /// OGenericDay form constructor.
        /// Creates a new form with a specific Form ID (FID).
        /// </summary>
        /// <param name="FID"></param>
        public OGenericDay(int FID) : base(FID)
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
            this.CADay.Value = VAR.DATE_DAY;
        }

        /// <summary>
        /// Auxiliary - Loads predefined events.
        /// </summary>
        private void LoadEvents()
        {
            this.CADay.ValueChanged += new EventHandler(ValidateDayEvent);
        }

        /// <summary>
        /// Manages the validation of the [ca_day] DateTimePicker control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void ValidateDayEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_VALIDATE_DAY);
            Auxiliary.ValidateStart(this.CADay, this.ep_error);
            ErrorCheck();
        }

        /// <summary>
        /// Manages the enabling or disabling of some controls based on if an error exists/is set.
        /// Saves the entered date value and enables the Accept button if no error is found.
        /// </summary>
        private void ErrorCheck()
        {
            logger.Info(LOG.FORM_ERROR);
            if (this.ep_error.GetError(this.CADay) == "")
            {
                VAR.DATE_DAY = this.Day;
                this.BTAccept.Enabled = true;
            }
            else
            {
                this.BTAccept.Enabled = false;
            }
        }
    }
}

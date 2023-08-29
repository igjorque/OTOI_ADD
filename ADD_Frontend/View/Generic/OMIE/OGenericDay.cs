using ADD_Backend.Function;
using ADD_Backend.Variable;
using ADD_Frontend.Code.Module.Style;
using System.Reflection;

namespace ADD_Frontend.View.Generic.OMIE
{
    // TODO: comment
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
                this.CADay, this.uc_day
            };
            return parentControls.Concat(controls).ToList();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.CADay.Value = ADD_Frontend.Properties.Settings.Default.DAY;
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
                ADD_Frontend.Properties.Settings.Default.DAY = this.Day;
                this.BTAccept.Enabled = true;
            }
            else
            {
                this.BTAccept.Enabled = false;
            }
        }
    }
}

using ADD_Backend.Function;
using ADD_Frontend.Code.Module.Style;
using ADD_Backend.Variable;
using ADD_Frontend.View.Asset.Control;
using System.Reflection;

namespace ADD_Frontend.View.Generic.ESIOS
{
    /// <summary>
    /// EGenericMonth
    /// </summary>
    public partial class EGenericMonth : EGeneric
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        internal MonthPicker MPMonth { get => this.uc_month.mp_month; }
        internal DateTime Month { get => new(this.MPMonth.Value.Year, this.MPMonth.Value.Month, 1); }
        
        /// <summary>
        /// Empty EGenericMonth form constructor.
        /// ** DO NOT USE **
        /// </summary>
        public EGenericMonth() : base() { InitializeComponent(); }

        /// <summary>
        /// EGenericMonth form constructor.
        /// Creates a new form with a specific Form ID (FID).
        /// </summary>
        /// <param name="FID">Created form unique ID</param>
        public EGenericMonth(int FID) : base(FID)
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
                this.MPMonth, this.uc_month, this.CBUnzip
            };
            return parentControls.Concat(controls).ToList();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.LBTitle.Text = "EGenericMonth ESIOS form";
            this.MPMonth.Value = ADD_Frontend.Properties.Settings.Default.MONTH;
        }

        private void LoadEvents()
        {
            this.MPMonth.ValueChanged += new EventHandler(ValidateMonthEvent);
        }

        /// <summary>
        /// Manages the validation of the [mp_month] MonthPicker control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void ValidateMonthEvent(object? sender, EventArgs e)
        {
            logger.Info(LOG.FORM_VALIDATE_MONTH);
            Auxiliary.ValidateMonth(this.MPMonth, this.ep_error);
            ErrorCheck();
        }

        /// <summary>
        /// Manages the enabling or disabling of some controls based on if an error exists/is set.
        /// Saves the entered month value and enables the Accept button if no error is found.
        /// </summary>
        private void ErrorCheck()
        {
            logger.Info(LOG.FORM_ERROR);
            if (this.ep_error.GetError(this.MPMonth) == "")
            {
                ADD_Frontend.Properties.Settings.Default.MONTH = this.Month;
                this.BTAccept.Enabled = true;
            }
            else
            {
                this.BTAccept.Enabled = false;
            }
        }
    }
}

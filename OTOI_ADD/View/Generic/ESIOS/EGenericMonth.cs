using OTOI_ADD.Code.Module.Function;
using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Asset.Control;
using System.Reflection;

namespace OTOI_ADD.View.Generic.ESIOS
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
            LoadFields();
            LoadEvents();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.LBTitle.Text = "EGenericMonth ESIOS form";
            this.MPMonth.Value = VAR.DATE_MONTH;
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
                VAR.DATE_MONTH = this.Month;
                this.BTAccept.Enabled = true;
            }
            else
            {
                this.BTAccept.Enabled = false;
            }
        }
    }
}

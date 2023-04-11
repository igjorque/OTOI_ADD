using OTOI_ADD.Code.Function;
using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Asset.Control;
using System.Reflection;

namespace OTOI_ADD.View.Generic.OMIE
{
    /// <summary>
    /// OGenericMonth
    /// </summary>
    public partial class OGenericMonth : OGeneric
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        internal MonthPicker MPMonth { get => this.uc_month.mp_month; }
        internal DateTime Month { get => new(this.MPMonth.Value.Year, this.MPMonth.Value.Month, 1); }

        /// <summary>
        /// Empty OGenericMonth form constructor.
        /// ** DO NOT USE **
        /// </summary>
        public OGenericMonth() : base() { InitializeComponent(); }

        /// <summary>
        /// OGenericMonth form constructor.
        /// Creates a new form with a specific Form ID (FID).
        /// </summary>
        /// <param name="FID">Created form unique ID</param>
        public OGenericMonth(int FID) : base(FID)
        {
            logger.Info(this.GetType().Name + " - " + LOG.CON_LFR);
            InitializeComponent();
            LoadFields();
            LoadEvents();
            logger.Info(this.GetType().Name + " - " + LOG.CON_FRL);
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.Text = this.GetType().Name;
            this.MPMonth.Value = VAR.DTE_MTH;
        }

        /// <summary>
        /// Auxiliary - Loads predefined events.
        /// </summary>
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
            logger.Info(this.GetType().Name + " - " + LOG.FRM_VAM);
            Auxiliary.ValidateMonth(this.MPMonth, this.ep_error);
            ErrorCheck();
        }

        /// <summary>
        /// Manages the enabling or disabling of some controls based on if an error exists/is set.
        /// Saves the entered month value and enables the Accept button if no error is found.
        /// </summary>
        private void ErrorCheck()
        {
            logger.Info(this.GetType().Name + " - " + LOG.FRM_ERC);
            if (this.ep_error.GetError(this.MPMonth) == "")
            {
                VAR.DTE_MTH = this.Month;
                this.BTAccept.Enabled = true;
            }
            else
            {
                this.BTAccept.Enabled = false;
            }
        }

    }
}

using OTOI_ADD.Code.Function;
using System.Reflection;

namespace OTOI_ADD.View.Generic
{
    /// <summary>
    /// MultiGeneric
    /// </summary>
    public partial class MultiGeneric : SingleGeneric
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        internal DateTime End { get => this.ca_date_end.Value; set => this.ca_date_end.Value = value; }

        /// <summary>
        /// Empty MultiGeneric form constructor.
        /// **DO NOT USE**
        /// </summary>
        public MultiGeneric() : base()
        {
            logger.Info("MultiGeneric - Constructor");
            InitializeComponent();
            LoadFields();
            LoadEvents();

        }

        /// <summary>
        /// MultiGeneric form constructor.
        /// Creates a new form with a specific Form ID (FID).
        /// </summary>
        /// <param name="FID">Created form unique ID</param>
        public MultiGeneric(int FID) : base(FID)
        {
            logger.Info("MultiGeneric - Constructor");
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.FormName = "MultiGeneric";
            this.Label = "Dias";
            this.Start = FormManager.STR;
            this.End = FormManager.END;
        }

        /// <summary>
        /// Auxiliary - Loads predefined events.
        /// </summary>
        private void LoadEvents()
        {
            logger.Info("MultiGeneric - Loading Events");
            this.ca_date_end.ValueChanged += new EventHandler(ValidateEndEvent);
            logger.Info("MultiGeneric - Events Loaded");
        }

        /// <summary>
        /// Manages the validation of the [ca_date_end] DateTimePicker control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void ValidateEndEvent(object? sender, EventArgs e)
        {
            Auxiliary.ValidateEnd(this.UCF.ca_date_start, this.ca_date_end, this.ep_error);
            if (this.ep_error.GetError(this.ca_date_end) == "")
            {
                FormManager.END = this.ca_date_end.Value;
                this.Accept.Enabled = true;
            } else
            {
                this.Accept.Enabled = false;
            }
        }
    }
}

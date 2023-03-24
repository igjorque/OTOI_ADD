using OTOI_ADD.View.Generic;
using System.Reflection;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// Hourly Market Multiple
    /// </summary>
    public partial class HMM : MultiGeneric
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Empty multiple HourlyMarket form constructor.
        /// </summary>
        public HMM() : base(4)
        {
            logger.Info("HMM - Constructor");
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields
        /// </summary>
        private void LoadFields()
        {
            this.FormName = "OMIE";
            this.Title = "Precio horario del mercado";
        }

        /// <summary>
        /// Auxiliary - Loads predefined events
        /// </summary>
        private void LoadEvents()
        {

        }
    }
}

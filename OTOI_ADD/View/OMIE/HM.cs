using log4net.Repository.Hierarchy;
using OTOI_ADD.View.Generic;
using System.Reflection;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// HourlyMarket
    /// </summary>
    public partial class HM : SingleGeneric
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Empty HourlyMarket form constructor.
        /// </summary>
        public HM() : base(3)
        {
            logger.Info("HM - Constructor");
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

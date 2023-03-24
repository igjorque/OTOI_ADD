using OTOI_ADD.View.Generic;
using System.Reflection;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// Hourly Price Consumers Multiple
    /// </summary>
    public partial class HPCM : MultiGeneric
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Empty multiple HourlyPriceConsumers form constructor.
        /// </summary>
        public HPCM() : base(2)
        {
            logger.Info("HPCM - Constructor");
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
            this.Title = "Precio definitivo horario del mecanismo de ajuste a los consumidores en el mercado";
        }

        /// <summary>
        /// Auxiliary - Loads predefined events
        /// </summary>
        private void LoadEvents()
        {

        }
    }
}

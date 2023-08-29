using ADD_Backend.Variable;
using ADD_Frontend.View.Generic.OMIE;
using System.Reflection;

namespace ADD_Frontend.View.OMIE
{
    /// <summary>
    /// Hourly Price Consumers
    /// </summary>
    public partial class HPC : OGenericDay
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Empty HourlyPriceConsumers form constructor.
        /// </summary>
        public HPC() : base(GLB.FID_HPC)
        {
            logger.Info(LOG.HPC_BUILD);
            InitializeComponent();
            LoadFields();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields
        /// </summary>
        private void LoadFields()
        {
            this.LBTitle.Text = GLB.TITLE_HPC;
        }
    }
}

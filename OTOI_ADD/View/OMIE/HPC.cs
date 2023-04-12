using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Generic.OMIE;
using System.Reflection;

namespace OTOI_ADD.View.OMIE
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
            this.FormTitle = GLB.OMIE_TITLE;
            this.LBTitle.Text = GLB.HPC_TITLE;
        }
    }
}

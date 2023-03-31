using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Generic;
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
            logger.Info("HPC - Constructor");
            InitializeComponent();
            LoadFields();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields
        /// </summary>
        private void LoadFields()
        {
            logger.Info("HPC - Loading Fields");
            this.FormTitle = GLB.OMIE_TLE;
            this.LBTitle.Text = GLB.HPC_TLE;
        }
    }
}

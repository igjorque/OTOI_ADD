using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Generic;
using System.Reflection;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// Hourly Price Consumers Multiple
    /// </summary>
    public partial class HPCM : OGenericRange
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Empty HourlyPriceConsumersMultiple form constructor.
        /// </summary>
        public HPCM() : base(GLB.FID_HPCM)
        {
            logger.Info("HPCM - Constructor");
            InitializeComponent();
            LoadFields();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields
        /// </summary>
        private void LoadFields()
        {
            logger.Info("HPCM - Loading Fields");
            this.FormTitle = GLB.OMIE_TLE;
            this.LBTitle.Text = GLB.HPC_TLE;
        }
    }
}

using ADD_Backend.Variable;
using ADD_Frontend.View.Generic.OMIE;
using System.Reflection;

namespace ADD_Frontend.View.OMIE
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
            logger.Info(LOG.HPCM_BUILD);
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

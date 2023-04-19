using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Generic.OMIE;
using System.Reflection;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// Hourly Market Multiple
    /// </summary>
    public partial class HMM : OGenericRange
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Empty mHourlyMarketMultiple form constructor.
        /// </summary>
        public HMM() : base(GLB.HMM_FID)
        {
            logger.Info(LOG.HMM_BUILD);
            InitializeComponent();
            LoadFields();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields
        /// </summary>
        private void LoadFields()
        {
            this.LBTitle.Text = GLB.HM_TITLE;
        }
    }
}

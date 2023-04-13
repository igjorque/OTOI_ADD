using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Generic.OMIE;
using System.Reflection;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// Hourly Market
    /// </summary>
    public partial class HM : OGenericDay
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Empty HourlyMarket form constructor.
        /// </summary>
        public HM() : base(GLB.HM_FID)
        {
            logger.Info(LOG.HM_BLD);
            InitializeComponent();
            LoadFields();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields
        /// </summary>
        private void LoadFields()
        {
            this.FormTitle = GLB.OMIE_TITLE;
            this.LBTitle.Text = GLB.HM_TITLE;
        }
    }
}

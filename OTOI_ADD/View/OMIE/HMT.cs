using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Generic.OMIE;
using System.Reflection;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// Hourly Market Table
    /// </summary>
    public partial class HMT : OGenericMonth
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Empty HourlyMarketTable form constructor
        /// </summary>
        public HMT() : base(GLB.FID_HMT)
        {
            logger.Info(LOG.HMT_BUILD);
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
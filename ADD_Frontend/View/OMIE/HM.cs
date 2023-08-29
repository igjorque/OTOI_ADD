using ADD_Backend.Variable;
using ADD_Frontend.View.Generic.OMIE;
using System.Reflection;

namespace ADD_Frontend.View.OMIE
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
        public HM() : base(GLB.FID_HM)
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
            this.LBTitle.Text = GLB.TITLE_HM;
        }
    }
}

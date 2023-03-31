using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Generic;
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
            logger.Info("HMT - Constructor");
            InitializeComponent();
            LoadFields();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields
        /// </summary>
        private void LoadFields()
        {
            logger.Info("HMT - Loading Fields");
            this.FormTitle = GLB.OMIE_TLE;
            this.LBTitle.Text = GLB.HM_TLE;
        }
    }
}
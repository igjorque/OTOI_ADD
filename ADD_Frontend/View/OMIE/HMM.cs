﻿using ADD_Backend.Variable;
using ADD_Frontend.View.Generic.OMIE;
using System.Reflection;

namespace ADD_Frontend.View.OMIE
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
        public HMM() : base(GLB.FID_HMM)
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
            this.LBTitle.Text = GLB.TITLE_HM;
        }
    }
}
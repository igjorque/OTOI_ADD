using OTOI_ADD.Code.Module.Style;
using OTOI_ADD.View.Asset.Control;
using OTOI_ADD.View.Generic.ESIOS;
using OTOI_ADD.View.Generic.OMIE;
using System.Diagnostics;

namespace OTOI_ADD.View
{
    /// <summary>
    /// Test
    /// </summary>
    public partial class Test : Form
    {
        /// <summary>
        /// Test constructor
        /// </summary>
        public Test() : base()
        {
            InitializeComponent();
            LoadStyles();
            LoadFields();
        }

        private void LoadFields()
        {
            
        }
        private void LoadStyles()
        {
            LoadLight();
            LoadDark();
        }
        private void LoadLight()
        {
            this.BackColor = ColorScheme.FORM_BACK_L;
            this.MSL.BackColor = ColorScheme.MS_BACK_L;
            this.TSMI1L.BackColor = ColorScheme.TSMI_BACK_L;
            this.TSMI1L.ForeColor = ColorScheme.TSMI_FORE_L;
            this.TSMI2L.BackColor = ColorScheme.TSMI_BACK_L;
            this.TSMI2L.ForeColor = ColorScheme.TSMI_FORE_L;
            this.LB2L.BackColor = ColorScheme.LB2_BACK_L;
            this.LB2L.ForeColor = ColorScheme.LB2_FORE_L;
            this.BTL.BackColor = ColorScheme.BT_BACK_L;
            this.BTL.ForeColor = ColorScheme.BT_FORE_L;
            this.LBL.BackColor = ColorScheme.LB_BACK_L;
            this.LBL.ForeColor = ColorScheme.LB_FORE_L;
            this.LLL.BackColor = ColorScheme.LL_BACK_L;
            this.LLL.ActiveLinkColor = ColorScheme.LL_UNUSED_L;
            this.LLL.VisitedLinkColor = ColorScheme.LL_USED_L;
            this.CBL.BackColor = ColorScheme.CHB_BACK_L;
            this.CBL.ForeColor = ColorScheme.CHB_FORE_L;
        }
        private void LoadDark()
        {
            this.FBD.BackColor = ColorScheme.FORM_BACK_D;
            this.MSD.BackColor = ColorScheme.MS_BACK_D;
            this.TSMI1D.BackColor = ColorScheme.TSMI_BACK_D;
            this.TSMI1D.ForeColor = ColorScheme.TSMI_FORE_D;
            this.TSMI2D.BackColor = ColorScheme.TSMI_BACK_D;
            this.TSMI2D.ForeColor = ColorScheme.TSMI_FORE_D;
            this.LB2D.BackColor = ColorScheme.LB2_BACK_D;
            this.LB2D.ForeColor = ColorScheme.LB2_FORE_D;
            this.BTD.BackColor = ColorScheme.BT_BACK_D;
            this.BTD.ForeColor = ColorScheme.BT_FORE_D;
            this.LBD.BackColor = ColorScheme.LB_BACK_D;
            this.LBD.ForeColor = ColorScheme.LB_FORE_D;
            this.LLD.BackColor = ColorScheme.LL_BACK_D;
            this.LLD.ActiveLinkColor = ColorScheme.LL_UNUSED_D;
            this.LLD.VisitedLinkColor = ColorScheme.LL_USED_D;
            this.CBD.BackColor = ColorScheme.CHB_BACK_D;
            this.CBD.ForeColor = ColorScheme.CHB_FORE_D;
        }
    }
}

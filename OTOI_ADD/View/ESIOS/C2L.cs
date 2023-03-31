using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Generic.ESIOS;
using System.Reflection;

namespace OTOI_ADD.View.ESIOS
{
    /// <summary>
    /// C2 Liquicomun
    /// </summary>
    public partial class C2L : EGenericMonth
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Empty C2Liquicomun form constructor.
        /// </summary>
        public C2L() : base(GLB.FID_C2L)
        {
            logger.Info("C2L - Constructor");
            InitializeComponent();
            LoadFields();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            logger.Info("C2L - Loading Fields");
            this.Text = GLB.ESIOS_TLE;
            this.LBTitle.Text = GLB.C2L_TLE;
        }
    }
}

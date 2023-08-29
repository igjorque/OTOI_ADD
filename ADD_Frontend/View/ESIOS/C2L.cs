using ADD_Backend.Variable;
using ADD_Frontend.View.Generic.ESIOS;
using System.Reflection;

namespace ADD_Frontend.View.ESIOS
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
            logger.Info(LOG.C2L_BUILD);
            InitializeComponent();
            LoadFields();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.LBTitle.Text = GLB.TITLE_C2L;
        }
    }
}

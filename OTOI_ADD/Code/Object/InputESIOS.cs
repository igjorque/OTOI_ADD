using log4net;
using OTOI_ADD.Code.Module.Function;
using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Generic.ESIOS;

namespace OTOI_ADD.Code.Class
{
    /// <summary>
    /// ESIOS Input class
    /// </summary>
    internal class InputESIOS : Input
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private bool unzip;
        private string file;

        internal bool Unzip { get => this.unzip; }
        internal string File { get => this.file; }

        /// <summary>
        /// Default empty constructor.
        /// </summary>
        public InputESIOS() : base() 
        {
            this.unzip = false;
            this.file = "";
        }
        
        /// <summary>
        /// Builds an [Input] object using a SingleGeneric type form's fields.
        /// </summary>
        /// <param name="egm">C2L form</param>
        public InputESIOS(EGenericMonth egm) : base(egm.FID, Auxiliary.MonthStart(egm.Month), Auxiliary.MonthEnd(egm.Month), egm.LBFolder.Text, egm.CBKeep.Checked, egm.CBProcess.Checked)
        {
            logger.Info(LOG.ESIOS_MONTH);
            this.unzip = egm.CBUnzip.Checked;
            this.file = egm.LBFile.Text;
        }
    }
}

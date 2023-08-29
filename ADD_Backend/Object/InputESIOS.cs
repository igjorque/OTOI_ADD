using System;
using log4net;
using ADD_Backend.Function;
using ADD_Backend.Variable;

namespace ADD_Backend.Object
{
    /// <summary>
    /// ESIOS Input class
    /// </summary>
    public class InputESIOS : Input
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private bool unzip;
        private string file;

        public bool Unzip { get => this.unzip; }
        public string File { get => this.file; }

        /// <summary>
        /// Default empty constructor.
        /// </summary>
        public InputESIOS() : base() 
        {
            this.unzip = false;
            this.file = "";
        }
        // TODO: check usage
        /*
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
        */
        /// <summary>
        /// Builds an [Input] object using a SingleGeneric type form's fields.
        /// </summary>
        /// <param name="egm">C2L form</param>
        public InputESIOS(int FID, DateTime month, string lbfolder, bool cbkeep, bool cbprocess, bool cbunzip, string lbfile) : base(FID, Auxiliary.MonthStart(month), Auxiliary.MonthEnd(month), lbfolder, cbkeep, cbprocess)
        {
            logger.Info(LOG.ESIOS_MONTH);
            this.unzip = cbunzip;
            this.file = lbfile;
        }
    }
}

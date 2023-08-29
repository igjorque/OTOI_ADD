using System;
using log4net;
using ADD_Backend.Function;
using ADD_Backend.Variable;
using System.Windows.Forms;

namespace ADD_Backend.Object
{
    /// <summary>
    /// OMIE Input class
    /// </summary>
    public class InputOMIE : Input
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private string destFile;

        public string DestFile { get => destFile; }

        /// <summary>
        /// Default empty constructor.
        /// </summary>
        public InputOMIE() : base()
        {
            this.destFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        // TODO: check usage
        /*
        /// <summary>
        /// Builds an [Input] object using a SingleGeneric type form's fields.
        /// </summary>
        /// <param name="ogd">SingleGeneric form</param>
        public InputOMIE(OGenericDay ogd) : base(ogd.FID, ogd.Day, ogd.Day, ogd.LBFolder.Text, ogd.CBKeep.Checked, ogd.CBProcess.Checked)
        {
            logger.Info(LOG.OMIE_DAY);
            this.destFile = ogd.LBFile.Text;
        }
        */
        /// <summary>
        /// Builds an [Input] object using a SingleGeneric type form's fields.
        /// </summary>
        /// <param name="ogd">SingleGeneric form</param>
        public InputOMIE(int FID, DateTime day, string lbfolder, bool cbkeep, bool cbprocess, string lbfile) : base(FID, day, day, lbfolder, cbkeep, cbprocess)
        {
            logger.Info(LOG.OMIE_DAY);
            this.destFile = lbfile;
        }

        // TODO: check usage
        /*
        /// <summary>
        /// Builds an [Input] object using a MultiGeneric type form's fields.
        /// </summary>
        /// <param name="ogr">MultiGeneric form</param>
        public InputOMIE(OGenericRange ogr) : base(ogr.FID, ogr.Start, ogr.End, ogr.LBFolder.Text, ogr.CBKeep.Checked, ogr.CBProcess.Checked)
        {
            logger.Info(LOG.OMIE_RANGE);
            this.destFile = ogr.LBFile.Text;
        }
        */
        /// <summary>
        /// Builds an [Input] object using a MultiGeneric type form's fields.
        /// </summary>
        /// <param name="ogr">MultiGeneric form</param>
        public InputOMIE(int FID, DateTime start, DateTime end, string lbfolder, bool cbkeep, bool cbprocess, string lbfile) : base(FID, start, end, lbfolder, cbkeep, cbprocess)
        {
            logger.Info(LOG.OMIE_RANGE);
            this.destFile = lbfile;
        }

        //TODO: check usage
        /*
        /// <summary>
        /// Builds an [Input] object using a MultiGeneric type form's fields.
        /// </summary>
        /// <param name="ogm">MultiGeneric form</param>
        public InputOMIE(OGenericMonth ogm) : base(ogm.FID, Auxiliary.MonthStart(ogm.Month), Auxiliary.MonthEnd(ogm.Month), ogm.LBFolder.Text, ogm.CBKeep.Checked, ogm.CBProcess.Checked)
        {
            logger.Info(LOG.OMIE_MONTH);
            this.destFile = ogm.LBFile.Text;
        }
        */
        /// <summary>
        /// Builds an [Input] object using a MultiGeneric type form's fields.
        /// </summary>
        /// <param name="ogm">MultiGeneric form</param>
        public InputOMIE(int FID, DateTimePicker month, string lbfolder, bool cbkeep, bool cbprocess, string lbfile) : base(FID, Auxiliary.MonthStart(month.Value), Auxiliary.MonthEnd(month.Value), lbfolder, cbkeep, cbprocess)
        {
            logger.Info(LOG.OMIE_MONTH);
            this.destFile = lbfile;
        }
    }
}

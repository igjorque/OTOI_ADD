using log4net;
using log4net.Config;
using OTOI_ADD.Code.Module.Style;
using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Generic.ESIOS;
using OTOI_ADD.View.Generic.OMIE;
using System.Reflection;

namespace OTOI_ADD.Code.Module.Function
{
    /// <summary>
    /// Application Configuration Manager
    /// </summary>
    internal static class AppConfigManager
    {
        /// <summary>
        /// General initialization handler
        /// </summary>
        internal static void Initialize()
        {
            RebuildFileSystem();
            InitFileSystem();
            InitLogger();
        }

        // Private initialization functions
        #region Private init functions

        /// <summary>
        /// Rebuilds the program's file system if it's an older version
        /// </summary>
        private static void RebuildFileSystem()
        {
            // USAR SOLO SI SE NECESITA BORRAR LA ESTRUCTURA
            if (Directory.GetCreationTime(GLB.FOLDER_CONFIG) < new DateTime(2023, 5, 5, 8, 0, 0))
            {
                Directory.Delete(GLB.FOLDER_CONFIG, true);
            }
        }

        /// <summary>
        /// Initializes the app file system - configs, logs, downloads...
        /// </summary>
        private static void InitFileSystem()
        {
            // Create Default Folder if not exists
            if (!Directory.Exists(GLB.FOLDER_DEFAULT)) Directory.CreateDirectory(GLB.FOLDER_DEFAULT);
            // Create Config Folder if not exists
            if (!Directory.Exists(GLB.FOLDER_CONFIG)) Directory.CreateDirectory(GLB.FOLDER_CONFIG);
            // Create Logs Folder if not exists
            if (!Directory.Exists(GLB.FOLDER_LOGS)) Directory.CreateDirectory(GLB.FOLDER_LOGS);
            //Create Downloads Folder if not exists
            if (!Directory.Exists(GLB.FOLDER_DOWNLOADS)) Directory.CreateDirectory(GLB.FOLDER_DOWNLOADS);

            // Create logger config file if not exists
            if (!File.Exists(GLB.FIL_L4N)) InitLogConfig();
        }

        /// <summary>
        /// Initializes the loggers config file
        /// </summary>
        private static void InitLogConfig()
        {
            using FileStream fs = File.Open(GLB.FIL_L4N, FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sw.WriteLine("<configuration>");
            sw.WriteLine("  <log4net>");
            sw.WriteLine("      <root>");
            sw.WriteLine("          <level value=\"ALL\" />");
            sw.WriteLine("          <appender-ref ref=\"all_logs_file\" />");
            sw.WriteLine("      </root>");
            sw.WriteLine("      <appender name=\"all_logs_file\" type=\"log4net.Appender.RollingFileAppender\">");
            sw.WriteLine("          <file value=\"" + GLB.LOC_LOG + "\" />");
            sw.WriteLine("          <datePattern value=\"'log_'dd-MM-yyyy'.log'\" />");
            sw.WriteLine("          <staticLogFileName value=\"false\" />");
            sw.WriteLine("          <appendToFile value=\"true\" />");
            sw.WriteLine("          <rollingStyle value=\"Composite\" />");
            sw.WriteLine("          <maxSizeRollBackups value=\"10\" />");
            sw.WriteLine("          <layout type=\"log4net.Layout.PatternLayout\">");
            sw.WriteLine("              <conversionPattern value=\"[%date] > [%level] > [%logger] > %newline   ==> %message %newline %newline\" />");
            sw.WriteLine("          </layout>");
            sw.WriteLine("      </appender>");
            sw.WriteLine("  </log4net>");
            sw.WriteLine("</configuration>");
        }

        /// <summary>
        /// Initializes the logger configuration
        /// </summary>
        private static void InitLogger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo(GLB.FIL_L4N));
        }
        #endregion

        /// <summary>
        /// Saves the current app configuration params
        /// </summary>
        /// <param name="f">Current form</param>
        /// <param name="FID">Current form ID</param>
        internal static void Save(Form f, int FID)
        {
            if (f is OGenericDay)
            {
                OGenericDay foday = (OGenericDay)f;
                OGenericParams(foday);
                OTOI_ADD.Properties.Settings.Default.DAY = foday.CADay.Value;
            } 
            else if (f is OGenericMonth)
            {
                OGenericMonth fomth = (OGenericMonth)f;
                OGenericParams(fomth);
                OTOI_ADD.Properties.Settings.Default.MONTH = fomth.MPMonth.Value;
            } 
            else if (f is OGenericRange)
            {
                OGenericRange forng = (OGenericRange)f;
                OGenericParams(forng);
                OTOI_ADD.Properties.Settings.Default.START = forng.CAStart.Value;
                OTOI_ADD.Properties.Settings.Default.END = forng.CAEnd.Value;
            } 
            else if (f is EGenericMonth)
            {
                EGenericMonth femth = (EGenericMonth)f;
                EGenericParams(femth);
                OTOI_ADD.Properties.Settings.Default.MONTH = femth.MPMonth.Value;
            }
        }

        /// <summary>
        /// Saves the common OMIE forms params.
        /// </summary>
        /// <param name="fo">OMIE form</param>
        private static void OGenericParams(OGeneric fo)
        {
            // DL
            OTOI_ADD.Properties.Settings.Default.DIRECTORY = fo.LBFolder.Text;
            // PR
            OTOI_ADD.Properties.Settings.Default.O_PROCESS = fo.CBProcess.Checked;
            // KP
            OTOI_ADD.Properties.Settings.Default.O_KEEP = fo.CBKeep.Checked;
        }

        /// <summary>
        /// Saves the common ESIOS forms params.
        /// </summary>
        /// <param name="fe">ESIOS form</param>
        private static void EGenericParams(EGeneric fe)
        {
            // DL
            OTOI_ADD.Properties.Settings.Default.DIRECTORY = fe.LBFolder.Text;
            // UZ
            OTOI_ADD.Properties.Settings.Default.E_UNZIP = fe.CBUnzip.Checked;
            // PR
            OTOI_ADD.Properties.Settings.Default.E_PROCESS = fe.CBProcess.Checked;
            // KP
            OTOI_ADD.Properties.Settings.Default.E_KEEP = fe.CBKeep.Checked;
        }
    }
}

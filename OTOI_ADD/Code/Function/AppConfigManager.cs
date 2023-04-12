using log4net;
using log4net.Config;
using OTOI_ADD.Code.Variable;
using System.Reflection;

namespace OTOI_ADD.Code.Function
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
            InitAppConfig();
            InitLogger();
        }

        // Private initialization functions
        #region Private init functions

        /// <summary>
        /// Rebuilds the program's file system if it's an older version
        /// </summary>
        private static void RebuildFileSystem()
        {
            if (Directory.GetCreationTime(GLB.FOLDER_CONFIG) < new DateTime(2023, 4, 12, 13, 38, 0))
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
            
            // Create app parameters file if not exists
            if (!File.Exists(GLB.FIL_CFG)) InitParamConfig();
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
            sw.WriteLine("      <appender name=\"all_logs_file\" type=\"log4net.Appender.FileAppender\">");
            sw.WriteLine("          <file value=\"" + GLB.LOC_LOG + "\" />");
            sw.WriteLine("          <layout type=\"log4net.Layout.PatternLayout\">");
            sw.WriteLine("              <conversionPattern value=\"[%date] > [%level] > [%logger] > %newline   ==> %message %newline %newline\" />");
            sw.WriteLine("          </layout>");
            sw.WriteLine("      </appender>");
            sw.WriteLine("  </log4net>");
            sw.WriteLine("</configuration>");
        }

        /// <summary>
        /// Initializes the parameter configuration file
        /// </summary>
        private static void InitParamConfig()
        {
            using FileStream fs = File.Open(GLB.FIL_CFG, FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);
            // Create Dates
            sw.WriteLine("STR=01/01/2023");
            sw.WriteLine("END=31/01/2023");
            sw.WriteLine("DAY=01/01/2023");
            sw.WriteLine("MTH=01/01/2023");

            // Create Path
            sw.WriteLine("DIR=" + GLB.FOLDER_DOWNLOADS);
        }

        /// <summary>
        /// Initializes the application configuration parameters
        /// </summary>
        private static void InitAppConfig()
        {
            using FileStream fs = File.Open(GLB.FIL_CFG, FileMode.Open);
            using StreamReader sr = new(fs);
            Dictionary<string, string> cfg = new();
            string? ln;
            string[] lns;

            while ((ln = sr.ReadLine()) != null)
            {
                lns = ln.Split("=");
                cfg.Add(lns[0], lns[1]);
            }

            // Parse Dates
            string? str = cfg["STR"];
            if (str != null) VAR.RANGE_START = DateTime.Parse(str);
            string? end = cfg["END"];
            if (end != null) VAR.RANGE_END = DateTime.Parse(end);
            string? day = cfg["DAY"];
            if (day != null) VAR.DATE_DAY = DateTime.Parse(day);
            string? mth = cfg["MTH"];
            if (mth != null) VAR.DATE_MONTH = DateTime.Parse(mth);

            // Parse Path
            string? dir = cfg["DIR"];
            if (dir != null) VAR.CURRENT_DIRECTORY = dir;
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
        /// Saves the current app configuration
        /// </summary>
        internal static void Save()
        {
            using FileStream fs = File.Open(GLB.FIL_CFG, FileMode.Create);
            using StreamWriter sw = new(fs);

            // Save Dates
            sw.WriteLine("STR=" + VAR.RANGE_START.ToShortDateString());
            sw.WriteLine("END=" + VAR.RANGE_END.ToShortDateString());
            sw.WriteLine("DAY=" + VAR.DATE_DAY.ToShortDateString());
            sw.WriteLine("MTH=" + VAR.DATE_MONTH.ToShortDateString());

            // Save Path
            sw.WriteLine("DIR=" + VAR.CURRENT_DIRECTORY);
        }
    }
}

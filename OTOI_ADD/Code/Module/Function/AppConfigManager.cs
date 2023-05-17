using log4net;
using log4net.Config;
using OTOI_ADD.Code.Module.Style;
using OTOI_ADD.Code.Variable;
using System.Reflection;
using Prop = OTOI_ADD.Properties.Settings;

namespace OTOI_ADD.Code.Module.Function
{
    /// <summary>
    /// Application Configuration Manager class
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
            LoadAppConfig();
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
            if (Directory.GetCreationTime(GLB.FOLDER_CONFIG) < new DateTime(2023, 5, 8, 6, 0, 0))
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
            if (!File.Exists(GLB.FILE_L4N)) InitLogConfig();
        }

        /// <summary>
        /// Loads the app config settings, if the file exists.
        /// </summary>
        private static void LoadAppConfig()
        {
            if (File.Exists(GLB.FILE_CONFIG))
            {
                InitSettings();
            } 
            else
            {
                InitSettingsFile();
                InitSettings();
            }
        }

        /// <summary>
        /// Initializes the application settings using a config file.
        /// </summary>
        private static void InitSettings()
        {
            string? line;
            string[] lineSpl;
            string key, value;

            Dictionary<string, string> cfg = new Dictionary<string, string>();

            using StreamReader sr = new StreamReader(GLB.FILE_CONFIG);
            while((line = sr.ReadLine()) != null)
            {
                lineSpl = line.Split("=");
                key = lineSpl[0];
                value = lineSpl[1];
                cfg.Add(key, value);
            }

            Prop.Default.CFG_LOAD = Boolean.Parse(cfg["CFG_LOAD"]);
            Prop.Default.CFG_SAVE = Boolean.Parse(cfg["CFG_SAVE"]);
            Prop.Default.DIRECTORY = cfg["DIRECTORY"];
            Prop.Default.THEME = Boolean.Parse(cfg["THEME"]);
            Styler.MODE = Boolean.Parse(cfg["THEME"]);
            Prop.Default.LANG = cfg["LANG"];

            Prop.Default.DAY = DateTime.Parse(cfg["DAY"]);
            Prop.Default.MONTH = DateTime.Parse(cfg["MONTH"]);
            Prop.Default.START = DateTime.Parse(cfg["START"]);
            Prop.Default.END = DateTime.Parse(cfg["END"]);

            Prop.Default.O_PROCESS = Boolean.Parse(cfg["O_PROCESS"]);
            Prop.Default.O_KEEP = Boolean.Parse(cfg["O_KEEP"]);
            Prop.Default.E_UNZIP = Boolean.Parse(cfg["E_UNZIP"]);
            Prop.Default.E_KEEP = Boolean.Parse(cfg["E_KEEP"]);
            Prop.Default.E_PROCESS = Boolean.Parse(cfg["E_PROCESS"]);
            
        }

        /// <summary>
        /// Initializes the loggers config file
        /// </summary>
        private static void InitLogConfig()
        {
            using FileStream fs = File.Open(GLB.FILE_L4N, FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sw.WriteLine("<configuration>");
            sw.WriteLine("  <log4net>");
            sw.WriteLine("      <root>");
            sw.WriteLine("          <level value=\"ALL\" />");
            sw.WriteLine("          <appender-ref ref=\"all_logs_file\" />");
            sw.WriteLine("      </root>");
            sw.WriteLine("      <appender name=\"all_logs_file\" type=\"log4net.Appender.RollingFileAppender\">");
            sw.WriteLine("          <file value=\"" + GLB.LOCATION_LOG + "\" />");
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
        /// Creates the applications settings file
        /// </summary>
        private static void InitSettingsFile()
        {
            using FileStream fs = File.Open(GLB.FILE_CONFIG, FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);
            sw.WriteLine("CFG_LOAD=True");
            sw.WriteLine("CFG_SAVE=True");
            sw.WriteLine("DIRECTORY=C:\\OTOI_ADD\\downloads");
            sw.WriteLine("FILE=Por defecto"); // TODO: remove hardcoded text
            sw.WriteLine("THEME=False");
            sw.WriteLine("LANG=ES");
            sw.WriteLine("START=01/01/2023");
            sw.WriteLine("END=31/01/2023");
            sw.WriteLine("DAY=01/01/2023");
            sw.WriteLine("MONTH=01/01/2023");
            sw.WriteLine("O_PROCESS=False");
            sw.WriteLine("O_KEEP=False");
            sw.WriteLine("E_UNZIP=False");
            sw.WriteLine("E_KEEP=False");
            sw.WriteLine("E_PROCESS=False");
        }

        /// <summary>
        /// Initializes the logger configuration
        /// </summary>
        private static void InitLogger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo(GLB.FILE_L4N));
        }
        #endregion

        /// <summary>
        /// Saves the current app configuration params
        /// </summary>
        internal static void Save()
        {
            if (File.Exists(GLB.FILE_CONFIG))
            {
                File.Delete(GLB.FILE_CONFIG);
            }
            using FileStream fs = File.Open(GLB.FILE_CONFIG, FileMode.OpenOrCreate);
            using StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("CFG_LOAD=" + Prop.Default.CFG_LOAD.ToString());
            sw.WriteLine("CFG_SAVE=" + Prop.Default.CFG_SAVE.ToString());
            sw.WriteLine("DIRECTORY=" + Prop.Default.DIRECTORY.ToString());
            sw.WriteLine("FILE=" + Prop.Default.FILE.ToString());
            sw.WriteLine("THEME=" + Prop.Default.THEME.ToString());
            sw.WriteLine("LANG=" + Prop.Default.LANG.ToString());
            sw.WriteLine("START=" + Prop.Default.START.ToString());
            sw.WriteLine("END=" + Prop.Default.END.ToString());
            sw.WriteLine("DAY=" + Prop.Default.DAY.ToString());
            sw.WriteLine("MONTH=" + Prop.Default.MONTH.ToString());
            sw.WriteLine("O_PROCESS=" + Prop.Default.O_PROCESS.ToString());
            sw.WriteLine("O_KEEP=" + Prop.Default.O_KEEP.ToString());
            sw.WriteLine("E_UNZIP=" + Prop.Default.E_UNZIP.ToString());
            sw.WriteLine("E_KEEP=" + Prop.Default.E_KEEP.ToString());
            sw.WriteLine("E_PROCESS=" + Prop.Default.E_PROCESS.ToString());
        }
    }
}

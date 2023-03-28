using log4net;
using log4net.Config;
using OTOI_ADD.Code.Function;
using OTOI_ADD.View;
using System.Reflection;

namespace OTOI_ADD
{
    internal static class Program
    {

        private static log4net.ILog? logger;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create C:/OTOI_ADD/log4net.config if not exists
            if (!Directory.Exists("C:\\OTOI_ADD")) Directory.CreateDirectory("C:\\OTOI_ADD");
            
            // Initialize logger config file if not exists
            if (!File.Exists("C:\\OTOI_ADD\\log4net.config")) InitLogConfig();
            
            // Create log file if not exists
            if (!File.Exists("C:\\OTOI_ADD\\log.log")) File.Create("C:\\OTOI_ADD\\log.log");
            
            // Copy log file
            File.Copy("C:\\OTOI_ADD\\log.log", "C:\\OTOI_ADD\\log_cpy.log", true);

            // Create app parameters file if not exists
            if (!File.Exists("C:\\OTOI_ADD\\app_params.config")) InitParamConfig();
            
            // TODO: Init app config
            //AppConfigManager.Initialize();

            // Initialize logger configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            // Debug config
            XmlConfigurator.Configure(logRepository, new FileInfo("C:\\OTOI_ADD\\log4net.config"));
            logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            logger.Info("Program - Loading");

            // Run app
            Application.Run(new Main());

            logger.Info("Program - Shutdown");
        }

        private static void InitLogConfig()
        {
            using FileStream fs = File.Open("C:\\OTOI_ADD\\log4net.config", FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sw.WriteLine("<configuration>");
            sw.WriteLine("  <log4net>");
            sw.WriteLine("      <root>");
            sw.WriteLine("          <level value=\"ALL\" />");
            sw.WriteLine("          <appender-ref ref=\"all_logs_file\" />");
            sw.WriteLine("      </root>");
            sw.WriteLine("      <appender name=\"all_logs_file\" type=\"log4net.Appender.FileAppender\">");
            sw.WriteLine("          <file value=\"C:\\\\OTOI_ADD\\\\log.log\" />");
            sw.WriteLine("          <layout type=\"log4net.Layout.PatternLayout\">");
            sw.WriteLine("              <conversionPattern value=\"[%date] > [%level] > [%logger] > [%message]%newline\" />");
            sw.WriteLine("          </layout>");
            sw.WriteLine("      </appender>");
            sw.WriteLine("  </log4net>");
            sw.WriteLine("</configuration>");
        }

        private static void InitParamConfig()
        {
            using FileStream fs = File.Open("C:\\OTOI_ADD\\app_params.config", FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);
            sw.WriteLine("STR=01/01/2023");
            sw.WriteLine("END=31/01/2023");
            sw.WriteLine("DIR=C:\\OTOI_ADD");
            sw.WriteLine("FIL=C:\\OTOI_ADD\\ejemplo.csv");
            sw.WriteLine("MTH=01/01/2023");
        }
    }
}
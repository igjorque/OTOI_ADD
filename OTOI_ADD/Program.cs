using log4net;
using log4net.Config;
using OTOI_ADD.View;
using System.Reflection;


//[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

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
            // Create C:/OTOI_ADD/log4net.config if doesn't exist
            if (!Directory.Exists("C:\\OTOI_ADD"))
            {
                Directory.CreateDirectory("C:\\OTOI_ADD");
            }
            if (!File.Exists("C:\\OTOI_ADD\\log4net.config"))
            {
                InitConfig();
            }

            // Create log file if doesn't exist
            if (!File.Exists("C:\\OTOI_ADD\\log.log"))
            {
                File.Create("C:\\OTOI_ADD\\log.log");
            }
            // Copy log file
            File.Copy("C:\\OTOI_ADD\\log.log", "C:\\OTOI_ADD\\log_cpy.log", true);

            // Initialize logger configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            // Debug config
            XmlConfigurator.Configure(logRepository, new FileInfo("C:\\OTOI_ADD\\log4net.config"));

            logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            logger.Info("Application - Loading");

            // TODO: Init app config
            ApplicationConfiguration.Initialize();
            // Run app
            Application.Run(new Main());

            logger.Info("Application - Shutdown");
        }

        private static void InitConfig()
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
    }
}
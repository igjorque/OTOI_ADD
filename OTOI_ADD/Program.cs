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
            if (!File.Exists("C:\\OTOI_ADD\\log4net.config")) AppConfigManager.InitLogConfig();
            
            // Create log file if not exists
            if (!File.Exists("C:\\OTOI_ADD\\log.log")) File.Create("C:\\OTOI_ADD\\log.log");
            
            // Copy log file
            File.Copy("C:\\OTOI_ADD\\log.log", "C:\\OTOI_ADD\\log_cpy.log", true);

            // Create app parameters file if not exists
            if (!File.Exists("C:\\OTOI_ADD\\app_params.config")) AppConfigManager.InitParamConfig();
            
            // TODO: Init app config
            AppConfigManager.Initialize();

            // Initialize logger configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("C:\\OTOI_ADD\\log4net.config"));

            // Init logger
            logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            logger.Info("Program - Loading");

            // DO NOT ERASE THIS LINE
            ApplicationConfiguration.Initialize();

            // Run app
            Application.Run(new Main());

            logger.Info("Program - Shutdown");
        }
    }
}
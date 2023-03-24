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
            // Initialize logger configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            logger.Info("Application - Loading");

            // TODO: Init app config
            ApplicationConfiguration.Initialize();
            // Run app
            Application.Run(new Main());

            logger.Info("Application - Shutdown");
        }
    }
}
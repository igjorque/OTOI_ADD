using ADD_Backend.Variable;
using ADD_Frontend.Code.Module.Function;
using ADD_Frontend.View;
using log4net;
using System.Reflection;

namespace ADD_Frontend
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
            // App init region
            #region App initialization

            // Init custom app configurations
            AppConfigManager.Initialize();

            // DO NOT ERASE THIS LINE - Init app configurations
            ApplicationConfiguration.Initialize();

            #endregion

            // Init logger
            logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            logger.Info(LOG.APP_START);

            // Run app
            Application.Run(new Main());

            logger.Info(LOG.APP_END);
        }
    }
}
using log4net;
using log4net.Config;
using OTOI_ADD.Code.Module.Function;
using OTOI_ADD.Code.Variable;
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
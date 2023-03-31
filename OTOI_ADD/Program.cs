using log4net;
using log4net.Config;
using OTOI_ADD.Code.Function;
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
            // TODO: Create AppConfigManager.InitFiles()

            // Create Default Folder if not exists
            if (!Directory.Exists(GLB.FLD_DEF)) Directory.CreateDirectory(GLB.FLD_DEF);
            // Create Config Folder if not exists
            if (!Directory.Exists(GLB.FLD_DEF + GLB.FLD_CFG)) Directory.CreateDirectory(GLB.FLD_DEF + GLB.FLD_CFG);
            // Create Logs Folder if not exists
            if (!Directory.Exists(GLB.FLD_DEF + GLB.FLD_LOG)) Directory.CreateDirectory(GLB.FLD_DEF + GLB.FLD_LOG);
            //Create Downloads Folder if not exists
            if (!Directory.Exists(GLB.FLD_DEF + GLB.FLD_DWL)) Directory.CreateDirectory(GLB.FLD_DEF + GLB.FLD_DWL);

            // Create logger config file if not exists
            if (!File.Exists(GLB.FLD_DEF + GLB.FIL_L4N)) AppConfigManager.InitLogConfig(GLB.FLD_DEF + GLB.FIL_L4N);
            // Create log file if not exists
            if (!File.Exists(GLB.FLD_DEF + GLB.FIL_LOG)) File.Create(GLB.FLD_DEF + GLB.FIL_LOG);
            // Create app parameters file if not exists
            if (!File.Exists(GLB.FLD_DEF + GLB.FIL_CFG)) AppConfigManager.InitParamConfig(GLB.FLD_DEF + GLB.FIL_CFG);

            // TODO: Init app config
            AppConfigManager.Initialize();

            // Initialize logger configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo(GLB.FLD_DEF + GLB.FIL_L4N));

            // Init logger
            logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            logger.Info("Program - " + LOG.PRG_STR);

            // DO NOT ERASE THIS LINE
            ApplicationConfiguration.Initialize();

            // Run app
            Application.Run(new Main());

            logger.Info("Program - " + LOG.PRG_END);
        }
    }
}
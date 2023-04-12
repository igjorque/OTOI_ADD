namespace OTOI_ADD.Code.Variable
{
    /// <summary>
    /// Global variables - Can't be modified
    /// </summary>
    internal static class GLB
    {
        // REGISTRY
        // USED IDs: 1, 2, 3, 4, 5, 6

        // OMIE
        #region OMIE GLOBAL FIELDS
        // TITLE
        /// <summary>
        /// OMIE default form title
        /// </summary>
        internal static readonly string OMIE_TITLE = "OMIE";

        // HPC
        /// <summary>
        /// HPC form ID
        /// </summary>
        internal static readonly int FID_HPC = 1;
        /// <summary>
        /// HPCM form ID
        /// </summary>
        internal static readonly int FID_HPCM = 2;
        /// <summary>
        /// HPC uri substring
        /// </summary>
        internal static readonly string HPC_URI = "INT_MAJ_EV_H";
        /// <summary>
        /// HPC form default title
        /// </summary>
        internal static readonly string HPC_TITLE = "Precio definitivo horario del mecanismo de ajuste a los consumidores en el mercado";
        

        // HM
        /// <summary>
        /// HM form ID
        /// </summary>
        internal static readonly int FID_HM = 3;
        /// <summary>
        /// HMM form ID
        /// </summary>
        internal static readonly int FID_HMM = 4;
        /// <summary>
        /// HM uri substring
        /// </summary>
        internal static readonly string HM_URI = "INT_PBC_EV_H_1";
        /// <summary>
        /// HMT form ID
        /// </summary>
        internal static readonly int FID_HMT = 6;
        /// <summary>
        /// HMT uri substring
        /// </summary>
        internal static readonly string HMT_URI = "INT_PDBC_PRECIO_5";
        /// <summary>
        /// HM form default title
        /// </summary>
        internal static readonly string HM_TITLE = "Precio horario del mercado";
        
        #endregion

        // ESIOS
        #region ESIOS GLOBAL FIELDS
        // TITLE
        // TODO: borrar?
        /// <summary>
        /// ESIOS default form title
        /// </summary>
        internal static readonly string ESIOS_TITLE = "ESIOS";

        // C2L
        /// <summary>
        /// C2L form ID
        /// </summary>
        internal static readonly int FID_C2L = 5;
        /// <summary>
        /// C2L form default title
        /// </summary>
        internal static readonly string C2L_TITLE = "C2 Liquicomun";
        #endregion

        // DEFAULTS
        #region APPLICATION GLOBALS
        // Aux
        /// <summary>
        /// Exact moment when this class is loaded
        /// </summary>
        private static readonly long now = DateTime.Now.Ticks;

        // Default app folder
        /// <summary>
        /// ADDs default unit
        /// </summary>
        private static readonly string unit = "C:";
        /// <summary>
        /// ADDs default folder
        /// </summary>
        private static readonly string def_folder = "\\OTOI_ADD";
        /// <summary>
        /// ADDs default config/downloads path
        /// </summary>
        internal static readonly string FOLDER_DEFAULT = unit + def_folder;

        // Default internal folders
        /// <summary>
        /// ADDs config folder path
        /// </summary>
        internal static readonly string FOLDER_CONFIG = FOLDER_DEFAULT + "\\config";
        /// <summary>
        /// Logs folder name
        /// </summary>
        private static readonly string log_fld_name = "\\logs";
        /// <summary>
        /// ADDs logs destination folder path
        /// </summary>
        internal static readonly string FOLDER_LOGS = FOLDER_DEFAULT + log_fld_name;
        /// <summary>
        /// ADDs default downloads path
        /// </summary>
        internal static readonly string FOLDER_DOWNLOADS = FOLDER_DEFAULT + "\\downloads";

        // Config files
        /// <summary>
        /// ADDs general config file path
        /// </summary>
        internal static readonly string FIL_CFG = FOLDER_CONFIG + "\\app_params.config";
        /// <summary>
        /// ADDs logger config file path
        /// </summary>
        internal static readonly string FIL_L4N = FOLDER_CONFIG + "\\log4net.config";

        // Default log file location
        /// <summary>
        /// Log file name for current execution
        /// </summary>
        private static readonly string log_file = "\\log_" + now + ".log";
        /// <summary>
        /// Log file full path
        /// </summary>
        internal static readonly string FIL_LOG = FOLDER_LOGS + log_file;
        /// <summary>
        /// Logger configs log full path
        /// </summary>
        internal static readonly string LOC_LOG = unit +"\\"+ def_folder +"\\"+ log_fld_name +"\\"+ log_file;
        #endregion

        // ABOUT
        #region ABOUT MESSAGES
        /// <summary>
        /// About MessageBox caption (title)
        /// </summary>
        internal static readonly string ABOUT_TITLE = "Acerca de ADD";
        /// <summary>
        /// About MessageBox program developer
        /// </summary>
        internal static readonly string ABOUT_DEVELOPER = "Programa desarrollado por Ignacio A. Jorquera Ferrat para la Oficina Técnica de Obras e Infraestructuras (OTOI) - Universidad de La Rioja.";
        /// <summary>
        /// About MessageBox program description
        /// </summary>
        internal static readonly string ABOUT_DESCRIPTION = "\nAgiliza la descarga de datos de las webs OMIE y ESIOS.";
        #endregion
    }
}

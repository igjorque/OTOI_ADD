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

        // HPC
        /// <summary>
        /// HPC form ID (1)
        /// </summary>
        internal static readonly int FID_HPC = 1;
        /// <summary>
        /// HPCM form ID (2)
        /// </summary>
        internal static readonly int FID_HPCM = 2;
        /// <summary>
        /// HPC uri substring
        /// </summary>
        internal static readonly string URI_HPC = "INT_MAJ_EV_H";
        /// <summary>
        /// HPC form default title
        /// </summary>
        internal static readonly string TITLE_HPC = "Precio definitivo horario del mecanismo de ajuste a los consumidores en el mercado";
        
        // HM
        /// <summary>
        /// HM form ID (3)
        /// </summary>
        internal static readonly int FID_HM = 3;
        /// <summary>
        /// HMM form ID (4)
        /// </summary>
        internal static readonly int FID_HMM = 4;
        /// <summary>
        /// HM uri substring
        /// </summary>
        internal static readonly string URI_HM = "INT_PBC_EV_H_1";
        /// <summary>
        /// HMT form ID (6)
        /// </summary>
        internal static readonly int FID_HMT = 6;
        /// <summary>
        /// HMT uri substring
        /// </summary>
        internal static readonly string URI_HMT = "INT_PDBC_PRECIO_5";
        /// <summary>
        /// HM form default title
        /// </summary>
        internal static readonly string TITLE_HM = "Precio horario del mercado";
        
        #endregion

        // ESIOS
        #region ESIOS GLOBAL FIELDS

        // C2L
        /// <summary>
        /// C2L form ID (5)
        /// </summary>
        internal static readonly int FID_C2L = 5;
        /// <summary>
        /// C2L form default title
        /// </summary>
        internal static readonly string TITLE_C2L = "C2 Liquicomun";
        #endregion

        // DEFAULTS
        #region APPLICATION GLOBALS

        // Default app folder
        /// <summary>
        /// ADDs default unit
        /// </summary>
        private static readonly string unit = "C:";
        /// <summary>
        /// ADDs default folder
        /// </summary>
        private static readonly string def_folder = @"\OTOI_ADD";
        /// <summary>
        /// ADDs default config/downloads path
        /// </summary>
        internal static readonly string FOLDER_DEFAULT = unit + def_folder;

        // Default internal folders
        /// <summary>
        /// ADDs config folder path
        /// </summary>
        internal static readonly string FOLDER_CONFIG = $@"{FOLDER_DEFAULT}\config";
        /// <summary>
        /// Logs folder name
        /// </summary>
        private static readonly string log_fld_name = @"\logs";
        /// <summary>
        /// ADDs logs destination folder path
        /// </summary>
        internal static readonly string FOLDER_LOGS = $"{FOLDER_DEFAULT}{log_fld_name}";
        /// <summary>
        /// ADDs default downloads path
        /// </summary>
        internal static readonly string FOLDER_DOWNLOADS = $@"{FOLDER_DEFAULT}\downloads";

        // Config files
        /// <summary>
        /// ADDs general config file path
        /// </summary>
        internal static readonly string FILE_CONFIG = $@"{FOLDER_CONFIG}\app_params.config";
        /// <summary>
        /// ADDs logger config file path
        /// </summary>
        internal static readonly string FILE_L4N = $@"{FOLDER_CONFIG}\log4net.config";

        // Default log file location
        /// <summary>
        /// Logger configs log full path
        /// </summary>
        internal static readonly string LOCATION_LOG = $@"{unit}\{def_folder}\{log_fld_name}\";
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

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
        internal static readonly string OMIE_TLE = "OMIE";

        // HPC
        internal static readonly int FID_HPC = 1;
        internal static readonly int FID_HPCM = 2;
        internal static readonly string HPC_TLE = "Precio definitivo horario del mecanismo de ajuste a los consumidores en el mercado";

        // HM
        internal static readonly int FID_HM = 3;
        internal static readonly int FID_HMM = 4;
        internal static readonly int FID_HMT = 6;
        internal static readonly string HM_TLE = "Precio horario del mercado";
        #endregion

        // ESIOS
        #region ESIOS GLOBAL FIELDS
        // TITLE
        internal static readonly string ESIOS_TLE = "ESIOS";

        // C2L
        internal static readonly int FID_C2L = 5;
        internal static readonly string C2L_TLE = "C2 Liquicomun";
        #endregion

        // DEFAULTS
        #region APPLICATION GLOBALS
        // Aux
        private static readonly long now = DateTime.Now.Ticks;

        // Default app folder
        private static readonly string unit = "C:";
        private static readonly string def_folder = "\\OTOI_ADD";
        internal static readonly string FLD_DEF = unit + def_folder;

        // Default internal folders
        internal static readonly string FLD_CFG = "\\CONFIG";
        internal static readonly string FLD_LOG = "\\LOGS";
        internal static readonly string FLD_DWL = "\\DOWNLOADS";

        // Config files
        internal static readonly string FIL_CFG = FLD_CFG + "\\app_params.config";
        internal static readonly string FIL_L4N = FLD_CFG + "\\log4net.config";

        // Default log file location
        private static readonly string log_file = "\\log_" + now + ".log";
        internal static readonly string FIL_LOG = FLD_LOG + log_file;
        internal static readonly string LOC_LOG = unit +"\\"+ def_folder +"\\"+ FLD_LOG +"\\"+ log_file;
        #endregion
    }
}

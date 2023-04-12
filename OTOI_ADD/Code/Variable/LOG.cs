namespace OTOI_ADD.Code.Variable
{
    /// <summary>
    /// Logger default messages
    /// </summary>
    internal static class LOG
    {
        // Program
        /// <summary>
        /// Application starting log message
        /// </summary>
        internal static readonly string APP_START = "Application Loading";
        /// <summary>
        /// Application closing log message
        /// </summary>
        internal static readonly string APP_END = "Application Shutdown";

        // Link
        /// <summary>
        /// Link opening log message
        /// </summary>
        internal static readonly string LINK_OPEN = "Opening Link";

        // Accept / Cancel
        /// <summary>
        /// Form accept button clicked log message
        /// </summary>
        internal static readonly string FORM_ACCEPT = "Form Accept";
        /// <summary>
        /// Form cancel button clicked log message
        /// </summary>
        internal static readonly string FORM_CANCEL = "Form Closing";

        // Field Enabling / Disabling
        /// <summary>
        /// Process checkbox checked status changed log message
        /// </summary>
        internal static readonly string FORM_PROCESS = "Process Enable Switch";
        /// <summary>
        /// Keep checkbox checked status changed log message
        /// </summary>
        internal static readonly string FORM_KEEP = "Keep Enable Switch";
        /// <summary>
        /// Unzip checkbox checked status changed log message
        /// </summary>
        internal static readonly string FORM_UNZIP = "Unzip Enable Switch";

        // Dialog
        /// <summary>
        /// Folder dialog opening log message
        /// </summary>
        internal static readonly string FORM_FOLDER = "Folder Dialog";
        /// <summary>
        /// File dialog opening log message
        /// </summary>
        internal static readonly string FORM_FILE = "File Dialog";

        // Validation
        /// <summary>
        /// Day validation log message
        /// </summary>
        internal static readonly string FORM_VALIDATE_DAY = "Validating Day";
        /// <summary>
        /// Date range validation log message
        /// </summary>
        internal static readonly string FORM_VALIDATE_RANGE = "Validating Range";
        /// <summary>
        /// Month validation log message
        /// </summary>
        internal static readonly string FORM_VALIDATE_MONTH = "Validating Month";

        // Error
        /// <summary>
        /// Error checking log message
        /// </summary>
        internal static readonly string FORM_ERROR = "Error Check";

        // Processor
        /// <summary>
        /// Processor start log message
        /// </summary>
        internal static readonly string PROCESS_START = "File processing starting";
        /// <summary>
        /// Processor end log message
        /// </summary>
        internal static readonly string PROCESS_END = "File processing ended";

        // Downloader
        /// <summary>
        /// Download success log message
        /// </summary>
        internal static readonly string DOWNLOAD_OK = "Success - "; // + concat downloaded file name
        /// <summary>
        /// Download error log message
        /// </summary>
        internal static readonly string DOWNLOAD_ERROR = "Error - "; // + concat file + uri

        // DL_OMIE
        /// <summary>
        /// OMIE download manager log message
        /// </summary>
        internal static readonly string DOWNLOAD_OMIE_MANAGE = "Managing OMIE download";

        // DL_ESIOS
        /// <summary>
        /// ESIOS download manager log message
        /// </summary>
        internal static readonly string DOWNLOAD_ESIOS_MANAGE = "Managing ESIOS download";

        // FormManager
        /// <summary>
        /// Form acceptance log message
        /// </summary>
        internal static readonly string FORM_MANAGE = "Managing form accept";

        // InputOMIE
        /// <summary>
        /// OMIE day generic form log message
        /// </summary>
        internal static readonly string OMIE_DAY = "Building day generic InputOMIE";
        /// <summary>
        /// OMIE range generic form log message
        /// </summary>
        internal static readonly string OMIE_RANGE = "Building range generic InputOMIE";
        /// <summary>
        /// OMIE month generic form log message
        /// </summary>
        internal static readonly string OMIE_MONTH = "Building month generic InputOMIE";

        // InputESIOS
        /// <summary>
        /// ESIOS month generic form log message
        /// </summary>
        internal static readonly string ESIOS_MONTH = "Building month generic InputESIOS";

        // ProgressDialog
        /// <summary>
        /// OMIE progress form build log message
        /// </summary>
        internal static readonly string PROGRESS_BUILD_OMIE = "Building OMIE download/processing progress form";
        /// <summary>
        /// ESIOS progress form build log message
        /// </summary>
        internal static readonly string PROGRESS_BUILD_ESIOS = "Building ESIOS download/processing progress form";
        /// <summary>
        /// OMIE progress form showing log message
        /// </summary>
        internal static readonly string PROGRESS_OMIE = "Showing OMIE progress";
        /// <summary>
        /// ESIOS progress form showing log message
        /// </summary>
        internal static readonly string PROGRESS_ESIOS = "Showing ESIOS progress";

        // C2L
        /// <summary>
        /// ESIOS C2L form build log message
        /// </summary>
        internal static readonly string C2L_BUILD = "Building C2L ESIOS form";

        // HM
        /// <summary>
        /// OMIE HM form build log message
        /// </summary>
        internal static readonly string HM_BLD = "Building HM OMIE form";

        // HMM
        /// <summary>
        /// OMIE HMM form build log message
        /// </summary>
        internal static readonly string HMM_BUILD = "Building HMM OMIE form";

        // HMT
        /// <summary>
        /// OMIE HMT form build log message
        /// </summary>
        internal static readonly string HMT_BUILD = "Building HMT OMIE form";

        // HPC
        /// <summary>
        /// OMIE HPC form build log message
        /// </summary>
        internal static readonly string HPC_BUILD = "Building HPC OMIE form";

        // HPCM
        /// <summary>
        /// OMIE HPCM form build log message
        /// </summary>
        internal static readonly string HPCM_BUILD = "Building HPCM OMIE form";

        // Main
        /// <summary>
        /// Program Main form build log message
        /// </summary>
        internal static readonly string MAIN_BUILD = "Building main form";
        /// <summary>
        /// Program Main form opening HPC log message
        /// </summary>
        internal static readonly string MAIN_HPC = "Opening HPC form";
        /// <summary>
        /// Program Main form opening HPCM log message
        /// </summary>
        internal static readonly string MAIN_HPCM = "Opening HPCM form";
        /// <summary>
        /// Program Main form opening HM log message
        /// </summary>
        internal static readonly string MAIN_HM = "Opening HM form";
        /// <summary>
        /// Program Main form opening HMM log message
        /// </summary>
        internal static readonly string MAIN_HMM = "Opening HMM form";
        /// <summary>
        /// Program Main form opening HMT log message
        /// </summary>
        internal static readonly string MAIN_HMT = "Opening HMT form";
        /// <summary>
        /// Program Main form opening C2L log message
        /// </summary>
        internal static readonly string MAIN_C2L = "Opening C2L form";
        /// <summary>
        /// Program Main form closing log message
        /// </summary>
        internal static readonly string MAIN_EXIT = "Closing Main form";
        /// <summary>
        /// Program Main form focusing existing form log message
        /// </summary>
        internal static readonly string MAIN_FOCUS = "Focusing ";
        /// <summary>
        /// Program Main form opening folder log message
        /// </summary>
        internal static readonly string MAIN_OPEN = "Opening folder";
        /// <summary>
        /// Program Main form uploading logs log message
        /// </summary>
        internal static readonly string MAIN_SEND = "Uploading logs";
        /// <summary>
        /// Program Main form showing documentation log message
        /// </summary>
        internal static readonly string MAIN_DOCS = "Showing app documentation";

    }
}

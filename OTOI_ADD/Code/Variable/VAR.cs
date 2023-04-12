namespace OTOI_ADD.Code.Variable
{
    /// <summary>
    /// Global variables - Modifiable
    /// </summary>
    internal class VAR
    {
        // Range
        /// <summary>
        /// Date range start
        /// </summary>
        internal static DateTime RANGE_START = DateTime.Today.AddDays(-2);
        /// <summary>
        /// Date range end
        /// </summary>
        internal static DateTime RANGE_END = DateTime.Today.AddDays(-1);

        // Day
        /// <summary>
        /// Date day
        /// </summary>
        internal static DateTime DATE_DAY = DateTime.Today.AddDays(-1);

        // Month
        /// <summary>
        /// Date month
        /// </summary>
        internal static DateTime DATE_MONTH = DateTime.Today.AddMonths(-1);

        // Current Directory
        /// <summary>
        /// Current directory
        /// </summary>
        internal static string CURRENT_DIRECTORY = GLB.FOLDER_DEFAULT;

        // Default File Text
        /// <summary>
        /// Default file
        /// </summary>
        internal static string DEFAULT_FILE = "Por defecto";
    }
}

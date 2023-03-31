using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOI_ADD.Code.Variable
{
    /// <summary>
    /// Global variables - Modifiable
    /// </summary>
    internal class VAR
    {
        // Range
        internal static DateTime RNG_STR = DateTime.Today.AddDays(-2);
        internal static DateTime RNG_END = DateTime.Today.AddDays(-1);

        // Day
        internal static DateTime DTE_DAY = DateTime.Today.AddDays(-1);

        // Month
        internal static DateTime DTE_MTH = DateTime.Today.AddMonths(-1);

        // Current Directory
        internal static string CUR_DIR = GLB.FLD_DEF;

        // Default File Text
        internal static string DEF_FIL = "Por defecto";
    }
}

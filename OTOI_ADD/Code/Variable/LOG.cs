using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOI_ADD.Code.Variable
{
    internal static class LOG
    {
        // Program
        internal static readonly string PRG_STR = "Application Loading";
        internal static readonly string PRG_END = "Application Shutdown";

        // Constructor
        internal static readonly string CON_LFR = "Constructor - Loading Form";
        internal static readonly string CON_FRL = "Constructor - Form Loaded";

        // Link
        internal static readonly string LNK_OPN = "Opening Link";

        // Accept / Cancel
        internal static readonly string FRM_ACT = "Form Accept";
        internal static readonly string FRM_CNL = "Form Closing";

        // Field Enabling / Disabling
        internal static readonly string FRM_PES = "Process Enable Switch";
        internal static readonly string FRM_KES = "Keep Enable Switch";
        internal static readonly string FRM_UES = "Unzip Enable Switch";

        // Dialog
        internal static readonly string FRM_FDD = "Folder Dialog";
        internal static readonly string FRM_FLD = "File Dialog";

        // Validation
        internal static readonly string FRM_VAD = "Validating Day";
        internal static readonly string FRM_VAR = "Validating Range";
        internal static readonly string FRM_VAM = "Validating Month";

        // Error
        internal static readonly string FRM_ERC = "Error Check";
    }
}

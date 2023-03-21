using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOI_ADD.Code.Function
{
    internal static class AppConfigManager
    {
        internal static void Start()
        {
            string? str = ConfigurationManager.AppSettings.Get("STR");
            if (str != null)
            {
                FormManager.STR = DateTime.Parse(str);
            }

            string? end = ConfigurationManager.AppSettings.Get("END");
            if (end != null)
            {
                FormManager.END = DateTime.Parse(end);
            }
        }
        internal static void Save()
        {
            ConfigurationManager.AppSettings.Set("STR", FormManager.STR.ToShortDateString());
            ConfigurationManager.AppSettings.Set("END", FormManager.END.ToShortDateString());
            ConfigurationManager.RefreshSection("applicationSettings");
        }
    }
}

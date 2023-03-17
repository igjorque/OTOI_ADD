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
            try
            {
                FormManager.STR = DateTime.Parse(ConfigurationManager.AppSettings.Get("STR"));
            }
            catch (ArgumentNullException e)
            {
                // TODO: Log error
            }
            try
            {
                FormManager.END = DateTime.Parse(ConfigurationManager.AppSettings.Get("END"));
            }
            catch (ArgumentNullException e)
            {
                // TODO: Log error
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

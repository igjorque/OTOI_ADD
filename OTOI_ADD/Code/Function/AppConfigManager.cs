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
        internal static void Initialize()
        {
            using FileStream fs = File.Open("C:\\OTOI_ADD\\app_params.config", FileMode.Open);
            using StreamReader sr = new(fs);
            Dictionary<string, string> cfg = new();
            string? ln;
            string[] lns;

            while ((ln = sr.ReadLine()) != null)
            {
                lns = ln.Split("=");
                cfg.Add(lns[0], lns[1]);
            }

            string? str = cfg["STR"];
            if (str != null)
            {
                FormManager.STR = DateTime.Parse(str);
            }
            string? end = cfg["END"];
            if (end != null)
            {
                FormManager.END = DateTime.Parse(end);
            }
            string? dir = cfg["DIR"];
            if (dir != null)
            {
                FormManager.CURR_DIR = dir;
            }
            string? fil = cfg["FIL"];
            if (fil != null)
            {
                FormManager.CURR_FIL = fil;
            }
            string? mth = cfg["MTH"];
            if (mth != null)
            {
                FormManager.MTH = DateTime.Parse(mth);
            }
        }
        internal static void Save()
        {
            using FileStream fs = File.Open("C:\\OTOI_ADD\\app_params.config", FileMode.Create);
            using StreamWriter sw = new(fs);

            sw.WriteLine("STR="+FormManager.STR.ToShortDateString());
            sw.WriteLine("END="+FormManager.END.ToShortDateString());
            sw.WriteLine("DIR="+FormManager.CURR_DIR);
            sw.WriteLine("FIL="+FormManager.CURR_FIL);
            sw.WriteLine("MTH=" + FormManager.MTH.ToShortDateString());
        }
    }
}

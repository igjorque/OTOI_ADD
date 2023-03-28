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
            if (str != null) FormManager.STR = DateTime.Parse(str);
            string? end = cfg["END"];
            if (end != null) FormManager.END = DateTime.Parse(end);
            string? dir = cfg["DIR"];
            if (dir != null) FormManager.CURR_DIR = dir;
            string? fil = cfg["FIL"];
            if (fil != null && !fil.Contains("ejemplo")) FormManager.CURR_FIL = fil;
            string? mth = cfg["MTH"];
            if (mth != null) FormManager.MTH = DateTime.Parse(mth);
            
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

        internal static void InitLogConfig()
        {
            using FileStream fs = File.Open("C:\\OTOI_ADD\\log4net.config", FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sw.WriteLine("<configuration>");
            sw.WriteLine("  <log4net>");
            sw.WriteLine("      <root>");
            sw.WriteLine("          <level value=\"ALL\" />");
            sw.WriteLine("          <appender-ref ref=\"all_logs_file\" />");
            sw.WriteLine("      </root>");
            sw.WriteLine("      <appender name=\"all_logs_file\" type=\"log4net.Appender.FileAppender\">");
            sw.WriteLine("          <file value=\"C:\\\\OTOI_ADD\\\\log.log\" />");
            sw.WriteLine("          <layout type=\"log4net.Layout.PatternLayout\">");
            sw.WriteLine("              <conversionPattern value=\"[%date] > [%level] > [%logger] > [%message]%newline\" />");
            sw.WriteLine("          </layout>");
            sw.WriteLine("      </appender>");
            sw.WriteLine("  </log4net>");
            sw.WriteLine("</configuration>");
        }

        internal static void InitParamConfig()
        {
            using FileStream fs = File.Open("C:\\OTOI_ADD\\app_params.config", FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);
            sw.WriteLine("STR=01/01/2023");
            sw.WriteLine("END=31/01/2023");
            sw.WriteLine("DIR=C:\\OTOI_ADD");
            sw.WriteLine("FIL=C:\\OTOI_ADD\\ejemplo.xls");
            sw.WriteLine("MTH=01/01/2023");
        }
    }
}

using OTOI_ADD.Code.Variable;

namespace OTOI_ADD.Code.Function
{
    internal static class AppConfigManager
    {
        internal static void Initialize()
        {
            using FileStream fs = File.Open(GLB.FLD_DEF + GLB.FIL_CFG, FileMode.Open);
            using StreamReader sr = new(fs);
            Dictionary<string, string> cfg = new();
            string? ln;
            string[] lns;

            while ((ln = sr.ReadLine()) != null)
            {
                lns = ln.Split("=");
                cfg.Add(lns[0], lns[1]);
            }

            // Parse Dates
            string? str = cfg["STR"];
            if (str != null) VAR.RNG_STR = DateTime.Parse(str);
            string? end = cfg["END"];
            if (end != null) VAR.RNG_END = DateTime.Parse(end);
            string? day = cfg["DAY"];
            if (day != null) VAR.DTE_DAY = DateTime.Parse(day);
            string? mth = cfg["MTH"];
            if (mth != null) VAR.DTE_MTH = DateTime.Parse(mth);

            // Parse Path
            string? dir = cfg["DIR"];
            if (dir != null) VAR.CUR_DIR = dir;
        }
        internal static void Save()
        {
            using FileStream fs = File.Open(GLB.FLD_DEF + GLB.FIL_CFG, FileMode.Create);
            using StreamWriter sw = new(fs);

            // Save Dates
            sw.WriteLine("STR=" + VAR.RNG_STR.ToShortDateString());
            sw.WriteLine("END=" + VAR.RNG_END.ToShortDateString());
            sw.WriteLine("DAY=" + VAR.DTE_DAY.ToShortDateString());
            sw.WriteLine("MTH=" + VAR.DTE_MTH.ToShortDateString());

            // Save Path
            sw.WriteLine("DIR=" + VAR.CUR_DIR);
        }

        internal static void InitLogConfig(string file)
        {
            using FileStream fs = File.Open(file, FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sw.WriteLine("<configuration>");
            sw.WriteLine("  <log4net>");
            sw.WriteLine("      <root>");
            sw.WriteLine("          <level value=\"ALL\" />");
            sw.WriteLine("          <appender-ref ref=\"all_logs_file\" />");
            sw.WriteLine("      </root>");
            sw.WriteLine("      <appender name=\"all_logs_file\" type=\"log4net.Appender.FileAppender\">");
            sw.WriteLine("          <file value=\""+ GLB.LOC_LOG +"\" />");
            sw.WriteLine("          <layout type=\"log4net.Layout.PatternLayout\">");
            sw.WriteLine("              <conversionPattern value=\"[%date] > [%level] > [%logger] > [%message]%newline\" />");
            sw.WriteLine("          </layout>");
            sw.WriteLine("      </appender>");
            sw.WriteLine("  </log4net>");
            sw.WriteLine("</configuration>");
        }

        internal static void InitParamConfig(string file)
        {
            using FileStream fs = File.Open(file, FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);
            // Create Dates
            sw.WriteLine("STR=01/01/2023");
            sw.WriteLine("END=31/01/2023");
            sw.WriteLine("DAY=01/01/2023");
            sw.WriteLine("MTH=01/01/2023");

            // Create Path
            sw.WriteLine("DIR=" + GLB.FLD_DEF + GLB.FLD_DWL);
        }
    }
}

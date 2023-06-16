using log4net;
using log4net.Repository.Hierarchy;
using Microsoft.Office.Interop.Excel;
using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Variable;
using static System.Reflection.Metadata.BlobBuilder;
using Excel = Microsoft.Office.Interop.Excel;
using Prop = OTOI_ADD.Properties.Settings;

namespace OTOI_ADD.Code.Module.Process
{
    /// <summary>
    /// ESIOS Processor class
    /// </summary>
    internal class ProcessorESIOS
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Manages the downloaded files processing.
        /// </summary>
        /// <param name="inp">Input data</param>
        /// <param name="pb_progress">Progress bar</param>
        internal static void Process(InputESIOS inp, ProgressBar pb_progress)
        {
            logger.Info(LOG.PROCESS_START);

            Excel.Application? app = null;
            Workbooks? books = null;
            Workbook? bk = null, tbk = null;
            Worksheet? tws = null;

            object miss = System.Reflection.Missing.Value;

            int i;
            string fname;
            DirectoryInfo di;

            app = new Excel.Application();
            app.DisplayAlerts = false;
            books = app.Workbooks;
            tbk = app.Workbooks.Add(miss);
            di = new DirectoryInfo(inp.DestDL);
            
            // Generate processed files
            string colFile;
            foreach (var f in di.GetFiles()) // For each file...
            {
                colFile = inp.DestDL + Path.DirectorySeparatorChar + "ESIOS_" + f.Name.Split("_")[1] + "_" + inp.DateStart.Year + "-" + inp.DateStart.Month + ".txt";
                using (StreamWriter sw = new(colFile))
                {
                    sw.WriteLine("Dia; Hora; Valor; ");
                    string[] lines = File.ReadAllLines(f.FullName);
                    for (int n = 2; n<lines.Length; n++) // For each line in file... DAY
                    {
                        string[] values = lines[n].Split(';');
                        for (int m = 1; m < values.Length - 2; m++) // For each value in line... HOUR/VALUE
                        {
                            sw.WriteLine(n-1 + "; " + m + "; " + values[m] + "; ");
                        }
                    }
                }
                if (!inp.KeepDL)
                {
                    f.Delete();
                }
            }

            di = new DirectoryInfo(inp.DestDL);
            pb_progress.Maximum = di.GetFiles().Length;
            pb_progress.Value = 0;
            i = 1;
            // Convert CSV files to XLS
            foreach (var f in di.GetFiles())
            {
                // Generate spreadsheet from file
                books.OpenText(f.FullName, XlPlatform.xlWindows, 1, XlTextParsingType.xlDelimited, XlTextQualifier.xlTextQualifierDoubleQuote, false, false, true, false, false, false, miss, miss, miss, miss, miss);
                bk = app.ActiveWorkbook;
                tws = bk.Worksheets[1];
                tws.Copy(tbk.Worksheets[i]);
                bk.Close(false, miss, miss);
                i++;
                pb_progress.PerformStep();
                if (!inp.KeepDL)
                {
                    f.Delete();
                }
            }

            // Delete the default sheet
            foreach (Worksheet ws in app.Worksheets)
            {
                if (ws.Name == "Hoja1")
                {
                    ws.Delete();
                }
            }

            fname = inp.DestDL + Path.DirectorySeparatorChar + "ESIOS_C2-liquicomun_" + inp.DateStart.Year + "-" + inp.DateStart.Month;
            tbk.SaveAs(fname, XlFileFormat.xlWorkbookNormal, miss, miss, miss, miss, XlSaveAsAccessMode.xlNoChange, miss, miss, miss, miss);
            tbk.Close(true, miss, miss);
            books.Close();

            app.DisplayAlerts = true;

            app.Quit();

            logger.Info(LOG.PROCESS_END);
        }
    }
}

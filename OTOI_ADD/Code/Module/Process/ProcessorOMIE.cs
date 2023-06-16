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
    /// OMIE Processor class
    /// </summary>
    internal static class ProcessorOMIE
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Manages the downloaded files processing.
        /// </summary>
        /// <param name="inp">User input</param>
        /// <param name="files">Files to be processed</param>
        /// <param name="pb_progress">Progress bar</param>
        internal static void Process(InputOMIE inp, List<string> files, ProgressBar pb_progress)
        {
            logger.Info(LOG.PROCESS_START);

            Excel.Application? app = null;
            Workbooks? books = null;
            Workbook? bk = null, tbk = null;
            Worksheet? tws = null;

            DateTime daux = DateTime.Now;
            string fpath = $@"{inp.DestDL}\OMIE_col_{inp.DateStart.Month}-{inp.DateStart.Year}_{daux.Day}-{daux.Month}-{daux.Year}-{daux.Hour}-{daux.Minute}-{daux.Second}.xls";
            object miss = System.Reflection.Missing.Value;
            
            app = new Excel.Application();

            app.DisplayAlerts = false;

            books = app.Workbooks;
            tbk = app.Workbooks.Add(miss);

            pb_progress.Maximum = files.Count;
            pb_progress.Value = 0;

            // Special processing into a single column
            int dia = 1;
            string colFile = $@"{inp.DestDL}\OMIE_col_{inp.DateStart.Month}-{inp.DateStart.Year}_{daux.Day}-{daux.Month}-{daux.Year}-{daux.Hour}-{daux.Minute}-{daux.Second}.txt";
            using (StreamWriter sw = new(colFile))
            {
                sw.WriteLine("Dia; Hora; Valor; ");
                foreach (string f in files)
                {
                    string[] lines = File.ReadAllLines(f);
                    string[] values = lines[3].Split(';');
                    for (int n = 1; n < values.Length - 1; n++)
                    {
                        sw.WriteLine(dia + "; " + n + "; " + values[n] + "; ");
                    }
                    dia++;
                }
            }
            books.OpenText(colFile, XlPlatform.xlWindows, 1, XlTextParsingType.xlDelimited, XlTextQualifier.xlTextQualifierDoubleQuote, false, false, true, false, false, false, miss, miss, miss, miss, miss);
            bk = app.ActiveWorkbook;
            tws = bk.Worksheets[1];
            tws.Copy(tbk.Worksheets[1]);
            bk.Close(false, miss, miss);

            // Delete the default sheet
            foreach (Worksheet ws in app.Worksheets)
            {
                if (ws.Name == "Hoja1")
                {
                    ws.Delete();
                }
            }

            tbk.SaveAs(fpath, XlFileFormat.xlWorkbookNormal, miss, miss, miss, miss, XlSaveAsAccessMode.xlNoChange, miss, miss, miss, miss);
            tbk.Close(true, miss, miss);
            books.Close();

            app.DisplayAlerts = true;

            app.Quit();

            logger.Info(LOG.PROCESS_END);
        }

        /*
        /// <summary>
        /// Manages the downloaded files processing.
        /// </summary>
        /// <param name="files">Files to be processed</param>
        /// <param name="pb_progress">Progress bar</param>
        /// <param name="mode"></param>
        internal static void Process(List<string> files, ProgressBar pb_progress, bool mode = false)
        {
            logger.Info(LOG.PROCESS_START);

            Excel.Application? app = null;
            Workbooks? books = null;
            Workbook? bk = null, tbk = null;
            Worksheet? tws = null;

            DateTime daux = DateTime.Now;
            string fpath = $@"{Prop.Default.DIRECTORY}\OMIE_col_{daux.Day}-{daux.Month}-{daux.Year}-{daux.Hour}-{daux.Minute}-{daux.Second}.xls";
            object miss = System.Reflection.Missing.Value;
            string? path = Prop.Default.DIRECTORY;
            int i = 0;

            app = new Excel.Application();

            app.DisplayAlerts = false;

            books = app.Workbooks;
            tbk = app.Workbooks.Add(miss);

            pb_progress.Maximum = files.Count;
            pb_progress.Value = 0;

            // Process files into a single XLS
            foreach (string f in files)
            {
                books.OpenText(f, XlPlatform.xlWindows, 1, XlTextParsingType.xlDelimited, XlTextQualifier.xlTextQualifierDoubleQuote, false, false, true, false, false, false, miss, miss, miss, miss, miss);
                bk = app.ActiveWorkbook;
                tws = bk.Worksheets[1];
                tws.Copy(tbk.Worksheets[i]);
                bk.Close(false, miss, miss);
                i++;
                pb_progress.PerformStep();
            }


            // Delete the default sheet
            foreach (Worksheet ws in app.Worksheets)
            {
                if (ws.Name == "Hoja1")
                {
                    ws.Delete();
                }
            }

            tbk.SaveAs(fpath, XlFileFormat.xlWorkbookNormal, miss, miss, miss, miss, XlSaveAsAccessMode.xlNoChange, miss, miss, miss, miss);
            tbk.Close(true, miss, miss);
            books.Close();

            app.DisplayAlerts = true;

            app.Quit();

            logger.Info(LOG.PROCESS_END);
        }
        */

    }
}

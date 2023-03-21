using Microsoft.Office.Interop.Excel;
using OTOI_ADD.Code.Function;
using Excel = Microsoft.Office.Interop.Excel;

namespace OTOI_ADD.Code.Module.Process
{
    internal static class ProcessorOMIE
    {
        /// <summary>
        /// Manages the downloaded files processing.
        /// </summary>
        /// <param name="files">Files to be processed</param>
        /// <param name="option">Processing option</param>
        internal static void Process(List<string> files, int option = 1)
        {
            switch (option)
            {
                case 1:
                    Process_Multiple(files);
                    break;
                case 2:
                    Process_Single(files);
                    break;
                default:
                    // TODO: Log error in [ProcessorOMIE.Process]
                    MessageBox.Show("Error en el procesador de OMIE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        // TODO: Handle possible exceptions in [ProcessorOMIE.Process_Multiple]
        // Process in multiple files - option = 1
        /// <summary>
        /// Processes the downloaded files in multiple, separated files.
        /// </summary>
        /// <param name="files">File list to be processed</param>
        private static void Process_Multiple(List<string> files)
        {
            Excel.Application? app = null;
            Excel.Workbooks? books = null;
            Excel._Workbook? b = null;

            object miss = System.Reflection.Missing.Value;
            string? path = FormManager.CURR_DIR, name_xls = "";

            app = new Excel.Application();
            books = (Excel.Workbooks) app.Workbooks;

            foreach (string f in files)
            {
                name_xls = Path.GetFileNameWithoutExtension(f) + ".xls";
                books.OpenText(f, Excel.XlPlatform.xlWindows, 1, Excel.XlTextParsingType.xlDelimited, Excel.XlTextQualifier.xlTextQualifierDoubleQuote, false, false, true, false, false, false, miss, miss, miss, miss, miss);
                b = app.ActiveWorkbook;
                b.SaveAs(path + "\\" + name_xls, Excel.XlFileFormat.xlWorkbookNormal, miss, miss, miss, miss, Excel.XlSaveAsAccessMode.xlNoChange, miss, miss, miss, miss);  
                b.Close(false, miss, miss);
            }

            books.Close();
            app.Quit();
        }

        // TODO: Handle possible exceptions in [ProcessorOMIE.Process_Single]
        // Process in a single file - option = 2
        /// <summary>
        /// Processes the downloaded files in a single, unified file.
        /// </summary>
        /// <param name="files">File list to be processed</param>
        private static void Process_Single(List<string> files)
        {
            Excel.Application? app = null;
            Excel.Workbooks? books = null;
            Excel.Workbook? bk = null, tbk = null;
            Excel.Worksheet? tws = null;

            DateTime daux = DateTime.Now;
            string fpath = FormManager.CURR_FIL;
            if (fpath == "")
            {
                fpath = FormManager.CURR_DIR+"\\OMIE_" + daux.Day + daux.Month + daux.Year + daux.Hour + daux.Minute + daux.Second + ".xls";
            }
            object miss = System.Reflection.Missing.Value;
            string? path = FormManager.CURR_DIR;
            int i = 1;

            app = new Excel.Application();

            app.DisplayAlerts = false;

            books = (Excel.Workbooks) app.Workbooks;
            tbk = app.Workbooks.Add(miss);

            foreach (string f in files)
            {
                books.OpenText(f, Excel.XlPlatform.xlWindows, 1, Excel.XlTextParsingType.xlDelimited, Excel.XlTextQualifier.xlTextQualifierDoubleQuote, false, false, true, false, false, false, miss, miss, miss, miss, miss);
                bk = app.ActiveWorkbook;
                tws = bk.Worksheets[1];
                tws.Copy(tbk.Worksheets[i]);
                bk.Close(false, miss, miss);
                i++;
            }

            foreach (Worksheet ws in app.Worksheets)
            {
                if (ws.Name == "Hoja1")
                {
                    ws.Delete();
                }
            }

            tbk.SaveAs(fpath, Excel.XlFileFormat.xlWorkbookNormal, miss, miss, miss, miss, Excel.XlSaveAsAccessMode.xlNoChange, miss, miss, miss, miss);
            tbk.Close(true, miss, miss);
            books.Close();

            app.DisplayAlerts = true;

            app.Quit();
        }
    }
}

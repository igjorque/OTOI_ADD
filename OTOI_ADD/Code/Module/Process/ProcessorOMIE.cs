using OTOI_ADD.Code.Function;
using Excel = Microsoft.Office.Interop.Excel;

namespace OTOI_ADD.Code.Module.Process
{
    internal static class ProcessorOMIE
    {
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
                    MessageBox.Show("No se ha seleccionado una opción válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        // Process in multiple files - option = 1
        private static void Process_Multiple(List<string> files)
        {
            Excel.Application? app = null;
            Excel.Workbooks? books = null;
            Excel._Workbook? b = null;
            object miss = System.Reflection.Missing.Value;

            string? path = "", name_txt = "", name_xls = "";
            foreach (string f in files)
            {
                path = Path.GetDirectoryName(f);
                name_txt = Path.GetFileName(f);
                name_xls = Path.GetFileNameWithoutExtension(f) + ".xls";
                // Create app
                app = new Excel.Application();
                // Assign workbooks
                books = (Excel.Workbooks)app.Workbooks;
                // Open txt -> see parsing options ahead     ->                                                                                                   cons delim   tab     ;      ,    space  other otherchar                        
                books.OpenText(path + "\\" + name_txt, Excel.XlPlatform.xlWindows, 1, Excel.XlTextParsingType.xlDelimited, Excel.XlTextQualifier.xlTextQualifierDoubleQuote, false, false, true, false, false, false, miss, miss, miss, miss, miss);
                // Assign active workbook
                b = app.ActiveWorkbook;
                // Save currently open file with xls format
                b.SaveAs(path + "\\" + name_xls, Excel.XlFileFormat.xlWorkbookNormal, miss, miss, miss, miss, Excel.XlSaveAsAccessMode.xlNoChange, miss, miss, miss, miss);
                // Closes workbook    
                b.Close(false, miss, miss);
                // Closes app
                app.Quit();
            }
        }

        // Process in a single file - option = 2
        private static void Process_Single(List<string> files)
        {
            Excel.Application app = null;
            Excel.Workbooks books = null;
            Excel.Workbook bk = null, tbk = null;
            Excel.Worksheet tws = null;

            DateTime daux = DateTime.Now;
            string sdaux = "" + daux.Day + daux.Month + daux.Year + daux.Hour + daux.Minute + daux.Second;

            object miss = System.Reflection.Missing.Value;
            
            string? path = "", name_txt = "", name_xls = "";
            int i = 1;

            // Create app
            app = new Excel.Application();

            // Assign workbooks
            books = (Excel.Workbooks)app.Workbooks;

            tbk = app.Workbooks.Add(miss);

            foreach (string f in files)
            {
                path = Path.GetDirectoryName(f);
                name_txt = Path.GetFileName(f);
                name_xls = Path.GetFileNameWithoutExtension(f) + ".xls";

                // Open txt -> see parsing options ahead     ->                                                                                                   cons delim   tab     ;      ,    space  other otherchar                        
                books.OpenText(path + "\\" + name_txt, Excel.XlPlatform.xlWindows, 1, Excel.XlTextParsingType.xlDelimited, Excel.XlTextQualifier.xlTextQualifierDoubleQuote, false, false, true, false, false, false, miss, miss, miss, miss, miss);
                // Assign active workbook
                bk = app.ActiveWorkbook;
                tws = bk.Worksheets[1];
                tws.Copy(tbk.Worksheets[i]);

                // Closes workbook    
                bk.Close(false, miss, miss);
                i++;
            }
            // Save currently open file with xls format
            tbk.SaveAs(path + "\\omie_" + sdaux + ".xls", Excel.XlFileFormat.xlWorkbookNormal, miss, miss, miss, miss, Excel.XlSaveAsAccessMode.xlNoChange, miss, miss, miss, miss);

            // Closes app
            tbk.Close(true, miss, miss);
            books.Close();
            app.Quit();
        }
    }
}

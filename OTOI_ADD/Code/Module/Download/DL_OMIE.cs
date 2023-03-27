using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Function;
using OTOI_ADD.View.Asset;

namespace OTOI_ADD.Code.Module.Download
{
    internal static class DL_OMIE
    {
        /* Links
        // HPC Day
        // https://www.omie.es/sites/default/files/dados/AGNO_2022/MES_12/TXT/INT_MAJ_EV_H_01_12_2022_01_12_2022.TXT
        // https://www.omie.es/sites/default/files/dados/AGNO_2023/MES_01/TXT/INT_MAJ_EV_H_01_01_2023_01_01_2023.TXT

        // HPC Month
        // https://www.omie.es/sites/default/files/dados/AGNO_2022/MES_12/TXT/INT_M_PFM_MMM_DEM_1_01_12_2022_31_12_2022.TXT
        // https://www.omie.es/sites/default/files/dados/AGNO_2023/MES_01/TXT/INT_M_PFM_MMM_DEM_1_01_01_2023_31_01_2023.TXT

        // HM Day
        // https://www.omie.es/sites/default/files/dados/AGNO_2022/MES_12/TXT/INT_PBC_EV_H_1_01_12_2022_01_12_2022.TXT
        // https://www.omie.es/sites/default/files/dados/AGNO_2023/MES_01/TXT/INT_PBC_EV_H_1_01_01_2023_01_01_2023.TXT

        // HM Month
        // https://www.omie.es/sites/default/files/dados/AGNO_2022/MES_12/TXT/INT_PDBC_PRECIO_2_01_12_2022_31_12_2022.TXT
        // https://www.omie.es/sites/default/files/dados/AGNO_2023/MES_01/TXT/INT_PDBC_PRECIO_2_01_01_2023_31_01_2023.TXT
        */

        /// <summary>
        /// Establishes both base URI and specific URI based on the received [Input]
        /// </summary>
        /// <param name="inp">Form input</param>
        internal static void DLSwitch(InputOMIE inp)
        {
            string uribase = "https://www.omie.es/sites/default/files/dados/AGNO_";
            string uripage = "";

            switch (inp.FID)
            {
                case 1:
                case 2:
                    uripage = "INT_MAJ_EV_H";
                    break;
                case 3:
                case 4:
                    uripage = "INT_PBC_EV_H_1";
                    break;
                case 6:
                    uripage = "INT_PDBC_PRECIO_5";
                    break;
            }

            ProcessDL(uribase, uripage, inp);
        }

        /// <summary>
        /// Manages the download process, building an URI list based on the received [Input].
        /// </summary>
        /// <param name="uribase">Base URI</param>
        /// <param name="uripage">Specific URI</param>
        /// <param name="inp">Form input</param>
        internal static void ProcessDL(string uribase, string uripage, InputOMIE inp)
        {
            string mth, day;
            string uristr;
            Uri uri;
            List<Uri> l_uri = new List<Uri>();

            // TODO: check
            if (inp.FID != 6)
            {
                for (DateTime currDate = inp.DateStart; DateTime.Compare(currDate, inp.DateEnd) <= 0; currDate = currDate.AddDays(1))
                {
                    mth = Auxiliary.FormatMonth(currDate.Month);
                    day = Auxiliary.FormatDay(currDate.Day);
                    uristr = uribase + currDate.Year + "/MES_" + mth + "/TXT/" + uripage + "_" + day + "_" + mth + "_" + currDate.Year + "_" + day + "_" + mth + "_" + currDate.Year + ".TXT";
                    uri = new Uri(uristr);
                    l_uri.Add(uri);
                }
            } 
            else
            {
                string sd, sm, ed, em;
                sd = Auxiliary.FormatDay(inp.DateStart.Day);
                sm = Auxiliary.FormatMonth(inp.DateStart.Month);
                ed = Auxiliary.FormatDay(inp.DateEnd.Day);
                em = Auxiliary.FormatDay(inp.DateEnd.Month);
                uristr = uribase + inp.DateStart.Year + "/MES_" + sm + "/TXT/" + uripage + "_" + sd + "_" + sm + "_" + inp.DateStart.Year + "_" + ed + "_" + em + "_" + inp.DateEnd.Year + ".TXT";
                uri = new Uri(uristr);
                l_uri.Add(uri);
            }
            
            ProgressDialog pd = new ProgressDialog(inp, l_uri);
            pd.ShowDialog();
        }
    }
}

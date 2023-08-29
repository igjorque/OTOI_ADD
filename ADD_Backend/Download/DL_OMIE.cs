using System;
using log4net;
using ADD_Backend.Object;
using ADD_Backend.Function;
using ADD_Backend.Variable;
using System.Collections.Generic;

namespace ADD_Backend.Download
{
    /// <summary>
    /// OMIE downloader class
    /// </summary>
    public static class DL_OMIE
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

        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Manages the download process, building an URI list based on the received [Input].
        /// </summary>
        /// <param name="inp">Form input</param>
        public static DLList ManageDL(InputOMIE inp)
        {
            logger.Info(LOG.DOWNLOAD_OMIE_MANAGE);

            string uribase = "https://www.omie.es/sites/default/files/dados/AGNO_";
            string uripage = "";

            uripage = DLSwitch(inp.FID);

            string sday, smth, syea, eday, emth, eyea;
            string uristr;
            Uri uri;
            List<Uri> l_uri = new List<Uri>();

            if (inp.FID != GLB.FID_HMT)
            {
                for (DateTime currDate = inp.DateStart; DateTime.Compare(currDate, inp.DateEnd) <= 0; currDate = currDate.AddDays(1))
                {
                    smth = Auxiliary.FormatMonth(currDate.Month);
                    sday = Auxiliary.FormatDay(currDate.Day);
                    syea = currDate.Year.ToString();

                    uristr = $"{uribase}{syea}/MES_{smth}/TXT/{uripage}_{sday}_{smth}_{syea}_{sday}_{smth}_{syea}.TXT";
                    uri = new Uri(uristr);

                    l_uri.Add(uri);
                }
            }
            else
            {
                sday = Auxiliary.FormatDay(inp.DateStart.Day);
                smth = Auxiliary.FormatMonth(inp.DateStart.Month);
                syea = inp.DateStart.Year.ToString();
                eday = Auxiliary.FormatDay(inp.DateEnd.Day);
                emth = Auxiliary.FormatDay(inp.DateEnd.Month);
                eyea = inp.DateEnd.Year.ToString();

                uristr = $"{uribase}{syea}/MES_{smth}/TXT/{uripage}_{sday}_{smth}_{syea}_{eday}_{emth}_{eyea}.TXT";
                uri = new Uri(uristr);

                l_uri.Add(uri);
            }

            return new DLList(l_uri);
            // TODO: Use ProgDiag returned params
            /*
            ProgressDialog pd = new ProgressDialog(inp, l_uri);
            pd.ShowDialog();
            */
        }

        /// <summary>
        /// Establishes the specific URI based on the received [FID]
        /// </summary>
        /// <param name="FID">Inputs current form ID</param>
        /// <returns>URI substring corresponding to FID</returns>
        private static string DLSwitch(int FID)
        {
            string uripage;
            switch (FID)
            {
                case 1:
                case 2:
                    uripage = GLB.URI_HPC;
                    break;
                case 3:
                case 4:
                    uripage = GLB.URI_HM;
                    break;
                case 6:
                    uripage = GLB.URI_HMT;
                    break;
                default:
                    uripage = "";
                    break;
            }
            return uripage;
        }
    }
}

﻿using log4net;
using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Module.Function;
using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.Asset;

namespace OTOI_ADD.Code.Module.Download
{
    /// <summary>
    /// ESIOS downloader class
    /// </summary>
    internal static class DL_ESIOS
    {
        /* Links
        Item: C2_liquicomun
        1-9-2022 -> 12-1-2023
        https://api.esios.ree.es/archives/8/download?date_type=publicacion&end_date=2023-01-12T23%3A59%3A59%2B00%3A00&locale=es&start_date=2022-09-01T00%3A00%3A00%2B00%3A00
                         item identifier  ^                                end date ^--------^                                  start date ^--------^                       
        Item: C2_liquicomun
        1-9-2022 -> 13-1-2023
        https://api.esios.ree.es/archives/8/download?date_type=publicacion&end_date=2023-01-13T23%3A59%3A59%2B00%3A00&locale=es&start_date=2022-09-01T00%3A00%3A00%2B00%3A00
                         item identifier  ^                                end date ^--------^                                  start date ^--------^                           
        Item: C3_liquicomun
        1-9-2022 -> 13-1-2023
        https://api.esios.ree.es/archives/9/download?date_type=publicacion&end_date=2023-01-13T23%3A59%3A59%2B00%3A00&locale=es&start_date=2022-09-01T00%3A00%3A00%2B00%3A00
                         item identifier  ^                                end date ^--------^                                  start date ^--------^                                                   
        */

        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Manages the download process, building an URI based on the received [Input].
        /// </summary>
        /// <param name="inp">Form input</param>
        internal static void ManageDL(InputESIOS inp)
        {
            logger.Info(LOG.DOWNLOAD_ESIOS_MANAGE);

            string yea, mth;

            yea = inp.DateStart.Year.ToString();
            mth = Auxiliary.FormatMonth(inp.DateStart.Month);
            string start = $"{yea}-{mth}-01";

            yea = inp.DateEnd.Year.ToString();
            mth = Auxiliary.FormatMonth(inp.DateEnd.Month);
            string end = $"{yea}-{mth}-28";

            string uristr = $@"https://api.esios.ree.es/archives/8/download?date_type=datos&end_date={end}T23%3A59%3A59%2B00%3A00&locale=es&start_date={start}T00%3A00%3A00%2B00%3A00";
            Uri uri = new(uristr);
            DateTime daux = DateTime.Now;
            string filename = $"C2_liquicomun_{mth}-{yea}_{daux.Hour}-{daux.Minute}-{daux.Second}";

            ProgressDialog pd = new(inp, uri, filename);
            pd.ShowDialog();
        }
    }
}

using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Function;
using OTOI_ADD.View.Asset;

namespace OTOI_ADD.Code.Module.Download
{
    internal static class DL_ESIOS
    {
        /*
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

        internal static void ProcessDL(InputESIOS inp)
        {
            string yea, mth, day;

            yea = inp.DateStart.Year.ToString();
            mth = Auxiliary.FormatMonth(inp.DateStart.Month);
            day = Auxiliary.FormatDay(inp.DateStart.Day);
            string start = yea + "-" + mth + "-" + day;

            yea = inp.DateEnd.Year.ToString();
            mth = Auxiliary.FormatMonth(inp.DateEnd.Month);
            day = Auxiliary.FormatDay(inp.DateEnd.Day);
            string end = yea + "-" + mth + "-" + day;

            string uristr = $"https://api.esios.ree.es/archives/8/download?date_type=publicacion&end_date={end}T23%3A59%3A59%2B00%3A00&locale=es&start_date={start}T00%3A00%3A00%2B00%3A00";
            Uri uri = new (uristr);
            // end format: 2023-01-12 |||| start format: 2022-09-01

            string filename = $"C2_liquicomun.zip";

            ProgressDialog pd = new (inp, uri, filename);
            pd.ShowDialog();
        }
    }
}

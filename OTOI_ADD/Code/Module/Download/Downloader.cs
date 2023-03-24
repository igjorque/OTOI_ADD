using log4net;

namespace OTOI_ADD.Code.Module.Download
{
    internal static class Downloader
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Downloads the [uri] resource to [file] location.
        /// </summary>
        /// <param name="file">File destination</param>
        /// <param name="uri">Resource URI to download</param>
        /// <exception cref="HttpRequestException">Download failure</exception>
        internal static void Download(string file, Uri uri)
        {
            DialogResult dr = DialogResult.Retry;
            while (dr == DialogResult.Retry)
            {
                try
                {
                    using var client = new HttpClient();
                    using var s = client.GetStreamAsync(uri);
                    using var fs = new FileStream(file, FileMode.OpenOrCreate);
                    s.Result.CopyTo(fs);
                    logger.Info(String.Format("[Success - Download - {0}]", file));
                    dr = DialogResult.Continue;
                }
                catch (HttpRequestException e)
                {
                    logger.Error(String.Format("[Error - Download - {0} - {1}]", file, uri));
                    dr = MessageBox.Show("Error " + e.StatusCode + ":\nNo se ha podido obtener el recurso.", "Operación fallida", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.Cancel) throw;
                }
            }
        }
    }
}

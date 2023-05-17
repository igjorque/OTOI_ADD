using log4net;
using OTOI_ADD.Code.Variable;

namespace OTOI_ADD.Code.Module.Download
{
    /// <summary>
    /// Downloader class
    /// </summary>
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
                    // TODO: extract client ?
                    using var client = new HttpClient();
                    using var s = client.GetStreamAsync(uri.AbsoluteUri);
                    using var fs = new FileStream(file, FileMode.OpenOrCreate);
                    s.Result.CopyTo(fs);
                    logger.Info(LOG.DOWNLOAD_OK + file);
                    dr = DialogResult.Continue;
                }
                catch (HttpRequestException e)
                {
                    logger.Error(LOG.DOWNLOAD_ERROR + file + " - " + uri);
                    // TODO: hardcoded text
                    dr = MessageBox.Show("Error " + e.StatusCode + ":\nNo se ha podido obtener el recurso.", "Operación fallida", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.Cancel) throw;
                }
            }
        }
    }
}


using System;
using log4net;
using System.IO;
using System.Net.Http;
using ADD_Backend.Variable;
using System.Windows.Forms;


namespace ADD_Backend.Download
{
    /// <summary>
    /// Downloader class
    /// </summary>
    public static class Downloader
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Downloads the [uri_] resource to [file] location.
        /// </summary>
        /// <param name="file">File destination</param>
        /// <param name="uri">Resource URI to download</param>
        /// <exception cref="HttpRequestException">Download failure</exception>
        public static void Download(string file, Uri uri)
        {
            DialogResult dr = DialogResult.Retry;
            while (dr == DialogResult.Retry)
            {
                try
                {
                    // TODO: extract client ?
                    HttpClient client = new HttpClient();
                    var s = client.GetStreamAsync(uri.AbsoluteUri);
                    var fs = new FileStream(file, FileMode.OpenOrCreate);
                    using (client) using (s) using (fs)
                    {
                        s.Result.CopyTo(fs);
                        logger.Info(LOG.DOWNLOAD_OK + file);
                        dr = DialogResult.OK;
                    }
                        
                }
                catch (HttpRequestException e)
                {
                    logger.Error(LOG.DOWNLOAD_ERROR + file + " - " + uri);
                    // TODO: hardcoded text
                    dr = MessageBox.Show("Error:\nNo se ha podido obtener el recurso. " + e.Message, "Operación fallida", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.Cancel) throw;
                }
            }
        }
    }
}


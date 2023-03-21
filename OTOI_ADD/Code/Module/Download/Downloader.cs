namespace OTOI_ADD.Code.Module.Download
{
    internal static class Downloader
    {
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
                }
                catch (HttpRequestException e)
                {
                    // TODO: Log exception in [Dowloader.Download]
                    dr = MessageBox.Show("Error " + e.StatusCode + ":\nNo se ha podido obtener el recurso.", "Operación fallida", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.Cancel) throw;
                }
            }
        }
    }
}

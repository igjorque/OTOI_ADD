namespace OTOI_ADD.Code.Module.Download
{
    internal static class Downloader
    {
        /// <summary>
        /// Downloads the [uri] resource to [file] location.
        /// </summary>
        /// <param name="file">File destination</param>
        /// <param name="uri">Resource URI to download</param>
        internal static void Download(string file, Uri uri)
        {
            using (var client = new HttpClient())
            {
                using (var s = client.GetStreamAsync(uri))
                {
                    using (var fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        s.Result.CopyTo(fs);
                    }
                }
            }
        }
    }
}

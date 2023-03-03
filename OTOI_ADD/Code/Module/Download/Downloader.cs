namespace OTOI_ADD.Code.Module.Download
{
    internal static class Downloader
    {
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

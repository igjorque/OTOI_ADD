namespace OTOI_ADD.Code.Class
{
    internal class InputESIOS : Input
    {
        private bool unzip;

        public InputESIOS() : base() { }

        public InputESIOS(Dictionary<string, object> fields) : base((int) fields["FID"], (DateTime) fields["start"], (DateTime) fields["end"], (string) fields["download"], (bool) fields["keep"])
        {
            this.unzip = (bool) fields["unzip"];
        }

        public bool Unzip { get => unzip; }
    }
}

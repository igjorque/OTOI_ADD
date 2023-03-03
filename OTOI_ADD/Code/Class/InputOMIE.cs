namespace OTOI_ADD.Code.Class
{
    internal class InputOMIE : Input
    {
        private string destFile;
        private bool processFile;
        
        /// <summary>
        /// Default empty constructor.
        /// </summary>
        public InputOMIE() : base()
        {
            this.destFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.processFile = false;
        }

        /// <summary>
        /// Builds an [Input] object using a Dictionary containing the fields values.
        /// </summary>
        /// <param name="fields">Dictionary that contains one key-value pair per field.</param>
        public InputOMIE(Dictionary<string, Object> fields) : base((int) fields["FID"], (DateTime) fields["start"], (DateTime) fields["end"], (string) fields["download"], (bool) fields["keep"]) 
        {
            this.destFile =  (string) fields["file"];
            this.processFile = (bool) fields["process"];
        }

        public string DestFile { get => destFile; }

        public bool ProcessFile { get => processFile; }
    }
}

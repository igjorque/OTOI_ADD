using OTOI_ADD.View.ESIOS;

namespace OTOI_ADD.Code.Class
{
    internal class InputESIOS : Input
    {
        private bool unzip;
        private string file;

        internal bool Unzip { get => this.unzip; }
        internal string File { get => this.file; }

        /// <summary>
        /// Default empty constructor.
        /// </summary>
        public InputESIOS() : base() 
        {
            this.unzip = false;
            this.file = "";
        }

        /// <summary>
        /// Builds an [Input] object using a SingleGeneric type form's fields.
        /// </summary>
        /// <param name="c2l">C2L form</param>
        public InputESIOS(C2L c2l) : base(c2l.FID, c2l.Date, c2l.Date, c2l.Folder, c2l.Keep, c2l.Process)
        {
            this.unzip = c2l.Unzip;
            this.file = c2l.File;
        }

    }



}

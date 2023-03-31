using OTOI_ADD.View.Generic.ESIOS;

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
        /// <param name="egm">C2L form</param>
        public InputESIOS(EGenericMonth egm) : base(egm.FID, egm.Month, egm.LBFolder.Text, egm.CBKeep.Checked, egm.CBProcess.Checked)
        {
            this.unzip = egm.CBUnzip.Checked;
            this.file = egm.LBFile.Text;
        }
    }
}

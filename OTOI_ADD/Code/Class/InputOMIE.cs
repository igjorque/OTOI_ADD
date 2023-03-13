using OTOI_ADD.View.Generic;

namespace OTOI_ADD.Code.Class
{
    internal class InputOMIE : Input
    {
        private string destFile;

        public string DestFile { get => destFile; }

        /// <summary>
        /// Default empty constructor.
        /// </summary>
        public InputOMIE() : base()
        {
            this.destFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        /// <summary>
        /// Builds an [Input] object using a Dictionary containing the fields values.
        /// </summary>
        /// <param name="fields">Dictionary that contains one key-value pair per field.</param>
        public InputOMIE(Dictionary<string, Object> fields) : base((int)fields["FID"], (DateTime)fields["start"], (DateTime)fields["end"], (string)fields["download"], (bool)fields["keep"], (bool)fields["process"])
        {
            this.destFile = (string)fields["file"];
        }

        /// <summary>
        /// Builds an [Input] object using a SingleGeneric type form's fields.
        /// </summary>
        /// <param name="sgf">SingleGeneric form</param>
        public InputOMIE(SingleGeneric sgf) : base(sgf.FID, sgf.Start, sgf.Start, sgf.LBDownload.Text, sgf.Keep.Checked, sgf.Process.Checked)
        {
            this.destFile = sgf.LBFile.Text;
        }

        /// <summary>
        /// Builds an [Input] object using a MultiGeneric type form's fields.
        /// </summary>
        /// <param name="mgf">MultiGeneric form</param>
        public InputOMIE(MultiGeneric mgf) : base(mgf.FID, mgf.Start, mgf.End, mgf.LBDownload.Text, mgf.Keep.Checked, mgf.Process.Checked)
        {
            this.destFile = mgf.LBFile.Text;
        }
    }
}

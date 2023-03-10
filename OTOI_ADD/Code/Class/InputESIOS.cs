using OTOI_ADD.View.Generic;

namespace OTOI_ADD.Code.Class
{
    internal class InputESIOS : Input
    {
        /// <summary>
        /// Default empty constructor.
        /// </summary>
        public InputESIOS() : base() { }

        /// <summary>
        /// Builds an [Input] object using a Dictionary containing the fields values.
        /// </summary>
        /// <param name="fields">Dictionary that contains one key-value pair per field.</param>
        public InputESIOS(Dictionary<string, Object> fields) : base((int)fields["FID"], (DateTime)fields["start"], (DateTime)fields["end"], (string)fields["download"], (bool)fields["keep"], (bool)fields["process"]) { }

        /// <summary>
        /// Builds an [Input] object using a SingleGeneric type form's fields.
        /// </summary>
        /// <param name="sgf">SingleGeneric form</param>
        public InputESIOS(SingleGeneric sgf) : base(sgf.FID, sgf.Start, sgf.Start, sgf.LBDownload.Text, sgf.Keep.Checked, sgf.Process.Checked) { }

        /// <summary>
        /// Builds an [Input] object using a MultiGeneric type form's fields.
        /// </summary>
        /// <param name="mgf">MultiGeneric form</param>
        public InputESIOS(MultiGeneric mgf) : base(mgf.FID, mgf.Start, mgf.End, mgf.LBDownload.Text, mgf.Keep.Checked, mgf.Process.Checked) { }
    }



}

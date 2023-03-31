using OTOI_ADD.View.Generic;
using OTOI_ADD.View.OMIE;

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
        /// <param name="ogd">SingleGeneric form</param>
        public InputOMIE(OGenericDay ogd) : base(ogd.FID, ogd.Day, ogd.Day, ogd.LBFolder.Text, ogd.CBKeep.Checked, ogd.CBProcess.Checked)
        {
            this.destFile = ogd.LBFile.Text;
        }

        /// <summary>
        /// Builds an [Input] object using a MultiGeneric type form's fields.
        /// </summary>
        /// <param name="ogr">MultiGeneric form</param>
        public InputOMIE(OGenericRange ogr) : base(ogr.FID, ogr.Start, ogr.End, ogr.LBFolder.Text, ogr.CBKeep.Checked, ogr.CBProcess.Checked)
        {
            this.destFile = ogr.LBFile.Text;
        }

        /// <summary>
        /// Builds an [Input] object using a MultiGeneric type form's fields.
        /// </summary>
        /// <param name="ogm">MultiGeneric form</param>
        public InputOMIE(OGenericMonth ogm) : base(ogm.FID, ogm.Month, ogm.LBFolder.Text, ogm.CBKeep.Checked, ogm.CBProcess.Checked)
        {
            this.destFile = ogm.LBFile.Text;
        }
    }
}

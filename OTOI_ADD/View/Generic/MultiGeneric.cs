using OTOI_ADD.Code.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOI_ADD.View.Generic
{
    public partial class MultiGeneric : SingleGeneric
    {
        internal DateTime End { get => this.ca_date_end.Value; set => this.ca_date_end.Value = value; }

        public MultiGeneric() : base()
        {
            InitializeComponent();
            LoadEvents();

        }

        public MultiGeneric(int FID) : base(FID)
        {
            InitializeComponent();
            LoadEvents();
        }

        private void LoadEvents()
        {
            this.FormName = "MultiGeneric";
            this.Label = "Dias";
            this.Start = DateTime.Today.AddDays(-2);
            this.End = DateTime.Today.AddDays(-1);

            this.ca_date_end.Validated += new EventHandler(validateEnd);
        }

        private void validateEnd(object sender, EventArgs e)
        {
            Auxiliary.ValidateEnd(this.UCF.ca_date_start, this.ca_date_end, this.ep_error);
        }
    }
}

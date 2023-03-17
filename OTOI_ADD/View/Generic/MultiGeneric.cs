using OTOI_ADD.Code.Function;
using System.Reflection;

namespace OTOI_ADD.View.Generic
{
    public partial class MultiGeneric : SingleGeneric
    {
        internal DateTime End { get => this.ca_date_end.Value; set => this.ca_date_end.Value = value; }

        public MultiGeneric() : base()
        {
            InitializeComponent();
            LoadFields();
            LoadEvents();

        }

        public MultiGeneric(int FID) : base(FID)
        {
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        private void LoadFields()
        {
            this.FormName = "MultiGeneric";
            this.Label = "Dias";
            this.Start = DateTime.Today.AddDays(-2);
            this.End = DateTime.Today.AddDays(-1);
        }

        private void LoadEvents()
        {
            this.ca_date_end.ValueChanged += new EventHandler(ValidateEndEvent);
        }

        private void ValidateEndEvent(object? sender, EventArgs e)
        {
            Auxiliary.ValidateEnd(this.UCF.ca_date_start, this.ca_date_end, this.ep_error);
            if (this.ep_error.GetError(this.ca_date_end) == "")
            {
                FormManager.END = this.ca_date_end.Value;
                this.Accept.Enabled = true;
            } else
            {
                this.Accept.Enabled = false;
            }
        }
    }
}

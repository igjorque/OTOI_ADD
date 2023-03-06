using OTOI_ADD.View.Generic;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// HourlyMarket
    /// </summary>
    public partial class HM : SingleGeneric
    {

        public HM() : base(3)
        {
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        private void LoadFields()
        {
            this.FormName = "OMIE";
            this.Title = "Precio horario del mercado";
        }

        private void LoadEvents()
        {

        }
    }
}

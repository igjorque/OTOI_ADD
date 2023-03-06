using OTOI_ADD.View.Generic;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// Hourly Market Multiple
    /// </summary>
    public partial class HMM : MultiGeneric
    {
        public HMM() : base(4)
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

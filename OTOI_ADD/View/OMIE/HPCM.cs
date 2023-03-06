using OTOI_ADD.View.Generic;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// Hourly Price Consumers Multiple
    /// </summary>
    public partial class HPCM : MultiGeneric
    {

        public HPCM() : base(2)
        {
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        private void LoadFields()
        {
            this.FormName = "OMIE";
            this.Title = "Precio definitivo horario del mecanismo de ajuste a los consumidores en el mercado";
        }

        private void LoadEvents()
        {

        }
    }
}

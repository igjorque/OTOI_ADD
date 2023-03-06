using OTOI_ADD.View.Generic;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// Hourly Price Consumers
    /// https://www.omie.es/es/market-results/daily/average-final-prices/hourly-price-consumers?scope=daily&date=2023-01-01
    /// </summary>
    public partial class HPC : SingleGeneric
    {
        public HPC() : base(1)
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

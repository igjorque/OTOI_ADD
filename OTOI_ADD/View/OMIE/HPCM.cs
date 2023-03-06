using OTOI_ADD.Code.Function;
using OTOI_ADD.View.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

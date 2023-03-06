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

namespace OTOI_ADD.View.ESIOS
{
    public partial class C2L : SingleGeneric
    {
        private static new readonly int FID = 5;

        public C2L() : base(FID)
        {
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        private void LoadFields()
        {
            this.FormName = "ESIOS";
            this.Title = "C2 liquicomun";
            this.Process.Text = "Descomprimir archivos descargados";
            this.File.Visible = false;
            this.File.Enabled = false;
            this.LBFile.Visible = false;
            this.LBFile.Enabled = false;
        }

        private void LoadEvents()
        {

        }
    }
}

using OTOI_ADD.View.Asset.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOI_ADD.View
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Validate(object sender, EventArgs e)
        {
            MonthPicker m = (MonthPicker)sender;
            DateTime dx = m.Value;
            dx = new DateTime(dx.Year, dx.Month, 1);
            if (m != null)
            {
                this.lb_selected.Text = dx.ToShortDateString();
            }
        }
    }
}

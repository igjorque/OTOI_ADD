using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOI_ADD.View.Asset
{
    public partial class FFields : UserControl
    {
        public FFields()
        {
            this.ca_date_start.Value = DateTime.Today.AddDays(-1);
            InitializeComponent();
        }
        private void cb_process_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_process.Checked)
            {
                this.cb_keepDownload.Enabled = true;
            }
            else
            {
                this.cb_keepDownload.Enabled = false;
                this.cb_keepDownload.Checked = false;
            }
        }
    }
}

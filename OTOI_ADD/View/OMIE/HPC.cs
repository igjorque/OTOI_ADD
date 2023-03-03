using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Function;
using OTOI_ADD.Code.Module.Download;
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
    /// Hourly Price Consumers
    /// https://www.omie.es/es/market-results/daily/average-final-prices/hourly-price-consumers?scope=daily&date=2023-01-01
    /// </summary>
    public partial class HPC : SingleGeneric
    {
        public HPC()
        {
            InitializeComponent();
            LoadEvents();
        }
        private void LoadEvents()
        {
            this.Accept.Click += new EventHandler(accept);
        }

        private void accept(object sender, EventArgs e)
        {
            InputOMIE inp = new InputOMIE(Auxiliary.InitFields(this.FID,
                                                     Auxiliary.DateStart(this.Start),
                                                     Auxiliary.DateEnd(this.Start),
                                                     this.LBFile.Text,
                                                     this.LBDownload.Text,
                                                     this.Keep.Checked,
                                                     this.Process.Checked
                                                     )
                                    );
            DL_OMIE.DLSwitch(inp);
            this.Close();
        }
    }
}

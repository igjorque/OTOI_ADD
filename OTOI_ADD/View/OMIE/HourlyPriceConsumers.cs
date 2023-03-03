using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Function;
using OTOI_ADD.Code.Module.Download;

namespace OTOI_ADD.View.OMIE
{
    public partial class HourlyPriceConsumers : Form
    {
        internal int FID;
        public HourlyPriceConsumers()
        {
            this.FID = 1;
            this.Text = "OMIE";
            InitializeComponent();
            this.ca_day.Value = DateTime.Now;
            this.fb_directory.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.sf_file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public void bt_accept_Click(object sender, EventArgs e)
        {
            InputOMIE inp = new InputOMIE(Auxiliary.InitFields(this.FID,
                                                     Auxiliary.DateStart(this.ca_day.Value),
                                                     Auxiliary.DateEnd(this.ca_day.Value),
                                                     this.lb_bt_fileDest.Text,
                                                     this.lb_bt_downloadDir.Text,
                                                     this.ch_keepDownload.Checked,
                                                     this.ch_process.Checked
                                                     )
                                    );
            DL_OMIE.DLSwitch(inp);
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ch_enabler(object sender, EventArgs e)
        {
            Auxiliary.DLEnabler(sender, this.bt_downloadDir, this.lb_bt_downloadDir);
        }

        private void bt_downloadDir_Click(object sender, EventArgs e)
        {
            Auxiliary.DownloadDir(this.fb_directory, this.lb_bt_downloadDir, this.tt_folder);
        }

        private void bt_fileDest_Click(object sender, EventArgs e)
        {
            Auxiliary.FileDest(this.sf_file, this.lb_bt_downloadDir, this.tt_file);
        }

        private void ca_date_Validated(object sender, EventArgs e)
        {
            Auxiliary.ValidateStart(this.ca_day, this.ep_error);
        }

        private void lb_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // https://www.omie.es/es/market-results/daily/average-final-prices/hourly-price-consumers?scope=daily&date=2023-01-01
            Auxiliary.OpenLink(this.FID, this.lb_link);
        }
    }
}

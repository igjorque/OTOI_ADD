using OTOI_ADD.Code.Class;
using OTOI_ADD.Code.Function;
using OTOI_ADD.Code.Module.Download;

namespace OTOI_ADD.View.ESIOS
{
    public partial class C2_Liquicomun : Form
    {
        internal int FID;
        public C2_Liquicomun()
        {
            this.FID = 5;
            InitializeComponent();
            this.ca_date_start.Value = DateTime.Today.AddDays(-2);
            this.ca_date_end.Value = DateTime.Today.AddDays(-1);
        }

        private void bt_downloadDir_Click(object sender, EventArgs e)
        {
            Auxiliary.DownloadDir(this.fb_directory, this.lb_bt_downloadDir, this.tt_folder);
        }

        private void cb_decompress_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_decompress.Checked)
            {
                cb_keepDownload.Enabled = true;
            }
            else
            {
                cb_keepDownload.Enabled = false;
            }
        }

        private void bt_accept_Click(object sender, EventArgs e)
        {
            InputESIOS inp = new InputESIOS(Auxiliary.InitFields(this.FID,
                                                                Auxiliary.DateStart(this.ca_date_start.Value),
                                                                Auxiliary.DateEnd(this.ca_date_end.Value),
                                                                this.lb_bt_downloadDir.Text,
                                                                this.cb_keepDownload.Checked,
                                                                this.cb_decompress.Checked
                                                                )
                                            );
            DL_ESIOS.ProcessDL(inp);
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Auxiliary.OpenLink(this.FID, this.lb_link);
        }
    }
}

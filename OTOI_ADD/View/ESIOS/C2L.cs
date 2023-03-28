using OTOI_ADD.Code.Function;
using OTOI_ADD.View.Asset.Control;
using OTOI_ADD.View.Generic;

namespace OTOI_ADD.View.ESIOS
{
    /// <summary>
    /// C2L
    /// </summary>
    public partial class C2L : Form
    {
        private static readonly int fid = 5;

        internal int FID { get => fid; }
        internal DateTime Date { get => MPtoDT(this.mp_date); } 
        internal string Folder { get => this.lb_bt_downloadDir.Text; }
        internal bool Unzip { get => this.cb_unzip.Checked; }
        internal bool Keep { get => this.cb_keep.Checked; }
        internal bool Process { get => this.cb_process.Checked; }
        internal string File { get => this.lb_bt_fileDest.Text; }

        /// <summary>
        /// Empty C2L form constructor.
        /// </summary>
        public C2L()
        {
            InitializeComponent();
            LoadFields();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            this.Text = "ESIOS";
            this.lb_title.Text = "C2 liquicomun";
            this.mp_date.Value = FormManager.MTH;
            this.lb_bt_downloadDir.Text = FormManager.CURR_DIR;
            this.lb_bt_fileDest.Text = FormManager.CURR_FIL;
            this.fb_directory.InitialDirectory = FormManager.CURR_DIR;
            this.sf_file.InitialDirectory = FormManager.CURR_DIR;
        }

        /// <summary>
        /// Manages the validation of the [mp_date] MonthPicker control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void Mp_date_ValueChanged(object sender, EventArgs e)
        {
            Auxiliary.ValidateESIOS(this.mp_date, this.ep_error);
            if (this.ep_error.GetError(this.mp_date) == "")
            {
                this.bt_accept.Enabled = true;
            } 
            else
            {
                this.bt_accept.Enabled = false;
            }
        }

        /// <summary>
        /// Manages the click event onto the [lb_link] LinkLabel control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void Lb_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormManager.OpenLink(fid, this.lb_link);
        }

        /// <summary>
        /// Manages the click event ont the [bt_downloadDir] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void Bt_downloadDir_Click(object sender, EventArgs e)
        {
            FormManager.DownloadDir(this.fb_directory, this.lb_bt_downloadDir, this.tt_folder);
        }

        /// <summary>
        /// Manages the enabling/disabling of some controls based on the [cb_unzip] CheckBox current status.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void Cb_unzip_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_unzip.Checked)
            {
                this.cb_keep.Enabled = true;
                this.cb_process.Enabled = true;
            } 
            else
            {
                this.cb_keep.Enabled = false;
                this.cb_process.Enabled = false;
            }
        }

        /// <summary>
        /// Manages the enabling/disabling of some controls based on the [cb_process] CheckBox current status.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void Cb_process_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_process.Checked)
            {
                this.bt_fileDest.Enabled = true;
                this.lb_bt_fileDest.Enabled = true;
            } 
            else
            {
                this.bt_fileDest.Enabled = false;
                this.lb_bt_fileDest.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void Bt_fileDest_Click(object sender, EventArgs e)
        {
            FormManager.DownloadFil(this.sf_file, this.lb_bt_fileDest, this.tt_file);
        }

        /// <summary>
        /// Manages the click event onto the [bt_accept] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void Bt_accept_Click(object sender, EventArgs e)
        {
            FormManager.FormAccept(this, fid);
        }

        /// <summary>
        /// Manages the click event onto the [bt_cancel] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Auxiliary - Converts a MonthPicker custom control data to DateTime.
        /// </summary>
        /// <param name="mp">Custom control</param>
        /// <returns>Data converted to DateTime</returns>
        private DateTime MPtoDT(MonthPicker mp)
        {
            DateTime dx = new(mp.Value.Year, mp.Value.Month, 1);
            return dx;
        }
    }
}

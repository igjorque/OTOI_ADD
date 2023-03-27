using log4net.Repository.Hierarchy;
using OTOI_ADD.Code.Function;
using OTOI_ADD.View.Asset;
using OTOI_ADD.View.Asset.Control;
using OTOI_ADD.View.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HMT : Form
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static readonly int fid = 6;

        internal int FID { get => fid; }
        internal string FormName { get => this.Text; set => this.Text = value; }
        internal string Title { get => this.lb_title.Text; set => this.lb_title.Text = value; }
        internal LinkLabel Link { get => this.lb_link; set => this.lb_link = value; }
        internal string Label { get => this.lb_date.Text; set => this.lb_date.Text = value; }
        internal Button Download { get => this.bt_downloadDir; set => this.bt_downloadDir = value; }
        internal Label LBDownload { get => this.lb_bt_downloadDir; set => this.lb_bt_downloadDir = value; }
        internal CheckBox Process { get => this.cb_process; set => this.cb_process = value; }
        internal CheckBox Keep { get => this.cb_keepDownload; set => this.cb_keepDownload = value; }
        internal Button File { get => this.bt_fileDest; set => this.bt_fileDest = value; }
        internal Label LBFile { get => this.lb_bt_fileDest; set => this.lb_bt_fileDest = value; }
        internal Button Accept { get => this.bt_accept; set => this.bt_accept = value; }
        internal Button Cancel { get => this.bt_cancel; set => this.bt_cancel = value; }
        internal MonthPicker Date { get => this.mp_date; set => this.mp_date = value; }

        /// <summary>
        /// 
        /// </summary>
        public HMT()
        {
            logger.Info("HMT - Constructor");
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields
        /// </summary>
        private void LoadFields()
        {
            this.FormName = "OMIE";
            this.Title = "Precio horario del mercado";
            this.mp_date.Value = DateTime.Today.AddMonths(-1);
            this.lb_bt_downloadDir.Text = FormManager.CURR_DIR;
            this.lb_bt_fileDest.Text = FormManager.CURR_FIL;
            this.fb_directory.InitialDirectory = FormManager.CURR_DIR;
            this.sf_file.InitialDirectory = FormManager.CURR_DIR;
        }

        /// <summary>
        /// Auxiliary - Loads predefined events
        /// </summary>
        private void LoadEvents()
        {

        }

        /// <summary>
        /// Manages the validation of the [mp_date] MonthPicker control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void Mp_date_ValueChanged(object sender, EventArgs e)
        {
            Auxiliary.ValidateESIOS(this.mp_date, this.ep_error); // TODO: Cambiar
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
        private void Cb_keepDownload_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Manages the enabling/disabling of some controls based on the [cb_process] CheckBox current status.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void Cb_process_CheckedChanged(object sender, EventArgs e)
        {
            FormManager.DLEnabler(sender, this.cb_keepDownload, this.bt_fileDest, this.lb_bt_fileDest);
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

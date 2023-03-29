using OTOI_ADD.Code.Function;
using OTOI_ADD.View.Asset.Control;
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

namespace OTOI_ADD.View.Generic
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MonthGeneric : Form
    {

        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private int fid;
        internal int FID { get => fid; }
        internal string FormName { get => this.Text; set => this.Text = value; }
        internal string Title { get => this.uc_fm.lb_title.Text; set => this.uc_fm.lb_title.Text = value; }
        internal LinkLabel Link { get => this.uc_fm.lb_link; set => this.uc_fm.lb_link = value; }
        internal string Label { get => this.uc_fm.lb_date.Text; set => this.uc_fm.lb_date.Text = value; }
        internal Button Download { get => this.uc_fm.bt_downloadDir; set => this.uc_fm.bt_downloadDir = value; }
        internal Label LBDownload { get => this.uc_fm.lb_bt_downloadDir; set => this.uc_fm.lb_bt_downloadDir = value; }
        internal CheckBox Process { get => this.uc_fm.cb_process; set => this.uc_fm.cb_process = value; }
        internal CheckBox Keep { get => this.uc_fm.cb_keepDownload; set => this.uc_fm.cb_keepDownload = value; }
        internal Button File { get => this.uc_fm.bt_fileDest; set => this.uc_fm.bt_fileDest = value; }
        internal Label LBFile { get => this.uc_fm.lb_bt_fileDest; set => this.uc_fm.lb_bt_fileDest = value; }
        internal Button Accept { get => this.uc_fm.bt_accept; set => this.uc_fm.bt_accept = value; }
        internal Button Cancel { get => this.uc_fm.bt_cancel; set => this.uc_fm.bt_cancel = value; }
        internal MonthPicker Date { get => this.uc_fm.mp_date; set => this.uc_fm.mp_date = value; }

        /// <summary>
        /// 
        /// </summary>
        public MonthGeneric()
        {
            logger.Info("MonthGeneric - Constructor");
            fid = 0;
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fid"></param>
        public MonthGeneric(int fid)
        {
            logger.Info("MonthGeneric - Constructor");
            this.fid = fid;
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields.
        /// </summary>
        private void LoadFields()
        {
            logger.Info("MonthGeneric - Loading Fields");
            this.FormName = "SingleGeneric";
            this.Date.Value = FormManager.MTH;
            this.LBDownload.Text = FormManager.CURR_DIR;
            this.fb_directory.InitialDirectory = FormManager.CURR_DIR;
            if (FormManager.CURR_FIL != "") this.LBFile.Text = FormManager.CURR_FIL;
            else this.LBFile.Text = "Por defecto";
            this.sf_file.InitialDirectory = FormManager.CURR_DIR;
            logger.Info("MonthGeneric - Fields Loaded");
        }

        /// <summary>
        /// Auxiliary - Loads predefined events.
        /// </summary>
        private void LoadEvents()
        {
            logger.Info("MonthGeneric - Loading Events");
            this.AcceptButton = this.Accept;
            this.Process.CheckedChanged += new EventHandler(EnableEvent);
            this.Accept.Click += new EventHandler(AcceptEvent);
            this.Cancel.Click += new EventHandler(CancelEvent);
            this.Link.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkEvent);
            this.Download.Click += new EventHandler(DownloadFolderEvent);
            this.File.Click += new EventHandler(DownloadFileEvent);
            this.uc_fm.mp_date.ValueChanged += new EventHandler(ValidateDateEvent);
            logger.Info("MonthGeneric - Events Loaded");
        }
        /// <summary>
        /// Manages the enabling/disabling of some controls based on the [cb_keepDownload] CheckBox current status.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void EnableEvent(object? sender, EventArgs e)
        {
            FormManager.DLEnabler(sender, this.uc_fm.cb_keepDownload, this.uc_fm.bt_fileDest, this.uc_fm.lb_bt_fileDest);
        }

        /// <summary>
        /// Manages the click event onto the [bt_accept] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void AcceptEvent(object? sender, EventArgs e)
        {
            logger.Info("MonthGeneric - Form Accept");
            FormManager.FormAccept(this, this.FID);
        }

        /// <summary>
        /// Manages the click event onto the [bt_cancel] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void CancelEvent(object? sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Manages the click event onto the [lb_link] LinkLabel control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void LinkEvent(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            logger.Info("MonthGeneric - Opening Link");
            FormManager.OpenLink(this.FID, this.Link);
        }

        /// <summary>
        /// Manages the click event onto the [bt_downloadDir] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void DownloadFolderEvent(object? sender, EventArgs e)
        {
            FormManager.DownloadDir(this.fb_directory, this.LBDownload, this.tt_folder);
        }

        /// <summary>
        /// Manages the click event onto the [bt_fileDest] Button control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void DownloadFileEvent(object? sender, EventArgs e)
        {
            FormManager.DownloadFil(this.sf_file, this.LBFile, this.tt_file);
        }

        /// <summary>
        /// Manages the validation of the [mp_date] MonthPicker control.
        /// </summary>
        /// <param name="sender">Sender control</param>
        /// <param name="e">Event arguments</param>
        private void ValidateDateEvent(object? sender, EventArgs e)
        {
            Auxiliary.ValidateDate(this.uc_fm.mp_date, this.ep_error);
            if (this.ep_error.GetError(this.uc_fm.mp_date) == "")
            {
                FormManager.STR = this.uc_fm.mp_date.Value;
                this.Accept.Enabled = true;
            }
            else
            {
                this.Accept.Enabled = false;
            }
        }
    }
}

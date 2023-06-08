using OTOI_ADD.Code.Interface;
using OTOI_ADD.Code.Module.Function;
using OTOI_ADD.Code.Module.Style;
using Prop = OTOI_ADD.Properties.Settings;

namespace OTOI_ADD.View
{
    /// <summary>
    /// Configuration form
    /// </summary>
    public partial class Configuration : Form, IControls
    {
        // Flag for pausing events
        private bool EVT_PAUSE = false;

        // Flags for modified fields
        #region ## Flags ##
        internal bool F_LOAD;
        internal bool F_SAVE;
        internal bool F_FOLDER;
        internal bool F_THEME;
        internal bool F_LANG;
        internal bool F_OPR;
        internal bool F_OKP;
        internal bool F_EUZ;
        internal bool F_EKP;
        internal bool F_EPR;
        #endregion

        /// <summary>
        /// Empty form constructor.
        /// </summary>
        public Configuration()
        {
            InitFlags();
            InitializeComponent();
            this.EVT_PAUSE = true;
            LoadConfig();
            this.EVT_PAUSE = false;
            Styler.SetStyle(this.GetControls());
        }

        /// <summary>
        /// Initializes this forms flags to FALSE.
        /// </summary>
        private void InitFlags()
        {
            this.F_LOAD = false;
            this.F_SAVE = false;
            this.F_FOLDER = false;
            this.F_THEME = false;
            this.F_LANG = false;
            this.F_OPR = false;
            this.F_OKP = false;
            this.F_EUZ = false;
            this.F_EKP = false;
            this.F_EPR = false;
        }

        /// <summary>
        /// IControls implementation.
        /// Gets this form's controls
        /// </summary>
        /// <returns>List of this form's controls</returns>
        public List<Object> GetControls()
        {
            return new List<Object>
            {
                this,
                this.lb_section1, this.cb_load_config, this.cb_save_config, this.bt_download, this.lb_download, this.cb_mode, this.lb_lang, this.cb_lang,
                this.lb_section2, this.cb_opr, this.cb_okp,
                this.lb_section3, this.cb_euz, this.cb_ekp, this.cb_epr,
                this.bt_accept, this.bt_cancel
            };
        }

        /// <summary>
        /// Checks if ANY flag is true.
        /// </summary>
        /// <returns>TRUE if ANY flag is set to true, FALSE otherwise.</returns>
        private bool Flags()
        {
            return this.F_LOAD || this.F_SAVE || this.F_FOLDER || this.F_THEME || this.F_LANG || this.F_OPR || this.F_OKP || this.F_EUZ || this.F_EKP || this.F_EPR;
        }

        /// <summary>
        /// Loads the current app params configuration.
        /// </summary>
        private void LoadConfig()
        {
            this.cb_load_config.Checked = Prop.Default.CFG_LOAD;
            this.lb_download.Text = Prop.Default.DIRECTORY;
            this.cb_mode.Checked = Prop.Default.THEME;
            this.cb_lang.SelectedIndex = this.cb_lang.Items.IndexOf(Prop.Default.LANG);

            this.cb_opr.Checked = Prop.Default.O_PROCESS;
            this.cb_okp.Checked = Prop.Default.O_KEEP;

            this.cb_euz.Checked = Prop.Default.E_UNZIP;
            this.cb_ekp.Checked = Prop.Default.E_KEEP;
            this.cb_epr.Checked = Prop.Default.E_PROCESS;
        }

        /// <summary>
        /// Enables/Disables most of this form's controls based on [cb_load_config].
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigLoadChanged(object sender, EventArgs e)
        {
            if (!this.EVT_PAUSE)
            {
                this.F_LOAD = !this.F_LOAD;
                ControlStatus(this.cb_load_config.Checked);
            }
        }

        // TODO: comment
        private void ControlStatus(bool status)
        {
            this.cb_save_config.Enabled = status;
            this.bt_download.Enabled = status;
            this.lb_download.Enabled = status;
            this.cb_mode.Enabled = status;
            this.lb_lang.Enabled = status;
            this.cb_lang.Enabled = status;
            this.lb_section2.Enabled = status;
            this.lb_section3.Enabled = status;
            this.cb_opr.Enabled = status;
            this.cb_okp.Enabled = status;
            this.cb_euz.Enabled = status;
            this.cb_ekp.Enabled = status;
            this.cb_epr.Enabled = status;
        }

        /// <summary>
        /// Alternates the [F_SAVE] flag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigSaveChanged(object sender, EventArgs e)
        {
            if (!this.EVT_PAUSE) this.F_SAVE = !this.F_SAVE;
        }

        /// <summary>
        /// Opens a FolderBrowserDialog, and alternates the [F_FOLDER] flag if a NEW folder is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownloadDestination(object sender, EventArgs e)
        {
            this.fb_directory.ShowNewFolderButton = true;
            this.fb_directory.InitialDirectory = this.lb_download.Text;
            if (this.fb_directory.ShowDialog() == DialogResult.OK)
            {
                if (this.lb_download.Text != this.fb_directory.SelectedPath) this.F_FOLDER = !this.F_FOLDER;

                this.lb_download.Text = this.fb_directory.SelectedPath;
            }
        }

        /// <summary>
        /// Alternates the [F_THEME] flag and presents a preview of the selected theme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemeChanged(object sender, EventArgs e)
        {
            if (!this.EVT_PAUSE) this.F_THEME = !this.F_THEME; // Inverts flag current value

            CheckBox cb = (CheckBox)sender;
            Styler.MODE = cb.Checked;
            Styler.SetStyle(this.GetControls());
        }

        /// <summary>
        /// Alternates the [F_LANG] flag and presents a preview of the selected language.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LangChanged(object sender, EventArgs e)
        {
            if (!this.EVT_PAUSE) this.F_LANG = !this.F_LANG;
            // TODO: I18N language switcher
        }

        /// <summary>
        /// Alternates the [F_OPR] flag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OMIE_ProcessChanged(object sender, EventArgs e)
        {
            if (!this.EVT_PAUSE) this.F_OPR = !this.F_OPR;

            this.cb_okp.Enabled = this.cb_opr.Checked;
        }

        /// <summary>
        /// Alternates the [F_EUZ] flag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ESIOS_UnzipChanged(object sender, EventArgs e)
        {
            if (!this.EVT_PAUSE) this.F_EUZ = !this.F_EUZ;

            this.cb_ekp.Enabled = this.cb_euz.Checked;
            this.cb_epr.Enabled = this.cb_euz.Checked;
        }

        /// <summary>
        /// Saves the selected configuration params when the accept button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Accept(object sender, EventArgs e)
        {
            if (Flags())
            {
                if (this.F_LOAD) Prop.Default.CFG_LOAD = this.cb_load_config.Checked;
                if (this.F_SAVE) Prop.Default.CFG_SAVE = this.cb_save_config.Checked;
                if (this.F_FOLDER) Prop.Default.DIRECTORY = this.lb_download.Text;
                if (this.F_THEME) Prop.Default.THEME = this.cb_mode.Checked;
                if (this.F_LANG) Prop.Default.LANG = this.cb_lang.SelectedText;
                if (this.F_OPR) Prop.Default.O_PROCESS = this.cb_opr.Checked;
                if (this.F_OKP) Prop.Default.O_KEEP = this.cb_okp.Checked;
                if (this.F_EUZ) Prop.Default.E_UNZIP = this.cb_euz.Checked;
                if (this.F_EKP) Prop.Default.E_KEEP = this.cb_ekp.Checked;
                if (this.F_EPR) Prop.Default.E_PROCESS = this.cb_epr.Checked;

                InitFlags(); // Reset flags - prevents ClosingForm from popping a MessageBox

                AppConfigManager.Save();
            }
            this.Close();
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// If changes were made, asks for confirmation to close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = DialogResult.Yes;
            if (Flags())
            {
                // TODO: remove hardcoded text
                dr = MessageBox.Show("Hay cambios en la configuración. ¿Seguro que desea salir? Estos cambios se perderán.", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (dr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Styler.MODE = Prop.Default.THEME;
            }
        }

        /// <summary>
        /// Alternates the [F_OKP] flag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OMIE_KeepChanged(object sender, EventArgs e)
        {
            if (!this.EVT_PAUSE) this.F_OKP = !this.F_OKP;
        }

        /// <summary>
        /// Alternates the [F_EKP] flag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ESIOS_KeepChanged(object sender, EventArgs e)
        {
            if (!this.EVT_PAUSE) this.F_EKP = !this.F_EKP;
        }

        /// <summary>
        /// Alternates the [F_EPR] flag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ESIOS_ProcessChanged(object sender, EventArgs e)
        {
            if (!this.EVT_PAUSE) this.F_EPR = !this.F_EPR;
        }
    }
}

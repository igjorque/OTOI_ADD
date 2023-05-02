using OTOI_ADD.Code.Module.Style;
using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.ESIOS;
using OTOI_ADD.View.OMIE;
using System.Diagnostics;
using System.Reflection;

namespace OTOI_ADD.View
{
    /// <summary>
    /// Main
    /// </summary>
    public partial class Main : Form
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Main form constructor.
        /// </summary>
        public Main()
        {
            logger.Info(LOG.MAIN_BUILD);
            InitializeComponent();
            Styler.SetStyle(GetControls());
            SetImage();
        }

        private List<Object> GetControls()
        {
            List<Object> controls = new List<Object>
            {
                this.ms_menu, 
                this.tsmi_menu, this.tsmi_config, this.tsmi_exit,
                this.tsmi_downloads, this.tsmi_omie, this.tsmi_HPCM, this.tsmi_HMM, this.tsmi_HMT,
                                    this.tsmi_esios, this.tsmi_c2l,
                                    this.tsmi_downloadFolder,
                this.tsmi_folder, this.tsmi_openDir, this.tsmi_installDir, this.tsmi_configDir, this.tsmi_downloadDir, this.tsmi_logsDir,
                                    this.tsmi_log, this.tsmi_logSend,
                                    this.tsmi_old, this.tsmi_HPC, this.tsmi_HM,
                                    this.tsmi_test,
                this.tsmi_help, this.tsmi_doc, this.tsmi_about,

                this.tss_file, this.tss_download1, this.tss_download2, this.tss_utility, this.tss_help
            };
            return controls;
        }

        // ----------------------------------------------------------------------------------------- 
        // ------------------------------------------ OMIE ----------------------------------------- 
        // ----------------------------------------------------------------------------------------- 

        /// <summary>
        /// Handles the click event in [tsmi_HPC] button.
        /// Creates and/or sets focus to a [HPC] form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenForm_HPC(object sender, EventArgs e)
        {
            logger.Info(LOG.MAIN_HPC);
            HPC hpc = new HPC();
            hpc.Name = "f_hpc";
            if (FormExists(hpc.Name))
            {
                GiveFocus(hpc.Name);
            }
            else
            {
                hpc.StartPosition = FormStartPosition.CenterScreen;
                hpc.MdiParent = this;
                hpc.Show();
            }
        }

        /// <summary>
        /// Handles the click event in [tsmi_HPCM] button.
        /// Creates and/or sets focus to a [HPCM] form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenForm_HPCM(object sender, EventArgs e)
        {
            logger.Info(LOG.MAIN_HPCM);
            HPCM hpcm = new HPCM();
            hpcm.Name = "f_hpcm";
            if (FormExists(hpcm.Name))
            {
                GiveFocus(hpcm.Name);
            }
            else
            {
                hpcm.StartPosition = FormStartPosition.CenterScreen;
                hpcm.MdiParent = this;
                hpcm.Show();
            }

        }

        /// <summary>
        /// Handles the click event in [tsmi_HM] button.
        /// Creates and/or sets focus to a [HM] form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenForm_HM(object sender, EventArgs e)
        {
            logger.Info(LOG.MAIN_HM);
            HM hm = new HM();
            hm.Name = "f_hm";
            if (FormExists(hm.Name))
            {
                GiveFocus(hm.Name);
            }
            else
            {
                hm.StartPosition = FormStartPosition.CenterScreen;
                hm.MdiParent = this;
                hm.Show();
            }
        }

        /// <summary>
        /// Handles the click event in [tsmi_HMM] button.
        /// Creates and/or sets focus to a [HMM] form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenForm_HMM(object sender, EventArgs e)
        {
            logger.Info(LOG.MAIN_HMM);
            HMM hmm = new HMM();
            hmm.Name = "f_hmm";
            if (FormExists(hmm.Name))
            {
                GiveFocus(hmm.Name);
            }
            else
            {
                hmm.StartPosition = FormStartPosition.CenterScreen;
                hmm.MdiParent = this;
                hmm.Show();
            }
        }

        private void OpenForm_HMT(object sender, EventArgs e)
        {
            logger.Info(LOG.MAIN_HMT);
            HMT hmt = new();
            hmt.Name = "f_hmt";
            if (FormExists(hmt.Name))
            {
                GiveFocus(hmt.Name);
            }
            else
            {
                hmt.StartPosition = FormStartPosition.CenterScreen;
                hmt.MdiParent = this;
                hmt.Show();
            }
        }

        // ----------------------------------------------------------------------------------------- 
        // ----------------------------------------- ESIOS ----------------------------------------- 
        // ----------------------------------------------------------------------------------------- 

        /// <summary>
        /// Handles the click event in [tsmi_c2l] button.
        /// Creates and/or sets focus to a [C2L] form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenForm_C2L(object sender, EventArgs e)
        {
            logger.Info(LOG.MAIN_C2L);
            C2L c2l = new();
            c2l.Name = "f_c2l";
            if (FormExists(c2l.Name))
            {
                GiveFocus(c2l.Name);
            }
            else
            {
                c2l.StartPosition = FormStartPosition.CenterScreen;
                c2l.MdiParent = this;
                c2l.Show();
            }
        }

        // ----------------------------------------------------------------------------------------- 
        // -------------------------------------- OTHER / AUX -------------------------------------- 
        // ----------------------------------------------------------------------------------------- 

        private void ConfigureApp(object sender, EventArgs e)
        {
            // TODO: implement app configurations
        }

        /// <summary>
        /// Handles the click event in [tsmi_exit] button.
        /// Terminates the program by closing the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {
            logger.Info(LOG.MAIN_EXIT);
            this.Close();
        }

        /// <summary>
        /// Checks if a child form already exists.
        /// </summary>
        /// <param name="fname">Child form's name to check existence</param>
        /// <returns></returns>
        private bool FormExists(string fname)
        {
            bool exists = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(fname))
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }

        /// <summary>
        /// Gives the focus to an existing child form.
        /// </summary>
        /// <param name="fname">Child forms' name to set focus on</param>
        private void GiveFocus(string fname)
        {
            logger.Info(LOG.MAIN_FOCUS + fname);
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(fname))
                {
                    f.Focus();
                    return;
                }
            }
        }

        private void InstallDir(object sender, EventArgs e)
        {
            OpenFolder(Environment.CurrentDirectory);
        }

        private void ConfigDir(object sender, EventArgs e)
        {
            OpenFolder(GLB.FOLDER_CONFIG);
        }

        private void DownloadDir(object sender, EventArgs e)
        {
            OpenFolder(GLB.FOLDER_DOWNLOADS);
        }

        private void LogsDir(object sender, EventArgs e)
        {
            OpenFolder(GLB.FOLDER_LOGS);
        }

        private void OpenFolder(string folderPath)
        {
            logger.Info(LOG.MAIN_OPEN);
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
        }

        private void SendLogs(object sender, EventArgs e)
        {
            // TODO: implementar subida/envío logs
            logger.Info(LOG.MAIN_SEND);
            MessageBox.Show("Funcionalidad futura :)");
        }

        private void Documentation(object sender, EventArgs e)
        {
            logger.Info(LOG.MAIN_DOCS);
            try
            {
                string url = "https://github.com/igjorque/OTOI_ADD";
                Process.Start(new ProcessStartInfo() { FileName = url, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido abrir el enlace.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void About(object sender, EventArgs e)
        {
            string msg = "";
            string cap = "";
            cap = GLB.ABOUT_TITLE;
            msg += GLB.ABOUT_DEVELOPER;
            msg += GLB.ABOUT_DESCRIPTION;
            MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ----------------------------------------------------------------------------------------- 
        // ----------------------------------------- TEST ------------------------------------------ 
        // ----------------------------------------------------------------------------------------- 

        private void TEST(object sender, EventArgs e)
        {
            Test t = new();
            t.MdiParent = this;
            t.Show();
        }

        private void SetImage()
        {
            if (Styler.MODE)
            {
                this.tsmi_mode.Image = OTOI_ADD.Properties.Resources.dark;

                this.tsmi_config.Image = OTOI_ADD.Properties.Resources.gear_dark;
                this.tsmi_exit.Image = OTOI_ADD.Properties.Resources.exit_dark;

                this.tsmi_downloadFolder.Image = OTOI_ADD.Properties.Resources.folder_dark;

                this.tsmi_log.Image = OTOI_ADD.Properties.Resources.log_dark;

                this.tsmi_openDir.Image = OTOI_ADD.Properties.Resources.folder_dark;
                this.tsmi_installDir.Image = OTOI_ADD.Properties.Resources.folder_dark;
                this.tsmi_configDir.Image = OTOI_ADD.Properties.Resources.folder_dark;
                this.tsmi_downloadDir.Image = OTOI_ADD.Properties.Resources.folder_dark;
                this.tsmi_logsDir.Image = OTOI_ADD.Properties.Resources.folder_dark;

                this.tsmi_doc.Image = OTOI_ADD.Properties.Resources.file_dark;
                this.tsmi_about.Image = OTOI_ADD.Properties.Resources.about_dark;

                this.tsmi_menu.BackgroundImage = OTOI_ADD.Properties.Resources.button_dark;
                this.tsmi_menu.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_downloads.BackgroundImage = OTOI_ADD.Properties.Resources.button_dark;
                this.tsmi_downloads.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_folder.BackgroundImage = OTOI_ADD.Properties.Resources.button_dark;
                this.tsmi_folder.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_help.BackgroundImage = OTOI_ADD.Properties.Resources.button_dark;
                this.tsmi_help.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_mode.BackgroundImage = OTOI_ADD.Properties.Resources.button_dark;
                this.tsmi_mode.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                this.tsmi_mode.Image = OTOI_ADD.Properties.Resources.light;
                
                this.tsmi_config.Image = OTOI_ADD.Properties.Resources.gear_light;
                this.tsmi_exit.Image = OTOI_ADD.Properties.Resources.exit_light;

                this.tsmi_downloadFolder.Image = OTOI_ADD.Properties.Resources.folder_light;

                this.tsmi_log.Image = OTOI_ADD.Properties.Resources.log_light;

                this.tsmi_openDir.Image = OTOI_ADD.Properties.Resources.folder_light;
                this.tsmi_installDir.Image = OTOI_ADD.Properties.Resources.folder_light;
                this.tsmi_configDir.Image = OTOI_ADD.Properties.Resources.folder_light;
                this.tsmi_downloadDir.Image = OTOI_ADD.Properties.Resources.folder_light;
                this.tsmi_logsDir.Image = OTOI_ADD.Properties.Resources.folder_light;

                this.tsmi_doc.Image = OTOI_ADD.Properties.Resources.file_light;
                this.tsmi_about.Image = OTOI_ADD.Properties.Resources.about_light;

                this.tsmi_menu.BackgroundImage = OTOI_ADD.Properties.Resources.button_light;
                this.tsmi_menu.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_downloads.BackgroundImage = OTOI_ADD.Properties.Resources.button_light;
                this.tsmi_downloads.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_folder.BackgroundImage = OTOI_ADD.Properties.Resources.button_light;
                this.tsmi_folder.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_help.BackgroundImage = OTOI_ADD.Properties.Resources.button_light;
                this.tsmi_help.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_mode.BackgroundImage = OTOI_ADD.Properties.Resources.button_light;
                this.tsmi_mode.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void ModeSwitch(object sender, EventArgs e)
        {
            if (!Styler.MODE) 
            {
                // Dark
                Styler.MODE = true;
                this.tsmi_mode.Text = "Oscuro";

                SetImage();
                
                Styler.SetStyle(GetControls());
                this.tsmi_mode.ForeColor = Color.Black;
                this.tsmi_mode.BackColor = Color.Gray;
            }
            else
            {
                // Light
                Styler.MODE = false;
                this.tsmi_mode.Text = "Claro";

                SetImage();

                Styler.SetStyle(GetControls());
                this.tsmi_mode.ForeColor = Color.Black;
                this.tsmi_mode.BackColor = Color.White;
            }
        }

        private void DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            tsmi.ForeColor = Color.Black;
        }

        private void DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            if (Styler.MODE)
            {
                tsmi.ForeColor = ColorScheme.TSMI_TEXT_D;
            }
            else
            {
                tsmi.ForeColor = ColorScheme.TSMI_TEXT_L;
            }
        }
    }
}
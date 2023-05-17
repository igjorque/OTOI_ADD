using OTOI_ADD.Code.Interface;
using OTOI_ADD.Code.Module.Style;
using OTOI_ADD.Code.Variable;
using OTOI_ADD.View.ESIOS;
using OTOI_ADD.View.Generic.ESIOS;
using OTOI_ADD.View.Generic.OMIE;
using OTOI_ADD.View.OMIE;
using System.Diagnostics;
using System.Reflection;
using Res = OTOI_ADD.Properties.Resources;

namespace OTOI_ADD.View
{
    /// <summary>
    /// Main form.
    /// </summary>
    public partial class Main : Form, IControls
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Main form constructor.
        /// </summary>
        public Main()
        {
            logger.Info(LOG.MAIN_BUILD);
            InitializeComponent();
            Styler.SetStyle(this.GetControls());
            SetImage();
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
                this.ms_menu,

                this.tsmi_menu, this.tsmi_config, this.tsmi_exit,
                                this.tsmi_tools, this.tsmi_logs, this.tsmi_delete,
                this.tsmi_downloads, this.tsmi_omie, this.tsmi_HPCM, this.tsmi_HMM, this.tsmi_HMT,
                                    this.tsmi_esios, this.tsmi_c2l,
                                    this.tsmi_downloadFolder,

                this.tsmi_folder, this.tsmi_openDir, this.tsmi_installDir, this.tsmi_configDir, this.tsmi_downloadDir, this.tsmi_logsDir,

                this.tsmi_help, this.tsmi_doc, this.tsmi_about,

                this.tss_file, this.tss_download1, this.tss_download2, this.tss_help_2, this.tss_help_2,
            };
        }

        // ----------------------------------------------------------------------------------------- 
        // ------------------------------------------ OMIE ----------------------------------------- 
        // ----------------------------------------------------------------------------------------- 

        #region ## OMIE ##

        /// <summary>
        /// Handles the click event in [tsmi_HPC] button.
        /// Creates and/or sets focus to a [HPC] form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenForm_HPC(object sender, EventArgs e)
        {
            logger.Info(LOG.MAIN_HPC);
            HPC hpc = new()
            {
                Name = "f_hpc"
            };
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
            HPCM hpcm = new()
            {
                Name = "f_hpcm"
            };
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
            HM hm = new()
            {
                Name = "f_hm"
            };
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
            HMM hmm = new()
            {
                Name = "f_hmm"
            };
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
            HMT hmt = new()
            {
                Name = "f_hmt"
            };
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
        #endregion

        // ----------------------------------------------------------------------------------------- 
        // ----------------------------------------- ESIOS ----------------------------------------- 
        // ----------------------------------------------------------------------------------------- 

        #region ## ESIOS ##

        /// <summary>
        /// Handles the click event in [tsmi_c2l] button.
        /// Creates and/or sets focus to a [C2L] form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenForm_C2L(object sender, EventArgs e)
        {
            logger.Info(LOG.MAIN_C2L);
            C2L c2l = new()
            {
                Name = "f_c2l"
            };
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

        #endregion

        // ----------------------------------------------------------------------------------------- 
        // ----------------------------------------- MENU ------------------------------------------ 
        // ----------------------------------------------------------------------------------------- 

        #region ## MENU ##

        /// <summary>
        /// Opens a Configuration form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigureApp(object sender, EventArgs e)
        {
            Configuration c = new();
            c.ShowDialog();
            ThemeSwitch();
            c.Dispose();
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenLogsForm(object sender, EventArgs e)
        {
            // TODO: implement
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenDeleteForm(object sender, EventArgs e)
        {
            Deletion del = new()
            {
                MdiParent = this
            };
            del.Show();
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

        /// <summary>
        /// Opens the installation directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstallDir(object sender, EventArgs e)
        {
            OpenFolder(Environment.CurrentDirectory);
        }

        /// <summary>
        /// Opens the configurations directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigDir(object sender, EventArgs e)
        {
            OpenFolder(GLB.FOLDER_CONFIG);
        }

        /// <summary>
        /// Opens the downloads directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownloadDir(object sender, EventArgs e)
        {
            OpenFolder(GLB.FOLDER_DOWNLOADS);
        }

        /// <summary>
        /// Opens the logs directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogsDir(object sender, EventArgs e)
        {
            OpenFolder(GLB.FOLDER_LOGS);
        }

        /// <summary>
        /// Shares the log files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendLogs(object sender, EventArgs e)
        {
            // TODO: implementar subida/envío logs
            logger.Info(LOG.MAIN_SEND);
        }

        /// <summary>
        /// Opens the application's repository and documentation location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Shows a MessageBox with the application's dev info.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void About(object sender, EventArgs e)
        {
            string msg = "";
            string cap = "";
            cap = GLB.ABOUT_TITLE;
            msg += GLB.ABOUT_DEVELOPER;
            msg += GLB.ABOUT_DESCRIPTION;
            MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Sets a better visibility for the control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            tsmi.ForeColor = ColorScheme.TSMI_FORE_L;
        }

        /// <summary>
        /// Sets the control visibility to its default value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            if (Styler.MODE)
            {
                tsmi.ForeColor = ColorScheme.TSMI_FORE_D;
            }
            else
            {
                tsmi.ForeColor = ColorScheme.TSMI_FORE_L;
            }
        }
        #endregion

        // ----------------------------------------------------------------------------------------- 
        // ------------------------------------------ AUX ------------------------------------------ 
        // ----------------------------------------------------------------------------------------- 

        #region ## AUX ##

        /// <summary>
        /// 
        /// </summary>
        private void ChildrenStyle()
        {
            foreach (Generic.Generic g in MdiChildren.Cast<Generic.Generic>())
            {
                if (g is OGenericDay ogd)
                {
                    Styler.SetStyle(ogd.GetControls());
                }
                else if (g is OGenericMonth ogm)
                {
                    Styler.SetStyle(ogm.GetControls());
                }
                else if (g is OGenericRange ogr)
                {
                    Styler.SetStyle(ogr.GetControls());
                }
                else if (g is EGenericMonth egm)
                {
                    Styler.SetStyle(egm.GetControls());
                }
            }
        }

        /// <summary>
        /// Opens  a folder in file explorer.
        /// </summary>
        /// <param name="folderPath">Folder path to open</param>
        private static void OpenFolder(string folderPath)
        {
            logger.Info(LOG.MAIN_OPEN);
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new()
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
        }


        /// <summary>
        /// Sets this form's controls images based on the current theme mode.
        /// </summary>
        internal void SetImage()
        {
            if (Styler.MODE)
            {
                this.tsmi_config.Image = Res.gear_dark;

                this.tsmi_tools.Image = Res.tool_dark;
                this.tsmi_logs.Image = Res.log_dark;
                this.tsmi_delete.Image = Res.delete_dark;

                this.tsmi_exit.Image = Res.exit_dark;

                this.tsmi_downloadFolder.Image = Res.folder_dark;

                this.tsmi_logs.Image = Res.log_dark;

                this.tsmi_omie.Image = Res.get_dark;
                this.tsmi_HPCM.Image = Res.get_dark;
                this.tsmi_HMM.Image = Res.get_dark;
                this.tsmi_HMT.Image = Res.get_dark;

                this.tsmi_esios.Image = Res.get_dark;
                this.tsmi_c2l.Image = Res.get_dark;

                this.tsmi_openDir.Image = Res.folder_dark;

                this.tsmi_installDir.Image = Res.folder_dark;
                this.tsmi_configDir.Image = Res.folder_dark;
                this.tsmi_downloadDir.Image = Res.folder_dark;
                this.tsmi_logsDir.Image = Res.folder_dark;

                this.tsmi_help.Image = Res.help_dark;
                this.tsmi_doc.Image = Res.file_dark;
                this.tsmi_about.Image = Res.about_dark;

                this.tsmi_menu.BackgroundImage = Res.button_dark;
                this.tsmi_menu.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_downloads.BackgroundImage = Res.button_dark;
                this.tsmi_downloads.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_folder.BackgroundImage = Res.button_dark;
                this.tsmi_folder.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_help.BackgroundImage = Res.button_dark;
                this.tsmi_help.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                this.tsmi_config.Image = Res.gear_light;

                this.tsmi_tools.Image = Res.tool_light;
                this.tsmi_logs.Image = Res.log_light;
                this.tsmi_delete.Image = Res.delete_light;

                this.tsmi_exit.Image = Res.exit_light;

                this.tsmi_downloadFolder.Image = Res.folder_light;

                this.tsmi_logs.Image = Res.log_light;

                this.tsmi_omie.Image = Res.get_light;
                this.tsmi_HPCM.Image = Res.get_light;
                this.tsmi_HMM.Image = Res.get_light;
                this.tsmi_HMT.Image = Res.get_light;

                this.tsmi_esios.Image = Res.get_light;
                this.tsmi_c2l.Image = Res.get_light;

                this.tsmi_openDir.Image = Res.folder_light;

                this.tsmi_installDir.Image = Res.folder_light;
                this.tsmi_configDir.Image = Res.folder_light;
                this.tsmi_downloadDir.Image = Res.folder_light;
                this.tsmi_logsDir.Image = Res.folder_light;

                this.tsmi_help.Image = Res.help_light;
                this.tsmi_doc.Image = Res.file_light;
                this.tsmi_about.Image = Res.about_light;

                this.tsmi_menu.BackgroundImage = Res.button_light;
                this.tsmi_menu.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_downloads.BackgroundImage = Res.button_light;
                this.tsmi_downloads.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_folder.BackgroundImage = Res.button_light;
                this.tsmi_folder.BackgroundImageLayout = ImageLayout.Stretch;
                this.tsmi_help.BackgroundImage = Res.button_light;
                this.tsmi_help.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        /// <summary>
        /// Alternates the theme mode.
        /// </summary>
        internal void ThemeSwitch()
        {
            ChildrenStyle();
            SetImage();
            Styler.SetStyle(this.GetControls());
        }
        #endregion

        // TODO: comment
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = (Form)sender;
            f.Dispose();
        }

        // ----------------------------------------------------------------------------------------- 
        // ----------------------------------------- TEST ------------------------------------------ 
        // ----------------------------------------------------------------------------------------- 

        // None
    }
}
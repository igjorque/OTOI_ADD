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
            logger.Info("Main - Constructor");
            InitializeComponent();
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
        private void CL_openForm_HPC(object sender, EventArgs e)
        {
            logger.Info("Main - Open HPC");
            HPC hpc = new HPC();
            hpc.Name = "f_hpc";
            if (FormExists(hpc.Name))
            {
                GiveFocus(hpc.Name);
            }
            else
            {
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
        private void CL_openForm_HPCM(object sender, EventArgs e)
        {
            logger.Info("Main - Open HPCM");
            HPCM hpcm = new HPCM();
            hpcm.Name = "f_hpcm";
            if (FormExists(hpcm.Name))
            {
                GiveFocus(hpcm.Name);
            }
            else
            {
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
        private void CL_openForm_HM(object sender, EventArgs e)
        {
            logger.Info("Main - Open HM");
            HM hm = new HM();
            hm.Name = "f_hm";
            if (FormExists(hm.Name))
            {
                GiveFocus(hm.Name);
            }
            else
            {
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
        private void CL_openForm_HMM(object sender, EventArgs e)
        {
            logger.Info("Main - Open HMM");
            HMM hmm = new HMM();
            hmm.Name = "f_hmm";
            if (FormExists(hmm.Name))
            {
                GiveFocus(hmm.Name);
            }
            else
            {
                hmm.MdiParent = this;
                hmm.Show();
            }
        }

        private void CL_openForm_HMT(object sender, EventArgs e)
        {
            logger.Info("Main - Open HMT");
            HMT hmt = new();
            hmt.Name = "f_hmt";
            if (FormExists(hmt.Name))
            {
                GiveFocus(hmt.Name);
            }
            else
            {
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
        private void CL_openForm_C2L(object sender, EventArgs e)
        {
            logger.Info("Main - Open C2L");
            C2L c2l = new C2L();
            c2l.Name = "f_c2l";
            if (FormExists(c2l.Name))
            {
                GiveFocus(c2l.Name);
            }
            else
            {
                c2l.MdiParent = this;
                c2l.Show();
            }
        }

        // ----------------------------------------------------------------------------------------- 
        // -------------------------------------- OTHER / AUX -------------------------------------- 
        // ----------------------------------------------------------------------------------------- 

        /// <summary>
        /// Handles the click event in [tsmi_exit] button.
        /// Terminates the program by closing the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {
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
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(fname))
                {
                    f.Focus();
                    return;
                }
            }
        }

        private void OpenAppFolder(object sender, EventArgs e)
        {
            string folderPath = "" + Environment.CurrentDirectory;
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


        private void OpenLogFolder(object sender, EventArgs e)
        {
            string folderPath = "C:\\OTOI_ADD";
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
            MessageBox.Show("Funcionalidad futura :)");
        }

        private void Documentation(object sender, EventArgs e)
        {
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
            msg += "Programa desarrollado por Ignacio A. Jorquera Ferrat para la Oficina Técnica de Obras e Infraestructuras (OTOI) - Universidad de La Rioja.";
            msg += "\nAgiliza la descarga de datos de las webs OMIE y ESIOS.";
            cap = "Acerca de ADD";
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
    }
}
using OTOI_ADD.Code.Module.Process;
using OTOI_ADD.View.ESIOS;
using OTOI_ADD.View.OMIE;

namespace OTOI_ADD.View
{
    public partial class Main : Form
    {
        /// <summary>
        /// Main form constructor.
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        // ----------------------------------------------------------------------------------------- 
        // ------------------------------------------ OMIE ----------------------------------------- 
        // ----------------------------------------------------------------------------------------- 

        /// <summary>
        /// Opens a new HourlyPriceConsumers form. Gives focus if one already exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CL_openForm_HPC(object sender, EventArgs e)
        {
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

        private void CL_openForm_HPCM(object sender, EventArgs e)
        {
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
        /// Opens a new HourlyMarket form. Gives focus if one already exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CL_openForm_HM(object sender, EventArgs e)
        {
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

        private void CL_openForm_HMM(object sender, EventArgs e)
        {
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

        // ----------------------------------------------------------------------------------------- 
        // ----------------------------------------- ESIOS ----------------------------------------- 
        // ----------------------------------------------------------------------------------------- 

        private void CL_openForm_C2L(object sender, EventArgs e)
        {
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
        /// Terminates the program by closing the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Checks if a child form already exists.
        /// </summary>
        /// <param name="fname"></param>
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
        /// <param name="fname"></param>
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

        // ----------------------------------------------------------------------------------------- 
        // ----------------------------------------- TEST ------------------------------------------ 
        // ----------------------------------------------------------------------------------------- 

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            t.MdiParent = this;
            t.Show();
        }

        private void process2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C2L c2l = new();
            c2l.MdiParent = this;
            c2l.Show();
        }

        private void Tsmi_info_Click(object sender, EventArgs e)
        {
            // TODO: Mostrar versión actual del programa + info extra
            MessageBox.Show("Información de versión", "Información", MessageBoxButtons.OK);
        }
    }
}
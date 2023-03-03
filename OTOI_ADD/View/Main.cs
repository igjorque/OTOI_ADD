using OTOI_ADD.View.ESIOS;
using OTOI_ADD.View.Generic;
using OTOI_ADD.View.OMIE;

namespace OTOI_ADD.View
{
    public partial class Main : Form
    {
        /// <summary>
        /// Main form constructor.
        /// </summary>
        public Main() { InitializeComponent(); }

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
            HourlyPriceConsumers hpc = new HourlyPriceConsumers();
            hpc.Name = "f_hpc";
            if (FormExists(hpc.Name)) {
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
            HourlyPriceConsumersMultiple hpcm = new HourlyPriceConsumersMultiple();
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
            HourlyMarket hm = new HourlyMarket();
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
            HourlyMarketMultiple hmm = new HourlyMarketMultiple();
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

        private void tsmi_c2_liquicomun_Click(object sender, EventArgs e)
        {
            C2_Liquicomun c2l = new C2_Liquicomun();
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
                }
            }
        }

        private void singleGenericToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleGeneric sg = new SingleGeneric();
            sg.MdiParent = this;
            sg.Show();
        }

        private void multiGenericToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiGeneric mg = new MultiGeneric();
            mg.MdiParent = this;
            mg.Show();
        }
    }
}
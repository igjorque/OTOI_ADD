using OTOI_ADD.View.Asset.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOI_ADD.View
{
    /// <summary>
    /// Test
    /// </summary>
    public partial class Test : Form
    {
        /// <summary>
        /// Test constructor
        /// </summary>
        public Test()
        {
            InitializeComponent();
            LoadFields();
        }

        /// <summary>
        /// Test validate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Validate(object sender, EventArgs e)
        {
            MonthPicker m = (MonthPicker)sender;
            DateTime dx = m.Value;
            dx = new DateTime(dx.Year, dx.Month, 1);
            if (m != null)
            {
                this.lb_selected.Text = dx.ToShortDateString();
            }
        }
        private void LoadFields()
        {
            this.lb_dir1.Text = "" + Environment.CurrentDirectory;
            this.lb_dir2.Text = "" + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        }

        private void bt_dir_Click(object sender, EventArgs e)
        {
            string folderPath = lb_dir1.Text;
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
    }
}

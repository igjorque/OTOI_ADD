using OTOI_ADD.Code.Interface;
using OTOI_ADD.Code.Module.Style;
using OTOI_ADD.Code.Variable;

namespace OTOI_ADD.View
{
    // TODO: comment
    /// <summary>
    /// 
    /// </summary>
    public partial class Deletion : Form, IControls
    {
        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        public Deletion()
        {
            InitializeComponent();
            Styler.SetStyle(this.GetControls());
            this.rb_old.Select();
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<object> GetControls()
        {
            return new List<object>
            {
                this, this.lb_section1,
                this.gb_choice, this.rb_old, this.rb_all,
                this.bt_files, this.bt_logs, this.lb_files, this.lb_logs,
                this.bt_close
            };
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Name == this.rb_old.Name && this.rb_old.Checked)
            {
                UpdateOld();
            }
            if (rb.Name == this.rb_all.Name && this.rb_all.Checked)
            {
                UpdateAll();
            }
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        private void UpdateOld()
        {
            OldFiles();
            OldLogs();
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        private void OldFiles()
        {
            long filesize = 0;
            int filecount = 0;
            foreach (FileInfo file in new DirectoryInfo(GLB.FOLDER_DOWNLOADS).GetFiles())
            {
                if (file.CreationTime.Date <= DateTime.Today.AddDays(-7))
                {
                    filecount++;
                    filesize += file.Length;
                }
            }
            foreach (DirectoryInfo dir in new DirectoryInfo(GLB.FOLDER_DOWNLOADS).GetDirectories())
            {
                foreach (FileInfo fil in dir.GetFiles())
                {
                    if (fil.CreationTime.Date <= DateTime.Today.AddDays(-7))
                    {
                        filecount++;
                        filesize += fil.Length;
                    }
                }
            }
            this.lb_files.Text = "Archivos: " + filecount + " - Tamaño: " + ByteToString(filesize);
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        private void OldLogs()
        {
            long logsize = 0;
            int logcount = 0;
            foreach (FileInfo file in new DirectoryInfo(GLB.FOLDER_LOGS).GetFiles())
            {
                if (file.CreationTime.Date <= DateTime.Today.AddDays(-7))
                {
                    logcount++;
                    logsize += file.Length;
                }
            }

            this.lb_logs.Text = "Archivos: " + logcount + " - Tamaño: " + ByteToString(logsize);
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        private void UpdateAll()
        {
            AllFiles();
            AllLogs();
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        private void AllFiles()
        {
            long filesize = 0;
            int filecount = 0;
            foreach (FileInfo file in new DirectoryInfo(GLB.FOLDER_DOWNLOADS).GetFiles())
            {
                filecount++;
                filesize += file.Length;
            }
            foreach (DirectoryInfo dir in new DirectoryInfo(GLB.FOLDER_DOWNLOADS).GetDirectories())
            {
                foreach (FileInfo fil in dir.GetFiles())
                {
                    filecount++;
                    filesize += fil.Length;
                }
            }
            this.lb_files.Text = "Archivos: " + filecount + " - Tamaño: " + ByteToString(filesize);
        }
        
        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        private void AllLogs()
        {
            long logsize = 0;
            int logcount = 0;
            foreach (FileInfo file in new DirectoryInfo(GLB.FOLDER_LOGS).GetFiles())
            {
                logcount++;
                logsize += file.Length;
            }

            this.lb_logs.Text = "Archivos: " + logcount + " - Tamaño: " + ByteToString(logsize);
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        private string ByteToString(long size)
        {
            string byteString = size + " B";
            if (size > 1024)
            {
                size = size / 1024;
                byteString = size + " KB";
                if (size > 1024)
                {
                    size = size / 1024;
                    byteString = size + " MB";
                    if (size > 1024)
                    {
                        size = size / 1024;
                        byteString = size + " GB";
                    }
                }
            }
            return byteString;
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteLogs(object sender, EventArgs e)
        {
            if (this.rb_old.Checked)
            {
                foreach (FileInfo file in new DirectoryInfo(GLB.FOLDER_LOGS).GetFiles())
                {
                    if (file.LastAccessTime.Date <= DateTime.Today.AddDays(-7))
                    {
                        file.Delete();
                    }
                }
                OldLogs();
            }
            else if (this.rb_all.Checked)
            {
                FileInfo latest = new DirectoryInfo(GLB.FOLDER_LOGS).GetFiles().OrderByDescending(f => f.LastWriteTime).First();
                foreach (FileInfo file in new DirectoryInfo(GLB.FOLDER_LOGS).GetFiles())
                {
                    if (!file.Name.Equals(latest.Name))
                    {
                        file.Delete();
                    }
                    
                }
                AllLogs();
            }
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteFiles(object sender, EventArgs e)
        {
            if (this.rb_old.Checked)
            {
                foreach (FileInfo file in new DirectoryInfo(GLB.FOLDER_DOWNLOADS).GetFiles())
                {
                    if (file.LastAccessTime.Date <= DateTime.Today.AddDays(-7))
                    {
                        file.Delete();
                    }
                }
                foreach (DirectoryInfo dir in new DirectoryInfo(GLB.FOLDER_DOWNLOADS).GetDirectories())
                {
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        if (file.LastAccessTime.Date <= DateTime.Today.AddDays(-7))
                        {
                            file.Delete();
                        }
                    }
                    if (dir.GetFiles().Length == 0)
                    {
                        dir.Delete();
                    }
                }
                OldFiles();
            }
            else if (this.rb_all.Checked)
            {
                foreach (FileInfo file in new DirectoryInfo(GLB.FOLDER_DOWNLOADS).GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in new DirectoryInfo(GLB.FOLDER_DOWNLOADS).GetDirectories())
                {
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        file.Delete();
                    }
                    if (dir.GetFiles().Length == 0)
                    {
                        dir.Delete();
                    }
                }
                AllFiles();
            }
        }

        // TODO: comment
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

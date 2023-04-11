namespace OTOI_ADD.View.Generic.OMIE
{
    partial class OGeneric
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sf_file = new System.Windows.Forms.SaveFileDialog();
            this.fb_directory = new System.Windows.Forms.FolderBrowserDialog();
            this.tt_folder = new System.Windows.Forms.ToolTip(this.components);
            this.tt_file = new System.Windows.Forms.ToolTip(this.components);
            this.ep_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.uc_fo = new OTOI_ADD.View.Asset.Fields_OMIE();
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).BeginInit();
            this.SuspendLayout();
            // 
            // tt_folder
            // 
            this.tt_folder.AutoPopDelay = 5000;
            this.tt_folder.InitialDelay = 100;
            this.tt_folder.ReshowDelay = 100;
            // 
            // tt_file
            // 
            this.tt_file.AutoPopDelay = 5000;
            this.tt_file.InitialDelay = 100;
            this.tt_file.ReshowDelay = 100;
            // 
            // ep_error
            // 
            this.ep_error.ContainerControl = this;
            // 
            // uc_fo
            // 
            this.uc_fo.BackColor = System.Drawing.SystemColors.Control;
            this.uc_fo.Location = new System.Drawing.Point(0, 0);
            this.uc_fo.Name = "uc_fo";
            this.uc_fo.Size = new System.Drawing.Size(314, 227);
            this.uc_fo.TabIndex = 1;
            // 
            // OGeneric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 229);
            this.Controls.Add(this.uc_fo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OGeneric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Generic";
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal ErrorProvider ep_error;
        internal SaveFileDialog sf_file;
        internal FolderBrowserDialog fb_directory;
        internal ToolTip tt_folder;
        internal ToolTip tt_file;
        internal Asset.Fields_OMIE uc_fo;
    }
}
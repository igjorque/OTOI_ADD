﻿namespace OTOI_ADD.View.Generic
{
    partial class Generic
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
            this.uc_f = new OTOI_ADD.View.Asset.Fields();
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
            // uc_f
            // 
            this.uc_f.BackColor = System.Drawing.SystemColors.Control;
            this.uc_f.Location = new System.Drawing.Point(0, 0);
            this.uc_f.Name = "uc_f";
            this.uc_f.Size = new System.Drawing.Size(314, 312);
            this.uc_f.TabIndex = 0;
            // 
            // Generic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 323);
            this.Controls.Add(this.uc_f);
            this.Name = "Generic";
            this.Text = "Generic";
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal SaveFileDialog sf_file;
        internal FolderBrowserDialog fb_directory;
        internal ToolTip tt_folder;
        internal ToolTip tt_file;
        internal ErrorProvider ep_error;
        private Asset.Fields uc_f;
    }
}
namespace OTOI_ADD.View.OMIE
{
    partial class HMT
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
            this.mp_date = new OTOI_ADD.View.Asset.Control.MonthPicker();
            this.lb_date = new System.Windows.Forms.Label();
            this.cb_process = new System.Windows.Forms.CheckBox();
            this.cb_keepDownload = new System.Windows.Forms.CheckBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_accept = new System.Windows.Forms.Button();
            this.bt_fileDest = new System.Windows.Forms.Button();
            this.bt_downloadDir = new System.Windows.Forms.Button();
            this.lb_bt_downloadDir = new System.Windows.Forms.Label();
            this.lb_bt_fileDest = new System.Windows.Forms.Label();
            this.lb_link = new System.Windows.Forms.LinkLabel();
            this.lb_title = new System.Windows.Forms.Label();
            this.sf_file = new System.Windows.Forms.SaveFileDialog();
            this.fb_directory = new System.Windows.Forms.FolderBrowserDialog();
            this.tt_folder = new System.Windows.Forms.ToolTip(this.components);
            this.tt_file = new System.Windows.Forms.ToolTip(this.components);
            this.ep_error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).BeginInit();
            this.SuspendLayout();
            // 
            // mp_date
            // 
            this.mp_date.CustomFormat = "MMMM yyyy";
            this.mp_date.Location = new System.Drawing.Point(52, 53);
            this.mp_date.Name = "mp_date";
            this.mp_date.Size = new System.Drawing.Size(120, 23);
            this.mp_date.TabIndex = 152;
            this.mp_date.ValueChanged += new System.EventHandler(this.Mp_date_ValueChanged);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(11, 58);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(29, 15);
            this.lb_date.TabIndex = 151;
            this.lb_date.Text = "Mes";
            // 
            // cb_process
            // 
            this.cb_process.AutoSize = true;
            this.cb_process.Location = new System.Drawing.Point(8, 116);
            this.cb_process.Name = "cb_process";
            this.cb_process.Size = new System.Drawing.Size(187, 19);
            this.cb_process.TabIndex = 160;
            this.cb_process.Text = "Procesar archivos descargados";
            this.cb_process.UseVisualStyleBackColor = true;
            this.cb_process.Click += new System.EventHandler(this.Cb_process_CheckedChanged);
            // 
            // cb_keepDownload
            // 
            this.cb_keepDownload.AutoSize = true;
            this.cb_keepDownload.Enabled = false;
            this.cb_keepDownload.Location = new System.Drawing.Point(8, 144);
            this.cb_keepDownload.Name = "cb_keepDownload";
            this.cb_keepDownload.Size = new System.Drawing.Size(193, 19);
            this.cb_keepDownload.TabIndex = 159;
            this.cb_keepDownload.Text = "Mantener archivos descargados";
            this.cb_keepDownload.UseVisualStyleBackColor = true;
            this.cb_keepDownload.Click += new System.EventHandler(this.Cb_keepDownload_CheckedChanged);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_cancel.Location = new System.Drawing.Point(184, 200);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 158;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_accept
            // 
            this.bt_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_accept.Location = new System.Drawing.Point(80, 200);
            this.bt_accept.Name = "bt_accept";
            this.bt_accept.Size = new System.Drawing.Size(75, 23);
            this.bt_accept.TabIndex = 157;
            this.bt_accept.Text = "Aceptar";
            this.bt_accept.UseVisualStyleBackColor = false;
            this.bt_accept.Click += new System.EventHandler(this.Bt_accept_Click);
            // 
            // bt_fileDest
            // 
            this.bt_fileDest.Enabled = false;
            this.bt_fileDest.Location = new System.Drawing.Point(8, 168);
            this.bt_fileDest.Name = "bt_fileDest";
            this.bt_fileDest.Size = new System.Drawing.Size(109, 23);
            this.bt_fileDest.TabIndex = 156;
            this.bt_fileDest.Text = "Archivo final";
            this.bt_fileDest.UseVisualStyleBackColor = true;
            this.bt_fileDest.Click += new System.EventHandler(this.Bt_fileDest_Click);
            // 
            // bt_downloadDir
            // 
            this.bt_downloadDir.Location = new System.Drawing.Point(8, 84);
            this.bt_downloadDir.Name = "bt_downloadDir";
            this.bt_downloadDir.Size = new System.Drawing.Size(109, 23);
            this.bt_downloadDir.TabIndex = 155;
            this.bt_downloadDir.Text = "Carpeta destino";
            this.bt_downloadDir.UseVisualStyleBackColor = true;
            this.bt_downloadDir.Click += new System.EventHandler(this.Bt_downloadDir_Click);
            // 
            // lb_bt_downloadDir
            // 
            this.lb_bt_downloadDir.Location = new System.Drawing.Point(120, 88);
            this.lb_bt_downloadDir.Name = "lb_bt_downloadDir";
            this.lb_bt_downloadDir.Size = new System.Drawing.Size(200, 15);
            this.lb_bt_downloadDir.TabIndex = 154;
            this.lb_bt_downloadDir.Text = "Ruta de descarga de archivos";
            // 
            // lb_bt_fileDest
            // 
            this.lb_bt_fileDest.Enabled = false;
            this.lb_bt_fileDest.Location = new System.Drawing.Point(120, 172);
            this.lb_bt_fileDest.Name = "lb_bt_fileDest";
            this.lb_bt_fileDest.Size = new System.Drawing.Size(200, 15);
            this.lb_bt_fileDest.TabIndex = 153;
            this.lb_bt_fileDest.Text = "Ruta de archivo final";
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Location = new System.Drawing.Point(292, 20);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(23, 15);
            this.lb_link.TabIndex = 162;
            this.lb_link.TabStop = true;
            this.lb_link.Tag = "";
            this.lb_link.Text = "Ver";
            this.lb_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lb_link_LinkClicked);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_title.Location = new System.Drawing.Point(8, 8);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(276, 40);
            this.lb_title.TabIndex = 161;
            this.lb_title.Text = "[Form title]";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // HMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 231);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.cb_process);
            this.Controls.Add(this.cb_keepDownload);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_accept);
            this.Controls.Add(this.bt_fileDest);
            this.Controls.Add(this.bt_downloadDir);
            this.Controls.Add(this.lb_bt_downloadDir);
            this.Controls.Add(this.lb_bt_fileDest);
            this.Controls.Add(this.mp_date);
            this.Controls.Add(this.lb_date);
            this.Name = "HMT";
            this.Text = "HMT";
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Asset.Control.MonthPicker mp_date;
        internal Label lb_date;
        internal CheckBox cb_process;
        internal CheckBox cb_keepDownload;
        internal Button bt_cancel;
        internal Button bt_accept;
        internal Button bt_fileDest;
        internal Button bt_downloadDir;
        internal Label lb_bt_downloadDir;
        internal Label lb_bt_fileDest;
        internal LinkLabel lb_link;
        internal Label lb_title;
        internal SaveFileDialog sf_file;
        internal FolderBrowserDialog fb_directory;
        internal ToolTip tt_folder;
        internal ToolTip tt_file;
        internal ErrorProvider ep_error;
    }
}
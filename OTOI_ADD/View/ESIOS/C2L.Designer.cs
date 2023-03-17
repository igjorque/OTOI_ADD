namespace OTOI_ADD.View.ESIOS
{
    partial class C2L
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
            this.cb_unzip = new System.Windows.Forms.CheckBox();
            this.lb_link = new System.Windows.Forms.LinkLabel();
            this.cb_keep = new System.Windows.Forms.CheckBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_accept = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.bt_fileDest = new System.Windows.Forms.Button();
            this.bt_downloadDir = new System.Windows.Forms.Button();
            this.lb_bt_downloadDir = new System.Windows.Forms.Label();
            this.lb_bt_fileDest = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.mp_date = new OTOI_ADD.View.Asset.Control.MonthPicker();
            this.cb_process = new System.Windows.Forms.CheckBox();
            this.sf_file = new System.Windows.Forms.SaveFileDialog();
            this.fb_directory = new System.Windows.Forms.FolderBrowserDialog();
            this.tt_folder = new System.Windows.Forms.ToolTip(this.components);
            this.tt_file = new System.Windows.Forms.ToolTip(this.components);
            this.ep_error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_unzip
            // 
            this.cb_unzip.AutoSize = true;
            this.cb_unzip.Location = new System.Drawing.Point(6, 116);
            this.cb_unzip.Name = "cb_unzip";
            this.cb_unzip.Size = new System.Drawing.Size(151, 19);
            this.cb_unzip.TabIndex = 149;
            this.cb_unzip.Text = "Descomprimir descarga";
            this.cb_unzip.UseVisualStyleBackColor = true;
            this.cb_unzip.CheckedChanged += new System.EventHandler(this.Cb_unzip_CheckedChanged);
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Location = new System.Drawing.Point(290, 20);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(23, 15);
            this.lb_link.TabIndex = 148;
            this.lb_link.TabStop = true;
            this.lb_link.Tag = "";
            this.lb_link.Text = "Ver";
            this.lb_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lb_link_LinkClicked);
            // 
            // cb_keep
            // 
            this.cb_keep.AutoSize = true;
            this.cb_keep.Enabled = false;
            this.cb_keep.Location = new System.Drawing.Point(6, 144);
            this.cb_keep.Name = "cb_keep";
            this.cb_keep.Size = new System.Drawing.Size(188, 19);
            this.cb_keep.TabIndex = 147;
            this.cb_keep.Text = "Mantener archivo comprimido";
            this.cb_keep.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_cancel.Location = new System.Drawing.Point(182, 232);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 146;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_accept
            // 
            this.bt_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_accept.Enabled = false;
            this.bt_accept.Location = new System.Drawing.Point(78, 232);
            this.bt_accept.Name = "bt_accept";
            this.bt_accept.Size = new System.Drawing.Size(75, 23);
            this.bt_accept.TabIndex = 145;
            this.bt_accept.Text = "Aceptar";
            this.bt_accept.UseVisualStyleBackColor = false;
            this.bt_accept.Click += new System.EventHandler(this.Bt_accept_Click);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_title.Location = new System.Drawing.Point(6, 8);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(276, 40);
            this.lb_title.TabIndex = 144;
            this.lb_title.Text = "[Form title]";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_fileDest
            // 
            this.bt_fileDest.Enabled = false;
            this.bt_fileDest.Location = new System.Drawing.Point(6, 200);
            this.bt_fileDest.Name = "bt_fileDest";
            this.bt_fileDest.Size = new System.Drawing.Size(109, 23);
            this.bt_fileDest.TabIndex = 143;
            this.bt_fileDest.Text = "Archivo final";
            this.bt_fileDest.UseVisualStyleBackColor = true;
            this.bt_fileDest.Click += new System.EventHandler(this.Bt_fileDest_Click);
            // 
            // bt_downloadDir
            // 
            this.bt_downloadDir.Location = new System.Drawing.Point(6, 84);
            this.bt_downloadDir.Name = "bt_downloadDir";
            this.bt_downloadDir.Size = new System.Drawing.Size(109, 23);
            this.bt_downloadDir.TabIndex = 142;
            this.bt_downloadDir.Text = "Carpeta destino";
            this.bt_downloadDir.UseVisualStyleBackColor = true;
            this.bt_downloadDir.Click += new System.EventHandler(this.Bt_downloadDir_Click);
            // 
            // lb_bt_downloadDir
            // 
            this.lb_bt_downloadDir.Location = new System.Drawing.Point(118, 88);
            this.lb_bt_downloadDir.Name = "lb_bt_downloadDir";
            this.lb_bt_downloadDir.Size = new System.Drawing.Size(200, 15);
            this.lb_bt_downloadDir.TabIndex = 141;
            this.lb_bt_downloadDir.Text = "Ruta de descarga de archivos";
            // 
            // lb_bt_fileDest
            // 
            this.lb_bt_fileDest.Enabled = false;
            this.lb_bt_fileDest.Location = new System.Drawing.Point(118, 204);
            this.lb_bt_fileDest.Name = "lb_bt_fileDest";
            this.lb_bt_fileDest.Size = new System.Drawing.Size(200, 15);
            this.lb_bt_fileDest.TabIndex = 140;
            this.lb_bt_fileDest.Text = "Ruta de archivo final";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(6, 56);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(29, 15);
            this.lb_date.TabIndex = 139;
            this.lb_date.Text = "Mes";
            // 
            // mp_date
            // 
            this.mp_date.CustomFormat = "MMMM yyyy";
            this.mp_date.Location = new System.Drawing.Point(47, 51);
            this.mp_date.Name = "mp_date";
            this.mp_date.Size = new System.Drawing.Size(120, 23);
            this.mp_date.TabIndex = 150;
            this.mp_date.ValueChanged += new System.EventHandler(this.Mp_date_ValueChanged);
            // 
            // cb_process
            // 
            this.cb_process.AutoSize = true;
            this.cb_process.Enabled = false;
            this.cb_process.Location = new System.Drawing.Point(6, 172);
            this.cb_process.Name = "cb_process";
            this.cb_process.Size = new System.Drawing.Size(118, 19);
            this.cb_process.TabIndex = 151;
            this.cb_process.Text = "Procesar archivos";
            this.cb_process.UseVisualStyleBackColor = true;
            this.cb_process.CheckedChanged += new System.EventHandler(this.Cb_process_CheckedChanged);
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
            // C2L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 262);
            this.Controls.Add(this.cb_process);
            this.Controls.Add(this.mp_date);
            this.Controls.Add(this.cb_unzip);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.cb_keep);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_accept);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.bt_fileDest);
            this.Controls.Add(this.bt_downloadDir);
            this.Controls.Add(this.lb_bt_downloadDir);
            this.Controls.Add(this.lb_bt_fileDest);
            this.Controls.Add(this.lb_date);
            this.Name = "C2L";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "C2L";
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal CheckBox cb_unzip;
        internal LinkLabel lb_link;
        internal CheckBox cb_keep;
        internal Button bt_cancel;
        public Button bt_accept;
        internal Label lb_title;
        internal Button bt_fileDest;
        internal Button bt_downloadDir;
        internal Label lb_bt_downloadDir;
        internal Label lb_bt_fileDest;
        internal Label lb_date;
        private Asset.Control.MonthPicker mp_date;
        internal CheckBox cb_process;
        internal SaveFileDialog sf_file;
        internal FolderBrowserDialog fb_directory;
        internal ToolTip tt_folder;
        internal ToolTip tt_file;
        internal ErrorProvider ep_error;
    }
}
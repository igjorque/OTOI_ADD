namespace OTOI_ADD.View.OMIE
{
    partial class HourlyPriceConsumers
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
            this.lb_title = new System.Windows.Forms.Label();
            this.bt_fileDest = new System.Windows.Forms.Button();
            this.bt_downloadDir = new System.Windows.Forms.Button();
            this.lb_bt_downloadDir = new System.Windows.Forms.Label();
            this.lb_bt_fileDest = new System.Windows.Forms.Label();
            this.lb_ca_day = new System.Windows.Forms.Label();
            this.ca_day = new System.Windows.Forms.DateTimePicker();
            this.bt_accept = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.ch_keepDownload = new System.Windows.Forms.CheckBox();
            this.sf_directory = new System.Windows.Forms.SaveFileDialog();
            this.sf_file = new System.Windows.Forms.SaveFileDialog();
            this.fb_directory = new System.Windows.Forms.FolderBrowserDialog();
            this.tt_folder = new System.Windows.Forms.ToolTip(this.components);
            this.tt_file = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ep_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_link = new System.Windows.Forms.LinkLabel();
            this.ch_process = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_title.Location = new System.Drawing.Point(12, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(279, 63);
            this.lb_title.TabIndex = 71;
            this.lb_title.Text = "Precio definitivo horario del mecanismo de ajuste a los consumidores en el mercad" +
    "o";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_fileDest
            // 
            this.bt_fileDest.Enabled = false;
            this.bt_fileDest.Location = new System.Drawing.Point(12, 198);
            this.bt_fileDest.Name = "bt_fileDest";
            this.bt_fileDest.Size = new System.Drawing.Size(109, 23);
            this.bt_fileDest.TabIndex = 70;
            this.bt_fileDest.Text = "Archivo final";
            this.bt_fileDest.UseVisualStyleBackColor = true;
            this.bt_fileDest.Click += new System.EventHandler(this.bt_fileDest_Click);
            // 
            // bt_downloadDir
            // 
            this.bt_downloadDir.Location = new System.Drawing.Point(12, 135);
            this.bt_downloadDir.Name = "bt_downloadDir";
            this.bt_downloadDir.Size = new System.Drawing.Size(109, 23);
            this.bt_downloadDir.TabIndex = 69;
            this.bt_downloadDir.Text = "Carpeta destino";
            this.bt_downloadDir.UseVisualStyleBackColor = true;
            this.bt_downloadDir.Click += new System.EventHandler(this.bt_downloadDir_Click);
            // 
            // lb_bt_downloadDir
            // 
            this.lb_bt_downloadDir.Location = new System.Drawing.Point(127, 139);
            this.lb_bt_downloadDir.Name = "lb_bt_downloadDir";
            this.lb_bt_downloadDir.Size = new System.Drawing.Size(185, 15);
            this.lb_bt_downloadDir.TabIndex = 68;
            this.lb_bt_downloadDir.Text = "Ruta de descarga de archivos";
            // 
            // lb_bt_fileDest
            // 
            this.lb_bt_fileDest.Enabled = false;
            this.lb_bt_fileDest.Location = new System.Drawing.Point(127, 202);
            this.lb_bt_fileDest.Name = "lb_bt_fileDest";
            this.lb_bt_fileDest.Size = new System.Drawing.Size(185, 15);
            this.lb_bt_fileDest.TabIndex = 67;
            this.lb_bt_fileDest.Text = "Ruta de archivo final";
            // 
            // lb_ca_day
            // 
            this.lb_ca_day.AutoSize = true;
            this.lb_ca_day.Location = new System.Drawing.Point(12, 82);
            this.lb_ca_day.Name = "lb_ca_day";
            this.lb_ca_day.Size = new System.Drawing.Size(24, 15);
            this.lb_ca_day.TabIndex = 65;
            this.lb_ca_day.Text = "Dia";
            // 
            // ca_day
            // 
            this.ca_day.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ca_day.Location = new System.Drawing.Point(51, 76);
            this.ca_day.Name = "ca_day";
            this.ca_day.Size = new System.Drawing.Size(120, 23);
            this.ca_day.TabIndex = 61;
            this.ca_day.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.ca_day.Validated += new System.EventHandler(this.ca_date_Validated);
            // 
            // bt_accept
            // 
            this.bt_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_accept.Location = new System.Drawing.Point(77, 237);
            this.bt_accept.Name = "bt_accept";
            this.bt_accept.Size = new System.Drawing.Size(75, 23);
            this.bt_accept.TabIndex = 73;
            this.bt_accept.Text = "Aceptar";
            this.bt_accept.UseVisualStyleBackColor = false;
            this.bt_accept.Click += new System.EventHandler(this.bt_accept_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_cancel.Location = new System.Drawing.Point(180, 237);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 74;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // ch_keepDownload
            // 
            this.ch_keepDownload.AutoSize = true;
            this.ch_keepDownload.Checked = true;
            this.ch_keepDownload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_keepDownload.Location = new System.Drawing.Point(12, 110);
            this.ch_keepDownload.Name = "ch_keepDownload";
            this.ch_keepDownload.Size = new System.Drawing.Size(193, 19);
            this.ch_keepDownload.TabIndex = 75;
            this.ch_keepDownload.Text = "Mantener archivos descargados";
            this.ch_keepDownload.UseVisualStyleBackColor = true;
            this.ch_keepDownload.CheckedChanged += new System.EventHandler(this.ch_enabler);
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
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Location = new System.Drawing.Point(297, 34);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(23, 15);
            this.lb_link.TabIndex = 76;
            this.lb_link.TabStop = true;
            this.lb_link.Tag = "";
            this.lb_link.Text = "Ver";
            this.lb_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_link_LinkClicked);
            // 
            // ch_process
            // 
            this.ch_process.AutoSize = true;
            this.ch_process.Enabled = false;
            this.ch_process.Location = new System.Drawing.Point(12, 173);
            this.ch_process.Name = "ch_process";
            this.ch_process.Size = new System.Drawing.Size(193, 19);
            this.ch_process.TabIndex = 77;
            this.ch_process.Text = "Mantener archivos descargados";
            this.ch_process.UseVisualStyleBackColor = true;
            // 
            // HourlyPriceConsumers
            // 
            this.AcceptButton = this.bt_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_cancel;
            this.ClientSize = new System.Drawing.Size(327, 272);
            this.Controls.Add(this.ch_process);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.ch_keepDownload);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_accept);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.bt_fileDest);
            this.Controls.Add(this.bt_downloadDir);
            this.Controls.Add(this.lb_bt_downloadDir);
            this.Controls.Add(this.lb_bt_fileDest);
            this.Controls.Add(this.lb_ca_day);
            this.Controls.Add(this.ca_day);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HourlyPriceConsumers";
            this.Text = "OMIE";
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal Button bt_cancel;
        internal Label lb_title;
        internal Button bt_fileDest;
        internal Button bt_downloadDir;
        internal Label lb_bt_downloadDir;
        internal Label lb_bt_fileDest;
        internal Label lb_ca_day;
        internal DateTimePicker ca_day;
        private SaveFileDialog sf_directory;
        private SaveFileDialog sf_file;
        private FolderBrowserDialog fb_directory;
        private ToolTip tt_folder;
        private ToolTip tt_file;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Button bt_accept;
        internal CheckBox ch_keepDownload;
        internal ErrorProvider ep_error;
        private LinkLabel lb_link;
        internal CheckBox ch_process;
    }
}
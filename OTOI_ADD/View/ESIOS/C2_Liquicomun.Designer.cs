namespace OTOI_ADD.View.ESIOS
{
    partial class C2_Liquicomun
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
            this.lb_separator = new System.Windows.Forms.Label();
            this.ca_date_end = new System.Windows.Forms.DateTimePicker();
            this.lb_link = new System.Windows.Forms.LinkLabel();
            this.cb_keepDownload = new System.Windows.Forms.CheckBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_accept = new System.Windows.Forms.Button();
            this.bt_downloadDir = new System.Windows.Forms.Button();
            this.lb_bt_downloadDir = new System.Windows.Forms.Label();
            this.lb_ca_day = new System.Windows.Forms.Label();
            this.ca_date_start = new System.Windows.Forms.DateTimePicker();
            this.cb_decompress = new System.Windows.Forms.CheckBox();
            this.fb_directory = new System.Windows.Forms.FolderBrowserDialog();
            this.tt_folder = new System.Windows.Forms.ToolTip(this.components);
            this.ep_error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_title.Location = new System.Drawing.Point(12, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(279, 40);
            this.lb_title.TabIndex = 120;
            this.lb_title.Text = "C2_Liquicomun";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_separator
            // 
            this.lb_separator.AutoSize = true;
            this.lb_separator.Location = new System.Drawing.Point(179, 58);
            this.lb_separator.Name = "lb_separator";
            this.lb_separator.Size = new System.Drawing.Size(12, 15);
            this.lb_separator.TabIndex = 119;
            this.lb_separator.Text = "-";
            // 
            // ca_date_end
            // 
            this.ca_date_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ca_date_end.Location = new System.Drawing.Point(197, 52);
            this.ca_date_end.Name = "ca_date_end";
            this.ca_date_end.Size = new System.Drawing.Size(120, 23);
            this.ca_date_end.TabIndex = 118;
            this.ca_date_end.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Location = new System.Drawing.Point(291, 23);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(23, 15);
            this.lb_link.TabIndex = 116;
            this.lb_link.TabStop = true;
            this.lb_link.Tag = "";
            this.lb_link.Text = "Ver";
            this.lb_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_link_LinkClicked);
            // 
            // cb_keepDownload
            // 
            this.cb_keepDownload.AutoSize = true;
            this.cb_keepDownload.Enabled = false;
            this.cb_keepDownload.Location = new System.Drawing.Point(12, 144);
            this.cb_keepDownload.Name = "cb_keepDownload";
            this.cb_keepDownload.Size = new System.Drawing.Size(193, 19);
            this.cb_keepDownload.TabIndex = 115;
            this.cb_keepDownload.Text = "Mantener archivos descargados";
            this.cb_keepDownload.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_cancel.Location = new System.Drawing.Point(174, 178);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 114;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_accept
            // 
            this.bt_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_accept.Location = new System.Drawing.Point(71, 178);
            this.bt_accept.Name = "bt_accept";
            this.bt_accept.Size = new System.Drawing.Size(75, 23);
            this.bt_accept.TabIndex = 113;
            this.bt_accept.Text = "Aceptar";
            this.bt_accept.UseVisualStyleBackColor = false;
            this.bt_accept.Click += new System.EventHandler(this.bt_accept_Click);
            // 
            // bt_downloadDir
            // 
            this.bt_downloadDir.Location = new System.Drawing.Point(14, 90);
            this.bt_downloadDir.Name = "bt_downloadDir";
            this.bt_downloadDir.Size = new System.Drawing.Size(109, 23);
            this.bt_downloadDir.TabIndex = 111;
            this.bt_downloadDir.Text = "Carpeta destino";
            this.bt_downloadDir.UseVisualStyleBackColor = true;
            this.bt_downloadDir.Click += new System.EventHandler(this.bt_downloadDir_Click);
            // 
            // lb_bt_downloadDir
            // 
            this.lb_bt_downloadDir.Location = new System.Drawing.Point(129, 94);
            this.lb_bt_downloadDir.Name = "lb_bt_downloadDir";
            this.lb_bt_downloadDir.Size = new System.Drawing.Size(185, 15);
            this.lb_bt_downloadDir.TabIndex = 110;
            this.lb_bt_downloadDir.Text = "Ruta de descarga de archivos";
            // 
            // lb_ca_day
            // 
            this.lb_ca_day.AutoSize = true;
            this.lb_ca_day.Location = new System.Drawing.Point(14, 58);
            this.lb_ca_day.Name = "lb_ca_day";
            this.lb_ca_day.Size = new System.Drawing.Size(29, 15);
            this.lb_ca_day.TabIndex = 108;
            this.lb_ca_day.Text = "Dias";
            // 
            // ca_date_start
            // 
            this.ca_date_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ca_date_start.Location = new System.Drawing.Point(53, 52);
            this.ca_date_start.Name = "ca_date_start";
            this.ca_date_start.Size = new System.Drawing.Size(120, 23);
            this.ca_date_start.TabIndex = 107;
            this.ca_date_start.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // cb_decompress
            // 
            this.cb_decompress.AutoSize = true;
            this.cb_decompress.Enabled = false;
            this.cb_decompress.Location = new System.Drawing.Point(12, 119);
            this.cb_decompress.Name = "cb_decompress";
            this.cb_decompress.Size = new System.Drawing.Size(101, 19);
            this.cb_decompress.TabIndex = 121;
            this.cb_decompress.Text = "Descomprimir";
            this.cb_decompress.UseVisualStyleBackColor = true;
            this.cb_decompress.CheckedChanged += new System.EventHandler(this.cb_decompress_CheckedChanged);
            // 
            // tt_folder
            // 
            this.tt_folder.AutoPopDelay = 5000;
            this.tt_folder.InitialDelay = 100;
            this.tt_folder.ReshowDelay = 100;
            // 
            // ep_error
            // 
            this.ep_error.ContainerControl = this;
            // 
            // C2_Liquicomun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 217);
            this.Controls.Add(this.cb_decompress);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.lb_separator);
            this.Controls.Add(this.ca_date_end);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.cb_keepDownload);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_accept);
            this.Controls.Add(this.bt_downloadDir);
            this.Controls.Add(this.lb_bt_downloadDir);
            this.Controls.Add(this.lb_ca_day);
            this.Controls.Add(this.ca_date_start);
            this.Name = "C2_Liquicomun";
            this.Text = "ESIOS";
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label lb_title;
        internal Label lb_separator;
        internal DateTimePicker ca_date_end;
        private LinkLabel lb_link;
        internal CheckBox cb_keepDownload;
        internal Button bt_cancel;
        public Button bt_accept;
        internal Button bt_downloadDir;
        internal Label lb_bt_downloadDir;
        internal Label lb_ca_day;
        internal DateTimePicker ca_date_start;
        internal CheckBox cb_decompress;
        private FolderBrowserDialog fb_directory;
        private ToolTip tt_folder;
        internal ErrorProvider ep_error;
    }
}
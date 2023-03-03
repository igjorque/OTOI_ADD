namespace OTOI_ADD.View.Asset
{
    partial class Fields
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_process = new System.Windows.Forms.CheckBox();
            this.lb_link = new System.Windows.Forms.LinkLabel();
            this.cb_keepDownload = new System.Windows.Forms.CheckBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_accept = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.bt_fileDest = new System.Windows.Forms.Button();
            this.bt_downloadDir = new System.Windows.Forms.Button();
            this.lb_bt_downloadDir = new System.Windows.Forms.Label();
            this.lb_bt_fileDest = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.ca_date_start = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cb_process
            // 
            this.cb_process.AutoSize = true;
            this.cb_process.Location = new System.Drawing.Point(1, 114);
            this.cb_process.Name = "cb_process";
            this.cb_process.Size = new System.Drawing.Size(187, 19);
            this.cb_process.TabIndex = 137;
            this.cb_process.Text = "Procesar archivos descargados";
            this.cb_process.UseVisualStyleBackColor = true;
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Location = new System.Drawing.Point(285, 18);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(23, 15);
            this.lb_link.TabIndex = 136;
            this.lb_link.TabStop = true;
            this.lb_link.Tag = "";
            this.lb_link.Text = "Ver";
            // 
            // cb_keepDownload
            // 
            this.cb_keepDownload.AutoSize = true;
            this.cb_keepDownload.Enabled = false;
            this.cb_keepDownload.Location = new System.Drawing.Point(1, 142);
            this.cb_keepDownload.Name = "cb_keepDownload";
            this.cb_keepDownload.Size = new System.Drawing.Size(193, 19);
            this.cb_keepDownload.TabIndex = 135;
            this.cb_keepDownload.Text = "Mantener archivos descargados";
            this.cb_keepDownload.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_cancel.Location = new System.Drawing.Point(177, 198);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 134;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = false;
            // 
            // bt_accept
            // 
            this.bt_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_accept.Location = new System.Drawing.Point(73, 198);
            this.bt_accept.Name = "bt_accept";
            this.bt_accept.Size = new System.Drawing.Size(75, 23);
            this.bt_accept.TabIndex = 133;
            this.bt_accept.Text = "Aceptar";
            this.bt_accept.UseVisualStyleBackColor = false;
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_title.Location = new System.Drawing.Point(1, 6);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(276, 40);
            this.lb_title.TabIndex = 132;
            this.lb_title.Text = "[Form title]";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_fileDest
            // 
            this.bt_fileDest.Enabled = false;
            this.bt_fileDest.Location = new System.Drawing.Point(1, 166);
            this.bt_fileDest.Name = "bt_fileDest";
            this.bt_fileDest.Size = new System.Drawing.Size(109, 23);
            this.bt_fileDest.TabIndex = 131;
            this.bt_fileDest.Text = "Archivo final";
            this.bt_fileDest.UseVisualStyleBackColor = true;
            // 
            // bt_downloadDir
            // 
            this.bt_downloadDir.Location = new System.Drawing.Point(1, 82);
            this.bt_downloadDir.Name = "bt_downloadDir";
            this.bt_downloadDir.Size = new System.Drawing.Size(109, 23);
            this.bt_downloadDir.TabIndex = 130;
            this.bt_downloadDir.Text = "Carpeta destino";
            this.bt_downloadDir.UseVisualStyleBackColor = true;
            // 
            // lb_bt_downloadDir
            // 
            this.lb_bt_downloadDir.Location = new System.Drawing.Point(113, 86);
            this.lb_bt_downloadDir.Name = "lb_bt_downloadDir";
            this.lb_bt_downloadDir.Size = new System.Drawing.Size(200, 15);
            this.lb_bt_downloadDir.TabIndex = 129;
            this.lb_bt_downloadDir.Text = "Ruta de descarga de archivos";
            // 
            // lb_bt_fileDest
            // 
            this.lb_bt_fileDest.Enabled = false;
            this.lb_bt_fileDest.Location = new System.Drawing.Point(113, 170);
            this.lb_bt_fileDest.Name = "lb_bt_fileDest";
            this.lb_bt_fileDest.Size = new System.Drawing.Size(200, 15);
            this.lb_bt_fileDest.TabIndex = 128;
            this.lb_bt_fileDest.Text = "Ruta de archivo final";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(1, 54);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(24, 15);
            this.lb_date.TabIndex = 127;
            this.lb_date.Text = "Dia";
            // 
            // ca_date_start
            // 
            this.ca_date_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ca_date_start.Location = new System.Drawing.Point(42, 49);
            this.ca_date_start.Name = "ca_date_start";
            this.ca_date_start.Size = new System.Drawing.Size(120, 23);
            this.ca_date_start.TabIndex = 126;
            this.ca_date_start.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // Fields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_process);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.cb_keepDownload);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_accept);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.bt_fileDest);
            this.Controls.Add(this.bt_downloadDir);
            this.Controls.Add(this.lb_bt_downloadDir);
            this.Controls.Add(this.lb_bt_fileDest);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.ca_date_start);
            this.Name = "Fields";
            this.Size = new System.Drawing.Size(314, 227);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal CheckBox cb_process;
        internal CheckBox cb_keepDownload;
        internal Button bt_cancel;
        public Button bt_accept;
        internal Label lb_title;
        internal Button bt_fileDest;
        internal Button bt_downloadDir;
        internal Label lb_bt_downloadDir;
        internal Label lb_bt_fileDest;
        internal Label lb_date;
        internal DateTimePicker ca_date_start;
        internal LinkLabel lb_link;
    }
}

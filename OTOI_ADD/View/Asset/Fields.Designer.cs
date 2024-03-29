﻿namespace OTOI_ADD.View.Asset
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
            this.cb_keep = new System.Windows.Forms.CheckBox();
            this.bt_cancel = new OTOI_ADD.View.Asset.Button2();
            this.bt_accept = new OTOI_ADD.View.Asset.Button2();
            this.bt_fileDest = new System.Windows.Forms.Button();
            this.bt_downloadDir = new System.Windows.Forms.Button();
            this.lb_title = new OTOI_ADD.View.Asset.Label2();
            this.lb_download = new OTOI_ADD.View.Asset.Label2();
            this.lb_file = new OTOI_ADD.View.Asset.Label2();
            this.SuspendLayout();
            // 
            // cb_process
            // 
            this.cb_process.AutoSize = true;
            this.cb_process.ForeColor = System.Drawing.Color.Black;
            this.cb_process.Location = new System.Drawing.Point(8, 112);
            this.cb_process.Name = "cb_process";
            this.cb_process.Size = new System.Drawing.Size(71, 19);
            this.cb_process.TabIndex = 164;
            this.cb_process.Text = "Procesar";
            this.cb_process.UseVisualStyleBackColor = true;
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_link.LinkColor = System.Drawing.Color.Blue;
            this.lb_link.Location = new System.Drawing.Point(285, 18);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(25, 17);
            this.lb_link.TabIndex = 161;
            this.lb_link.TabStop = true;
            this.lb_link.Tag = "";
            this.lb_link.Text = "Ver";
            // 
            // cb_keep
            // 
            this.cb_keep.AutoSize = true;
            this.cb_keep.ForeColor = System.Drawing.Color.Black;
            this.cb_keep.Location = new System.Drawing.Point(8, 136);
            this.cb_keep.Name = "cb_keep";
            this.cb_keep.Size = new System.Drawing.Size(77, 19);
            this.cb_keep.TabIndex = 160;
            this.cb_keep.Text = "Mantener";
            this.cb_keep.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_cancel.Location = new System.Drawing.Point(160, 200);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 159;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = false;
            // 
            // bt_accept
            // 
            this.bt_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_accept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_accept.Location = new System.Drawing.Point(64, 200);
            this.bt_accept.Name = "bt_accept";
            this.bt_accept.Size = new System.Drawing.Size(75, 23);
            this.bt_accept.TabIndex = 158;
            this.bt_accept.Text = "Aceptar";
            this.bt_accept.UseVisualStyleBackColor = false;
            // 
            // bt_fileDest
            // 
            this.bt_fileDest.Location = new System.Drawing.Point(0, 168);
            this.bt_fileDest.Name = "bt_fileDest";
            this.bt_fileDest.Size = new System.Drawing.Size(109, 23);
            this.bt_fileDest.TabIndex = 156;
            this.bt_fileDest.Text = "Archivo final";
            this.bt_fileDest.UseVisualStyleBackColor = true;
            // 
            // bt_downloadDir
            // 
            this.bt_downloadDir.Location = new System.Drawing.Point(0, 80);
            this.bt_downloadDir.Name = "bt_downloadDir";
            this.bt_downloadDir.Size = new System.Drawing.Size(109, 23);
            this.bt_downloadDir.TabIndex = 155;
            this.bt_downloadDir.Text = "Carpeta destino";
            this.bt_downloadDir.UseVisualStyleBackColor = true;
            // 
            // lb_title
            // 
            this.lb_title.BackColor = System.Drawing.Color.White;
            this.lb_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_title.Location = new System.Drawing.Point(1, 6);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(276, 40);
            this.lb_title.TabIndex = 165;
            this.lb_title.Text = "[Form title]";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_download
            // 
            this.lb_download.BackColor = System.Drawing.Color.White;
            this.lb_download.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_download.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_download.Location = new System.Drawing.Point(112, 80);
            this.lb_download.Name = "lb_download";
            this.lb_download.Size = new System.Drawing.Size(200, 21);
            this.lb_download.TabIndex = 166;
            this.lb_download.Text = "Ruta de descarga de archivos";
            this.lb_download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_file
            // 
            this.lb_file.BackColor = System.Drawing.Color.White;
            this.lb_file.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_file.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_file.Location = new System.Drawing.Point(112, 168);
            this.lb_file.Name = "lb_file";
            this.lb_file.Size = new System.Drawing.Size(200, 21);
            this.lb_file.TabIndex = 167;
            this.lb_file.Text = "Ruta de archivo final";
            this.lb_file.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Fields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lb_file);
            this.Controls.Add(this.lb_download);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.cb_process);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.cb_keep);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_accept);
            this.Controls.Add(this.bt_fileDest);
            this.Controls.Add(this.bt_downloadDir);
            this.Name = "Fields";
            this.Size = new System.Drawing.Size(314, 233);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal CheckBox cb_process;
        internal LinkLabel lb_link;
        internal CheckBox cb_keep;
        internal Button2 bt_cancel;
        internal Button2 bt_accept;
        internal Button bt_fileDest;
        internal Button bt_downloadDir;
        internal Label2 lb_title;
        internal Label2 lb_download;
        internal Label2 lb_file;
    }
}

namespace ADD_Frontend.View
{
    partial class Configuration
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
            this.lb_section1 = new ADD_Frontend.View.Asset.Label2();
            this.lb_section2 = new ADD_Frontend.View.Asset.Label2();
            this.lb_section3 = new ADD_Frontend.View.Asset.Label2();
            this.cb_load_config = new System.Windows.Forms.CheckBox();
            this.lb_download = new ADD_Frontend.View.Asset.Label2();
            this.bt_download = new System.Windows.Forms.Button();
            this.cb_mode = new System.Windows.Forms.CheckBox();
            this.cb_lang = new System.Windows.Forms.ComboBox();
            this.lb_lang = new System.Windows.Forms.Label();
            this.cb_opr = new System.Windows.Forms.CheckBox();
            this.cb_okp = new System.Windows.Forms.CheckBox();
            this.cb_euz = new System.Windows.Forms.CheckBox();
            this.cb_ekp = new System.Windows.Forms.CheckBox();
            this.cb_epr = new System.Windows.Forms.CheckBox();
            this.bt_cancel = new ADD_Frontend.View.Asset.Button2();
            this.bt_accept = new ADD_Frontend.View.Asset.Button2();
            this.fb_directory = new System.Windows.Forms.FolderBrowserDialog();
            this.cb_save_config = new System.Windows.Forms.CheckBox();
            this.tt_help = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lb_section1
            // 
            this.lb_section1.BackColor = System.Drawing.Color.White;
            this.lb_section1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_section1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_section1.Location = new System.Drawing.Point(5, 5);
            this.lb_section1.Name = "lb_section1";
            this.lb_section1.Size = new System.Drawing.Size(305, 24);
            this.lb_section1.TabIndex = 166;
            this.lb_section1.Text = "General";
            this.lb_section1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_section2
            // 
            this.lb_section2.BackColor = System.Drawing.Color.White;
            this.lb_section2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_section2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_section2.Location = new System.Drawing.Point(6, 120);
            this.lb_section2.Name = "lb_section2";
            this.lb_section2.Size = new System.Drawing.Size(150, 24);
            this.lb_section2.TabIndex = 167;
            this.lb_section2.Text = "OMIE";
            this.lb_section2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_section3
            // 
            this.lb_section3.BackColor = System.Drawing.Color.White;
            this.lb_section3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_section3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_section3.Location = new System.Drawing.Point(158, 120);
            this.lb_section3.Name = "lb_section3";
            this.lb_section3.Size = new System.Drawing.Size(150, 24);
            this.lb_section3.TabIndex = 168;
            this.lb_section3.Text = "ESIOS";
            this.lb_section3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_load_config
            // 
            this.cb_load_config.AutoSize = true;
            this.cb_load_config.Checked = true;
            this.cb_load_config.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_load_config.Location = new System.Drawing.Point(5, 35);
            this.cb_load_config.Name = "cb_load_config";
            this.cb_load_config.Size = new System.Drawing.Size(138, 19);
            this.cb_load_config.TabIndex = 169;
            this.cb_load_config.Text = "Cargar configuración";
            this.tt_help.SetToolTip(this.cb_load_config, "Habilita o deshabilita la carga de la configuración al inicio del programa.");
            this.cb_load_config.UseVisualStyleBackColor = true;
            this.cb_load_config.CheckedChanged += new System.EventHandler(this.ConfigLoadChanged);
            // 
            // lb_download
            // 
            this.lb_download.BackColor = System.Drawing.Color.White;
            this.lb_download.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_download.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_download.Location = new System.Drawing.Point(118, 60);
            this.lb_download.Name = "lb_download";
            this.lb_download.Size = new System.Drawing.Size(190, 23);
            this.lb_download.TabIndex = 171;
            this.lb_download.Text = "Ruta de descarga de archivos";
            this.lb_download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_download
            // 
            this.bt_download.Location = new System.Drawing.Point(5, 60);
            this.bt_download.Name = "bt_download";
            this.bt_download.Size = new System.Drawing.Size(109, 23);
            this.bt_download.TabIndex = 170;
            this.bt_download.Text = "Carpeta destino";
            this.tt_help.SetToolTip(this.bt_download, "Selecciona la carpeta de destino por defecto para nuevas descargas.");
            this.bt_download.UseVisualStyleBackColor = true;
            this.bt_download.Click += new System.EventHandler(this.DownloadDestination);
            // 
            // cb_mode
            // 
            this.cb_mode.AutoSize = true;
            this.cb_mode.Location = new System.Drawing.Point(5, 92);
            this.cb_mode.Name = "cb_mode";
            this.cb_mode.Size = new System.Drawing.Size(140, 19);
            this.cb_mode.TabIndex = 172;
            this.cb_mode.Text = "Habilitar tema oscuro";
            this.tt_help.SetToolTip(this.cb_mode, "Habilita o deshabilita el tema oscuro del programa.");
            this.cb_mode.UseVisualStyleBackColor = true;
            this.cb_mode.CheckedChanged += new System.EventHandler(this.ThemeChanged);
            // 
            // cb_lang
            // 
            this.cb_lang.Enabled = false;
            this.cb_lang.FormattingEnabled = true;
            this.cb_lang.Items.AddRange(new object[] {
            "ES",
            "EN"});
            this.cb_lang.Location = new System.Drawing.Point(225, 90);
            this.cb_lang.Name = "cb_lang";
            this.cb_lang.Size = new System.Drawing.Size(83, 23);
            this.cb_lang.TabIndex = 173;
            this.tt_help.SetToolTip(this.cb_lang, "Establece el idioma del programa.");
            this.cb_lang.SelectedValueChanged += new System.EventHandler(this.LangChanged);
            // 
            // lb_lang
            // 
            this.lb_lang.AutoSize = true;
            this.lb_lang.Location = new System.Drawing.Point(175, 93);
            this.lb_lang.Name = "lb_lang";
            this.lb_lang.Size = new System.Drawing.Size(44, 15);
            this.lb_lang.TabIndex = 174;
            this.lb_lang.Text = "Idioma";
            // 
            // cb_opr
            // 
            this.cb_opr.AutoSize = true;
            this.cb_opr.Checked = true;
            this.cb_opr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_opr.Location = new System.Drawing.Point(5, 150);
            this.cb_opr.Name = "cb_opr";
            this.cb_opr.Size = new System.Drawing.Size(71, 19);
            this.cb_opr.TabIndex = 175;
            this.cb_opr.Text = "Procesar";
            this.cb_opr.UseVisualStyleBackColor = true;
            this.cb_opr.CheckedChanged += new System.EventHandler(this.OMIE_ProcessChanged);
            // 
            // cb_okp
            // 
            this.cb_okp.AutoSize = true;
            this.cb_okp.Location = new System.Drawing.Point(5, 170);
            this.cb_okp.Name = "cb_okp";
            this.cb_okp.Size = new System.Drawing.Size(77, 19);
            this.cb_okp.TabIndex = 176;
            this.cb_okp.Text = "Mantener";
            this.cb_okp.UseVisualStyleBackColor = true;
            this.cb_okp.CheckedChanged += new System.EventHandler(this.OMIE_KeepChanged);
            // 
            // cb_euz
            // 
            this.cb_euz.AutoSize = true;
            this.cb_euz.Checked = true;
            this.cb_euz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_euz.Location = new System.Drawing.Point(158, 150);
            this.cb_euz.Name = "cb_euz";
            this.cb_euz.Size = new System.Drawing.Size(101, 19);
            this.cb_euz.TabIndex = 177;
            this.cb_euz.Text = "Descomprimir";
            this.cb_euz.UseVisualStyleBackColor = true;
            this.cb_euz.CheckedChanged += new System.EventHandler(this.ESIOS_UnzipChanged);
            // 
            // cb_ekp
            // 
            this.cb_ekp.AutoSize = true;
            this.cb_ekp.Location = new System.Drawing.Point(158, 170);
            this.cb_ekp.Name = "cb_ekp";
            this.cb_ekp.Size = new System.Drawing.Size(77, 19);
            this.cb_ekp.TabIndex = 178;
            this.cb_ekp.Text = "Mantener";
            this.cb_ekp.UseVisualStyleBackColor = true;
            this.cb_ekp.CheckedChanged += new System.EventHandler(this.ESIOS_KeepChanged);
            // 
            // cb_epr
            // 
            this.cb_epr.AutoSize = true;
            this.cb_epr.Location = new System.Drawing.Point(158, 191);
            this.cb_epr.Name = "cb_epr";
            this.cb_epr.Size = new System.Drawing.Size(71, 19);
            this.cb_epr.TabIndex = 179;
            this.cb_epr.Text = "Procesar";
            this.cb_epr.UseVisualStyleBackColor = true;
            this.cb_epr.CheckedChanged += new System.EventHandler(this.ESIOS_ProcessChanged);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_cancel.Location = new System.Drawing.Point(166, 216);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 181;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.Cancel);
            // 
            // bt_accept
            // 
            this.bt_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_accept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_accept.Location = new System.Drawing.Point(70, 216);
            this.bt_accept.Name = "bt_accept";
            this.bt_accept.Size = new System.Drawing.Size(75, 23);
            this.bt_accept.TabIndex = 180;
            this.bt_accept.Text = "Aceptar";
            this.bt_accept.UseVisualStyleBackColor = false;
            this.bt_accept.Click += new System.EventHandler(this.Accept);
            // 
            // cb_save_config
            // 
            this.cb_save_config.AutoSize = true;
            this.cb_save_config.Checked = true;
            this.cb_save_config.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_save_config.Location = new System.Drawing.Point(158, 35);
            this.cb_save_config.Name = "cb_save_config";
            this.cb_save_config.Size = new System.Drawing.Size(145, 19);
            this.cb_save_config.TabIndex = 182;
            this.cb_save_config.Text = "Guardar configuración";
            this.tt_help.SetToolTip(this.cb_save_config, "Habilita o deshabilita el guardado de la configuración mientras se usa el program" +
        "a.");
            this.cb_save_config.UseVisualStyleBackColor = true;
            this.cb_save_config.CheckedChanged += new System.EventHandler(this.ConfigSaveChanged);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 246);
            this.Controls.Add(this.cb_save_config);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_accept);
            this.Controls.Add(this.cb_epr);
            this.Controls.Add(this.cb_ekp);
            this.Controls.Add(this.cb_euz);
            this.Controls.Add(this.cb_okp);
            this.Controls.Add(this.cb_opr);
            this.Controls.Add(this.lb_lang);
            this.Controls.Add(this.cb_lang);
            this.Controls.Add(this.cb_mode);
            this.Controls.Add(this.lb_download);
            this.Controls.Add(this.bt_download);
            this.Controls.Add(this.cb_load_config);
            this.Controls.Add(this.lb_section3);
            this.Controls.Add(this.lb_section2);
            this.Controls.Add(this.lb_section1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal Asset.Label2 lb_section1;
        internal Asset.Label2 lb_section2;
        internal Asset.Label2 lb_section3;
        internal Asset.Label2 lb_download;
        internal Button bt_download;
        internal CheckBox cb_load_config;
        internal CheckBox cb_mode;
        internal ComboBox cb_lang;
        internal Label lb_lang;
        internal CheckBox cb_opr;
        internal CheckBox cb_okp;
        internal CheckBox cb_euz;
        internal CheckBox cb_ekp;
        internal CheckBox cb_epr;
        internal Asset.Button2 bt_cancel;
        internal Asset.Button2 bt_accept;
        internal FolderBrowserDialog fb_directory;
        private CheckBox cb_save_config;
        private ToolTip tt_help;
    }
}
using OTOI_ADD.View.Asset;

namespace OTOI_ADD.View
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_config = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_file = new OTOI_ADD.View.Asset.ToolStripSeparator2();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_downloads = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_omie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HPCM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HMM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HMT = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_download1 = new OTOI_ADD.View.Asset.ToolStripSeparator2();
            this.tsmi_esios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_c2l = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_download2 = new OTOI_ADD.View.Asset.ToolStripSeparator2();
            this.tsmi_downloadFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_folder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_openDir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_installDir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_configDir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_downloadDir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_logsDir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_log = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_logSend = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new OTOI_ADD.View.Asset.ToolStripSeparator2();
            this.tss_utility = new OTOI_ADD.View.Asset.ToolStripSeparator2();
            this.tsmi_old = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_doc = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_help_2 = new OTOI_ADD.View.Asset.ToolStripSeparator2();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.tt_menu = new System.Windows.Forms.ToolTip(this.components);
            this.tsmi_HPC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_test = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_help_1 = new OTOI_ADD.View.Asset.ToolStripSeparator2();
            this.ms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.AutoSize = false;
            this.ms_menu.BackColor = System.Drawing.SystemColors.Control;
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_menu,
            this.tsmi_downloads,
            this.tsmi_folder,
            this.tsmi_help});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(499, 30);
            this.ms_menu.TabIndex = 22;
            this.ms_menu.Text = "menuStrip1";
            // 
            // tsmi_menu
            // 
            this.tsmi_menu.AutoSize = false;
            this.tsmi_menu.BackgroundImage = global::OTOI_ADD.Properties.Resources.button_light;
            this.tsmi_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsmi_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_config,
            this.tss_file,
            this.tsmi_exit});
            this.tsmi_menu.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.tsmi_menu.Name = "tsmi_menu";
            this.tsmi_menu.Size = new System.Drawing.Size(70, 26);
            this.tsmi_menu.Text = "Menú";
            this.tsmi_menu.DropDownClosed += new System.EventHandler(this.DropDownClosed);
            this.tsmi_menu.DropDownOpened += new System.EventHandler(this.DropDownOpened);
            // 
            // tsmi_config
            // 
            this.tsmi_config.Name = "tsmi_config";
            this.tsmi_config.Size = new System.Drawing.Size(180, 22);
            this.tsmi_config.Text = "Configuración";
            this.tsmi_config.Click += new System.EventHandler(this.ConfigureApp);
            // 
            // tss_file
            // 
            this.tss_file.Name = "tss_file";
            this.tss_file.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(180, 22);
            this.tsmi_exit.Text = "Salir";
            this.tsmi_exit.Click += new System.EventHandler(this.Exit);
            // 
            // tsmi_downloads
            // 
            this.tsmi_downloads.AutoSize = false;
            this.tsmi_downloads.BackgroundImage = global::OTOI_ADD.Properties.Resources.button_light;
            this.tsmi_downloads.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsmi_downloads.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_omie,
            this.tss_download1,
            this.tsmi_esios,
            this.tss_download2,
            this.tsmi_downloadFolder,
            this.tsmi_clear});
            this.tsmi_downloads.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.tsmi_downloads.Name = "tsmi_downloads";
            this.tsmi_downloads.Size = new System.Drawing.Size(70, 26);
            this.tsmi_downloads.Text = "Descargas";
            this.tsmi_downloads.DropDownClosed += new System.EventHandler(this.DropDownClosed);
            this.tsmi_downloads.DropDownOpened += new System.EventHandler(this.DropDownOpened);
            // 
            // tsmi_omie
            // 
            this.tsmi_omie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_HPCM,
            this.tsmi_HMM,
            this.tsmi_HMT});
            this.tsmi_omie.Name = "tsmi_omie";
            this.tsmi_omie.Size = new System.Drawing.Size(180, 22);
            this.tsmi_omie.Text = "OMIE";
            // 
            // tsmi_HPCM
            // 
            this.tsmi_HPCM.Name = "tsmi_HPCM";
            this.tsmi_HPCM.Size = new System.Drawing.Size(341, 22);
            this.tsmi_HPCM.Text = "Mecanismo de ajuste - Precio horario dia (HPCM)";
            this.tsmi_HPCM.ToolTipText = "Multiple Hourly Price Consumers\r\nPrecio definitivo horario del mecanismo de ajust" +
    "e a los consumidores en el mercado.\r\nPermite la descarga de datos de múltiples d" +
    "ías.\r\n";
            this.tsmi_HPCM.Click += new System.EventHandler(this.OpenForm_HPCM);
            // 
            // tsmi_HMM
            // 
            this.tsmi_HMM.Name = "tsmi_HMM";
            this.tsmi_HMM.Size = new System.Drawing.Size(341, 22);
            this.tsmi_HMM.Text = "Contratación horaria mercado diario (HMM)";
            this.tsmi_HMM.ToolTipText = "Precio energía horario mensual";
            this.tsmi_HMM.Click += new System.EventHandler(this.OpenForm_HMM);
            // 
            // tsmi_HMT
            // 
            this.tsmi_HMT.Name = "tsmi_HMT";
            this.tsmi_HMT.Size = new System.Drawing.Size(341, 22);
            this.tsmi_HMT.Text = "Tabla - Contratación horaria mercado diario (HMT)";
            this.tsmi_HMT.Click += new System.EventHandler(this.OpenForm_HMT);
            // 
            // tss_download1
            // 
            this.tss_download1.Name = "tss_download1";
            this.tss_download1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_esios
            // 
            this.tsmi_esios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_c2l});
            this.tsmi_esios.Name = "tsmi_esios";
            this.tsmi_esios.Size = new System.Drawing.Size(180, 22);
            this.tsmi_esios.Text = "ESIOS";
            // 
            // tsmi_c2l
            // 
            this.tsmi_c2l.Name = "tsmi_c2l";
            this.tsmi_c2l.Size = new System.Drawing.Size(186, 22);
            this.tsmi_c2l.Text = "C2 Liquicomun (C2L)";
            this.tsmi_c2l.Click += new System.EventHandler(this.OpenForm_C2L);
            // 
            // tss_download2
            // 
            this.tss_download2.Name = "tss_download2";
            this.tss_download2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_downloadFolder
            // 
            this.tsmi_downloadFolder.Name = "tsmi_downloadFolder";
            this.tsmi_downloadFolder.Size = new System.Drawing.Size(180, 22);
            this.tsmi_downloadFolder.Text = "Ver descargas";
            this.tsmi_downloadFolder.Click += new System.EventHandler(this.DownloadDir);
            // 
            // tsmi_clear
            // 
            this.tsmi_clear.Name = "tsmi_clear";
            this.tsmi_clear.Size = new System.Drawing.Size(180, 22);
            this.tsmi_clear.Text = "Limpiar descargas";
            this.tsmi_clear.ToolTipText = "Elimina todos los archivos descargados ubicados en la carpeta de descargas por de" +
    "fecto";
            this.tsmi_clear.Click += new System.EventHandler(this.ClearDownloads);
            // 
            // tsmi_folder
            // 
            this.tsmi_folder.AutoSize = false;
            this.tsmi_folder.BackgroundImage = global::OTOI_ADD.Properties.Resources.button_light;
            this.tsmi_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsmi_folder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_openDir,
            this.tsmi_log,
            this.tss_utility,
            this.tsmi_old});
            this.tsmi_folder.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.tsmi_folder.Name = "tsmi_folder";
            this.tsmi_folder.Size = new System.Drawing.Size(70, 26);
            this.tsmi_folder.Text = "Carpetas";
            this.tsmi_folder.DropDownClosed += new System.EventHandler(this.DropDownClosed);
            this.tsmi_folder.DropDownOpened += new System.EventHandler(this.DropDownOpened);
            // 
            // tsmi_openDir
            // 
            this.tsmi_openDir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_installDir,
            this.tsmi_configDir,
            this.tsmi_downloadDir,
            this.tsmi_logsDir});
            this.tsmi_openDir.Name = "tsmi_openDir";
            this.tsmi_openDir.Size = new System.Drawing.Size(180, 22);
            this.tsmi_openDir.Text = "Abrir directorio";
            // 
            // tsmi_installDir
            // 
            this.tsmi_installDir.Name = "tsmi_installDir";
            this.tsmi_installDir.Size = new System.Drawing.Size(180, 22);
            this.tsmi_installDir.Text = "Instalación";
            this.tsmi_installDir.Click += new System.EventHandler(this.InstallDir);
            // 
            // tsmi_configDir
            // 
            this.tsmi_configDir.Name = "tsmi_configDir";
            this.tsmi_configDir.Size = new System.Drawing.Size(180, 22);
            this.tsmi_configDir.Text = "Configuraciones";
            this.tsmi_configDir.Click += new System.EventHandler(this.ConfigDir);
            // 
            // tsmi_downloadDir
            // 
            this.tsmi_downloadDir.Name = "tsmi_downloadDir";
            this.tsmi_downloadDir.Size = new System.Drawing.Size(180, 22);
            this.tsmi_downloadDir.Text = "Descargas";
            this.tsmi_downloadDir.Click += new System.EventHandler(this.DownloadDir);
            // 
            // tsmi_logsDir
            // 
            this.tsmi_logsDir.Name = "tsmi_logsDir";
            this.tsmi_logsDir.Size = new System.Drawing.Size(180, 22);
            this.tsmi_logsDir.Text = "Logs";
            this.tsmi_logsDir.Click += new System.EventHandler(this.LogsDir);
            // 
            // tsmi_log
            // 
            this.tsmi_log.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_logSend,
            this.toolStripSeparator3});
            this.tsmi_log.Name = "tsmi_log";
            this.tsmi_log.Size = new System.Drawing.Size(180, 22);
            this.tsmi_log.Text = "Logs";
            // 
            // tsmi_logSend
            // 
            this.tsmi_logSend.Enabled = false;
            this.tsmi_logSend.Name = "tsmi_logSend";
            this.tsmi_logSend.Size = new System.Drawing.Size(131, 22);
            this.tsmi_logSend.Text = "Enviar logs";
            this.tsmi_logSend.Click += new System.EventHandler(this.SendLogs);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(128, 6);
            // 
            // tss_utility
            // 
            this.tss_utility.BackColor = System.Drawing.SystemColors.Control;
            this.tss_utility.Name = "tss_utility";
            this.tss_utility.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_old
            // 
            this.tsmi_old.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_HPC,
            this.tsmi_HM});
            this.tsmi_old.Name = "tsmi_old";
            this.tsmi_old.Size = new System.Drawing.Size(180, 22);
            this.tsmi_old.Text = "Antiguos";
            // 
            // tsmi_help
            // 
            this.tsmi_help.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmi_help.AutoSize = false;
            this.tsmi_help.BackgroundImage = global::OTOI_ADD.Properties.Resources.button_light;
            this.tsmi_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsmi_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_doc,
            this.tss_help_1,
            this.tsmi_about,
            this.tss_help_2,
            this.tsmi_test});
            this.tsmi_help.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.tsmi_help.Name = "tsmi_help";
            this.tsmi_help.Size = new System.Drawing.Size(70, 26);
            this.tsmi_help.Text = "Ayuda";
            this.tsmi_help.DropDownClosed += new System.EventHandler(this.DropDownClosed);
            this.tsmi_help.DropDownOpened += new System.EventHandler(this.DropDownOpened);
            // 
            // tsmi_doc
            // 
            this.tsmi_doc.Name = "tsmi_doc";
            this.tsmi_doc.Size = new System.Drawing.Size(180, 22);
            this.tsmi_doc.Text = "Documentación";
            this.tsmi_doc.Click += new System.EventHandler(this.Documentation);
            // 
            // tss_help_2
            // 
            this.tss_help_2.Name = "tss_help_2";
            this.tss_help_2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_about
            // 
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.Size = new System.Drawing.Size(180, 22);
            this.tsmi_about.Text = "Acerca de";
            this.tsmi_about.Click += new System.EventHandler(this.About);
            // 
            // tsmi_HPC
            // 
            this.tsmi_HPC.Name = "tsmi_HPC";
            this.tsmi_HPC.Size = new System.Drawing.Size(317, 22);
            this.tsmi_HPC.Text = "Mecanismo de ajuste Precio horario dia (HPC)";
            this.tsmi_HPC.ToolTipText = "Hourly Price Consumers\r\nPrecio definitivo horario del mecanismo de ajuste a los c" +
    "onsumidores en el mercado.";
            this.tsmi_HPC.Click += new System.EventHandler(this.OpenForm_HPC);
            // 
            // tsmi_HM
            // 
            this.tsmi_HM.Name = "tsmi_HM";
            this.tsmi_HM.Size = new System.Drawing.Size(317, 22);
            this.tsmi_HM.Text = "Precio energía horario mensual (HM)";
            this.tsmi_HM.ToolTipText = "Hourly Market\r\nContratación horaria mercado diario.\r\n";
            this.tsmi_HM.Click += new System.EventHandler(this.OpenForm_HM);
            // 
            // tsmi_test
            // 
            this.tsmi_test.Name = "tsmi_test";
            this.tsmi_test.Size = new System.Drawing.Size(180, 22);
            this.tsmi_test.Text = "Test";
            this.tsmi_test.Click += new System.EventHandler(this.TEST);
            // 
            // tss_help_1
            // 
            this.tss_help_1.Name = "tss_help_1";
            this.tss_help_1.Size = new System.Drawing.Size(177, 6);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(499, 360);
            this.Controls.Add(this.ms_menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTOI - Asistente de Descarga de Datos";
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip ms_menu;
        private ToolStripMenuItem tsmi_menu;
        private ToolStripMenuItem tsmi_downloads;
        private ToolStripMenuItem tsmi_omie;
        private ToolStripMenuItem tsmi_exit;
        private ToolStripMenuItem tsmi_HPCM;
        private ToolTip tt_menu;
        private ToolStripMenuItem tsmi_HMM;
        private ToolStripMenuItem tsmi_esios;
        private ToolStripMenuItem tsmi_c2l;
        private ToolStripMenuItem tsmi_folder;
        private ToolStripMenuItem tsmi_log;
        private ToolStripMenuItem tsmi_HMT;
        private ToolStripMenuItem tsmi_old;
        private ToolStripSeparator2 toolStripSeparator3;
        private ToolStripMenuItem tsmi_logSend;
        private ToolStripMenuItem tsmi_help;
        private ToolStripMenuItem tsmi_doc;
        private ToolStripMenuItem tsmi_about;
        private ToolStripMenuItem tsmi_openDir;
        private ToolStripMenuItem tsmi_installDir;
        private ToolStripMenuItem tsmi_configDir;
        private ToolStripMenuItem tsmi_downloadDir;
        private ToolStripMenuItem tsmi_logsDir;
        private ToolStripMenuItem tsmi_downloadFolder;
        private ToolStripMenuItem tsmi_config;
        internal ToolStripSeparator2 tss_utility;
        internal ToolStripSeparator2 tss_file;
        internal ToolStripSeparator2 tss_download1;
        internal ToolStripSeparator2 tss_help_2;
        internal ToolStripSeparator2 tss_download2;
        private ToolStripMenuItem tsmi_clear;
        private ToolStripMenuItem tsmi_HPC;
        private ToolStripMenuItem tsmi_HM;
        internal ToolStripSeparator2 tss_help_1;
        private ToolStripMenuItem tsmi_test;
    }
}
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
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_downloads = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_omie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HPCM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HMM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HMT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_esios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_c2l = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_utility = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_folder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_log = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_logFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_logSend = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_old = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HPC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_test = new System.Windows.Forms.ToolStripMenuItem();
            this.tt_menu = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_documentation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_downloads,
            this.tsmi_utility,
            this.tsmi_help});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(784, 24);
            this.ms_menu.TabIndex = 22;
            this.ms_menu.Text = "menuStrip1";
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tsmi_exit});
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(60, 20);
            this.tsmi_file.Text = "Archivo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(180, 22);
            this.tsmi_exit.Text = "Salir";
            this.tsmi_exit.Click += new System.EventHandler(this.Tsmi_exit_Click);
            // 
            // tsmi_downloads
            // 
            this.tsmi_downloads.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_omie,
            this.toolStripSeparator4,
            this.tsmi_esios});
            this.tsmi_downloads.Name = "tsmi_downloads";
            this.tsmi_downloads.Size = new System.Drawing.Size(72, 20);
            this.tsmi_downloads.Text = "Descargas";
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
            this.tsmi_HPCM.Click += new System.EventHandler(this.CL_openForm_HPCM);
            // 
            // tsmi_HMM
            // 
            this.tsmi_HMM.Name = "tsmi_HMM";
            this.tsmi_HMM.Size = new System.Drawing.Size(341, 22);
            this.tsmi_HMM.Text = "Contratación horaria mercado diario (HMM)";
            this.tsmi_HMM.ToolTipText = "Precio energía horario mensual";
            this.tsmi_HMM.Click += new System.EventHandler(this.CL_openForm_HMM);
            // 
            // tsmi_HMT
            // 
            this.tsmi_HMT.Name = "tsmi_HMT";
            this.tsmi_HMT.Size = new System.Drawing.Size(341, 22);
            this.tsmi_HMT.Text = "Tabla - Contratación horaria mercado diario (HMT)";
            this.tsmi_HMT.Click += new System.EventHandler(this.CL_openForm_HMT);
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
            this.tsmi_c2l.Size = new System.Drawing.Size(155, 22);
            this.tsmi_c2l.Text = "C2 Liquicomun";
            this.tsmi_c2l.Click += new System.EventHandler(this.CL_openForm_C2L);
            // 
            // tsmi_utility
            // 
            this.tsmi_utility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_folder,
            this.tsmi_log,
            this.toolStripSeparator1,
            this.tsmi_old,
            this.tsmi_test});
            this.tsmi_utility.Name = "tsmi_utility";
            this.tsmi_utility.Size = new System.Drawing.Size(71, 20);
            this.tsmi_utility.Text = "Utilidades";
            // 
            // tsmi_folder
            // 
            this.tsmi_folder.Name = "tsmi_folder";
            this.tsmi_folder.Size = new System.Drawing.Size(216, 22);
            this.tsmi_folder.Text = "Abrir carpeta del programa";
            this.tsmi_folder.Click += new System.EventHandler(this.OpenAppFolder);
            // 
            // tsmi_log
            // 
            this.tsmi_log.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_logFolder,
            this.toolStripSeparator3,
            this.tsmi_logSend});
            this.tsmi_log.Name = "tsmi_log";
            this.tsmi_log.Size = new System.Drawing.Size(216, 22);
            this.tsmi_log.Text = "Logs";
            // 
            // tsmi_logFolder
            // 
            this.tsmi_logFolder.Name = "tsmi_logFolder";
            this.tsmi_logFolder.Size = new System.Drawing.Size(183, 22);
            this.tsmi_logFolder.Text = "Abrir carpeta de logs";
            this.tsmi_logFolder.Click += new System.EventHandler(this.OpenLogFolder);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // tsmi_logSend
            // 
            this.tsmi_logSend.Name = "tsmi_logSend";
            this.tsmi_logSend.Size = new System.Drawing.Size(183, 22);
            this.tsmi_logSend.Text = "Enviar logs";
            this.tsmi_logSend.Click += new System.EventHandler(this.SendLogs);
            // 
            // tsmi_HMT
            // 
            this.tsmi_HMT.Name = "tsmi_HMT";
            this.tsmi_HMT.Size = new System.Drawing.Size(375, 22);
            this.tsmi_HMT.Text = "Contratación horaria mercado diario - Tabla";
            this.tsmi_HMT.Click += new System.EventHandler(this.CL_openForm_HMT);
            // 
            // tsmi_old
            // 
            this.tsmi_old.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_HPC,
            this.tsmi_HM});
            this.tsmi_old.Name = "tsmi_old";
            this.tsmi_old.Size = new System.Drawing.Size(67, 20);
            this.tsmi_old.Text = "Antiguos";
            // 
            // tsmi_HPC
            // 
            this.tsmi_HPC.Name = "tsmi_HPC";
            this.tsmi_HPC.Size = new System.Drawing.Size(317, 22);
            this.tsmi_HPC.Text = "Mecanismo de ajuste Precio horario dia (HPC)";
            this.tsmi_HPC.ToolTipText = "Hourly Price Consumers\r\nPrecio definitivo horario del mecanismo de ajuste a los c" +
    "onsumidores en el mercado.";
            // 
            // tsmi_HM
            // 
            this.tsmi_HM.Name = "tsmi_HM";
            this.tsmi_HM.Size = new System.Drawing.Size(317, 22);
            this.tsmi_HM.Text = "Precio energía horario mensual (HM)";
            this.tsmi_HM.ToolTipText = "Hourly Market\r\nContratación horaria mercado diario.\r\n";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.PerformLayout();

        }

        #endregion

        private MenuStrip ms_menu;
        private ToolStripMenuItem tsmi_file;
        private ToolStripMenuItem tsmi_downloads;
        private ToolStripMenuItem tsmi_omie;
        private ToolStripMenuItem tsmi_exit;
        private ToolStripMenuItem tsmi_HPCM;
        private ToolTip tt_menu;
        private ToolStripMenuItem tsmi_HMM;
        private ToolStripMenuItem tsmi_esios;
        private ToolStripMenuItem tsmi_c2l;
        private ToolStripMenuItem tsmi_utility;
        private ToolStripMenuItem tsmi_folder;
        private ToolStripMenuItem tsmi_log;
        private ToolStripMenuItem tsmi_HMT;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmi_old;
        private ToolStripMenuItem tsmi_HPC;
        private ToolStripMenuItem tsmi_HM;
        private ToolStripMenuItem tsmi_test;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsmi_logFolder;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem tsmi_logSend;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem tsmi_help;
        private ToolStripMenuItem tsmi_documentation;
        private ToolStripMenuItem tsmi_about;
    }
}
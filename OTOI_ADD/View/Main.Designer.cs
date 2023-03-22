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
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_downloads = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_omie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HPC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HPCM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HMM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_esios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_c2_liquicomun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_version = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_info = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_update = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.process2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tt_menu = new System.Windows.Forms.ToolTip(this.components);
            this.pruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_downloads,
            this.tsmi_version,
            this.testToolStripMenuItem});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(784, 24);
            this.ms_menu.TabIndex = 22;
            this.ms_menu.Text = "menuStrip1";
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_exit});
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(60, 20);
            this.tsmi_file.Text = "Archivo";
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(96, 22);
            this.tsmi_exit.Text = "Salir";
            this.tsmi_exit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // tsmi_downloads
            // 
            this.tsmi_downloads.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_omie,
            this.tsmi_esios});
            this.tsmi_downloads.Name = "tsmi_downloads";
            this.tsmi_downloads.Size = new System.Drawing.Size(72, 20);
            this.tsmi_downloads.Text = "Descargas";
            // 
            // tsmi_omie
            // 
            this.tsmi_omie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_HPC,
            this.tsmi_HPCM,
            this.tsmi_HM,
            this.tsmi_HMM});
            this.tsmi_omie.Name = "tsmi_omie";
            this.tsmi_omie.Size = new System.Drawing.Size(104, 22);
            this.tsmi_omie.Text = "OMIE";
            // 
            // tsmi_HPC
            // 
            this.tsmi_HPC.Name = "tsmi_HPC";
            this.tsmi_HPC.Size = new System.Drawing.Size(375, 22);
            this.tsmi_HPC.Text = "Mecanismo de ajuste Precio horario dia (HPC)";
            this.tsmi_HPC.ToolTipText = "Hourly Price Consumers\r\nPrecio definitivo horario del mecanismo de ajuste a los c" +
    "onsumidores en el mercado.";
            this.tsmi_HPC.Click += new System.EventHandler(this.CL_openForm_HPC);
            // 
            // tsmi_HPCM
            // 
            this.tsmi_HPCM.Name = "tsmi_HPCM";
            this.tsmi_HPCM.Size = new System.Drawing.Size(375, 22);
            this.tsmi_HPCM.Text = "Mecanismo de ajuste Precio horario dia múltiple (HPCM)";
            this.tsmi_HPCM.ToolTipText = "Multiple Hourly Price Consumers\r\nPrecio definitivo horario del mecanismo de ajust" +
    "e a los consumidores en el mercado.\r\nPermite la descarga de datos de múltiples d" +
    "ías.\r\n";
            this.tsmi_HPCM.Click += new System.EventHandler(this.CL_openForm_HPCM);
            // 
            // tsmi_HM
            // 
            this.tsmi_HM.Name = "tsmi_HM";
            this.tsmi_HM.Size = new System.Drawing.Size(375, 22);
            this.tsmi_HM.Text = "Precio energía horario mensual (HM)";
            this.tsmi_HM.ToolTipText = "Hourly Market\r\nContratación horaria mercado diario.\r\n";
            this.tsmi_HM.Click += new System.EventHandler(this.CL_openForm_HM);
            // 
            // tsmi_HMM
            // 
            this.tsmi_HMM.Name = "tsmi_HMM";
            this.tsmi_HMM.Size = new System.Drawing.Size(375, 22);
            this.tsmi_HMM.Text = "Precio energía horario mensual múltiple (HMM)";
            this.tsmi_HMM.Click += new System.EventHandler(this.CL_openForm_HMM);
            // 
            // tsmi_esios
            // 
            this.tsmi_esios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_c2_liquicomun});
            this.tsmi_esios.Name = "tsmi_esios";
            this.tsmi_esios.Size = new System.Drawing.Size(104, 22);
            this.tsmi_esios.Text = "ESIOS";
            // 
            // tsmi_c2_liquicomun
            // 
            this.tsmi_c2_liquicomun.Name = "tsmi_c2_liquicomun";
            this.tsmi_c2_liquicomun.Size = new System.Drawing.Size(155, 22);
            this.tsmi_c2_liquicomun.Text = "C2 Liquicomun";
            this.tsmi_c2_liquicomun.Click += new System.EventHandler(this.CL_openForm_C2L);
            // 
            // tsmi_version
            // 
            this.tsmi_version.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_info,
            this.tsmi_update,
            this.pruebaToolStripMenuItem});
            this.tsmi_version.Name = "tsmi_version";
            this.tsmi_version.Size = new System.Drawing.Size(57, 20);
            this.tsmi_version.Text = "Versión";
            // 
            // tsmi_info
            // 
            this.tsmi_info.Name = "tsmi_info";
            this.tsmi_info.Size = new System.Drawing.Size(180, 22);
            this.tsmi_info.Text = "Información";
            this.tsmi_info.Click += new System.EventHandler(this.Tsmi_info_Click);
            // 
            // tsmi_update
            // 
            this.tsmi_update.Name = "tsmi_update";
            this.tsmi_update.Size = new System.Drawing.Size(180, 22);
            this.tsmi_update.Text = "Actualizar";
            this.tsmi_update.Click += new System.EventHandler(this.Tsmi_update_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processToolStripMenuItem,
            this.process2ToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.processToolStripMenuItem.Text = "Process";
            this.processToolStripMenuItem.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // process2ToolStripMenuItem
            // 
            this.process2ToolStripMenuItem.Name = "process2ToolStripMenuItem";
            this.process2ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.process2ToolStripMenuItem.Text = "Process 2";
            this.process2ToolStripMenuItem.Click += new System.EventHandler(this.process2ToolStripMenuItem_Click);
            // 
            // pruebaToolStripMenuItem
            // 
            this.pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            this.pruebaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pruebaToolStripMenuItem.Text = "Prueba";
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
        private ToolStripMenuItem tsmi_HPC;
        private ToolStripMenuItem tsmi_HM;
        private ToolStripMenuItem tsmi_HPCM;
        private ToolTip tt_menu;
        private ToolStripMenuItem tsmi_HMM;
        private ToolStripMenuItem tsmi_esios;
        private ToolStripMenuItem tsmi_c2_liquicomun;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem processToolStripMenuItem;
        private ToolStripMenuItem process2ToolStripMenuItem;
        private ToolStripMenuItem tsmi_version;
        private ToolStripMenuItem tsmi_info;
        private ToolStripMenuItem tsmi_update;
        private ToolStripMenuItem pruebaToolStripMenuItem;
    }
}
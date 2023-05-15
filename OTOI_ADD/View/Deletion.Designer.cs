namespace OTOI_ADD.View
{
    partial class Deletion
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
            this.lb_section1 = new OTOI_ADD.View.Asset.Label2();
            this.lb_files = new OTOI_ADD.View.Asset.Label2();
            this.bt_files = new System.Windows.Forms.Button();
            this.lb_logs = new OTOI_ADD.View.Asset.Label2();
            this.bt_logs = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.gb_choice = new System.Windows.Forms.GroupBox();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.rb_old = new System.Windows.Forms.RadioButton();
            this.gb_choice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_section1
            // 
            this.lb_section1.BackColor = System.Drawing.Color.White;
            this.lb_section1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_section1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_section1.Location = new System.Drawing.Point(4, 7);
            this.lb_section1.Name = "lb_section1";
            this.lb_section1.Size = new System.Drawing.Size(305, 24);
            this.lb_section1.TabIndex = 186;
            this.lb_section1.Text = "Archivos a eliminar";
            this.lb_section1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_files
            // 
            this.lb_files.BackColor = System.Drawing.Color.White;
            this.lb_files.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_files.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_files.Location = new System.Drawing.Point(119, 116);
            this.lb_files.Name = "lb_files";
            this.lb_files.Size = new System.Drawing.Size(190, 23);
            this.lb_files.TabIndex = 193;
            this.lb_files.Text = "[peso y num archivos]";
            this.lb_files.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_files
            // 
            this.bt_files.Location = new System.Drawing.Point(4, 116);
            this.bt_files.Name = "bt_files";
            this.bt_files.Size = new System.Drawing.Size(109, 23);
            this.bt_files.TabIndex = 192;
            this.bt_files.Text = "Descargas";
            this.bt_files.UseVisualStyleBackColor = true;
            this.bt_files.Click += new System.EventHandler(this.DeleteFiles);
            // 
            // lb_logs
            // 
            this.lb_logs.BackColor = System.Drawing.Color.White;
            this.lb_logs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_logs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_logs.Location = new System.Drawing.Point(119, 87);
            this.lb_logs.Name = "lb_logs";
            this.lb_logs.Size = new System.Drawing.Size(190, 23);
            this.lb_logs.TabIndex = 191;
            this.lb_logs.Text = "[peso y num archivos]";
            this.lb_logs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_logs
            // 
            this.bt_logs.Location = new System.Drawing.Point(4, 87);
            this.bt_logs.Name = "bt_logs";
            this.bt_logs.Size = new System.Drawing.Size(109, 23);
            this.bt_logs.TabIndex = 190;
            this.bt_logs.Text = "Logs";
            this.bt_logs.UseVisualStyleBackColor = true;
            this.bt_logs.Click += new System.EventHandler(this.DeleteLogs);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(119, 151);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 194;
            this.bt_close.Text = "Cerrar";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.Close);
            // 
            // gb_choice
            // 
            this.gb_choice.Controls.Add(this.rb_all);
            this.gb_choice.Controls.Add(this.rb_old);
            this.gb_choice.Location = new System.Drawing.Point(4, 34);
            this.gb_choice.Name = "gb_choice";
            this.gb_choice.Size = new System.Drawing.Size(305, 40);
            this.gb_choice.TabIndex = 195;
            this.gb_choice.TabStop = false;
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Location = new System.Drawing.Point(152, 15);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(121, 19);
            this.rb_all.TabIndex = 1;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "Todos los archivos";
            this.rb_all.UseVisualStyleBackColor = true;
            this.rb_all.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // rb_old
            // 
            this.rb_old.AutoSize = true;
            this.rb_old.Location = new System.Drawing.Point(26, 15);
            this.rb_old.Name = "rb_old";
            this.rb_old.Size = new System.Drawing.Size(120, 19);
            this.rb_old.TabIndex = 0;
            this.rb_old.TabStop = true;
            this.rb_old.Text = "Archivos antiguos";
            this.rb_old.UseVisualStyleBackColor = true;
            this.rb_old.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // Deletion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 185);
            this.Controls.Add(this.gb_choice);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.lb_files);
            this.Controls.Add(this.bt_files);
            this.Controls.Add(this.lb_logs);
            this.Controls.Add(this.bt_logs);
            this.Controls.Add(this.lb_section1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Deletion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar archivos";
            this.gb_choice.ResumeLayout(false);
            this.gb_choice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Asset.Label2 lb_section1;
        internal Asset.Label2 lb_files;
        internal Button bt_files;
        internal Asset.Label2 lb_logs;
        internal Button bt_logs;
        private GroupBox gb_choice;
        private RadioButton rb_all;
        private RadioButton rb_old;
        internal Button bt_close;
    }
}
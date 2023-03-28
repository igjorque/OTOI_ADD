namespace OTOI_ADD.View
{
    partial class Test
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
            this.mp_selector = new OTOI_ADD.View.Asset.Control.MonthPicker();
            this.lb_selected = new System.Windows.Forms.Label();
            this.lb_dir1 = new System.Windows.Forms.Label();
            this.lb_dir2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_dir = new System.Windows.Forms.Button();
            this.monthPicker1 = new OTOI_ADD.View.Asset.Control.MonthPicker();
            this.SuspendLayout();
            // 
            // mp_selector
            // 
            this.mp_selector.CustomFormat = "MMMM yyyy";
            this.mp_selector.Location = new System.Drawing.Point(16, 24);
            this.mp_selector.Name = "mp_selector";
            this.mp_selector.Size = new System.Drawing.Size(200, 23);
            this.mp_selector.TabIndex = 0;
            this.mp_selector.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.mp_selector.ValueChanged += new System.EventHandler(this.Validate);
            // 
            // lb_selected
            // 
            this.lb_selected.AutoSize = true;
            this.lb_selected.Location = new System.Drawing.Point(224, 28);
            this.lb_selected.Name = "lb_selected";
            this.lb_selected.Size = new System.Drawing.Size(63, 15);
            this.lb_selected.TabIndex = 1;
            this.lb_selected.Text = "VERSION 4";
            // 
            // lb_dir1
            // 
            this.lb_dir1.AutoSize = true;
            this.lb_dir1.Location = new System.Drawing.Point(16, 104);
            this.lb_dir1.Name = "lb_dir1";
            this.lb_dir1.Size = new System.Drawing.Size(38, 15);
            this.lb_dir1.TabIndex = 2;
            this.lb_dir1.Text = "label1";
            // 
            // lb_dir2
            // 
            this.lb_dir2.AutoSize = true;
            this.lb_dir2.Location = new System.Drawing.Point(16, 160);
            this.lb_dir2.Name = "lb_dir2";
            this.lb_dir2.Size = new System.Drawing.Size(38, 15);
            this.lb_dir2.TabIndex = 3;
            this.lb_dir2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Environment.CurrentDirectory;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Directory.GetParent(workingDirectory).Parent.Parent.FullName;";
            // 
            // bt_dir
            // 
            this.bt_dir.Location = new System.Drawing.Point(192, 72);
            this.bt_dir.Name = "bt_dir";
            this.bt_dir.Size = new System.Drawing.Size(75, 23);
            this.bt_dir.TabIndex = 6;
            this.bt_dir.Text = "ABRIR";
            this.bt_dir.UseVisualStyleBackColor = true;
            this.bt_dir.Click += new System.EventHandler(this.bt_dir_Click);
            // 
            // monthPicker1
            // 
            this.monthPicker1.CustomFormat = "MMMM yyyy";
            this.monthPicker1.Location = new System.Drawing.Point(16, 48);
            this.monthPicker1.Name = "monthPicker1";
            this.monthPicker1.Size = new System.Drawing.Size(200, 23);
            this.monthPicker1.TabIndex = 7;
            this.monthPicker1.ValueChanged += new System.EventHandler(this.Validate);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(367, 239);
            this.Controls.Add(this.monthPicker1);
            this.Controls.Add(this.bt_dir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_dir2);
            this.Controls.Add(this.lb_dir1);
            this.Controls.Add(this.lb_selected);
            this.Controls.Add(this.mp_selector);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Test";
            this.Opacity = 0.4D;
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lb_selected;
        private Label lb_dir1;
        private Label lb_dir2;
        private Label label1;
        private Label label2;
        private Button bt_dir;
        internal Asset.Control.MonthPicker monthPicker1;
        internal Asset.Control.MonthPicker mp_selector;
    }
}
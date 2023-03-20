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
            this.SuspendLayout();
            // 
            // mp_selector
            // 
            this.mp_selector.CustomFormat = "MMMM yyyy";
            this.mp_selector.Location = new System.Drawing.Point(72, 80);
            this.mp_selector.Name = "mp_selector";
            this.mp_selector.Size = new System.Drawing.Size(200, 23);
            this.mp_selector.TabIndex = 0;
            this.mp_selector.ValueChanged += new System.EventHandler(this.Validate);
            // 
            // lb_selected
            // 
            this.lb_selected.AutoSize = true;
            this.lb_selected.Location = new System.Drawing.Point(72, 136);
            this.lb_selected.Name = "lb_selected";
            this.lb_selected.Size = new System.Drawing.Size(63, 15);
            this.lb_selected.TabIndex = 1;
            this.lb_selected.Text = "VERSION 2";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 239);
            this.Controls.Add(this.lb_selected);
            this.Controls.Add(this.mp_selector);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Asset.Control.MonthPicker mp_selector;
        private Label lb_selected;
    }
}
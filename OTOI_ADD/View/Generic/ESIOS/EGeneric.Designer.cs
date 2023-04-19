namespace OTOI_ADD.View.Generic.ESIOS
{
    partial class EGeneric
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
            this.cb_unzip = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_unzip
            // 
            this.cb_unzip.AutoSize = true;
            this.cb_unzip.BackColor = System.Drawing.SystemColors.Control;
            this.cb_unzip.Checked = true;
            this.cb_unzip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_unzip.ForeColor = System.Drawing.Color.Black;
            this.cb_unzip.Location = new System.Drawing.Point(8, 112);
            this.cb_unzip.Name = "cb_unzip";
            this.cb_unzip.Size = new System.Drawing.Size(101, 19);
            this.cb_unzip.TabIndex = 1;
            this.cb_unzip.Text = "Descomprimir";
            this.cb_unzip.UseVisualStyleBackColor = false;
            // 
            // EGeneric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 314);
            this.Controls.Add(this.cb_unzip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EGeneric";
            this.Text = "ESIOS";
            this.Controls.SetChildIndex(this.cb_unzip, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox cb_unzip;
    }
}
namespace OTOI_ADD.View.Generic.OMIE
{
    partial class OGenericRange
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
            this.uc_range = new OTOI_ADD.View.Asset.Date_Range();
            this.SuspendLayout();
            // 
            // uc_range
            // 
            this.uc_range.BackColor = System.Drawing.SystemColors.Control;
            this.uc_range.Location = new System.Drawing.Point(0, 49);
            this.uc_range.Name = "uc_range";
            this.uc_range.Size = new System.Drawing.Size(314, 31);
            this.uc_range.TabIndex = 2;
            // 
            // GenericRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 229);
            this.Controls.Add(this.uc_range);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "GenericRange";
            this.Text = "GenericRange";
            this.Controls.SetChildIndex(this.uc_range, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Asset.Date_Range uc_range;
    }
}
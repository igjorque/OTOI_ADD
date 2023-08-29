namespace ADD_Frontend.View.Generic.OMIE
{
    partial class OGenericMonth
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
            this.uc_month = new ADD_Frontend.View.Asset.Date_Month();
            this.SuspendLayout();
            // 
            // uc_month
            // 
            this.uc_month.BackColor = System.Drawing.SystemColors.Control;
            this.uc_month.Location = new System.Drawing.Point(0, 49);
            this.uc_month.Name = "uc_month";
            this.uc_month.Size = new System.Drawing.Size(314, 31);
            this.uc_month.TabIndex = 2;
            // 
            // OGenericMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 229);
            this.Controls.Add(this.uc_month);
            this.Name = "OGenericMonth";
            this.Controls.SetChildIndex(this.uc_month, 0);
            this.ResumeLayout(false);

        }

        #endregion

        internal Asset.Date_Month uc_month;
    }
}
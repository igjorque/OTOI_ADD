namespace ADD_Frontend.View.Generic.OMIE
{
    partial class OGenericDay
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
            this.uc_day = new ADD_Frontend.View.Asset.Date_Day();
            this.SuspendLayout();
            // 
            // uc_day
            // 
            this.uc_day.BackColor = System.Drawing.SystemColors.Control;
            this.uc_day.Location = new System.Drawing.Point(0, 49);
            this.uc_day.Name = "uc_day";
            this.uc_day.Size = new System.Drawing.Size(314, 31);
            this.uc_day.TabIndex = 2;
            // 
            // OGenericDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 229);
            this.Controls.Add(this.uc_day);
            this.Name = "OGenericDay";
            this.Controls.SetChildIndex(this.uc_day, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Asset.Date_Day uc_day;
    }
}
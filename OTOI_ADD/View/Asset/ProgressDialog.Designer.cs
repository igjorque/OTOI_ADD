namespace OTOI_ADD.View.Asset
{
    partial class ProgressDialog
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
            this.pb_progress = new System.Windows.Forms.ProgressBar();
            this.lb_download = new System.Windows.Forms.Label();
            this.lb_url = new System.Windows.Forms.Label();
            this.bt_accept = new System.Windows.Forms.Button();
            this.lb_url_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pb_progress
            // 
            this.pb_progress.Location = new System.Drawing.Point(12, 52);
            this.pb_progress.Name = "pb_progress";
            this.pb_progress.Size = new System.Drawing.Size(220, 23);
            this.pb_progress.TabIndex = 0;
            // 
            // lb_download
            // 
            this.lb_download.Location = new System.Drawing.Point(12, 9);
            this.lb_download.Name = "lb_download";
            this.lb_download.Size = new System.Drawing.Size(220, 15);
            this.lb_download.TabIndex = 1;
            this.lb_download.Text = "Descarga en curso. Por favor espere.";
            // 
            // lb_url
            // 
            this.lb_url.AutoSize = true;
            this.lb_url.Location = new System.Drawing.Point(12, 34);
            this.lb_url.Name = "lb_url";
            this.lb_url.Size = new System.Drawing.Size(34, 15);
            this.lb_url.TabIndex = 2;
            this.lb_url.Text = "URL: ";
            // 
            // bt_accept
            // 
            this.bt_accept.Enabled = false;
            this.bt_accept.Location = new System.Drawing.Point(157, 81);
            this.bt_accept.Name = "bt_accept";
            this.bt_accept.Size = new System.Drawing.Size(75, 23);
            this.bt_accept.TabIndex = 3;
            this.bt_accept.Text = "Aceptar";
            this.bt_accept.UseVisualStyleBackColor = true;
            this.bt_accept.Visible = false;
            this.bt_accept.Click += new System.EventHandler(this.bt_accept_Click);
            // 
            // lb_url_value
            // 
            this.lb_url_value.Location = new System.Drawing.Point(52, 34);
            this.lb_url_value.Name = "lb_url_value";
            this.lb_url_value.Size = new System.Drawing.Size(180, 15);
            this.lb_url_value.TabIndex = 4;
            this.lb_url_value.Text = "[HERE -> CURR URL VALUE]\r\n";
            // 
            // ProgressDialog
            // 
            this.AcceptButton = this.bt_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 109);
            this.Controls.Add(this.lb_url_value);
            this.Controls.Add(this.bt_accept);
            this.Controls.Add(this.lb_url);
            this.Controls.Add(this.lb_download);
            this.Controls.Add(this.pb_progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProgressDialog";
            this.Text = "Descargando...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar pb_progress;
        private Label lb_download;
        private Label lb_url;
        private Button bt_accept;
        private Label lb_url_value;
    }
}
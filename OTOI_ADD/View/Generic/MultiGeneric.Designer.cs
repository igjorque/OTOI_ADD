﻿namespace OTOI_ADD.View.Generic
{
    partial class MultiGeneric
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
            this.lb_separator = new System.Windows.Forms.Label();
            this.ca_date_end = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lb_separator
            // 
            this.lb_separator.AutoSize = true;
            this.lb_separator.Location = new System.Drawing.Point(331, 218);
            this.lb_separator.Name = "lb_separator";
            this.lb_separator.Size = new System.Drawing.Size(12, 15);
            this.lb_separator.TabIndex = 109;
            this.lb_separator.Text = "-";
            // 
            // ca_date_end
            // 
            this.ca_date_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ca_date_end.Location = new System.Drawing.Point(349, 214);
            this.ca_date_end.Name = "ca_date_end";
            this.ca_date_end.Size = new System.Drawing.Size(120, 23);
            this.ca_date_end.TabIndex = 108;
            this.ca_date_end.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // MultiGeneric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_separator);
            this.Controls.Add(this.ca_date_end);
            this.Name = "MultiGeneric";
            this.Text = "MultiGeneric";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label lb_separator;
        internal DateTimePicker ca_date_end;
    }
}
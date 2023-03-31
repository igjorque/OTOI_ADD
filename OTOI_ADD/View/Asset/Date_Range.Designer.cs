namespace OTOI_ADD.View.Asset
{
    partial class Date_Range
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_date = new System.Windows.Forms.Label();
            this.ca_date_start = new System.Windows.Forms.DateTimePicker();
            this.lb_sep = new System.Windows.Forms.Label();
            this.ca_date_end = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(0, 8);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(29, 15);
            this.lb_date.TabIndex = 129;
            this.lb_date.Text = "Dias";
            // 
            // ca_date_start
            // 
            this.ca_date_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ca_date_start.Location = new System.Drawing.Point(34, 4);
            this.ca_date_start.Name = "ca_date_start";
            this.ca_date_start.Size = new System.Drawing.Size(120, 23);
            this.ca_date_start.TabIndex = 128;
            this.ca_date_start.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lb_sep
            // 
            this.lb_sep.AutoSize = true;
            this.lb_sep.Location = new System.Drawing.Point(156, 8);
            this.lb_sep.Name = "lb_sep";
            this.lb_sep.Size = new System.Drawing.Size(12, 15);
            this.lb_sep.TabIndex = 130;
            this.lb_sep.Text = "-";
            // 
            // ca_date_end
            // 
            this.ca_date_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ca_date_end.Location = new System.Drawing.Point(170, 4);
            this.ca_date_end.Name = "ca_date_end";
            this.ca_date_end.Size = new System.Drawing.Size(120, 23);
            this.ca_date_end.TabIndex = 131;
            this.ca_date_end.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // Date_Range
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ca_date_end);
            this.Controls.Add(this.lb_sep);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.ca_date_start);
            this.Name = "Date_Range";
            this.Size = new System.Drawing.Size(314, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label lb_date;
        internal DateTimePicker ca_date_start;
        internal Label lb_sep;
        internal DateTimePicker ca_date_end;
    }
}

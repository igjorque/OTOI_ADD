namespace ADD_Frontend.View.Asset
{
    partial class Date_Day
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
            this.ca_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(0, 8);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(24, 15);
            this.lb_date.TabIndex = 131;
            this.lb_date.Text = "Dia";
            // 
            // ca_date
            // 
            this.ca_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ca_date.Location = new System.Drawing.Point(34, 4);
            this.ca_date.Name = "ca_date";
            this.ca_date.Size = new System.Drawing.Size(120, 23);
            this.ca_date.TabIndex = 130;
            this.ca_date.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // Date_Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.ca_date);
            this.Name = "Date_Day";
            this.Size = new System.Drawing.Size(314, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label lb_date;
        internal DateTimePicker ca_date;
    }
}

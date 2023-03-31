namespace OTOI_ADD.View.Asset
{
    partial class Date_Month
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
            this.mp_month = new OTOI_ADD.View.Asset.Control.MonthPicker();
            this.lb_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mp_month
            // 
            this.mp_month.CustomFormat = "MMMM yyyy";
            this.mp_month.Location = new System.Drawing.Point(34, 4);
            this.mp_month.Name = "mp_month";
            this.mp_month.Size = new System.Drawing.Size(147, 23);
            this.mp_month.TabIndex = 0;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(0, 8);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(29, 15);
            this.lb_date.TabIndex = 1;
            this.lb_date.Text = "Mes";
            // 
            // Date_Month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.mp_month);
            this.Name = "Date_Month";
            this.Size = new System.Drawing.Size(314, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Control.MonthPicker mp_month;
        private Label lb_date;
    }
}

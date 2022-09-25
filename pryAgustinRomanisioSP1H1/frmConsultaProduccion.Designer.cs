namespace pryAgustinRomanisioSP1H1
{
    partial class frmConsultaProduccion
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
            this.dgvConsultaProduccion = new System.Windows.Forms.DataGridView();
            this.NombreLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCultivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarProduccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaProduccion
            // 
            this.dgvConsultaProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreLocalidad,
            this.Fecha,
            this.NombreCultivo,
            this.Cantidad});
            this.dgvConsultaProduccion.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaProduccion.Name = "dgvConsultaProduccion";
            this.dgvConsultaProduccion.Size = new System.Drawing.Size(449, 150);
            this.dgvConsultaProduccion.TabIndex = 0;
            // 
            // NombreLocalidad
            // 
            this.NombreLocalidad.HeaderText = "Nombre Localidad";
            this.NombreLocalidad.Name = "NombreLocalidad";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // NombreCultivo
            // 
            this.NombreCultivo.HeaderText = "Nombre Cultivo";
            this.NombreCultivo.Name = "NombreCultivo";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // btnConsultarProduccion
            // 
            this.btnConsultarProduccion.Location = new System.Drawing.Point(386, 177);
            this.btnConsultarProduccion.Name = "btnConsultarProduccion";
            this.btnConsultarProduccion.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarProduccion.TabIndex = 1;
            this.btnConsultarProduccion.Text = "Consultar";
            this.btnConsultarProduccion.UseVisualStyleBackColor = true;
            this.btnConsultarProduccion.Click += new System.EventHandler(this.btnConsultarProduccion_Click);
            // 
            // frmConsultaProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 223);
            this.Controls.Add(this.btnConsultarProduccion);
            this.Controls.Add(this.dgvConsultaProduccion);
            this.Name = "frmConsultaProduccion";
            this.Text = "Consulta Produccion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaProduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCultivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnConsultarProduccion;
    }
}
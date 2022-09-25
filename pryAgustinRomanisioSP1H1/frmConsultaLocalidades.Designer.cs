namespace pryAgustinRomanisioSP1H1
{
    partial class frmConsultaLocalidades
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
            this.dgvConsultaLocalidades = new System.Windows.Forms.DataGridView();
            this.idLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultaLocalidades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaLocalidades
            // 
            this.dgvConsultaLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaLocalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLocalidad,
            this.Nombre});
            this.dgvConsultaLocalidades.Location = new System.Drawing.Point(12, 22);
            this.dgvConsultaLocalidades.Name = "dgvConsultaLocalidades";
            this.dgvConsultaLocalidades.Size = new System.Drawing.Size(301, 150);
            this.dgvConsultaLocalidades.TabIndex = 0;
            // 
            // idLocalidad
            // 
            this.idLocalidad.HeaderText = "ID Localidad";
            this.idLocalidad.Name = "idLocalidad";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // btnConsultaLocalidades
            // 
            this.btnConsultaLocalidades.Location = new System.Drawing.Point(238, 193);
            this.btnConsultaLocalidades.Name = "btnConsultaLocalidades";
            this.btnConsultaLocalidades.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaLocalidades.TabIndex = 1;
            this.btnConsultaLocalidades.Text = "Consulta";
            this.btnConsultaLocalidades.UseVisualStyleBackColor = true;
            this.btnConsultaLocalidades.Click += new System.EventHandler(this.btnConsultaLocalidades_Click);
            // 
            // frmConsultaLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 254);
            this.Controls.Add(this.btnConsultaLocalidades);
            this.Controls.Add(this.dgvConsultaLocalidades);
            this.Name = "frmConsultaLocalidades";
            this.Text = "Consulta Localidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLocalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaLocalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnConsultaLocalidades;
    }
}
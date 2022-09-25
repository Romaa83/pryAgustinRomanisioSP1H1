namespace pryAgustinRomanisioSP1H1
{
    partial class frmConsultaCultivos
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
            this.dgvConsultaCultivos = new System.Windows.Forms.DataGridView();
            this.idCultivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecultivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCultivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaCultivos
            // 
            this.dgvConsultaCultivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCultivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCultivo,
            this.nombrecultivo});
            this.dgvConsultaCultivos.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaCultivos.Name = "dgvConsultaCultivos";
            this.dgvConsultaCultivos.Size = new System.Drawing.Size(244, 110);
            this.dgvConsultaCultivos.TabIndex = 0;
            // 
            // idCultivo
            // 
            this.idCultivo.HeaderText = "ID";
            this.idCultivo.Name = "idCultivo";
            // 
            // nombrecultivo
            // 
            this.nombrecultivo.HeaderText = "Nombre Cultivo";
            this.nombrecultivo.Name = "nombrecultivo";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(181, 137);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultaCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 196);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsultaCultivos);
            this.Name = "frmConsultaCultivos";
            this.Text = "frmConsultaCultivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCultivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaCultivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCultivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecultivo;
        private System.Windows.Forms.Button btnConsultar;
    }
}
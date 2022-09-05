namespace pryAgustinRomanisioSP1H1
{
    partial class frmCultivos
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNombreCultivos = new System.Windows.Forms.TextBox();
            this.txtIdentificadorCultivos = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificadorCultivos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(130, 138);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNombreCultivos
            // 
            this.txtNombreCultivos.Location = new System.Drawing.Point(105, 66);
            this.txtNombreCultivos.Name = "txtNombreCultivos";
            this.txtNombreCultivos.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCultivos.TabIndex = 8;
            // 
            // txtIdentificadorCultivos
            // 
            this.txtIdentificadorCultivos.Location = new System.Drawing.Point(105, 26);
            this.txtIdentificadorCultivos.Name = "txtIdentificadorCultivos";
            this.txtIdentificadorCultivos.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificadorCultivos.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIdentificadorCultivos
            // 
            this.lblIdentificadorCultivos.AutoSize = true;
            this.lblIdentificadorCultivos.Location = new System.Drawing.Point(26, 29);
            this.lblIdentificadorCultivos.Name = "lblIdentificadorCultivos";
            this.lblIdentificadorCultivos.Size = new System.Drawing.Size(65, 13);
            this.lblIdentificadorCultivos.TabIndex = 5;
            this.lblIdentificadorCultivos.Text = "Identificador";
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 201);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNombreCultivos);
            this.Controls.Add(this.txtIdentificadorCultivos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdentificadorCultivos);
            this.Name = "frmCultivos";
            this.Text = "Cultivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNombreCultivos;
        private System.Windows.Forms.TextBox txtIdentificadorCultivos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificadorCultivos;
    }
}
namespace pryAgustinRomanisioSP1H1
{
    partial class frmProduccion
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
            this.nudCantidadProduccion = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboNombreCultivo = new System.Windows.Forms.ComboBox();
            this.cboNombreLocalidad = new System.Windows.Forms.ComboBox();
            this.lblCantidadProduccion = new System.Windows.Forms.Label();
            this.lblNombreCultivoProduccion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.btnCargarProduccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCantidadProduccion
            // 
            this.nudCantidadProduccion.Location = new System.Drawing.Point(164, 148);
            this.nudCantidadProduccion.Name = "nudCantidadProduccion";
            this.nudCantidadProduccion.Size = new System.Drawing.Size(120, 20);
            this.nudCantidadProduccion.TabIndex = 15;
            this.nudCantidadProduccion.ValueChanged += new System.EventHandler(this.nudCantidadProduccion_ValueChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(164, 66);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 14;
            // 
            // cboNombreCultivo
            // 
            this.cboNombreCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreCultivo.FormattingEnabled = true;
            this.cboNombreCultivo.Location = new System.Drawing.Point(164, 104);
            this.cboNombreCultivo.Name = "cboNombreCultivo";
            this.cboNombreCultivo.Size = new System.Drawing.Size(121, 21);
            this.cboNombreCultivo.TabIndex = 13;
            // 
            // cboNombreLocalidad
            // 
            this.cboNombreLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreLocalidad.FormattingEnabled = true;
            this.cboNombreLocalidad.Location = new System.Drawing.Point(164, 21);
            this.cboNombreLocalidad.Name = "cboNombreLocalidad";
            this.cboNombreLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cboNombreLocalidad.TabIndex = 12;
            // 
            // lblCantidadProduccion
            // 
            this.lblCantidadProduccion.AutoSize = true;
            this.lblCantidadProduccion.Location = new System.Drawing.Point(20, 150);
            this.lblCantidadProduccion.Name = "lblCantidadProduccion";
            this.lblCantidadProduccion.Size = new System.Drawing.Size(52, 13);
            this.lblCantidadProduccion.TabIndex = 11;
            this.lblCantidadProduccion.Text = "Cantidad:";
            // 
            // lblNombreCultivoProduccion
            // 
            this.lblNombreCultivoProduccion.AutoSize = true;
            this.lblNombreCultivoProduccion.Location = new System.Drawing.Point(20, 107);
            this.lblNombreCultivoProduccion.Name = "lblNombreCultivoProduccion";
            this.lblNombreCultivoProduccion.Size = new System.Drawing.Size(97, 13);
            this.lblNombreCultivoProduccion.TabIndex = 10;
            this.lblNombreCultivoProduccion.Text = "Nombre de Cultivo:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(20, 66);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.Location = new System.Drawing.Point(20, 24);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(96, 13);
            this.lblNombreLocalidad.TabIndex = 8;
            this.lblNombreLocalidad.Text = "Nombre Localidad:";
            // 
            // btnCargarProduccion
            // 
            this.btnCargarProduccion.Location = new System.Drawing.Point(291, 183);
            this.btnCargarProduccion.Name = "btnCargarProduccion";
            this.btnCargarProduccion.Size = new System.Drawing.Size(75, 23);
            this.btnCargarProduccion.TabIndex = 16;
            this.btnCargarProduccion.Text = "Cargar";
            this.btnCargarProduccion.UseVisualStyleBackColor = true;
            this.btnCargarProduccion.Click += new System.EventHandler(this.btnCargarProduccion_Click);
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 218);
            this.Controls.Add(this.btnCargarProduccion);
            this.Controls.Add(this.nudCantidadProduccion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboNombreCultivo);
            this.Controls.Add(this.cboNombreLocalidad);
            this.Controls.Add(this.lblCantidadProduccion);
            this.Controls.Add(this.lblNombreCultivoProduccion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombreLocalidad);
            this.Name = "frmProduccion";
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCantidadProduccion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboNombreCultivo;
        private System.Windows.Forms.ComboBox cboNombreLocalidad;
        private System.Windows.Forms.Label lblCantidadProduccion;
        private System.Windows.Forms.Label lblNombreCultivoProduccion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.Button btnCargarProduccion;
    }
}
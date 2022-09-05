using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryAgustinRomanisioSP1H1
{
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader lectorLocalidad = new StreamReader("./localidades.txt");
            StreamReader lectorProduccion = new StreamReader("./cultivos.txt");
            char separador = Convert.ToChar(",");
            StreamWriter Produccion = new StreamWriter("./Produccion.txt");
            Produccion.Close();

            while (!lectorLocalidad.EndOfStream)
            {
                string [] informacionLocalidad = lectorLocalidad.ReadLine().Split(separador);
                cboNombreLocalidad.Items.Add(informacionLocalidad[1]);
            }
            while (!lectorProduccion.EndOfStream)
            {
                string [] informacionCultivos = lectorProduccion.ReadLine().Split(separador);
                cboNombreCultivo.Items.Add(informacionCultivos[1]);
            }


            lectorLocalidad.Close();
        }

        private void nudCantidadProduccion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarProduccion_Click(object sender, EventArgs e)
        {

            StreamWriter swProduccion = new StreamWriter("./Produccion.txt", true);
            swProduccion.WriteLine("Localidad: " + cboNombreLocalidad.Text + " " + "Cultivo: " +  cboNombreCultivo.Text + " " + "Cantidad: " + nudCantidadProduccion.Value);
            MessageBox.Show("Nice");
            swProduccion.Close();
        }
    }
}

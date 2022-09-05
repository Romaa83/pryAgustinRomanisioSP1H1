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
    public partial class frmLocalidades : Form
    {

        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int idLocalidad;
            string NombLocalidad, datos;
            bool bandera = false;

            idLocalidad = Convert.ToInt32(txtIDLocalidad.Text);
            NombLocalidad = txtNombreLocalidad.Text;

            TextWriter cultivo = new StreamWriter("./Localidades.txt", true);
            cultivo.Close();

            if (idLocalidad != 0 && NombLocalidad != "")
            {
                datos = idLocalidad + "," + NombLocalidad;
                char separador = Convert.ToChar(",");
                StreamReader srLocalidad = new StreamReader("./Localidades.txt");
                while (!srLocalidad.EndOfStream && bandera==false)
                {
                    string [] arrayLocalidades = srLocalidad.ReadLine().Split(separador);
                    int idLoca = Convert.ToInt32(arrayLocalidades[0]);
                    if (idLocalidad == idLoca)
                    {
                        bandera = true;
                        MessageBox.Show("Esta ID ya esta registrada");
                    }
                }
                srLocalidad.Close();
                using (StreamWriter swLocalidades = File.AppendText("./Localidades.txt"))
                {
                    if (bandera == false)
                    {
                        swLocalidades.WriteLine(datos);
                        MessageBox.Show("Datos Agregados con exito");
                    }
                }
            }

        }
    }
}

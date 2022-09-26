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
    public partial class frmConsultaProduccion : Form
    {
        string [,] matConsultaProduccion = new string[30,4];

        public frmConsultaProduccion()
        {
            InitializeComponent();
        }

        private void btnConsultarProduccion_Click(object sender, EventArgs e)
        {
            dgvConsultaProduccion.Rows.Clear();
            if (File.Exists("./Produccion.txt"))
            {
                StreamReader srConsultaProduccion = new StreamReader("./Produccion.txt");
                char separador = Convert.ToChar(",");
                int fm = 0;
                while (!srConsultaProduccion.EndOfStream)
                {
                    string[] arrayConsultaProduccion = srConsultaProduccion.ReadLine().Split(separador);
                    matConsultaProduccion[fm, 0] = arrayConsultaProduccion[0];
                    matConsultaProduccion[fm, 1] = arrayConsultaProduccion[1];
                    matConsultaProduccion[fm, 2] = arrayConsultaProduccion[2];
                    matConsultaProduccion[fm, 3] = arrayConsultaProduccion[3];
                    dgvConsultaProduccion.Rows.Add(matConsultaProduccion[fm, 0], matConsultaProduccion[fm, 1],
                        matConsultaProduccion[fm,2], matConsultaProduccion[fm,3]);
                    fm++;
                }

                srConsultaProduccion.Close();
            }
            else
            {
                MessageBox.Show("No existen esos datos, porfavor ingreselos");
            }
        }
    }
}

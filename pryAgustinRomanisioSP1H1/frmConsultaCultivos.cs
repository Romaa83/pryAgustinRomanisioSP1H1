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
    public partial class frmConsultaCultivos : Form
    {
        string[,] matConsultaCultivos = new string[24, 2];

        public frmConsultaCultivos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (File.Exists("./Cultivos.txt"))
            {
                dgvConsultaCultivos.Rows.Clear();
                StreamReader srConsultaProduccion = new StreamReader("./Cultivos.txt");
                char separador = Convert.ToChar(",");
                int fm = 0;
                while (!srConsultaProduccion.EndOfStream)
                {
                    string[] arrayConsultaProduccion = srConsultaProduccion.ReadLine().Split(separador);
                    matConsultaCultivos[fm, 0] = arrayConsultaProduccion[0];
                    matConsultaCultivos[fm, 1] = arrayConsultaProduccion[1];
                    dgvConsultaCultivos.Rows.Add(matConsultaCultivos[fm, 0], matConsultaCultivos[fm, 1]);
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

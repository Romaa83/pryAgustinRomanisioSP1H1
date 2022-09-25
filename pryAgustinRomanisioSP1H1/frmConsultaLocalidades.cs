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
    public partial class frmConsultaLocalidades : Form
    {
        string [,] matLocalidades = new string[24,2];

        public frmConsultaLocalidades()
        {
            InitializeComponent();
        }

        private void btnConsultaLocalidades_Click(object sender, EventArgs e)
        {
            if (File.Exists("./Localidades.txt"))
            {
                StreamReader srConsultaLocalidades = new StreamReader("./Localidades.txt");
                char separador = Convert.ToChar(",");
                int fm = 0;
                while (!srConsultaLocalidades.EndOfStream)
                {
                    string[] arrayConsultaLocalidades = srConsultaLocalidades.ReadLine().Split(separador);
                    matLocalidades[fm, 0] = arrayConsultaLocalidades[0];
                    matLocalidades[fm, 1] = arrayConsultaLocalidades[1];
                    dgvConsultaLocalidades.Rows.Clear();
                    dgvConsultaLocalidades.Rows.Add(matLocalidades[fm, 0], matLocalidades[fm, 1]);
                    fm++;
                }
                srConsultaLocalidades.Close();
            }
            else
            {
                MessageBox.Show("No exite esa carpeta, porfavor ingrese los datos");
            }

        }
    }
}

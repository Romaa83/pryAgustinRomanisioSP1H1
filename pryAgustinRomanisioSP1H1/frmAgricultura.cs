using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAgustinRomanisioSP1H1
{
    public partial class frmRomanisiosp : Form
    {
        public frmRomanisiosp()
        {
            InitializeComponent();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidades frmLocalidad = new frmLocalidades();
            frmLocalidad.ShowDialog();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos frmCult = new frmCultivos();
            frmCult.ShowDialog();
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion frmProdu = new frmProduccion();
            frmProdu.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void localidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaLocalidades frmConsultaLocalidades = new frmConsultaLocalidades();
            frmConsultaLocalidades.ShowDialog();
        }

        private void produccionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduccion frmConsultaProduccion = new frmConsultaProduccion();
            frmConsultaProduccion.ShowDialog();
        }

        private void cultivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCultivos frmConsultaCultivos = new frmConsultaCultivos();
            frmConsultaCultivos.ShowDialog();
        }
    }
}

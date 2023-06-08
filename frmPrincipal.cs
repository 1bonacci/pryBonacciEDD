using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBonacciEstructuraDeDatos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void datosDelProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola x = new frmCola();
            x.Show();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila x = new frmPila();
            x.Show();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple x = new frmListaSimple();
            x.Show();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble x = new frmListaDoble();
            x.Show();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbol x = new frmArbol();
            x.Show();
        }

        private void consultaTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaSQLtxt x = new frmConsultaSQLtxt();
            x.Show();
        }

        private void baseDeDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBaseDatos x = new frmBaseDatos();
            x.Show();
        }

        private void consultaCboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaSQLcbo x = new frmConsultaSQLcbo();
            x.Show();
        }
    }
}

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
    public partial class frmConsultaSQLtxt : Form
    {
        public frmConsultaSQLtxt()
        {
            InitializeComponent();
        }

        string varSQL = "";
        clsBaseDatos BaseDatos = new clsBaseDatos();

        private void btnListar_Click(object sender, EventArgs e)
        {
            varSQL = txtSQL.Text;
            BaseDatos.Listar(dgvSQL, varSQL);
        }
    }
}

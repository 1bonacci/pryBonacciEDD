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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila Lista = new clsPila();

        #region "Agregar / Eliminar"

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();

            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Lista.Agregar(objNodo);
            Lista.Recorrer(dgvLista, lstLista);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            txtCodigo.Focus();
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                txtCodigoE.Text = Lista.Primero.Codigo.ToString();
                txtNombreE.Text = Lista.Primero.Nombre;
                txtTramiteE.Text = Lista.Primero.Tramite;

                Lista.Eliminar();
                Lista.Recorrer(dgvLista, lstLista);
            }
            else
            {
                txtCodigoE.Text = "";
                txtNombreE.Text = "";
                txtTramiteE.Text = "";
            }
        }

        #endregion

        #region "Aceptar"
        
        public void TxtOn()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            TxtOn();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            TxtOn();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            TxtOn();
        }

        #endregion

        private void frmPila_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            txtCodigo.Focus();
            btnEliminar.Enabled = false;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

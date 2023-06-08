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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple Simple = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                clsNodo objNodo = new clsNodo();
                objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                objNodo.Nombre = txtNombre.Text;
                objNodo.Tramite = txtTramite.Text;

                //Procedimientos para mostrar
                Simple.Agregar(objNodo);
                Simple.Recorrer(dgvLista);
                Simple.Recorrer(lstLista);
                Simple.Recorrer(cmbCodigo);
                txtCodigo.Clear();
                txtNombre.Clear();
                txtTramite.Clear();

                txtCodigo.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Simple.Primero != null)
            {
                cmbCodigo.SelectedItem = Simple.Primero.Codigo.ToString();
                Simple.Eliminar(Convert.ToInt32(cmbCodigo.SelectedItem));
                Simple.Recorrer(dgvLista);
                Simple.Recorrer(lstLista);
                Simple.Recorrer(cmbCodigo);
                btnEliminar.Enabled = false;
            }
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            txtCodigo.Focus();
            btnEliminar.Enabled = false;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAgregar.Enabled = false;
            txtCodigo.Focus();
            btnEliminar.Enabled = false;
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        #region "Habilitar Aceptar"

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
    }
}

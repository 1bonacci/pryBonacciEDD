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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola FiladePersonas = new clsCola();

        #region "Agregar / Eliminar"

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;

            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            FiladePersonas.Agregar(ObjNodo);
            FiladePersonas.Recorrer(dgvLista);
            FiladePersonas.Recorrer(lstLista);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            txtCodigo.Focus();
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FiladePersonas.Primero != null)
            {
                txtCodigoE.Text = FiladePersonas.Primero.Codigo.ToString();
                txtNombreE.Text = FiladePersonas.Primero.Nombre;
                txtTramiteE.Text = FiladePersonas.Primero.Tramite;

                FiladePersonas.Eliminar();
                FiladePersonas.Recorrer(dgvLista);
                FiladePersonas.Recorrer(lstLista);
            }
            else
            {
                txtCodigoE.Text = "";
                txtNombreE.Text = "";
                txtTramiteE.Text = "";
            }
        }

        #endregion

        #region "Habilitar Agregar"

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

        private void frmCola_Load(object sender, EventArgs e)
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

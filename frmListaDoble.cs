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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble Doble = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nodo = new clsNodo();
            Nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            Nodo.Nombre = txtNombre.Text;
            Nodo.Tramite = txtTramite.Text;

            Doble.Agregar(Nodo);

            if (rdbAsc.Checked == true)
            {
                Doble.Recorrer(dgvLista);
                Doble.Recorrer(lstLista);
                Doble.Recorrer(cmbCodigo);
            }
            else
            {
                Doble.RecorrerDes(dgvLista);
                Doble.RecorrerDes(lstLista);
                Doble.RecorrerDes(cmbCodigo);
            }

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Doble.Primero != null)
            {
                Doble.Eliminar(Convert.ToInt32(cmbCodigo.SelectedItem));

                if (rdbAsc.Checked == true)
                {
                    Doble.Recorrer(dgvLista);
                    Doble.Recorrer(lstLista);
                    Doble.Recorrer(cmbCodigo);

                }
                else
                {
                    Doble.RecorrerDes(dgvLista);
                    Doble.RecorrerDes(lstLista);
                    Doble.RecorrerDes(cmbCodigo);
                }
            }
            else
            {
                MessageBox.Show("Lista vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private void rdbAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAsc.Checked == true)
            {
                Doble.Recorrer(dgvLista);
                Doble.Recorrer(lstLista);
                Doble.Recorrer(cmbCodigo);

            }
            else
            {
                Doble.RecorrerDes(dgvLista);
                Doble.RecorrerDes(lstLista);
                Doble.RecorrerDes(cmbCodigo);
            }
        }

        private void rdbDes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDes.Checked == true)
            {
                Doble.RecorrerDes(dgvLista);
                Doble.RecorrerDes(lstLista);
                Doble.RecorrerDes(cmbCodigo);

            }
            else
            {
                Doble.Recorrer(dgvLista);
                Doble.Recorrer(lstLista);
                Doble.Recorrer(cmbCodigo);
            }
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            txtCodigo.Focus();
            btnEliminar.Enabled = false;
        }

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
    }
}

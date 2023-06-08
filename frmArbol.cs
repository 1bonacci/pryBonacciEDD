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

namespace pryBonacciEstructuraDeDatos
{
    public partial class frmArbol : Form
    {
        public frmArbol()
        {
            InitializeComponent();
        }

        clsArbol Arbol = new clsArbol();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                clsNodo clsNodo = new clsNodo();
                clsNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                clsNodo.Nombre = (txtNombre.Text);
                clsNodo.Tramite = (txtTramite.Text);

                Arbol.Agregar(clsNodo);

                Arbol.RecorrerInOrder(dgvLista);
                Arbol.RecorrerInOrder(lstLista);
                Arbol.RecorrerInOrder(cmbCodigo);

                if (Arbol.Raiz == null)
                {
                    btnEliminar.Enabled = true; // Habilitar el botón eliminar
                }

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
        }

        #region "RadioButtons"

        private void rdbInOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAsc.Checked == true)
            {
                Arbol.RecorrerInOrder(dgvLista);
                Arbol.RecorrerInOrder(lstLista);
                Arbol.RecorrerInOrder(cmbCodigo);
                trvArbol.Nodes.Clear();
            }
            if (rdbDes.Checked == true)
            {
                Arbol.RecorrerInOrderDes(dgvLista);
                Arbol.RecorrerInOrderDes(lstLista);
                Arbol.RecorrerInOrderDes(cmbCodigo);
            }
        }

        private void rdbPreOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAsc.Checked == true)
            {
                Arbol.RecorrerPreOrder(dgvLista);
                Arbol.RecorrerPreOrder(lstLista);
                Arbol.RecorrerPreOrder(cmbCodigo);
                Arbol.ListarEnTreeView(trvArbol);
            }
            if (rdbDes.Checked == true)
            {
                Arbol.RecorrerInOrderDes(dgvLista);
                Arbol.RecorrerInOrderDes(lstLista);
                Arbol.RecorrerInOrderDes(cmbCodigo);
                Arbol.ListarEnTreeView(trvArbol);
            }
        }

        private void rdbPostOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAsc.Checked == true)
            {
                Arbol.RecorrerPostOrder(dgvLista);
                Arbol.RecorrerPostOrder(lstLista);
                Arbol.RecorrerPostOrder(cmbCodigo);
                trvArbol.Nodes.Clear();
            }
            if (rdbDes.Checked == true)
            {
                Arbol.RecorrerPostOrderDes(dgvLista);
                Arbol.RecorrerPostOrderDes(lstLista);
                Arbol.RecorrerPostOrderDes(cmbCodigo);
            }
        }


        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 cod = Convert.ToInt32(cmbCodigo.Text);
            Arbol.Eliminar(cod);

            Arbol.RecorrerInOrder(dgvLista);
            Arbol.RecorrerInOrder(lstLista);
            Arbol.RecorrerInOrder(cmbCodigo);
            Arbol.ListarEnTreeView(trvArbol);

            btnEliminar.Enabled = false;
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();

            Arbol.RecorrerInOrder(dgvLista);
            Arbol.RecorrerInOrder(lstLista);
            Arbol.RecorrerInOrder(cmbCodigo);
            Arbol.ListarEnTreeView(trvArbol);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 codigo = Convert.ToInt32(txtCodigoBus.Text);
            clsNodo nodo = Arbol.BuscarNodo(codigo);

            if (nodo != null)
            {
                // Mostrar los datos del nodo encontrado
                txtCodigoBus.Text = nodo.Codigo.ToString();
                txtNombreBus.Text = nodo.Nombre;
                txtTramiteBus.Text = nodo.Tramite;
            }
            else
            {
                MessageBox.Show("No se encontró el codigo " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Crear una tabla temporal para contener los datos del DataGridView
            DataTable tabla = new DataTable();

            foreach (DataGridViewColumn columna in dgvLista.Columns)
            {
                tabla.Columns.Add(columna.HeaderText, typeof(string));
            }
            foreach (DataGridViewRow fila in dgvLista.Rows)
            {
                DataRow nuevaFila = tabla.NewRow();
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    nuevaFila[celda.ColumnIndex] = celda.Value;
                }
                tabla.Rows.Add(nuevaFila);
            }

            // Mostrar diálogo para seleccionar la ubicación y el nombre del archivo CSV
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar archivo CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Exportar la tabla a un archivo CSV
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                foreach (DataColumn columna in tabla.Columns)
                {
                    streamWriter.Write(columna.ColumnName + ",");
                }
                streamWriter.WriteLine();
                foreach (DataRow fila in tabla.Rows)
                {
                    for (int i = 0; i < tabla.Columns.Count; i++)
                    {
                        streamWriter.Write(fila[i].ToString() + ", ");
                    }
                    streamWriter.WriteLine();
                }
                streamWriter.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            txtCodigoBus.Text = "";
            txtNombreBus.Text = "";
            txtTramiteBus.Text = "";
            cmbCodigo.Text = "";
            dgvLista.Rows.Clear();
            lstLista.Items.Clear();
            cmbCodigo.Items.Clear();
            trvArbol.Nodes.Clear();
            Arbol.Raiz = null;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            rdbAsc.Checked = true;
            rdbInOrder.Checked = true;
            txtCodigo.Focus();
        }

        private void frmArbol_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            rdbAsc.Checked = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            txtCodigo.Focus();
        }

        #region "TxtBox Numericos"

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCodigoBus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region "Habilitar Botones"

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

        private void txtCodigoBus_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoBus.Text != "")

                btnBuscar.Enabled = true;
            else

                btnBuscar.Enabled = false;
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

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
    public partial class frmConsultaSQLcbo : Form
    {
        public frmConsultaSQLcbo()
        {
            InitializeComponent();
        }

        clsBaseDatos BaseDatos = new clsBaseDatos();

        private void frmConsultaSQLcbo_Load(object sender, EventArgs e)
        {
            cboOperacion.Items.Add("Diferencia");
            cboOperacion.Items.Add("Interseccion");
            cboOperacion.Items.Add("Juntar");
            cboOperacion.Items.Add("Proyeccion simple");
            cboOperacion.Items.Add("Proyeccion multiatributo");
            cboOperacion.Items.Add("Seleccion multiatributo con operador AND");
            cboOperacion.Items.Add("Seleccion multiatributo con operador OR");
            cboOperacion.Items.Add("Seleccion multiatributo por convolucion");
            cboOperacion.Items.Add("Seleccion simple");
            cboOperacion.Items.Add("Union");
        }

        private void cboOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string operacionSeleccionada = cboOperacion.SelectedItem.ToString();
            string varSQL = "";

            switch (operacionSeleccionada)
            {
                case "Diferencia":
                    varSQL = "SELECT * FROM libro WHERE idIdioma = 2 AND idLibro NOT IN (SELECT idLibro FROM libro WHERE idPais = 3) ORDER BY 1 ASC";
                    BaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Interseccion":
                    varSQL = "SELECT * FROM libro WHERE idIdioma = 2 AND idLibro IN (SELECT idLibro FROM libro WHERE idPais = 3) ORDER BY 1 ASC";
                    BaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Juntar":
                    varSQL = "SELECT * FROM libro INNER JOIN autor on LIBRO.IDAUTOR = AUTOR.IDAUTOR";
                    BaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Proyeccion simple":
                    varSQL = "SELECT titulo FROM libro ORDER BY 1 DESC";
                    BaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Proyeccion multiatributo":
                    varSQL = "SELECT titulo, año FROM libro ORDER BY titulo ASC";
                    BaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Seleccion multiatributo con operador AND":
                    varSQL = "SELECT titulo, idAutor AS autor, idIdioma as idioma FROM libro WHERE idAutor <> 5 AND idIdioma = 1 ORDER BY titulo ASC";
                    BaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Seleccion multiatributo con operador OR":
                    varSQL = "SELECT titulo, idAutor AS autor, idIdioma as idioma FROM libro WHERE idAutor <> 5 OR idIdioma = 1 ORDER BY titulo ASC";
                    BaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Seleccion multiatributo por convolucion":
                    varSQL = "SELECT * FROM (SELECT * FROM libro WHERE idAutor = 4) AS x WHERE idIdioma = 1 ORDER BY titulo";
                    BaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Seleccion simple":
                    varSQL = "SELECT titulo, idAutor FROM libro WHERE idAutor <> 5 ORDER BY titulo DESC";
                    BaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Union":
                    varSQL = "SELECT * FROM libro WHERE idIdioma = 1 UNION SELECT * FROM libro WHERE idIdioma = 2";
                    BaseDatos.Listar(dgvSQL, varSQL);
                    break;
            }
        }
    }
}

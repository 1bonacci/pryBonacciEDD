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
    public partial class frmBaseDatos : Form
    {
        public frmBaseDatos()
        {
            InitializeComponent();
        }

        clsBaseDatos BaseDatos = new clsBaseDatos();
        
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            BaseDatos.Listar(dgvGrilla);
        }

        private void btnProyeccionMulti_Click(object sender, EventArgs e)
        {
            String SQL = "Select Titulo " +
                "From Libro " +
                "Order By 1 Desc ";
            BaseDatos.Listar(dgvGrilla, SQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            //String SQL = "Select * " +
            //    ""From Libro, Autor " +
            //    "Where Libro.IdAutor = Autor.IdAutor ";
            //BaseDatos.Listar(dgvGrilla, SQL);

            String SQL = "Select * " +
                "From Libro Inner Join Autor " +
                "On Libro.IdAutor = Autor.IdAutor ";
            BaseDatos.Listar(dgvGrilla, SQL);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            String SQL = "Select Titulo, IdAutor " +
                "From Libro " +
                "Where IdAutor <> 5 " +
                "Order By Titulo Desc ";
            BaseDatos.Listar(dgvGrilla, SQL);
        }

        private void btnSeleccionMulti_Click(object sender, EventArgs e)
        {
            String SQL = "Select Titulo, IdAutor As Autor, IdIdioma As Idioma " +
                "From Libro " +
                "Where IdAutor <> 5 AND IdIdioma = 1 " +
                "Order By Titulo Asc ";
            BaseDatos.Listar(dgvGrilla, SQL);
        }

        private void btnConvolucion_Click(object sender, EventArgs e)
        {
            String SQL = "Select * " +
                " From (Select * From Libro Where IdAutor = 4) as Lib1 " +
                " Where IdIdioma = 1 " +
                " Order By Titulo ";
            BaseDatos.Listar(dgvGrilla, SQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String SQL = "Select * From Libro Where IdAutor = 5 " +
                "Union " +
                " (Select * From Libro Where IdIdioma = 3 )";
            BaseDatos.Listar(dgvGrilla, SQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String SQL = "Select * From Libro " +
            " Where idIdioma = 2 And " +
            " IdLibro In " +
            " (Select IdLibro From Libro Where IdPais = 3 )" +
            " Order By 1 Asc ";
            BaseDatos.Listar(dgvGrilla, SQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String SQL = "Select * From Libro Where IdIdioma = 2 " +
                "and IdLibro not in " +
                " (Select IdLibro From Libro Where IdPais = 3 )" +
                "Order By 1 Asc";
            BaseDatos.Listar(dgvGrilla, SQL);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryBonacciEstructuraDeDatos
{
    internal class clsArbol
    {
        private clsNodo Inicio;

        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;

        #region "Agregar / Eliminar"

        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;

            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo Aux = Raiz;
                clsNodo Ant = Raiz;
                while (Aux != null)
                {
                    Ant = Aux;
                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if (Nuevo.Codigo < Ant.Codigo)
                {
                    Ant.Izquierdo = Nuevo;
                }
                else
                {
                    Ant.Derecho = Nuevo;
                }
            }
        }

        //public void Eliminar(Int32 Codigo)
        //{
        //    clsNodo aux = Raiz;
        //    clsNodo ant = Raiz;

        //    while (aux != null && aux.Codigo != Codigo)
        //    {
        //        ant = aux;
        //        if (Codigo < aux.Codigo)
        //        {
        //            aux = aux.Izquierdo;
        //        }
        //        else
        //        {
        //            aux = aux.Derecho;
        //        }
        //    }
        //    if (aux != null && aux.Izquierdo == null && aux.Derecho == null)
        //    {
        //        if (Codigo < ant.Codigo)
        //        {
        //            ant.Izquierdo = null;
        //        }
        //        else
        //        {
        //            ant.Derecho = null;
        //        }
        //    }
        //    else
        //    {
        //        if (aux != null)
        //        {
        //            if (aux.Izquierdo == null)
        //            {
        //                if (Codigo < ant.Codigo)
        //                {
        //                    ant.Izquierdo = aux.Derecho;
        //                }
        //                else
        //                {
        //                    ant.Derecho = aux.Derecho;
        //                }
        //            }

        //        }
        //        else
        //        {
        //            if (aux != null)
        //            {
        //                if (aux.Derecho == null)
        //                {
        //                    if (Codigo < ant.Codigo)
        //                    {
        //                        ant.Izquierdo = aux.Izquierdo;
        //                    }
        //                    else
        //                    {
        //                        ant.Derecho = aux.Izquierdo;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                clsNodo aux2 = aux.Derecho;
        //                clsNodo ant2 = aux.Derecho;
        //                while (aux2.Izquierdo != null)
        //                {
        //                    ant2 = aux2;
        //                    aux2 = aux2.Izquierdo;
        //                }
        //                aux.Codigo = aux2.Codigo;
        //                aux.Nombre = aux2.Nombre;
        //                aux.Tramite = aux2.Tramite;
        //                if (aux2.Derecho == null)
        //                {
        //                    ant2.Izquierdo = null;
        //                }
        //                else
        //                {
        //                    ant2.Izquierdo = aux2.Derecho;
        //                }
        //            }
        //        }
        //    }
        //}

        public void Eliminar(Int32 Num)
        {
            i = 0;
            CargarVector(Raiz, Num);
            Raiz = null;
            EliminarArbol(0, i - 1);
        }

        private void CargarVector(clsNodo Nodopadre, Int32 Cod)
        {
            if (Nodopadre.Izquierdo != null)
            {
                CargarVector(Nodopadre.Izquierdo, Cod);
            }
            if (Nodopadre.Codigo != Cod)
            {
                Vector[i] = Nodopadre;
                i++;
            }
            if (Nodopadre.Derecho != null)
            {
                CargarVector(Nodopadre.Derecho, Cod);
            }
        }

        private void EliminarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;

            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EliminarArbol(ini, m - 1);
                EliminarArbol(m + 1, fin);

            }
        }

        #endregion

        #region "ListBox"

        #region "Recorrer"

        public void RecorrerInOrder(ListBox lstLista)
        {
            lstLista.Items.Clear();
            if (Raiz != null)
            {
                InOrderAsc(lstLista, Raiz);
            }
        }

        public void RecorrerPreOrder(ListBox lstLista)
        {
            lstLista.Items.Clear();
            if (Raiz != null)
            {
                PreOrderAsc(lstLista, Raiz);
            }
        }

        public void RecorrerPostOrder(ListBox lstLista)
        {
            lstLista.Items.Clear();
            if (Raiz != null)
            {
                PostOrderAsc(lstLista, Raiz);
            }
        }

        public void RecorrerInOrderDes(ListBox lstLista)
        {
            lstLista.Items.Clear();
            if (Raiz != null)
            {
                InOrderDes(lstLista, Raiz);
            }
        }

        public void RecorrerPreOrderDes(ListBox lstLista)
        {
            lstLista.Items.Clear();
            if (Raiz != null)
            {
                PreOrderDes(lstLista, Raiz);
            }
        }

        public void RecorrerPostOrderDes(ListBox lstLista)
        {
            lstLista.Items.Clear();
            if (Raiz != null)
            {
                PostOrderDes(lstLista, Raiz);
            }
        }

        #endregion

        #region "Order"

        private void InOrderAsc(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(lst, R.Izquierdo);
            lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrderAsc(lst, R.Derecho);
        }

        private void PreOrderAsc(ListBox lst, clsNodo R)
        {
            lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrderAsc(lst, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(lst, R.Derecho);
        }

        private void PostOrderAsc(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(lst, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(lst, R.Derecho);
            lst.Items.Add(R.Codigo);
        }

        private void InOrderDes(ListBox lst, clsNodo R)
        {
            if (R.Derecho != null) InOrderDes(lst, R.Derecho);
            lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrderDes(lst, R.Izquierdo);
        }

        private void PreOrderDes(ListBox lst, clsNodo R)
        {
            lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrderDes(lst, R.Izquierdo);
            if (R.Derecho != null) PreOrderDes(lst, R.Derecho);
        }
        private void PostOrderDes(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderDes(lst, R.Izquierdo);
            if (R.Derecho != null) PostOrderDes(lst, R.Derecho);
            lst.Items.Add(R.Codigo);
        }

        #endregion

        #endregion

        #region "ComboBox"

        #region "Recorrer"

        public void RecorrerInOrder(ComboBox cbo)
        {
            cbo.Items.Clear();
            if (Raiz != null)
            {
                InOrderAsc(cbo, Raiz);
            }
        }

        public void RecorrerPreOrder(ComboBox cbo)
        {
            cbo.Items.Clear();
            if (Raiz != null)
            {
                PreOrderAsc(cbo, Raiz);
            }
        }

        public void RecorrerPostOrder(ComboBox cbo)
        {
            cbo.Items.Clear();
            if (Raiz != null)
            {
                PostOrderAsc(cbo, Raiz);
            }
        }

        public void RecorrerInOrderDes(ComboBox cbo)
        {
            cbo.Items.Clear();
            if (Raiz != null)
            {
                InOrderDes(cbo, Raiz);
            }
        }

        public void RecorrerPreOrderDes(ComboBox cbo)
        {
            cbo.Items.Clear();
            if (Raiz != null)
            {
                PreOrderDes(cbo, Raiz);
            }
        }

        public void RecorrerPostOrderDes(ComboBox cbo)
        {
            cbo.Items.Clear();
            if (Raiz != null)
            {
                PostOrderDes(cbo, Raiz);
            }
        }

        #endregion

        #region "Order"

        private void InOrderAsc(ComboBox cbo, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(cbo, R.Izquierdo);
            cbo.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrderAsc(cbo, R.Derecho);
        }

        private void PreOrderAsc(ComboBox cbo, clsNodo R)
        {
            cbo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrderAsc(cbo, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(cbo, R.Derecho);
        }

        private void PostOrderAsc(ComboBox cbo, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(cbo, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(cbo, R.Derecho);
            cbo.Items.Add(R.Codigo);
        }

        private void InOrderDes(ComboBox cbo, clsNodo R)
        {
            if (R.Derecho != null) InOrderDes(cbo, R.Derecho);
            cbo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrderDes(cbo, R.Izquierdo);
        }

        private void PreOrderDes(ComboBox cbo, clsNodo R)
        {
            cbo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrderDes(cbo, R.Izquierdo);
            if (R.Derecho != null) PreOrderDes(cbo, R.Derecho);
        }

        private void PostOrderDes(ComboBox cbo, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderDes(cbo, R.Izquierdo);
            if (R.Derecho != null) PostOrderDes(cbo, R.Derecho);
            cbo.Items.Add(R.Codigo);
        }

        #endregion

        #endregion

        #region "DataGridView"

        #region "Recorrer"

        public void RecorrerInOrder(DataGridView dgv)
        {
            dgv.Rows.Clear();
            if (Raiz != null)
            {
                InOrderAsc(dgv, Raiz);
            }
        }

        public void RecorrerPreOrder(DataGridView dgv)
        {
            dgv.Rows.Clear();
            if (Raiz != null)
            {
                PreOrderAsc(dgv, Raiz);
            }
        }

        public void RecorrerPostOrder(DataGridView dgv)
        {
            dgv.Rows.Clear();
            if (Raiz != null)
            {
                PostOrderAsc(dgv, Raiz);
            }
        }

        public void RecorrerInOrderDes(DataGridView dgv)
        {
            dgv.Rows.Clear();
            if (Raiz != null)
            {
                InOrderDes(dgv, Raiz);
            }
        }

        public void RecorrerPreOrderDes(DataGridView dgv)
        {
            dgv.Rows.Clear();
            if (Raiz != null)
            {
                PreOrderDes(dgv, Raiz);
            }
        }

        public void RecorrerPostOrderDes(DataGridView dgv)
        {
            dgv.Rows.Clear();
            if (Raiz != null)
            {
                PostOrderDes(dgv, Raiz);
            }
        }

        #endregion

        #region "Order"

        private void InOrderAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(dgv, R.Izquierdo);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrderAsc(dgv, R.Derecho);
        }

        private void PreOrderAsc(DataGridView dgv, clsNodo R)
        {
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrderAsc(dgv, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(dgv, R.Derecho);
        }

        private void PostOrderAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(dgv, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(dgv, R.Derecho);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        private void InOrderDes(DataGridView dgv, clsNodo R)
        {
            if (R.Derecho != null) InOrderDes(dgv, R.Derecho);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrderDes(dgv, R.Izquierdo);
        }

        private void PreOrderDes(DataGridView dgv, clsNodo R)
        {
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrderDes(dgv, R.Izquierdo);
            if (R.Derecho != null) PreOrderDes(dgv, R.Derecho);
        }

        private void PostOrderDes(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderDes(dgv, R.Izquierdo);
            if (R.Derecho != null) PostOrderDes(dgv, R.Derecho);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        #endregion

        #endregion

        #region "StreamWriter"

        #region "Recorrer"

        public void RecorrerInOrder(StreamWriter sw)
        {
            sw.WriteLine();
            if (Raiz != null)
            {
                InOrderAsc(sw, Raiz);
            }
        }

        public void RecorrerPreOrder(StreamWriter sw)
        {
            sw.WriteLine();
            if (Raiz != null)
            {
                PreOrderAsc(sw, Raiz);
            }
        }

        public void RecorrerPostOrder(StreamWriter sw)
        {
            sw.WriteLine();
            if (Raiz != null)
            {
                PostOrderAsc(sw, Raiz);
            }
        }

        #endregion

        #region "Order"

        public void InOrderAsc(StreamWriter sw, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(sw, R.Izquierdo);
            sw.WriteLine(R.Codigo);
            if (R.Derecho != null) InOrderAsc(sw, R.Derecho);
        }

        public void PreOrderAsc(StreamWriter sw, clsNodo R)
        {
            sw.WriteLine(R.Codigo);
            if (R.Izquierdo != null) PreOrderAsc(sw, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(sw, R.Derecho);
        }

        public void PostOrderAsc(StreamWriter sw, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(sw, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(sw, R.Derecho);
            sw.WriteLine(R.Codigo);
        }

        #endregion

        #endregion

        #region "TreeView"

        #region "Recorrer"

        public void ListarEnTreeView(TreeView treeview)
        {
            treeview.Nodes.Clear();
            if (Raiz != null)
            {
                ListarRecursivoEnTreeView(treeview.Nodes, Raiz);
            }
        }

        #endregion

        #region "Order"

        private void ListarRecursivoEnTreeView(TreeNodeCollection nodes, clsNodo nodo)
        {
            if (nodo != null)
            {
                TreeNode treeNode = nodes.Add(nodo.Codigo.ToString());
                ListarRecursivoEnTreeView(treeNode.Nodes, nodo.Izquierdo);
                ListarRecursivoEnTreeView(treeNode.Nodes, nodo.Derecho);
            }
        }

        #endregion              

        #endregion

        #region "Equilibrar"

        private clsNodo[] vecEquilibrar = new clsNodo[100];
        private Int32 ind = 0;

        private void CargarVectorInOrder(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVectorInOrder(NodoPadre.Izquierdo);
            }

            vecEquilibrar[ind] = NodoPadre;
            ind++;

            if (NodoPadre.Derecho != null)
            {
                CargarVectorInOrder(NodoPadre.Derecho);
            }
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(vecEquilibrar[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        public void Equilibrar()
        {
            ind = 0;
            CargarVectorInOrder(Raiz);
            Raiz = null;
            EquilibrarArbol(0, ind - 1);
        }

        #endregion

        #region "Buscar Nodo"

        public clsNodo BuscarNodo(Int32 Codigo)
        {
            clsNodo NodoPadre = Raiz;
            while (NodoPadre != null)
            {
                if (NodoPadre.Codigo == Codigo)
                {
                    return NodoPadre;
                }
                else
                {
                    if (Codigo < NodoPadre.Codigo)
                    {
                        NodoPadre = NodoPadre.Izquierdo;
                    }
                    else
                    {
                        NodoPadre = NodoPadre.Derecho;
                    }
                }
            }
            return null;
        }

        #endregion

    }
}

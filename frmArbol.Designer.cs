namespace pryBonacciEstructuraDeDatos
{
    partial class frmArbol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbol));
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.gpbRecorrido = new System.Windows.Forms.GroupBox();
            this.rdbDes = new System.Windows.Forms.RadioButton();
            this.rdbAsc = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpbNodo = new System.Windows.Forms.GroupBox();
            this.txtTramiteBus = new System.Windows.Forms.TextBox();
            this.txtNombreBus = new System.Windows.Forms.TextBox();
            this.txtCodigoBus = new System.Windows.Forms.TextBox();
            this.lblCodigoBUS = new System.Windows.Forms.Label();
            this.lblNombreBUS = new System.Windows.Forms.Label();
            this.lblTramiteBUS = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gpbOrden = new System.Windows.Forms.GroupBox();
            this.rdbPostOrder = new System.Windows.Forms.RadioButton();
            this.rdbPreOrder = new System.Windows.Forms.RadioButton();
            this.rdbInOrder = new System.Windows.Forms.RadioButton();
            this.trvArbol = new System.Windows.Forms.TreeView();
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoRO = new System.Windows.Forms.Label();
            this.grbNuevo = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.grbListado = new System.Windows.Forms.GroupBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbRecorrido.SuspendLayout();
            this.gpbNodo.SuspendLayout();
            this.gpbOrden.SuspendLayout();
            this.grbEliminar.SuspendLayout();
            this.grbNuevo.SuspendLayout();
            this.grbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(656, 345);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(156, 27);
            this.btnEquilibrar.TabIndex = 46;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(656, 378);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(156, 27);
            this.btnExportar.TabIndex = 45;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // gpbRecorrido
            // 
            this.gpbRecorrido.Controls.Add(this.rdbDes);
            this.gpbRecorrido.Controls.Add(this.rdbAsc);
            this.gpbRecorrido.Location = new System.Drawing.Point(656, 107);
            this.gpbRecorrido.Name = "gpbRecorrido";
            this.gpbRecorrido.Size = new System.Drawing.Size(156, 64);
            this.gpbRecorrido.TabIndex = 41;
            this.gpbRecorrido.TabStop = false;
            this.gpbRecorrido.Text = "Configurar Recorrido";
            // 
            // rdbDes
            // 
            this.rdbDes.AutoSize = true;
            this.rdbDes.Location = new System.Drawing.Point(11, 40);
            this.rdbDes.Name = "rdbDes";
            this.rdbDes.Size = new System.Drawing.Size(89, 17);
            this.rdbDes.TabIndex = 9;
            this.rdbDes.TabStop = true;
            this.rdbDes.Text = "Descendente";
            this.rdbDes.UseVisualStyleBackColor = true;
            // 
            // rdbAsc
            // 
            this.rdbAsc.AutoSize = true;
            this.rdbAsc.Checked = true;
            this.rdbAsc.Location = new System.Drawing.Point(11, 18);
            this.rdbAsc.Name = "rdbAsc";
            this.rdbAsc.Size = new System.Drawing.Size(82, 17);
            this.rdbAsc.TabIndex = 8;
            this.rdbAsc.TabStop = true;
            this.rdbAsc.Text = "Ascendente";
            this.rdbAsc.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(656, 413);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(156, 23);
            this.btnLimpiar.TabIndex = 44;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpbNodo
            // 
            this.gpbNodo.Controls.Add(this.txtTramiteBus);
            this.gpbNodo.Controls.Add(this.txtNombreBus);
            this.gpbNodo.Controls.Add(this.txtCodigoBus);
            this.gpbNodo.Controls.Add(this.lblCodigoBUS);
            this.gpbNodo.Controls.Add(this.lblNombreBUS);
            this.gpbNodo.Controls.Add(this.lblTramiteBUS);
            this.gpbNodo.Controls.Add(this.btnBuscar);
            this.gpbNodo.Location = new System.Drawing.Point(228, 12);
            this.gpbNodo.Name = "gpbNodo";
            this.gpbNodo.Size = new System.Drawing.Size(206, 162);
            this.gpbNodo.TabIndex = 43;
            this.gpbNodo.TabStop = false;
            this.gpbNodo.Text = "Buscar Nodo";
            // 
            // txtTramiteBus
            // 
            this.txtTramiteBus.Location = new System.Drawing.Point(70, 97);
            this.txtTramiteBus.Name = "txtTramiteBus";
            this.txtTramiteBus.ReadOnly = true;
            this.txtTramiteBus.Size = new System.Drawing.Size(126, 20);
            this.txtTramiteBus.TabIndex = 13;
            // 
            // txtNombreBus
            // 
            this.txtNombreBus.Location = new System.Drawing.Point(70, 64);
            this.txtNombreBus.Name = "txtNombreBus";
            this.txtNombreBus.ReadOnly = true;
            this.txtNombreBus.Size = new System.Drawing.Size(126, 20);
            this.txtNombreBus.TabIndex = 12;
            // 
            // txtCodigoBus
            // 
            this.txtCodigoBus.Location = new System.Drawing.Point(96, 31);
            this.txtCodigoBus.Name = "txtCodigoBus";
            this.txtCodigoBus.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoBus.TabIndex = 11;
            this.txtCodigoBus.TextChanged += new System.EventHandler(this.txtCodigoBus_TextChanged);
            this.txtCodigoBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBus_KeyPress);
            // 
            // lblCodigoBUS
            // 
            this.lblCodigoBUS.AutoSize = true;
            this.lblCodigoBUS.Location = new System.Drawing.Point(17, 34);
            this.lblCodigoBUS.Name = "lblCodigoBUS";
            this.lblCodigoBUS.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoBUS.TabIndex = 7;
            this.lblCodigoBUS.Text = "Codigo:";
            // 
            // lblNombreBUS
            // 
            this.lblNombreBUS.AutoSize = true;
            this.lblNombreBUS.Location = new System.Drawing.Point(17, 67);
            this.lblNombreBUS.Name = "lblNombreBUS";
            this.lblNombreBUS.Size = new System.Drawing.Size(47, 13);
            this.lblNombreBUS.TabIndex = 8;
            this.lblNombreBUS.Text = "Nombre:";
            // 
            // lblTramiteBUS
            // 
            this.lblTramiteBUS.AutoSize = true;
            this.lblTramiteBUS.Location = new System.Drawing.Point(19, 100);
            this.lblTramiteBUS.Name = "lblTramiteBUS";
            this.lblTramiteBUS.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteBUS.TabIndex = 9;
            this.lblTramiteBUS.Text = "Tramite:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(11, 132);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(185, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gpbOrden
            // 
            this.gpbOrden.Controls.Add(this.rdbPostOrder);
            this.gpbOrden.Controls.Add(this.rdbPreOrder);
            this.gpbOrden.Controls.Add(this.rdbInOrder);
            this.gpbOrden.Location = new System.Drawing.Point(656, 12);
            this.gpbOrden.Name = "gpbOrden";
            this.gpbOrden.Size = new System.Drawing.Size(156, 89);
            this.gpbOrden.TabIndex = 42;
            this.gpbOrden.TabStop = false;
            this.gpbOrden.Text = "Configurar Orden";
            // 
            // rdbPostOrder
            // 
            this.rdbPostOrder.AutoSize = true;
            this.rdbPostOrder.Location = new System.Drawing.Point(11, 62);
            this.rdbPostOrder.Name = "rdbPostOrder";
            this.rdbPostOrder.Size = new System.Drawing.Size(72, 17);
            this.rdbPostOrder.TabIndex = 10;
            this.rdbPostOrder.TabStop = true;
            this.rdbPostOrder.Text = "PostOrder";
            this.rdbPostOrder.UseVisualStyleBackColor = true;
            this.rdbPostOrder.CheckedChanged += new System.EventHandler(this.rdbPostOrder_CheckedChanged);
            // 
            // rdbPreOrder
            // 
            this.rdbPreOrder.AutoSize = true;
            this.rdbPreOrder.Location = new System.Drawing.Point(11, 40);
            this.rdbPreOrder.Name = "rdbPreOrder";
            this.rdbPreOrder.Size = new System.Drawing.Size(67, 17);
            this.rdbPreOrder.TabIndex = 9;
            this.rdbPreOrder.TabStop = true;
            this.rdbPreOrder.Text = "PreOrder";
            this.rdbPreOrder.UseVisualStyleBackColor = true;
            this.rdbPreOrder.CheckedChanged += new System.EventHandler(this.rdbPreOrder_CheckedChanged);
            // 
            // rdbInOrder
            // 
            this.rdbInOrder.AutoSize = true;
            this.rdbInOrder.Location = new System.Drawing.Point(11, 18);
            this.rdbInOrder.Name = "rdbInOrder";
            this.rdbInOrder.Size = new System.Drawing.Size(60, 17);
            this.rdbInOrder.TabIndex = 8;
            this.rdbInOrder.Text = "InOrder";
            this.rdbInOrder.UseVisualStyleBackColor = true;
            this.rdbInOrder.CheckedChanged += new System.EventHandler(this.rdbInOrder_CheckedChanged);
            // 
            // trvArbol
            // 
            this.trvArbol.Location = new System.Drawing.Point(657, 185);
            this.trvArbol.Name = "trvArbol";
            this.trvArbol.Size = new System.Drawing.Size(156, 154);
            this.trvArbol.TabIndex = 40;
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.cmbCodigo);
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Controls.Add(this.lblCodigoRO);
            this.grbEliminar.Location = new System.Drawing.Point(440, 12);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Size = new System.Drawing.Size(210, 112);
            this.grbEliminar.TabIndex = 38;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Eliminar Elemento";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(78, 34);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigo.TabIndex = 14;
            this.cmbCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbCodigo_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(11, 74);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigoRO
            // 
            this.lblCodigoRO.AutoSize = true;
            this.lblCodigoRO.Location = new System.Drawing.Point(22, 37);
            this.lblCodigoRO.Name = "lblCodigoRO";
            this.lblCodigoRO.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoRO.TabIndex = 12;
            this.lblCodigoRO.Text = "Codigo:";
            // 
            // grbNuevo
            // 
            this.grbNuevo.Controls.Add(this.btnAgregar);
            this.grbNuevo.Controls.Add(this.txtTramite);
            this.grbNuevo.Controls.Add(this.lblCodigo);
            this.grbNuevo.Controls.Add(this.txtNombre);
            this.grbNuevo.Controls.Add(this.lblNombre);
            this.grbNuevo.Controls.Add(this.txtCodigo);
            this.grbNuevo.Controls.Add(this.lblTramite);
            this.grbNuevo.Location = new System.Drawing.Point(12, 12);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Size = new System.Drawing.Size(210, 161);
            this.grbNuevo.TabIndex = 37;
            this.grbNuevo.TabStop = false;
            this.grbNuevo.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 131);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(73, 97);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(126, 20);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(99, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(22, 100);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite:";
            // 
            // grbListado
            // 
            this.grbListado.Controls.Add(this.lstLista);
            this.grbListado.Controls.Add(this.dgvLista);
            this.grbListado.Location = new System.Drawing.Point(12, 180);
            this.grbListado.Name = "grbListado";
            this.grbListado.Size = new System.Drawing.Size(638, 256);
            this.grbListado.TabIndex = 39;
            this.grbListado.TabStop = false;
            this.grbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(13, 21);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(193, 225);
            this.lstLista.TabIndex = 13;
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvLista.Location = new System.Drawing.Point(212, 21);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(415, 225);
            this.dgvLista.TabIndex = 20;
            // 
            // clmCodigo
            // 
            this.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.Width = 65;
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            // 
            // clmTramite
            // 
            this.clmTramite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTramite.HeaderText = "Tramite";
            this.clmTramite.Name = "clmTramite";
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 447);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.gpbRecorrido);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpbNodo);
            this.Controls.Add(this.gpbOrden);
            this.Controls.Add(this.trvArbol);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.grbListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinamica No Lineal - Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbol_Load);
            this.gpbRecorrido.ResumeLayout(false);
            this.gpbRecorrido.PerformLayout();
            this.gpbNodo.ResumeLayout(false);
            this.gpbNodo.PerformLayout();
            this.gpbOrden.ResumeLayout(false);
            this.gpbOrden.PerformLayout();
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            this.grbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.GroupBox gpbRecorrido;
        private System.Windows.Forms.RadioButton rdbDes;
        private System.Windows.Forms.RadioButton rdbAsc;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpbNodo;
        private System.Windows.Forms.TextBox txtTramiteBus;
        private System.Windows.Forms.TextBox txtNombreBus;
        private System.Windows.Forms.TextBox txtCodigoBus;
        private System.Windows.Forms.Label lblCodigoBUS;
        private System.Windows.Forms.Label lblNombreBUS;
        private System.Windows.Forms.Label lblTramiteBUS;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gpbOrden;
        private System.Windows.Forms.RadioButton rdbPostOrder;
        private System.Windows.Forms.RadioButton rdbPreOrder;
        private System.Windows.Forms.RadioButton rdbInOrder;
        private System.Windows.Forms.TreeView trvArbol;
        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoRO;
        private System.Windows.Forms.GroupBox grbNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.GroupBox grbListado;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
    }
}
namespace pryBonacciEstructuraDeDatos
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTramiteE = new System.Windows.Forms.TextBox();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.lblCodigoRO = new System.Windows.Forms.Label();
            this.lblTramiteRO = new System.Windows.Forms.Label();
            this.txtCodigoE = new System.Windows.Forms.TextBox();
            this.lblNombreRO = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbEliminar.SuspendLayout();
            this.grbNuevo.SuspendLayout();
            this.grbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Controls.Add(this.txtTramiteE);
            this.grbEliminar.Controls.Add(this.txtNombreE);
            this.grbEliminar.Controls.Add(this.lblCodigoRO);
            this.grbEliminar.Controls.Add(this.lblTramiteRO);
            this.grbEliminar.Controls.Add(this.txtCodigoE);
            this.grbEliminar.Controls.Add(this.lblNombreRO);
            this.grbEliminar.Location = new System.Drawing.Point(440, 14);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Size = new System.Drawing.Size(210, 161);
            this.grbEliminar.TabIndex = 27;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Eliminar Elemento";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(11, 132);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtTramiteE
            // 
            this.txtTramiteE.Enabled = false;
            this.txtTramiteE.Location = new System.Drawing.Point(73, 96);
            this.txtTramiteE.Name = "txtTramiteE";
            this.txtTramiteE.ReadOnly = true;
            this.txtTramiteE.Size = new System.Drawing.Size(126, 20);
            this.txtTramiteE.TabIndex = 18;
            // 
            // txtNombreE
            // 
            this.txtNombreE.Enabled = false;
            this.txtNombreE.Location = new System.Drawing.Point(73, 63);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.ReadOnly = true;
            this.txtNombreE.Size = new System.Drawing.Size(126, 20);
            this.txtNombreE.TabIndex = 17;
            // 
            // lblCodigoRO
            // 
            this.lblCodigoRO.AutoSize = true;
            this.lblCodigoRO.Location = new System.Drawing.Point(22, 33);
            this.lblCodigoRO.Name = "lblCodigoRO";
            this.lblCodigoRO.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoRO.TabIndex = 12;
            this.lblCodigoRO.Text = "Codigo:";
            // 
            // lblTramiteRO
            // 
            this.lblTramiteRO.AutoSize = true;
            this.lblTramiteRO.Location = new System.Drawing.Point(22, 99);
            this.lblTramiteRO.Name = "lblTramiteRO";
            this.lblTramiteRO.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteRO.TabIndex = 15;
            this.lblTramiteRO.Text = "Tramite:";
            // 
            // txtCodigoE
            // 
            this.txtCodigoE.Enabled = false;
            this.txtCodigoE.Location = new System.Drawing.Point(99, 30);
            this.txtCodigoE.Name = "txtCodigoE";
            this.txtCodigoE.ReadOnly = true;
            this.txtCodigoE.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoE.TabIndex = 16;
            // 
            // lblNombreRO
            // 
            this.lblNombreRO.AutoSize = true;
            this.lblNombreRO.Location = new System.Drawing.Point(22, 66);
            this.lblNombreRO.Name = "lblNombreRO";
            this.lblNombreRO.Size = new System.Drawing.Size(47, 13);
            this.lblNombreRO.TabIndex = 14;
            this.lblNombreRO.Text = "Nombre:";
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
            this.grbNuevo.Location = new System.Drawing.Point(224, 14);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Size = new System.Drawing.Size(210, 161);
            this.grbNuevo.TabIndex = 26;
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
            this.txtTramite.Location = new System.Drawing.Point(73, 100);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(126, 20);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(99, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(22, 103);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite:";
            // 
            // grbListado
            // 
            this.grbListado.Controls.Add(this.lstLista);
            this.grbListado.Controls.Add(this.dgvLista);
            this.grbListado.Location = new System.Drawing.Point(12, 181);
            this.grbListado.Name = "grbListado";
            this.grbListado.Size = new System.Drawing.Size(638, 257);
            this.grbListado.TabIndex = 28;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryBonacciEstructuraDeDatos.Properties.Resources.pila;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.grbListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinamica Lineal - Pila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            this.grbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTramiteE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label lblCodigoRO;
        private System.Windows.Forms.Label lblTramiteRO;
        private System.Windows.Forms.TextBox txtCodigoE;
        private System.Windows.Forms.Label lblNombreRO;
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
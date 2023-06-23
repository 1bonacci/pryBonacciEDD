namespace pryBonacciEstructuraDeDatos
{
    partial class frmBaseDatos
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
            this.gpbSeleccion = new System.Windows.Forms.GroupBox();
            this.btnConvolucion = new System.Windows.Forms.Button();
            this.btnSeleccionMulti = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.gpbAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.gpbProyeccion = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyeccionMulti = new System.Windows.Forms.Button();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.gpbSeleccion.SuspendLayout();
            this.gpbAlgebraicas.SuspendLayout();
            this.gpbProyeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbSeleccion
            // 
            this.gpbSeleccion.Controls.Add(this.btnConvolucion);
            this.gpbSeleccion.Controls.Add(this.btnSeleccionMulti);
            this.gpbSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.gpbSeleccion.Location = new System.Drawing.Point(251, 298);
            this.gpbSeleccion.Name = "gpbSeleccion";
            this.gpbSeleccion.Size = new System.Drawing.Size(233, 155);
            this.gpbSeleccion.TabIndex = 6;
            this.gpbSeleccion.TabStop = false;
            this.gpbSeleccion.Text = "Operaciones de Seleccion";
            // 
            // btnConvolucion
            // 
            this.btnConvolucion.Location = new System.Drawing.Point(6, 110);
            this.btnConvolucion.Name = "btnConvolucion";
            this.btnConvolucion.Size = new System.Drawing.Size(221, 23);
            this.btnConvolucion.TabIndex = 5;
            this.btnConvolucion.Text = "Seleccion por Convolucion";
            this.btnConvolucion.UseVisualStyleBackColor = true;
            this.btnConvolucion.Click += new System.EventHandler(this.btnConvolucion_Click);
            // 
            // btnSeleccionMulti
            // 
            this.btnSeleccionMulti.Location = new System.Drawing.Point(6, 71);
            this.btnSeleccionMulti.Name = "btnSeleccionMulti";
            this.btnSeleccionMulti.Size = new System.Drawing.Size(221, 23);
            this.btnSeleccionMulti.TabIndex = 4;
            this.btnSeleccionMulti.Text = "Seleccion Multiatributo";
            this.btnSeleccionMulti.UseVisualStyleBackColor = true;
            this.btnSeleccionMulti.Click += new System.EventHandler(this.btnSeleccionMulti_Click);
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(6, 32);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(221, 23);
            this.btnSeleccionSimple.TabIndex = 3;
            this.btnSeleccionSimple.Text = "Seleccion Simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // gpbAlgebraicas
            // 
            this.gpbAlgebraicas.Controls.Add(this.btnDiferencia);
            this.gpbAlgebraicas.Controls.Add(this.btnInterseccion);
            this.gpbAlgebraicas.Controls.Add(this.btnUnion);
            this.gpbAlgebraicas.Location = new System.Drawing.Point(490, 298);
            this.gpbAlgebraicas.Name = "gpbAlgebraicas";
            this.gpbAlgebraicas.Size = new System.Drawing.Size(236, 155);
            this.gpbAlgebraicas.TabIndex = 7;
            this.gpbAlgebraicas.TabStop = false;
            this.gpbAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(6, 110);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(221, 23);
            this.btnDiferencia.TabIndex = 8;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(6, 71);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(221, 23);
            this.btnInterseccion.TabIndex = 7;
            this.btnInterseccion.Text = "Interseccion";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 32);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(221, 23);
            this.btnUnion.TabIndex = 6;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // gpbProyeccion
            // 
            this.gpbProyeccion.Controls.Add(this.btnJuntar);
            this.gpbProyeccion.Controls.Add(this.btnProyeccionMulti);
            this.gpbProyeccion.Controls.Add(this.btnProyeccionSimple);
            this.gpbProyeccion.Location = new System.Drawing.Point(12, 298);
            this.gpbProyeccion.Name = "gpbProyeccion";
            this.gpbProyeccion.Size = new System.Drawing.Size(233, 155);
            this.gpbProyeccion.TabIndex = 5;
            this.gpbProyeccion.TabStop = false;
            this.gpbProyeccion.Text = "Operaciones de Proyeccion";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 110);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(221, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProyeccionMulti
            // 
            this.btnProyeccionMulti.Location = new System.Drawing.Point(6, 71);
            this.btnProyeccionMulti.Name = "btnProyeccionMulti";
            this.btnProyeccionMulti.Size = new System.Drawing.Size(221, 23);
            this.btnProyeccionMulti.TabIndex = 1;
            this.btnProyeccionMulti.Text = "Proyeccion Multiatributo";
            this.btnProyeccionMulti.UseVisualStyleBackColor = true;
            this.btnProyeccionMulti.Click += new System.EventHandler(this.btnProyeccionMulti_Click);
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(6, 32);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(221, 23);
            this.btnProyeccionSimple.TabIndex = 0;
            this.btnProyeccionSimple.Text = "Proyeccion Simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(12, 12);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(714, 271);
            this.dgvGrilla.TabIndex = 4;
            // 
            // frmBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 461);
            this.Controls.Add(this.gpbSeleccion);
            this.Controls.Add(this.gpbAlgebraicas);
            this.Controls.Add(this.gpbProyeccion);
            this.Controls.Add(this.dgvGrilla);
            this.Name = "frmBaseDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            this.gpbSeleccion.ResumeLayout(false);
            this.gpbAlgebraicas.ResumeLayout(false);
            this.gpbProyeccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSeleccion;
        private System.Windows.Forms.Button btnConvolucion;
        private System.Windows.Forms.Button btnSeleccionMulti;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.GroupBox gpbAlgebraicas;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.GroupBox gpbProyeccion;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyeccionMulti;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.DataGridView dgvGrilla;
    }
}
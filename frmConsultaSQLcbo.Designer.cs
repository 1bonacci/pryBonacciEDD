namespace pryBonacciEstructuraDeDatos
{
    partial class frmConsultaSQLcbo
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
            this.lblOp = new System.Windows.Forms.Label();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.dgvSQL = new System.Windows.Forms.DataGridView();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(11, 13);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(338, 20);
            this.lblOp.TabIndex = 12;
            this.lblOp.Text = "Operacion a realizar en la base de datos:";
            // 
            // cboOperacion
            // 
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Location = new System.Drawing.Point(355, 12);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(336, 21);
            this.cboOperacion.TabIndex = 11;
            this.cboOperacion.SelectedIndexChanged += new System.EventHandler(this.cboOperacion_SelectedIndexChanged);
            // 
            // dgvSQL
            // 
            this.dgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQL.Location = new System.Drawing.Point(12, 147);
            this.dgvSQL.Name = "dgvSQL";
            this.dgvSQL.Size = new System.Drawing.Size(775, 234);
            this.dgvSQL.TabIndex = 10;
            // 
            // txtSQL
            // 
            this.txtSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQL.Location = new System.Drawing.Point(12, 38);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ReadOnly = true;
            this.txtSQL.Size = new System.Drawing.Size(775, 103);
            this.txtSQL.TabIndex = 9;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(697, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(90, 22);
            this.btnListar.TabIndex = 13;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // frmConsultaSQLcbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 404);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.dgvSQL);
            this.Controls.Add(this.txtSQL);
            this.Name = "frmConsultaSQLcbo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta SQL Combobox";
            this.Load += new System.EventHandler(this.frmConsultaSQLcbo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.DataGridView dgvSQL;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Button btnListar;
    }
}
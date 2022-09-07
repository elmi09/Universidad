namespace Universidad
{
    partial class Frmplan
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcarrera = new System.Windows.Forms.Label();
            this.txtaniocursado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_aniocursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_edicion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cboasignatura = new System.Windows.Forms.ComboBox();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.rbnprimer = new System.Windows.Forms.RadioButton();
            this.rbnsegundo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcarrera
            // 
            this.lblcarrera.AutoSize = true;
            this.lblcarrera.Location = new System.Drawing.Point(47, 72);
            this.lblcarrera.Name = "lblcarrera";
            this.lblcarrera.Size = new System.Drawing.Size(41, 13);
            this.lblcarrera.TabIndex = 0;
            this.lblcarrera.Text = "Carrera";
            // 
            // txtaniocursado
            // 
            this.txtaniocursado.AutoSize = true;
            this.txtaniocursado.Location = new System.Drawing.Point(24, 179);
            this.txtaniocursado.Name = "txtaniocursado";
            this.txtaniocursado.Size = new System.Drawing.Size(64, 13);
            this.txtaniocursado.TabIndex = 1;
            this.txtaniocursado.Text = "Añocursado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuatrismestre";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_asignatura,
            this.col_aniocursado,
            this.col_cuatrimestre,
            this.col_edicion});
            this.dgvDetalle.Location = new System.Drawing.Point(12, 233);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(444, 176);
            this.dgvDetalle.TabIndex = 8;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // col_id
            // 
            this.col_id.HeaderText = "id";
            this.col_id.Name = "col_id";
            this.col_id.Width = 30;
            // 
            // col_asignatura
            // 
            this.col_asignatura.HeaderText = "Asignatura";
            this.col_asignatura.Name = "col_asignatura";
            // 
            // col_aniocursado
            // 
            this.col_aniocursado.HeaderText = "Añocursado";
            this.col_aniocursado.Name = "col_aniocursado";
            // 
            // col_cuatrimestre
            // 
            this.col_cuatrimestre.HeaderText = "Cuatrimestre";
            this.col_cuatrimestre.Name = "col_cuatrimestre";
            // 
            // col_edicion
            // 
            this.col_edicion.HeaderText = "Edicion";
            this.col_edicion.Name = "col_edicion";
            this.col_edicion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_edicion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_edicion.Text = "Quitar";
            this.col_edicion.Width = 70;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(255, 176);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(166, 415);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 10;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(269, 415);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // cboasignatura
            // 
            this.cboasignatura.FormattingEnabled = true;
            this.cboasignatura.Location = new System.Drawing.Point(99, 141);
            this.cboasignatura.Name = "cboasignatura";
            this.cboasignatura.Size = new System.Drawing.Size(306, 21);
            this.cboasignatura.TabIndex = 12;
            // 
            // txtanio
            // 
            this.txtanio.Location = new System.Drawing.Point(99, 176);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(121, 20);
            this.txtanio.TabIndex = 13;
            // 
            // txtcarrera
            // 
            this.txtcarrera.Location = new System.Drawing.Point(99, 64);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(306, 20);
            this.txtcarrera.TabIndex = 14;
            // 
            // rbnprimer
            // 
            this.rbnprimer.AutoSize = true;
            this.rbnprimer.Location = new System.Drawing.Point(113, 105);
            this.rbnprimer.Name = "rbnprimer";
            this.rbnprimer.Size = new System.Drawing.Size(31, 17);
            this.rbnprimer.TabIndex = 15;
            this.rbnprimer.TabStop = true;
            this.rbnprimer.Text = "1";
            this.rbnprimer.UseVisualStyleBackColor = true;
            // 
            // rbnsegundo
            // 
            this.rbnsegundo.AutoSize = true;
            this.rbnsegundo.Location = new System.Drawing.Point(269, 105);
            this.rbnsegundo.Name = "rbnsegundo";
            this.rbnsegundo.Size = new System.Drawing.Size(31, 17);
            this.rbnsegundo.TabIndex = 16;
            this.rbnsegundo.TabStop = true;
            this.rbnsegundo.Text = "2";
            this.rbnsegundo.UseVisualStyleBackColor = true;
            // 
            // Frmplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.rbnsegundo);
            this.Controls.Add(this.rbnprimer);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.txtanio);
            this.Controls.Add(this.cboasignatura);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaniocursado);
            this.Controls.Add(this.lblcarrera);
            this.Name = "Frmplan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frmplan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcarrera;
        private System.Windows.Forms.Label txtaniocursado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox cboasignatura;
        private System.Windows.Forms.TextBox txtanio;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.RadioButton rbnprimer;
        private System.Windows.Forms.RadioButton rbnsegundo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_aniocursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn col_edicion;
    }
}


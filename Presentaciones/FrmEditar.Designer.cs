namespace Universidad.Presentaciones
{
    partial class FrmEditar
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
            this.cbocarrera = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.cboasignatura = new System.Windows.Forms.ComboBox();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.rbtprimercuatrimestre = new System.Windows.Forms.RadioButton();
            this.rbtsegundocuatrimestre = new System.Windows.Forms.RadioButton();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcarrera = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblasignatura = new System.Windows.Forms.Label();
            this.btngrabarcarrera = new System.Windows.Forms.Button();
            this.btngrabardetalle = new System.Windows.Forms.Button();
            this.btneditardetalle = new System.Windows.Forms.Button();
            this.btncancelardetalle = new System.Windows.Forms.Button();
            this.btneditarcarrera = new System.Windows.Forms.Button();
            this.btncancelarcarrera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // cbocarrera
            // 
            this.cbocarrera.FormattingEnabled = true;
            this.cbocarrera.Location = new System.Drawing.Point(99, 70);
            this.cbocarrera.Name = "cbocarrera";
            this.cbocarrera.Size = new System.Drawing.Size(507, 21);
            this.cbocarrera.TabIndex = 0;
            this.cbocarrera.SelectedIndexChanged += new System.EventHandler(this.cbocarrera_SelectedIndexChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(99, 106);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(415, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Location = new System.Drawing.Point(99, 184);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalle.Size = new System.Drawing.Size(709, 207);
            this.dgvdetalle.TabIndex = 2;
            this.dgvdetalle.SelectionChanged += new System.EventHandler(this.dgvdetalle_SelectionChanged);
            // 
            // cboasignatura
            // 
            this.cboasignatura.FormattingEnabled = true;
            this.cboasignatura.Location = new System.Drawing.Point(99, 455);
            this.cboasignatura.Name = "cboasignatura";
            this.cboasignatura.Size = new System.Drawing.Size(273, 21);
            this.cboasignatura.TabIndex = 3;
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(99, 413);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(148, 20);
            this.txtaño.TabIndex = 5;
            // 
            // rbtprimercuatrimestre
            // 
            this.rbtprimercuatrimestre.AutoSize = true;
            this.rbtprimercuatrimestre.Location = new System.Drawing.Point(421, 413);
            this.rbtprimercuatrimestre.Name = "rbtprimercuatrimestre";
            this.rbtprimercuatrimestre.Size = new System.Drawing.Size(112, 17);
            this.rbtprimercuatrimestre.TabIndex = 6;
            this.rbtprimercuatrimestre.TabStop = true;
            this.rbtprimercuatrimestre.Text = "PrimerCuatrimestre";
            this.rbtprimercuatrimestre.UseVisualStyleBackColor = true;
            // 
            // rbtsegundocuatrimestre
            // 
            this.rbtsegundocuatrimestre.AutoSize = true;
            this.rbtsegundocuatrimestre.Location = new System.Drawing.Point(421, 455);
            this.rbtsegundocuatrimestre.Name = "rbtsegundocuatrimestre";
            this.rbtsegundocuatrimestre.Size = new System.Drawing.Size(126, 17);
            this.rbtsegundocuatrimestre.TabIndex = 7;
            this.rbtsegundocuatrimestre.TabStop = true;
            this.rbtsegundocuatrimestre.Text = "SegundoCuatrimestre";
            this.rbtsegundocuatrimestre.UseVisualStyleBackColor = true;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(49, 109);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 8;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcarrera
            // 
            this.lblcarrera.AutoSize = true;
            this.lblcarrera.Location = new System.Drawing.Point(49, 70);
            this.lblcarrera.Name = "lblcarrera";
            this.lblcarrera.Size = new System.Drawing.Size(41, 13);
            this.lblcarrera.TabIndex = 9;
            this.lblcarrera.Text = "Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Año";
            // 
            // lblasignatura
            // 
            this.lblasignatura.AutoSize = true;
            this.lblasignatura.Location = new System.Drawing.Point(36, 459);
            this.lblasignatura.Name = "lblasignatura";
            this.lblasignatura.Size = new System.Drawing.Size(57, 13);
            this.lblasignatura.TabIndex = 12;
            this.lblasignatura.Text = "Asignatura";
            // 
            // btngrabarcarrera
            // 
            this.btngrabarcarrera.Location = new System.Drawing.Point(608, 109);
            this.btngrabarcarrera.Name = "btngrabarcarrera";
            this.btngrabarcarrera.Size = new System.Drawing.Size(75, 23);
            this.btngrabarcarrera.TabIndex = 13;
            this.btngrabarcarrera.Text = "Grabar";
            this.btngrabarcarrera.UseVisualStyleBackColor = true;
            this.btngrabarcarrera.Click += new System.EventHandler(this.btngrabarcarrera_Click);
            // 
            // btngrabardetalle
            // 
            this.btngrabardetalle.Location = new System.Drawing.Point(608, 432);
            this.btngrabardetalle.Name = "btngrabardetalle";
            this.btngrabardetalle.Size = new System.Drawing.Size(75, 23);
            this.btngrabardetalle.TabIndex = 14;
            this.btngrabardetalle.Text = "Grabar";
            this.btngrabardetalle.UseVisualStyleBackColor = true;
            this.btngrabardetalle.Click += new System.EventHandler(this.btngrabardetalle_Click);
            // 
            // btneditardetalle
            // 
            this.btneditardetalle.Location = new System.Drawing.Point(689, 432);
            this.btneditardetalle.Name = "btneditardetalle";
            this.btneditardetalle.Size = new System.Drawing.Size(75, 23);
            this.btneditardetalle.TabIndex = 15;
            this.btneditardetalle.Text = "Editar";
            this.btneditardetalle.UseVisualStyleBackColor = true;
            this.btneditardetalle.Click += new System.EventHandler(this.btneditardetalle_Click);
            // 
            // btncancelardetalle
            // 
            this.btncancelardetalle.Location = new System.Drawing.Point(770, 432);
            this.btncancelardetalle.Name = "btncancelardetalle";
            this.btncancelardetalle.Size = new System.Drawing.Size(75, 23);
            this.btncancelardetalle.TabIndex = 16;
            this.btncancelardetalle.Text = "Cancelar";
            this.btncancelardetalle.UseVisualStyleBackColor = true;
            this.btncancelardetalle.Click += new System.EventHandler(this.btncancelardetalle_Click);
            // 
            // btneditarcarrera
            // 
            this.btneditarcarrera.Location = new System.Drawing.Point(690, 108);
            this.btneditarcarrera.Name = "btneditarcarrera";
            this.btneditarcarrera.Size = new System.Drawing.Size(75, 23);
            this.btneditarcarrera.TabIndex = 17;
            this.btneditarcarrera.Text = "Editar";
            this.btneditarcarrera.UseVisualStyleBackColor = true;
            this.btneditarcarrera.Click += new System.EventHandler(this.btneditarcarrera_Click);
            // 
            // btncancelarcarrera
            // 
            this.btncancelarcarrera.Location = new System.Drawing.Point(771, 109);
            this.btncancelarcarrera.Name = "btncancelarcarrera";
            this.btncancelarcarrera.Size = new System.Drawing.Size(75, 23);
            this.btncancelarcarrera.TabIndex = 18;
            this.btncancelarcarrera.Text = "Cancelar";
            this.btncancelarcarrera.UseVisualStyleBackColor = true;
            this.btncancelarcarrera.Click += new System.EventHandler(this.btncancelarcarrera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = "Editar carrera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Editar detalles de la carrera:";
            // 
            // FrmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelarcarrera);
            this.Controls.Add(this.btneditarcarrera);
            this.Controls.Add(this.btncancelardetalle);
            this.Controls.Add(this.btneditardetalle);
            this.Controls.Add(this.btngrabardetalle);
            this.Controls.Add(this.btngrabarcarrera);
            this.Controls.Add(this.lblasignatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblcarrera);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.rbtsegundocuatrimestre);
            this.Controls.Add(this.rbtprimercuatrimestre);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.cboasignatura);
            this.Controls.Add(this.dgvdetalle);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.cbocarrera);
            this.Name = "FrmEditar";
            this.Text = "FrmEditar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbocarrera;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.ComboBox cboasignatura;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.RadioButton rbtprimercuatrimestre;
        private System.Windows.Forms.RadioButton rbtsegundocuatrimestre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblasignatura;
        private System.Windows.Forms.Button btngrabarcarrera;
        private System.Windows.Forms.Button btngrabardetalle;
        private System.Windows.Forms.Button btneditardetalle;
        private System.Windows.Forms.Button btncancelardetalle;
        private System.Windows.Forms.Button btneditarcarrera;
        private System.Windows.Forms.Button btncancelarcarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
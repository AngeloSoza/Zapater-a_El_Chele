namespace Final1Proyecto.Formularios
{
    partial class GestionCategoriasForm
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
            this.gpbCategoria = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.lblCategoríaEstado = new System.Windows.Forms.Label();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoriaNombre = new System.Windows.Forms.TextBox();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtCategoriaID = new System.Windows.Forms.TextBox();
            this.lblCategoriaID = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnReporteCategoria = new System.Windows.Forms.Button();
            this.gpbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCategoria
            // 
            this.gpbCategoria.Controls.Add(this.btnReporteCategoria);
            this.gpbCategoria.Controls.Add(this.btnEliminar);
            this.gpbCategoria.Controls.Add(this.btnEditar);
            this.gpbCategoria.Controls.Add(this.btnAgregar);
            this.gpbCategoria.Controls.Add(this.chkEstado);
            this.gpbCategoria.Controls.Add(this.lblCategoríaEstado);
            this.gpbCategoria.Controls.Add(this.txtDescripcionCategoria);
            this.gpbCategoria.Controls.Add(this.label1);
            this.gpbCategoria.Controls.Add(this.txtCategoriaNombre);
            this.gpbCategoria.Controls.Add(this.lblNombreCategoria);
            this.gpbCategoria.Controls.Add(this.txtCategoriaID);
            this.gpbCategoria.Controls.Add(this.lblCategoriaID);
            this.gpbCategoria.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCategoria.Location = new System.Drawing.Point(31, 27);
            this.gpbCategoria.Name = "gpbCategoria";
            this.gpbCategoria.Size = new System.Drawing.Size(536, 364);
            this.gpbCategoria.TabIndex = 0;
            this.gpbCategoria.TabStop = false;
            this.gpbCategoria.Text = "Categoría";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(276, 300);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 40);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(158, 300);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 40);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(40, 300);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 40);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(212, 235);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(79, 24);
            this.chkEstado.TabIndex = 11;
            this.chkEstado.Text = "Activa";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblCategoríaEstado
            // 
            this.lblCategoríaEstado.AutoSize = true;
            this.lblCategoríaEstado.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoríaEstado.Location = new System.Drawing.Point(22, 236);
            this.lblCategoríaEstado.Name = "lblCategoríaEstado";
            this.lblCategoríaEstado.Size = new System.Drawing.Size(67, 20);
            this.lblCategoríaEstado.TabIndex = 10;
            this.lblCategoríaEstado.Text = "Estado:";
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(182, 174);
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(208, 27);
            this.txtDescripcionCategoria.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripción:";
            // 
            // txtCategoriaNombre
            // 
            this.txtCategoriaNombre.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaNombre.Location = new System.Drawing.Point(210, 51);
            this.txtCategoriaNombre.Name = "txtCategoriaNombre";
            this.txtCategoriaNombre.Size = new System.Drawing.Size(178, 27);
            this.txtCategoriaNombre.TabIndex = 3;
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCategoria.Location = new System.Drawing.Point(22, 119);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(157, 20);
            this.lblNombreCategoria.TabIndex = 2;
            this.lblNombreCategoria.Text = "Nombre Categoría:";
            // 
            // txtCategoriaID
            // 
            this.txtCategoriaID.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaID.Location = new System.Drawing.Point(210, 116);
            this.txtCategoriaID.Name = "txtCategoriaID";
            this.txtCategoriaID.Size = new System.Drawing.Size(178, 27);
            this.txtCategoriaID.TabIndex = 1;
            // 
            // lblCategoriaID
            // 
            this.lblCategoriaID.AutoSize = true;
            this.lblCategoriaID.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaID.Location = new System.Drawing.Point(22, 58);
            this.lblCategoriaID.Name = "lblCategoriaID";
            this.lblCategoriaID.Size = new System.Drawing.Size(152, 20);
            this.lblCategoriaID.TabIndex = 0;
            this.lblCategoriaID.Text = "ID de la Categoría:";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(573, 37);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(356, 283);
            this.dgvCategorias.TabIndex = 2;
            // 
            // btnReporteCategoria
            // 
            this.btnReporteCategoria.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCategoria.Location = new System.Drawing.Point(394, 300);
            this.btnReporteCategoria.Name = "btnReporteCategoria";
            this.btnReporteCategoria.Size = new System.Drawing.Size(112, 40);
            this.btnReporteCategoria.TabIndex = 15;
            this.btnReporteCategoria.Text = "Reporte";
            this.btnReporteCategoria.UseVisualStyleBackColor = true;
            this.btnReporteCategoria.Click += new System.EventHandler(this.btnReporteCategoria_Click);
            // 
            // GestionCategoriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.gpbCategoria);
            this.Name = "GestionCategoriasForm";
            this.Text = "GestionCategorias";
            this.Load += new System.EventHandler(this.GestionCategoriasForm_Load);
            this.gpbCategoria.ResumeLayout(false);
            this.gpbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCategoria;
        private System.Windows.Forms.TextBox txtCategoriaNombre;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox txtCategoriaID;
        private System.Windows.Forms.Label lblCategoriaID;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lblCategoríaEstado;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnReporteCategoria;
    }
}
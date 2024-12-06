namespace Final1Proyecto.Formularios
{
    partial class AyudaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewTemas = new System.Windows.Forms.TreeView();
            this.richTextBoxContenido = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manual del Sistema de Gestión de Inventario para Tienda de Zapatos\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // treeViewTemas
            // 
            this.treeViewTemas.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewTemas.Location = new System.Drawing.Point(0, 23);
            this.treeViewTemas.Name = "treeViewTemas";
            this.treeViewTemas.Size = new System.Drawing.Size(195, 694);
            this.treeViewTemas.TabIndex = 1;
            this.treeViewTemas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTemas_AfterSelect);
            // 
            // richTextBoxContenido
            // 
            this.richTextBoxContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxContenido.Location = new System.Drawing.Point(195, 23);
            this.richTextBoxContenido.Name = "richTextBoxContenido";
            this.richTextBoxContenido.ReadOnly = true;
            this.richTextBoxContenido.Size = new System.Drawing.Size(733, 694);
            this.richTextBoxContenido.TabIndex = 2;
            this.richTextBoxContenido.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(477, 667);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(111, 38);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // AyudaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 717);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.richTextBoxContenido);
            this.Controls.Add(this.treeViewTemas);
            this.Controls.Add(this.label1);
            this.Name = "AyudaForm";
            this.Text = "AyudaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewTemas;
        private System.Windows.Forms.RichTextBox richTextBoxContenido;
        private System.Windows.Forms.Button btnCerrar;
    }
}
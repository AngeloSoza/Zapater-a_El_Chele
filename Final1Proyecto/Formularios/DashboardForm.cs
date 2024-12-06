using System;
using System.Windows.Forms;
using Final1Proyecto.Formularios;
using Final1Proyecto.Modelos;

namespace Final1Proyecto.Formularios
{
    public partial class DashboardForm : Form
    {
        private Usuario _usuario;
        public DashboardForm(Usuario usuario)
        {
            InitializeComponent();
            _usuario = new Usuario();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCategoriasForm categoriasForm = new GestionCategoriasForm();
            categoriasForm.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionProductosForm productosForm = new GestionProductosForm();
            productosForm.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionUsuariosForm usuariosForm = new GestionUsuariosForm();
            usuariosForm.ShowDialog();
        }

        private void gestionarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionVentasForm ventasForm = new GestionVentasForm();
            ventasForm.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaForm ayudaForm = new AyudaForm();
            ayudaForm.ShowDialog();
        }
    }
}

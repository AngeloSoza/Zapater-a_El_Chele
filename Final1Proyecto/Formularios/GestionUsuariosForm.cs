using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final1Proyecto.Ayudantes;
using Final1Proyecto.DataSet;
using Final1Proyecto.Modelos;
using Microsoft.Reporting.WinForms;

namespace Final1Proyecto.Formularios
{
    public partial class GestionUsuariosForm : Form
    {
        private List<Usuario> usuarios;
        public GestionUsuariosForm()
        {
            InitializeComponent();
            usuarios = FileManager.LeerDeArchivo<Usuario>("Binarios/usuarios.dat") ?? new List<Usuario>();
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarios;

            dgvUsuarios.Columns["Contraseña"].Visible = false;
        }
        private void GestionUsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioID.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                string.IsNullOrWhiteSpace(cbRol.Text) ||
                string.IsNullOrWhiteSpace(txtNombreUsuario.Text)
                )
            {
                MessageBox.Show("Por favor, llene todos los campos.");
                return;
            }

            //Verificar si el usuario ya existe
            if (usuarios.Any(u => u.UsuarioID == txtUsuarioID.Text))
            {
                MessageBox.Show("El usuario ya existe.");
                return;
            }

            //Agregar usuario
            var nuevoUsuario = new Usuario
            {
                UsuarioID = txtUsuarioID.Text,
                Nombre = txtNombreUsuario.Text,
                Rol = cbRol.Text,
                Activo = chkActivo.Checked,
                Contraseña = txtContraseña.Text

            };

            //Guardar usuario
            usuarios.Add(nuevoUsuario);
            FileManager.GuardarEnArchivo("Binarios/usuarios.dat", usuarios);

            //Limpiae los campos
            CargarUsuarios();
            LimpiarCampos();
            ActualizarDataGridView();
            MessageBox.Show("Usuario agregado correctamente.");
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario.");
                return;
            }

            var usuarioSeleccionado = dgvUsuarios.SelectedRows[0].DataBoundItem as Usuario;

            if (MessageBox.Show($"¿Está seguro de eliminar al usuario {usuarioSeleccionado.UsuarioID}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                usuarios.Remove(usuarioSeleccionado);
                FileManager.GuardarEnArchivo("Binarios/usuarios.dat", usuarios);
                CargarUsuarios();
                MessageBox.Show("Usuario eliminado correctamente.");
            }
            ActualizarDataGridView();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario.");
                return;
            }

            var usuarioSeleccionado = dgvUsuarios.SelectedRows[0].DataBoundItem as Usuario;

            usuarioSeleccionado.UsuarioID = txtUsuarioID.Text;
            usuarioSeleccionado.Nombre = txtNombreUsuario.Text;
            usuarioSeleccionado.Rol = cbRol.Text;
            usuarioSeleccionado.Activo = chkActivo.Checked;
            usuarioSeleccionado.Contraseña = txtContraseña.Text;

            FileManager.GuardarEnArchivo("Binarios/usuarios.dat", usuarios);
            CargarUsuarios();
            MessageBox.Show("Usuario actualizado correctamente.");
            ActualizarDataGridView();
        }

        private void LimpiarCampos()
        {
            txtUsuarioID.Clear();
            txtNombreUsuario.Clear();
            cbRol.SelectedIndex = -1;
            chkActivo.Checked = false;
            txtContraseña.Clear();
        }

        private void ActualizarDataGridView()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarios;
        }

        private void btnReporteUsuarios_Click(object sender, EventArgs e)
        {
            ReportDataSource dataSource = new ReportDataSource("dsUsuarios", usuarios);
            FrmReporteVenta reporte = new FrmReporteVenta();
            reporte.reportViewer1.LocalReport.DataSources.Clear();
            reporte.reportViewer1.LocalReport.DataSources.Add(dataSource);
            reporte.reportViewer1.LocalReport.ReportEmbeddedResource = "Final1Proyecto.Reportes.rptUsuarios.rdlc";
            reporte.reportViewer1.RefreshReport();
            reporte.ShowDialog();
        }
    }
}

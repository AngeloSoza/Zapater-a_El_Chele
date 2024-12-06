using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final1Proyecto.Modelos;

namespace Final1Proyecto.Formularios
{
    public partial class AyudaForm : Form
    {
        public AyudaForm()
        {
            InitializeComponent();
            CargarTemasDeAyuda();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeViewTemas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Introducción":
                    richTextBoxContenido.Text = "Este sistema está diseñado para facilitar la gestión de inventarios, ventas, usuarios y reportes en una tienda de zapatos.\nA continuación, se describe cómo utilizar cada pantalla y funcionalidad.";
                    break;

                case "Pantalla Principal":
                    richTextBoxContenido.Text = "Función: Permite iniciar sesión en el sistema.\n\nCampos Requeridos:\n- Usuario\n- Contraseña\n\nRoles Disponibles:\n- Administrador\n- Almacenista\n- Vendedor\n\nAcción:\nPresiona 'Iniciar Sesión' para acceder al menú principal.";
                    break;

                case "Pantalla de Menú":
                    richTextBoxContenido.Text = "Opciones Disponibles:\n- Gestión: Agregar Categorías, Agregar Productos, Registrar Usuarios.\n- Ventas: Gestionar Ventas.\n- Manual de uso: Muestra el manual.\n- Salir: Cerrar sesión.";
                    break;

                case "Agregar Categorías":
                    richTextBoxContenido.Text = "Campos Requeridos:\n- ID de Categoría.\n- Nombre de Categoría.\n- Descripción.\n- Estado.\n\nAcciones:\n- Agregar, Editar, Eliminar, Reportes.\n\nVisualización:\nUna tabla muestra las categorías registradas.";
                    break;

                case "Agregar Productos":
                    richTextBoxContenido.Text = "Campos Requeridos:\n- Nombre del Producto.\n- Precio Unitario.\n- Categoría.\n- Cantidad en Stock.\n\nAcciones:\n- Agregar, Editar, Eliminar, Reportes.\n\nVisualización:\nUna gráfica muestra los productos registrados.";
                    break;

                case "Gestión de Usuarios":
                    richTextBoxContenido.Text = "Campos Requeridos:\n- ID de Usuario.\n- Nombre del Usuario.\n- Rol.\n- Estado.\n- Contraseña.\n\nAcciones:\n- Agregar, Editar, Eliminar, Reportes.";
                    break;

                case "Ventas":
                    richTextBoxContenido.Text = "Gestión de Ventas:\n- Fecha.\n- Vendedor.\n- Producto.\n- Precio Unitario.\n- Cantidad.\n- Total (calculado automáticamente).\n\nAcciones:\n- Agregar, Editar, Eliminar, Ver Reporte.";
                    break;

                case "Reportes":
                    richTextBoxContenido.Text = "Reportes Personalizados:\n- Categorías más vendidas.\n- Resumen de ingresos.\n- Productos con menor stock.";
                    break;

                case "Salir":
                    richTextBoxContenido.Text = "Permite cerrar sesión de manera segura.\nAcción: Presionar 'Salir'.";
                    break;

                case "Conclusión":
                    richTextBoxContenido.Text = "Este manual sirve como guía para entender y utilizar el sistema de gestión de inventario.\nPara dudas o soporte técnico, consulte al administrador.";
                    break;

                default:
                    richTextBoxContenido.Text = "Seleccione un tema para ver más detalles.";
                    break;
            }
        }

        private void CargarTemasDeAyuda()
        {
            TreeNode introduccion = new TreeNode("Introducción");
            TreeNode pantallaPrincipal = new TreeNode("Pantalla Principal");
            TreeNode menuPrincipal = new TreeNode("Pantalla de Menú");
            TreeNode gestion = new TreeNode("Gestión");
            gestion.Nodes.Add("Agregar Categorías");
            gestion.Nodes.Add("Agregar Productos");
            gestion.Nodes.Add("Gestión de Usuarios");
            TreeNode ventas = new TreeNode("Ventas");
            TreeNode reportes = new TreeNode("Reportes");
            TreeNode salir = new TreeNode("Salir");
            TreeNode conclusion = new TreeNode("Conclusión");

            treeViewTemas.Nodes.Add(introduccion);
            treeViewTemas.Nodes.Add(pantallaPrincipal);
            treeViewTemas.Nodes.Add(menuPrincipal);
            treeViewTemas.Nodes.Add(gestion);
            treeViewTemas.Nodes.Add(ventas);
            treeViewTemas.Nodes.Add(reportes);
            treeViewTemas.Nodes.Add(salir);
            treeViewTemas.Nodes.Add(conclusion);
        }
    }
}

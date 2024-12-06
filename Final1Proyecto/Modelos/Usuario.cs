using System;

namespace Final1Proyecto.Modelos
{
    [Serializable]
    public class Usuario
    {
        public string UsuarioID { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; } // Administrador, Almacenista, Ventas
        public bool Activo { get; set; }
    }
}

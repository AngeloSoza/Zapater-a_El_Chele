using System;

namespace Final1Proyecto.Modelos
{
    [Serializable]
    public class Categoria
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}

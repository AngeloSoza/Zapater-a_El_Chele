using System;

namespace Final1Proyecto.Modelos
{
    [Serializable]
    public class Producto
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Stock { get; set; }
    }
}

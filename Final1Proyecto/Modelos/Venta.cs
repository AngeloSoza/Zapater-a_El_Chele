using System;

namespace Final1Proyecto.Modelos
{
    [Serializable]
    public class Venta
    {
        public string NombreProducto { get; set; }
        public int CantidadVendida { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaVenta { get; set; }
        public string Usuario { get; set; }

        public Venta(string nombreProducto, int cantidadVendida, decimal precioUnitario, DateTime fechaVenta, string usuario)
        {
            NombreProducto = nombreProducto; // Nombre del producto vendido
            CantidadVendida = cantidadVendida; // Cantidad de productos vendidos
            PrecioUnitario = precioUnitario; // Precio por unidad del producto
            Total = cantidadVendida * precioUnitario; // Calcula el total automáticamente
            FechaVenta = fechaVenta; // Fecha y hora de la venta
            Usuario = usuario; // Usuario que realiza la venta 
        }
    }
}

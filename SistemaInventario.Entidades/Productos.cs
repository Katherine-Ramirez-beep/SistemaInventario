namespace SistemaInventario.Entidades
{
    /// <summary>
    /// Representa un producto en el inventario.
    /// </summary>
    public class Productos : EntidadBase
    {
        /// <summary>
        /// Nombre del producto.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Precio unitario del producto.
        /// </summary>
        public decimal PrecioUnitario { get; set; }

        /// <summary>
        /// Identificador de la categoría asociada.
        /// </summary>
        public int CategoriaId { get; set; }

        /// <summary>
        /// Identificador del suplidor asociado.
        /// </summary>
        public int SuplidorId { get; set; }
    }
}
namespace SistemaInventario.Entidades
{
    /// <summary>
    /// Representa la entidad Categoria en el sistema.
    /// </summary>
    public class Categorias : EntidadBase
    {
        /// <summary>
        /// Nombre de la categoría.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Descripción detallada de la categoría.
        /// </summary>
        public string Descripcion { get; set; }
    }
}
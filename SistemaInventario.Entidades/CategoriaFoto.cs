namespace SistemaInventario.Entidades
{
    /// <summary>
    /// Representa una fotografía asociada a una categoría.
    /// </summary>
    public class CategoriaFoto : EntidadBase
    {
        /// <summary>
        /// Identificador de la categoría a la que pertenece la foto.
        /// </summary>
        public int CategoriaId { get; set; }

        /// <summary>
        /// Ruta o dirección de la imagen.
        /// </summary>
        public string RutaFoto { get; set; }
    }
}
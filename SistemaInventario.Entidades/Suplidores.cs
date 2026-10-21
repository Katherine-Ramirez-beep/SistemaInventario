namespace SistemaInventario.Entidades
{
    /// <summary>
    /// Representa a un suplidor de productos en el sistema.
    /// </summary>
    public class Suplidores : EntidadBase
    {
        /// <summary>
        /// Nombre de la empresa del suplidor.
        /// </summary>
        public string NombreEmpresa { get; set; }

        /// <summary>
        /// Nombre de la persona de contacto.
        /// </summary>
        public string NombreContacto { get; set; }

        /// <summary>
        /// Teléfono de contacto 
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Correo electrónico de contacto.
        /// </summary>
        public string CorreoElectronico { get; set; }
    }
}
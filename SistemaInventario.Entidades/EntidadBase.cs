using System;

namespace SistemaInventario.Entidades
{
    /// <summary>
    /// Clase base con los atributos comunes.
    /// </summary>
    public class EntidadBase
    {
        /// <summary>
        /// Identificador único del registro.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Estado del registro (true = activo, false = inactivo).
        /// </summary>
        public bool Activo { get; set; } = true;

        /// <summary>
        /// Fecha de creación del registro.
        /// </summary>
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        /// <summary>
        /// Fecha de modificación del registro.
        /// </summary>
        public DateTime FechaModificacion { get; set; }
    }
}
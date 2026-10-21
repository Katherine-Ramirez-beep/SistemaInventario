using System;
using System.IO;

namespace SistemaInventario.LogicaNegocio
{
    /// <summary>
    /// Guarda los errores en un archivo de texto.
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// Escribe el error en errores.log.
        /// </summary>
        public static void RegistrarError(Exception ex)
        {
            string texto = $"[{DateTime.Now}] {ex.Message}{Environment.NewLine}";
            File.AppendAllText("errores.log", texto);
        }
    }
}
using System.Text.RegularExpressions;

namespace SistemaInventario.LogicaNegocio
{
    /// <summary>
    /// Contiene las reglas y expresiones regulares para validar los datos ingresados.
    /// </summary>
    public static class Validador
    {
        /// <summary>
        /// Valida si un texto tiene formato de correo electrónico.
        /// </summary>
        public static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        /// <summary>
        /// Valida el formato de teléfono dominicano (809/829/849-XXX-XXXX).
        /// </summary>
        public static bool EsTelefonoDominicano(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono)) return false;
            return Regex.IsMatch(telefono, @"^(809|829|849)-\d{3}-\d{4}$");
        }

        /// <summary>
        /// Valida que el precio sea mayor a cero.
        /// </summary>
        public static bool EsPrecioValido(decimal precio)
        {
            return precio > 0;
        }

        /// <summary>
        /// Valida que un texto no esté vacío y cumpla la longitud requerida.
        /// </summary>
        public static bool EsTextoValido(string texto, int minLongitud, int maxLongitud)
        {
            if (string.IsNullOrWhiteSpace(texto)) return false;
            int largo = texto.Trim().Length;
            return largo >= minLongitud && largo <= maxLongitud;
        }
    }
}
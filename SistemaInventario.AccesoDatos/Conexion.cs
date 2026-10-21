using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace SistemaInventario.AccesoDatos
{
    /// <summary>
    /// Proporciona una única instancia de conexión a la base de datos aplicando el patrón Singleton.
    /// </summary>
    public class Conexion
    {
        private static Conexion _instancia;
        private readonly string _cadenaConexion;

        private Conexion()
        {
            _cadenaConexion = "Data Source=DESKTOP-QJNQ9RN\\KATHRASHEL; Initial Catalog=SistemaInventario; User ID=sa; Password=Mytaetae25uwu; Trust Server Certificate=True;";
        }

        /// <summary>
        /// Obtiene la instancia única de la clase Conexion.
        /// </summary>
        public static Conexion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Conexion();
                }
                return _instancia;
            }
        }

        /// <summary>
        /// Crea y retorna una nueva conexión a la base de datos SQL Server.
        /// </summary>
     
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }
    }
}

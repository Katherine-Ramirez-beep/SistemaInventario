using System.Collections.Generic;

namespace SistemaInventario.AccesoDatos
{
    /// <summary>
    /// Interfaz genérica para definir las operaciones CRUD en el patrón Repository.
    /// </summary>
    public interface IRepositorio<T> where T : class
    {
        /// <summary>
        /// Obtiene la lista de todos los registros activos.
        /// </summary>
        List<T> ObtenerTodos();

        /// <summary>
        /// Obtiene un registro por su identificador único.
        /// </summary>
        T ObtenerPorId(int id);

        /// <summary>
        /// Agrega un nuevo registro a la base de datos.
        /// </summary>
        bool Agregar(T entidad);

        /// <summary>
        /// Actualiza un registro existente en la base de datos.
        /// </summary>
        bool Actualizar(T entidad);

        /// <summary>
        /// Realiza el borrado lógico de un registro.
        /// </summary>
        bool EliminarLogico(int id);

        /// <summary>
        /// Obtiene la lista de registros eliminados para la papelera de reciclaje.
        /// </summary>
        List<T> ObtenerPapelera();

        /// <summary>
        /// Restaura un registro borrado lógicamente.
        /// </summary>
        bool Restaurar(int id);
    }
}
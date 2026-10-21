using System.Collections.Generic;
using System.Linq;
using SistemaInventario.AccesoDatos;
using SistemaInventario.Entidades;

namespace SistemaInventario.LogicaNegocio
{
    /// <summary>
    /// Servicio para la lógica de negocio y validaciones de Suplidores.
    /// </summary>
    public class SuplidorServicio
    {
        private readonly IRepositorio<Suplidores> _suplidorRepo;
        private readonly IRepositorio<Productos> _productoRepo;

        /// <summary>
        /// Constructor que aplica inyección de dependencias.
        /// </summary>
        public SuplidorServicio(IRepositorio<Suplidores> suplidorRepo, IRepositorio<Productos> productoRepo)
        {
            _suplidorRepo = suplidorRepo;
            _productoRepo = productoRepo;
        }

        /// <summary>
        /// Obtiene todos los suplidores activos.
        /// </summary>
        public List<Suplidores> ObtenerTodos()
        {
            try
            {
                return _suplidorRepo.ObtenerTodos();
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                throw;
            }
        }

        /// <summary>
        /// Valida y guarda un nuevo suplidor.
        /// </summary>
        public bool Guardar(Suplidores suplidor, out string mensajeError)
        {
            mensajeError = string.Empty;

            if (!Validador.EsTextoValido(suplidor.NombreEmpresa, 1, 100))
            {
                mensajeError = "El nombre de la empresa es obligatorio.";
                return false;
            }

            if (!Validador.EsTextoValido(suplidor.NombreContacto, 1, 100))
            {
                mensajeError = "El nombre del contacto es obligatorio.";
                return false;
            }

            if (!Validador.EsTelefonoDominicano(suplidor.Telefono))
            {
                mensajeError = "El teléfono debe tener un formato dominicano válido (809/829/849-XXX-XXXX).";
                return false;
            }

            if (!Validador.EsEmailValido(suplidor.CorreoElectronico))
            {
                mensajeError = "El correo electrónico no tiene un formato válido.";
                return false;
            }

            try
            {
                return _suplidorRepo.Agregar(suplidor);
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                mensajeError = "Error al guardar en la base de datos: " + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Elimina lógicamente un suplidor si no tiene productos activos vinculados.
        /// </summary>
        public bool EliminarLogico(int suplidorId, out string mensajeError)
        {
            mensajeError = string.Empty;

            try
            {
                bool tieneProductos = _productoRepo.ObtenerTodos().Any(p => p.SuplidorId == suplidorId && p.Activo);
                if (tieneProductos)
                {
                    mensajeError = "No se puede eliminar el suplidor porque tiene productos activos asociados.";
                    return false;
                }

                return _suplidorRepo.EliminarLogico(suplidorId);
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                mensajeError = "Error al intentar eliminar el suplidor: " + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Obtiene los suplidores en la papelera.
        /// </summary>
        public List<Suplidores> ObtenerPapelera()
        {
            try
            {
                return _suplidorRepo.ObtenerPapelera();
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                throw;
            }
        }

        /// <summary>
        /// Restaura un suplidor de la papelera.
        /// </summary>
        public bool Restaurar(int suplidorId)
        {
            try
            {
                return _suplidorRepo.Restaurar(suplidorId);
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                throw;
            }
        }
    }
}

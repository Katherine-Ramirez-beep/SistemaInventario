using System;
using System.Collections.Generic;
using System.Linq;
using SistemaInventario.AccesoDatos;
using SistemaInventario.Entidades;

namespace SistemaInventario.LogicaNegocio
{
    /// <summary>
    /// Servicio para la lógica de negocio y validaciones de Categorías.
    /// </summary>
    public class CategoriaServicio
    {
        private readonly IRepositorio<Categorias> _categoriaRepo;
        private readonly IRepositorio<Productos> _productoRepo;

        /// <summary>
        /// Constructor que aplica inyección de dependencias.
        /// </summary>
        public CategoriaServicio(IRepositorio<Categorias> categoriaRepo, IRepositorio<Productos> productoRepo)
        {
            _categoriaRepo = categoriaRepo;
            _productoRepo = productoRepo;
        }

        /// <summary>
        /// Obtiene todas las categorías activas.
        /// </summary>
        public List<Categorias> ObtenerTodos()
        {
            try
            {
                return _categoriaRepo.ObtenerTodos();
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                throw;
            }
        }

        /// <summary>
        /// Valida y guarda una nueva categoría.
        /// </summary>
        public bool Guardar(Categorias categoria, out string mensajeError)
        {
            mensajeError = string.Empty;

            if (!Validador.EsTextoValido(categoria.Nombre, 3, 100))
            {
                mensajeError = "El nombre de la categoría debe tener entre 3 y 100 caracteres.";
                return false;
            }

            if (!Validador.EsTextoValido(categoria.Descripcion, 1, 500))
            {
                mensajeError = "La descripción es obligatoria y no debe superar 500 caracteres.";
                return false;
            }

            try
            {
                return _categoriaRepo.Agregar(categoria);
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                mensajeError = "Error al guardar en la base de datos: " + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Elimina lógicamente una categoría si no tiene productos activos vinculados.
        /// </summary>
        public bool EliminarLogico(int categoriaId, out string mensajeError)
        {
            mensajeError = string.Empty;

            try
            {
                bool tieneProductos = _productoRepo.ObtenerTodos().Any(p => p.CategoriaId == categoriaId && p.Activo);
                if (tieneProductos)
                {
                    mensajeError = "No se puede eliminar la categoría porque tiene productos activos asociados.";
                    return false;
                }

                return _categoriaRepo.EliminarLogico(categoriaId);
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                mensajeError = "Error al intentar eliminar la categoría: " + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Obtiene las categorías enviadas a la papelera.
        /// </summary>
        public List<Categorias> ObtenerPapelera()
        {
            try
            {
                return _categoriaRepo.ObtenerPapelera();
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                throw;
            }
        }

        /// <summary>
        /// Restaura una categoría de la papelera.
        /// </summary>
        public bool Restaurar(int categoriaId)
        {
            try
            {
                return _categoriaRepo.Restaurar(categoriaId);
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                throw;
            }
        }
    }
}
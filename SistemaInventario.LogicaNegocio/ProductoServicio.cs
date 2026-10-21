using System;
using System.Collections.Generic;
using System.Linq;
using SistemaInventario.AccesoDatos;
using SistemaInventario.Entidades;

namespace SistemaInventario.LogicaNegocio
{
    /// <summary>
    /// Servicio para la lógica de negocio, validaciones y consultas LINQ de Productos.
    /// </summary>
    public class ProductoServicio
    {
        private readonly IRepositorio<Productos> _productoRepo;
        private readonly IRepositorio<Categorias> _categoriaRepo;
        private readonly IRepositorio<Suplidores> _suplidorRepo;

        /// <summary>
        /// Constructor que aplica inyección de dependencias.
        /// </summary>
        public ProductoServicio(
            IRepositorio<Productos> productoRepo,
            IRepositorio<Categorias> categoriaRepo,
            IRepositorio<Suplidores> suplidorRepo)
        {
            _productoRepo = productoRepo;
            _categoriaRepo = categoriaRepo;
            _suplidorRepo = suplidorRepo;
        }

        /// <summary>
        /// Obtiene todos los productos activos.
        /// </summary>
        public List<Productos> ObtenerTodos()
        {
            try
            {
                return _productoRepo.ObtenerTodos();
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                throw;
            }
        }

        /// <summary>
        /// Valida y guarda un nuevo producto.
        /// </summary>
        public bool Guardar(Productos producto, out string mensajeError)
        {
            mensajeError = string.Empty;

            if (!Validador.EsTextoValido(producto.Nombre, 1, 100))
            {
                mensajeError = "El nombre del producto es obligatorio.";
                return false;
            }

            if (!Validador.EsPrecioValido(producto.PrecioUnitario))
            {
                mensajeError = "El precio debe ser mayor a 0.";
                return false;
            }

            if (producto.CategoriaId <= 0)
            {
                mensajeError = "Debe seleccionar una categoría válida.";
                return false;
            }

            if (producto.SuplidorId <= 0)
            {
                mensajeError = "Debe seleccionar un suplidor válido.";
                return false;
            }

            try
            {
                return _productoRepo.Agregar(producto);
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                mensajeError = "Error al guardar el producto: " + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Elimina lógicamente un producto.
        /// </summary>
        public bool EliminarLogico(int productoId, out string mensajeError)
        {
            mensajeError = string.Empty;
            try
            {
                return _productoRepo.EliminarLogico(productoId);
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                mensajeError = "Error al eliminar el producto: " + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Obtiene la lista de productos en la papelera.
        /// </summary>
        public List<Productos> ObtenerPapelera() => _productoRepo.ObtenerPapelera();

        /// <summary>
        /// Restaura un producto de la papelera.
        /// </summary>
        public bool Restaurar(int productoId) => _productoRepo.Restaurar(productoId);

        /// <summary>
        /// Consulta LINQ 1: Búsqueda parcial por nombre ignorando mayúsculas y minúsculas.
        /// </summary>
        public List<Productos> BuscarPorNombre(string busqueda)
        {
            var productos = _productoRepo.ObtenerTodos();
            if (string.IsNullOrWhiteSpace(busqueda)) return productos;

            return productos
                .Where(p => p.Nombre.ToLower().Contains(busqueda.Trim().ToLower()))
                .ToList();
        }

        /// <summary>
        /// Consulta LINQ 2: Filtrado de productos por rango de precios y categoría.
        /// </summary>
        public List<Productos> FiltrarPorPrecioYCategoria(decimal precioMin, decimal precioMax, int? categoriaId)
        {
            return _productoRepo.ObtenerTodos()
                .Where(p => p.PrecioUnitario >= precioMin && p.PrecioUnitario <= precioMax)
                .Where(p => !categoriaId.HasValue || p.CategoriaId == categoriaId.Value)
                .ToList();
        }

        /// <summary>
        /// Consulta LINQ 3: Conteo de productos agrupados por categoría.
        /// </summary>
        public Dictionary<string, int> ObtenerConteoPorCategoria()
        {
            var productos = _productoRepo.ObtenerTodos();
            var categorias = _categoriaRepo.ObtenerTodos();

            return (from p in productos
                    join c in categorias on p.CategoriaId equals c.Id
                    group p by c.Nombre into grupo
                    select new { Categoria = grupo.Key, Conteo = grupo.Count() })
                   .ToDictionary(x => x.Categoria, x => x.Conteo);
        }

        /// <summary>
        /// Consulta LINQ 4: Promedio de precios por categoría.
        /// </summary>
        public Dictionary<string, decimal> ObtenerPromedioPrecioPorCategoria()
        {
            var productos = _productoRepo.ObtenerTodos();
            var categorias = _categoriaRepo.ObtenerTodos();

            return (from p in productos
                    join c in categorias on p.CategoriaId equals c.Id
                    group p by c.Nombre into grupo
                    select new { Categoria = grupo.Key, Promedio = grupo.Average(x => x.PrecioUnitario) })
                   .ToDictionary(x => x.Categoria, x => Math.Round(x.Promedio, 2));
        }

        /// <summary>
        /// Consulta LINQ 5: Top 5 de suplidores con mayor número de productos registrados.
        /// </summary>
        public List<string> ObtenerTop5SuplidoresConMasProductos()
        {
            var productos = _productoRepo.ObtenerTodos();
            var suplidores = _suplidorRepo.ObtenerTodos();

            return (from p in productos
                    join s in suplidores on p.SuplidorId equals s.Id
                    group p by s.NombreEmpresa into grupo
                    orderby grupo.Count() descending
                    select grupo.Key)
                   .Take(5)
                   .ToList();
        }
    }
}
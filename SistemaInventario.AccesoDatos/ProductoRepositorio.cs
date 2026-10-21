using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using SistemaInventario.Entidades;

namespace SistemaInventario.AccesoDatos
{
    /// <summary>
    /// Repositorio de acceso a datos para Productos.
    /// </summary>
    public class ProductoRepositorio : IRepositorio<Productos>
    {
        /// <summary>
        /// Obtiene todos los productos según su estado activo.
        /// </summary>
        private List<Productos> ObtenerPorEstado(bool activo)
        {
            List<Productos> lista = new List<Productos>();
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "SELECT ProductoId, Nombre, PrecioUnitario, CategoriaId, SuplidorId, Activo, FechaCreacion, FechaModificacion FROM Productos WHERE Activo = @Activo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Activo", activo);
                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Productos
                        {
                            Id = (int)dr["ProductoId"],
                            Nombre = dr["Nombre"].ToString(),
                            PrecioUnitario = (decimal)dr["PrecioUnitario"],
                            CategoriaId = (int)dr["CategoriaId"],
                            SuplidorId = (int)dr["SuplidorId"],
                            Activo = (bool)dr["Activo"],
                            FechaCreacion = (DateTime)dr["FechaCreacion"],
                            FechaModificacion = dr["FechaModificacion"] == DBNull.Value ? DateTime.Now : (DateTime)dr["FechaModificacion"]
                        });
                    }
                }
            }
            return lista;
        }

        /// <summary>
        /// Obtiene todos los productos activos.
        /// </summary>
        public List<Productos> ObtenerTodos() => ObtenerPorEstado(true);

        /// <summary>
        /// Obtiene los productos de la papelera.
        /// </summary>
        public List<Productos> ObtenerPapelera() => ObtenerPorEstado(false);

        /// <summary>
        /// Obtiene un producto activo por su Id.
        /// </summary>
        public Productos ObtenerPorId(int id)
        {
            Productos producto = null;
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "SELECT ProductoId, Nombre, PrecioUnitario, CategoriaId, SuplidorId, Activo, FechaCreacion, FechaModificacion FROM Productos WHERE ProductoId = @Id AND Activo = 1";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        producto = new Productos
                        {
                            Id = (int)dr["ProductoId"],
                            Nombre = dr["Nombre"].ToString(),
                            PrecioUnitario = (decimal)dr["PrecioUnitario"],
                            CategoriaId = (int)dr["CategoriaId"],
                            SuplidorId = (int)dr["SuplidorId"],
                            Activo = (bool)dr["Activo"],
                            FechaCreacion = (DateTime)dr["FechaCreacion"],
                            FechaModificacion = dr["FechaModificacion"] == DBNull.Value ? DateTime.Now : (DateTime)dr["FechaModificacion"]
                        };
                    }
                }
            }
            return producto;
        }

        /// <summary>
        /// Agrega un nuevo producto.
        /// </summary>
        public bool Agregar(Productos entidad)
        {
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "INSERT INTO Productos (Nombre, PrecioUnitario, CategoriaId, SuplidorId) VALUES (@Nombre, @PrecioUnitario, @CategoriaId, @SuplidorId)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                cmd.Parameters.AddWithValue("@PrecioUnitario", entidad.PrecioUnitario);
                cmd.Parameters.AddWithValue("@CategoriaId", entidad.CategoriaId);
                cmd.Parameters.AddWithValue("@SuplidorId", entidad.SuplidorId);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Actualiza un producto existente.
        /// </summary>
        public bool Actualizar(Productos entidad)
        {
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "UPDATE Productos SET Nombre = @Nombre, PrecioUnitario = @PrecioUnitario, CategoriaId = @CategoriaId, SuplidorId = @SuplidorId, FechaModificacion = GETDATE() WHERE ProductoId = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                cmd.Parameters.AddWithValue("@PrecioUnitario", entidad.PrecioUnitario);
                cmd.Parameters.AddWithValue("@CategoriaId", entidad.CategoriaId);
                cmd.Parameters.AddWithValue("@SuplidorId", entidad.SuplidorId);
                cmd.Parameters.AddWithValue("@Id", entidad.Id);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Cambia el estado activo/inactivo de un producto.
        /// </summary>
        private bool CambiarEstado(int id, bool estado)
        {
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "UPDATE Productos SET Activo = @Estado, FechaModificacion = GETDATE() WHERE ProductoId = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Elimina lógicamente un producto.
        /// </summary>
        public bool EliminarLogico(int id) => CambiarEstado(id, false);

        /// <summary>
        /// Restaura un producto de la papelera.
        /// </summary>
        public bool Restaurar(int id) => CambiarEstado(id, true);
    }
}
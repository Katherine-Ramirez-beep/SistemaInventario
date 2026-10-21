using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using SistemaInventario.Entidades;

namespace SistemaInventario.AccesoDatos
{
    /// <summary>
    /// Repositorio de acceso a datos para Categorías.
    /// </summary>
    public class CategoriaRepositorio : IRepositorio<Categorias>
    {
        /// <summary>
        /// Obtiene todas las categorías según su estado activo.
        /// </summary>
        private List<Categorias> ObtenerPorEstado(bool activo)
        {
            List<Categorias> lista = new List<Categorias>();
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "SELECT CategoriaId, Nombre, Descripcion, Activo, FechaCreacion, FechaModificacion FROM Categorias WHERE Activo = @Activo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Activo", activo);
                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Categorias
                        {
                            Id = (int)dr["CategoriaId"],
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
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
        /// Obtiene todas las categorías activas.
        /// </summary>
        public List<Categorias> ObtenerTodos() => ObtenerPorEstado(true);

        /// <summary>
        /// Obtiene las categorías de la papelera.
        /// </summary>
        public List<Categorias> ObtenerPapelera() => ObtenerPorEstado(false);

        /// <summary>
        /// Obtiene una categoría activa por su Id.
        /// </summary>
        public Categorias ObtenerPorId(int id)
        {
            Categorias categoria = null;
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "SELECT CategoriaId, Nombre, Descripcion, Activo, FechaCreacion, FechaModificacion FROM Categorias WHERE CategoriaId = @Id AND Activo = 1";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        categoria = new Categorias
                        {
                            Id = (int)dr["CategoriaId"],
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            Activo = (bool)dr["Activo"],
                            FechaCreacion = (DateTime)dr["FechaCreacion"],
                            FechaModificacion = dr["FechaModificacion"] == DBNull.Value ? DateTime.Now : (DateTime)dr["FechaModificacion"]
                        };
                    }
                }
            }
            return categoria;
        }

        /// <summary>
        /// Agrega una nueva categoría.
        /// </summary>
        public bool Agregar(Categorias entidad)
        {
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "INSERT INTO Categorias (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", entidad.Descripcion);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Actualiza una categoría existente.
        /// </summary>
        public bool Actualizar(Categorias entidad)
        {
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "UPDATE Categorias SET Nombre = @Nombre, Descripcion = @Descripcion, FechaModificacion = GETDATE() WHERE CategoriaId = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", entidad.Descripcion);
                cmd.Parameters.AddWithValue("@Id", entidad.Id);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Cambia el estado activo/inactivo de una categoría.
        /// </summary>
        private bool CambiarEstado(int id, bool estado)
        {
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "UPDATE Categorias SET Activo = @Estado, FechaModificacion = GETDATE() WHERE CategoriaId = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Elimina lógicamente una categoría.
        /// </summary>
        public bool EliminarLogico(int id) => CambiarEstado(id, false);

        /// <summary>
        /// Restaura una categoría de la papelera.
        /// </summary>
        public bool Restaurar(int id) => CambiarEstado(id, true);
    }
}
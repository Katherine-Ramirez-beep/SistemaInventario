using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using SistemaInventario.Entidades;

namespace SistemaInventario.AccesoDatos
{
    /// <summary>
    /// Repositorio de acceso a datos para Suplidores.
    /// </summary>
    public class SuplidorRepositorio : IRepositorio<Suplidores>
    {
        /// <summary>
        /// Obtiene todos los suplidores según su estado activo.
        /// </summary>
        private List<Suplidores> ObtenerPorEstado(bool activo)
        {
            List<Suplidores> lista = new List<Suplidores>();
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "SELECT SuplidorId, NombreEmpresa, NombreContacto, Telefono, CorreoEmail, Activo, FechaCreacion, FechaModificacion FROM Suplidores WHERE Activo = @Activo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Activo", activo);
                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Suplidores
                        {
                            Id = (int)dr["SuplidorId"],
                            NombreEmpresa = dr["NombreEmpresa"].ToString(),
                            NombreContacto = dr["NombreContacto"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            CorreoElectronico = dr["CorreoEmail"].ToString(),
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
        /// Obtiene todos los suplidores activos.
        /// </summary>
        public List<Suplidores> ObtenerTodos() => ObtenerPorEstado(true);

        /// <summary>
        /// Obtiene los suplidores de la papelera.
        /// </summary>
        public List<Suplidores> ObtenerPapelera() => ObtenerPorEstado(false);

        /// <summary>
        /// Obtiene un suplidor activo por su Id.
        /// </summary>
        public Suplidores ObtenerPorId(int id)
        {
            Suplidores suplidor = null;
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "SELECT SuplidorId, NombreEmpresa, NombreContacto, Telefono, CorreoEmail, Activo, FechaCreacion, FechaModificacion FROM Suplidores WHERE SuplidorId = @Id AND Activo = 1";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        suplidor = new Suplidores
                        {
                            Id = (int)dr["SuplidorId"],
                            NombreEmpresa = dr["NombreEmpresa"].ToString(),
                            NombreContacto = dr["NombreContacto"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            CorreoElectronico = dr["CorreoEmail"].ToString(),
                            Activo = (bool)dr["Activo"],
                            FechaCreacion = (DateTime)dr["FechaCreacion"],
                            FechaModificacion = dr["FechaModificacion"] == DBNull.Value ? DateTime.Now : (DateTime)dr["FechaModificacion"]
                        };
                    }
                }
            }
            return suplidor;
        }

        /// <summary>
        /// Agrega un nuevo suplidor.
        /// </summary>
        public bool Agregar(Suplidores entidad)
        {
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "INSERT INTO Suplidores (NombreEmpresa, NombreContacto, Telefono, CorreoEmail) VALUES (@NombreEmpresa, @NombreContacto, @Telefono, @CorreoEmail)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NombreEmpresa", entidad.NombreEmpresa);
                cmd.Parameters.AddWithValue("@NombreContacto", entidad.NombreContacto);
                cmd.Parameters.AddWithValue("@Telefono", entidad.Telefono);
                cmd.Parameters.AddWithValue("@CorreoEmail", entidad.CorreoElectronico);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Actualiza un suplidor existente.
        /// </summary>
        public bool Actualizar(Suplidores entidad)
        {
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "UPDATE Suplidores SET NombreEmpresa = @NombreEmpresa, NombreContacto = @NombreContacto, Telefono = @Telefono, CorreoEmail = @CorreoEmail, FechaModificacion = GETDATE() WHERE SuplidorId = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NombreEmpresa", entidad.NombreEmpresa);
                cmd.Parameters.AddWithValue("@NombreContacto", entidad.NombreContacto);
                cmd.Parameters.AddWithValue("@Telefono", entidad.Telefono);
                cmd.Parameters.AddWithValue("@CorreoEmail", entidad.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Id", entidad.Id);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Cambia el estado activo/inactivo de un suplidor.
        /// </summary>
        private bool CambiarEstado(int id, bool estado)
        {
            using (SqlConnection con = Conexion.Instancia.ObtenerConexion())
            {
                string query = "UPDATE Suplidores SET Activo = @Estado, FechaModificacion = GETDATE() WHERE SuplidorId = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Elimina lógicamente un suplidor.
        /// </summary>
        public bool EliminarLogico(int id) => CambiarEstado(id, false);

        /// <summary>
        /// Restaura un suplidor de la papelera.
        /// </summary>
        public bool Restaurar(int id) => CambiarEstado(id, true);
    }
}
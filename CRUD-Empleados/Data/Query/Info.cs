using Datos.Entidades;
using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Query
{
    public class Info
    {
        public List<Empleado> Listar() 
        {
            List<Empleado> empleados = new List<Empleado>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("select * from Empleado", oConexion);
                cmd.CommandType = CommandType.Text;

                try 
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            empleados.Add(new Empleado
                            {
                                IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Salario = Convert.ToDouble(dr["Salario"]),
                                Correo = dr["Correo"].ToString()
                            });
                        }
                    }
                    return empleados;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public Empleado Obtener(int IdEmpleado)
        {
            Empleado empleados = new Empleado();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerEmpleado", oConexion);
                cmd.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            empleados.IdEmpleado = Convert.ToInt32(dr["IdEmpleado"].ToString());
                            empleados.Nombre = dr["Nombre"].ToString();
                            empleados.Apellido = dr["Apellido"].ToString();
                            empleados.Salario = Convert.ToDouble(dr["Salario"].ToString());
                            empleados.Correo = dr["Correo"].ToString();
                        }
                    }
                    return empleados;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public bool Crear(Empleado empleado)
        {
            bool respuesta = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_CrearEmpleado", oConexion);
                cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("@Correo", empleado.Correo);
                cmd.Parameters.AddWithValue("@Salario", empleado.Salario);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0) respuesta = true;
                    return respuesta;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        public bool Editar(Empleado empleado)
        {
            bool respuesta = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_EditarEmpleado", oConexion);
                cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("@Correo", empleado.Correo);
                cmd.Parameters.AddWithValue("@Salario", empleado.Salario);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0) respuesta = true;
                    return respuesta;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        public bool Eliminar(int IdEmpleado)
        {
            bool respuesta = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarEmpleado", oConexion);
                cmd.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0) respuesta = true;
                    return respuesta;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public List<Empleado> Buscar(string dato)
        {
            List<Empleado> empleados = new List<Empleado>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_BuscarEmpleado", oConexion);
                cmd.Parameters.AddWithValue("@Nombre", dato);
                cmd.Parameters.AddWithValue("@Apellido", dato);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            empleados.Add(new Empleado
                            {
                                IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Salario = Convert.ToDouble(dr["Salario"]),
                                Correo = dr["Correo"].ToString()
                            });
                        }
                    }
                    return empleados;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

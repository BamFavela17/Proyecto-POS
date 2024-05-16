using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaDatos
{
    public class CD_Usuario
    {
        private ConexionSQL conn = new ConexionSQL();
        public bool Login(string user, string pass)
        {
            using (conn.AbrirConexion())
            {
                using (var command = new SqlCommand())
                {
                    string consulta = "select * from Usuarios where usuario = '" + user + "' and contraseña = '" + pass + "'";
                    SqlCommand cmd = new SqlCommand(consulta, conn.AbrirConexion());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.IdUser = reader.GetInt32(0);
                            UserCache.nombres = reader.GetString(1);
                            UserCache.apellidos = reader.GetString(2);
                            UserCache.idpuesto = reader.GetInt32(3);
                            UserCache.fhNacido = reader.GetDateTime(4);
                            UserCache.fhContratado = reader.GetDateTime(5);
                            UserCache.direccion = reader.GetString(6);
                            UserCache.telefono = reader.GetString(7);
                            UserCache.correo = reader.GetString(8);
                            UserCache.idturno = reader.GetInt32(9);
                            UserCache.usuario = reader.GetString(10);
                            UserCache.contraseña = reader.GetString(11);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        public void Cargo(int id)
        {
            using (conn.AbrirConexion())
            {
                using (var command = new SqlCommand())
                {
                    string consulta = "select * from Puestos where idPue = '" + id + "'";
                    SqlCommand cmd = new SqlCommand(consulta, conn.AbrirConexion());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.Cargousuario = reader.GetString(1);
                            UserCache.sueldo = reader.GetDecimal(2);
                        }

                    }
                }
            }
        }
    }
}

    




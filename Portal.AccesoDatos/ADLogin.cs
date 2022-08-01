using PortalProveedores.Portal.Entidades.ELogin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PortalProveedores.Portal.AccesoDatos.ADLogin
{
    public class ADLogin
    {
        private static string _cs = @"Server=svrdatabase\svripsa01; Initial Catalog=bdCompras; user id = sa; password = Ipsa1025";
        private SqlConnection cnn = new SqlConnection(_cs);

        internal List<ELogin> obtenerUsuarios() {
            List<ELogin> ListaUsuarios = new List<ELogin>();

            using (SqlConnection Conexion = cnn) {
                using (SqlCommand Comando = new SqlCommand("SELECT * FROM UsuariosPortalProveedores", Conexion)) {
                    Conexion.Open();

                    using (var Reader = Comando.ExecuteReader()) {
                        while (Reader.Read()) {
                            ELogin Temporal = new ELogin();
                            _ = Reader["Usuario"] == DBNull.Value ? Temporal.Usuario = "": Temporal.Usuario = Reader["Usuario"].ToString();
                            _ = Reader["Password"] == DBNull.Value ? Temporal.Password = "": Temporal.Password = Reader["Password"].ToString();
                            _ = Reader["CambioPassword"] == DBNull.Value ? Temporal.CambioPassword = false : Temporal.CambioPassword = (bool)Reader["CambioPassword"];
                            ListaUsuarios.Add(Temporal);
                        }
                    }

                }
            }

            return ListaUsuarios;
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalProveedores.Portal.Entidades.ELogin
{
    public class ELogin
    {

        public ELogin() { }
        public ELogin(ELogin login) {
            Usuario = login.Usuario;
            Password = login.Password;
            CambioPassword = login.CambioPassword;
        }

        public string Usuario { get; set; }
        public string Password { get; set; }
        public bool CambioPassword { get; set; }
    }

}
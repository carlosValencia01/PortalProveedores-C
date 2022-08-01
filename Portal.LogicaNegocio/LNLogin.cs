using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PortalProveedores.Portal.AccesoDatos.ADLogin;
using PortalProveedores.Portal.Entidades.ELogin;

namespace PortalProveedores.Portal.LogicaNegocio.LNLogin
{
    public class LNLogin
    {
        private ADLogin Conexion = new ADLogin();
        
        
        //Obtener
        public List<ELogin> obtenerUsuarios()
        {
            return Conexion.obtenerUsuarios();
        }

    }
}
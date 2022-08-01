using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortalProveedores.Portal.Entidades.ELogin;
using PortalProveedores.Portal.LogicaNegocio.LNLogin;

namespace PortalProveedores.Loggin
{
    public partial class Loggin : System.Web.UI.Page
    {
        LNLogin LNLogin = new LNLogin();
        private List<ELogin> ListaUsuarios;
        
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string Usuario = txtUserName.Text;
            string Password = txtPass.Text;

            //Ver si existe el usuario
            List<ELogin> Coincidencias = new List<ELogin>();
            foreach (ELogin usuarioTemporal in ListaUsuarios) {
                if (usuarioTemporal.Usuario == Usuario) {
                    Coincidencias.Add(usuarioTemporal);
                }
            }
            if (Coincidencias.Count == 0)
            {
                popupIniciarSesion.Text = "El usuario no existe.";
                popupIniciarSesion.ShowOnPageLoad = true;
            }
            else {
                //Validar contraseña
                if (Coincidencias[0].Password.Trim() == Password.Trim()) {
                    //Mandarlo a otra pagina
                    FormsAuthentication.RedirectFromLoginPage(Usuario, false);

                }
                else {                 
                    popupIniciarSesion.Text = "Contraseña Incorrecta.";
                    popupIniciarSesion.ShowOnPageLoad = true;  
                }
            }           
            //popupIniciarSesion.Text = ListaUsuarios.Count.ToString();
            //popupIniciarSesion.ShowOnPageLoad = true;            
        }

        protected void login_Load(object sender, EventArgs e)
        {
            ListaUsuarios = LNLogin.obtenerUsuarios();
            
        }

        //Eventos auxiliares

        

    }
}
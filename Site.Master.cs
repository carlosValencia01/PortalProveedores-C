using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace PortalProveedores
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void MainContent_Load(object sender, EventArgs e)
        {
            ASPxLabel2.Text = DateTime.Now.Year.ToString() + Server.HtmlDecode(" &copy; Copyright by Ingenio de Puga, S.A. de C.V.");
        }

        
    }
}
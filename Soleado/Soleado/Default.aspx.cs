using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace Soleado
{
    public partial class _Default : System.Web.UI.Page
    {
        protected string json;
        protected void Page_Load(object sender, EventArgs e)
        {   json="";
            if (Convert.ToString(Session["Bearer Token"]).Length > 10)
            {   
                Usuario auth = Global.db.auth(Session["Bearer Token"].ToString());
                List<Task> tt = Global.db.getTasks(auth);
                JavaScriptSerializer serializer = new JavaScriptSerializer(); //creating serializer instance of JavaScriptSerializer class
                json = serializer.Serialize((object)tt);
                titulo.Text = "Bienvenido " + auth.NombreDeUsuario+"!";
                
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}

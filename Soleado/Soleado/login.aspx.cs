using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Soleado
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Global.db.IsInit() == false) { Response.Redirect("register.aspx"); }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Bearer Token"] = Global.db.login(usuario.Text, clave.Text).Hash;
            Response.Redirect("Default.aspx");
        }
    }
}
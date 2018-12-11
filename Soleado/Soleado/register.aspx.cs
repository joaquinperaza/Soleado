using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Soleado
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario a;
            if (DropDownList3.SelectedValue == "GRATIS") {
                a = new Free();
            } else {
                a = new Premium();
            }
            a.NombreDeUsuario = usuario.Text;
            a.Mail = email.Text;
            a.Telefono = telefono.Text;
            a.Hash = Global.db.CalculateMD5Hash(clave.Text, a);
            
            
            Global.db.createUser(a);
            Session["Bearer Token"] = a.Hash;
            Response.Redirect("Default.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Soleado
{
    public partial class newTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Request.QueryString["lat"];
            TextBox2.Text = Request.QueryString["lon"];

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["Bearer Token"]).Length > 10)
            {
                try
                {   Usuario auth=Global.db.auth(Session["Bearer Token"].ToString());
                    ClimaTask t = new ClimaTask();
                    t.Name = localidad.Text;
                    t.Delay = Convert.ToInt32(DropDownList2.SelectedValue);
                    t.Metodo = Convert.ToInt32(DropDownList1.SelectedValue);
                    t.Lat = Convert.ToDouble(TextBox1.Text,  CultureInfo.GetCultureInfoByIetfLanguageTag("en-US"));
                    t.Lon = Convert.ToDouble(TextBox2.Text, CultureInfo.GetCultureInfoByIetfLanguageTag("en-US"));
                    t.Last = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds-t.Delay;
                    t.Usuario = auth;
                    auth.addTask(t);
                    Response.Redirect("Default.aspx");

                }
                catch (Exception e2) { 
                
                }
            }
            else {
                Response.Redirect("login.aspx");
            }

        }
    }
}
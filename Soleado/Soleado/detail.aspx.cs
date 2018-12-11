using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Soleado
{
    public partial class detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   Usuario auth = Global.db.auth(Session["Bearer Token"].ToString());
        Current clima = new Current();
         clima = auth.getData(Global.db.getTask(Request.QueryString["name"]).Lat, Global.db.getTask(Request.QueryString["name"]).Lon);
         titulo.Text = "Detalles para la ubicación: " + Request.QueryString["name"];
         
         temp.Text = clima.Temperature.Value.ToString() ?? "N/A";
         hum.Text = clima.Humidity.Value.ToString() ?? "N/A";
         presion.Text = clima.Pressure.Value.ToString() ?? "N/A";
         vientovel.Text = clima.Wind.Speed.Value.ToString() ?? "N/A";
         vientodir.Text = clima.Wind.Direction.Code ?? "N/A";
         nubosidad.Text = clima.Clouds.Value.ToString() ?? "N/A";
         climat.Text = clima.Weather.Value ?? "N/A";
         precipitaciones.Text = clima.Precipitation.Value.ToString() ?? "N/A";
         

        }
    }
}
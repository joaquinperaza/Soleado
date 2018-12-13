using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PARCIAL2018_Joaquin_Peraza
{
    public partial class _Default : System.Web.UI.Page
    {
        public DB2 db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DB2();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String cliente = TextBox1.Text;
            int total = 0;
            foreach (Factura f in db.facturas.FindAll(factura => factura.Cliente.Nombre == cliente)) {
                total += f.Importe;
            }
            TextBox2.Text = total.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            DateTime desde = Convert.ToDateTime(TextBox3.Text);
            DateTime hasta = Convert.ToDateTime(TextBox4.Text);
            foreach (Factura f in db.facturas)
            {
                if (f.Fecha > desde && f.Fecha < hasta)
                {
                    total += f.Importe;
                }
                TextBox5.Text = total.ToString();
            }
        }
        public DataTable locDataTable(String localidad)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Fecha", typeof(DateTime));
            table.Columns.Add("Numero", typeof(int));
            table.Columns.Add("Cliente", typeof(string));
            table.Columns.Add("Descripcion", typeof(string));
            table.Columns.Add("Importe", typeof(int));
            foreach (Factura item in db.facturas.FindAll(factura => factura.Cliente.Localidad == localidad && factura.Estado=="Pendiente"))
            {
                    DataRow row = table.NewRow();
                    row["Fecha"] = item.Fecha;
                    row["Numero"] = item.Numero;
                    row["Cliente"] = item.Cliente.Nombre;
                    row["Descripcion"] = item.Descripcion;
                    row["Importe"] = item.Importe;
                    table.Rows.Add(row);
                
            }
            return table;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = locDataTable(TextBox6.Text);
            GridView1.DataBind();
        }
    }
}

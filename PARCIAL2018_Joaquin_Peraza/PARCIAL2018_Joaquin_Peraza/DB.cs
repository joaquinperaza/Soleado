using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PARCIAL2018_Joaquin_Peraza
{
    public class DB2
    {
        public List<Factura> facturas=new List<Factura>();

       
        public List<Cliente> clientes= new List<Cliente>();

       
        public DB2 (){

            Cliente jose = new Cliente();
            jose.Nombre = "Jose";
            jose.Localidad = "Salto";
            jose.Documento = 123;
            jose.Mail = "jose@mail.com";
            Cliente jose2 = new Cliente();
            jose2.Nombre = "Jose2";
            jose2.Localidad = "Young";
            jose2.Documento = 123;
            jose2.Mail = "jose2@mail.com";
            Factura f1 = new Factura();
            f1.Cliente = jose;
            f1.Descripcion = "descripcion de factura";
            f1.Estado = "Paga";
            f1.Fecha = DateTime.Now;
            f1.Importe = 100;
            f1.Numero = 1001;
            Factura f2 = new Factura();
            f2.Cliente = jose2;
            f2.Descripcion = "descripcion de factura";
            f2.Estado = "Pendiente";
            f2.Fecha = DateTime.Now;
            f2.Importe = 200;
            f2.Numero = 1002;
            Factura f3 = new Factura();
            f3.Cliente = jose;
            f3.Descripcion = "descripcion de factura";
            f3.Estado = "Paga";
            f3.Fecha = DateTime.Now;
            f3.Importe = 500;
            f3.Numero = 1003;
            clientes.Add(jose);
            clientes.Add(jose2);
            facturas.Add(f1);
            facturas.Add(f2);
            facturas.Add(f3);
        }

    }
}
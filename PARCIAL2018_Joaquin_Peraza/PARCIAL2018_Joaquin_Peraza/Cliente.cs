using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PARCIAL2018_Joaquin_Peraza
{
    public class Cliente
    {
        private int documento;

        public int Documento
        {
            get { return documento; }
            set { documento = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String mail;

        public String Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        private String localidad;

        public String Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soleado
{
    public class Usuario
    {
        private String nombreDeUsuario;

        public String NombreDeUsuario
        {
            get { return nombreDeUsuario; }
            set { nombreDeUsuario = value; }
        }
        private String hash;

        public String Hash
        {
            get { return hash; }
            set { hash = value; }
        }
        private List<Ciudad> ciudades = new List<Ciudad>();

        public List<Ciudad> Ciudades
        {
            get { return ciudades; }
        }
        private int metodo;

        public int Metodo
        {
            get { return metodo; }
            set { metodo = value; }
        }
        private int ciclo;

        public int Ciclo
        {
            get { return ciclo; }
            set { ciclo = value; }
        }
        public virtual void addCiudad(Ciudad ciudad) {
            ciudades.Add(ciudad);
        }
        public void removeCiudad(Ciudad ciudad)
        {
            Ciudad c = ciudades.Find(x => x.name == ciudad.name);
            ciudades.Remove(c);
        }

    }
}
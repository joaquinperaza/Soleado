using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soleado
{
    public class ClimaTask
    {
        private int delay;

        public int Delay
        {
            get { return delay; }
            set { delay = value; }
        }
        private Usuario usuario;
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private Double lat;

        public Double Lat
        {
            get { return lat; }
            set { lat = value; }
        }
        private Double lon;

        public Double Lon
        {
            get { return lon; }
            set { lon = value; }
        }
        private int last;

        public int Last
        {
            get { return last; }
            set { last = value; }
        }
        private int metodo;

        public int Metodo
        {
            get { return metodo; }
            set { metodo = value; }
        }
        
    }
}
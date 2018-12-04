using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soleado
{
    public class Task
    {
        private int delay;

        public int Delay
        {
            get { return delay; }
            set { delay = value; }
        }
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private int last;

        public int Last
        {
            get { return last; }
            set { last = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soleado
{
    public class SoleadoManager
    {
        //-http://api.openweathermap.org/data/2.5/weather?lat=-32.2&lon=-58.1&appid=afb32eed00a636cea85290aa478f6365&lang=es
        private DB db = new DB();

        public void addUser(Usuario usuario) {
            db.users.Add(usuario);
            Task t = new Task();
            t.Delay = 24 * 60 * 60;
            t.Last = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds-t.Delay;
        }
        public void addCiudad(Usuario usuario, Ciudad ciudad) {
                db.users.Find(x => x.NombreDeUsuario == usuario.NombreDeUsuario).addCiudad(ciudad);      
        }
        public void removeCiudad(Usuario usuario, Ciudad ciudad)
        {
            db.users.Find(x => x.NombreDeUsuario == usuario.NombreDeUsuario).removeCiudad(ciudad);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Soleado
{
    public class SoleadoManager
    {
        //-http://api.openweathermap.org/data/2.5/weather?lat=-32.2&lon=-58.1&appid=afb32eed00a636cea85290aa478f6365&lang=es
        private DB db = new DB();
        public static String rutaArchivo = HttpRuntime.AppDomainAppPath + "db.xml";
        private void guardardb()
        {

            
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(DB));
            System.IO.StreamWriter file = new System.IO.StreamWriter(rutaArchivo);
            writer.Serialize(file, db);
            file.Close();
        }
        private void leerDB()
        {
            DB dbr = new DB();

            if (File.Exists(rutaArchivo))
            {
                System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(DB));
                System.IO.StreamReader file = new System.IO.StreamReader(rutaArchivo);
                dbr = (DB)reader.Deserialize(file);
                file.Close();
            }

            db = dbr;
        }
        public SoleadoManager()
        {
            leerDB();
        }
        public void addUser(Usuario usuario) {
            db.users.Add(usuario);
            Task t = new Task();
            t.Delay = 24 * 60 * 60;
            t.Last = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds-t.Delay;
            db.tasks.Add(t);
            guardardb();
        }
        public void addCiudad(Usuario usuario, Ciudad ciudad) {
                db.users.Find(x => x.NombreDeUsuario == usuario.NombreDeUsuario).addCiudad(ciudad);
                guardardb();
        }
        public void removeCiudad(Usuario usuario, Ciudad ciudad)
        {
            db.users.Find(x => x.NombreDeUsuario == usuario.NombreDeUsuario).removeCiudad(ciudad);
            guardardb();
        }
    }
}
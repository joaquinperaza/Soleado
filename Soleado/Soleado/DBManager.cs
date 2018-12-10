using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Soleado
{
    public class DBManager
    {
        private DB db = new DB();
        public static String rutaArchivo = HttpRuntime.AppDomainAppPath + "db2.xml";
        public void guardardb()
        {
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(DB));
            System.IO.StreamWriter file = new System.IO.StreamWriter(rutaArchivo);
            writer.Serialize(file, db);
            file.Close();
        }
        private void leerBarcos()
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
        public DBManager()
        {
            leerBarcos();
        }
        public Usuario Usuario (String username){
        return db.users.Find(b2 => b2.NombreDeUsuario == username);
        }
        public void createUser(Usuario u){
            db.users.Add(u);
            guardardb();
        }
        public string CalculateMD5Hash(string input)
        {
            if (input != null)
            {
                // step 1, calculate MD5 hash from input

                MD5 md5 = System.Security.Cryptography.MD5.Create();

                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

                byte[] hash = md5.ComputeHash(inputBytes);

                // step 2, convert byte array to hex string

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {

                    sb.Append(hash[i].ToString("X2"));

                }

                return sb.ToString();
            }
            else { return "NO TEXT"; }
        }
        public Usuario login(String usuario, String pwd){
            if (db.users.Find(b2 => b2.NombreDeUsuario == usuario).Hash == CalculateMD5Hash(pwd))
            {
                return db.users.Find(b2 => b2.NombreDeUsuario == usuario);
            }
            else
            {
                return null;
            }

        }
        public Usuario auth(String token)
        {
            return db.users.Find(b2 => b2.Hash == token);
        }
        public void addTask(Task t) {
            db.tasks.Add(t);
            guardardb();
        }
        public void addTaskFree(Task t) {
            if (db.tasks.FindAll(e2 => e2.Usuario.Hash == t.Usuario.Hash).Count < 5)
            {
                db.tasks.Add(t);
                guardardb();
            }
            else {
                throw new System.InvalidOperationException("Not premium");
            }
        }

        
        public void removeTask(Task t)
        {
            db.tasks.Remove(t);
            guardardb();
        }
        public List<Task> getTasks(Usuario u) {
            return db.tasks.FindAll(e2 => e2.Usuario.Hash == u.Hash);
        }
        
        public Current getData(Double lat,Double lon)
        {
            XmlDocument document = new XmlDocument();
            document.Load("http://api.openweathermap.org/data/2.5/weather?lat=" + lat.ToString() + "&lon=" + ToString() + "&appid=afb32eed00a636cea85290aa478f6365&lang=es&mode=xml");
            var serializer = new XmlSerializer(typeof(Current));
            object result;
            using (TextReader reader = new StringReader(document.InnerXml))
            {
                result = serializer.Deserialize(reader);
            }
            return (Current)result;
        }
        
        //(Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds-t.Delay

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
namespace Soleado
{
    [XmlInclude(typeof(Free))]
    [XmlInclude(typeof(Premium))]
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

        private String mail;

        public String Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        private String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

       
        public virtual void addTask(Task task) {
            Global.db.addTask(task);
        }
        public void removeCiudad(Task task)
        {
            Global.db.removeTask(task);
        }

    }
}
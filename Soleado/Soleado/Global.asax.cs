using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Threading.Tasks;
using System.Threading;

namespace Soleado
{
    public class Global : System.Web.HttpApplication
    {
        public static DBManager db;
        public static Usuario Usuario=new Usuario();
        public static Task task;
        void mytask() {
            try
            {
                System.Diagnostics.Debug.WriteLine("SOLEADO Background email alert");
                Global.db.AlertService();
                System.Diagnostics.Debug.WriteLine("SOLEADO Background email alert OK!");
                Thread.Sleep(5000);
                mytask();
            }
            catch {
                System.Diagnostics.Debug.WriteLine("SOLEADO Ejecutando recuperacion.");
                Random r=new Random();
                Thread.Sleep(r.Next(10000,30000));
                mytask();
            }
            
        }
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciarse la aplicación
            db = new DBManager();
            task = new Task(() => mytask());
            task.Start();
            
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Código que se ejecuta cuando se cierra la aplicación

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Código que se ejecuta al producirse un error no controlado

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando se inicia una nueva sesión

        }

        void Session_End(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando finaliza una sesión.
            // Nota: el evento Session_End se desencadena sólo cuando el modo sessionstate
            // se establece como InProc en el archivo Web.config. Si el modo de sesión se establece como StateServer 
            // o SQLServer, el evento no se genera.

        }

    }
}

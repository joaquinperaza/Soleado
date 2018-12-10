using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soleado
{
    public class Free:Usuario
    {
        public override void addTask(Task task) {
            Global.db.addTaskFree(task);

        }
    }
}
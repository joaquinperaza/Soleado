using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soleado
{
    public class Free:Usuario
    {
        public override void addTask(ClimaTask task) {
            Global.db.addTaskFree(task);

        }
        public override Current getData(Double lat, Double lon)
        {
            Current clima = Global.db.getData(lat, lon);
            clima.Wind.Direction.Code = "PRO";
            clima.Wind.Speed.Value = "PRO";
            clima.Clouds.Value = "PRO";
            clima.Precipitation.Value = "PRO";
            return clima;
        }
    }
}
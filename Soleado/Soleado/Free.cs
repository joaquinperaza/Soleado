using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soleado
{
    public class Free:Usuario
    {
        public override void addCiudad(Ciudad city) {
            if (this.Ciudades.Count < 5)
            {
                Ciudades.Add(city);
            }
            else {
                throw new System.InvalidOperationException("Not premium");
            }
        }
    }
}
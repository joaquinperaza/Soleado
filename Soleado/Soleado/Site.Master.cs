﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
namespace Soleado
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {   

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Global.db.IsInit() == true)
            {
                
            }
        }
    }
}

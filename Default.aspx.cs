﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace aspnet01
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Trace
            System.Diagnostics.Trace.TraceInformation("Received request at " + DateTime.Now + "!");
        }
    }
}

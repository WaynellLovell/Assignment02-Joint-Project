﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Assignment02
{
    public class Global : System.Web.HttpApplication
    {
        public static int RowID = 1;
        protected void Application_Start(object sender, EventArgs e)
        {
            Debug.WriteLine("Application Started....");
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            RowID = 1;
        }
    }
}
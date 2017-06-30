using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Proyecto36_ErroresPagina
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            string url = Request.Path;
            Exception ex = Server.GetLastError();

            StringBuilder text = new StringBuilder("Error que ha ocurrido: ");
            text.Append(ex.Message);
            text.Append(" en ");
            text.Append(url);

            /* en este objeto se instancia el log de windows */
            EventLog log = new EventLog();
            log.Source = "TAJAMARlog";
            log.WriteEntry(text.ToString(), EventLogEntryType.Error);


        }
    }
}
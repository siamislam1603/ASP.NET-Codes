using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Create Application State Variable
            Application["totalApplications"] = 0;
            Application["totalUserSessions"] = 0;
            //Increment TotalApplications by 1
            Application["totalApplications"] = (int)Application["totalApplications"] + 1;

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Incerement totalUserSessions by 1
            Application["totalUserSessions"] = (int)Application["totalUserSessions"] + 1;

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.
            //Decrement totalUserSessions by 1
            Application["totalUserSessions"] = (int)Application["totalUserSessions"] - 1;

        }

    }
}

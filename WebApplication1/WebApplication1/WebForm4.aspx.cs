using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Total Number Of Application: " + Application["totalApplications"]+"</br>");
            Response.Write("Number of users: " + Application["totalUserSessions"]);
        }
    }
}
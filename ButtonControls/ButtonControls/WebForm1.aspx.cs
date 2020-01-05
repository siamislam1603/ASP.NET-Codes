using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ButtonControls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button is clicked" + "<br/>");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Write("LinkButton is clicked" + "<br/>");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("ImageButton is clicked" + "<br/>");
        }
    }
}
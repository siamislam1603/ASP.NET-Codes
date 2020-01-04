using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlEvents
{
    public partial class CachedEvents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("cached Event:Textbox text changed" + "<br/>");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Write("Postback event:Button Clicked" + "<br/>");

        }
    }
}
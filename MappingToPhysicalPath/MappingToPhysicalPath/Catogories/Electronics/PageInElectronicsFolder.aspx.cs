using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MappingToPhysicalPath.Catogories.Electronics
{
    public partial class PageInElectronicsFolder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Currently Executing Path:<br/>" + Server.MapPath(".") + "<br/><br/>");
            Response.Write("Page Currently Executing it's Parent Path:<br/>" + Server.MapPath("..") + "<br/><br/>");
            Response.Write("Page Currently Executing it's Root Path:<br/>" + Server.MapPath("~") + "<br/><br/>");
            Response.Write("Page Currently Executing it's Root Path:<br/>" + Server.MapPath("../..") + "<br/><br/>");
        }
    }
}
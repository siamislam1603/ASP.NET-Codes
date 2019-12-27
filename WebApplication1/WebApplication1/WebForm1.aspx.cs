using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int clicksCount = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["Clicks"] != null)
            {
                clicksCount = (int)ViewState["Clicks"] + 1;
            }
            TextBox1.Text = clicksCount.ToString();
            ViewState["Clicks"] = clicksCount;
        }
    }
}
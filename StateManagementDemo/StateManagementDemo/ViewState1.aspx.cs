using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//when browser reopen this page doesn't retain the previous data like session_state/application state
namespace StateManagementDemo
{
    public partial class ViewState1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Clicks"] == null)
                {
                    ViewState["Clicks"] = 0;
                }
                TextBox1.Text = ViewState["Clicks"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clicksCount = (int)ViewState["Clicks"] + 1;
            TextBox1.Text = clicksCount.ToString();
            ViewState["Clicks"] = clicksCount;
        }
    }
}
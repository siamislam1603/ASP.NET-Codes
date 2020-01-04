using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IsPostBackProperty
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Load only once at inital state.if this condition isn't given dropdown list item duplicates
            if (!IsPostBack)
            {
                LoadCityDropDownList();
            }
        }
        public void LoadCityDropDownList()
        {
            ListItem li1 = new ListItem("Dhaka");
            DropDownList1.Items.Add(li1);

            ListItem li2 = new ListItem("Rajshahi");
            DropDownList1.Items.Add(li2);

            ListItem li3 = new ListItem("Khulna");
            DropDownList1.Items.Add(li3);
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("Selected Index from View State changed:" + DropDownList1.SelectedItem);
        }
    }
}
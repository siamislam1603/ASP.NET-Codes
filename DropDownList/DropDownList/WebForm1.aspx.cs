﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem li1 = new ListItem("Male", "M");
                ListItem li2 = new ListItem("Female", "F");
                DropDownList1.Items.Add(li1);
                DropDownList1.Items.Add(li2);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
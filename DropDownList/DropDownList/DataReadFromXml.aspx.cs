using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace DropDownList
{
    public partial class DataReadFromXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string physicalPath = Server.MapPath("Countries.xml");
            ds.ReadXml(physicalPath);
            DropDownList1.DataTextField = "CountryName";
            DropDownList1.DataValueField = "CountryId";
            DropDownList1.DataSource = ds;
            DropDownList1.DataBind();
            ListItem li = new ListItem("Select", "-1");
            DropDownList1.Items.Insert(0,li);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace CheckBoxControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GraduateCheckBox.Checked = true;
                PostGraduateCheckBox.Focus();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            if (GraduateCheckBox.Checked)
            {
                str.Append(" "+"Graduate");
            }
            if (PostGraduateCheckBox.Checked)
            {
                str.Append(" " + "Postgraduate");
            }
            if (DoctorateCheckBox.Checked)
            {
                str.Append(" " + "Doctorate");
            }
            Response.Write("Your selected education is" + str +"<br/>");
        }
    }
}
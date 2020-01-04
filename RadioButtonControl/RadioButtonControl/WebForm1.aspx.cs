using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButtonControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //after post event cache event triggers from vew_state
            if (MaleRadioButton.Checked)
            {
                Response.Write("Your checked gender:" + MaleRadioButton.Text);
            }
            else if (FemaleRadioButton.Checked)
            {
                Response.Write("Your checked gender:" + FemaleRadioButton.Text);
            }
            else if (UnknownRadioButton.Checked)
            {
                Response.Write("Your checked gender:" + UnknownRadioButton.Text);
            }
        }

        protected void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Your Selected Gender is " + MaleRadioButton.Text + "<br/>");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommandEvent
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CommandButton_Click(object sender, CommandEventArgs e)
        {
            //we can use same onCommand Event for buttons to handle their request in one event &
            //using commandName we can differentiate which button responded &
            //using commandArgument for the case of same commandName to differentiate a button
            switch (e.CommandName)
            {
                case "Print":
                    OutputLabel.Text = "Print Button clicked";
                    break;
                case "Delete":
                    OutputLabel.Text = "Delete Button Clicked";
                    break;
                case "Show":
                    if (e.CommandArgument.ToString() == "Top10")
                    {
                        OutputLabel.Text = "Top 10 button clicked";
                    }
                    else if (e.CommandArgument.ToString() == "Bottom10")
                    {
                        OutputLabel.Text = "Bottom 10 button clicked";
                    }
                    break;
                default:
                    OutputLabel.Text = "You don't have clicked any of this buttons";
                    break;
            }
        }
    }
}
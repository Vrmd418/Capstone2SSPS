using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capstone2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {
                Server.Transfer("LogIn.aspx", true);
            }
            else
            {
                UserObject obj = (UserObject)Session["Login"];

                ((Label)Master.FindControl("UserLabel")).Text = obj.Name.ToString();

                if (obj.Category.ToString() == "Freshman")
                {

                    ((Panel)Master.FindControl("FreshmanPanel")).Visible = true;
                }
                else if (obj.Category.ToString() == "Sophomore")
                {
                    ((Panel)Master.FindControl("SophmorePanel")).Visible = true;
                }
                else if (obj.Category.ToString() == "Admin")
                {
                    ((Panel)Master.FindControl("AdminPanel")).Visible = true;
                }
                else
                {
                    ((Panel)Master.FindControl("CommitteePanel")).Visible = true;
                }


            }
        }
    }
}
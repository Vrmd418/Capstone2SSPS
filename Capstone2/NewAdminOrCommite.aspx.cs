using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capstone2
{
    public partial class WebForm6 : System.Web.UI.Page
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
                ((Panel)Master.FindControl("AdminPanel")).Visible = true;
            }



        }
    }
}
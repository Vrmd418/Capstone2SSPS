using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capstone2
{
    public partial class WebForm10 : System.Web.UI.Page
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

                DataTable tbl = new DataTable();

                tbl.Columns.Add("tuid", typeof(String));
                tbl.Columns.Add("firstName", typeof(String));
                tbl.Columns.Add("lastName", typeof(String));
                tbl.Columns.Add("academicYear", typeof(String));
                tbl.Columns.Add("major", typeof(String));
                tbl.Columns.Add("rank", typeof(String));

                DataRow newRow = tbl.NewRow();

                newRow["tuid"] = "tuu99999";
                newRow["firstName"] = "Brent";
                newRow["lastName"] = "Baskin";
                newRow["academicYear"] = "2014-2015";
                newRow["major"] = "CIS";
                newRow["rank"] = 5;

                tbl.Rows.Add(newRow);

                DataRow newRow1 = tbl.NewRow();

                newRow1["tuid"] = "tuu99999";
                newRow1["firstName"] = "Vince";
                newRow1["lastName"] = "Dixon";
                newRow1["academicYear"] = "2014-2015";
                newRow1["major"] = "CIS";
                newRow1["rank"] = 5;

                tbl.Rows.Add(newRow1);

                DataRow newRow2 = tbl.NewRow();

                newRow2["tuid"] = "tuu99999";
                newRow2["firstName"] = "Josh";
                newRow2["lastName"] = "Roach";
                newRow2["academicYear"] = "2014-2015";
                newRow2["major"] = "CIS";
                newRow2["rank"] = 5;

                tbl.Rows.Add(newRow2);

                ViewHistoricalGridView.DataSource = tbl;
                ViewHistoricalGridView.DataBind();
            }
        }
    }
}
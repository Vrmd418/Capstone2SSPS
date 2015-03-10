using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capstone2
{
    public partial class WebForm13 : System.Web.UI.Page
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

                if (!IsPostBack)
                {
                    StoredProcedures sp = new StoredProcedures();
                    int yearCode2 = 2014;
                    String yearCode = sp.GetYearCode();

                    if (yearCode != "")
                    {
                        yearCode2 = int.Parse(yearCode.Substring(0, 4));

                    }

                    DataTable tbl = new DataTable();

                    tbl.Columns.Add("Value", typeof(String));
                    tbl.Columns.Add("Text", typeof(String));

                    for (int i = 1; i < 10; i++)
                    {
                        DataRow row = tbl.NewRow();

                        String yearCode3 = String.Concat(yearCode2 + i, " - ", (yearCode2 + i) + 1);

                        row["Value"] = yearCode3;
                        row["Text"] = yearCode3;

                        tbl.Rows.Add(row);
                    }

                    AcademicYearList.DataSource = tbl;
                    AcademicYearList.DataTextField = "Text";
                    AcademicYearList.DataValueField = "Value";
                    AcademicYearList.DataBind();


                }
                Calendar1.SelectionChanged += new EventHandler(this.Selection_Changed);
            }
        }
        private void Selection_Changed(object sender, EventArgs e)
        {

            String date = String.Format("{0:M/d/yyyy}", Calendar1.SelectedDate);
                        
            Calendar1.Visible = false;
            
            String deadline = (String) Session["Deadline"];

            if (deadline == "Application")
            {

                ApplicationDeadlineTextBox.Text = date;
            }

            else if (deadline == "Document")
            {
                DocumentDeadlineTextBox.Text = date;

            }
            else
            {
                RankDeadlineTextBox.Text = date;
            
            }
        }

        protected void ApplicationDeadlineLink_OnClick (object sender, EventArgs e)
        {
            Calendar1.SelectedDates.Clear();
            Calendar1.Visible = true;
            Session["Deadline"] = "Application";
        }
        protected void DocumentDeadlineLink_OnClick(object sender, EventArgs e)
        {
            Calendar1.SelectedDates.Clear();
            Calendar1.Visible = true;
            Session["Deadline"] = "Document";
        }
        protected void RankDeadlineLink_OnClick(object sender, EventArgs e)
        {
            Calendar1.SelectedDates.Clear();
            Calendar1.Visible = true;
            Session["Deadline"] = "Rank";
        }
        protected void SubmitButton_OnClick(object sender, EventArgs e)
        {

            StoredProcedures sp = new StoredProcedures();

           sp.CreateTerm(AcademicYearList.SelectedValue, ApplicationDeadlineTextBox.Text, DocumentDeadlineTextBox.Text, RankDeadlineTextBox.Text); 
        }
    }
}
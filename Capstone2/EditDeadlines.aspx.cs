﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capstone2
{
    public partial class WebForm14 : System.Web.UI.Page
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

                DataSet ds = sp.GetDeadlines();

                DateTime applicationDate = DateTime.Parse(ds.Tables[0].Rows[0][1].ToString());
                DateTime documentDate = DateTime.Parse(ds.Tables[0].Rows[0][2].ToString());
                DateTime rankDate = DateTime.Parse(ds.Tables[0].Rows[0][3].ToString());
                Session["AcademicYear"] = ds.Tables[0].Rows[0][0].ToString();

                AcademicYearLabel.Text = String.Concat("Acaademic Year ", ds.Tables[0].Rows[0][0].ToString());
                ApplicationDeadlineTextBox.Text = applicationDate.ToString("d/MM/yyyy");
                DocumentDeadlineTextBox.Text = documentDate.ToString("d/MM/yyyy");
                RankDeadlineTextBox.Text = rankDate.ToString("d/MM/yyyy");
                
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

                


            }
            Calendar1.SelectionChanged += new EventHandler(this.Selection_Changed);
            }
        }
        private void Selection_Changed(object sender, EventArgs e)
        {

            String date = String.Format("{0:M/d/yyyy}", Calendar1.SelectedDate);

            Calendar1.Visible = false;

            String deadline = (String)Session["Deadline"];

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

        protected void ApplicationDeadlineLink_OnClick(object sender, EventArgs e)
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
            String academicYear = (String)Session["AcademicYear"];
            sp.UpdateDeadlines(academicYear, ApplicationDeadlineTextBox.Text, DocumentDeadlineTextBox.Text, RankDeadlineTextBox.Text);
        }
    }
}
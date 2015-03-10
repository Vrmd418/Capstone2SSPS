using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.Text.RegularExpressions;
//using System.Drawing;
using System.IO;

namespace Capstone2
{
    public partial class WebForm5 : System.Web.UI.Page
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

                ((Label)Master.FindControl("UserLabel")).Text = obj.TUID.ToString();

                ((Panel)Master.FindControl("SophmorePanel")).Visible = true;
            }

        }
        protected void Page_Init(object sender, EventArgs e)
        {
            StoredProcedures storedProcs = new StoredProcedures();
            ApplicationFunctions appFuncs = new ApplicationFunctions();

            //CHANGE WHEN WE GET ID FROM LOGIN
            DataSet myDS = storedProcs.SelectApplication("App123");

            Application currApp = appFuncs.RepopulateApplicationObj(myDS);

            MobilePhoneTextBox.Text = currApp.MobileNumber;
            CitizenshipDropDownList.SelectedValue = currApp.Citizenship;
            HealthScholarsDropDownList.SelectedValue = currApp.IsMedicalStudent;
            InterestsTextBox.Text = currApp.Question1;
            ResearchProjectsTextBox.Text = currApp.Question2;
            AccomplishmentTextBox.Text = currApp.Question3;
            Essay1TextBox.Text = currApp.Essay1;
            Essay2TextBox.Text = currApp.Essay2;
            Essay3TextBox.Text = currApp.Essay3;


        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            StoredProcedures storedProcs = new StoredProcedures();
            ApplicationFunctions appFuncs = new ApplicationFunctions();

            //CHANGE WHEN WE GET ID FROM LOGIN
            DataSet myDS = storedProcs.SelectApplication("App123");

            Application currApp = appFuncs.RepopulateApplicationObj(myDS);

            //Phone num validation
            bool valid = Regex.IsMatch(MobilePhoneTextBox.Text, @"^[0-9]+$");
            if (MobilePhoneTextBox.Text.Length == 10 && valid == true)
            {
                currApp.MobileNumber = MobilePhoneTextBox.Text;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Enter valid 10-digit phone number');", true);
            }
            currApp.Citizenship = CitizenshipDropDownList.SelectedValue;
            currApp.IsMedicalStudent = HealthScholarsDropDownList.SelectedValue;
            currApp.Question1 = InterestsTextBox.Text;
            currApp.Question2 = ResearchProjectsTextBox.Text;
            currApp.Question3 = AccomplishmentTextBox.Text;
            string[] words1 = Essay1TextBox.Text.Split(' ');
            string[] words2 = Essay2TextBox.Text.Split(' ');
            string[] words3 = Essay3TextBox.Text.Split(' ');
            if (words1.Length > 250 || words2.Length > 250 || words3.Length > 250)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Word limit exceeded for one or more essay questions!');", true);
            }
            else
            {
                currApp.Essay1 = Essay1TextBox.Text;
                currApp.Essay2 = Essay2TextBox.Text;
                currApp.Essay3 = Essay3TextBox.Text;
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Application was saved successfully!');", true);
                storedProcs.UpdateApplication(currApp);
            }

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (MobilePhoneTextBox.Text.Length == 0 || MajorDropDownList.SelectedIndex == 0 || CitizenshipDropDownList.SelectedIndex == 0 || HealthScholarsDropDownList.SelectedIndex == 0 || InterestsTextBox.Text.Length == 0
                || ResearchProjectsTextBox.Text.Length == 0 || AccomplishmentTextBox.Text.Length == 0 || Essay1TextBox.Text.Length == 0 || Essay2TextBox.Text.Length == 0 ||
                Essay3TextBox.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Check that all fields are complete!');", true);
            }

            else
            {
                StoredProcedures storedProcs = new StoredProcedures();
                ApplicationFunctions appFuncs = new ApplicationFunctions();

                //CHANGE WHEN WE GET ID FROM LOGIN
                DataSet myDS = storedProcs.SelectApplication("App123");

                Application currApp = appFuncs.RepopulateApplicationObj(myDS);

                //Phone num validation
                bool valid = Regex.IsMatch(MobilePhoneTextBox.Text, @"^[0-9]+$");
                if (MobilePhoneTextBox.Text.Length == 10 && valid == true)
                {
                    currApp.MobileNumber = MobilePhoneTextBox.Text;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Enter valid 10-digit phone number');", true);
                }
                currApp.Citizenship = CitizenshipDropDownList.SelectedValue;
                currApp.IsMedicalStudent = HealthScholarsDropDownList.SelectedValue;
                currApp.Question1 = InterestsTextBox.Text;
                currApp.Question2 = ResearchProjectsTextBox.Text;
                currApp.Question3 = AccomplishmentTextBox.Text;
                //currApp.Question4 = UniversityTextBox.Text;
                string[] words1 = Essay1TextBox.Text.Split(' ');
                string[] words2 = Essay2TextBox.Text.Split(' ');
                string[] words3 = Essay3TextBox.Text.Split(' ');
                if (words1.Length > 250 || words2.Length > 250 || words3.Length > 250)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Word limit exceeded for one or more essay questions!');", true);
                }
                else
                {
                    currApp.Essay1 = Essay1TextBox.Text;
                    currApp.Essay2 = Essay2TextBox.Text;
                    currApp.Essay3 = Essay3TextBox.Text;
                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Application was submitted successfully!');", true);
                    storedProcs.UpdateApplication(currApp);
                }
            }

        }

        protected void CitizenshipDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CitizenshipDropDownList.SelectedValue == "Other")
            {
                txtCitizenOther.Visible = true;
            }
            else
            {
                txtCitizenOther.Visible = false;
            }
        }

        protected void ToPDF_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";

            // Change "studentxapp" to student's name or Accessnet username
            string attachment = "attachment; filename=" + "studentxapp" + ".pdf";
            Response.AddHeader("content-disposition", attachment);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Document doc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);

            PdfWriter.GetInstance(doc, Response.OutputStream);
            doc.Open();
            doc.Add(new Paragraph(MobilePhoneLabel.Text, FontFactory.GetFont("Times", 12, Font.BOLD)));
            doc.Add(new Paragraph(MobilePhoneTextBox.Text, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
            doc.Add(new Paragraph(" "));

            doc.Add(new Paragraph(MajorLabel.Text, FontFactory.GetFont("Arial", 12, Font.BOLD)));
            doc.Add(new Paragraph(MajorDropDownList.SelectedValue, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
            doc.Add(new Paragraph(" "));

            doc.Add(new Paragraph(CitizenshipLabel.Text, FontFactory.GetFont("Arial", 12, Font.BOLD)));
            doc.Add(new Paragraph(CitizenshipDropDownList.SelectedValue, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
            doc.Add(new Paragraph(" "));
            //if (txtCitizenOther.Visible==true)
            //{
            // doc.Add(new Paragraph((txtCitizenOther.Text, FontFactory.GetFont("Arial", 12, Font.NORMAL )));}

            doc.Add(new Paragraph(HealthScholarsLabel.Text, FontFactory.GetFont("Arial", 12, Font.BOLD)));
            doc.Add(new Paragraph(HealthScholarsDropDownList.SelectedValue, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
            doc.Add(new Paragraph(" "));

            doc.Add(new Paragraph(InterestsLabel.Text, FontFactory.GetFont("Arial", 12, Font.BOLD)));
            doc.Add(new Paragraph(InterestsTextBox.Text, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
            doc.Add(new Paragraph(" "));

            doc.Add(new Paragraph(ResearchProjectsLabel.Text, FontFactory.GetFont("Arial", 12, Font.BOLD)));
            doc.Add(new Paragraph(ResearchProjectsTextBox.Text, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
            doc.Add(new Paragraph(" "));

            doc.Add(new Paragraph(AccomplishmentLabel.Text, FontFactory.GetFont("Arial", 12, Font.BOLD)));
            doc.Add(new Paragraph(AccomplishmentTextBox.Text, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
            doc.Add(new Paragraph(" "));

            //doc.Add(new Paragraph(UniversityLabel.Text, FontFactory.GetFont("Arial", 12, Font.BOLD)));
            //doc.Add(new Paragraph(UniversityTextBox.Text, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
            //doc.Add(new Paragraph(" "));

            doc.Add(new Paragraph(EssayQuestionsLabel.Text, FontFactory.GetFont("Arial", 16, Font.BOLD)));
            doc.Add(new Paragraph(" "));

            doc.Add(new Paragraph(Essay1Label.Text, FontFactory.GetFont("Arial", 12, Font.BOLD)));
            doc.Add(new Paragraph(Essay1TextBox.Text, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
            doc.Add(new Paragraph(" "));

            doc.Add(new Paragraph(Essay2Label.Text, FontFactory.GetFont("Arial", 12, Font.BOLD)));
            doc.Add(new Paragraph(Essay2TextBox.Text, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
            doc.Add(new Paragraph(" "));

            doc.Add(new Paragraph(Essay3Label.Text, FontFactory.GetFont("Arial", 12, Font.BOLD)));
            doc.Add(new Paragraph(Essay3TextBox.Text, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
            doc.Add(new Paragraph(" "));

            doc.Close();
            Response.Write(doc);
            Response.End();
        }
    }
}
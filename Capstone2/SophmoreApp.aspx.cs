using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

                ((Label)Master.FindControl("UserLabel")).Text = obj.Name.ToString();

                ((Panel)Master.FindControl("SophmorePanel")).Visible = true;
            }

        }
        protected void Page_Init(object sender, EventArgs e)
        {
            StoredProcedures storedProcs = new StoredProcedures();
            ApplicationFunctions appFuncs = new ApplicationFunctions();

            //CHANGE WHEN WE GET ID FROM LOGIN
            DataSet myDS = storedProcs.SelectApplication("1");

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

            currApp.MobileNumber = MobilePhoneTextBox.Text;
            currApp.Citizenship = CitizenshipDropDownList.SelectedValue;
            currApp.IsMedicalStudent = HealthScholarsDropDownList.SelectedValue;
            currApp.Question1 = InterestsTextBox.Text;
            currApp.Question2 = ResearchProjectsTextBox.Text;
            currApp.Question3 = AccomplishmentTextBox.Text;
            currApp.Essay1 = Essay1TextBox.Text;
            currApp.Essay2 = Essay2TextBox.Text;
            currApp.Essay3 = Essay3TextBox.Text;

            storedProcs.UpdateApplication(currApp);

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            foreach (TextBox text in this.Controls)
            {
                if (text.Text == "")
                {
                    break;
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
    }
}
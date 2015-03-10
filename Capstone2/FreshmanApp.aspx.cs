using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capstone2
{
    public partial class WebForm4 : System.Web.UI.Page
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

                ((Panel)Master.FindControl("FreshmanPanel")).Visible = true;
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
            UniversityTextBox.Text = currApp.Question4;
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
            currApp.Question4 = UniversityTextBox.Text;
            currApp.Essay1 = Essay1TextBox.Text;
            currApp.Essay2 = Essay2TextBox.Text;
            currApp.Essay3 = Essay3TextBox.Text;

            storedProcs.UpdateApplication(currApp);

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (MobilePhoneTextBox.Text.Length == 0 || MajorDropDownList.SelectedIndex == 0 || CitizenshipDropDownList.SelectedIndex == 0 || HealthScholarsDropDownList.SelectedIndex == 0 || InterestsTextBox.Text.Length == 0
                || ResearchProjectsTextBox.Text.Length == 0 || AccomplishmentTextBox.Text.Length == 0 || UniversityTextBox.Text.Length == 0 || Essay1TextBox.Text.Length == 0 || Essay2TextBox.Text.Length == 0 ||
                Essay3TextBox.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Check that all fields are complete!');", true);
            }

            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Application submitted successfully!');", true);

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
                currApp.Question4 = UniversityTextBox.Text;
                currApp.Essay1 = Essay1TextBox.Text;
                currApp.Essay2 = Essay2TextBox.Text;
                currApp.Essay3 = Essay3TextBox.Text;

                currApp.Completed = true;

                storedProcs.UpdateApplication(currApp);
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




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Data;


//namespace Capstone2
//{
//    public partial class WebForm4 : System.Web.UI.Page
//    {
//        protected void Page_Init(object sender, EventArgs e)
//        {
//            StoredProcedures storedProcs = new StoredProcedures();
//            ApplicationFunctions appFuncs = new ApplicationFunctions();

//            //CHANGE WHEN WE GET ID FROM LOGIN
//            DataSet myDS = storedProcs.SelectApplication("App123");

//            Application currApp = appFuncs.RepopulateApplicationObj(myDS);

//            MobilePhoneTextBox.Text = currApp.MobileNumber;
//            CitizenshipDropDownList.SelectedValue = currApp.Citizenship;
//            HealthScholarsDropDownList.SelectedValue = currApp.IsMedicalStudent;
//            InterestsTextBox.Text = currApp.Question1;
//            ResearchProjectsTextBox.Text = currApp.Question2;
//            AccomplishmentTextBox.Text = currApp.Question3;
//            UniversityTextBox.Text = currApp.Question4;
//            Essay1TextBox.Text = currApp.Essay1;
//            Essay2TextBox.Text = currApp.Essay2;
//            Essay3TextBox.Text = currApp.Essay3;


//        }

//        protected void SaveButton_Click(object sender, EventArgs e)
//        {
//            StoredProcedures storedProcs = new StoredProcedures();
//            ApplicationFunctions appFuncs = new ApplicationFunctions();

//            //CHANGE WHEN WE GET ID FROM LOGIN
//            DataSet myDS = storedProcs.SelectApplication("App123");

//            Application currApp = appFuncs.RepopulateApplicationObj(myDS);

//            currApp.MobileNumber = MobilePhoneTextBox.Text;
//            currApp.Citizenship = CitizenshipDropDownList.SelectedValue;
//            currApp.IsMedicalStudent = HealthScholarsDropDownList.SelectedValue;
//            currApp.Question1 = InterestsTextBox.Text;
//            currApp.Question2 = ResearchProjectsTextBox.Text;
//            currApp.Question3 = AccomplishmentTextBox.Text;
//            currApp.Question4 = UniversityTextBox.Text;
//            currApp.Essay1 = Essay1TextBox.Text;
//            currApp.Essay2 = Essay2TextBox.Text;
//            currApp.Essay3 = Essay3TextBox.Text;

//            storedProcs.UpdateApplication(currApp);

//        }

//        protected void SubmitButton_Click(object sender, EventArgs e)
//        {
//            foreach (TextBox text in this.Controls)
//            {
//                if (text.Text == "")
//                {
//                    break;
//                }

//            }
//        }

//        protected void CitizenshipDropDownList_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (CitizenshipDropDownList.SelectedValue == "Other")
//            {
//                txtCitizenOther.Visible = true;
//            }
//            else
//            {
//                txtCitizenOther.Visible = false;
//            }
//        }



//    }
//}

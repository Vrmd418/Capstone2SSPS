using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone2
{
    public class ApplicationFunctions
    {


        public Application RepopulateApplicationObj(DataSet myDS)
        {
            StoredProcedures storeProc = new StoredProcedures();
            Application savedApp = new Application();

            //CHANGE THIS WHEN WE GET ID FROM LOGIN
            savedApp.ApplicationID = "App123";

            //FIGURE OUT FIRST NAME LAST NAME FOR STUDENT
            //
            //
            //

            savedApp.DateSubmitted = myDS.Tables[0].Rows[0]["DateSubmitted"].ToString();
            savedApp.IsStarted = true;
            savedApp.Completed = Convert.ToBoolean(myDS.Tables[0].Rows[0]["Completed"]);
            savedApp.LastUpdateDate = myDS.Tables[0].Rows[0]["LastUpdated"].ToString();
            savedApp.LastUpdatedBy = myDS.Tables[0].Rows[0]["LastUpdatedBy"].ToString();
            savedApp.StudentID = myDS.Tables[0].Rows[0]["StudentID"].ToString();
            savedApp.Year = myDS.Tables[0].Rows[0]["TermID"].ToString();
            savedApp.IsMedicalStudent = myDS.Tables[0].Rows[0]["IsMedicalStudent"].ToString();
            savedApp.MobileNumber = myDS.Tables[0].Rows[0]["MobileNumber"].ToString();
            savedApp.Citizenship = myDS.Tables[0].Rows[0]["Citizenship"].ToString();

            savedApp.Question1 = myDS.Tables[0].Rows[0]["Question1"].ToString();
            savedApp.Question2 = myDS.Tables[0].Rows[0]["Question2"].ToString();
            savedApp.Question3 = myDS.Tables[0].Rows[0]["Question3"].ToString();
            savedApp.Question4 = myDS.Tables[0].Rows[0]["Question4"].ToString();
           
            savedApp.Essay1 = myDS.Tables[0].Rows[0]["Essay1"].ToString();
            savedApp.Essay2 = myDS.Tables[0].Rows[0]["Essay2"].ToString();
            savedApp.Essay3 = myDS.Tables[0].Rows[0]["Essay3"].ToString();

            return savedApp;
        }


    }
}
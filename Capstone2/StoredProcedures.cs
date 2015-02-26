using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Utilities;
using System.Data.SqlClient;

namespace Capstone2
{
    public class StoredProcedures
    {
        Application myApplication = new Application();
        DBConnect myConnection = new DBConnect();
    
        /*    @applicationID varchar(50),
	@dateSubmitted varchar(50),
	@lastUpdated varchar(50),
	@lastUpdatedBy varchar(50),
	@contents varchar(50),
	@isMedicalStudent varchar(50),
	@studentID varchar(50),
	@termID varchar(50)
    }*/
        public void InsertApplication(Application myApplication){
            SqlCommand objCommand = new SqlCommand();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "InsertApp";

            SqlParameter inputParameter = new SqlParameter("@applicationID", myApplication.ApplicationID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            SqlParameter inputParameter1 = new SqlParameter("@dateSubmitted", myApplication.DateSubmitted);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter1);

            SqlParameter inputParameter2 = new SqlParameter("@lastUpdated", myApplication.LastUpdateDate);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter2);

            SqlParameter inputParameter3 = new SqlParameter("@lastUpdatedBy", myApplication.LastUpdatedBy);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter3);

            SqlParameter inputParameter4 = new SqlParameter("@contents", myApplication.Contents);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter4);

            SqlParameter inputParameter5 = new SqlParameter("@isMedicalStudent",myApplication.IsMedicalStudent);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter5);

            SqlParameter inputParameter6 = new SqlParameter("@studentID", myApplication.StudentID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter5);

            SqlParameter inputParameter7 = new SqlParameter("@termID", myApplication.Year);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter5);


            SqlParameter inputParameter8 = new SqlParameter("@question1", myApplication.Question1);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter8);

            SqlParameter inputParameter9 = new SqlParameter("@question2", myApplication.Question2);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter9);
            SqlParameter inputParameter10 = new SqlParameter("@question3", myApplication.Question3);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter10);
            SqlParameter inputParameter11 = new SqlParameter("@question4", myApplication.Question4);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter11);

            SqlParameter inputParameter12 = new SqlParameter("@essay1", myApplication.Essay1);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);
            SqlParameter inputParameter13 = new SqlParameter("@essay2", myApplication.Essay2);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);
            SqlParameter inputParameter14 = new SqlParameter("@essay3", myApplication.Essay3);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            myConnection.DoUpdateUsingCmdObj(objCommand);
        }

        public void UpdateApplication(Application myApplication)
        {
            SqlCommand objCommand = new SqlCommand();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateApp";
            
            SqlParameter inputParameter = new SqlParameter("@appID", myApplication.ApplicationID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            SqlParameter inputParameter1 = new SqlParameter("@dateSubmitted", myApplication.DateSubmitted);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter1);

            SqlParameter inputParameter2 = new SqlParameter("@lastUpdated", myApplication.LastUpdateDate);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter2);

            SqlParameter inputParameter3 = new SqlParameter("@lastUpdatedBy", myApplication.LastUpdatedBy);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter3);

            //SqlParameter inputParameter4 = new SqlParameter("@contents", myApplication.Contents);
            //inputParameter.Direction = ParameterDirection.Input;
            //inputParameter.SqlDbType = SqlDbType.VarChar;
            //inputParameter.Size = 50;
            //objCommand.Parameters.Add(inputParameter4);

            SqlParameter inputParameter5 = new SqlParameter("@isMedicalStudent", myApplication.IsMedicalStudent);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter5);

            SqlParameter inputParameter8 = new SqlParameter("@question1", myApplication.Question1);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter8);

            SqlParameter inputParameter9 = new SqlParameter("@question2", myApplication.Question2);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter9);
            SqlParameter inputParameter10 = new SqlParameter("@question3", myApplication.Question3);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter10);
            SqlParameter inputParameter11 = new SqlParameter("@question4", myApplication.Question4);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter11);

            SqlParameter inputParameter12 = new SqlParameter("@essay1", myApplication.Essay1);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter12);
            SqlParameter inputParameter13 = new SqlParameter("@essay2", myApplication.Essay2);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter13);
            SqlParameter inputParameter14 = new SqlParameter("@essay3", myApplication.Essay3);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter14);

            myConnection.DoUpdateUsingCmdObj(objCommand);
        }

        public DataSet SelectApplication(Application myApplication)
        {
            SqlCommand objCommand = new SqlCommand();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SelectApp";

            SqlParameter inputParameter = new SqlParameter("@applicationID", myApplication.ApplicationID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);
            DataSet myDS = myConnection.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public DataSet SelectApplication(string appID)
        {
            SqlCommand objCommand = new SqlCommand();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SelectApp";

            SqlParameter inputParameter = new SqlParameter("@applicationID", appID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);
            DataSet myDS = myConnection.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public void DeleteApplication(Application myApplication)
        {
            SqlCommand objCommand = new SqlCommand();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "DeleteApp";

            SqlParameter inputParameter = new SqlParameter("@applicationID", myApplication.ApplicationID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);
            myConnection.DoUpdateUsingCmdObj(objCommand);
           
        }

        public void InsertStudent(SSPSStudent myStudent)
        {
            SqlCommand objCommand = new SqlCommand();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "InsertStudent";

            SqlParameter inputParameter = new SqlParameter("@studentID", myStudent.StudentID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            SqlParameter inputParameter1 = new SqlParameter("@fname", myStudent.FirstName);
            inputParameter1.Direction = ParameterDirection.Input;
            inputParameter1.SqlDbType = SqlDbType.VarChar;
            inputParameter1.Size = 50;
            objCommand.Parameters.Add(inputParameter1);

            SqlParameter inputParameter2 = new SqlParameter("@lName", myStudent.LastName);
            inputParameter2.Direction = ParameterDirection.Input;
            inputParameter2.SqlDbType = SqlDbType.VarChar;
            inputParameter2.Size = 50;
            objCommand.Parameters.Add(inputParameter2);

            SqlParameter inputParameter3 = new SqlParameter("@major", myStudent.LastName);
            inputParameter3.Direction = ParameterDirection.Input;
            inputParameter3.SqlDbType = SqlDbType.VarChar;
            inputParameter3.Size = 50;
            objCommand.Parameters.Add(inputParameter3);

            SqlParameter inputParameter4 = new SqlParameter("@gender", myStudent.Gender);
            inputParameter4.Direction = ParameterDirection.Input;
            inputParameter4.SqlDbType = SqlDbType.VarChar;
            inputParameter4.Size = 50;
            objCommand.Parameters.Add(inputParameter4);

            SqlParameter inputParameter5 = new SqlParameter("@ethnicity", myStudent.Ethnicity);
            inputParameter5.Direction = ParameterDirection.Input;
            inputParameter5.SqlDbType = SqlDbType.VarChar;
            inputParameter5.Size = 50;
            objCommand.Parameters.Add(inputParameter5);

            //SqlParameter inputParameter6 = new SqlParameter("@totalRankings", myStudent.TotalRankings);
            //inputParameter6.Direction = ParameterDirection.Input;
            //inputParameter6.SqlDbType = SqlDbType.VarChar;
            //inputParameter6.Size = 50;
            //objCommand.Parameters.Add(inputParameter5);

            SqlParameter inputParameter7 = new SqlParameter("@birthdate", myStudent.BirthDate);
            inputParameter7.Direction = ParameterDirection.Input;
            inputParameter7.SqlDbType = SqlDbType.VarChar;
            inputParameter7.Size = 50;
            objCommand.Parameters.Add(inputParameter7);


            SqlParameter inputParameter8 = new SqlParameter("@scholarshipType", myStudent.ScholarshipType);
            inputParameter8.Direction = ParameterDirection.Input;
            inputParameter8.SqlDbType = SqlDbType.VarChar;
            inputParameter8.Size = 50;
            objCommand.Parameters.Add(inputParameter8);

            SqlParameter inputParameter9 = new SqlParameter("@admitTerm", myStudent.AdmitTerm);
            inputParameter9.Direction = ParameterDirection.Input;
            inputParameter9.SqlDbType = SqlDbType.VarChar;
            inputParameter9.Size = 50;
            objCommand.Parameters.Add(inputParameter9);
            SqlParameter inputParameter10 = new SqlParameter("@degreeType", myStudent.DegreeType);
            inputParameter10.Direction = ParameterDirection.Input;
            inputParameter10.SqlDbType = SqlDbType.VarChar;
            inputParameter10.Size = 50;
            objCommand.Parameters.Add(inputParameter10);
            SqlParameter inputParameter11 = new SqlParameter("@nameOfHighSchool", myStudent.NameOfHighSchool);
            inputParameter11.Direction = ParameterDirection.Input;
            inputParameter11.SqlDbType = SqlDbType.VarChar;
            inputParameter11.Size = 50;
            objCommand.Parameters.Add(inputParameter11);

            SqlParameter inputParameter12 = new SqlParameter("@termID", myStudent.TermID);
            inputParameter12.Direction = ParameterDirection.Input;
            inputParameter12.SqlDbType = SqlDbType.VarChar;
            inputParameter12.Size = 50;
            objCommand.Parameters.Add(inputParameter12);

            myConnection.DoUpdateUsingCmdObj(objCommand);
        }

        public Boolean GetUser(String userId)
        {
            SqlCommand objcomm = new SqlCommand();

            objcomm.CommandType = CommandType.StoredProcedure;

            objcomm.CommandText = "GetUser";
            objcomm.Parameters.Add("@userName", userId);

            SqlParameter outputParameter = new SqlParameter("@result", DbType.Int32);
            outputParameter.Direction = ParameterDirection.ReturnValue;

            objcomm.Parameters.Add(outputParameter);

            myConnection.DoUpdateUsingCmdObj(objcomm);

            int result = int.Parse(objcomm.Parameters["@result"].Value.ToString());

            if (result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public String GetCategory(String username)
        {
            DBConnect db = new DBConnect();
            SqlCommand objcomm = new SqlCommand();
            objcomm.CommandType = CommandType.StoredProcedure;
            objcomm.CommandText = "GetCategory";

            objcomm.Parameters.Add("@userName", username);

            DataSet ds = db.GetDataSetUsingCmdObj(objcomm);

            String category = ds.Tables[0].Rows[0][0].ToString();

            return category;

        }

        public void CreateTerm(String yearCode, String appdeadline, String docdeadline, String rankdeadline)
        {
            SqlCommand objcomm = new SqlCommand();

            objcomm.CommandType = CommandType.StoredProcedure;

            objcomm.CommandText = "CreateTerm";
            objcomm.Parameters.Add("@yearCode", yearCode);
            objcomm.Parameters.Add("@applicationDeadline", appdeadline);
            objcomm.Parameters.Add("@documentDeadline", docdeadline);
            objcomm.Parameters.Add("@rankDeadline", rankdeadline);
	
            SqlParameter outputParameter = new SqlParameter("@result", DbType.Int32);
            outputParameter.Direction = ParameterDirection.ReturnValue;

            objcomm.Parameters.Add(outputParameter);

            myConnection.DoUpdateUsingCmdObj(objcomm);

            
        }

        public String GetYearCode()
        {
            DBConnect db = new DBConnect();
            SqlCommand objcomm = new SqlCommand();
            objcomm.CommandType = CommandType.StoredProcedure;
            objcomm.CommandText = "GetAcademicYear";

            DataSet ds = db.GetDataSetUsingCmdObj(objcomm);

            String category = ds.Tables[0].Rows[0][0].ToString();

            return category;

        }
    
    }

       
}
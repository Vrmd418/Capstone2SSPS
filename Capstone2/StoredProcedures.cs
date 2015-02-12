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
    }
       
}
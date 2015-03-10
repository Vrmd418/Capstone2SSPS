using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capstone2
{
    public partial class WebForm7 : System.Web.UI.Page
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
        protected void UploadButton_Click(object sender, EventArgs e)
        {
            DataSet myDS = UtilityFunctions.getDataSetFromExcel(masterList, Server);
            StoredProcedures mySP = new StoredProcedures();

            object[] columnNames = myDS.Tables[0].Rows[0].ItemArray;

            foreach (DataTable dt in myDS.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dt.Rows.IndexOf(dr)>=0)
                    {
                        SSPSStudent student = new SSPSStudent();
                        student.StudentID = dr["TUID"].ToString();
                        student.FirstName = dr["First Name"].ToString();
                        student.LastName = dr["Last Name"].ToString();
                        student.Major = dr["Major "].ToString();
                        student.Gender = dr["Gender Desc."].ToString();
                        student.Ethnicity = dr["Ethnicity / Intl / Race"].ToString();
                        student.BirthDate = dr["Birth Date"].ToString();
                        student.ScholarshipType = dr["Scholarship Type"].ToString();
                        student.AdmitTerm = dr["Admit Term"].ToString();
                        student.DegreeType = dr["Degree"].ToString();
                        student.NameOfHighSchool = dr["HS Name"].ToString();
                        student.StudentYearStatus = rdoStudentType.SelectedValue.ToString();
                        student.TermID = AcademicYearList.SelectedValue.ToString();

                        mySP.InsertStudent(student);

                    }
                }
            }

            GridView1.DataSource = myDS;
            GridView1.DataBind();
        }
    }
}
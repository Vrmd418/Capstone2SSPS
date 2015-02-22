using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace Capstone2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean val = GetUser(UserIdTextBox.Text);

            if (val == false)
            {
                MessageLabel.Visible = true;
                MessageLabel.Text = "Sorry, you are not permitted to log in";
            }
            else
            {

                if (IsValid)
                {
                    string anUser = UserIdTextBox.Text;
                    string RetVal = AuthenticateUser(anUser.ToUpper());
                    if (RetVal.Length > 0)
                    {
                        Session["isUserAuthenticated"] = true;
                        bool incorrectUNPW = false;
                        Session["incorrectUNPW"] = incorrectUNPW;

                        MessageLabel.Visible = false;

                        UserObject obj = new UserObject();
                        String category = GetCategory(UserIdTextBox.Text);
                        obj.Category = category;
                        obj.TUID = UserIdTextBox.Text;
                        Session["Login"] = obj;

                        if (category == "Admin")
                        {
                            Server.Transfer("AdminPage.aspx", true);
                        }
                        else if (category == "Freshman" || category == "Sophmore")
                        {
                            Server.Transfer("StudentHome.aspx", true);
                        }
                        else
                        {
                            Server.Transfer("CommitteeView.aspx", true);

                        }

                    }
                    else
                    {
                        bool incorrectUNPW = true;
                        Session["incorrectUNPW"] = incorrectUNPW;
                        MessageLabel.Visible = true;
                        MessageLabel.Text = "Invalid username or password.";
                    }
                }
            }
        }


        public string AuthenticateUser(string strUID)
        {
            string strID = string.Empty;
            DirectoryEntry entry = new DirectoryEntry();

            try
            {
                // call getDNFRromLDAP method to anonymously (port 389)
                // search against ldap for the correct DN
                string strDN = getDNFromLDAP(strUID);

                //now use the found DN for the secure bind (port 636)
                entry.Path = "LDAP://rock.temple.edu/" + strDN;
                entry.Username = strDN;
                entry.Password = PasswordTextBox.Text;
                entry.AuthenticationType = AuthenticationTypes.SecureSocketsLayer;

                //try to fetch a property..if no errors raised then it works
                strID = entry.Properties["sAMAccountName"][0].ToString();


            }
            catch
            {
            }
            finally
            {
                entry.Close();
                entry.Dispose();
            }

            return strID;
        }

        public static string getDNFromLDAP(string strUID)
        {
            DirectoryEntry entry = new DirectoryEntry("LDAP://rock.temple.edu/ou=temple,dc=tu,dc=temple,dc=edu");
            entry.AuthenticationType = AuthenticationTypes.None;
            DirectorySearcher mySearcher = new DirectorySearcher(entry);
            entry.Close();
            entry.Dispose();
            mySearcher.Filter = "(sAMAccountName=" + strUID + ")";
            SearchResult result = mySearcher.FindOne();
            mySearcher.Dispose();
            int nIndex = result.Path.LastIndexOf("/");
            string strDN = result.Path.Substring((nIndex + 1)).ToString().TrimEnd();
            return strDN;
        }
        private Boolean GetUser(String userId)
        {
            DBConnect db2 = new DBConnect();
            SqlCommand objcomm = new SqlCommand();

            objcomm.CommandType = CommandType.StoredProcedure;

            objcomm.CommandText = "GetUser";
            objcomm.Parameters.Add("@userName", UserIdTextBox.Text);

            SqlParameter outputParameter = new SqlParameter("@result", DbType.Int32);
            outputParameter.Direction = ParameterDirection.ReturnValue;

            objcomm.Parameters.Add(outputParameter);

            db2.DoUpdateUsingCmdObj(objcomm);

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

        private String GetCategory(String username)
        {
            DBConnect db = new DBConnect();
            SqlCommand objcomm = new SqlCommand();
            objcomm.CommandType = CommandType.StoredProcedure;
            objcomm.CommandText = "GetCategory";

            objcomm.Parameters.Add("@userName", UserIdTextBox.Text);

            DataSet ds = db.GetDataSetUsingCmdObj(objcomm);

            String category = ds.Tables[0].Rows[0][0].ToString();

            return category;

        }
        protected void ForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://accounts.temple.edu/selfcare/login.jsp");

        }
    
    }
}
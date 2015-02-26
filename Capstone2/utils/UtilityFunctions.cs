using System;
using System.Data;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OfficeOpenXml;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.DirectoryServices;
using Excel;

public class UtilityFunctions
{
    public UtilityFunctions()
    {
    }

    public void ExportGridView(GridView grid, HttpResponse Response)
    {
        Response.Clear();
        Response.AddHeader("content-disposition", "attachment;filename=Vehicles.xls");
        Response.Charset = "";
        Response.ContentType = "application/vnd.ms-excel";
        StringWriter StringWriter = new System.IO.StringWriter();
        HtmlTextWriter HtmlTextWriter = new HtmlTextWriter(StringWriter);

        grid.AllowPaging = false;
        grid.AllowSorting = false;
        grid.RenderControl(HtmlTextWriter);
        Response.Write(StringWriter.ToString());
        Response.End();
    }

    public void ExportGridViewSelectedColumns(GridView grid, HttpResponse response, int startCol, int endCol)
    {
        DataSet myDataSet = new DataSet();
        myDataSet = (DataSet)grid.DataSource;
        DataTable myTable = new DataTable(grid.ToString());

        for (int i = startCol; i < endCol; i++)
        {
            myTable.Columns.Add(myDataSet.Tables[0].Columns[i].ToString());

        }
        for (int j = 0; j < myDataSet.Tables[0].Rows.Count; j++)
        {
            String[] colValues = new String[endCol];
            for (int k = startCol; k < endCol; k++)
            {
                colValues[k] = myDataSet.Tables[0].Rows[j][k].ToString();
            }
            myTable.Rows.Add(colValues);
        }


        GridView exportGv = new GridView();
        exportGv.AllowPaging = false;
        exportGv.AllowSorting = false;
        exportGv.DataSource = myTable;
        exportGv.DataBind();

        ExportGridView(exportGv, response);
    }

    public void ExportPDF(HttpResponse Response, GridView grdView)
    {
        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition",
         "attachment;filename=GridViewExport.pdf");
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        StringWriter sw = new StringWriter();
        HtmlTextWriter hw = new HtmlTextWriter(sw);
        grdView.AllowPaging = false;
        grdView.DataBind();
        grdView.RenderControl(hw);
        StringReader sr = new StringReader(sw.ToString());
        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
        HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        pdfDoc.Open();
        htmlparser.Parse(sr);
        pdfDoc.Close();
        Response.Write(pdfDoc);
        Response.End();
    }

    public void ExportWord(HttpResponse Response, GridView grdView)
    {
        Response.Clear();
        Response.Buffer = true;
        Response.AddHeader("content-disposition",
        "attachment;filename=GridViewExport.doc");
        Response.Charset = "";
        Response.ContentType = "application/vnd.ms-word ";
        StringWriter sw = new StringWriter();
        HtmlTextWriter hw = new HtmlTextWriter(sw);
        grdView.AllowPaging = false;
        grdView.DataBind();
        grdView.RenderControl(hw);
        Response.Output.Write(sw.ToString());
        Response.Flush();
        Response.End();
    }

    public void ExportCSV(HttpResponse Response, GridView grdView)
    {
        Response.Clear();
        Response.Buffer = true;
        Response.AddHeader("content-disposition",
         "attachment;filename=GridViewExport.csv");
        Response.Charset = "";
        Response.ContentType = "application/text";

        grdView.AllowPaging = false;
        grdView.DataBind();

        StringBuilder sb = new StringBuilder();
        for (int k = 0; k < grdView.Columns.Count; k++)
        {
            //add separator
            sb.Append(grdView.Columns[k].HeaderText + ',');
        }
        //append new line
        sb.Append("\r\n");
        for (int i = 0; i < grdView.Rows.Count; i++)
        {
            for (int k = 0; k < grdView.Columns.Count; k++)
            {
                //add separator
                sb.Append(grdView.Rows[i].Cells[k].Text + ',');
            }
            //append new line
            sb.Append("\r\n");
        }
        Response.Output.Write(sb.ToString());
        Response.Flush();
        Response.End();
    }

    public static string getDNFromLDAP(string strUID)
    {
        var entry = new DirectoryEntry("LDAP://rock.temple.edu/ou=temple,dc=tu,dc=temple,dc=edu");
        entry.AuthenticationType = AuthenticationTypes.None;
        var mySearcher = new DirectorySearcher(entry);
        entry.Close();
        entry.Dispose();
        mySearcher.Filter = "(sAMAccountName=" + strUID + ")";
        var result = mySearcher.FindOne();
        mySearcher.Dispose();
        int nIndex = result.Path.LastIndexOf("/");
        string strDN = result.Path.Substring((nIndex + 1)).ToString().TrimEnd();
        return strDN;
    }
    //getDNFromLDAP

    public bool AuthenticateUser(string strUID, string strPassword)
    {
        string strID = string.Empty;
        var entry = new DirectoryEntry();

        try
        {
            // call getDNFRromLDAP method to anonymously (port 389)
            // search against ldap for the correct DN
            string strDN = getDNFromLDAP(strUID);

            //now use the found DN for the secure bind (port 636)
            entry.Path = "LDAP://rock.temple.edu/" + strDN;
            entry.Username = strDN;
            entry.Password = strPassword;
            entry.AuthenticationType = AuthenticationTypes.SecureSocketsLayer;

            //try to fetch a property..if no errors raised then it works
            strID = entry.Properties["sAMAccountName"][0].ToString();

        }
        catch
        {
            return false;
        }
        finally
        {
            entry.Close();
            entry.Dispose();
        }
        return true;
    }
    //AuthenticateUser

    public static string getNameFromLDAP(string strUID)
    {
        var entry = new DirectoryEntry("LDAP://rock. temple.edu/ou=temple,dc=tu,dc= temple,dc=edu");
        entry.AuthenticationType = AuthenticationTypes.None;
        DirectorySearcher mySearcher = new DirectorySearcher(entry);
        entry.Close();
        entry.Dispose();
        mySearcher.Filter = "(sAMAccountName=" + strUID + ")";
        mySearcher.PropertiesToLoad.Add("cn");
        SearchResult result = mySearcher.FindOne();
        mySearcher.Dispose();
        int nIndex = result.Path.LastIndexOf("/");
        string strDN = result.Path.Substring((nIndex + 1)).ToString().TrimEnd();
        return strDN;
    }
    //getDNFromLDAP

    //adds name to session for new user
    public bool addNameToSession(string DNstring)
    {
        string firstName = null;
        string lastName = null;
        return true;
    }

    public static DataSet getDataSetFromExcel(FileUpload FileUpload1, HttpServerUtility Server)
    {
        if (FileUpload1.HasFile)
        {
            string fileName = Path.GetFileName(FileUpload1.FileName);
            string filePath = Server.MapPath("~/Excel/" + fileName);
            string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);

            try
            {

                MemoryStream stream = new MemoryStream(FileUpload1.FileBytes);
                IExcelDataReader excelReader;

                if (fileExtension == ".xls")
                {
                    excelReader = ExcelReaderFactory.CreateBinaryReader(stream);

                    excelReader.IsFirstRowAsColumnNames = true;
                    DataSet result = excelReader.AsDataSet();

                    DataTable myTable = result.Tables[0];

                    excelReader.Close();
                    return result;
                }
                else if (fileExtension == ".xlsx")
                {
                    excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

                    excelReader.IsFirstRowAsColumnNames = true;
                    DataSet result = excelReader.AsDataSet();

                    DataTable myTable = result.Tables[0];

                    excelReader.Close();
                    return result;
                }
                else if (fileExtension == ".csv")
                {
                    //Someone else can implement this
                    return null;
                }
                else
                {
                    throw new Exception("Unhandled Filetype");
                }
            }
            catch
            {
                return null;
            }
        }
        else
        {
            return null;
        }
    }
}

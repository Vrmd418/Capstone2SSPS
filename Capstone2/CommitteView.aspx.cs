using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["Login"] == null)
                {
                    Server.Transfer("LogIn.aspx", true);
                }
                else
                {
                    UserObject obj = (UserObject)Session["Login"];

                    ((Label)Master.FindControl("UserLabel")).Text = obj.TUID.ToString();
                    ((Panel)Master.FindControl("CommitteePanel")).Visible = true;

                    DataTable tbl = new DataTable();

                    tbl.Columns.Add("tuid", typeof(String));
                    tbl.Columns.Add("firstName", typeof(String));
                    tbl.Columns.Add("lastName", typeof(String));
                    tbl.Columns.Add("academicYear", typeof(String));
                    tbl.Columns.Add("major", typeof(String));
                    tbl.Columns.Add("rank", typeof(String));

                    DataRow newRow = tbl.NewRow();

                    newRow["tuid"] = "tuu99999";
                    newRow["firstName"] = "Brent";
                    newRow["lastName"] = "Baskin";
                    newRow["academicYear"] = "2014-2015";
                    newRow["major"] = "CIS";
                    newRow["rank"] = 5;

                    tbl.Rows.Add(newRow);

                    DataRow newRow1 = tbl.NewRow();

                    newRow1["tuid"] = "tuu99999";
                    newRow1["firstName"] = "Vince";
                    newRow1["lastName"] = "Dixon";
                    newRow1["academicYear"] = "2014-2015";
                    newRow1["major"] = "CIS";
                    newRow1["rank"] = 5;

                    tbl.Rows.Add(newRow1);

                    DataRow newRow2 = tbl.NewRow();

                    newRow2["tuid"] = "tuu99999";
                    newRow2["firstName"] = "Josh";
                    newRow2["lastName"] = "Roach";
                    newRow2["academicYear"] = "2014-2015";
                    newRow2["major"] = "CIS";
                    newRow2["rank"] = 5;

                    tbl.Rows.Add(newRow2);

                    ViewHistoricalGridView.DataSource = tbl;
                    ViewHistoricalGridView.DataBind();
                }
            }
        }

        protected void ShowPDF(object sender, EventArgs e)
        {
            
                StoredProcedures storedProcs = new StoredProcedures();
                ApplicationFunctions appFuncs = new ApplicationFunctions();

                //CHANGE WHEN WE GET ID FROM LOGIN
                DataSet myDS = storedProcs.SelectApplication("App123");

                Application currApp = appFuncs.RepopulateApplicationObj(myDS);
                Response.ContentType = "application/pdf";

                // Change "studentxapp" to student's name or Accessnet username
                string attachment = "attachment; filename=" + "studentxapp" + ".pdf";
                Response.AddHeader("content-disposition", attachment);
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Document doc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);

                PdfWriter.GetInstance(doc, Response.OutputStream);
                doc.Open();
                doc.Add(new Paragraph("John Doe", FontFactory.GetFont("Times", 16, Font.BOLD)));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Mobile Number:", FontFactory.GetFont("Arial", 12, Font.BOLD)));
                doc.Add(new Paragraph(currApp.MobileNumber, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("Citizenship:", FontFactory.GetFont("Arial", 12, Font.BOLD)));
                doc.Add(new Paragraph(currApp.Citizenship, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("Health Scholar:", FontFactory.GetFont("Arial", 12, Font.BOLD)));
                doc.Add(new Paragraph(currApp.IsMedicalStudent, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("Interests:", FontFactory.GetFont("Arial", 12, Font.BOLD)));
                doc.Add(new Paragraph(currApp.Question1, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("Research Projects:", FontFactory.GetFont("Arial", 12, Font.BOLD)));
                doc.Add(new Paragraph(currApp.Question2, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("Accomplishments:", FontFactory.GetFont("Arial", 12, Font.BOLD)));
                doc.Add(new Paragraph(currApp.Question3, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("Why Temple?:", FontFactory.GetFont("Arial", 12, Font.BOLD)));
                doc.Add(new Paragraph(currApp.Question4, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("Essay 1:", FontFactory.GetFont("Arial", 12, Font.BOLD)));
                doc.Add(new Paragraph(currApp.Essay1, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("Essay 2:", FontFactory.GetFont("Arial", 12, Font.BOLD)));
                doc.Add(new Paragraph(currApp.Essay2, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("Essay 3:", FontFactory.GetFont("Arial", 12, Font.BOLD)));
                doc.Add(new Paragraph(currApp.Essay3, FontFactory.GetFont("Arial", 12, Font.NORMAL)));
                doc.Add(new Paragraph(" "));

                doc.Close();
                Response.Write(doc);
                Response.End();
            
        }


    }
}
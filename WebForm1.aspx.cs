using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataClasses1DataContext _db = new DataClasses1DataContext();
            //GridView1.DataSource = _db.Select_Authors_Paintings();
            //GridView1.DataBind();
            if (!IsPostBack)
            {
                if (Session["Username"] == "" || Session["Username"] == null)
                {
                    Response.Redirect("WebForm4.aspx");
                }
                btnSaveUpdate.Text = "Save";
                GetAllPaintings();
            }
        }

        string cs = ConfigurationManager.ConnectionStrings["PaintingsConnectionString"].ConnectionString;
        private void GetAllPaintings()
        {
            DataClasses1DataContext _paintingcontext = new DataClasses1DataContext();
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Authors_Paintings", con);
            con.Open();
            adapt.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            authoridDD.DataSource = _paintingcontext.Authors;
            authoridDD.DataTextField = "LastName";
            authoridDD.DataValueField = "AuthorID";
            authoridDD.DataBind();
            _paintingcontext.Dispose();
        }

        private void GetSpecificAuthor(int value)
        {
            //DataClasses1DataContext _paintingcontext = new DataClasses1DataContext();
            //DataSet ds = _paintingcontext.Select_Author_ID(Convert.ToInt16(authoridDD.SelectedValue));
            //for(int i = 0; i < ds.Tables[0].RowArray; i++)
            //_paintingcontext.Dispose();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataClasses1DataContext _paintingcontext = new DataClasses1DataContext();
            _paintingcontext.Delete_Painting(Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Value));
            GetAllPaintings();
            ClearTextBox();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext _paintingcontext = new DataClasses1DataContext();
            //_paintingcontext.Update_Authors_Paintings();
            authorid.Text = Convert.ToString(GridView1.SelectedRow.Cells[1].Text);
            authoridDD.SelectedValue = authorid.Text;
            paintingid.Text = Convert.ToString(GridView1.SelectedRow.Cells[2].Text);
            firstname.Text = Convert.ToString(GridView1.SelectedRow.Cells[3].Text);
            middlename.Text = Convert.ToString(GridView1.SelectedRow.Cells[4].Text);
            lastname.Text = Convert.ToString(GridView1.SelectedRow.Cells[5].Text);
            paintingstyle.Text = Convert.ToString(GridView1.SelectedRow.Cells[6].Text);
            yb.Text = Convert.ToString(GridView1.SelectedRow.Cells[7].Text);
            paintingname.Text = Convert.ToString(GridView1.SelectedRow.Cells[8].Text);
            ym.Text = Convert.ToString(GridView1.SelectedRow.Cells[9].Text);
            medium.Text = Convert.ToString(GridView1.SelectedRow.Cells[10].Text);
            btnSaveUpdate.Text = "Update";
            _paintingcontext.Dispose();
        }

        protected void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext _paintingcontext = new DataClasses1DataContext();
            CultureInfo culture = CultureInfo.InvariantCulture;
            DateTime ybconvert;
            DateTime ymconvert;
            bool isSuccess = DateTime.TryParseExact(yb.Text, new string[] { "yyyy-mm-dd", "yyyy-MM-dd" }, culture, DateTimeStyles.None, out ybconvert);
            bool isSuccess2 = DateTime.TryParseExact(ym.Text, new string[] { "yyyy-mm-dd", "yyyy-MM-dd" }, culture, DateTimeStyles.None, out ymconvert);
            if (ymconvert == Convert.ToDateTime("1/1/0001 12:00:00 AM"))
            {
                Error.Visible = true;
                Error.Text = "Сложете валидна дата.";
            }
            else
            {
                if (btnSaveUpdate.Text == "Save")
                {
                    //GetSpecificAuthor(Convert.ToInt16(authoridDD.SelectedValue));
                    _paintingcontext.Insert_Info(Convert.ToInt16(authoridDD.SelectedValue), paintingname.Text, ymconvert, medium.Text);
                }
                else
                {
                    _paintingcontext.Update_Authors_Paintings(Convert.ToInt16(authorid.Text), Convert.ToInt16(paintingid.Text),
                        firstname.Text, middlename.Text, lastname.Text, paintingstyle.Text, ybconvert, paintingname.Text,
                        ymconvert, medium.Text);
                }

                btnSaveUpdate.Text = "Save";
                //ClearTextBox();
                GetAllPaintings();
                _paintingcontext.Dispose();
            }
        }

        private void ClearTextBox()
        {
            authorid.Text = "";
            paintingid.Text = "";
            firstname.Text = "";
            middlename.Text = "";
            lastname.Text = "";
            paintingstyle.Text = "";
            yb.Text = "";
            paintingname.Text = "";
            ym.Text = "";
            medium.Text = "";
            btnSaveUpdate.Text = "Save";
        }

        protected void authoridDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext _paintingcontext = new DataClasses1DataContext();
            //authorid.Text = Convert.ToString(authoridDD.SelectedValue);
            //ListView1.DataSource = _paintingcontext.Select_Author_ID(Convert.ToInt16(authoridDD.SelectedValue));
            //ListView1.DataBind();
            //authorid.Text = Convert.ToString(authoridDD.SelectedValue);

            ISingleResult<Select_Author_IDResult> result = _paintingcontext.Select_Author_ID(Convert.ToInt16(authoridDD.SelectedValue));

            foreach (Select_Author_IDResult author in result)
            {
                //Console.WriteLine("CustID={0}; City={1}", cust.CustomerID,
                //    cust.City);
                firstname.Text = author.Име;
                middlename.Text = author.Презиме;
                lastname.Text = author.Фамилия;
                paintingstyle.Text = author.Стил_на_рисуване;
                yb.Text = Convert.ToString(author.Дата_на_раждане);
            }
            _paintingcontext.Dispose();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("master.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
            CultureInfo culture = CultureInfo.InvariantCulture;
            DateTime ymconvert;
            bool isSuccess = DateTime.TryParseExact(ym.Text, "dd.MM.yyyy", culture, DateTimeStyles.None, out ymconvert);
            if (isSuccess)
            {
                Calendar1.SelectedDate = ymconvert;
                Calendar1.SelectedDayStyle.BackColor = System.Drawing.Color.Pink;
                Calendar1.VisibleDate = ymconvert;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            ym.Text = Calendar1.SelectedDate.ToString("dd.MM.yyyy");
            Calendar1.Visible = false;
        }
    }
}
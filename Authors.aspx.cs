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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnSaveUpdate.Text = "Save";
                GetAllAuthors();
            }
        }

        string cs = ConfigurationManager.ConnectionStrings["PaintingsConnectionString"].ConnectionString;
        private void GetAllAuthors()
        {
            DataClasses1DataContext _paintingcontext = new DataClasses1DataContext();
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Authors", con);
            con.Open();
            adapt.Fill(dt);
            con.Close();
            if(dt.Rows.Count>0)
            {
                Authors.DataSource = dt;
                Authors.DataBind();
            }
            //Authors.DataSource = _paintingcontext.Select_All_Authors();
            //Authors.DataBind();
            //authoridDD.DataSource = _paintingcontext.Authors;
            //authoridDD.DataTextField = "LastName";
            //authoridDD.DataValueField = "AuthorID";
            //authoridDD.DataBind();
            _paintingcontext.Dispose();
        }

        protected void Authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext _paintingcontext = new DataClasses1DataContext();
            authorid.Text = Convert.ToString(Authors.SelectedRow.Cells[1].Text);
            _paintingcontext.Author_Search(Convert.ToInt16(authorid.Text));
            //authoridDD.SelectedValue = authorid.Text;
            firstname.Text = Convert.ToString(Authors.SelectedRow.Cells[2].Text);
            middlename.Text = Convert.ToString(Authors.SelectedRow.Cells[3].Text);
            lastname.Text = Convert.ToString(Authors.SelectedRow.Cells[4].Text);
            paintingstyle.Text = Convert.ToString(Authors.SelectedRow.Cells[5].Text);
            yb.Text = Convert.ToString(Authors.SelectedRow.Cells[6].Text);
            btnSaveUpdate.Text = "Update";
            _paintingcontext.Dispose();
        }

        protected void Authors_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataClasses1DataContext _paintingcontext = new DataClasses1DataContext();
            int result = _paintingcontext.Delete_Author(Convert.ToInt16(Authors.DataKeys[e.RowIndex].Value));
            if(result == 1)
            {
                Error.Visible = true;
                Error.Text = "Художникът има картини.";
            }
            else
            {
                //_paintingcontext.Author_Search(Convert.ToInt16(Authors.DataKeys[e.RowIndex].Value));
                GetAllAuthors();
                ClearTextBox();
            }
        }

        protected void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext _paintingcontext = new DataClasses1DataContext();
            CultureInfo culture = CultureInfo.InvariantCulture;
            DateTime ybconvert;
            bool isSuccess = DateTime.TryParseExact(yb.Text, "dd.MM.yyyy", culture, DateTimeStyles.None, out ybconvert);
            if (!isSuccess)
            {
                Error.Visible = true;
                Error.Text = "Сложете валидна дата.";
            }
            else
            {
                Error.Visible = false;
                if (btnSaveUpdate.Text == "Save")
                {
                    //GetSpecificAuthor(Convert.ToInt16(authoridDD.SelectedValue));
                    _paintingcontext.Insert_Authors(firstname.Text, middlename.Text, lastname.Text, paintingstyle.Text, ybconvert);
                }
                else
                {
                    _paintingcontext.Update_Authors(Convert.ToInt16(authorid.Text), firstname.Text, middlename.Text, lastname.Text, paintingstyle.Text, ybconvert);
                }

                btnSaveUpdate.Text = "Save";
                //ClearTextBox();
                GetAllAuthors();
                _paintingcontext.Dispose();
            }
        }

        private void ClearTextBox()
        {
            authorid.Text = "";
            firstname.Text = "";
            middlename.Text = "";
            lastname.Text = "";
            paintingstyle.Text = "";
            yb.Text = "";
            btnSaveUpdate.Text = "Save";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("master.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
            CultureInfo culture = CultureInfo.InvariantCulture;
            DateTime ybconvert;
            bool isSuccess = DateTime.TryParseExact(yb.Text, "dd.MM.yyyy", culture, DateTimeStyles.None, out ybconvert);
            if (isSuccess)
            {
                Calendar1.SelectedDate = ybconvert;
                Calendar1.SelectedDayStyle.BackColor = System.Drawing.Color.Pink;
                Calendar1.VisibleDate = ybconvert;
            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            yb.Text = Calendar1.SelectedDate.ToString("dd.MM.yyyy");
            Calendar1.Visible = false;
        }
    }
}
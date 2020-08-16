using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebAppAssign13Aug
{
    public partial class ConnectedObject : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DotNetAug2020;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        public void ShowGrid()
        {
            conn.Open();
            cmd = new SqlCommand("select * from Employeetb1", conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            dr.Close();
            conn.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ShowGrid();
            }
        }

        protected void btnInsertP_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into EmployeeTb1(empName,empSal) values(@empname,@empsal)", conn);
            cmd.Parameters.AddWithValue("@empname",txtEmpName.Text);
            cmd.Parameters.AddWithValue("@empsal", txtEmpSal.Text);
            int x = cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnUpdateP_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("update EmployeeTb1 set empName=@empname,empsal=@empsal where empId=@empid", conn);
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = txtEmpName.Text;
            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(txtEmpSal.Text);

            int x = cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btndeleteP_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from EmployeeTb1 where empId=@empid", conn);
            SqlParameter para = new SqlParameter("@empid",txtEmpId.Text);
            cmd.Parameters.Add(para);
            int x = cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnWithQ_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into employeetb1(empName,empSal) values('" +txtEmpName.Text + "'," + txtEmpSal.Text + ")", conn);
            int x = cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            cmd = new SqlCommand("update EmployeeTb1 set empName='" + txtEmpName.Text + "',empSal=" + txtEmpSal.Text + " where empId=" + txtEmpId.Text + "", conn);
            int x = cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from EmployeeTb1 where empId=" + txtEmpId.Text + "", conn);

            int x = cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }
    }
}
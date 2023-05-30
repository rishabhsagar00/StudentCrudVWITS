using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using applicationLayer1;

namespace bookstoreapp
{
    public partial class bookstoreForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            applayer1 aa = new applayer1();
            int a = int.Parse(TextBox1.Text);
            string b = TextBox2.Text;
            string c = TextBox3.Text;
            int d = int.Parse(TextBox4.Text);
            aa.insertrecord(a, b, c, d);
            Response.Write("Book inserted successfully");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            applayer1 a = new applayer1();
            int aaa= int.Parse(TextBox1.Text);
            a.deleterecord(aaa);
            Response.Write("Book deleted successfully");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            applayer1 applayer1 = new applayer1();
            GridView1.DataSourceID = null;
            GridView1.DataSource = applayer1.getrecords();
          //  GridView1.DataBind();
            GridView1.Visible = true;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            applayer1 t = new applayer1();
            int a = int.Parse(TextBox1.Text);
            string b = TextBox2.Text;
            string c = TextBox3.Text;
            int d = int.Parse(TextBox4.Text);
            t.updaterecord(a, b, c, d);
            Response.Write("Book updated successfully");

        }
    }
}
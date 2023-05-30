using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace datalayer
{
    public class Class1
    {
    }
    public class datalayer1
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-95L5PDJ\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        public void add(int bookid, string bookname,string bookdomain, int bookprice)
        {
            SqlDataAdapter sda = new SqlDataAdapter("insert into bookstore values('" + bookid + "','" + bookname + "','" + bookdomain + "','" + bookprice + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        public void delete(int bookid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from bookstore where bookid="+bookid,con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable getall()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from bookstore",con);
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        public void update(int bookid,string bookname,string bookdomain,int bookprice)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("update bookstore set bookid= '" + bookid + " ' ,  bookname = '" + bookname + "' , bookdomain = '" + bookdomain + "' ,  bookprice = '" + bookprice + " ' where bookid = '" + bookid +"'" , con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
        }
    }
}

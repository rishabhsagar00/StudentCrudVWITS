using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        public void clearData()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP - 95L5PDJ\SQLEXPRESS; Initial Catalog = master; Integrated Security = True");
        private BindingSource bs = new BindingSource();
        private DataGridView dataGridView1 = new DataGridView();

        public void display()
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("Select * from Student", con);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Student values(@s_name,@s_id,@s_address,@s_age)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@s_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@s_id", textBox2.Text);
            cmd.Parameters.AddWithValue("@s_address", textBox3.Text);
            cmd.Parameters.AddWithValue("@s_age", textBox4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            clearData();
            MessageBox.Show("Student Added successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-95L5PDJ\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Student", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                dataGridView1.Visible = true;
                // display();
                MessageBox.Show("All records are here");
            }

            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("please Enter the name of student");
            }
            else
            {
                SqlCommand c = new SqlCommand("delete from Student where s_name=@s_name", con);
                c.CommandType = CommandType.Text;
                c.Parameters.AddWithValue("@s_name", textBox1.Text);
                con.Open();
                c.ExecuteNonQuery();
                con.Close();
                clearData();
                MessageBox.Show("Student Details Deleted Successfully");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand s = new SqlCommand("update Student set s_id=@s_id,s_address = @s_address,s_name=@s_name,s_age=@s_age where s_name=@s_name", con);
            s.CommandType = CommandType.Text;
            s.Parameters.AddWithValue("@s_name", textBox1.Text);
            s.Parameters.AddWithValue("@s_id", textBox2.Text);
            s.Parameters.AddWithValue("@s_address", textBox3.Text);
            s.Parameters.AddWithValue("@s_age", textBox4.Text);
            con.Open();
            s.ExecuteNonQuery();
            con.Close();
            clearData();
            MessageBox.Show("Student Details updated successfully");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace Crud_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conString = "Data Source=ZOBAER;Initial Catalog=CrudApplication;Integrated Security=True;TrustServerCertificate=True";
        //Insert
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO CATable(id, name, age) VALUES(@id, @name, @age)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(IDtb.Text));
            cmd.Parameters.AddWithValue("@name",NAMEtb.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(AGEtb.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Inserted");

            if (string.IsNullOrEmpty(IDtb.Text) == true)
            {
                IDtb.Focus();
                errorProvider1.SetError(this.IDtb, "Please fill ID");
            }
            else if(string.IsNullOrEmpty(NAMEtb.Text) == true)
            {
                NAMEtb.Focus();
                errorProvider2.SetError(this.NAMEtb, "Please fill Name");
            }
            else if (string.IsNullOrEmpty(AGEtb.Text) == true)
            {
                AGEtb.Focus();
                errorProvider3.SetError(this.AGEtb, "Please fill Age");
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
            }
        }
        //Delete
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE CATable WHERE id=@id",con);
            cmd.Parameters.AddWithValue("@id", int.Parse(IDtb.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Deleted");
        }
        //Update
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE CATable SET name=@name, age=@age WHERE id=@id",con);
            cmd.Parameters.AddWithValue("@id", int.Parse(IDtb.Text)); 
            cmd.Parameters.AddWithValue("@name", NAMEtb.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(AGEtb.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated");

            if (string.IsNullOrEmpty(IDtb.Text) == true)
            {
                IDtb.Focus();
                errorProvider1.SetError(this.IDtb, "Please fill ID");
            }
            else if (string.IsNullOrEmpty(NAMEtb.Text) == true)
            {
                NAMEtb.Focus();
                errorProvider2.SetError(this.NAMEtb, "Please fill Name");
            }
            else if (string.IsNullOrEmpty(AGEtb.Text) == true)
            {
                AGEtb.Focus();
                errorProvider3.SetError(this.AGEtb, "Please fill Age");
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
            }
        }
        //Search
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CATable WHERE id=@id",con);
            cmd.Parameters.AddWithValue("@id", int.Parse(IDtb.Text));
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}

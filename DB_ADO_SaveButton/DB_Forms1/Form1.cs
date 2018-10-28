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

namespace DB_Forms1
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        DataSet ds;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

            string connectionString = @"Data Source=DMITRI-PC;Initial Catalog=Galaxy;Integrated Security=True;";

            connection = new SqlConnection(connectionString);
            connection.Open();
            adapter = new SqlDataAdapter("Select * from planets", connection);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(ds);
            ds.Clear();
            adapter.Fill(ds);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
         { /*
             //
             try
             {
                 SqlCommand cmd = new SqlCommand(@"select * from planets p where p.name like(@name)", connection);
                 cmd.Parameters.Add(new SqlParameter("@name", "%a%"));
                 SqlDataReader reader = cmd.ExecuteReader();
                 if (reader.HasRows)
                 {
                     while (reader.Read())
                     {
                         MessageBox.Show(reader.GetValue(0).ToString());
                         //if (reader.GetValue(0).ToString().Equals("Earth"))
                         //    connection.Close();                            
                     }
                 }
                 //

                 connection.Close();
             }
             catch(Exception err)
             {
                 MessageBox.Show(err.Message);
             }
        */ }
    }
}

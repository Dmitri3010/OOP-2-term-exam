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

namespace Task3_2_6_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CountTextBox.Enabled = false;
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DMITRI-PC;Initial Catalog=vklady;Integrated Security=True;");
        DataTable dataTable;

        private void CountButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select sum([Sum]) from [Users]", sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            CountTextBox.Text = dataTable.Rows[0][0].ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from [Users]", sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            UserDataGrid.DataSource = dataTable;
        }
    }
}

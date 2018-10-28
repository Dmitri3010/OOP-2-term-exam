using System;
using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace exam2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionstring;
        SqlDataAdapter adapter;
        DataTable StudentTable;
       
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                SqlConnectionStringBuilder connect = new SqlConnectionStringBuilder();
                connectionstring = ConfigurationManager.ConnectionStrings["StudentConnectingString"].ConnectionString;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetDataFromDB()
        {
            int FirstID = Convert.ToInt32(date1.Text);
            int SecondID = Convert.ToInt32(date2.Text);
            if (FirstID < SecondID)
            {
                string sql = " select* from Student where id   between " +FirstID.ToString()+" and "+SecondID.ToString();
                StudentTable = new DataTable();
                SqlConnection connection = null;
                try
                {
                    connection = new SqlConnection(connectionstring);
                    SqlCommand command = new SqlCommand(sql, connection);
                    adapter = new SqlDataAdapter(command);
                    connection.Open();
                    adapter.Fill(StudentTable);
                    StudentGrid.ItemsSource = StudentTable.DefaultView;
                    MessageBox.Show("Data is load succses");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("второе число меньше 1");
           

        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetDataFromDB();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

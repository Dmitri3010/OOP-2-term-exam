using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace DB_ADO_Xml
{

    public partial class MainWindow : Window
    {
      DataSet ds = new DataSet();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveToXML()
        {
            try
            {

                SqlConnection connection = new SqlConnection(@"Data Source=DMITRI-PC;Initial Catalog=Galaxy;Integrated Security=True;");
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from planets", connection);
                adapter.Fill(ds);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.DefaultExt = ".xml";
          
            Nullable<bool> result = dlg.ShowDialog();


            if (result == true)
            {

                ds.WriteXml(dlg.FileName);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveToXML();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1 db = new Model1();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                db.Students.Load();
                list1.ItemsSource = db.Students.Select(c => c.Name).ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try {
                db.Students.Load();
                list2.ItemsSource = db.Students.Select(c => c.Age).ToList();
                    }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

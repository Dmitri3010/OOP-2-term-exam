using System;
using System.Collections.Generic;
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

namespace read_clicks
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int k, m, n;

        private void Blue_Button_Click(object sender, RoutedEventArgs e)
        {
            m++;
            blue_label.Content = m;
            if (m > 10)
            {
                Blue_Button.Background = Brushes.Blue;
            }
        }

        private void Red_Button_Click(object sender, RoutedEventArgs e)
        {
            n++;
            Red_label.Content = n;
            if (n > 10)
            {
                Red_Button.Background = Brushes.Red;
            }
        }

        private void reset_button_Click(object sender, RoutedEventArgs e)
        {
            k = 0;
            n = 0;
            m = 0;
            Red_label.Content = n;
            blue_label.Content = m;
            Green_label1.Content = k;
            Green_Button.Background = Brushes.Gray;
            Red_Button.Background = Brushes.Gray;
            Blue_Button.Background = Brushes.Gray;

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Green_Button_Click(object sender, RoutedEventArgs e)
        {
            k++;
            Green_label1.Content = k;
            if (k > 10)
            {
                Green_Button.Background = Brushes.Green;
            }
        }
    }
}

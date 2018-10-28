using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using task2_entity.models;

namespace task2_entity
{
    public partial class MainWindow : Window
    {
        Db_Context db;

        public MainWindow()
        {
            InitializeComponent();
            db = new Db_Context();
            db.dbSet.Load();
            StudentGrid.ItemsSource = db.dbSet.Select(p => p).ToList();
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Student student = new Student();
                student.Course = Convert.ToInt32(Course_TXB.Text);
                student.Group = Convert.ToInt32(Group_TXB.Text);
                student.Name = Student_TXB.Text;
                db.dbSet.Add(student);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
            try
            {
                int id = Convert.ToInt32(ID_txb.Text);
                db.dbSet.Remove(db.dbSet.Where(p => (p.ID == id)).Select(p => p).First());
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentGrid.ItemsSource = db.dbSet.Select(p => p).ToList(); 
        }
    }
}

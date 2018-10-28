using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using Newtonsoft.Json;

namespace Task1_2_6_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            NameTextBox.Enabled = false;
            GroupTextBox.Enabled = false;
            AgeTextBox.Enabled = false;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            Student student1 = new Student("Olga", "1", "18");
            Student student2 = new Student("Nikita", "2", "19");
            Student student3 = new Student("Pavel", "3", "20");
            Student[] students = new Student[] { student1, student2, student3 };
            List<Student> studentList = new List<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            Department department = new Department("FIT", studentList);
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Department));
            using(FileStream fs = new FileStream("student.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fs, department);
            }

            using (FileStream fs = new FileStream("student.json", FileMode.OpenOrCreate))
            {
                Department newstudent = (Department)jsonSerializer.ReadObject(fs);
                int year = -1;
                bool result = Int32.TryParse(this.YearTextBox.Text, out year);
                if (result)
                {
                    foreach (Student s in newstudent.student)
                    {
                        if (2018 - year == Convert.ToInt32(s._age))
                        {
                            AgeTextBox.Text = s._age;
                            NameTextBox.Text = s._name;
                            GroupTextBox.Text = s._group;
                        }
                    }
                }
            }
        }
    }
}

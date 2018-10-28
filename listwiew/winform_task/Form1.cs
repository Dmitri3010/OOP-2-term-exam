using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_task
{
    public partial class Form1 : Form
    {
       public  List<int> ListOfElement = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Rand()
        {
            Random random = new Random();
            
            for(int i=0; i<10; i++)
            {
                int element = random.Next(1000);
                elements_listView.Items.Add(element.ToString());
                ListOfElement.Add(element);
                index_listView.Items.Add(i.ToString());
            }
        }
        
        private void Find_max()
        {
            max_element.Text = ListOfElement.Max().ToString();
            max_element_txb.Text = ListOfElement.LastIndexOf(ListOfElement.Max()).ToString();

        }

        private void Clear()
        {
            elements_listView.Clear();
            index_listView.Clear();
            ListOfElement.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            Rand();
            Find_max();
            
        }
    }
}

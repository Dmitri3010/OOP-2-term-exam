using System.Windows.Forms;

namespace Task4_1_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Computer computer = new Computer();

        private void ConnectServerFirstButton_Click(object sender, System.EventArgs e)
        {
            computer.Connect("BelstuServer", "192.16.13.15");
            IPRichTextBox.Text += computer.Server.IPAdress + " " + computer.Server.ServerName + "\n";
        }

        private void ConnectServerSecondButton_Click(object sender, System.EventArgs e)
        {
            computer.Server = BstuNet.GetServer("BeCloud", "172.16.13.15");
            IPRichTextBox.Text += computer.Server.IPAdress + " " + computer.Server.ServerName + "\n";
        }
    }
}
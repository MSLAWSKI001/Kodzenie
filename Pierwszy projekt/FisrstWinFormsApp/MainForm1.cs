using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FisrstWinFormsApp
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        

        private void MainForm1_Load(object sender, EventArgs e)
        {

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wiataj w pierwszym programie WinForms");
        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {
            Environment.Exit(128);
        }

        private void buttonHelloName_MouseClick(object sender, MouseEventArgs e)
        {
            string message = "Witaj "+textBoxName.Text+" w tym programie";
            MessageBox.Show(message);
        }

        private void buttonHelloName_Click(object sender, EventArgs e)
        {
            string strAge = textBoxAge.Text;
            if (string.IsNullOrWhiteSpace(strAge))
            {
                Message.Show("Nie podano wieku");
                return;
            }
            int age;
            if (!int.TryParse(strAge, out age))
            { 
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

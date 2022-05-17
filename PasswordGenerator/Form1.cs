using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            tabControl1.SelectedTab = tabPage2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("успешный вход");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            Size = new Size(434, 415);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            Size = new Size(586, 418);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("успешный вход");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(434, 415);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Size = new Size(434, 415);
            tabControl1.SelectedTab = tabPage2;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
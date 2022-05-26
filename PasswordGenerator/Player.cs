using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName + @"\fishDance.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        public void ChangeLabel(string text)
        {
            label1.Text = text;
        }

        private void Player_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}

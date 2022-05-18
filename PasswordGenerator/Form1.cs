using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool mailMatch;
        private bool passwordMatch;
        private const string numbers = "1234567890";
        private const string cyrillic = "ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
        private const string symbols = "`~!#$%^&*()-_=+;:'/.,<>|\"";
        private bool confirmPassMatch;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            tabControl1.SelectedTab = tabPage2;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(434, 415);

        }

        private void signButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Equals("") || passwordTextBox.Text.Equals(""))
            {
                incorrectDataLabel.Text = "Поля не могут быть пустыми";
                incorrectDataLabel.Visible = true;
                return;
            }
            else 
            {
                using (var connection = new SQLiteConnection(@"Data Source=..\..\passwordGenerator.db;Mode=ReadOnly")) 
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = $"SELECT * FROM users WHERE login = '{loginTextBox.Text}' AND pass = '{passwordTextBox.Text}'";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int id = 0;
                        if (reader.HasRows && reader.Read() && int.TryParse(reader.GetValue(0).ToString(), out id))
                        {
                            passwordTextBox.Text = string.Empty;
                            MessageBox.Show("успешно");
                            return;
                        }
                    }
                }
            }
            
            incorrectDataLabel.Text = "Неверные логин или пароль";
            incorrectDataLabel.Visible = true;

        }

        private void generatePassBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            Size = new Size(586, 418);
        }

        private void signBtn2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("успешный вход");
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            Size = new Size(434, 415);
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            Size = new Size(434, 415);
            tabControl1.SelectedTab = tabPage2;
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            mailMatch = loginTextBox.Text.Length >= 3 && !symbols.Contains(loginTextBox.Text) && !cyrillic.Intersect(loginTextBox.Text).Any();
            if (mailMatch)
            {
                mailTip.ToolTipTitle = "Логин";
                mailTip.SetToolTip(mailCheck, "Все в порядке");
                mailCheck.Text = "✔️";
                mailCheck.ForeColor = Color.Green;
            }
            else
            {
                mailTip.ToolTipTitle = "Неверный формат логина";
                mailTip.SetToolTip(mailCheck, "Логин должен состоять из более, чем 3 символов, только латиница и цыфры");
                mailCheck.Text = "❌";
                mailCheck.ForeColor = Color.Red;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordMatch = passwordTextBox.Text.Length > 7 && !cyrillic.Intersect(passwordTextBox.Text).Any();
            if (!passwordMatch)
            {
                passTip.ToolTipTitle = "Почему пароль не подходит?";
                passTip.SetToolTip(passwordCheck, "• Пароль должен содержать минимум 8 символов\n" +
                    "• Пароль не должен содержать символов кириллицы");
                passwordCheck.Text = "❌";
                passwordCheck.ForeColor = Color.Red;
            }
            else
            {
                passTip.ToolTipTitle = "Пароль";
                passTip.SetToolTip(passwordCheck, "Надежный пароль");
                passwordCheck.Text = "✔️";
                passwordCheck.ForeColor = Color.Green;
            }
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPassCheckBox.Checked;
        }

        private void loginTB_TextChanged(object sender, EventArgs e)
        {
            mailMatch = loginTB.Text.Length >= 3 && !symbols.Contains(loginTB.Text) && !cyrillic.Intersect(loginTB.Text).Any();
            if (mailMatch)
            {
                mailTip2.ToolTipTitle = "Логин";
                mailTip2.SetToolTip(mailCheck2, "Все в порядке");
                mailCheck2.Text = "✔️";
                mailCheck2.ForeColor = Color.Green;
            }
            else
            {
                mailTip2.ToolTipTitle = "Неверный формат логина";
                mailTip2.SetToolTip(mailCheck2, "Логин должен состоять из более, чем 3 символов");
                mailCheck2.Text = "❌";
                mailCheck2.ForeColor = Color.Red;
            }
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordMatch = passTextBox.Text.Length > 7 && !cyrillic.Intersect(passTextBox.Text).Any();
            if (!passwordMatch)
            {
                passTip2.ToolTipTitle = "Почему пароль не подходит?";
                passTip2.SetToolTip(passCheck2, "• Пароль должен содержать минимум 8 символов\n" +
                    "• Пароль не должен содержать символов кириллицы");
                passCheck2.Text = "❌";
                passCheck2.ForeColor = Color.Red;
            }
            else
            {
                passTip2.ToolTipTitle = "Пароль";
                passTip2.SetToolTip(passCheck2, "Надежный пароль");
                passCheck2.Text = "✔️";
                passCheck2.ForeColor = Color.Green;
            }
        }

        private void confirmPassTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmPassTip.ToolTipTitle = "Подтверждение";

            confirmPassMatch = confirmPassTextBox.Text.Equals(passTextBox.Text) && passTextBox.Text.Length > 7;
            if (confirmPassMatch)
            {
                confirmPassTip.SetToolTip(confirmPassCheck, "Все в порядке");
                confirmPassCheck.Text = "✔️";
                confirmPassCheck.ForeColor = Color.Green;
            }
            else
            {
                confirmPassTip.SetToolTip(confirmPassCheck, "Пароли должны совпадать");
                confirmPassCheck.Text = "❌";
                confirmPassCheck.ForeColor = Color.Red;
            }
        }

        private void showPassCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = !showPassCheckBox2.Checked;
        }

        private void showConfirmPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            confirmPassTextBox.UseSystemPasswordChar = !showConfirmPassCheckBox.Checked;
        }
    }
}
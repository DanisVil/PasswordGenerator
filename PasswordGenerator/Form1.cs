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
using NLog;
using System.Security.Cryptography;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private Color backColor = Color.FromArgb(38, 38, 38), controlColor = Color.FromArgb(160, 60, 60);
        private static Logger logger = LogManager.GetCurrentClassLogger();
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
            comboBox1.SelectedIndex = 0;
            tabPage1.BackColor = backColor;
            tabPage2.BackColor = backColor;
            tabPage3.BackColor = backColor;
            SetStyle(signButton, controlColor);
            SetStyle(signBtn2, controlColor);
            SetStyle(goBackBtn, controlColor);
            SetStyle(generatePassBtn, controlColor);
            SetStyle(backBtn2, controlColor);
            SetStyle(confirmGeneration, controlColor);
        }
        private void SetStyle (Control c, Color color)
        {
            c.BackColor = color;
            Button btn = c as Button;
            if (btn != null)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
                btn.ForeColor = Color.White;
            }
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
                try
                {
                    using (var connection = new SQLiteConnection(@"Data Source=..\..\passwordGenerator.db;Mode=ReadOnly"))
                    {
                        connection.Open();
                        logger.Info("Успешное подключение к бд");
                        SQLiteCommand command = new SQLiteCommand();
                        command.Connection = connection;
                        command.CommandText = $"SELECT * FROM users WHERE login = @name AND pass = @hash";
                        command.Parameters.Add(new SQLiteParameter("@hash", HashPass.PasswordToHashSalt(passwordTextBox.Text, loginTextBox.Text)));
                        command.Parameters.Add(new SQLiteParameter("@name", loginTextBox.Text));
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            int id = 0;
                            if (reader.HasRows && reader.Read() && int.TryParse(reader.GetValue(0).ToString(), out id))
                            {
                                passwordTextBox.Text = string.Empty;
                                logger.Info("Человек зашел куда хотел");
                                Player player = new Player();
                                player.ChangeLabel("Добро пожаловать," + loginTextBox.Text + "!!!");
                                player.ShowDialog();
                                return;
                            }
                        }
                    }
                }
                catch (Exception excep)
                {
                    logger.Error($"Ошибка в бд и в геноме того кто ее создал{excep.Message}");
                }
            }
            
            incorrectDataLabel.Text = "Неверные логин или пароль";
            logger.Info("Кто то забыл пароль");
            incorrectDataLabel.Visible = true;

        }

        private void generatePassBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            Size = new Size(586, 418);
        }
        private void signBtn2_Click(object sender, EventArgs e)
        {
            if (!CheckCorrectRegistr())
            {
                MessageBox.Show("Заполните все");
                return;
            }
            if (CheckMail())
            {
                MessageBox.Show("Такой логин существует");
                return;
            }
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=..\..\passwordGenerator.db"))
                {
                    connection.Open();
                    logger.Info("Успешное подключение к базе");
                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO users (login, pass) VALUES (@name, @hash)";
                    command.Parameters.Add(new SQLiteParameter("@hash", HashPass.PasswordToHashSalt(passTextBox.Text, loginTB.Text)));
                    command.Parameters.Add(new SQLiteParameter("@name", loginTB.Text));
                    command.ExecuteNonQuery();
                }
                Player player = new Player();
                player.ChangeLabel("Добро пожаловать," + loginTB.Text + "!!!");
                player.ShowDialog();
                logger.Info("Кто то благополучно зашел туда куда ему надо");
            }
            catch (Exception excep)
            {
                logger.Error($"Ошибка подключения к бд: {excep.Message}") ;
            }
        }

        private bool CheckMail()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=..\..\passwordGenerator.db;Mode=ReadOnly"))
                {
                    connection.Open();
                    logger.Info("Успешное подключение к базе");
                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = $"SELECT * FROM users WHERE login = '{loginTB.Text}'";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            logger.Info("Кто то хотел зарегистрировать существующий логин");
                            return true;
                        }
                    }
                }
            }
            catch (Exception excep)
            {
                logger.Error($"Ошибка подключения к бд: {excep.Message}");
            }
            return false;
        }

        private bool CheckCorrectRegistr()
        {
            return passCheck2.ForeColor == Color.Green && confirmPassCheck.ForeColor == Color.Green && mailCheck2.ForeColor == Color.Green;
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
            passwordMatch = passwordTextBox.Text.Length > 5 && !cyrillic.Intersect(passwordTextBox.Text).Any();
            if (!passwordMatch)
            {
                passTip.ToolTipTitle = "Почему пароль не подходит?";
                passTip.SetToolTip(passwordCheck, "• Пароль должен содержать минимум 6 символов\n" +
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
            passwordTextBox.Password = !showPassCheckBox.Checked;
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
            passwordMatch = passTextBox.Text.Length > 5 && !cyrillic.Intersect(passTextBox.Text).Any();
            if (!passwordMatch)
            {
                passTip2.ToolTipTitle = "Почему пароль не подходит?";
                passTip2.SetToolTip(passCheck2, "• Пароль должен содержать минимум 6 символов\n" +
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
                confirmPassMatch = passTextBox.Text.Equals(confirmPassTextBox.Text) && passTextBox.Text.Length > 5;
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
        }

        private void confirmPassTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmPassTip.ToolTipTitle = "Подтверждение";

            confirmPassMatch = confirmPassTextBox.Text.Equals(passTextBox.Text) && passTextBox.Text.Length > 5;
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
            passTextBox.Password = !showPassCheckBox2.Checked;
        }

        private void showConfirmPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            confirmPassTextBox.Password = !showConfirmPassCheckBox.Checked;
        }

        private void confirmGeneration_Click(object sender, EventArgs e)
        {
            bool flag = checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox6.Checked;
            
            if (!flag)
            {
                MessageBox.Show("Выберите параметры");
                return;
            }
            ConfigGenerator();
            do
            {
                genPassTB.Text = GenericPassword.GetPass(); 
            } while (ThereHit(genPassTB.Text));
            passTextBox.Text = genPassTB.Text;
            confirmPassTextBox.Text = genPassTB.Text;
        }

        private bool ThereHit(string password)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=..\..\passwordGenerator.db;Mode=ReadOnly"))
                {
                    connection.Open();
                    logger.Info("Успешное подключение");
                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = $"SELECT login,pass FROM users";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (HashPass.PasswordToHashSalt(password, reader.GetString(0)).Equals(reader.GetString(1)))
                                {
                                    logger.Info("Нашлось совпадение по сгенерированным паролям");
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception excep)
            {
                logger.Error($"Ошибка подключения бд:{excep.Message}");
            }
            
            return false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ConfigGenerator()
        {
            int length;
            if (!int.TryParse(comboBox1.Text, out length))
            {
                length = 6;
            }
            GenericPassword.IncludeNumbers = checkBox1.Checked;
            GenericPassword.IncludeSimbols = checkBox6.Checked;
            GenericPassword.Length = length;
            GenericPassword.LowerCase = checkBox2.Checked;
            GenericPassword.UpperCase = checkBox3.Checked;
            GenericPassword.SimilarChar = checkBox5.Checked;
            GenericPassword.AmbiguousChar = checkBox7.Checked;
            GenericPassword.WordOn = checkBox4.Checked;
        }
    }
}
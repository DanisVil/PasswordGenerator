using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.showPassCheckBox = new System.Windows.Forms.CheckBox();
            this.mailCheck = new System.Windows.Forms.Label();
            this.passwordCheck = new System.Windows.Forms.Label();
            this.incorrectDataLabel = new System.Windows.Forms.Label();
            this.signButton = new MaterialSkin.Controls.MaterialButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.loginTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.showConfirmPassCheckBox = new System.Windows.Forms.CheckBox();
            this.showPassCheckBox2 = new System.Windows.Forms.CheckBox();
            this.confirmPassCheck = new System.Windows.Forms.Label();
            this.mailCheck2 = new System.Windows.Forms.Label();
            this.passCheck2 = new System.Windows.Forms.Label();
            this.passTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.confirmPassTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.loginTB = new MaterialSkin.Controls.MaterialTextBox();
            this.signBtn2 = new MaterialSkin.Controls.MaterialButton();
            this.generatePassBtn = new MaterialSkin.Controls.MaterialButton();
            this.goBackBtn = new MaterialSkin.Controls.MaterialButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.genPassTB = new MaterialSkin.Controls.MaterialTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmGeneration = new MaterialSkin.Controls.MaterialButton();
            this.backBtn2 = new MaterialSkin.Controls.MaterialButton();
            this.passTip = new System.Windows.Forms.ToolTip(this.components);
            this.mailTip = new System.Windows.Forms.ToolTip(this.components);
            this.passTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.mailTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.confirmPassTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Depth = 0;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 376);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage1.Controls.Add(this.showPassCheckBox);
            this.tabPage1.Controls.Add(this.mailCheck);
            this.tabPage1.Controls.Add(this.passwordCheck);
            this.tabPage1.Controls.Add(this.incorrectDataLabel);
            this.tabPage1.Controls.Add(this.signButton);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.passwordTextBox);
            this.tabPage1.Controls.Add(this.loginTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // showPassCheckBox
            // 
            this.showPassCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.showPassCheckBox.AutoSize = true;
            this.showPassCheckBox.FlatAppearance.BorderSize = 0;
            this.showPassCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.showPassCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassCheckBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPassCheckBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.showPassCheckBox.Location = new System.Drawing.Point(100, 227);
            this.showPassCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showPassCheckBox.Name = "showPassCheckBox";
            this.showPassCheckBox.Size = new System.Drawing.Size(125, 26);
            this.showPassCheckBox.TabIndex = 9;
            this.showPassCheckBox.Text = "Показать пароль";
            this.showPassCheckBox.UseVisualStyleBackColor = true;
            this.showPassCheckBox.CheckedChanged += new System.EventHandler(this.showPassCheckBox_CheckedChanged);
            // 
            // mailCheck
            // 
            this.mailCheck.AutoSize = true;
            this.mailCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailCheck.ForeColor = System.Drawing.Color.Red;
            this.mailCheck.Location = new System.Drawing.Point(337, 100);
            this.mailCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mailCheck.Name = "mailCheck";
            this.mailCheck.Size = new System.Drawing.Size(28, 17);
            this.mailCheck.TabIndex = 7;
            this.mailCheck.Text = "    ";
            // 
            // passwordCheck
            // 
            this.passwordCheck.AutoSize = true;
            this.passwordCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordCheck.ForeColor = System.Drawing.Color.Red;
            this.passwordCheck.Location = new System.Drawing.Point(337, 187);
            this.passwordCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordCheck.Name = "passwordCheck";
            this.passwordCheck.Size = new System.Drawing.Size(0, 17);
            this.passwordCheck.TabIndex = 8;
            // 
            // incorrectDataLabel
            // 
            this.incorrectDataLabel.AutoSize = true;
            this.incorrectDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.incorrectDataLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.incorrectDataLabel.Location = new System.Drawing.Point(77, 247);
            this.incorrectDataLabel.Name = "incorrectDataLabel";
            this.incorrectDataLabel.Size = new System.Drawing.Size(0, 15);
            this.incorrectDataLabel.TabIndex = 6;
            this.incorrectDataLabel.Visible = false;
            // 
            // signButton
            // 
            this.signButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signButton.Depth = 0;
            this.signButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signButton.HighEmphasis = true;
            this.signButton.Icon = null;
            this.signButton.Location = new System.Drawing.Point(162, 262);
            this.signButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.signButton.Name = "signButton";
            this.signButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signButton.Size = new System.Drawing.Size(71, 36);
            this.signButton.TabIndex = 5;
            this.signButton.Text = "Войти";
            this.signButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.signButton.UseAccentColor = false;
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(106, 304);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ешё не зарегистрировались?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AnimateReadOnly = false;
            this.passwordTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.Hint = "Введите пароль";
            this.passwordTextBox.LeadingIcon = global::PasswordGenerator.Properties.Resources.padlock;
            this.passwordTextBox.Location = new System.Drawing.Point(100, 171);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Password = true;
            this.passwordTextBox.Size = new System.Drawing.Size(221, 50);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "";
            this.passwordTextBox.TrailingIcon = null;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // loginTextBox
            // 
            this.loginTextBox.AnimateReadOnly = false;
            this.loginTextBox.BackColor = System.Drawing.Color.Salmon;
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.Depth = 0;
            this.loginTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginTextBox.ForeColor = System.Drawing.Color.White;
            this.loginTextBox.Hint = "Введите логин";
            this.loginTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginTextBox.LeadingIcon = global::PasswordGenerator.Properties.Resources.user;
            this.loginTextBox.Location = new System.Drawing.Point(100, 85);
            this.loginTextBox.MaxLength = 50;
            this.loginTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.loginTextBox.Multiline = false;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(221, 50);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.Text = "";
            this.loginTextBox.TrailingIcon = null;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPage2.Controls.Add(this.showConfirmPassCheckBox);
            this.tabPage2.Controls.Add(this.showPassCheckBox2);
            this.tabPage2.Controls.Add(this.confirmPassCheck);
            this.tabPage2.Controls.Add(this.mailCheck2);
            this.tabPage2.Controls.Add(this.passCheck2);
            this.tabPage2.Controls.Add(this.passTextBox);
            this.tabPage2.Controls.Add(this.confirmPassTextBox);
            this.tabPage2.Controls.Add(this.loginTB);
            this.tabPage2.Controls.Add(this.signBtn2);
            this.tabPage2.Controls.Add(this.generatePassBtn);
            this.tabPage2.Controls.Add(this.goBackBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // showConfirmPassCheckBox
            // 
            this.showConfirmPassCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.showConfirmPassCheckBox.AutoSize = true;
            this.showConfirmPassCheckBox.FlatAppearance.BorderSize = 0;
            this.showConfirmPassCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showConfirmPassCheckBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.showConfirmPassCheckBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.showConfirmPassCheckBox.Location = new System.Drawing.Point(56, 236);
            this.showConfirmPassCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showConfirmPassCheckBox.Name = "showConfirmPassCheckBox";
            this.showConfirmPassCheckBox.Size = new System.Drawing.Size(125, 26);
            this.showConfirmPassCheckBox.TabIndex = 13;
            this.showConfirmPassCheckBox.Text = "Показать пароль";
            this.showConfirmPassCheckBox.UseVisualStyleBackColor = true;
            this.showConfirmPassCheckBox.CheckedChanged += new System.EventHandler(this.showConfirmPassCheckBox_CheckedChanged);
            // 
            // showPassCheckBox2
            // 
            this.showPassCheckBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.showPassCheckBox2.AutoSize = true;
            this.showPassCheckBox2.FlatAppearance.BorderSize = 0;
            this.showPassCheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassCheckBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPassCheckBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.showPassCheckBox2.Location = new System.Drawing.Point(56, 148);
            this.showPassCheckBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showPassCheckBox2.Name = "showPassCheckBox2";
            this.showPassCheckBox2.Size = new System.Drawing.Size(125, 26);
            this.showPassCheckBox2.TabIndex = 12;
            this.showPassCheckBox2.Text = "Показать пароль";
            this.showPassCheckBox2.UseVisualStyleBackColor = true;
            this.showPassCheckBox2.CheckedChanged += new System.EventHandler(this.showPassCheckBox2_CheckedChanged);
            // 
            // confirmPassCheck
            // 
            this.confirmPassCheck.AutoSize = true;
            this.confirmPassCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPassCheck.ForeColor = System.Drawing.Color.Red;
            this.confirmPassCheck.Location = new System.Drawing.Point(333, 205);
            this.confirmPassCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPassCheck.Name = "confirmPassCheck";
            this.confirmPassCheck.Size = new System.Drawing.Size(0, 17);
            this.confirmPassCheck.TabIndex = 11;
            // 
            // mailCheck2
            // 
            this.mailCheck2.AutoSize = true;
            this.mailCheck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailCheck2.ForeColor = System.Drawing.Color.Red;
            this.mailCheck2.Location = new System.Drawing.Point(333, 64);
            this.mailCheck2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mailCheck2.Name = "mailCheck2";
            this.mailCheck2.Size = new System.Drawing.Size(28, 17);
            this.mailCheck2.TabIndex = 9;
            this.mailCheck2.Text = "    ";
            // 
            // passCheck2
            // 
            this.passCheck2.AutoSize = true;
            this.passCheck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passCheck2.ForeColor = System.Drawing.Color.Red;
            this.passCheck2.Location = new System.Drawing.Point(333, 123);
            this.passCheck2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passCheck2.Name = "passCheck2";
            this.passCheck2.Size = new System.Drawing.Size(0, 17);
            this.passCheck2.TabIndex = 10;
            // 
            // passTextBox
            // 
            this.passTextBox.AnimateReadOnly = false;
            this.passTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTextBox.Depth = 0;
            this.passTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passTextBox.Hint = "Введите пароль";
            this.passTextBox.LeadingIcon = global::PasswordGenerator.Properties.Resources.padlock;
            this.passTextBox.Location = new System.Drawing.Point(56, 92);
            this.passTextBox.MaxLength = 50;
            this.passTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passTextBox.Multiline = false;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Password = true;
            this.passTextBox.Size = new System.Drawing.Size(270, 50);
            this.passTextBox.TabIndex = 5;
            this.passTextBox.Text = "";
            this.passTextBox.TrailingIcon = null;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.AnimateReadOnly = false;
            this.confirmPassTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.confirmPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPassTextBox.Depth = 0;
            this.confirmPassTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.confirmPassTextBox.Hint = "Подтвердите пароль";
            this.confirmPassTextBox.LeadingIcon = global::PasswordGenerator.Properties.Resources.padlock;
            this.confirmPassTextBox.Location = new System.Drawing.Point(56, 180);
            this.confirmPassTextBox.MaxLength = 50;
            this.confirmPassTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.confirmPassTextBox.Multiline = false;
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.Password = true;
            this.confirmPassTextBox.Size = new System.Drawing.Size(270, 50);
            this.confirmPassTextBox.TabIndex = 4;
            this.confirmPassTextBox.Text = "";
            this.confirmPassTextBox.TrailingIcon = null;
            this.confirmPassTextBox.TextChanged += new System.EventHandler(this.confirmPassTextBox_TextChanged);
            // 
            // loginTB
            // 
            this.loginTB.AnimateReadOnly = false;
            this.loginTB.BackColor = System.Drawing.Color.PeachPuff;
            this.loginTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTB.Depth = 0;
            this.loginTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginTB.Hint = "Введите логин";
            this.loginTB.LeadingIcon = global::PasswordGenerator.Properties.Resources.user;
            this.loginTB.Location = new System.Drawing.Point(56, 21);
            this.loginTB.MaxLength = 50;
            this.loginTB.MouseState = MaterialSkin.MouseState.OUT;
            this.loginTB.Multiline = false;
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(270, 50);
            this.loginTB.TabIndex = 3;
            this.loginTB.Text = "";
            this.loginTB.TrailingIcon = null;
            this.loginTB.TextChanged += new System.EventHandler(this.loginTB_TextChanged);
            // 
            // signBtn2
            // 
            this.signBtn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signBtn2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signBtn2.Depth = 0;
            this.signBtn2.HighEmphasis = true;
            this.signBtn2.Icon = null;
            this.signBtn2.Location = new System.Drawing.Point(337, 320);
            this.signBtn2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signBtn2.MouseState = MaterialSkin.MouseState.HOVER;
            this.signBtn2.Name = "signBtn2";
            this.signBtn2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signBtn2.Size = new System.Drawing.Size(64, 36);
            this.signBtn2.TabIndex = 2;
            this.signBtn2.Text = "Вход";
            this.signBtn2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.signBtn2.UseAccentColor = false;
            this.signBtn2.UseVisualStyleBackColor = true;
            this.signBtn2.Click += new System.EventHandler(this.signBtn2_Click);
            // 
            // generatePassBtn
            // 
            this.generatePassBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generatePassBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.generatePassBtn.Depth = 0;
            this.generatePassBtn.HighEmphasis = true;
            this.generatePassBtn.Icon = null;
            this.generatePassBtn.Location = new System.Drawing.Point(124, 320);
            this.generatePassBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generatePassBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.generatePassBtn.Name = "generatePassBtn";
            this.generatePassBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.generatePassBtn.Size = new System.Drawing.Size(152, 36);
            this.generatePassBtn.TabIndex = 1;
            this.generatePassBtn.Text = "Создать пароль";
            this.generatePassBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.generatePassBtn.UseAccentColor = false;
            this.generatePassBtn.UseVisualStyleBackColor = true;
            this.generatePassBtn.Click += new System.EventHandler(this.generatePassBtn_Click);
            // 
            // goBackBtn
            // 
            this.goBackBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.goBackBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.goBackBtn.Depth = 0;
            this.goBackBtn.HighEmphasis = true;
            this.goBackBtn.Icon = null;
            this.goBackBtn.Location = new System.Drawing.Point(9, 320);
            this.goBackBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.goBackBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.goBackBtn.Size = new System.Drawing.Size(71, 36);
            this.goBackBtn.TabIndex = 0;
            this.goBackBtn.Text = "Назад";
            this.goBackBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.goBackBtn.UseAccentColor = false;
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.checkBox7);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.checkBox5);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.checkBox6);
            this.tabPage3.Controls.Add(this.checkBox4);
            this.tabPage3.Controls.Add(this.checkBox3);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.genPassTB);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.confirmGeneration);
            this.tabPage3.Controls.Add(this.backBtn2);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(559, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55"});
            this.comboBox1.Location = new System.Drawing.Point(324, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox7.Location = new System.Drawing.Point(324, 281);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(189, 22);
            this.checkBox7.TabIndex = 20;
            this.checkBox7.Text = "(Например : (){}[]<>:;\"\',.)";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(12, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(303, 18);
            this.label14.TabIndex = 19;
            this.label14.Text = "Использовать  неоднозначные символы :";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox5.Location = new System.Drawing.Point(324, 249);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(202, 22);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "(Например : i,I, 1,L, o,0,O)";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(12, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(237, 18);
            this.label13.TabIndex = 17;
            this.label13.Text = "Исключить подобные символы :";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBox6.Location = new System.Drawing.Point(324, 135);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(170, 22);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "(Например : @#$%^)";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(324, 109);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox3.Location = new System.Drawing.Point(324, 190);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(185, 22);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "(Например : QWERTY)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox2.Location = new System.Drawing.Point(324, 218);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(162, 22);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "(Например : qwerty)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(324, 163);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 22);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "(например : 123456 )";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // genPassTB
            // 
            this.genPassTB.AnimateReadOnly = false;
            this.genPassTB.BackColor = System.Drawing.Color.PeachPuff;
            this.genPassTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genPassTB.Depth = 0;
            this.genPassTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.genPassTB.LeadingIcon = null;
            this.genPassTB.Location = new System.Drawing.Point(217, 19);
            this.genPassTB.MaxLength = 50;
            this.genPassTB.MouseState = MaterialSkin.MouseState.OUT;
            this.genPassTB.Multiline = false;
            this.genPassTB.Name = "genPassTB";
            this.genPassTB.ReadOnly = true;
            this.genPassTB.Size = new System.Drawing.Size(269, 50);
            this.genPassTB.TabIndex = 10;
            this.genPassTB.Text = "";
            this.genPassTB.TrailingIcon = null;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.Location = new System.Drawing.Point(12, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "Длина пароля :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(12, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Включить числа:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(12, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Использовать английские маты :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(12, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Включить символы :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(12, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Включить прописные символы :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Включить строчные символы :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(11, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ваш новый пароль : ";
            // 
            // confirmGeneration
            // 
            this.confirmGeneration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.confirmGeneration.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.confirmGeneration.Depth = 0;
            this.confirmGeneration.HighEmphasis = true;
            this.confirmGeneration.Icon = null;
            this.confirmGeneration.Location = new System.Drawing.Point(438, 319);
            this.confirmGeneration.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.confirmGeneration.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmGeneration.Name = "confirmGeneration";
            this.confirmGeneration.NoAccentTextColor = System.Drawing.Color.Empty;
            this.confirmGeneration.Size = new System.Drawing.Size(112, 36);
            this.confirmGeneration.TabIndex = 2;
            this.confirmGeneration.Text = "Применить";
            this.confirmGeneration.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.confirmGeneration.UseAccentColor = false;
            this.confirmGeneration.UseVisualStyleBackColor = true;
            this.confirmGeneration.Click += new System.EventHandler(this.confirmGeneration_Click);
            // 
            // backBtn2
            // 
            this.backBtn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.backBtn2.Depth = 0;
            this.backBtn2.HighEmphasis = true;
            this.backBtn2.Icon = null;
            this.backBtn2.Location = new System.Drawing.Point(15, 319);
            this.backBtn2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backBtn2.MouseState = MaterialSkin.MouseState.HOVER;
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.backBtn2.Size = new System.Drawing.Size(71, 36);
            this.backBtn2.TabIndex = 1;
            this.backBtn2.Text = "назад";
            this.backBtn2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.backBtn2.UseAccentColor = false;
            this.backBtn2.UseVisualStyleBackColor = true;
            this.backBtn2.Click += new System.EventHandler(this.backBtn2_Click);
            // 
            // passTip
            // 
            this.passTip.ToolTipTitle = "Почему пароль не подходит?";
            // 
            // mailTip2
            // 
            this.mailTip2.ToolTipTitle = "Почему пароль не подходит?";
            // 
            // confirmPassTip
            // 
            this.confirmPassTip.ToolTipTitle = "Подтверждение пароля";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(567, 376);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(586, 418);
            this.MinimumSize = new System.Drawing.Size(434, 415);
            this.Name = "Form1";
            this.Text = "Генератор паролей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
        private MaterialSkin.Controls.MaterialTextBox loginTextBox;
        private LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialButton signBtn2;
        private MaterialSkin.Controls.MaterialButton generatePassBtn;
        private MaterialSkin.Controls.MaterialButton goBackBtn;
        private MaterialSkin.Controls.MaterialButton signButton;
        private MaterialSkin.Controls.MaterialTextBox loginTB;
        private MaterialSkin.Controls.MaterialTextBox passTextBox;
        private MaterialSkin.Controls.MaterialTextBox confirmPassTextBox;
        private CheckBox checkBox7;
        private Label label14;
        private CheckBox checkBox5;
        private Label label13;
        private CheckBox checkBox6;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private MaterialSkin.Controls.MaterialTextBox genPassTB;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private MaterialSkin.Controls.MaterialButton confirmGeneration;
        private MaterialSkin.Controls.MaterialButton backBtn2;
        private ComboBox comboBox1;
        private Label incorrectDataLabel;
        private Label mailCheck;
        private Label passwordCheck;
        private ToolTip passTip;
        private ToolTip mailTip;
        private CheckBox showPassCheckBox;
        private Label mailCheck2;
        private Label passCheck2;
        private ToolTip passTip2;
        private ToolTip mailTip2;
        private Label confirmPassCheck;
        private ToolTip confirmPassTip;
        private CheckBox showConfirmPassCheckBox;
        private CheckBox showPassCheckBox2;
    }
}


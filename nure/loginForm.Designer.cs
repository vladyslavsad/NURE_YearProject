namespace nure
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            login = new TabPage();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            logInButton = new Button();
            userFieldLogIn = new TextBox();
            passwordFieldLogIn = new TextBox();
            register = new TabPage();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            registerButton = new Button();
            registerPasswordField = new TextBox();
            registerUserField = new TextBox();
            panel5 = new Panel();
            label2 = new Label();
            tabControl1.SuspendLayout();
            login.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            register.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(login);
            tabControl1.Controls.Add(register);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // login
            // 
            login.BackColor = Color.Ivory;
            login.Controls.Add(panel1);
            login.Location = new Point(4, 29);
            login.Name = "login";
            login.Padding = new Padding(3);
            login.Size = new Size(792, 417);
            login.TabIndex = 0;
            login.Text = "вхід";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(logInButton);
            panel1.Controls.Add(userFieldLogIn);
            panel1.Controls.Add(passwordFieldLogIn);
            panel1.Location = new Point(230, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 280);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources._8666757_lock_security_icon;
            pictureBox2.Location = new Point(41, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources._8666609_user_icon;
            pictureBox1.Location = new Point(41, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(15, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 49);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 31);
            label1.TabIndex = 0;
            label1.Text = "Вхід";
            // 
            // logInButton
            // 
            logInButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logInButton.Location = new Point(83, 214);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(146, 37);
            logInButton.TabIndex = 2;
            logInButton.Text = "увійти";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // userFieldLogIn
            // 
            userFieldLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userFieldLogIn.Location = new Point(115, 105);
            userFieldLogIn.Name = "userFieldLogIn";
            userFieldLogIn.Size = new Size(197, 27);
            userFieldLogIn.TabIndex = 1;
            // 
            // passwordFieldLogIn
            // 
            passwordFieldLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            passwordFieldLogIn.Location = new Point(115, 152);
            passwordFieldLogIn.Name = "passwordFieldLogIn";
            passwordFieldLogIn.Size = new Size(197, 27);
            passwordFieldLogIn.TabIndex = 0;
            // 
            // register
            // 
            register.BackColor = Color.Ivory;
            register.Controls.Add(panel4);
            register.ForeColor = SystemColors.ActiveCaptionText;
            register.Location = new Point(4, 29);
            register.Name = "register";
            register.Padding = new Padding(3);
            register.Size = new Size(792, 417);
            register.TabIndex = 1;
            register.Text = "регістрація";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.SlateGray;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(registerButton);
            panel4.Controls.Add(registerPasswordField);
            panel4.Controls.Add(registerUserField);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(230, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(338, 280);
            panel4.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._8666757_lock_security_icon;
            pictureBox4.Location = new Point(43, 152);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._8666609_user_icon;
            pictureBox3.Location = new Point(43, 105);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(83, 214);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(146, 37);
            registerButton.TabIndex = 3;
            registerButton.Text = "зареєструватися ";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // registerPasswordField
            // 
            registerPasswordField.Location = new Point(115, 152);
            registerPasswordField.Name = "registerPasswordField";
            registerPasswordField.Size = new Size(197, 27);
            registerPasswordField.TabIndex = 2;
            // 
            // registerUserField
            // 
            registerUserField.Location = new Point(115, 105);
            registerUserField.Name = "registerUserField";
            registerUserField.Size = new Size(197, 27);
            registerUserField.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkTurquoise;
            panel5.Controls.Add(label2);
            panel5.Location = new Point(14, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(310, 49);
            panel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(88, 9);
            label2.Name = "label2";
            label2.Size = new Size(132, 31);
            label2.TabIndex = 0;
            label2.Text = "Регістрація";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "loginForm";
            Text = "Вхід";
            tabControl1.ResumeLayout(false);
            login.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            register.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage login;
        private TabPage register;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button logInButton;
        private TextBox userFieldLogIn;
        private TextBox passwordFieldLogIn;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Button registerButton;
        private TextBox registerPasswordField;
        private TextBox registerUserField;
        private Panel panel5;
        private Label label2;
        private PictureBox pictureBox4;
    }
}
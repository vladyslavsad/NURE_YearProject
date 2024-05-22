namespace nure
{
    partial class introduceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            ShowMyVacanciButton = new Button();
            ShowMyAncete = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            createVacanciButton = new Button();
            createAnceteButton = new Button();
            ShowVacanciesButton = new Button();
            ShowWorkersButton = new Button();
            panel2 = new Panel();
            label1 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Ivory;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(ShowMyVacanciButton);
            panel1.Controls.Add(ShowMyAncete);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(createVacanciButton);
            panel1.Controls.Add(createAnceteButton);
            panel1.Controls.Add(ShowVacanciesButton);
            panel1.Controls.Add(ShowWorkersButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources._4829868_arrow_right_up_icon;
            pictureBox6.Location = new Point(419, 204);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(42, 42);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._4829868_arrow_right_up_icon;
            pictureBox5.Location = new Point(419, 146);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // ShowMyVacanciButton
            // 
            ShowMyVacanciButton.Cursor = Cursors.Hand;
            ShowMyVacanciButton.Location = new Point(477, 204);
            ShowMyVacanciButton.Name = "ShowMyVacanciButton";
            ShowMyVacanciButton.Size = new Size(228, 42);
            ShowMyVacanciButton.TabIndex = 10;
            ShowMyVacanciButton.Text = "показати мою вакансію";
            ShowMyVacanciButton.UseVisualStyleBackColor = true;
            ShowMyVacanciButton.Click += ShowMyVacanciButton_Click;
            // 
            // ShowMyAncete
            // 
            ShowMyAncete.Cursor = Cursors.Hand;
            ShowMyAncete.Location = new Point(477, 146);
            ShowMyAncete.Name = "ShowMyAncete";
            ShowMyAncete.Size = new Size(228, 42);
            ShowMyAncete.TabIndex = 9;
            ShowMyAncete.Text = "показати мою анкету";
            ShowMyAncete.UseVisualStyleBackColor = true;
            ShowMyAncete.Click += ShowMyAncete_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._326602_create_edit_pencil_write_icon;
            pictureBox4.Location = new Point(235, 322);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._326602_create_edit_pencil_write_icon;
            pictureBox3.Location = new Point(235, 261);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._4829868_arrow_right_up_icon;
            pictureBox2.Location = new Point(86, 204);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4829868_arrow_right_up_icon;
            pictureBox1.Location = new Point(86, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // createVacanciButton
            // 
            createVacanciButton.Cursor = Cursors.Hand;
            createVacanciButton.Location = new Point(305, 322);
            createVacanciButton.Name = "createVacanciButton";
            createVacanciButton.Size = new Size(228, 42);
            createVacanciButton.TabIndex = 4;
            createVacanciButton.Text = "створити вакансію";
            createVacanciButton.UseVisualStyleBackColor = true;
            createVacanciButton.Click += createVacanciButton_Click;
            // 
            // createAnceteButton
            // 
            createAnceteButton.Cursor = Cursors.Hand;
            createAnceteButton.Location = new Point(305, 261);
            createAnceteButton.Name = "createAnceteButton";
            createAnceteButton.Size = new Size(228, 42);
            createAnceteButton.TabIndex = 3;
            createAnceteButton.Text = "створити анкету";
            createAnceteButton.UseVisualStyleBackColor = true;
            createAnceteButton.Click += createAnceteButton_Click;
            // 
            // ShowVacanciesButton
            // 
            ShowVacanciesButton.Cursor = Cursors.Hand;
            ShowVacanciesButton.Location = new Point(145, 204);
            ShowVacanciesButton.Name = "ShowVacanciesButton";
            ShowVacanciesButton.Size = new Size(228, 42);
            ShowVacanciesButton.TabIndex = 2;
            ShowVacanciesButton.Text = "вакансії";
            ShowVacanciesButton.UseVisualStyleBackColor = true;
            ShowVacanciesButton.Click += ShowVacanciesButton_Click;
            // 
            // ShowWorkersButton
            // 
            ShowWorkersButton.Cursor = Cursors.Hand;
            ShowWorkersButton.Location = new Point(145, 146);
            ShowWorkersButton.Name = "ShowWorkersButton";
            ShowWorkersButton.Size = new Size(228, 42);
            ShowWorkersButton.TabIndex = 1;
            ShowWorkersButton.Text = "працівники";
            ShowWorkersButton.UseVisualStyleBackColor = true;
            ShowWorkersButton.Click += ShowWorkersButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(66, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 55);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(148, 13);
            label1.Name = "label1";
            label1.Size = new Size(356, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome   ^^ що Вас цікавить?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // introduceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "introduceForm";
            Text = "Головне меню";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button createVacanciButton;
        private Button createAnceteButton;
        private Button ShowVacanciesButton;
        private Button ShowWorkersButton;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Button ShowMyVacanciButton;
        private Button ShowMyAncete;
    }
}
namespace nure
{
    partial class searchOfVacancy
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
            label1 = new Label();
            searchOfVacancies = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            listViewSerchOfVacancy = new ListView();
            label2 = new Label();
            pictureBoxTurnBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTurnBack).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 25);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "пошук";
            // 
            // searchOfVacancies
            // 
            searchOfVacancies.Location = new Point(175, 22);
            searchOfVacancies.Name = "searchOfVacancies";
            searchOfVacancies.Size = new Size(391, 27);
            searchOfVacancies.TabIndex = 1;
            searchOfVacancies.TextChanged += searchOfVacancies_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(181, 201, 247);
            pictureBox1.Location = new Point(32, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(727, 40);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(181, 201, 247);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(searchOfVacancies);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 364);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(listViewSerchOfVacancy);
            panel2.Location = new Point(39, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 251);
            panel2.TabIndex = 2;
            // 
            // listViewSerchOfVacancy
            // 
            listViewSerchOfVacancy.Dock = DockStyle.Fill;
            listViewSerchOfVacancy.Location = new Point(0, 0);
            listViewSerchOfVacancy.Name = "listViewSerchOfVacancy";
            listViewSerchOfVacancy.Size = new Size(644, 251);
            listViewSerchOfVacancy.TabIndex = 0;
            listViewSerchOfVacancy.UseCompatibleStateImageBehavior = false;
            listViewSerchOfVacancy.SelectedIndexChanged += listViewResults_ItemActivate;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(181, 201, 247);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(288, 9);
            label2.Name = "label2";
            label2.Size = new Size(232, 38);
            label2.TabIndex = 2;
            label2.Text = "пошук вакансій";
            // 
            // pictureBoxTurnBack
            // 
            pictureBoxTurnBack.BackColor = Color.FromArgb(181, 201, 247);
            pictureBoxTurnBack.BackgroundImageLayout = ImageLayout.None;
            pictureBoxTurnBack.Cursor = Cursors.Hand;
            pictureBoxTurnBack.Image = Properties.Resources._4829864_arrow_back_left_icon;
            pictureBoxTurnBack.Location = new Point(720, 15);
            pictureBoxTurnBack.Name = "pictureBoxTurnBack";
            pictureBoxTurnBack.Size = new Size(30, 30);
            pictureBoxTurnBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTurnBack.TabIndex = 4;
            pictureBoxTurnBack.TabStop = false;
            pictureBoxTurnBack.Click += pictureBoxTurnBack_Click;
            // 
            // searchOfVacancy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxTurnBack);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "searchOfVacancy";
            Text = "Пошук вакансій";
            Load += listViewResults_ItemActivate;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTurnBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox searchOfVacancies;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private ListView listViewSerchOfVacancy;
        private PictureBox pictureBoxTurnBack;
    }
}
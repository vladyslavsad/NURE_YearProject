namespace nure
{
    partial class vacanciCompilation
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
            label7 = new Label();
            contactField = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            positionField = new TextBox();
            nameField = new TextBox();
            conditionField = new TextBox();
            requerementsField = new TextBox();
            companyInfoField = new TextBox();
            button1 = new Button();
            pictureBoxTurnBack = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTurnBack).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Ivory;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(contactField);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(positionField);
            panel1.Controls.Add(nameField);
            panel1.Controls.Add(conditionField);
            panel1.Controls.Add(requerementsField);
            panel1.Controls.Add(companyInfoField);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBoxTurnBack);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(118, 295);
            label7.Name = "label7";
            label7.Size = new Size(154, 20);
            label7.TabIndex = 14;
            label7.Text = "як з вами звязатися?";
            // 
            // contactField
            // 
            contactField.BorderStyle = BorderStyle.FixedSingle;
            contactField.Cursor = Cursors.IBeam;
            contactField.Location = new Point(118, 319);
            contactField.Name = "contactField";
            contactField.Size = new Size(208, 27);
            contactField.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 190);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 12;
            label6.Text = "вакансія";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(506, 109);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 11;
            label5.Text = "про вакансію";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(506, 190);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 10;
            label4.Text = "умови ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 272);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 9;
            label3.Text = "вимоги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 109);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 8;
            label2.Text = "фірма";
            // 
            // positionField
            // 
            positionField.BorderStyle = BorderStyle.FixedSingle;
            positionField.Cursor = Cursors.IBeam;
            positionField.Location = new Point(118, 213);
            positionField.Name = "positionField";
            positionField.Size = new Size(208, 27);
            positionField.TabIndex = 7;
            // 
            // nameField
            // 
            nameField.BorderStyle = BorderStyle.FixedSingle;
            nameField.Cursor = Cursors.IBeam;
            nameField.Location = new Point(118, 132);
            nameField.Name = "nameField";
            nameField.Size = new Size(208, 27);
            nameField.TabIndex = 6;
            // 
            // conditionField
            // 
            conditionField.BorderStyle = BorderStyle.FixedSingle;
            conditionField.Cursor = Cursors.IBeam;
            conditionField.Location = new Point(506, 213);
            conditionField.Multiline = true;
            conditionField.Name = "conditionField";
            conditionField.Size = new Size(232, 51);
            conditionField.TabIndex = 5;
            // 
            // requerementsField
            // 
            requerementsField.BorderStyle = BorderStyle.FixedSingle;
            requerementsField.Cursor = Cursors.IBeam;
            requerementsField.Location = new Point(506, 295);
            requerementsField.Multiline = true;
            requerementsField.Name = "requerementsField";
            requerementsField.Size = new Size(232, 51);
            requerementsField.TabIndex = 4;
            // 
            // companyInfoField
            // 
            companyInfoField.BorderStyle = BorderStyle.FixedSingle;
            companyInfoField.Cursor = Cursors.IBeam;
            companyInfoField.Location = new Point(506, 132);
            companyInfoField.Multiline = true;
            companyInfoField.Name = "companyInfoField";
            companyInfoField.Size = new Size(232, 51);
            companyInfoField.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSpringGreen;
            button1.Location = new Point(317, 404);
            button1.Name = "button1";
            button1.Size = new Size(183, 34);
            button1.TabIndex = 2;
            button1.Text = "опублікувати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += publishAnceteButton_Click;
            // 
            // pictureBoxTurnBack
            // 
            pictureBoxTurnBack.Cursor = Cursors.Hand;
            pictureBoxTurnBack.Image = Properties.Resources._4829864_arrow_back_left_icon;
            pictureBoxTurnBack.Location = new Point(768, 12);
            pictureBoxTurnBack.Name = "pictureBoxTurnBack";
            pictureBoxTurnBack.Size = new Size(20, 20);
            pictureBoxTurnBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTurnBack.TabIndex = 1;
            pictureBoxTurnBack.TabStop = false;
            pictureBoxTurnBack.Click += pictureBoxTurnBack_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(72, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(666, 45);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(234, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 31);
            label1.TabIndex = 0;
            label1.Text = "cтворити вакансію";
            // 
            // vacanciCompilation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "vacanciCompilation";
            Text = "складання вашої вакансії";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTurnBack).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBoxTurnBack;
        private Button button1;
        private Label label1;
        private TextBox positionField;
        private TextBox nameField;
        private TextBox conditionField;
        private TextBox requerementsField;
        private TextBox companyInfoField;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox contactField;
    }
}
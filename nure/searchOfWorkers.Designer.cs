namespace nure
{
    partial class searchOfWorkers
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
            label2 = new Label();
            panel2 = new Panel();
            listViewOfWorkers = new ListView();
            searchOfWorker = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            pictureBoxTurnBack = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTurnBack).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(181, 201, 247);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(searchOfWorker);
            panel1.Location = new Point(32, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 364);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 25);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "пошук";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(listViewOfWorkers);
            panel2.Location = new Point(41, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 251);
            panel2.TabIndex = 1;
            // 
            // listViewOfWorkers
            // 
            listViewOfWorkers.Dock = DockStyle.Fill;
            listViewOfWorkers.Location = new Point(0, 0);
            listViewOfWorkers.Name = "listViewOfWorkers";
            listViewOfWorkers.Size = new Size(644, 251);
            listViewOfWorkers.TabIndex = 0;
            listViewOfWorkers.UseCompatibleStateImageBehavior = false;
            listViewOfWorkers.SelectedIndexChanged += listViewResults_ItemActivate;
            // 
            // searchOfWorker
            // 
            searchOfWorker.Location = new Point(175, 22);
            searchOfWorker.Name = "searchOfWorker";
            searchOfWorker.Size = new Size(391, 27);
            searchOfWorker.TabIndex = 2;
            searchOfWorker.TextChanged += searchOfWorkers_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(218, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 38);
            label1.TabIndex = 1;
            label1.Text = "пошук працівників";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(181, 201, 247);
            panel3.Controls.Add(pictureBoxTurnBack);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(32, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(727, 40);
            panel3.TabIndex = 1;
            // 
            // pictureBoxTurnBack
            // 
            pictureBoxTurnBack.Cursor = Cursors.Hand;
            pictureBoxTurnBack.Image = Properties.Resources._4829864_arrow_back_left_icon;
            pictureBoxTurnBack.Location = new Point(685, 5);
            pictureBoxTurnBack.Name = "pictureBoxTurnBack";
            pictureBoxTurnBack.Size = new Size(30, 30);
            pictureBoxTurnBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTurnBack.TabIndex = 1;
            pictureBoxTurnBack.TabStop = false;
            pictureBoxTurnBack.Click += pictureBoxTurnBack_Click;
            // 
            // searchOfWorkers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "searchOfWorkers";
            Text = "Пошук працівників";
            Load += searchOfWorkers_TextChanged;
            TextChanged += searchOfWorkers_TextChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTurnBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox searchOfWorker;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private ListView listViewOfWorkers;
        private PictureBox pictureBoxTurnBack;
    }
}
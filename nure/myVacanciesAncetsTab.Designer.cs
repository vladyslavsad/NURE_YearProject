namespace nure
{
    partial class myVacanciesAncetsTab
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
            AncetsVacanciesTabPage = new TabControl();
            MyAncete = new TabPage();
            MyPanel = new Panel();
            MyVacanci = new TabPage();
            MyPanel2 = new Panel();
            AncetsVacanciesTabPage.SuspendLayout();
            MyAncete.SuspendLayout();
            MyVacanci.SuspendLayout();
            SuspendLayout();
            // 
            // AncetsVacanciesTabPage
            // 
            AncetsVacanciesTabPage.Controls.Add(MyAncete);
            AncetsVacanciesTabPage.Controls.Add(MyVacanci);
            AncetsVacanciesTabPage.Dock = DockStyle.Fill;
            AncetsVacanciesTabPage.Location = new Point(0, 0);
            AncetsVacanciesTabPage.Name = "AncetsVacanciesTabPage";
            AncetsVacanciesTabPage.SelectedIndex = 0;
            AncetsVacanciesTabPage.Size = new Size(800, 450);
            AncetsVacanciesTabPage.TabIndex = 0;
            // 
            // MyAncete
            // 
            MyAncete.Controls.Add(MyPanel);
            MyAncete.Location = new Point(4, 29);
            MyAncete.Name = "MyAncete";
            MyAncete.Padding = new Padding(3);
            MyAncete.Size = new Size(792, 417);
            MyAncete.TabIndex = 0;
            MyAncete.Text = "анкети ";
            MyAncete.UseVisualStyleBackColor = true;
            // 
            // MyPanel
            // 
            MyPanel.BackColor = Color.Azure;
            MyPanel.Dock = DockStyle.Fill;
            MyPanel.Location = new Point(3, 3);
            MyPanel.Name = "MyPanel";
            MyPanel.Size = new Size(786, 411);
            MyPanel.TabIndex = 0;
            // 
            // MyVacanci
            // 
            MyVacanci.Controls.Add(MyPanel2);
            MyVacanci.Location = new Point(4, 29);
            MyVacanci.Name = "MyVacanci";
            MyVacanci.Padding = new Padding(3);
            MyVacanci.Size = new Size(792, 417);
            MyVacanci.TabIndex = 1;
            MyVacanci.Text = "вакансії";
            MyVacanci.UseVisualStyleBackColor = true;
            // 
            // MyPanel2
            // 
            MyPanel2.BackColor = Color.Azure;
            MyPanel2.Dock = DockStyle.Fill;
            MyPanel2.Location = new Point(3, 3);
            MyPanel2.Name = "MyPanel2";
            MyPanel2.Size = new Size(786, 411);
            MyPanel2.TabIndex = 0;
            // 
            // myVacanciesAncetsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AncetsVacanciesTabPage);
            Name = "myVacanciesAncetsTab";
            Text = "Ваш профіль";
            Load += myVacanciesAncetsTab_Load;
            AncetsVacanciesTabPage.ResumeLayout(false);
            MyAncete.ResumeLayout(false);
            MyVacanci.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl AncetsVacanciesTabPage;
        private TabPage MyAncete;
        private TabPage MyVacanci;
        private Panel MyPanel;
        private Panel MyPanel2;
    }
}
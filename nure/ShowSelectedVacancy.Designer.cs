namespace nure
{
    partial class ShowSelectedVacancy
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
            myPanal = new Panel();
            SuspendLayout();
            // 
            // myPanal
            // 
            myPanal.BackColor = Color.WhiteSmoke;
            myPanal.Dock = DockStyle.Fill;
            myPanal.Location = new Point(0, 0);
            myPanal.Name = "myPanal";
            myPanal.Size = new Size(800, 450);
            myPanal.TabIndex = 0;
            // 
            // ShowSelectedVacancy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myPanal);
            Name = "ShowSelectedVacancy";
            Text = "Распічатати вакансію";
            Load += ShowSelectedWorkers_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel myPanal;
    }
}
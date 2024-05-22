using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nure
{
    public partial class vacanciCompilation : Form
    {
        private SqlConnection connection;

        private string CurrentUnikUserID;
        public vacanciCompilation(string unikUserID)
        {
            InitializeComponent();

            CurrentUnikUserID = unikUserID;
            this.KeyPreview = true; // Це щоб клавіатура приймала події раніше ніж конролери 
            this.KeyDown += MyForm_KeyDown; // Підпис на подію
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Відключення кнопок максимізації та мінімізації
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(818, 497);
            this.StartPosition = FormStartPosition.CenterScreen;

        }









        private void publishAnceteButton_Click(object sender, EventArgs e) // знову ж таки передаємо дані через конструктор 
        {

            SaveData();
            int tabPageIndex = 1;
            myVacanciesAncetsTab myVacanciesAncets = new myVacanciesAncetsTab(CurrentUnikUserID, tabPageIndex);

            introduceForm introduceForm = new introduceForm(CurrentUnikUserID);
            introduceForm.Show();
            myVacanciesAncets.Show();
            this.Close();

        }





        public void SaveData()

        {

            // Додаємо дані в базу
            string updateQuery = @"UPDATE vacanciesForm SET
        name = @name, requiremenst = @requirements, position = @position, conditions = @conditions, companyInfo = @companyInfo, contact = @contact, isVisiable = @isVisiable
        WHERE unikUserID = @UnikUserID";

            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString);

            if (requerementsField.Text.Length > 50
                || companyInfoField.Text.Length > 50
                || conditionField.Text.Length > 50 
                || contactField.Text.Length > 50
                || nameField.Text.Length > 50 
                || positionField.Text.Length > 50) //валідація на 50 символів
            {
                
                MessageBox.Show("Інформація в полях не повина привишати 50 символів");


                return; 
            }


            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                connection.Open();

                int isVisiable = 1;

                // Заповнюємо параметри команди
                command.Parameters.AddWithValue("@UnikUserID", CurrentUnikUserID);
                command.Parameters.AddWithValue("@companyInfo", companyInfoField.Text);
                command.Parameters.AddWithValue("@requirements", requerementsField.Text);
                command.Parameters.AddWithValue("@name", nameField.Text);
                command.Parameters.AddWithValue("@position", positionField.Text);


                command.Parameters.AddWithValue("@conditions", conditionField.Text);
                command.Parameters.AddWithValue("@contact", contactField.Text);
                command.Parameters.AddWithValue("@isVisiable", isVisiable);


                command.ExecuteNonQuery();// Виконуємо запит
                connection.Close();



            }

        }

        private void pictureBoxTurnBack_Click(object sender, EventArgs e)
        {
            introduceForm introduceForm = new introduceForm(CurrentUnikUserID);
            introduceForm.Show();
            this.Close();
        }
        private void MyForm_KeyDown(object sender, KeyEventArgs e) // біндемо кнопку esc
        {
            if (e.KeyCode == Keys.Escape)
            {
                introduceForm introduceForm = new introduceForm(CurrentUnikUserID);
                introduceForm.Show();
                this.Close();
            }
        }

    }
}


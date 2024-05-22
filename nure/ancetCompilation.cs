using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace nure
{
    public partial class ancetCompilation : Form
    {
        private SqlConnection connection;

        private string CurrentUnikUserID;
        public ancetCompilation(string unikUserID)
        {
            InitializeComponent();
            CurrentUnikUserID = unikUserID;
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString);
            InitializeComponent();
            this.KeyPreview = true; // Це щоб клавіатура приймала події раніше ніж конролери 
            this.KeyDown += MyForm_KeyDown; // Підпис на подію
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Відключення кнопок максимізації та мінімізації
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(818, 497);
            this.StartPosition = FormStartPosition.CenterScreen;



        }









        private void publishAnceteButton_Click(object sender, EventArgs e)
        {
            int tabPageIndex = 0;
            SaveData();

            myVacanciesAncetsTab myVacanciesAncets = new myVacanciesAncetsTab(CurrentUnikUserID, tabPageIndex);
            myVacanciesAncets.Show();
            this.Close();
        }





        public void SaveData()

        {

            // Додаємо дані в базу
            string updateQuery = @"UPDATE workersInfoForm SET
        selfInfo = @SelfInfo, requiremenst = @Requirements, name = @Name, profesion = @Profession, 
        degree = @Degree, placeOfLastWork = @PlaceOfLastWork, causeOfDismissal = @CauseOfDismissal, 
        familyState = @FamilyState, lifeConditions = @LifeConditions, contactInfo = @ContactInfo, isVisiable = @isVisiable
        WHERE unikUserID = @UnikUserID";

            if (requiremenst.Text.Length > 50 
                || selfInfo.Text.Length > 50
                || lifeConditions.Text.Length > 50 
                || causeOfDismissal.Text.Length > 50 
                || requiremenst.Text.Length > 50)
            {
                //валідація на 50 символів
                MessageBox.Show("Інформація в полях не повина привишати 50 символів");


                return; 
            }


            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                connection.Open();

                int isVisiable = 1;

                // Заповнюємо параметри команди
                command.Parameters.AddWithValue("@UnikUserID", CurrentUnikUserID);
                command.Parameters.AddWithValue("@SelfInfo", selfInfo.Text);
                command.Parameters.AddWithValue("@Requirements", requiremenst.Text);
                command.Parameters.AddWithValue("@Name", name.Text);
                command.Parameters.AddWithValue("@Profession", profesion.Text);
                command.Parameters.AddWithValue("@Degree", degree.Text);
                command.Parameters.AddWithValue("@PlaceOfLastWork", placeOfLastWork.Text);
                command.Parameters.AddWithValue("@CauseOfDismissal", causeOfDismissal.Text);
                command.Parameters.AddWithValue("@FamilyState", familyState.Text);
                command.Parameters.AddWithValue("@LifeConditions", lifeConditions.Text);
                command.Parameters.AddWithValue("@ContactInfo", contactInfo.Text);
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

        private void MyForm_KeyDown(object sender, KeyEventArgs e)
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


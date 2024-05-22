using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nure
{
    public partial class myVacanciesAncetsTab : Form
    {
        private SqlConnection connection;

        private string CurrentUnikUserID;
        private readonly int tabPageIndex;
        public myVacanciesAncetsTab(string unikUserID, int tabPageIndex)
        {
            CurrentUnikUserID = unikUserID;
            InitializeComponent();
            this.tabPageIndex = tabPageIndex;
        }

        public myVacanciesAncetsTab(string unikUserID)
        {
            CurrentUnikUserID = unikUserID;
            InitializeComponent();

        }

        // два оверлоада для різних випадків

        private void myVacanciesAncetsTab_Load(object sender, EventArgs e)
        {
            AddNewTabPageWithTableToAncets(GetData());
            AddNewTabPageWithTableToVacanci(GetDataVacanci());
            AncetsVacanciesTabPage.SelectedIndex = tabPageIndex;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Відключення кнопок максимізації та мінімізації
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(818, 497);
            

        }

        private void DeleteTabPageAndDataAncete()
        {

            string deleteQuery = "UPDATE workersInfoForm SET selfInfo = NULL, requiremenst = NULL, name = NULL, profesion = NULL, " +
                "degree = NULL, placeOfLastWork = NULL, causeOfDismissal = NULL, familyState = NULL, lifeConditions = NULL, contactInfo = NULL WHERE unikUserID = @UserID";
            ;
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString);
            try
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    // Встановлення параметра для запобігання SQL інєкції
                    command.Parameters.AddWithValue("@UserID", CurrentUnikUserID);
                    connection.Open();
                    command.ExecuteNonQuery(); // Виконуємо запит на видалення
                    connection.Close();

                    myVacanciesAncetsTab myVacanciesAncetsTab = new myVacanciesAncetsTab(CurrentUnikUserID);
                    myVacanciesAncetsTab.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }



        }

        private void ArchiveTabPageAncete()
        {
            //додамо змінну в бд яка не буду дозволяти пошук елементів 
            string archiveQuery = "UPDATE workersInfoForm SET isVisiable = 0 WHERE unikUserID = @UserID";
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString);
            try
            {
                using (SqlCommand command = new SqlCommand(archiveQuery, connection))
                {
                    // Встановлення параметра для запобігання SQL ін'єкції
                    command.Parameters.AddWithValue("@UserID", CurrentUnikUserID);
                    connection.Open();
                    command.ExecuteNonQuery(); // Виконуємо запит на видалення
                    connection.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void UnArchiveTabPageAncete()
        {
            string archiveQuery = "UPDATE workersInfoForm SET isVisiable = 1 WHERE unikUserID = @UserID";
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString);
            try
            {
                using (SqlCommand command = new SqlCommand(archiveQuery, connection))
                {
                    // Встановлення параметра для запобігання SQL ін'єкції
                    command.Parameters.AddWithValue("@UserID", CurrentUnikUserID);
                    connection.Open();
                    command.ExecuteNonQuery(); // Виконуємо запит на видалення
                    connection.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }




        private string[] GetData()
        {
            List<string> dataList = new List<string>();

            string selectQuery = @"SELECT selfInfo, requiremenst, name, profesion, degree, 
                           placeOfLastWork, causeOfDismissal, familyState, lifeConditions, contactInfo 
                           FROM workersInfoForm WHERE unikUserID = @UserID";

      

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString))
            {
            SqlCommand command = new SqlCommand(selectQuery, connection);


                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@UserID", CurrentUnikUserID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            dataList.Add(reader["selfInfo"].ToString());
                            dataList.Add(reader["requiremenst"].ToString());
                            dataList.Add(reader["name"].ToString());
                            dataList.Add(reader["profesion"].ToString());
                            dataList.Add(reader["degree"].ToString());
                            dataList.Add(reader["placeOfLastWork"].ToString());
                            dataList.Add(reader["causeOfDismissal"].ToString());
                            dataList.Add(reader["familyState"].ToString());
                            dataList.Add(reader["lifeConditions"].ToString());
                            dataList.Add(reader["contactInfo"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Обробка помилки
                    MessageBox.Show("упссс" + ex);
                }
            }

            return dataList.ToArray();
        }
        private void AddNewTabPageWithTableToAncets(string[] data)
        {




            TableLayoutPanel tableLayoutPanel = CreateTableLayoutPanel();
            FillTableLayoutPanel(tableLayoutPanel, data); // Додавання даних у таблицю
            MyAncete.Controls.Add(tableLayoutPanel); // Додавання таблиці до TabPage


            MyPanel.Controls.Add(tableLayoutPanel);



            Button deleteButton = new Button
            {
                Size = new Size(94, 29),
                Location = new Point(363, 382),
                Text = "Видалити",
                BackColor = Color.Red
            };

            deleteButton.Click += (sender, args) => DeleteTabPageAndDataAncete();

            // Створення кнопки для архівації

            Button archiveButton = new Button
            {
                Size = new Size(94, 29),
                Location = new Point(503, 383),
                Text = "Архівувати",
                BackColor = Color.Orange
            };
            archiveButton.Click += (sender, args) => ArchiveTabPageAncete();

            Button unArchiveButton = new Button
            {
                Size = new Size(94, 29),
                Location = new Point(648, 383),
                Text = "Деархівувати",
                BackColor = Color.Green
            };
            unArchiveButton.Click += (sender, args) => UnArchiveTabPageAncete();




            MyPanel.Controls.Add(deleteButton);
            MyPanel.Controls.Add(archiveButton);
            MyPanel.Controls.Add(unArchiveButton);
            deleteButton.BringToFront();
            archiveButton.BringToFront();
            unArchiveButton.BringToFront();

        }

        private TableLayoutPanel CreateTableLayoutPanel()

        {

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = 2, // Дві колонки
                RowCount = 10, // Десять рядків
                Dock = DockStyle.Fill, // Заповнити весь доступний простір
                AutoSize = true // Автоматично змінювати розмір
            };

            // Налаштування ширини колонок
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // Ліва колонка займатиме 30%
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F)); // Права колонка займатиме 70%

            // Налаштування висоти рядків (автоматично розтягується для всіх рядків)
            for (int i = 0; i < 11; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F)); // Кожен рядок займатиме 10%
            }

            return tableLayoutPanel;


        }

        private void FillTableLayoutPanel(TableLayoutPanel panel, string[] data)
        {
            string[] labels = { "Інформація про себе", "Вимоги", "ПІБ", "Професія", "Освіта", "Останнє місце праці", "Причина звільнення", "Сімейні обставини", "Умови життя", "Контактна інформація" };

            // Додаємо в рядки назви полів та дані
            for (int i = 0; i < labels.Length; i++)
            {
                panel.Controls.Add(new Label { Text = labels[i], Dock = DockStyle.Fill, AutoSize = true }, 0, i);
                panel.Controls.Add(new Label { Text = data[i], Dock = DockStyle.Fill, AutoSize = true }, 1, i);
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////


        private void DeleteTabPageAndDataVacanci()
        {

            string deleteQuery = @"UPDATE vacanciesForm SET
        name = NULL, requiremenst = NULL, position =NULL, conditions = NULL, companyInfo = NULL, contact = NULL
        WHERE unikUserID = @UnikUserID";
            ;
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString);
            try
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    // Встановлення параметра для запобігання SQL ін'єкції
                    command.Parameters.AddWithValue("@UnikUserID", CurrentUnikUserID);
                    connection.Open();
                    command.ExecuteNonQuery(); // Виконуємо запит на видалення
                    connection.Close();

                    myVacanciesAncetsTab myVacanciesAncetsTab = new myVacanciesAncetsTab(CurrentUnikUserID);
                    myVacanciesAncetsTab.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }



        }



        private void ArchiveTabPageVacanci()
        {
            //додамо змінну в бд яка не буду дозволяти пошук елементів 

            string archiveQuery = "UPDATE vacanciesForm SET isVisiable = 0 WHERE unikUserID = @UserID";
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString);
            try
            {
                using (SqlCommand command = new SqlCommand(archiveQuery, connection))
                {
                    // Встановлення параметра для запобігання SQL ін'єкції
                    command.Parameters.AddWithValue("@UserID", CurrentUnikUserID);
                    connection.Open();
                    command.ExecuteNonQuery(); // Виконуємо запит на видалення
                    connection.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void UnArchiveTabPageVacanci()
        {
            //додамо змінну в бд яка не буду дозволяти пошук елементів 

            string archiveQuery = "UPDATE vacanciesForm SET isVisiable = 1 WHERE unikUserID = @UserID";
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString);
            try
            {
                using (SqlCommand command = new SqlCommand(archiveQuery, connection))
                {
                    // Встановлення параметра для запобігання SQL ін'єкції
                    command.Parameters.AddWithValue("@UserID", CurrentUnikUserID);
                    connection.Open();
                    command.ExecuteNonQuery(); // Виконуємо запит на видалення
                    connection.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private string[] GetDataVacanci()
        {
            List<string> dataList = new List<string>();

            string selectQuery = @"SELECT companyInfo, requiremenst, name, position, 
                          conditions, contact 
                          FROM vacanciesForm WHERE unikUserID = @UserID";


            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(selectQuery, connection);


                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@UserID", CurrentUnikUserID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataList.Add(reader["name"].ToString());
                            dataList.Add(reader["position"].ToString());
                            dataList.Add(reader["conditions"].ToString());
                            dataList.Add(reader["requiremenst"].ToString());

                            dataList.Add(reader["companyInfo"].ToString());
                            dataList.Add(reader["contact"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Обробка помилки
                    MessageBox.Show("упссс" + ex);
                }
            }

            return dataList.ToArray();
        }
        private void AddNewTabPageWithTableToVacanci(string[] data)
        {




            TableLayoutPanel tableLayoutPanelVacanci = CreateTableLayoutPanelVacanci();
            FillTableLayoutPanelVacanci(tableLayoutPanelVacanci, data); // Додавання даних у таблицю
            MyAncete.Controls.Add(tableLayoutPanelVacanci); // Додавання таблиці до TabPage


            MyPanel2.Controls.Add(tableLayoutPanelVacanci);



            Button deleteButtonVac = new Button
            {
                Size = new Size(94, 29),
                Location = new Point(203, 382),
                Text = "Видалити",
                BackColor = Color.Red
            };

            deleteButtonVac.Click += (sender, args) => DeleteTabPageAndDataVacanci();

            // Створення кнопки для архівації

            Button archiveButtonVac = new Button
            {
                Size = new Size(94, 29),
                Location = new Point(343, 383),
                Text = "Архівувати",
                BackColor = Color.Orange
            };
            archiveButtonVac.Click += (sender, args) => ArchiveTabPageVacanci();

            Button unArchiveButtonVac = new Button
            {
                Size = new Size(94, 29),
                Location = new Point(488, 383),
                Text = "Деархівувати",
                BackColor = Color.Green
            };
            unArchiveButtonVac.Click += (sender, args) => UnArchiveTabPageVacanci();




            MyPanel2.Controls.Add(deleteButtonVac);
            MyPanel2.Controls.Add(archiveButtonVac);
            MyPanel2.Controls.Add(unArchiveButtonVac);
            deleteButtonVac.BringToFront();
            archiveButtonVac.BringToFront();
            unArchiveButtonVac.BringToFront();

        }

        private TableLayoutPanel CreateTableLayoutPanelVacanci()

        {

            TableLayoutPanel tableLayoutPanelVacanci = new TableLayoutPanel
            {
                ColumnCount = 2, // Дві колонки
                RowCount = 7, // Сім рядків
                Dock = DockStyle.Fill, // Заповнити весь доступний простір
                AutoSize = true // Автоматично змінювати розмір
            };

            // Налаштування ширини колонок
            tableLayoutPanelVacanci.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // Ліва колонка займатиме 30%
            tableLayoutPanelVacanci.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F)); // Права колонка займатиме 70%

            // Налаштування висоти рядків (автоматично розтягується для всіх рядків)
            for (int i = 0; i < 6; i++)
            {
                tableLayoutPanelVacanci.RowStyles.Add(new RowStyle(SizeType.Percent, 10F)); // Кожен рядок займатиме 10%
            }

            return tableLayoutPanelVacanci;


        }

        private void FillTableLayoutPanelVacanci(TableLayoutPanel panel, string[] data)
        {
            string[] labels = { "Назва фірми", "Позиція", "Умови праці", "Вимоги", "Інформація про компанію", "Контакти" };

            // Додаємо в рядки назви полів та дані
            for (int i = 0; i < labels.Length; i++)
            {
                panel.Controls.Add(new Label { Text = labels[i], Dock = DockStyle.Fill, AutoSize = true }, 0, i);
                panel.Controls.Add(new Label { Text = data[i], Dock = DockStyle.Fill, AutoSize = true }, 1, i);
            }
        }


    }

}




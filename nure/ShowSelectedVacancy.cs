using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace nure
{
    public partial class ShowSelectedVacancy : Form
    {
        public ShowSelectedVacancy(string CurrentUserID)
        {
            InitializeComponent();
            CurrentUnikUserID = CurrentUserID;
        }
        private SqlConnection connection;
        private string CurrentUnikUserID;


        private void ShowSelectedWorkers_Load(object sender, EventArgs e)
        {
            AddNewTabPageWithTable(GetDataSet());
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Відключення кнопок максимізації та мінімізації
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(818, 497);
            
        }



        private string[] GetDataSet()
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

        private void DownloadButton_Click(object sender, EventArgs e)
        {

            string[] data = GetDataSet();
            string[] labels = { "Назва фірми", "Позиція", "Умови праці", "Вимоги", "Інформація про компанію", "Контакти" };
            GeneratePdf(data, labels);
            MessageBox.Show("Перевірте Ваш рабочій стіл)");
        }
        private void AddNewTabPageWithTable(string[] data)
        {

            Button downloadButton = new Button
            {

                Text = "Скачать PDF",

                Size = new Size(150, 34),
                Location = new Point(341, 404),

                BackColor = Color.MediumSpringGreen
            };




            TableLayoutPanel tableLayoutPanel = CreateTableLayout();
            FillTableLayout(tableLayoutPanel, data); // Додавання даних у таблицю



            myPanal.Controls.Add(tableLayoutPanel);

            downloadButton.Click += new EventHandler(DownloadButton_Click);
            myPanal.Controls.Add(downloadButton);
            downloadButton.BringToFront();


        }

        private TableLayoutPanel CreateTableLayout()

        {





            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = 2, // Дві колонки
                RowCount = 6, // Десять рядків
                Dock = DockStyle.Fill, // Заповнити весь доступний простір
                AutoSize = true // Автоматично змінювати розмір
            };

            // Налаштування ширини колонок
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // Ліва колонка займатиме 30%
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F)); // Права колонка займатиме 70%

            // Налаштування висоти рядків (автоматично розтягується для всіх рядків)
            for (int i = 0; i < 6; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16F)); // Кожен рядок займатиме 16%
            }

            return tableLayoutPanel;


        }

        private void FillTableLayout(TableLayoutPanel panel, string[] data)
        {
            string[] labels = { "Назва фірми", "Позиція", "Умови праці", "Вимоги", "Інформація про компанію", "Контакти" };

            // Додаємо в рядки назви полів та дані
            for (int i = 0; i < labels.Length; i++)
            {
                panel.Controls.Add(new Label { Text = labels[i], Dock = DockStyle.Fill, AutoSize = true }, 0, i);
                panel.Controls.Add(new Label { Text = data[i], Dock = DockStyle.Fill, AutoSize = true }, 1, i);
            }
        }
        /// <summary>
        /// //
        /// </summary>


        private void GeneratePdf(string[] data, string[] labels)
        {
            Document document = new Document();
            // Створення шрифту з підтримкою кирилиці
            BaseFont baseFont = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            // Создаем шрифт с указанием BaseFont и размером шрифта
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);


            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Document.pdf");
                PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
                document.Open();
                string folderPath = @"C:\Users\vlady\OneDrive\Рабочий стол"; 
                string fileName = "Vacancy.pdf"; 
                string fullPath = Path.Combine(folderPath, fileName);

                PdfWriter.GetInstance(document, new FileStream(fullPath, FileMode.Create));
                document.Open();

                for (int i = 0; i < data.Length; i++)
                {

                    document.Add(new Paragraph($"{labels[i]}: {data[i]}", font));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка створення PDF: " + ex.Message);
            }
            finally
            {
                document.Close();
            }
        }

    }
}

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
    public partial class ShowSelectedWorkers : Form
    {
        private SqlConnection connection;
        private string CurrentUnikUserID;
        public ShowSelectedWorkers(string CurrentUserID)
        {
            CurrentUnikUserID = CurrentUserID;
            InitializeComponent();

        }

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


        private void DownloadButton_Click(object sender, EventArgs e)
        {
            // Убедитесь, что шрифт поддерживает кириллицу, Arial обычно поддерживает.
            BaseFont baseFont = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            // Создаем шрифт с указанием BaseFont и размером шрифта
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);
            string[] data = GetDataSet();
            string[] labels = { "Інформація про себе", "Вимоги", "ПІБ", "Професія", "Освіта", "Останнє місце праці", "Причина звільнення", "Сімейні обставини", "Умови життя", "Контактна інформація" };
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



            myPanel.Controls.Add(tableLayoutPanel);

            downloadButton.Click += new EventHandler(DownloadButton_Click);
            myPanel.Controls.Add(downloadButton);
            downloadButton.BringToFront();

        }

        private TableLayoutPanel CreateTableLayout()

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
            for (int i = 0; i < 10; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F)); // Кожен рядок займатиме 10%
            }

            return tableLayoutPanel;


        }

        private void FillTableLayout(TableLayoutPanel panel, string[] data)
        {
            string[] labels = { "Інформація про себе", "Вимоги", "ПІБ", "Професія", "Освіта", "Останнє місце праці", "Причина звільнення", "Сімейні обставини", "Умови життя", "Контактна інформація" };

            // Додаємо в рядки назви полів та дані
            for (int i = 0; i < labels.Length; i++)
            {
                panel.Controls.Add(new Label { Text = labels[i], Dock = DockStyle.Fill, AutoSize = true }, 0, i);
                panel.Controls.Add(new Label { Text = data[i], Dock = DockStyle.Fill, AutoSize = true }, 1, i);
            }
        }
        private void GeneratePdf(string[] data, string[] labels)
        {
            Document document = new Document();
            // Шрифт з підтримкою кірілиці
            BaseFont baseFont = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            // Создаем шрифт с указанием BaseFont и размером шрифта
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);

            try

            {


                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Document.pdf");
                PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
                document.Open();
                string folderPath = @"C:\Users\vlady\OneDrive\Рабочий стол"; 
                string fileName = "Partfolio.pdf"; 
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

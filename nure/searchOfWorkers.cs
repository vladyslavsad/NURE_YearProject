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

namespace nure
{
    public partial class searchOfWorkers : Form
    {
        private SqlConnection connection;

        string CurrentUnikUserID;
        public searchOfWorkers(string CurrentUnikUserID)
        {
            InitializeComponent();
            this.CurrentUnikUserID = CurrentUnikUserID;
            this.KeyPreview = true; // Це щоб клавіатура приймала події раніше ніж конролери 
            this.KeyDown += MyForm_KeyDown; // Підпис на подію
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Відключення кнопок максимізації та мінімізації
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(818, 497);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void searchOfWorkers_TextChanged(object sender, EventArgs e)
        {
            await UpdateSearchResultsAsync(searchOfWorker.Text);
        }



        private async Task UpdateSearchResultsAsync(string searchText)
        {
            listViewOfWorkers.Items.Clear(); 
            listViewOfWorkers.View = View.List; // Встановлюємо режим відображення

            string query = @"SELECT name , profesion, degree , unikUserID FROM workersInfoForm WHERE ((name LIKE @SearchText OR degree LIKE @SearchText) OR profesion LIKE @SearchText ) AND isVisiable = 1 ";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {


                    command.Parameters.AddWithValue("@SearchText", $"%{searchText}%"); //пошук сабстрінга

                    await connection.OpenAsync();

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            // Комбінуємо имя вакансіі та інформацію о компаніі в одну строку
                            string combinedInfo = $"{reader["name"]} - {reader["profesion"]} - {reader["degree"]}";
                            var item = new ListViewItem(combinedInfo); // Створюємо новий элемент ListView
                            item.Tag = reader["unikUserID"].ToString(); // Зберігаємо userID в властивості Tag для подальшої передачі
                            listViewOfWorkers.Items.Add(item); // Додаємо строку в ListView

                        }
                    }
                }
            }
        }
        private void listViewResults_ItemActivate(object sender, EventArgs e)
        {
            if (listViewOfWorkers.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewOfWorkers.SelectedItems[0];
                if (selectedItem.Tag != null)
                {
                    string UserID = selectedItem.Tag.ToString();
                    ShowSelectedWorkers showSelectedWorkers = new ShowSelectedWorkers(UserID);
                    showSelectedWorkers.Show();


                }
                else
                {
                    // Обработка случая, когда Tag равен null
                    MessageBox.Show("Помилка: UserID відсутній в обранном элементі.");
                }



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

using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    namespace nure
    {


        public partial class loginForm : Form
        {
        


            public loginForm()
            {
                this.KeyPreview = true; // Це щоб клавіатура приймала події раніше ніж конролери
                this.KeyDown += MyForm_KeyDownLog; 
                this.AcceptButton = logInButton;   //
                this.AcceptButton = registerButton;// вішаємо події на кнопки
                InitializeComponent();
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString); //строка підключення до БД
                                                                                                                              // Встановлення стилю обрамлення форми на фіксований діалог
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Відключення кнопок максимізації та мінімізації
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(818, 497); 
            this.StartPosition = FormStartPosition.CenterScreen;

        }

            private SqlConnection sqlConnection = null; // ініцілюємо екземпляр классу для подальшого підключення


            private void logInButton_Click(object sender, EventArgs e) //реалізація кнопки регістрації
            {
                {
                    using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString)) // using для безпечного закриття бд
                    {
                        try
                        {
                            sqlConnection.Open(); 
                            // виборка по унікальному userID
                            string query = "SELECT unikUserID FROM usersLogInData WHERE name=@Username AND password=@Password";
                            using (SqlCommand command = new SqlCommand(query, sqlConnection))
                            {
                                command.Parameters.AddWithValue("@Username", userFieldLogIn.Text); // 
                                command.Parameters.AddWithValue("@Password", passwordFieldLogIn.Text);// передаємо параметри до бд
                                var unikUserID = command.ExecuteScalar(); // повино повернути унікальне значення

                                if (unikUserID != null)
                                {
                                    // передаємо userID до конструктору наступної форми для унікальної виборки(ступіню досупа до строк в DB )
                                    // встановлення параметра для запобігання SQL інєкції
                                    introduceForm IntroduceForm = new introduceForm(unikUserID.ToString());
                                    IntroduceForm.Show();

                                    this.Close(); 
                                }
                                else
                                {
                                    MessageBox.Show("Неверные имя пользователя или пароль.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка: " + ex.Message);
                        }
                    }



                }

            }

            private void MyForm_KeyDownLog(object sender, KeyEventArgs e) // біндимо Enter до кнопки
            {
                if (e.KeyCode == Keys.Enter)
                {
                    logInButton_Click(sender, e);
                }
            }

            private void registerButton_Click(object sender, EventArgs e) 
            {


                using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString))
                {
                    try
                    {
                        sqlConnection.Open();

                        // перевірка існування користувача
                        string checkUserQuery = "SELECT COUNT(*) FROM usersLogInData WHERE name = @Username";
                        using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, sqlConnection))
                        {
                            checkUserCommand.Parameters.AddWithValue("@Username", registerUserField.Text);
                            int userExists = (int)checkUserCommand.ExecuteScalar();

                            if (userExists > 0)
                            {
                                MessageBox.Show("Користувач з таким імям вже існує.");
                                return; // ретьорнаємо якщо імя не знайденно
                            }
                        }

                        if (registerUserField.Text.Length < 4 || registerPasswordField.Text.Length < 4) //валідація
                        {
                            // Якщо якесь поле містить меньше 4 символів
                            MessageBox.Show("Ім'я користувача та пароль повинні містити мінімум 4 символи.");


                            return; // Прериваємо
                        }
                        using (var transaction = sqlConnection.BeginTransaction())
                        {
                            try
                            {
                                // Вставка в usersLogInData
                                string query1 = "INSERT INTO usersLogInData (name, password, unikUserID) VALUES (@Username, @Password, @UserID)";
                                using (SqlCommand command1 = new SqlCommand(query1, sqlConnection, transaction))
                                {
                                    string userID = registerUserField.Text + registerPasswordField.Text; // реалізація створення унікального UserID

                                    command1.Parameters.AddWithValue("@Username", registerUserField.Text);
                                    command1.Parameters.AddWithValue("@Password", registerPasswordField.Text);



                                    command1.Parameters.AddWithValue("@UserID", userID);
                                    command1.ExecuteNonQuery();
                                }

                                // Вставка в workersInfoForm
                                string query2 = "INSERT INTO workersInfoForm (unikUserID) VALUES (@UserID)";
                                using (SqlCommand command2 = new SqlCommand(query2, sqlConnection, transaction))
                                {
                                    string userID = registerUserField.Text + registerPasswordField.Text; 

                                    command2.Parameters.AddWithValue("@UserID", userID);
                                    command2.ExecuteNonQuery();
                                }

                                // Вставка в vacanciesForm
                                string query3 = "INSERT INTO vacanciesForm (unikUserID) VALUES (@UserID)";
                                using (SqlCommand command3 = new SqlCommand(query3, sqlConnection, transaction))
                                {
                                    string userID = registerUserField.Text + registerPasswordField.Text; 

                                    command3.Parameters.AddWithValue("@UserID", userID);
                                    command3.ExecuteNonQuery();
                                }

                                // Якшо всьо ок то підверджуємо транзакцію
                                transaction.Commit();
                                MessageBox.Show("Користувач успішно зареєстрован");
                            }
                            catch (Exception ex)
                            {
                                // В випадку помилки відчиняємо транзакцию
                                transaction.Rollback();
                                MessageBox.Show("ппомилка: " + ex.Message);
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("/: " + ex.Message);
                    }
                }

            }



        }

}

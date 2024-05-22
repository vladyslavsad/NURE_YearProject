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
                this.KeyPreview = true; // �� ��� ��������� �������� ��䳿 ����� �� ���������
                this.KeyDown += MyForm_KeyDownLog; 
                this.AcceptButton = logInButton;   //
                this.AcceptButton = registerButton;// ����� ��䳿 �� ������
                InitializeComponent();
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString); //������ ���������� �� ��
                                                                                                                              // ������������ ����� ���������� ����� �� ���������� �����
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // ³��������� ������ ����������� �� ��������
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(818, 497); 
            this.StartPosition = FormStartPosition.CenterScreen;

        }

            private SqlConnection sqlConnection = null; // ��������� ��������� ������ ��� ���������� ����������


            private void logInButton_Click(object sender, EventArgs e) //��������� ������ ����������
            {
                {
                    using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["usersLogInData"].ConnectionString)) // using ��� ���������� �������� ��
                    {
                        try
                        {
                            sqlConnection.Open(); 
                            // ������� �� ���������� userID
                            string query = "SELECT unikUserID FROM usersLogInData WHERE name=@Username AND password=@Password";
                            using (SqlCommand command = new SqlCommand(query, sqlConnection))
                            {
                                command.Parameters.AddWithValue("@Username", userFieldLogIn.Text); // 
                                command.Parameters.AddWithValue("@Password", passwordFieldLogIn.Text);// �������� ��������� �� ��
                                var unikUserID = command.ExecuteScalar(); // ������ ��������� �������� ��������

                                if (unikUserID != null)
                                {
                                    // �������� userID �� ������������ �������� ����� ��� �������� �������(������ ������ �� ����� � DB )
                                    // ������������ ��������� ��� ���������� SQL ������
                                    introduceForm IntroduceForm = new introduceForm(unikUserID.ToString());
                                    IntroduceForm.Show();

                                    this.Close(); 
                                }
                                else
                                {
                                    MessageBox.Show("�������� ��� ������������ ��� ������.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("������: " + ex.Message);
                        }
                    }



                }

            }

            private void MyForm_KeyDownLog(object sender, KeyEventArgs e) // ������ Enter �� ������
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

                        // �������� ��������� �����������
                        string checkUserQuery = "SELECT COUNT(*) FROM usersLogInData WHERE name = @Username";
                        using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, sqlConnection))
                        {
                            checkUserCommand.Parameters.AddWithValue("@Username", registerUserField.Text);
                            int userExists = (int)checkUserCommand.ExecuteScalar();

                            if (userExists > 0)
                            {
                                MessageBox.Show("���������� � ����� ���� ��� ����.");
                                return; // ���������� ���� ��� �� ���������
                            }
                        }

                        if (registerUserField.Text.Length < 4 || registerPasswordField.Text.Length < 4) //��������
                        {
                            // ���� ����� ���� ������ ������ 4 �������
                            MessageBox.Show("��'� ����������� �� ������ ������ ������ ����� 4 �������.");


                            return; // ���������
                        }
                        using (var transaction = sqlConnection.BeginTransaction())
                        {
                            try
                            {
                                // ������� � usersLogInData
                                string query1 = "INSERT INTO usersLogInData (name, password, unikUserID) VALUES (@Username, @Password, @UserID)";
                                using (SqlCommand command1 = new SqlCommand(query1, sqlConnection, transaction))
                                {
                                    string userID = registerUserField.Text + registerPasswordField.Text; // ��������� ��������� ���������� UserID

                                    command1.Parameters.AddWithValue("@Username", registerUserField.Text);
                                    command1.Parameters.AddWithValue("@Password", registerPasswordField.Text);



                                    command1.Parameters.AddWithValue("@UserID", userID);
                                    command1.ExecuteNonQuery();
                                }

                                // ������� � workersInfoForm
                                string query2 = "INSERT INTO workersInfoForm (unikUserID) VALUES (@UserID)";
                                using (SqlCommand command2 = new SqlCommand(query2, sqlConnection, transaction))
                                {
                                    string userID = registerUserField.Text + registerPasswordField.Text; 

                                    command2.Parameters.AddWithValue("@UserID", userID);
                                    command2.ExecuteNonQuery();
                                }

                                // ������� � vacanciesForm
                                string query3 = "INSERT INTO vacanciesForm (unikUserID) VALUES (@UserID)";
                                using (SqlCommand command3 = new SqlCommand(query3, sqlConnection, transaction))
                                {
                                    string userID = registerUserField.Text + registerPasswordField.Text; 

                                    command3.Parameters.AddWithValue("@UserID", userID);
                                    command3.ExecuteNonQuery();
                                }

                                // ���� ���� �� �� ���������� ����������
                                transaction.Commit();
                                MessageBox.Show("���������� ������ �����������");
                            }
                            catch (Exception ex)
                            {
                                // � ������� ������� ��������� ����������
                                transaction.Rollback();
                                MessageBox.Show("��������: " + ex.Message);
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

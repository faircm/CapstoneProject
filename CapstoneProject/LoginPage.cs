using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class LoginPage : Form
    {
        bool isSpanish = CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToLower().Equals("es");
        private MySqlDataReader reader;
        private Dictionary<string, string> logins = new Dictionary<string, string>();

        public LoginPage()
        {
            InitializeComponent();
            if (isSpanish)
            {
                usernameLabel.Text = "Nombre de usuario";
                passwordLabel.Text = "Contraseña";
                loginBtn.Text = "Iniciar";
                clearBtn.Text = "Borrar";
                welcomeMsg.Text =
                    "Bienvenidos!\nPor favor, entre su información\npara iniciar sesión";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            string checkUsername;
            string checkPassword;

            bool isCorrect = false;

            MySqlCommand cmd = new MySqlCommand(
                $"SELECT username, password, userId FROM user WHERE username IN('{username}') AND password IN('{password}')",
                DatabaseConnection.connection
            );

            string fileDir = System.Environment.GetFolderPath(
                System.Environment.SpecialFolder.MyDocuments
            );
            string filePath = System.IO.Path.Combine(fileDir, "capstonelogfile.txt");

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    checkUsername = (string)reader.GetValue(reader.GetOrdinal("userName"));
                    checkPassword = (string)reader.GetValue(reader.GetOrdinal("password"));
                    if (checkUsername.Equals(username) && checkPassword.Equals(password))
                    {
                        isCorrect = true;
                        break;
                    }
                }
            }
            try
            {
                userContext.setUserId((int)reader.GetValue(reader.GetOrdinal("userId")));
                userContext.setUsername(username);
            }
            catch (Exception)
            {
                if (isSpanish)
                {
                    MessageBox.Show(
                        "Credenciales de inicio rechazados.",
                        "Inicio de session incorrecto!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Login credentials not accepted.\nPlease check your username and password.",
                        "Login unsuccessful!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                File.AppendAllText(
                    filePath,
                    $"USER {username} FAILED LOGIN ATTEMPT AT {DateTime.Now}\n"
                );
            }
            reader.Close();
            Appointment.apptList = Appointment.getAppts();

            if (isCorrect)
            {
                if (isSpanish)
                {
                    MessageBox.Show(
                        "Credenciales de inicio aceptados",
                        "Inicio de session correcto!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Login credentials accepted.",
                        "Login successful!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                File.AppendAllText(
                    filePath,
                    $"USER {username} SUCCESSFULLY LOGGED IN AT {DateTime.Now}\n"
                );
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                this.Hide();
            }
        }
    }
}

using System;
using System.Windows.Forms;
using System.Linq;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class Registration : Form
    {
        private bool isFIOSelected;
        private bool isBirthDateSelected;
        private bool isPhoneNumberSelected;
        private bool isLoginSelected;
        private bool isPasswordSelected;

        public Registration()
        {
            InitializeComponent();

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            Register.Enabled = false;

            isFIOSelected = false;
            isBirthDateSelected = false;
            isPhoneNumberSelected = false;
            isLoginSelected = false;
            isPasswordSelected = false;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void FIO_TextChanged(object sender, EventArgs e)
        {
            isFIOSelected = false;

            if (!String.IsNullOrEmpty(FIO.Text))
            {
                isFIOSelected = true;
            }

            Register.Enabled = isFIOSelected && isBirthDateSelected && isPhoneNumberSelected && isLoginSelected && isPasswordSelected;
        }

        private void Birthdate_ValueChanged(object sender, EventArgs e)
        {
            isBirthDateSelected = false;

            if (Birthdate.Value > DateTime.Now.Date)
            {
                MessageBox.Show("    Некорректная дата!    ");
            }
            else
            {
                isBirthDateSelected = true;
            }

            Register.Enabled = isFIOSelected && isBirthDateSelected && isPhoneNumberSelected && isLoginSelected && isPasswordSelected;
        }

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            isPhoneNumberSelected = false;

            if (!String.IsNullOrEmpty(PhoneNumber.Text))
            {
                isPhoneNumberSelected = true;
            }

            if (!PhoneNumber.Text.All(char.IsDigit) || !PhoneNumber.Text.StartsWith("8"))
            {
                MessageBox.Show("    Некорректный номер телефона!    ");
                isPhoneNumberSelected = false;
            }

            Register.Enabled = isFIOSelected && isBirthDateSelected && isPhoneNumberSelected && isLoginSelected && isPasswordSelected;
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            isLoginSelected = false;

            if (!String.IsNullOrEmpty(Login.Text))
            {
                isLoginSelected = true;
            }

            Register.Enabled = isFIOSelected && isBirthDateSelected && isPhoneNumberSelected && isLoginSelected && isPasswordSelected;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            isPasswordSelected = false;

            if (!String.IsNullOrEmpty(Password.Text))
            {
                isPasswordSelected = true;
            }

            Register.Enabled = isFIOSelected && isBirthDateSelected && isPhoneNumberSelected && isLoginSelected && isPasswordSelected;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            OleDbCommand selectUser = new OleDbCommand("SELECT FIO, TypeUser FROM Users " +
                                                            "WHERE Login = ? AND Password = ?", cn);
            selectUser.Parameters.Add("@Login", OleDbType.VarChar);
            selectUser.Parameters.Add("@Password", OleDbType.VarChar);
            selectUser.Parameters[0].Value = Login.Text;
            selectUser.Parameters[1].Value = Password.Text;
            selectUser.ExecuteNonQuery();

            OleDbDataReader reader = selectUser.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("    Пользователь с таким логином и паролем уже существует!    ");
                return;
            }
            reader.Close();

            OleDbCommand insertIntoPatients = new OleDbCommand("INSERT INTO Patients (FIO, Birthdate, PhoneNumber) VALUES (?, ?, ?)", cn);
            insertIntoPatients.Parameters.Add("@FIO", OleDbType.VarChar);
            insertIntoPatients.Parameters.Add("@Birthdate", OleDbType.DBDate);
            insertIntoPatients.Parameters.Add("@PhoneNumber", OleDbType.VarChar);
            insertIntoPatients.Parameters[0].Value = FIO.Text;
            insertIntoPatients.Parameters[1].Value = Birthdate.Value;
            insertIntoPatients.Parameters[2].Value = PhoneNumber.Text;
            insertIntoPatients.ExecuteNonQuery();

            OleDbCommand insertIntoUsers = new OleDbCommand("INSERT INTO Users (Login, Password, FIO, TypeUser) VALUES (?, ?, ?, ?)", cn);
            insertIntoUsers.Parameters.Add("@Login", OleDbType.VarChar);
            insertIntoUsers.Parameters.Add("@Password", OleDbType.VarChar);
            insertIntoUsers.Parameters.Add("@FIO", OleDbType.VarChar);
            insertIntoUsers.Parameters.Add("@TypeUser", OleDbType.Integer);
            insertIntoUsers.Parameters[0].Value = Login.Text;
            insertIntoUsers.Parameters[1].Value = Password.Text;
            insertIntoUsers.Parameters[2].Value = FIO.Text;
            insertIntoUsers.Parameters[3].Value = 3;
            insertIntoUsers.ExecuteNonQuery();

            MessageBox.Show("    Пользователь успешно зарегестрирован!    ");
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class MainForm : Form
    {
        private bool isLoginSelected;
        private bool isPasswordSelected;

        public MainForm()
        {
            InitializeComponent();

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            Entry.Enabled = false;
            Registration.Enabled = true;

            isLoginSelected = false;
            isPasswordSelected = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            isLoginSelected = false;

            if (!String.IsNullOrEmpty(Login.Text))
            {
                isLoginSelected = true;
            }

            Entry.Enabled = isLoginSelected && isPasswordSelected;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            isPasswordSelected = false;

            if (!String.IsNullOrEmpty(Password.Text))
            {
                isPasswordSelected = true;
            }

            Entry.Enabled = isLoginSelected && isPasswordSelected;
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            OleDbCommand selectUser = new OleDbCommand("SELECT FIO, TypeUser FROM Users " +
                                                            "WHERE Login = ? AND Password = ?", cn);
            selectUser.Parameters.Add("@Login", OleDbType.VarChar);
            selectUser.Parameters.Add("@Password", OleDbType.VarChar);
            selectUser.Parameters[0].Value = Login.Text;
            selectUser.Parameters[1].Value = Password.Text;
            selectUser.ExecuteNonQuery();

            object FIO;
            object TypeUser;

            OleDbDataReader reader = selectUser.ExecuteReader();
            if(reader.Read())
            {
                FIO = reader["FIO"];
                TypeUser = reader["TypeUser"];
            }
            else
            {
                MessageBox.Show("    Нет пользователя с таким логином или паролем!    ");
                return;
            }
            reader.Close();

            if((int)TypeUser == 1)
            {
                FormAdmin formAdmin = new FormAdmin(FIO.ToString());
                formAdmin.ShowDialog();
            }
            else if((int)TypeUser == 2)
            {
                FormDoctor formDoctor = new FormDoctor(FIO.ToString());
                formDoctor.ShowDialog();
            }
            else
            {
                FormPatient formPatient = new FormPatient(FIO.ToString());
                formPatient.ShowDialog();
            }
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }
    }
}

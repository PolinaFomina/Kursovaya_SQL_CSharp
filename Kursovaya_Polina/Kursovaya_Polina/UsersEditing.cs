using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class UsersEditing : Form
    {
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;

        private bool isTypeUser1Selected;
        private bool isIdUser1Selected;

        private bool isTypeUser2Selected;
        private bool isFIOSelected;
        private bool isLogin1Selected;
        private bool isPassword1Selected;

        private bool isTypeUser3Selected;
        private bool isIdUser2Selected;
        private bool isLogin2Selected;
        private bool isPassword2Selected;

        public UsersEditing()
        {
            InitializeComponent();

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable Users;
            Users = dSet.Tables.Add("Users");
            Users.Columns.Add("IdUser", typeof(string));
            Users.Columns.Add("FIO", typeof(string));
            Users.Columns.Add("Login", typeof(string));
            Users.Columns.Add("Password", typeof(string));
            Users.Columns.Add("TypeUser", typeof(string));

            dgUsers.SetDataBinding(dSet, "Users");

            OleDbCommand selectUsers = new OleDbCommand("SELECT IdUser, FIO, Login, Password, NameType AS TypeUser FROM Users " +
                                                            "JOIN TypeUsers ON Users.TypeUser = TypeUsers.IdTypeUser", cn);

            selectUsers.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectUsers;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Users");

            OleDbCommand selectTypeUsers = new OleDbCommand("SELECT NameType FROM TypeUsers", cn);

            OleDbDataReader reader = selectTypeUsers.ExecuteReader();
            while (reader.Read())
            {
                TypeUsers1.Items.Add(reader["NameType"]);
                TypeUsers2.Items.Add(reader["NameType"]);
                TypeUsers3.Items.Add(reader["NameType"]);
            }
            reader.Close();

            DeleteUser.Enabled = false;
            AddUser.Enabled = false;
            EditUser.Enabled = false;

            isTypeUser1Selected = false;
            isIdUser1Selected = false;

            isTypeUser2Selected = false;
            isFIOSelected = false;
            isLogin1Selected = false;
            isPassword1Selected = false;

            isTypeUser3Selected = false;
            isIdUser2Selected = false;
            isLogin2Selected = false;
            isPassword2Selected = false;
        }

        private void UsersEditing_Load(object sender, EventArgs e)
        {

        }

        private void selectIdUsers(ComboBox TypeUsers, ComboBox IdUser)
        {
            OleDbCommand selectIdUsers = new OleDbCommand("SELECT IdUser FROM Users " +
                                                                "JOIN TypeUsers ON Users.TypeUser = TypeUsers.IdTypeUser " +
                                                                    "WHERE NameType = ?", cn);
            selectIdUsers.Parameters.Add("@NameType", OleDbType.VarChar);
            selectIdUsers.Parameters[0].Value = TypeUsers.Text;
            selectIdUsers.ExecuteNonQuery();

            OleDbDataReader reader = selectIdUsers.ExecuteReader();
            IdUser.Items.Clear();
            while (reader.Read())
            {
                IdUser.Items.Add(reader["IdUser"]);
            }
            reader.Close();
        }

        private void updateUsers(ComboBox TypeUsers)
        {
            dSet.Tables[0].Clear();

            OleDbCommand selectUsers = new OleDbCommand("SELECT IdUser, FIO, Login, Password, NameType AS TypeUser FROM Users " +
                                                            "JOIN TypeUsers ON Users.TypeUser = TypeUsers.IdTypeUser " +
                                                                "WHERE NameType = ?", cn);
            selectUsers.Parameters.Add("@NameType", OleDbType.VarChar);
            selectUsers.Parameters[0].Value = TypeUsers.Text;
            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectUsers;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Users");
        }

        private void TypeUsers1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdUser1.Text = "";
            isIdUser1Selected = false;

            isTypeUser1Selected = true;

            updateUsers(TypeUsers1);
            selectIdUsers(TypeUsers1, IdUser1);

            DeleteUser.Enabled = isTypeUser1Selected && isIdUser1Selected;
        }

        private void IdUser1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIdUser1Selected = true;
            DeleteUser.Enabled = isTypeUser1Selected && isIdUser1Selected;
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            OleDbCommand selectFIO = new OleDbCommand("Select FIO, TypeUser FROM Users WHERE IdUser = ?", cn);
            selectFIO.Parameters.Add("@IdUser", OleDbType.Integer);
            selectFIO.Parameters[0].Value = IdUser1.SelectedItem;

            selectFIO.ExecuteNonQuery();

            OleDbDataReader reader = selectFIO.ExecuteReader();
            reader.Read();
            string FIO = reader["FIO"].ToString();
            string TypeUser = reader["TypeUser"].ToString();
            reader.Close();

            OleDbCommand deleteUser = new OleDbCommand("DELETE FROM Users WHERE IdUser = ?", cn);
            deleteUser.Parameters.Add("@IdUser", OleDbType.Integer);
            deleteUser.Parameters[0].Value = IdUser1.SelectedItem;

            deleteUser.ExecuteNonQuery();

            if(TypeUser == "1")
            {
                deleteUser = new OleDbCommand("DELETE FROM Administrators WHERE FIO = ?", cn);
            }
            else if(TypeUser == "2")
            {
                deleteUser = new OleDbCommand("DELETE FROM Doctors WHERE FIO = ?", cn);
            }
            else
            {
                deleteUser = new OleDbCommand("DELETE FROM Patients WHERE FIO = ?", cn);
            }

            deleteUser.Parameters.Add("@FIO", OleDbType.VarChar);
            deleteUser.Parameters[0].Value = FIO;

            deleteUser.ExecuteNonQuery();

            updateUsers(TypeUsers1);

            TypeUsers1.Text = "";
            IdUser1.Text = "";

            DeleteUser.Enabled = false;

            MessageBox.Show("    Пользователь удален!    ");
        }

        private void selectFIO(ComboBox TypeUsers, ComboBox FIO)
        {
            OleDbCommand selectFIO;
            if (TypeUsers.Text == "Администратор")
            {
                selectFIO = new OleDbCommand("SELECT FIO FROM Administrators " +
                                             "EXCEPT " +
                                             "SELECT FIO FROM Users " +
                                                "JOIN TypeUsers ON Users.TypeUser = TypeUsers.IdTypeUser " +
                                                    "WHERE NameType = ?", cn);
            }
            else if(TypeUsers.Text == "Врач")
            {
                selectFIO = new OleDbCommand("SELECT FIO FROM Doctors " +
                                             "EXCEPT " +
                                             "SELECT FIO FROM Users " +
                                                "JOIN TypeUsers ON Users.TypeUser = TypeUsers.IdTypeUser " +
                                                    "WHERE NameType = ?", cn);
            }
            else
            {
                selectFIO = new OleDbCommand("SELECT FIO FROM Patients " +
                                             "EXCEPT " +
                                             "SELECT FIO FROM Users " +
                                                "JOIN TypeUsers ON Users.TypeUser = TypeUsers.IdTypeUser " +
                                                    "WHERE NameType = ?", cn);
            }

            selectFIO.Parameters.Add("@NameType", OleDbType.VarChar);
            selectFIO.Parameters[0].Value = TypeUsers.Text;
            selectFIO.ExecuteNonQuery();

            OleDbDataReader reader = selectFIO.ExecuteReader();
            FIO.Items.Clear();
            while (reader.Read())
            {
                FIO.Items.Add(reader["FIO"]);
            }
            reader.Close();
        }

        private void TypeUsers2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FIO.Text = "";
            isFIOSelected = false;

            isTypeUser2Selected = true;

            updateUsers(TypeUsers2);
            selectFIO(TypeUsers2, FIO);

            AddUser.Enabled = isTypeUser2Selected && isFIOSelected && isLogin1Selected && isPassword1Selected;
        }

        private void FIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            isFIOSelected = true;
            AddUser.Enabled = isTypeUser2Selected && isFIOSelected && isLogin1Selected && isPassword1Selected;
        }

        private void Login1_TextChanged(object sender, EventArgs e)
        {
            isLogin1Selected = false;
            if(!String.IsNullOrEmpty(Login1.Text))
            {
                isLogin1Selected = true;
            }

            AddUser.Enabled = isTypeUser2Selected && isFIOSelected && isLogin1Selected && isPassword1Selected;
        }

        private void Password1_TextChanged(object sender, EventArgs e)
        {
            isPassword1Selected = false;
            if(!String.IsNullOrEmpty(Password1.Text))
            {
                isPassword1Selected = true;
            }

            AddUser.Enabled = isTypeUser2Selected && isFIOSelected && isLogin1Selected && isPassword1Selected;
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            OleDbCommand selectIdTypeUser = new OleDbCommand("SELECT IdTypeUser FROM TypeUsers WHERE NameType = ?", cn);
            selectIdTypeUser.Parameters.Add("@NameType", OleDbType.VarChar);
            selectIdTypeUser.Parameters[0].Value = TypeUsers2.Text;
            selectIdTypeUser.ExecuteNonQuery();

            OleDbDataReader reader = selectIdTypeUser.ExecuteReader();
            reader.Read();
            int IdTypeUser = (int)reader["IdTypeUser"];
            reader.Close();

            OleDbCommand insertIntoUsers = new OleDbCommand("INSERT INTO Users (Login, Password, FIO, TypeUser) VALUES (?, ?, ?, ?)", cn);
            insertIntoUsers.Parameters.Add("@Login", OleDbType.VarChar);
            insertIntoUsers.Parameters.Add("@Password", OleDbType.VarChar);
            insertIntoUsers.Parameters.Add("@FIO", OleDbType.VarChar);
            insertIntoUsers.Parameters.Add("@TypeUser", OleDbType.Integer);
            insertIntoUsers.Parameters[0].Value = Login1.Text;
            insertIntoUsers.Parameters[1].Value = Password1.Text;
            insertIntoUsers.Parameters[2].Value = FIO.Text;
            insertIntoUsers.Parameters[3].Value = IdTypeUser;
            insertIntoUsers.ExecuteNonQuery();

            updateUsers(TypeUsers2);

            TypeUsers2.Text = "";
            FIO.Text = "";
            Login1.Text = "";
            Password1.Text = "";

            AddUser.Enabled = false;

            isTypeUser2Selected = false;
            isFIOSelected = false;
            isLogin1Selected = false;
            isPassword1Selected = false;

            MessageBox.Show("    Пользователь добавлен!    ");
        }

        private void TypeUsers3_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdUser2.Text = "";
            isIdUser2Selected = false;

            isTypeUser3Selected = true;

            updateUsers(TypeUsers3);
            selectIdUsers(TypeUsers3, IdUser2);

            EditUser.Enabled = isTypeUser3Selected && isIdUser2Selected && isLogin2Selected && isPassword2Selected;
        }

        private void IdUser2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIdUser2Selected = true;
            EditUser.Enabled = isTypeUser3Selected && isIdUser2Selected && isLogin2Selected && isPassword2Selected;
        }

        private void Login2_TextChanged(object sender, EventArgs e)
        {
            isLogin2Selected = false;
            if (!String.IsNullOrEmpty(Login2.Text))
            {
                isLogin2Selected = true;
            }

            EditUser.Enabled = isTypeUser3Selected && isIdUser2Selected && isLogin2Selected && isPassword2Selected;
        }

        private void Password2_TextChanged(object sender, EventArgs e)
        {
            isPassword2Selected = false;
            if (!String.IsNullOrEmpty(Password2.Text))
            {
                isPassword2Selected = true;
            }

            EditUser.Enabled = isTypeUser3Selected && isIdUser2Selected && isLogin2Selected && isPassword2Selected;
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            OleDbCommand updateUsers = new OleDbCommand("UPDATE Users SET Login = ?, Password = ? WHERE IdUser = ?", cn);
            updateUsers.Parameters.Add("@Login", OleDbType.VarChar);
            updateUsers.Parameters.Add("@Password", OleDbType.VarChar);
            updateUsers.Parameters.Add("@IdUser", OleDbType.Integer);
            updateUsers.Parameters[0].Value = Login2.Text;
            updateUsers.Parameters[1].Value = Password2.Text;
            updateUsers.Parameters[2].Value = IdUser2.SelectedItem;
            updateUsers.ExecuteNonQuery();

            this.updateUsers(TypeUsers3);

            TypeUsers3.Text = "";
            IdUser2.Text = "";
            Login2.Text = "";
            Password2.Text = "";

            EditUser.Enabled = false;

            isTypeUser3Selected = false;
            isIdUser2Selected = false;
            isLogin2Selected = false;
            isPassword2Selected = false;

            MessageBox.Show("    Пользователь отредактирован!    ");
        }
    }
}

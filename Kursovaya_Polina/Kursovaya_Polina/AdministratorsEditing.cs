using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class AdministratorsEditing : Form
    {
        private FormAdmin formAdmin;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;

        private bool isIdAdministrator2Selected;
        private bool isFioOfAdministrator2Selected;
        public AdministratorsEditing()
        {
            InitializeComponent();

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable administrators;
            administrators = dSet.Tables.Add("Administrators");
            administrators.Columns.Add("IdAdministrator", typeof(int));
            administrators.Columns.Add("FIO", typeof(string));

            dgAdministrators.SetDataBinding(dSet, "Administrators");

            OleDbCommand selectAdministrators = new OleDbCommand("SELECT IdAdministrator, FIO FROM Administrators", cn);

            selectAdministrators.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectAdministrators;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Administrators");

            OleDbDataReader reader = selectAdministrators.ExecuteReader();
            while (reader.Read())
            {
                IdAdministrator1.Items.Add(reader["IdAdministrator"]);
                IdAdministrator2.Items.Add(reader["IdAdministrator"]);
            }
            reader.Close();

            DeleteAdministrator.Enabled = false;
            AddAdministrator.Enabled = false;
            EditAdministrator.Enabled = false;

            isIdAdministrator2Selected = false;
            isFioOfAdministrator2Selected = false;
        }

        private void AdministratorsEditing_Load(object sender, EventArgs e)
        {

        }

        private void updateIdAdministrators()
        {
            OleDbCommand selectIdAdministrator = new OleDbCommand("SELECT IdAdministrator FROM Administrators", cn);
            selectIdAdministrator.ExecuteNonQuery();

            OleDbDataReader reader = selectIdAdministrator.ExecuteReader();
            IdAdministrator1.Items.Clear();
            IdAdministrator2.Items.Clear();
            while (reader.Read())
            {
                IdAdministrator1.Items.Add(reader["IdAdministrator"]);
                IdAdministrator2.Items.Add(reader["IdAdministrator"]);
            }
            reader.Close();
        }

        private void updateAdministrators()
        {
            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Administrators");
        }

        private void IdAdministrator1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteAdministrator.Enabled = true;
        }

        private void DeleteAdministrator_Click(object sender, EventArgs e)
        {
            OleDbCommand deleteAdministrator = new OleDbCommand("DELETE FROM Administrators WHERE IdAdministrator = ?", cn);
            deleteAdministrator.Parameters.Add("@IdAdministrator", OleDbType.Integer);
            deleteAdministrator.Parameters[0].Value = IdAdministrator1.SelectedItem;

            deleteAdministrator.ExecuteNonQuery();
            IdAdministrator1.Text = "";
            DeleteAdministrator.Enabled = false;
            updateAdministrators();
            updateIdAdministrators();
            MessageBox.Show("    Данные администратора удалены!    ");
        }

        private void FioOfAdministrator1_TextChanged(object sender, EventArgs e)
        {
            AddAdministrator.Enabled = false;

            if (!String.IsNullOrEmpty(FioOfAdministrator1.Text))
            {
                AddAdministrator.Enabled = true;
            }
        }

        private void AddAdministrator_Click(object sender, EventArgs e)
        {
            OleDbCommand insertIntoAdministrators = new OleDbCommand("INSERT INTO Administrators (FIO) VALUES (?)", cn);
            insertIntoAdministrators.Parameters.Add("@FIO", OleDbType.VarChar);
            insertIntoAdministrators.Parameters[0].Value = FioOfAdministrator1.Text;
            insertIntoAdministrators.ExecuteNonQuery();

            FioOfAdministrator1.Text = "";

            AddAdministrator.Enabled = false;

            updateAdministrators();

            updateIdAdministrators();

            MessageBox.Show("    Данные администратора добавлены!    ");
        }

        private void IdAdministrator2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIdAdministrator2Selected = true;
            EditAdministrator.Enabled = isIdAdministrator2Selected && isFioOfAdministrator2Selected;
        }

        private void FioOfAdministrator2_TextChanged(object sender, EventArgs e)
        {
            isFioOfAdministrator2Selected = true;

            if (String.IsNullOrEmpty(FioOfAdministrator2.Text))
            {
                isFioOfAdministrator2Selected = false;
            }

            EditAdministrator.Enabled = isIdAdministrator2Selected && isFioOfAdministrator2Selected;
        }

        private void EditAdministrator_Click(object sender, EventArgs e)
        {
            OleDbCommand updateAdministrators = new OleDbCommand("UPDATE Administrators SET FIO = ? WHERE IdAdministrator = ?", cn);
            updateAdministrators.Parameters.Add("@FIO", OleDbType.VarChar);
            updateAdministrators.Parameters.Add("@IdAdministrator", OleDbType.Integer);
            updateAdministrators.Parameters[0].Value = FioOfAdministrator2.Text;
            updateAdministrators.Parameters[1].Value = IdAdministrator2.SelectedItem;
            updateAdministrators.ExecuteNonQuery();

            IdAdministrator2.Text = "";
            FioOfAdministrator2.Text = "";

            EditAdministrator.Enabled = false;

            this.updateAdministrators();

            isIdAdministrator2Selected = false;
            isFioOfAdministrator2Selected = false;

            MessageBox.Show("    Данные администратора отредактированы!    ");
        }
    }
}

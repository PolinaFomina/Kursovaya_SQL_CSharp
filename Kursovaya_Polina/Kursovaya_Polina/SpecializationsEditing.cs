using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class SpecializationsEditing : Form
    {
        private FormAdmin formAdmin;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;

        private bool isIdSpecialization2Selected;
        private bool isNameOfSpecialization2Selected;
        public SpecializationsEditing(FormAdmin formAdmin)
        {
            InitializeComponent();

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            this.formAdmin = formAdmin;

            dSet = new DataSet();
            DataTable specializations;
            specializations = dSet.Tables.Add("Specializations");
            specializations.Columns.Add("IdSpecialization", typeof(int));
            specializations.Columns.Add("Name", typeof(string));

            dgSpecializations.SetDataBinding(dSet, "Specializations");

            OleDbCommand selectSpecializations = new OleDbCommand("SELECT IdSpecialization, Name FROM Specializations", cn);

            selectSpecializations.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectSpecializations;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Specializations");

            OleDbDataReader reader = selectSpecializations.ExecuteReader();
            while (reader.Read())
            {
                IdSpecialization1.Items.Add(reader["IdSpecialization"]);
                IdSpecialization2.Items.Add(reader["IdSpecialization"]);
            }
            reader.Close();

            DeleteSpecialization.Enabled = false;
            AddSpecialization.Enabled = false;
            EditSpecialization.Enabled = false;

            isIdSpecialization2Selected = false;
            isNameOfSpecialization2Selected = false;
        }

        private void SpecializationsEditing_Load(object sender, EventArgs e)
        {

        }

        private void updateIdSpecializations()
        {
            OleDbCommand selectIdSpecializations = new OleDbCommand("SELECT IdSpecialization FROM Specializations", cn);
            selectIdSpecializations.ExecuteNonQuery();

            OleDbDataReader reader = selectIdSpecializations.ExecuteReader();
            IdSpecialization1.Items.Clear();
            IdSpecialization2.Items.Clear();
            while (reader.Read())
            {
                IdSpecialization1.Items.Add(reader["IdSpecialization"]);
                IdSpecialization2.Items.Add(reader["IdSpecialization"]);
            }
            reader.Close();
        }

        private void updateSpecializations()
        {
            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Specializations");
        }

        private void IdSpecialization1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteSpecialization.Enabled = true;
        }

        private void DeleteSpecialization_Click(object sender, EventArgs e)
        {
            OleDbCommand deleteSpecialization = new OleDbCommand("DELETE FROM Specializations WHERE IdSpecialization = ?", cn);
            deleteSpecialization.Parameters.Add("@IdSpecialization", OleDbType.Integer);
            deleteSpecialization.Parameters[0].Value = IdSpecialization1.SelectedItem;

            deleteSpecialization.ExecuteNonQuery();
            IdSpecialization1.Text = "";
            DeleteSpecialization.Enabled = false;
            updateSpecializations();
            updateIdSpecializations();
            MessageBox.Show("    Специализация удалена!    ");
        }

        private void NameOfSpecialization1_TextChanged(object sender, EventArgs e)
        {
            AddSpecialization.Enabled = false;

            if (!String.IsNullOrEmpty(NameOfSpecialization1.Text))
            {
                AddSpecialization.Enabled = true;
            }
        }

        private void AddSpecialization_Click(object sender, EventArgs e)
        {
            OleDbCommand insertIntoSpecializations = new OleDbCommand("INSERT INTO Specializations (Name) VALUES (?)", cn);
            insertIntoSpecializations.Parameters.Add("@Name", OleDbType.VarChar);
            insertIntoSpecializations.Parameters[0].Value = NameOfSpecialization1.Text;
            insertIntoSpecializations.ExecuteNonQuery();

            NameOfSpecialization1.Text = "";

            AddSpecialization.Enabled = false;

            updateSpecializations();

            updateIdSpecializations();

            MessageBox.Show("    Специализация добавлена!    ");
        }

        private void IdSpecialization2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIdSpecialization2Selected = true;
            EditSpecialization.Enabled = isIdSpecialization2Selected && isNameOfSpecialization2Selected;
        }

        private void NameOfSpecialization2_TextChanged(object sender, EventArgs e)
        {
            isNameOfSpecialization2Selected = true;

            if (String.IsNullOrEmpty(NameOfSpecialization2.Text))
            {
                isNameOfSpecialization2Selected = false;
            }

            EditSpecialization.Enabled = isIdSpecialization2Selected && isNameOfSpecialization2Selected;
        }

        private void EditSpecialization_Click(object sender, EventArgs e)
        {
            OleDbCommand updateSpecializations = new OleDbCommand("UPDATE Specializations SET Name = ? WHERE IdSpecialization = ?", cn);
            updateSpecializations.Parameters.Add("@Name", OleDbType.VarChar);
            updateSpecializations.Parameters.Add("@IdSpecialization", OleDbType.Integer);
            updateSpecializations.Parameters[0].Value = NameOfSpecialization2.Text;
            updateSpecializations.Parameters[1].Value = IdSpecialization2.SelectedItem;
            updateSpecializations.ExecuteNonQuery();

            IdSpecialization2.Text = "";
            NameOfSpecialization2.Text = "";

            EditSpecialization.Enabled = false;

            this.updateSpecializations();

            isIdSpecialization2Selected = false;
            isNameOfSpecialization2Selected = false;

            MessageBox.Show("    Специализация отредактирована!    ");
        }

        private void SpecializationsEditing_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAdmin.updateFormAdmin();
        }
    }
}

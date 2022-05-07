using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class DiagnosesEditing : Form
    {
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;

        private bool isIdDiagnose2Selected;
        private bool isNameOfDiagnose2Selected;

        public DiagnosesEditing()
        {
            InitializeComponent();

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable Diagnoses;
            Diagnoses = dSet.Tables.Add("Diagnoses");
            Diagnoses.Columns.Add("IdDiagnose", typeof(int));
            Diagnoses.Columns.Add("Name", typeof(string));

            dgDiagnoses.SetDataBinding(dSet, "Diagnoses");

            OleDbCommand selectDiagnoses = new OleDbCommand("SELECT IdDiagnose, Name FROM Diagnoses", cn);

            selectDiagnoses.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectDiagnoses;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Diagnoses");

            OleDbDataReader reader = selectDiagnoses.ExecuteReader();
            while (reader.Read())
            {
                IdDiagnose1.Items.Add(reader["IdDiagnose"]);
                IdDiagnose2.Items.Add(reader["IdDiagnose"]);
            }
            reader.Close();

            DeleteDiagnose.Enabled = false;
            AddDiagnose.Enabled = false;
            EditDiagnose.Enabled = false;

            isIdDiagnose2Selected = false;
            isNameOfDiagnose2Selected = false;
        }

        private void DiagnosesEditing_Load(object sender, EventArgs e)
        {

        }

        private void updateIdDiagnoses()
        {
            OleDbCommand selectIdDiagnoses = new OleDbCommand("SELECT IdDiagnose FROM Diagnoses", cn);
            selectIdDiagnoses.ExecuteNonQuery();

            OleDbDataReader reader = selectIdDiagnoses.ExecuteReader();
            IdDiagnose1.Items.Clear();
            IdDiagnose2.Items.Clear();
            while (reader.Read())
            {
                IdDiagnose1.Items.Add(reader["IdDiagnose"]);
                IdDiagnose2.Items.Add(reader["IdDiagnose"]);
            }
            reader.Close();
        }

        private void updateDiagnoses()
        {
            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Diagnoses");
        }

        private void IdDiagnose1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteDiagnose.Enabled = true;
        }

        private void DeleteDiagnose_Click(object sender, EventArgs e)
        {
            OleDbCommand deleteDiagnose = new OleDbCommand("DELETE FROM Diagnoses WHERE IdDiagnose = ?", cn);
            deleteDiagnose.Parameters.Add("@IdDiagnose", OleDbType.Integer);
            deleteDiagnose.Parameters[0].Value = IdDiagnose1.SelectedItem;

            deleteDiagnose.ExecuteNonQuery();
            IdDiagnose1.Text = "";
            DeleteDiagnose.Enabled = false;
            updateDiagnoses();
            updateIdDiagnoses();
            MessageBox.Show("    Диагноз удален!    ");
        }

        private void NameOfDiagnose1_TextChanged(object sender, EventArgs e)
        {
            AddDiagnose.Enabled = false;

            if (!String.IsNullOrEmpty(NameOfDiagnose1.Text))
            {
                AddDiagnose.Enabled = true;
            }
        }

        private void AddDiagnose_Click(object sender, EventArgs e)
        {
            OleDbCommand insertIntoDiagnoses = new OleDbCommand("INSERT INTO Diagnoses (Name) VALUES (?)", cn);
            insertIntoDiagnoses.Parameters.Add("@Name", OleDbType.VarChar);
            insertIntoDiagnoses.Parameters[0].Value = NameOfDiagnose1.Text;
            insertIntoDiagnoses.ExecuteNonQuery();

            NameOfDiagnose1.Text = "";

            AddDiagnose.Enabled = false;

            updateDiagnoses();

            updateIdDiagnoses();

            MessageBox.Show("    Диагноз добавлен!    ");
        }

        private void IdDiagnose2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIdDiagnose2Selected = true;
            EditDiagnose.Enabled = isIdDiagnose2Selected && isNameOfDiagnose2Selected;
        }

        private void NameOfDiagnose2_TextChanged(object sender, EventArgs e)
        {
            isNameOfDiagnose2Selected = true;

            if (String.IsNullOrEmpty(NameOfDiagnose2.Text))
            {
                isNameOfDiagnose2Selected = false;
            }

            EditDiagnose.Enabled = isIdDiagnose2Selected && isNameOfDiagnose2Selected;
        }

        private void EditDiagnose_Click(object sender, EventArgs e)
        {
            OleDbCommand updateDiagnoses = new OleDbCommand("UPDATE Diagnoses SET Name = ? WHERE IdDiagnose = ?", cn);
            updateDiagnoses.Parameters.Add("@Name", OleDbType.VarChar);
            updateDiagnoses.Parameters.Add("@IdDiagnose", OleDbType.Integer);
            updateDiagnoses.Parameters[0].Value = NameOfDiagnose2.Text;
            updateDiagnoses.Parameters[1].Value = IdDiagnose2.SelectedItem;
            updateDiagnoses.ExecuteNonQuery();

            IdDiagnose2.Text = "";
            NameOfDiagnose2.Text = "";

            EditDiagnose.Enabled = false;

            this.updateDiagnoses();

            isIdDiagnose2Selected = false;
            isNameOfDiagnose2Selected = false;

            MessageBox.Show("    Диагноз отредактирован!    ");
        }
    }
}

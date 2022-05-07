using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class DoctorsEditing : Form
    {
        FormAdmin formAdmin;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;

        private bool isFioOfDoctor1Selected;
        private bool isSpecialization1Selected;

        private bool isIdDoctor2Selected;
        private bool isFioOfDoctor2Selected;
        private bool isSpecialization2Selected;

        public DoctorsEditing(FormAdmin formAdmin)
        {
            InitializeComponent();

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            this.formAdmin = formAdmin;

            dSet = new DataSet();
            DataTable doctors;
            doctors = dSet.Tables.Add("Doctors");
            doctors.Columns.Add("IdDoctor", typeof(int));
            doctors.Columns.Add("FIO", typeof(string));
            doctors.Columns.Add("Specialization", typeof(string));

            dgDoctors.SetDataBinding(dSet, "Doctors");

            OleDbCommand selectDoctors = new OleDbCommand("SELECT IdDoctor, FIO, Specializations.Name AS Specialization FROM Doctors " +
                                                                "JOIN Specializations ON Doctors.IdSpecialization = Specializations.IdSpecialization", cn);

            selectDoctors.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectDoctors;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Doctors");

            OleDbDataReader reader = selectDoctors.ExecuteReader();
            while (reader.Read())
            {
                IdDoctor1.Items.Add(reader["IdDoctor"]);
                IdDoctor2.Items.Add(reader["IdDoctor"]);
            }
            reader.Close();

            OleDbCommand selectSpecializations = new OleDbCommand("SELECT Name FROM Specializations", cn);
            selectSpecializations.ExecuteNonQuery();

            reader = selectSpecializations.ExecuteReader();
            while (reader.Read())
            {
                Specialization1.Items.Add(reader["Name"]);
                Specialization2.Items.Add(reader["Name"]);
            }
            reader.Close();

            DeleteDoctor.Enabled = false;
            AddDoctor.Enabled = false;
            EditDoctor.Enabled = false;

            isFioOfDoctor1Selected = false;
            isSpecialization1Selected = false;

            isIdDoctor2Selected = false;
            isFioOfDoctor2Selected = false;
            isSpecialization2Selected = false;
        }

        private void DoctorsEditing_Load(object sender, EventArgs e)
        {

        }

        private void updateIdDoctors()
        {
            OleDbCommand selectIdDoctor = new OleDbCommand("SELECT IdDoctor FROM Doctors", cn);
            selectIdDoctor.ExecuteNonQuery();

            OleDbDataReader reader = selectIdDoctor.ExecuteReader();
            IdDoctor1.Items.Clear();
            IdDoctor2.Items.Clear();
            while (reader.Read())
            {
                IdDoctor1.Items.Add(reader["IdDoctor"]);
                IdDoctor2.Items.Add(reader["IdDoctor"]);
            }
            reader.Close();
        }

        private void updateDoctors()
        {
            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Doctors");
        }

        private void IdDoctor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteDoctor.Enabled = true;
        }

        private void DeleteDoctor_Click(object sender, EventArgs e)
        {
            OleDbCommand deleteDoctor = new OleDbCommand("DELETE FROM Doctors WHERE IdDoctor = ?", cn);
            deleteDoctor.Parameters.Add("@IdDoctor", OleDbType.Integer);
            deleteDoctor.Parameters[0].Value = IdDoctor1.SelectedItem;

            deleteDoctor.ExecuteNonQuery();
            IdDoctor1.Text = "";
            DeleteDoctor.Enabled = false;
            updateDoctors();
            updateIdDoctors();
            MessageBox.Show("    Данные врача удалены!    ");
        }

        private void FioOfDoctor1_TextChanged(object sender, EventArgs e)
        {
            isFioOfDoctor1Selected = true;

            if (String.IsNullOrEmpty(FioOfDoctor1.Text))
            {
                isFioOfDoctor1Selected = false;
            }

            AddDoctor.Enabled = isFioOfDoctor1Selected && isSpecialization1Selected;
        }

        private void Specialization1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSpecialization1Selected = true;
            AddDoctor.Enabled = isFioOfDoctor1Selected && isSpecialization1Selected;
        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {
            OleDbCommand insertIntoDoctors = new OleDbCommand("INSERT INTO Doctors (FIO, IdSpecialization) VALUES (?, ?)", cn);
            insertIntoDoctors.Parameters.Add("@FIO", OleDbType.VarChar);
            insertIntoDoctors.Parameters.Add("@IdSpecialization", OleDbType.Integer);
            insertIntoDoctors.Parameters[0].Value = FioOfDoctor1.Text;

            OleDbCommand selectIdSpecialization = new OleDbCommand("SELECT IdSpecialization FROM Specializations " +
                                                                        "WHERE Name = ?", cn);
            selectIdSpecialization.Parameters.Add("@Name", OleDbType.VarChar);
            selectIdSpecialization.Parameters[0].Value = Specialization1.Text;
            selectIdSpecialization.ExecuteNonQuery();

            OleDbDataReader reader = selectIdSpecialization.ExecuteReader();
            reader.Read();
            insertIntoDoctors.Parameters[1].Value = reader["IdSpecialization"];
            reader.Close();

            insertIntoDoctors.ExecuteNonQuery();

            FioOfDoctor1.Text = "";
            Specialization1.Text = "";

            AddDoctor.Enabled = false;

            updateDoctors();

            updateIdDoctors();

            isFioOfDoctor1Selected = false;
            isSpecialization1Selected = false;

            MessageBox.Show("    Данные врача добавлены!    ");
        }

        private void IdDoctor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIdDoctor2Selected = true;
            EditDoctor.Enabled = isIdDoctor2Selected && isFioOfDoctor2Selected && isSpecialization2Selected;
        }

        private void FioOfDoctor2_TextChanged(object sender, EventArgs e)
        {
            isFioOfDoctor2Selected = true;

            if (String.IsNullOrEmpty(FioOfDoctor2.Text))
            {
                isFioOfDoctor2Selected = false;
            }

            EditDoctor.Enabled = isIdDoctor2Selected && isFioOfDoctor2Selected && isSpecialization2Selected;
        }

        private void Specialization2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSpecialization2Selected = true;
            EditDoctor.Enabled = isIdDoctor2Selected && isFioOfDoctor2Selected && isSpecialization2Selected;
        }

        private void EditDoctor_Click(object sender, EventArgs e)
        {
            OleDbCommand updateDoctors = new OleDbCommand("UPDATE Doctors SET FIO = ?, IdSpecialization = ? WHERE IdDoctor = ?", cn);
            updateDoctors.Parameters.Add("@FIO", OleDbType.VarChar);
            updateDoctors.Parameters.Add("@Specialization", OleDbType.Integer);
            updateDoctors.Parameters.Add("@IdDoctor", OleDbType.Integer);
            updateDoctors.Parameters[0].Value = FioOfDoctor2.Text;
            updateDoctors.Parameters[2].Value = IdDoctor2.SelectedItem;

            OleDbCommand selectIdSpecialization = new OleDbCommand("SELECT IdSpecialization FROM Specializations " +
                                                                        "WHERE Name = ?", cn);
            selectIdSpecialization.Parameters.Add("@Name", OleDbType.VarChar);
            selectIdSpecialization.Parameters[0].Value = Specialization2.Text;
            selectIdSpecialization.ExecuteNonQuery();

            OleDbDataReader reader = selectIdSpecialization.ExecuteReader();
            reader.Read();
            updateDoctors.Parameters[1].Value = reader["IdSpecialization"];
            reader.Close();

            updateDoctors.ExecuteNonQuery();

            IdDoctor2.Text = "";
            FioOfDoctor2.Text = "";
            Specialization2.Text = "";

            EditDoctor.Enabled = false;

            this.updateDoctors();

            isIdDoctor2Selected = false;
            isFioOfDoctor2Selected = false;
            isSpecialization2Selected = false;

            MessageBox.Show("    Данные врача отредактированы!    ");
        }

        private void DoctorsEditing_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAdmin.updateFormAdmin();
        }
    }
}

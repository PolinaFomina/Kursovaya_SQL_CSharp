using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class SceduleEditing : Form
    {
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;

        private bool isDataSelected;
        private bool isTimeSelected;

        private bool isIdAppointment2Selected;
        private bool isFioOfPatientSelected;
        private bool isBirthdateSelected;
        private bool isPhoneNumberOfPatientSelected;

        private object IdDoctor;

        public SceduleEditing(String nameOfDoctor)
        {
            InitializeComponent();

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            OleDbCommand selectIdDoctor = new OleDbCommand("SELECT IdDoctor FROM Doctors WHERE FIO = ?", cn);
            selectIdDoctor.Parameters.Add("@FIO", OleDbType.VarChar);
            selectIdDoctor.Parameters[0].Value = nameOfDoctor;
            selectIdDoctor.ExecuteNonQuery();

            OleDbDataReader reader = selectIdDoctor.ExecuteReader();
            reader.Read();
            IdDoctor = reader["IdDoctor"];
            reader.Close();

            NameOfDoctor.Text = nameOfDoctor;

            dSet = new DataSet();
            DataTable schedule;
            schedule = dSet.Tables.Add("Schedule");
            schedule.Columns.Add("IdAppointment", typeof(int));
            schedule.Columns.Add("Date and time", typeof(string));
            schedule.Columns.Add("Patient", typeof(string));
            schedule.Columns.Add("Phone number", typeof(string));

            dgSchedule.SetDataBinding(dSet, "Schedule");

            OleDbCommand selectAppointments = new OleDbCommand("SELECT IdAppointment, DateTime AS [Date and time], FIO AS [Patient], PhoneNumber AS [Phone number] FROM Appointments " +
                                                                    "JOIN Patients ON Appointments.IdPatient = Patients.IdPatient " +
                                                                        "WHERE IdDoctor = ? " +
                                                               "UNION " +
                                                               "SELECT IdAppointment, DateTime, '-', '-' FROM Appointments " +
                                                                    "LEFT JOIN Patients ON Appointments.IdPatient = Patients.IdPatient " +
                                                                        "WHERE IdDoctor = ? AND FIO IS NULL " +
                                                               "ORDER BY DateTime", cn);

            selectAppointments.Parameters.Add("@IdDoctor1", OleDbType.Integer);
            selectAppointments.Parameters.Add("@IdDoctor2", OleDbType.Integer);
            selectAppointments.Parameters[0].Value = IdDoctor;
            selectAppointments.Parameters[1].Value = IdDoctor;
            selectAppointments.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectAppointments;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Schedule");

            reader = selectAppointments.ExecuteReader();
            while (reader.Read())
            {
                IdAppointment1.Items.Add(reader["IdAppointment"]);
                IdAppointment2.Items.Add(reader["IdAppointment"]);
            }
            reader.Close();

            DeleteAppointment.Enabled = false;
            AddAppointment.Enabled = false;
            Birthdate.Enabled = false;
            PhoneNumberOfPatient.Enabled = false;
            EditAppointment.Enabled = false;

            TimeOfAppointment.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 9, 0, 0);

            isDataSelected = false;
            isTimeSelected = false;

            isIdAppointment2Selected = false;
            isFioOfPatientSelected = false;
            isBirthdateSelected = false;
            isPhoneNumberOfPatientSelected = false;
        }

        private void SceduleEditing_Load(object sender, EventArgs e)
        {

        }

        private void updateIdAppointments()
        {
            OleDbCommand selectIdAppointment = new OleDbCommand("SELECT IdAppointment FROM Appointments " +
                                                                    "WHERE IdDoctor = ? ", cn);
            selectIdAppointment.Parameters.Add("@IdDoctor", OleDbType.Integer);
            selectIdAppointment.Parameters[0].Value = IdDoctor;
            selectIdAppointment.ExecuteNonQuery();

            OleDbDataReader reader = selectIdAppointment.ExecuteReader();
            IdAppointment1.Items.Clear();
            IdAppointment2.Items.Clear();
            while (reader.Read())
            {
                IdAppointment1.Items.Add(reader["IdAppointment"]);
                IdAppointment2.Items.Add(reader["IdAppointment"]);
            }
            reader.Close();
        }
        private void updateSchedule()
        {
            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Schedule");
        }

        private DateTime getDateTime(object IdAppointment)
        {
            OleDbCommand selectDateTime = new OleDbCommand("SELECT DateTime FROM Appointments WHERE IdAppointment = ?", cn);
            selectDateTime.Parameters.Add("@IdAppointment", OleDbType.Integer);
            selectDateTime.Parameters[0].Value = IdAppointment;
            selectDateTime.ExecuteNonQuery();

            OleDbDataReader reader = selectDateTime.ExecuteReader();
            reader.Read();
            DateTime dateTime = (DateTime)reader["DateTime"];
            reader.Close();

            return dateTime;
        }

        private void IdAppointment1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteAppointment.Enabled = true;
        }

        private void DeleteAppointment_Click(object sender, EventArgs e)
        {
            OleDbCommand deleteAppointment = new OleDbCommand("DELETE FROM Appointments WHERE IdAppointment = ?", cn);
            deleteAppointment.Parameters.Add("@IdAppointment", OleDbType.Integer);
            deleteAppointment.Parameters[0].Value = IdAppointment1.SelectedItem;

            DateTime dateTime = getDateTime(IdAppointment1.SelectedItem);

            if (dateTime > DateTime.Now)
            {
                deleteAppointment.ExecuteNonQuery();
                IdAppointment1.Text = "";
                DeleteAppointment.Enabled = false;
                updateSchedule();
                updateIdAppointments();
                MessageBox.Show("    Приём удалён!    ");
            }
            else
            {
                MessageBox.Show("    Этот приём не может быть удалён!    ");
            }
        }

        private void DateOfAppointment_ValueChanged(object sender, EventArgs e)
        {
            isDataSelected = true;

            if (DateOfAppointment.Value < DateTime.Now.Date)
            {
                MessageBox.Show("    Некорректная дата!    ");
                isDataSelected = false;
            }

            AddAppointment.Enabled = isDataSelected && isTimeSelected;
        }

        private void TimeOfAppointment_ValueChanged(object sender, EventArgs e)
        {
            isTimeSelected = true;

            int minHour = 9;
            int maxHour = 20;
            if (TimeOfAppointment.Value.Hour < minHour || TimeOfAppointment.Value.Hour > maxHour ||
                (TimeOfAppointment.Value.Hour == maxHour && TimeOfAppointment.Value.Minute != 0 && TimeOfAppointment.Value.Second != 0))
            {
                MessageBox.Show("    Некорректное время!    ");
                isTimeSelected = false;
            }

            AddAppointment.Enabled = isDataSelected && isTimeSelected;
        }

        private void AddAppointment_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(DateOfAppointment.Value.Year, DateOfAppointment.Value.Month, DateOfAppointment.Value.Day,
                TimeOfAppointment.Value.Hour, TimeOfAppointment.Value.Minute, TimeOfAppointment.Value.Second);

            OleDbCommand insertIntoAppointments = new OleDbCommand("INSERT INTO Appointments (IdDoctor, DateTime) VALUES (?, ?)", cn);
            insertIntoAppointments.Parameters.Add("@IdDoctor", OleDbType.Integer);
            insertIntoAppointments.Parameters.AddWithValue("@DateTime", dateTime);
            insertIntoAppointments.Parameters[0].Value = IdDoctor;
            insertIntoAppointments.ExecuteNonQuery();

            DateOfAppointment.Value = DateTime.Now.Date;
            TimeOfAppointment.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 9, 0, 0);

            AddAppointment.Enabled = false;

            updateSchedule();

            updateIdAppointments();

            isDataSelected = false;
            isTimeSelected = false;

            MessageBox.Show("    Приём добавлен!    ");
        }

        private bool getAddAppointmentEnabled(bool BirthdateEnabled)
        {
            if (BirthdateEnabled)
            {
                return isIdAppointment2Selected && isFioOfPatientSelected && isBirthdateSelected && isPhoneNumberOfPatientSelected;
            }

            return isIdAppointment2Selected && isFioOfPatientSelected;
        }

        private object getIdPatient(String FIO)
        {
            OleDbCommand selectIdPatient = new OleDbCommand("SELECT IdPatient FROM Patients WHERE FIO = ?", cn);
            selectIdPatient.Parameters.Add("@FIO", OleDbType.VarChar);
            selectIdPatient.Parameters[0].Value = FIO;
            selectIdPatient.ExecuteNonQuery();

            OleDbDataReader reader = selectIdPatient.ExecuteReader();
            if (reader.Read())
            {
                object id = reader["IdPatient"];
                reader.Close();
                return id;
            }

            return null;
        }

        private void IdAppointment2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dateTime = getDateTime(IdAppointment2.SelectedItem);

            if (dateTime > DateTime.Now)
            {
                isIdAppointment2Selected = true;
                EditAppointment.Enabled = getAddAppointmentEnabled(Birthdate.Enabled);
            }
            else
            {
                MessageBox.Show("    Этот приём не может быть отредактирован!    ");
            }
        }

        private void FioOfPatient_TextChanged(object sender, EventArgs e)
        {
            isFioOfPatientSelected = true;

            Birthdate.Enabled = true;
            PhoneNumberOfPatient.Enabled = true;
            if (String.IsNullOrEmpty(FioOfPatient.Text))
            {
                isFioOfPatientSelected = false;
            }
            if (getIdPatient(FioOfPatient.Text) != null || FioOfPatient.Text == "-")
            {
                Birthdate.Enabled = false;
                PhoneNumberOfPatient.Enabled = false;
            }

            EditAppointment.Enabled = getAddAppointmentEnabled(Birthdate.Enabled);
        }

        private void Birthdate_ValueChanged(object sender, EventArgs e)
        {
            isBirthdateSelected = false;

            if (Birthdate.Value > DateTime.Now.Date)
            {
                MessageBox.Show("    Некорректная дата!    ");
            }
            else
            {
                isBirthdateSelected = true;
            }

            EditAppointment.Enabled = isIdAppointment2Selected && isFioOfPatientSelected && isBirthdateSelected && isPhoneNumberOfPatientSelected;
        }

        private void PhoneNumberOfPatient_TextChanged(object sender, EventArgs e)
        {
            isPhoneNumberOfPatientSelected = false;

            if (PhoneNumberOfPatient.MaskCompleted)
            {
                isPhoneNumberOfPatientSelected = true;
            }

            EditAppointment.Enabled = isIdAppointment2Selected && isFioOfPatientSelected && isBirthdateSelected && isPhoneNumberOfPatientSelected;
        }

        private void EditAppointment_Click(object sender, EventArgs e)
        {
            OleDbCommand updateAppointments = new OleDbCommand("UPDATE Appointments SET IdPatient = ? WHERE IdAppointment = ?", cn);
            updateAppointments.Parameters.Add("@IdPatient", OleDbType.Integer);
            updateAppointments.Parameters.Add("@IdAppointment", OleDbType.Integer);
            updateAppointments.Parameters[1].Value = IdAppointment2.SelectedItem;

            if(FioOfPatient.Text == "-")
            {
                updateAppointments.Parameters[0].Value = null;
            }
            else if (getIdPatient(FioOfPatient.Text) != null)
            {
                updateAppointments.Parameters[0].Value = getIdPatient(FioOfPatient.Text);
            }
            else
            {
                OleDbCommand insertIntoPatients = new OleDbCommand("INSERT INTO Patients (FIO, Birthdate, PhoneNumber) VALUES (?, ?, ?)", cn);
                insertIntoPatients.Parameters.Add("@FIO", OleDbType.VarChar);
                insertIntoPatients.Parameters.Add("@Birthdate", OleDbType.DBDate);
                insertIntoPatients.Parameters.Add("@PhoneNumber", OleDbType.VarChar);
                insertIntoPatients.Parameters[0].Value = FioOfPatient.Text;
                insertIntoPatients.Parameters[1].Value = Birthdate.Value;
                insertIntoPatients.Parameters[2].Value = PhoneNumberOfPatient.Text;
                insertIntoPatients.ExecuteNonQuery();

                updateAppointments.Parameters[0].Value = getIdPatient(FioOfPatient.Text);
            }

            updateAppointments.ExecuteNonQuery();

            IdAppointment2.Text = "";
            FioOfPatient.Text = "";
            Birthdate.Value = DateTime.Now.Date;
            PhoneNumberOfPatient.Text = "";

            Birthdate.Enabled = false;
            PhoneNumberOfPatient.Enabled = false;
            EditAppointment.Enabled = false;

            updateSchedule();

            isIdAppointment2Selected = false;
            isFioOfPatientSelected = false;
            isBirthdateSelected = false;
            isPhoneNumberOfPatientSelected = false;

            MessageBox.Show("    Приём отредактирован!    ");
        }
    }
}

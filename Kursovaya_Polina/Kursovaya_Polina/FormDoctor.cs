using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class FormDoctor : Form
    {
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;

        private bool isDateSelected;

        private bool isDateOfAppointmentSelected;
        private bool isTimeOfAppointmentSelected;
        private bool areComplaintsSelected;
        private bool areDiagnosesSelected;
        private bool areRecommendationsSelected;

        public FormDoctor(String FioOfDoctor)
        {
            InitializeComponent();

            this.FioOfDoctor.Text = FioOfDoctor;

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable schedule;
            schedule = dSet.Tables.Add("Schedule");
            schedule.Columns.Add("Date and time", typeof(string));
            schedule.Columns.Add("Patient", typeof(string));

            dgSchedule.SetDataBinding(dSet, "Schedule");

            Date.Text = "";

            ShowSchedule.Enabled = true;

            isDateSelected = false;


            DataTable medicaments;
            medicaments = dSet.Tables.Add("Medicaments");
            medicaments.Columns.Add("Name", typeof(string));
            medicaments.Columns.Add("DosageForm", typeof(string));
            medicaments.Columns.Add("Price", typeof(int));
            medicaments.Columns.Add("Quantity", typeof(int));

            dgMedicaments.SetDataBinding(dSet, "Medicaments");

            OleDbCommand selectDosageForms = new OleDbCommand("SELECT Name FROM DosageForms", cn);
            selectDosageForms.ExecuteNonQuery();

            OleDbDataReader reader = selectDosageForms.ExecuteReader();
            while (reader.Read())
            {
                DosageForms.Items.Add(reader["Name"]);
            }
            reader.Close();

            ShowMedicaments.Enabled = true;

            TimeOfAppointment.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 9, 0, 0);

            OleDbCommand selectDiagnoses = new OleDbCommand("SELECT Name FROM Diagnoses", cn);
            selectDiagnoses.ExecuteNonQuery();

            reader = selectDiagnoses.ExecuteReader();
            while (reader.Read())
            {
                Diagnoses.Items.Add(reader["Name"]);
            }
            reader.Close();

            OleDbCommand selectMedicaments = new OleDbCommand("SELECT Medicaments.Name AS Name1, DosageForms.Name AS Name2 FROM Medicaments " +
                                                                    "JOIN DosageForms ON Medicaments.DosageForm = DosageForms.IdForm", cn);
            selectMedicaments.ExecuteNonQuery();

            reader = selectMedicaments.ExecuteReader();
            while (reader.Read())
            {
                Medicaments.Items.Add(reader["Name1"] + " " + reader["Name2"]);
            }
            reader.Close();

            SaveInfoAboutAppointment.Enabled = false;

            isDateOfAppointmentSelected = false;
            isTimeOfAppointmentSelected = false;
            areComplaintsSelected = false;
            areDiagnosesSelected = false;
            areRecommendationsSelected = false;
    }

        private void FormDoctor_Load(object sender, EventArgs e)
        {

        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            isDateSelected = true;
        }

        private void ShowSchedule_Click(object sender, EventArgs e)
        {
            dSet.Tables[0].Clear();

            OleDbCommand selectIdDoctor = new OleDbCommand("SELECT IdDoctor FROM Doctors WHERE FIO = ?", cn);
            selectIdDoctor.Parameters.Add("@FIO", OleDbType.VarChar);
            selectIdDoctor.Parameters[0].Value = FioOfDoctor.Text;
            selectIdDoctor.ExecuteNonQuery();

            OleDbDataReader reader = selectIdDoctor.ExecuteReader();
            reader.Read();
            object IdDoctor = reader["IdDoctor"];
            reader.Close();

            OleDbCommand selectAppointments;

            if (!isDateSelected)
            {
                selectAppointments = new OleDbCommand("SELECT DateTime AS [Date and time], FIO AS [Patient] FROM Appointments " +
                                                        "JOIN Patients ON Appointments.IdPatient = Patients.IdPatient " +
                                                            "WHERE IdDoctor = ? " +
                                                   "UNION " +
                                                   "SELECT DateTime, '-' FROM Appointments " +
                                                        "LEFT JOIN Patients ON Appointments.IdPatient = Patients.IdPatient " +
                                                            "WHERE IdDoctor = ? AND FIO IS NULL", cn);
                selectAppointments.Parameters.Add("@IdDoctor1", OleDbType.Integer);
                selectAppointments.Parameters.Add("@IdDoctor2", OleDbType.Integer);
                selectAppointments.Parameters[0].Value = IdDoctor;
                selectAppointments.Parameters[1].Value = IdDoctor;
            }
            else
            {
                DateTime dateTime = new DateTime(Date.Value.Year, Date.Value.Month, Date.Value.Day);

                selectAppointments = new OleDbCommand("SELECT DateTime AS [Date and time], FIO AS [Patient] FROM Appointments " +
                                                        "JOIN Patients ON Appointments.IdPatient = Patients.IdPatient " +
                                                            "WHERE IdDoctor = ? AND CONVERT(Date, DateTime) = ? " +
                                                      "UNION " +
                                                      "SELECT DateTime, '-' FROM Appointments " +
                                                        "LEFT JOIN Patients ON Appointments.IdPatient = Patients.IdPatient " +
                                                            "WHERE IdDoctor = ? AND FIO IS NULL AND CONVERT(Date, DateTime) = ?", cn);
                selectAppointments.Parameters.Add("@IdDoctor1", OleDbType.Integer);
                selectAppointments.Parameters.AddWithValue("@DateTime1", dateTime);
                selectAppointments.Parameters.Add("@IdDoctor2", OleDbType.Integer);
                selectAppointments.Parameters.AddWithValue("@DateTime2", dateTime);
                selectAppointments.Parameters[0].Value = IdDoctor;
                selectAppointments.Parameters[2].Value = IdDoctor;
            }

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectAppointments;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Schedule");
        }

        private void ShowMedicaments_Click(object sender, EventArgs e)
        {
            OleDbCommand selectMedicaments;
            dSet.Tables[1].Clear();

            if (String.IsNullOrEmpty(DosageForms.Text))
            {
                selectMedicaments = new OleDbCommand("SELECT Medicaments.Name AS Name, DosageForms.Name AS DosageForm, Price, Quantity FROM Medicaments " +
                                                        "JOIN Suppliers ON Medicaments.IdSupplier = Suppliers.IdSupplier " +
                                                            "JOIN DosageForms ON Medicaments.DosageForm = DosageForms.IdForm", cn);
            }
            else
            {
                selectMedicaments = new OleDbCommand("SELECT Medicaments.Name AS Name, DosageForms.Name AS DosageForm, Price, Quantity FROM Medicaments " +
                                                        "JOIN Suppliers ON Medicaments.IdSupplier = Suppliers.IdSupplier " +
                                                            "JOIN DosageForms ON Medicaments.DosageForm = DosageForms.IdForm " +
                                                                "WHERE DosageForm = ?", cn);
                selectMedicaments.Parameters.Add("@DosageForm", OleDbType.Integer);

                OleDbCommand selectIdForm = new OleDbCommand("SELECT IdForm FROM DosageForms " +
                                                                "WHERE Name = ?", cn);
                selectIdForm.Parameters.Add("@Name", OleDbType.VarChar);
                selectIdForm.Parameters[0].Value = DosageForms.Text;

                OleDbDataReader reader = selectIdForm.ExecuteReader();
                reader.Read();
                selectMedicaments.Parameters[0].Value = reader["IdForm"];
                reader.Close();
            }

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectMedicaments;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Medicaments");

            DosageForms.Text = "";
        }

        private void DateOfAppointment_ValueChanged(object sender, EventArgs e)
        {
            FIO.Text = "";

            isDateOfAppointmentSelected = true;

            if (DateOfAppointment.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("    Некорректная дата!    ");
                isDateOfAppointmentSelected = false;
            }

            if(isDateOfAppointmentSelected && isTimeOfAppointmentSelected)
            {
                OleDbCommand selectIdDoctor = new OleDbCommand("SELECT IdDoctor FROM Doctors " +
                                                                    "WHERE FIO = ?", cn);
                selectIdDoctor.Parameters.Add("@FIO", OleDbType.VarChar);
                selectIdDoctor.Parameters[0].Value = FioOfDoctor.Text;
                selectIdDoctor.ExecuteNonQuery();

                OleDbDataReader reader = selectIdDoctor.ExecuteReader();
                reader.Read();
                object IdDoctor = reader["IdDoctor"];
                reader.Close();

                DateTime dateTime = new DateTime(DateOfAppointment.Value.Year, DateOfAppointment.Value.Month, DateOfAppointment.Value.Day,
                    TimeOfAppointment.Value.Hour, TimeOfAppointment.Value.Minute, TimeOfAppointment.Value.Second);

                OleDbCommand selectFIO = new OleDbCommand("SELECT FIO FROM Patients " +
                                                              "RIGHT JOIN Appointments ON Patients.IdPatient = Appointments.IdPatient " +
                                                                   "WHERE DateTime = ? AND IdDoctor = ?", cn);
                selectFIO.Parameters.AddWithValue("@DateTime", dateTime);
                selectFIO.Parameters.Add("@IdDoctor", OleDbType.Integer);
                selectFIO.Parameters[1].Value = IdDoctor;
                selectFIO.ExecuteNonQuery();

                reader = selectFIO.ExecuteReader();
                if(reader.Read())
                {
                    FIO.Text = reader["FIO"].ToString();
                }
                reader.Close();
            }

            SaveInfoAboutAppointment.Enabled = isDateOfAppointmentSelected && isTimeOfAppointmentSelected
                && areComplaintsSelected && areDiagnosesSelected && areRecommendationsSelected;
        }

        private void TimeOfAppointment_ValueChanged(object sender, EventArgs e)
        {
            FIO.Text = "";

            isTimeOfAppointmentSelected = true;

            int minHour = 9;
            int maxHour = 20;
            if (TimeOfAppointment.Value.Hour < minHour || TimeOfAppointment.Value.Hour > maxHour ||
                (TimeOfAppointment.Value.Hour == maxHour && TimeOfAppointment.Value.Minute != 0 && TimeOfAppointment.Value.Second != 0))
            {
                MessageBox.Show("    Некорректное время!    ");
                isTimeOfAppointmentSelected = false;
            }

            if (isDateOfAppointmentSelected && isTimeOfAppointmentSelected)
            {
                OleDbCommand selectIdDoctor = new OleDbCommand("SELECT IdDoctor FROM Doctors " +
                                                    "WHERE FIO = ?", cn);
                selectIdDoctor.Parameters.Add("@FIO", OleDbType.VarChar);
                selectIdDoctor.Parameters[0].Value = FioOfDoctor.Text;
                selectIdDoctor.ExecuteNonQuery();

                OleDbDataReader reader = selectIdDoctor.ExecuteReader();
                reader.Read();
                object IdDoctor = reader["IdDoctor"];
                reader.Close();

                DateTime dateTime = new DateTime(DateOfAppointment.Value.Year, DateOfAppointment.Value.Month, DateOfAppointment.Value.Day,
                    TimeOfAppointment.Value.Hour, TimeOfAppointment.Value.Minute, TimeOfAppointment.Value.Second);

                OleDbCommand selectFIO = new OleDbCommand("SELECT FIO FROM Patients " +
                                                              "RIGHT JOIN Appointments ON Patients.IdPatient = Appointments.IdPatient " +
                                                                   "WHERE DateTime = ? AND IdDoctor = ?", cn);
                selectFIO.Parameters.AddWithValue("@DateTime", dateTime);
                selectFIO.Parameters.Add("@IdDoctor", OleDbType.Integer);
                selectFIO.Parameters[1].Value = IdDoctor;
                selectFIO.ExecuteNonQuery();

                reader = selectFIO.ExecuteReader();
                if(reader.Read())
                {
                    FIO.Text = reader["FIO"].ToString();
                }
                reader.Close();
            }

            SaveInfoAboutAppointment.Enabled = isDateOfAppointmentSelected && isTimeOfAppointmentSelected
                && areComplaintsSelected && areDiagnosesSelected && areRecommendationsSelected;
        }

        private void Complaints_TextChanged(object sender, EventArgs e)
        {
            areComplaintsSelected = true;

            if (String.IsNullOrEmpty(Complaints.Text))
            {
                areComplaintsSelected = false;
            }

            SaveInfoAboutAppointment.Enabled = isDateOfAppointmentSelected && isTimeOfAppointmentSelected
                && areComplaintsSelected && areDiagnosesSelected && areRecommendationsSelected;
        }

        private void Diagnoses_SelectedIndexChanged(object sender, EventArgs e)
        {
            areDiagnosesSelected = true;
            if (Diagnoses.CheckedItems.Count == 0)
            {
                areDiagnosesSelected = false;
            }

            SaveInfoAboutAppointment.Enabled = isDateOfAppointmentSelected && isTimeOfAppointmentSelected
                && areComplaintsSelected && areDiagnosesSelected && areRecommendationsSelected;
        }

        private void Recommendations_TextChanged(object sender, EventArgs e)
        {
            areRecommendationsSelected = true;

            if (String.IsNullOrEmpty(Recommendations.Text))
            {
                areRecommendationsSelected = false;
            }

            SaveInfoAboutAppointment.Enabled = isDateOfAppointmentSelected && isTimeOfAppointmentSelected
                && areComplaintsSelected && areDiagnosesSelected && areRecommendationsSelected;
        }

        private void SaveInfoAboutAppointment_Click(object sender, EventArgs e)
        {
            OleDbCommand selectIdPatient = new OleDbCommand("SELECT IdPatient FROM Patients " +
                                                                "WHERE FIO = ?", cn);
            selectIdPatient.Parameters.Add("@FIO", OleDbType.VarChar);
            selectIdPatient.Parameters[0].Value = FIO.Text;
            selectIdPatient.ExecuteNonQuery();

            OleDbDataReader reader = selectIdPatient.ExecuteReader();
            reader.Read();
            object IdPatient = reader["IdPatient"];

            DateTime dateTime = new DateTime(DateOfAppointment.Value.Year, DateOfAppointment.Value.Month, DateOfAppointment.Value.Day,
                TimeOfAppointment.Value.Hour, TimeOfAppointment.Value.Minute, TimeOfAppointment.Value.Second);

            OleDbCommand selectIdAppointment = new OleDbCommand("SELECT IdAppointment FROM Appointments " +
                                                                    "WHERE DateTime = ? AND IdPatient = ?", cn);
            selectIdAppointment.Parameters.AddWithValue("@DateTime", dateTime);
            selectIdAppointment.Parameters.Add("@IdPatient", OleDbType.Integer);
            selectIdAppointment.Parameters[1].Value = IdPatient;

            reader = selectIdAppointment.ExecuteReader();
            reader.Read();
            object IdAppointment = reader["IdAppointment"];

            OleDbCommand updateAppointments = new OleDbCommand("UPDATE Appointments SET Complaints = ?, Recommendations = ? " +
                                                                    "WHERE IdAppointment = ?", cn);
            updateAppointments.Parameters.Add("@Complaints", OleDbType.VarChar);
            updateAppointments.Parameters.Add("@Recommendations", OleDbType.VarChar);
            updateAppointments.Parameters.Add("@IdAppointment", OleDbType.Integer);
            updateAppointments.Parameters[0].Value = Complaints.Text;
            updateAppointments.Parameters[1].Value = Recommendations.Text;
            updateAppointments.Parameters[2].Value = IdAppointment;

            updateAppointments.ExecuteNonQuery();

            foreach (object diagnose in Diagnoses.CheckedItems)
            {
                OleDbCommand selectIdDiagnose = new OleDbCommand("SELECT IdDiagnose FROM Diagnoses WHERE Name = ?", cn);
                selectIdDiagnose.Parameters.Add("@Name", OleDbType.VarChar);
                selectIdDiagnose.Parameters[0].Value = diagnose.ToString();
                selectIdDiagnose.ExecuteNonQuery();

                OleDbCommand insertIntoAppointmentsDiagnoses = new OleDbCommand("INSERT INTO AppointmentsDiagnoses (IdAppointment, IdDiagnose) VALUES (?, ?)", cn);
                insertIntoAppointmentsDiagnoses.Parameters.Add("@IdAppointment", OleDbType.Integer);
                insertIntoAppointmentsDiagnoses.Parameters.Add("@IdDiagnose", OleDbType.Integer);
                insertIntoAppointmentsDiagnoses.Parameters[0].Value = IdAppointment;

                reader = selectIdDiagnose.ExecuteReader();
                reader.Read();
                insertIntoAppointmentsDiagnoses.Parameters[1].Value = reader["IdDiagnose"];
                reader.Close();

                insertIntoAppointmentsDiagnoses.ExecuteNonQuery();
            }

            foreach (object medicament in Medicaments.CheckedItems)
            {
                OleDbCommand selectIdForm = new OleDbCommand("SELECT IdForm FROM DosageForms WHERE Name = ?", cn);
                selectIdForm.Parameters.Add("@Name", OleDbType.VarChar);
                selectIdForm.Parameters[0].Value = medicament.ToString().Split(' ')[1];
                selectIdForm.ExecuteNonQuery();

                reader = selectIdForm.ExecuteReader();
                reader.Read();
                object IdForm = reader["IdForm"];
                reader.Close();

                OleDbCommand selectIdMedicament = new OleDbCommand("SELECT IdMedicament FROM Medicaments WHERE Name = ? AND DosageForm = ?", cn);
                selectIdMedicament.Parameters.Add("@Name", OleDbType.VarChar);
                selectIdMedicament.Parameters.Add("@DosageForm", OleDbType.Integer);
                selectIdMedicament.Parameters[0].Value = medicament.ToString().Split(' ')[0];
                selectIdMedicament.Parameters[1].Value = IdForm;
                selectIdMedicament.ExecuteNonQuery();

                reader = selectIdMedicament.ExecuteReader();
                reader.Read();
                object IdMedicament = reader["IdMedicament"];
                reader.Close();

                OleDbCommand insertIntoAppointmentsMedicaments = new OleDbCommand("INSERT INTO AppointmentsMedicaments (IdAppointment, IdMedicament) VALUES (?, ?)", cn);
                insertIntoAppointmentsMedicaments.Parameters.Add("@IdAppointment", OleDbType.Integer);
                insertIntoAppointmentsMedicaments.Parameters.Add("@IdMedicament", OleDbType.Integer);
                insertIntoAppointmentsMedicaments.Parameters[0].Value = IdAppointment;
                insertIntoAppointmentsMedicaments.Parameters[1].Value = IdMedicament;

                insertIntoAppointmentsMedicaments.ExecuteNonQuery();
            }

            DateOfAppointment.Value = DateTime.Now.Date;
            TimeOfAppointment.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 9, 0, 0);
            FIO.Text = "";
            Complaints.Text = "";
            for (int i = 0; i < Diagnoses.Items.Count; i++)
            {
                Diagnoses.SetItemChecked(i, false);
            }
            for (int i = 0; i < Medicaments.Items.Count; i++)
            {
                Medicaments.SetItemChecked(i, false);
            }
            Recommendations.Text = "";

            SaveInfoAboutAppointment.Enabled = false;

            isDateOfAppointmentSelected = false;
            isTimeOfAppointmentSelected = false;
            areComplaintsSelected = false;
            areDiagnosesSelected = false;
            areRecommendationsSelected = false;

            MessageBox.Show("    Информация сохранена!    ");
        }
    }
}

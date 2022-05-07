using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class FormAdmin : Form
    {
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;

        public FormAdmin(String FioOfAdmin)
        {
            InitializeComponent();

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            FioOfAdministrator.Text = FioOfAdmin;

            dSet = new DataSet();
            DataTable schedule;
            schedule = dSet.Tables.Add("Schedule");
            schedule.Columns.Add("DateTime", typeof(string));
            schedule.Columns.Add("Patient", typeof(string));
            schedule.Columns.Add("Phone number", typeof(string));

            dgSchedule.SetDataBinding(dSet, "Schedule");

            OleDbCommand selectName = new OleDbCommand("SELECT Name FROM Specializations", cn);
            selectName.ExecuteNonQuery();

            OleDbDataReader reader = selectName.ExecuteReader();
            while (reader.Read())
            {
                Specializations1.Items.Add(reader["Name"]);
                Specializations2.Items.Add(reader["Name"]);
            }
            reader.Close();

            OleDbCommand selectFIO = new OleDbCommand("SELECT FIO FROM Doctors", cn);
            selectFIO.ExecuteNonQuery();

            reader = selectFIO.ExecuteReader();
            while (reader.Read())
            {
                Doctors1.Items.Add(reader["FIO"]);
                Doctors2.Items.Add(reader["FIO"]);
            }
            reader.Close();

            ShowSchedule.Enabled = false;
            EditSchedule.Enabled = false;


            DataTable services;
            services = dSet.Tables.Add("Services");
            services.Columns.Add("Name", typeof(string));
            services.Columns.Add("Price", typeof(int));

            dgServices.SetDataBinding(dSet, "Services");

            ShowServices.Enabled = false;
            EditServices.Enabled = false;


            DataTable medicaments;
            medicaments = dSet.Tables.Add("Medicaments");
            medicaments.Columns.Add("Name", typeof(string));
            medicaments.Columns.Add("DosageForm", typeof(string));
            medicaments.Columns.Add("Price", typeof(int));
            medicaments.Columns.Add("Quantity", typeof(int));
            medicaments.Columns.Add("Supplier", typeof(string));

            dgMedicaments.SetDataBinding(dSet, "Medicaments");

            OleDbCommand selectDosageForms = new OleDbCommand("SELECT Name FROM DosageForms", cn);
            selectDosageForms.ExecuteNonQuery();

            reader = selectDosageForms.ExecuteReader();
            while (reader.Read())
            {
                DosageForms.Items.Add(reader["Name"]);
            }
            reader.Close();

            ShowMedicaments.Enabled = true;
            EditMedicaments.Enabled = false;


            DataTable doctors;
            doctors = dSet.Tables.Add("Doctors");
            doctors.Columns.Add("FIO", typeof(string));
            doctors.Columns.Add("Specialization", typeof(string));

            dgDoctors.SetDataBinding(dSet, "Doctors");

            ShowDoctors.Enabled = true;
            EditDoctors.Enabled = false;


            DataTable specializations;
            specializations = dSet.Tables.Add("Specializations");
            specializations.Columns.Add("Name", typeof(string));

            dgSpecializations.SetDataBinding(dSet, "Specializations");

            ShowSpecializations.Enabled = true;
            EditSpecializations.Enabled = false;


            DataTable administrators;
            administrators = dSet.Tables.Add("Administrators");
            administrators.Columns.Add("FIO", typeof(string));

            dgAdministrators.SetDataBinding(dSet, "Administrators");

            ShowAdministrators.Enabled = true;
            EditAdministrators.Enabled = false;


            DataTable users;
            users = dSet.Tables.Add("Users");
            users.Columns.Add("FIO", typeof(string));
            users.Columns.Add("Login", typeof(string));
            users.Columns.Add("Password", typeof(string));
            users.Columns.Add("TypeUser", typeof(string));

            dgUsers.SetDataBinding(dSet, "Users");

            ShowUsers.Enabled = false;
            EditUsers.Enabled = false;


            DataTable diagnoses;
            diagnoses = dSet.Tables.Add("Diagnoses");
            diagnoses.Columns.Add("Name", typeof(string));

            dgDiagnoses.SetDataBinding(dSet, "Diagnoses");

            ShowDiagnoses.Enabled = true;
            EditDiagnoses.Enabled = false;

            DataTable suppliers;
            suppliers = dSet.Tables.Add("Suppliers");
            suppliers.Columns.Add("Name", typeof(string));

            dgSuppliers.SetDataBinding(dSet, "Suppliers");

            ShowSuppliers.Enabled = true;
            EditSuppliers.Enabled = false;
        }

        public void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        public void updateFormAdmin()
        {
            OleDbCommand selectName = new OleDbCommand("SELECT Name FROM Specializations", cn);
            selectName.ExecuteNonQuery();

            Specializations1.Items.Clear();
            Specializations2.Items.Clear();
            OleDbDataReader reader = selectName.ExecuteReader();
            while (reader.Read())
            {
                Specializations1.Items.Add(reader["Name"]);
                Specializations2.Items.Add(reader["Name"]);
            }
            reader.Close();


            OleDbCommand selectFIO = new OleDbCommand("SELECT FIO FROM Doctors", cn);
            selectFIO.ExecuteNonQuery();

            Doctors1.Items.Clear();
            Doctors2.Items.Clear();
            reader = selectFIO.ExecuteReader();
            while (reader.Read())
            {
                Doctors1.Items.Add(reader["FIO"]);
                Doctors2.Items.Add(reader["FIO"]);
            }
            reader.Close();
        }

        private object getIdSpecialization(String nameOfSpecialization)
        {
            OleDbCommand selectIdSpecialization = new OleDbCommand("SELECT IdSpecialization FROM Specializations WHERE Name = ?", cn);
            selectIdSpecialization.Parameters.Add("@Name", OleDbType.VarChar);
            selectIdSpecialization.Parameters[0].Value = nameOfSpecialization;
            selectIdSpecialization.ExecuteNonQuery();

            OleDbDataReader reader = selectIdSpecialization.ExecuteReader();
            reader.Read();
            object id = reader["IdSpecialization"];
            reader.Close();

            return id;
        }

        private void Specializations1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSchedule.Enabled = false;
            EditSchedule.Enabled = false;

            Doctors1.Text = "";

            Doctors1.Items.Clear();

            OleDbCommand selectFIO = new OleDbCommand("SELECT FIO FROM Doctors WHERE IdSpecialization = ?", cn);
            selectFIO.Parameters.Add("@Specialization", OleDbType.Integer);
            selectFIO.Parameters[0].Value = getIdSpecialization(Specializations1.Text);
            selectFIO.ExecuteNonQuery();

            OleDbDataReader reader = selectFIO.ExecuteReader();
            while (reader.Read())
                Doctors1.Items.Add(reader["FIO"]);
            reader.Close();
        }

        private void Doctors1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSchedule.Enabled = true;
            EditSchedule.Enabled = false;
        }

        private void ShowSchedule_Click(object sender, EventArgs e)
        {
            dSet.Tables[0].Clear();

            OleDbCommand selectIdDoctor = new OleDbCommand("SELECT IdDoctor FROM Doctors WHERE FIO = ?", cn);
            selectIdDoctor.Parameters.Add("@FIO", OleDbType.VarChar);
            selectIdDoctor.Parameters[0].Value = Doctors1.SelectedItem;
            selectIdDoctor.ExecuteNonQuery();

            OleDbCommand selectAppointments = new OleDbCommand("SELECT DateTime, FIO AS [Patient], PhoneNumber AS [Phone number] FROM Appointments " +
                                                                    "JOIN Patients ON Appointments.IdPatient = Patients.IdPatient " +
                                                                        "WHERE IdDoctor = ? " +
                                                               "UNION " +
                                                               "SELECT DateTime, '-', '-' FROM Appointments " +
                                                                    "LEFT JOIN Patients ON Appointments.IdPatient = Patients.IdPatient " +
                                                                        "WHERE IdDoctor = ? AND FIO IS NULL", cn);
            selectAppointments.Parameters.Add("@IdDoctor1", OleDbType.Integer);
            selectAppointments.Parameters.Add("@IdDoctor2", OleDbType.Integer);

            OleDbDataReader reader = selectIdDoctor.ExecuteReader();
            reader.Read();
            selectAppointments.Parameters[0].Value = reader["IdDoctor"];
            selectAppointments.Parameters[1].Value = reader["IdDoctor"];
            reader.Close();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectAppointments;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Schedule");

            EditSchedule.Enabled = true;
        }

        private void EditSchedule_Click(object sender, EventArgs e)
        {
            SceduleEditing sceduleEditing = new SceduleEditing(Doctors1.Text);
            sceduleEditing.ShowDialog();
        }

        private void Specializations2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowServices.Enabled = false;
            EditServices.Enabled = false;

            Doctors2.Text = "";

            Doctors2.Items.Clear();

            OleDbCommand selectFIO = new OleDbCommand("SELECT FIO FROM Doctors WHERE IdSpecialization = ?", cn);
            selectFIO.Parameters.Add("@Specialization", OleDbType.Integer);
            selectFIO.Parameters[0].Value = getIdSpecialization(Specializations2.Text);

            selectFIO.ExecuteNonQuery();

            OleDbDataReader reader = selectFIO.ExecuteReader();
            while (reader.Read())
                Doctors2.Items.Add(reader["FIO"]);
            reader.Close();

            ShowServices.Enabled = true;
        }

        private void Doctors2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowServices.Enabled = true;
            EditServices.Enabled = false;
        }

        private void ShowServices_Click(object sender, EventArgs e)
        {
            dSet.Tables[1].Clear();

            OleDbCommand selectServices;

            if (!String.IsNullOrEmpty(Specializations2.Text))
            {
                object IdSpecialization = getIdSpecialization(Specializations2.Text);

                if (String.IsNullOrEmpty(Doctors2.Text))
                {
                    selectServices = new OleDbCommand("SELECT DISTINCT Name, Price FROM Services " +
                                                        "JOIN ServicesDoctors ON Services.IdService = ServicesDoctors.IdService " +
                                                            "JOIN Doctors ON ServicesDoctors.IdDoctor = Doctors.IdDoctor " +
                                                                "WHERE IdSpecialization = ?", cn);
                    selectServices.Parameters.Add("@IdSpecialization", OleDbType.Integer);
                }
                else
                {
                    selectServices = new OleDbCommand("SELECT DISTINCT Name, Price FROM Services " +
                                                        "JOIN ServicesDoctors ON Services.IdService = ServicesDoctors.IdService " +
                                                            "JOIN Doctors ON ServicesDoctors.IdDoctor = Doctors.IdDoctor " +
                                                                "WHERE IdSpecialization = ? AND FIO = ?", cn);
                    selectServices.Parameters.Add("@IdSpecialization", OleDbType.Integer);
                    selectServices.Parameters.Add("@FIO", OleDbType.VarChar);
                    selectServices.Parameters[1].Value = Doctors2.Text;
                }

                selectServices.Parameters[0].Value = IdSpecialization;
            }
            else
            {
                selectServices = new OleDbCommand("SELECT DISTINCT Name, Price FROM Services " +
                                                    "JOIN ServicesDoctors ON Services.IdService = ServicesDoctors.IdService " +
                                                       "JOIN Doctors ON ServicesDoctors.IdDoctor = Doctors.IdDoctor " +
                                                           "WHERE FIO = ?", cn);
                selectServices.Parameters.Add("@FIO", OleDbType.VarChar);
                selectServices.Parameters[0].Value = Doctors2.Text;
            }

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectServices;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Services");

            EditServices.Enabled = true;
        }

        private void EditServices_Click(object sender, EventArgs e)
        {
            ServicesEditing servicesEditing = new ServicesEditing(Specializations2.Text, Doctors2.Text);
            servicesEditing.ShowDialog();
        }

        private void ShowMedicaments_Click(object sender, EventArgs e)
        {
            OleDbCommand selectMedicaments;
            dSet.Tables[2].Clear();

            if (String.IsNullOrEmpty(DosageForms.Text))
            {
                selectMedicaments = new OleDbCommand("SELECT Medicaments.Name AS Name, DosageForms.Name AS DosageForm, Price, Quantity, Suppliers.Name AS Supplier FROM Medicaments " +
                                                        "JOIN Suppliers ON Medicaments.IdSupplier = Suppliers.IdSupplier " +
                                                            "JOIN DosageForms ON Medicaments.DosageForm = DosageForms.IdForm", cn);
            }
            else
            {
                selectMedicaments = new OleDbCommand("SELECT Medicaments.Name AS Name, DosageForms.Name AS DosageForm, Price, Quantity, Suppliers.Name AS Supplier FROM Medicaments " +
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

            EditMedicaments.Enabled = true;
        }

        private void EditMedicaments_Click(object sender, EventArgs e)
        {
            MedicamentsEditing medicamentsEditing = new MedicamentsEditing();
            medicamentsEditing.ShowDialog();
        }

        private void ShowDoctors_Click(object sender, EventArgs e)
        {
            dSet.Tables[3].Clear();
            OleDbCommand selectDoctors = new OleDbCommand("SELECT FIO, Name AS Specialization FROM Doctors " +
                                                                "JOIN Specializations ON Doctors.IdSpecialization = Specializations.IdSpecialization", cn);

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectDoctors;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Doctors");

            EditDoctors.Enabled = true;
        }

        private void EditDoctors_Click(object sender, EventArgs e)
        {
            DoctorsEditing doctorsEditing = new DoctorsEditing(this);
            doctorsEditing.ShowDialog();
        }

        private void ShowSpecializations_Click(object sender, EventArgs e)
        {
            dSet.Tables[4].Clear();
            OleDbCommand selectSpecializations = new OleDbCommand("SELECT Name FROM Specializations", cn);

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectSpecializations;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Specializations");

            EditSpecializations.Enabled = true;
        }

        private void EditSpecializations_Click(object sender, EventArgs e)
        {
            SpecializationsEditing specializationsEditing = new SpecializationsEditing(this);
            specializationsEditing.ShowDialog();
        }
        private void ShowAdministrators_Click(object sender, EventArgs e)
        {
            dSet.Tables[5].Clear();
            OleDbCommand selectAdministrators = new OleDbCommand("SELECT FIO FROM Administrators", cn);

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectAdministrators;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Administrators");

            EditAdministrators.Enabled = true;
        }

        private void EditAdministrators_Click(object sender, EventArgs e)
        {
            AdministratorsEditing administartorsEditing = new AdministratorsEditing();
            administartorsEditing.ShowDialog();
        }

        private void TypeUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowUsers.Enabled = false;
            if(TypeUsers.CheckedItems.Count > 0)
            {
                ShowUsers.Enabled = true;
            }
        }

        private void ShwUsers_Click(object sender, EventArgs e)
        {
            dSet.Tables[6].Clear();

            foreach (object typeUser in TypeUsers.CheckedItems)
            {
                OleDbCommand selectUsers = new OleDbCommand("SELECT FIO, Login, Password, NameType AS TypeUser FROM Users " +
                                                                "JOIN TypeUsers ON Users.TypeUser = TypeUsers.IdTypeUser " +
                                                                    "WHERE NameType = ?", cn);
                selectUsers.Parameters.Add("@NameType", OleDbType.VarChar);
                selectUsers.Parameters[0].Value = typeUser.ToString();
                dAdapter = new OleDbDataAdapter();
                dAdapter.SelectCommand = selectUsers;
                dAdapter.SelectCommand.Connection = cn;
                dAdapter.Fill(dSet, "Users");
            }

            EditUsers.Enabled = true;
        }

        private void EditUsers_Click(object sender, EventArgs e)
        {
            UsersEditing usersEditing = new UsersEditing();
            usersEditing.ShowDialog();
        }

        private void ShowDiagnoses_Click(object sender, EventArgs e)
        {
            dSet.Tables[7].Clear();
            OleDbCommand selectDiagnoses = new OleDbCommand("SELECT Name FROM Diagnoses", cn);

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectDiagnoses;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Diagnoses");

            EditDiagnoses.Enabled = true;
        }

        private void EditDiagnoses_Click(object sender, EventArgs e)
        {
            DiagnosesEditing diagnosesEditing = new DiagnosesEditing();
            diagnosesEditing.ShowDialog();
        }

        private void ShowSuppliers_Click(object sender, EventArgs e)
        {
            dSet.Tables[8].Clear();
            OleDbCommand selectSuppliers = new OleDbCommand("SELECT Name FROM Suppliers", cn);

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectSuppliers;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Suppliers");

            EditSuppliers.Enabled = true;
        }

        private void EditSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersEditing suppliersEditing = new SuppliersEditing();
            suppliersEditing.ShowDialog();
        }
    }
}

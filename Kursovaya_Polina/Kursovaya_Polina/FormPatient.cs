using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class FormPatient : Form
    {
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;

        private object IdPatient;

        private bool isMedicament1Selected;
        private bool isQuantity1Selected;
        private int totalPrice1;

        private bool isMedicament2Selected;
        private bool isQuantity2Selected;
        private int totalPrice2;

        private bool isMedicament3Selected;
        private bool isQuantity3Selected;
        private int totalPrice3;

        private bool isMedicament4Selected;
        private bool isQuantity4Selected;
        private int totalPrice4;

        private bool isMedicament5Selected;
        private bool isQuantity5Selected;
        private int totalPrice5;

        public FormPatient(String FioOfPatient)
        {
            InitializeComponent();

            this.FioOfPatient.Text = FioOfPatient;

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable schedule;
            schedule = dSet.Tables.Add("Schedule");
            schedule.Columns.Add("Date and time", typeof(string));
            schedule.Columns.Add("Patient", typeof(string));

            dgSchedule.SetDataBinding(dSet, "Schedule");

            OleDbCommand selectName = new OleDbCommand("SELECT Name FROM Specializations", cn);
            selectName.ExecuteNonQuery();

            OleDbDataReader reader = selectName.ExecuteReader();
            while (reader.Read())
            {
                Specializations1.Items.Add(reader["Name"]);
            }
            reader.Close();

            OleDbCommand selectFIO = new OleDbCommand("SELECT FIO FROM Doctors", cn);
            selectFIO.ExecuteNonQuery();

            reader = selectFIO.ExecuteReader();
            while (reader.Read())
            {
                Doctors.Items.Add(reader["FIO"]);
            }
            reader.Close();

            ShowSchedule.Enabled = false;


            DataTable pastAppointments;
            pastAppointments = dSet.Tables.Add("PastAppointments");
            pastAppointments.Columns.Add("Doctor", typeof(string));
            pastAppointments.Columns.Add("Specialization", typeof(string));
            pastAppointments.Columns.Add("Date and time", typeof(string));

            dgPastAppointments.SetDataBinding(dSet, "PastAppointments");

            OleDbCommand selectIdPatient = new OleDbCommand("SELECT IdPatient FROM Patients WHERE FIO = ?", cn);
            selectIdPatient.Parameters.Add("@FIO", OleDbType.VarChar);
            selectIdPatient.Parameters[0].Value = this.FioOfPatient.Text;
            selectIdPatient.ExecuteNonQuery();

            reader = selectIdPatient.ExecuteReader();
            reader.Read();
            IdPatient = reader["IdPatient"];
            reader.Close();

            DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            OleDbCommand selectPastAppointments = new OleDbCommand("SELECT FIO AS Doctor, Name AS Specialization, DateTime AS [Date and Time] FROM Appointments " +
                                                                        "JOIN Doctors ON Appointments.IdDoctor = Doctors.IdDoctor " +
                                                                            "JOIN Specializations ON Doctors.IdSpecialization = Specializations.IdSpecialization " +
                                                                                "WHERE IdPatient = ? AND DateTime < ?", cn);
            selectPastAppointments.Parameters.Add("@IdPatient", OleDbType.VarChar);
            selectPastAppointments.Parameters.AddWithValue("@DateTime", dateTime);
            selectPastAppointments.Parameters[0].Value = IdPatient;

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectPastAppointments;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "PastAppointments");


            DataTable futureAppointments;
            futureAppointments = dSet.Tables.Add("FutureAppointments");
            futureAppointments.Columns.Add("Doctor", typeof(string));
            futureAppointments.Columns.Add("Specialization", typeof(string));
            futureAppointments.Columns.Add("Date and time", typeof(string));

            dgFutureAppointments.SetDataBinding(dSet, "FutureAppointments");

            OleDbCommand selectFutureAppointments = new OleDbCommand("SELECT FIO AS Doctor, Name AS Specialization, DateTime AS [Date and Time] FROM Appointments " +
                                                                        "JOIN Doctors ON Appointments.IdDoctor = Doctors.IdDoctor " +
                                                                            "JOIN Specializations ON Doctors.IdSpecialization = Specializations.IdSpecialization " +
                                                                                "WHERE IdPatient = ? AND DateTime > ?", cn);
            selectFutureAppointments.Parameters.Add("@IdPatient", OleDbType.VarChar);
            selectFutureAppointments.Parameters.AddWithValue("@DateTime", dateTime);
            selectFutureAppointments.Parameters[0].Value = IdPatient;

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectFutureAppointments;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "FutureAppointments");


            DataTable orders;
            orders = dSet.Tables.Add("Orders");
            orders.Columns.Add("Date", typeof(string));
            orders.Columns.Add("TotalPrice", typeof(int));

            dgOrders.SetDataBinding(dSet, "Orders");

            OleDbCommand selectOrders = new OleDbCommand("SELECT Date, TotalPrice FROM Orders " +
                                                                        "WHERE IdPatient = ?", cn);
            selectOrders.Parameters.Add("@IdPatient", OleDbType.Integer);
            selectOrders.Parameters[0].Value = IdPatient;

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectOrders;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Orders");

            OleDbCommand selectMedicaments = new OleDbCommand("SELECT Medicaments.Name AS Name1, DosageForms.Name AS Name2 FROM Medicaments " +
                                                                    "JOIN DosageForms ON Medicaments.DosageForm = DosageForms.IdForm", cn);
            selectMedicaments.ExecuteNonQuery();

            reader = selectMedicaments.ExecuteReader();
            while (reader.Read())
            {
                Medicament1.Items.Add(reader["Name1"] + " " + reader["Name2"]);
                Medicament2.Items.Add(reader["Name1"] + " " + reader["Name2"]);
                Medicament3.Items.Add(reader["Name1"] + " " + reader["Name2"]);
                Medicament4.Items.Add(reader["Name1"] + " " + reader["Name2"]);
                Medicament5.Items.Add(reader["Name1"] + " " + reader["Name2"]);
            }
            reader.Close();

            for (int i = 0; i < 5; i++)
            {
                Quantity1.Items.Add(i + 1);
                Quantity2.Items.Add(i + 1);
                Quantity3.Items.Add(i + 1);
                Quantity4.Items.Add(i + 1);
                Quantity5.Items.Add(i + 1);
            }

            PlaceOrder.Enabled = false;

            isMedicament1Selected = false;
            isQuantity1Selected = false;
            totalPrice1 = 0;

            isMedicament2Selected = false;
            isQuantity2Selected = false;
            totalPrice2 = 0;

            isMedicament3Selected = false;
            isQuantity3Selected = false;
            totalPrice3 = 0;

            isMedicament4Selected = false;
            isQuantity4Selected = false;
            totalPrice4 = 0;

            isMedicament5Selected = false;
            isQuantity5Selected = false;
            totalPrice5 = 0;

            DataTable appointments;
            appointments = dSet.Tables.Add("Appointments");
            appointments.Columns.Add("Date", typeof(string));
            appointments.Columns.Add("FIO", typeof(string));
            appointments.Columns.Add("Specialization", typeof(string));
            appointments.Columns.Add("Service", typeof(string));
            appointments.Columns.Add("Diagnose", typeof(string));
            appointments.Columns.Add("Complaints", typeof(string));
            appointments.Columns.Add("Recommendations", typeof(string));
            appointments.Columns.Add("Medicaments", typeof(string));

            dgAppointments.SetDataBinding(dSet, "Appointments");

            OleDbCommand selectAppointments = new OleDbCommand("SELECT CONVERT(DATE, DateTime) AS Date, FIO, Specializations.Name AS Specialization, Services.Name AS Service, Diagnoses.Name AS Diagnose," +
                                                               " Complaints, Recommendations FROM Appointments " +
                                                                    "JOIN Doctors ON Appointments.IdDoctor = Doctors.IdDoctor " +
                                                                        "JOIN Specializations ON Doctors.IdSpecialization = Specializations.IdSpecialization " +
                                                                            "JOIN AppointmentsServices ON Appointments.IdAppointment = AppointmentsServices.IdAppointment " +
                                                                                "JOIN Services ON AppointmentsServices.IdService = Services.IdService " +
                                                                                    "JOIN AppointmentsDiagnoses ON Appointments.IdAppointment = AppointmentsDiagnoses.IdAppointment " +
                                                                                        "JOIN Diagnoses ON AppointmentsDiagnoses.IdDiagnose = Diagnoses.IdDiagnose " +
                                                                                            "WHERE IdPatient = ?", cn);
            selectAppointments.Parameters.Add("@IdPatient", OleDbType.Integer);
            selectAppointments.Parameters[0].Value = IdPatient;

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectAppointments;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Appointments");

            OleDbCommand selectIdAppointments = new OleDbCommand("SELECT IdAppointment FROM Appointments WHERE IdPatient = ?", cn);
            selectIdAppointments.Parameters.Add("@IdPatient", OleDbType.Integer);
            selectIdAppointments.Parameters[0].Value = IdPatient;
            selectIdAppointments.ExecuteNonQuery();

            reader = selectIdAppointments.ExecuteReader();
            int index = 0;
            while (reader.Read())
            {
                OleDbCommand selectMedicamentsForAppointment = new OleDbCommand("SELECT Name FROM Medicaments " +
                                                                                    "JOIN AppointmentsMedicaments ON Medicaments.IdMedicament = AppointmentsMedicaments.IdMedicament " +
                                                                                        "WHERE IdAppointment = ?", cn);
                selectMedicamentsForAppointment.Parameters.Add("@IdAppointment", OleDbType.Integer);
                selectMedicamentsForAppointment.Parameters[0].Value = reader["IdAppointment"];
                selectMedicamentsForAppointment.ExecuteNonQuery();

                OleDbDataReader reader1 = selectMedicamentsForAppointment.ExecuteReader();
                string medicaments = "";
                while (reader1.Read())
                {
                    if(String.IsNullOrEmpty(medicaments))
                    {
                        medicaments += reader1["Name"].ToString() + ", ";
                    }
                    else
                    {
                        medicaments += reader1["Name"].ToString().ToLower() + ", ";
                    }
                }
                if(String.IsNullOrEmpty(medicaments))
                {
                    dSet.Tables[4].Rows[index]["Medicaments"] = "-";
                }
                else
                {
                    dSet.Tables[4].Rows[index]["Medicaments"] = medicaments.Remove(medicaments.Length - 2);
                }

                index++;
            }
            reader.Close();
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {

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

        private void Specializations_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSchedule.Enabled = false;

            Doctors.Text = "";

            Doctors.Items.Clear();

            OleDbCommand selectFIO = new OleDbCommand("SELECT FIO FROM Doctors WHERE IdSpecialization = ?", cn);
            selectFIO.Parameters.Add("@Specialization", OleDbType.Integer);
            selectFIO.Parameters[0].Value = getIdSpecialization(Specializations1.Text);
            selectFIO.ExecuteNonQuery();

            OleDbDataReader reader = selectFIO.ExecuteReader();
            while (reader.Read())
                Doctors.Items.Add(reader["FIO"]);
            reader.Close();
        }

        private void Doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSchedule.Enabled = true;
        }

        private void ShowSchedule_Click(object sender, EventArgs e)
        {
            dSet.Tables[0].Clear();

            OleDbCommand selectIdDoctor = new OleDbCommand("SELECT IdDoctor FROM Doctors WHERE FIO = ?", cn);
            selectIdDoctor.Parameters.Add("@FIO", OleDbType.VarChar);
            selectIdDoctor.Parameters[0].Value = Doctors.SelectedItem;
            selectIdDoctor.ExecuteNonQuery();

            OleDbCommand selectAppointments = new OleDbCommand("SELECT DateTime AS [Date and time], 'Занято' AS Patient FROM Appointments " +
                                                                    "JOIN Patients ON Appointments.IdPatient = Patients.IdPatient " +
                                                                        "WHERE IdDoctor = ? " +
                                                               "UNION " +
                                                               "SELECT DateTime, '-' FROM Appointments " +
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
        }

        private bool getPlaceOrderEnabled()
        {
            if (isMedicament5Selected || isQuantity5Selected)
            {
                return isMedicament1Selected && isQuantity1Selected && isMedicament2Selected && isQuantity2Selected
                    && isMedicament3Selected && isQuantity3Selected && isMedicament4Selected && isQuantity4Selected
                        && isMedicament5Selected && isQuantity5Selected;
            }
            if (isMedicament4Selected || isQuantity4Selected)
            {
                return isMedicament1Selected && isQuantity1Selected && isMedicament2Selected && isQuantity2Selected
                    && isMedicament3Selected && isQuantity3Selected && isMedicament4Selected && isQuantity4Selected;
            }
            if (isMedicament3Selected || isQuantity3Selected)
            {
                return isMedicament1Selected && isQuantity1Selected && isMedicament2Selected && isQuantity2Selected
                    && isMedicament3Selected && isQuantity3Selected;
            }
            if (isMedicament2Selected || isQuantity2Selected)
            {
                return isMedicament1Selected && isQuantity1Selected && isMedicament2Selected && isQuantity2Selected;
            }
            if (isMedicament1Selected || isQuantity1Selected)
            {
                return isMedicament1Selected && isQuantity1Selected;
            }

            return false;
        }

        private int getPriceMedicament(object medicament)
        {
            if (medicament == null)
                return 0;

            OleDbCommand selectPriceMedicament = new OleDbCommand("SELECT Price FROM Medicaments WHERE Name = ?", cn);
            selectPriceMedicament.Parameters.Add("@Name", OleDbType.VarChar);
            selectPriceMedicament.Parameters[0].Value = medicament.ToString().Split(' ')[0];
            selectPriceMedicament.ExecuteNonQuery();

            OleDbDataReader reader = selectPriceMedicament.ExecuteReader();
            reader.Read();
            int price = (int)reader["Price"];
            reader.Close();

            return price;
        }

        private int getQuantityMedicament(string quantity_string)
        {
            if (String.IsNullOrEmpty(quantity_string))
                return 0;

            int quantity = Convert.ToInt32(quantity_string);

            return quantity;
        }

        private int getIdMedicament(string medicament)
        {
            OleDbCommand selectIdMedicament = new OleDbCommand("SELECT IdMedicament FROM Medicaments WHERE Name = ?", cn);
            selectIdMedicament.Parameters.Add("@Name", OleDbType.VarChar);
            selectIdMedicament.Parameters[0].Value = medicament.Split(' ')[0];
            selectIdMedicament.ExecuteNonQuery();

            OleDbDataReader reader = selectIdMedicament.ExecuteReader();
            reader.Read();
            int id = (int)reader["IdMedicament"];
            reader.Close();

            return id;
        }

        private void updateOrders()
        {
            dSet.Tables[3].Clear();

            OleDbCommand selectOrders = new OleDbCommand("SELECT Date, TotalPrice FROM Orders " +
                                                            "WHERE IdPatient = ?", cn);
            selectOrders.Parameters.Add("@IdPatient", OleDbType.Integer);
            selectOrders.Parameters[0].Value = IdPatient;

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectOrders;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Orders");
        }

        private void Medicament1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isMedicament1Selected = true;
            PlaceOrder.Enabled = getPlaceOrderEnabled();
            totalPrice1 = getPriceMedicament(Medicament1.SelectedItem) * getQuantityMedicament(Quantity1.Text);
            TotalPrice.Text = (totalPrice1 + totalPrice2 + totalPrice3 + totalPrice4 + totalPrice5).ToString();
        }

        private void Quantity1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isQuantity1Selected = true;
            PlaceOrder.Enabled = getPlaceOrderEnabled();
            totalPrice1 = getPriceMedicament(Medicament1.SelectedItem) * getQuantityMedicament(Quantity1.Text);
            TotalPrice.Text = (totalPrice1 + totalPrice2 + totalPrice3 + totalPrice4 + totalPrice5).ToString();
        }

        private void Medicament2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isMedicament2Selected = true;
            PlaceOrder.Enabled = getPlaceOrderEnabled();
            totalPrice2 = getPriceMedicament(Medicament2.SelectedItem) * getQuantityMedicament(Quantity2.Text);
            TotalPrice.Text = (totalPrice1 + totalPrice2 + totalPrice3 + totalPrice4 + totalPrice5).ToString();
        }

        private void Quantity2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isQuantity2Selected = true;
            PlaceOrder.Enabled = getPlaceOrderEnabled();
            totalPrice2 = getPriceMedicament(Medicament2.SelectedItem) * getQuantityMedicament(Quantity2.Text);
            TotalPrice.Text = (totalPrice1 + totalPrice2 + totalPrice3 + totalPrice4 + totalPrice5).ToString();
        }

        private void Medicament3_SelectedIndexChanged(object sender, EventArgs e)
        {
            isMedicament3Selected = true;
            PlaceOrder.Enabled = getPlaceOrderEnabled();
            totalPrice3 = getPriceMedicament(Medicament3.SelectedItem) * getQuantityMedicament(Quantity3.Text);
            TotalPrice.Text = (totalPrice1 + totalPrice2 + totalPrice3 + totalPrice4 + totalPrice5).ToString();
        }

        private void Quantity3_SelectedIndexChanged(object sender, EventArgs e)
        {
            isQuantity3Selected = true;
            PlaceOrder.Enabled = getPlaceOrderEnabled();
            totalPrice3 = getPriceMedicament(Medicament3.SelectedItem) * getQuantityMedicament(Quantity3.Text);
            TotalPrice.Text = (totalPrice1 + totalPrice2 + totalPrice3 + totalPrice4 + totalPrice5).ToString();
        }

        private void Medicament4_SelectedIndexChanged(object sender, EventArgs e)
        {
            isMedicament4Selected = true;
            PlaceOrder.Enabled = getPlaceOrderEnabled();
            totalPrice4 = getPriceMedicament(Medicament4.SelectedItem) * getQuantityMedicament(Quantity4.Text);
            TotalPrice.Text = (totalPrice1 + totalPrice2 + totalPrice3 + totalPrice4 + totalPrice5).ToString();
        }

        private void Quantity4_SelectedIndexChanged(object sender, EventArgs e)
        {
            isQuantity4Selected = true;
            PlaceOrder.Enabled = getPlaceOrderEnabled();
            totalPrice4 = getPriceMedicament(Medicament4.SelectedItem) * getQuantityMedicament(Quantity4.Text);
            TotalPrice.Text = (totalPrice1 + totalPrice2 + totalPrice3 + totalPrice4 + totalPrice5).ToString();
        }

        private void Medicament5_SelectedIndexChanged(object sender, EventArgs e)
        {
            isMedicament5Selected = true;
            PlaceOrder.Enabled = getPlaceOrderEnabled();
            totalPrice5 = getPriceMedicament(Medicament5.SelectedItem) * getQuantityMedicament(Quantity5.Text);
            TotalPrice.Text = (totalPrice1 + totalPrice2 + totalPrice3 + totalPrice4 + totalPrice5).ToString();
        }

        private void Quantity5_SelectedIndexChanged(object sender, EventArgs e)
        {
            isQuantity5Selected = true;
            PlaceOrder.Enabled = getPlaceOrderEnabled();
            totalPrice5 = getPriceMedicament(Medicament5.SelectedItem) * getQuantityMedicament(Quantity5.Text);
            TotalPrice.Text = (totalPrice1 + totalPrice2 + totalPrice3 + totalPrice4 + totalPrice5).ToString();
        }

        private void ResetData_Click(object sender, EventArgs e)
        {
            Medicament1.Text = "";
            Medicament2.Text = "";
            Medicament3.Text = "";
            Medicament4.Text = "";
            Medicament5.Text = "";

            Quantity1.Text = "";
            Quantity2.Text = "";
            Quantity3.Text = "";
            Quantity4.Text = "";
            Quantity5.Text = "";

            TotalPrice.Text = "";

            PlaceOrder.Enabled = false;

            isMedicament1Selected = false;
            isQuantity1Selected = false;
            totalPrice1 = 0;

            isMedicament2Selected = false;
            isQuantity2Selected = false;
            totalPrice2 = 0;

            isMedicament3Selected = false;
            isQuantity3Selected = false;
            totalPrice3 = 0;

            isMedicament4Selected = false;
            isQuantity4Selected = false;
            totalPrice4 = 0;

            isMedicament5Selected = false;
            isQuantity5Selected = false;
            totalPrice5 = 0;
        }

        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            OleDbCommand insertIntoOrders = new OleDbCommand("INSERT INTO Orders (Date, IdPatient, TotalPrice) VALUES (?, ?, ?)", cn);
            insertIntoOrders.Parameters.AddWithValue("@Date", dateTime);
            insertIntoOrders.Parameters.Add("@IdPatient", OleDbType.Integer);
            insertIntoOrders.Parameters.Add("@TotalPrice", OleDbType.Integer);
            insertIntoOrders.Parameters[1].Value = IdPatient;
            insertIntoOrders.Parameters[2].Value = Convert.ToInt32(TotalPrice.Text);
            insertIntoOrders.ExecuteNonQuery();

            OleDbCommand selectIdOrder = new OleDbCommand("SELECT IdOrder FROM Orders " +
                                                                "WHERE CONVERT(DATE, Date) = ? AND IdPatient = ? AND TotalPrice = ?", cn);
            selectIdOrder.Parameters.AddWithValue("@Date", dateTime);
            selectIdOrder.Parameters.Add("@IdPatient", OleDbType.Integer);
            selectIdOrder.Parameters.Add("@TotalPrice", OleDbType.Integer);
            selectIdOrder.Parameters[1].Value = IdPatient;
            selectIdOrder.Parameters[2].Value = Convert.ToInt32(TotalPrice.Text)*1.2;
            selectIdOrder.ExecuteNonQuery();

            OleDbDataReader reader = selectIdOrder.ExecuteReader();
            reader.Read();
            object IdOrder = reader["IdOrder"];
            reader.Close();

            OleDbCommand insertIntoOrdersMedicaments = new OleDbCommand("INSERT INTO OrdersMedicaments (IdOrder, IdMedicament, Quantity) VALUES (?, ?, ?)", cn);
            insertIntoOrdersMedicaments.Parameters.Add("@IdOrder", OleDbType.Integer);
            insertIntoOrdersMedicaments.Parameters.Add("@IdMedicament", OleDbType.Integer);
            insertIntoOrdersMedicaments.Parameters.Add("@Quantity", OleDbType.Integer);
            insertIntoOrdersMedicaments.Parameters[0].Value = IdOrder;

            if (!String.IsNullOrEmpty(Medicament1.Text))
            {
                insertIntoOrdersMedicaments.Parameters[1].Value = getIdMedicament(Medicament1.Text);
                insertIntoOrdersMedicaments.Parameters[2].Value = getQuantityMedicament(Quantity1.Text);
                insertIntoOrdersMedicaments.ExecuteNonQuery();
            }

            if (!String.IsNullOrEmpty(Medicament2.Text))
            {
                insertIntoOrdersMedicaments.Parameters[1].Value = getIdMedicament(Medicament2.Text);
                insertIntoOrdersMedicaments.Parameters[2].Value = getQuantityMedicament(Quantity2.Text);
                insertIntoOrdersMedicaments.ExecuteNonQuery();
            }

            if (!String.IsNullOrEmpty(Medicament3.Text))
            {
                insertIntoOrdersMedicaments.Parameters[1].Value = getIdMedicament(Medicament3.Text);
                insertIntoOrdersMedicaments.Parameters[2].Value = getQuantityMedicament(Quantity3.Text);
                insertIntoOrdersMedicaments.ExecuteNonQuery();
            }

            if (!String.IsNullOrEmpty(Medicament4.Text))
            {
                insertIntoOrdersMedicaments.Parameters[1].Value = getIdMedicament(Medicament4.Text);
                insertIntoOrdersMedicaments.Parameters[2].Value = getQuantityMedicament(Quantity4.Text);
                insertIntoOrdersMedicaments.ExecuteNonQuery();
            }

            if (!String.IsNullOrEmpty(Medicament5.Text))
            {
                insertIntoOrdersMedicaments.Parameters[1].Value = getIdMedicament(Medicament5.Text);
                insertIntoOrdersMedicaments.Parameters[2].Value = getQuantityMedicament(Quantity5.Text);
                insertIntoOrdersMedicaments.ExecuteNonQuery();
            }

            PlaceOrder.Enabled = false;

            updateOrders();

            Medicament1.Text = "";
            Medicament2.Text = "";
            Medicament3.Text = "";
            Medicament4.Text = "";
            Medicament5.Text = "";

            Quantity1.Text = "";
            Quantity2.Text = "";
            Quantity3.Text = "";
            Quantity4.Text = "";
            Quantity5.Text = "";

            TotalPrice.Text = "";

            PlaceOrder.Enabled = false;

            isMedicament1Selected = false;
            isQuantity1Selected = false;
            totalPrice1 = 0;

            isMedicament2Selected = false;
            isQuantity2Selected = false;
            totalPrice2 = 0;

            isMedicament3Selected = false;
            isQuantity3Selected = false;
            totalPrice3 = 0;

            isMedicament4Selected = false;
            isQuantity4Selected = false;
            totalPrice4 = 0;

            isMedicament5Selected = false;
            isQuantity5Selected = false;
            totalPrice5 = 0;

            MessageBox.Show("    Заказ оформлен!    ");
        }
    }
}

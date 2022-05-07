using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class ServicesEditing : Form
    {
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;

        private bool isNameOfService1Selected;
        private bool isPrice1Selected;
        private bool areDoctorsSelected;

        private bool isIdService2Selected;
        private bool isNameOfService2Selected;
        private bool isPrice2Selected;
        public ServicesEditing(String nameOfSpecialization, String nameOfDoctor)
        {
            InitializeComponent();

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            NameOfSpecialization.Text = nameOfSpecialization;
            NameOfDoctor.Text = nameOfDoctor;

            dSet = new DataSet();
            DataTable services;
            services = dSet.Tables.Add("Services");
            services.Columns.Add("IdService", typeof(int));
            services.Columns.Add("Name", typeof(string));
            services.Columns.Add("Price", typeof(int));

            dgServices.SetDataBinding(dSet, "Services");

            OleDbCommand selectServices;

            if (!String.IsNullOrEmpty(NameOfSpecialization.Text))
            {
                OleDbCommand selectIdSpecialization = new OleDbCommand("SELECT IdSpecialization FROM Specializations WHERE Name = ?", cn);
                selectIdSpecialization.Parameters.Add("@Name", OleDbType.VarChar);
                selectIdSpecialization.Parameters[0].Value = NameOfSpecialization.Text;
                selectIdSpecialization.ExecuteNonQuery();

                OleDbDataReader reader = selectIdSpecialization.ExecuteReader();
                reader.Read();
                object IdSpecialization = reader["IdSpecialization"];
                reader.Close();

                if (String.IsNullOrEmpty(NameOfDoctor.Text))
                {
                    selectServices = new OleDbCommand("SELECT DISTINCT Services.IdService, Name, Price FROM Services " +
                                                        "JOIN ServicesDoctors ON Services.IdService = ServicesDoctors.IdService " +
                                                            "LEFT JOIN Doctors ON ServicesDoctors.IdDoctor = Doctors.IdDoctor " +
                                                                "WHERE IdSpecialization = ?", cn);
                    selectServices.Parameters.Add("@IdSpecialization", OleDbType.Integer);

                    OleDbCommand selectDoctors = new OleDbCommand("SELECT FIO FROM Doctors WHERE IdSpecialization = ?", cn);
                    selectDoctors.Parameters.Add("@IdSpecialization", OleDbType.Integer);
                    selectDoctors.Parameters[0].Value = IdSpecialization;
                    selectDoctors.ExecuteNonQuery();

                    reader = selectDoctors.ExecuteReader();
                    while (reader.Read())
                        Doctors.Items.Add(reader["FIO"]);
                    reader.Close();

                    Doctors.Enabled = true;
                }
                else
                {
                    selectServices = new OleDbCommand("SELECT DISTINCT Services.IdService, Name, Price FROM Services " +
                                                        "JOIN ServicesDoctors ON Services.IdService = ServicesDoctors.IdService " +
                                                            "LEFT JOIN Doctors ON ServicesDoctors.IdDoctor = Doctors.IdDoctor " +
                                                                "WHERE IdSpecialization = ? AND FIO = ?", cn);
                    selectServices.Parameters.Add("@IdSpecialization", OleDbType.Integer);
                    selectServices.Parameters.Add("@FIO", OleDbType.VarChar);
                    selectServices.Parameters[1].Value = NameOfDoctor.Text;
                    Doctors.Enabled = false;
                }

                selectServices.Parameters[0].Value = IdSpecialization;
            }
            else
            {
                selectServices = new OleDbCommand("SELECT DISTINCT Services.IdService, Name, Price FROM Services " +
                                                   "JOIN ServicesDoctors ON Services.IdService = ServicesDoctors.IdService " +
                                                       "LEFT JOIN Doctors ON ServicesDoctors.IdDoctor = Doctors.IdDoctor " +
                                                           "WHERE FIO = ?", cn);
                selectServices.Parameters.Add("@FIO", OleDbType.VarChar);
                selectServices.Parameters[0].Value = NameOfDoctor.Text;
                Doctors.Enabled = false;
            }
            selectServices.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectServices;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Services");

            OleDbDataReader reader1 = selectServices.ExecuteReader();
            while (reader1.Read())
            {
                IdService1.Items.Add(reader1["IdService"]);
                IdService2.Items.Add(reader1["IdService"]);
            }
            reader1.Close();

            DeleteService.Enabled = false;
            AddService.Enabled = false;
            EditService.Enabled = false;

            isNameOfService1Selected = false;
            isPrice1Selected = false;
            areDoctorsSelected = false;

            isIdService2Selected = false;
            isNameOfService2Selected = false;
            isPrice2Selected = false;
        }

        private void ServicesEditing_Load(object sender, EventArgs e)
        {

        }

        private void updateIdServices()
        {
            OleDbCommand selectServices;

            if (!String.IsNullOrEmpty(NameOfSpecialization.Text))
            {
                OleDbCommand selectIdSpecialization = new OleDbCommand("SELECT IdSpecialization FROM Specializations WHERE Name = ?", cn);
                selectIdSpecialization.Parameters.Add("@Name", OleDbType.VarChar);
                selectIdSpecialization.Parameters[0].Value = NameOfSpecialization.Text;
                selectIdSpecialization.ExecuteNonQuery();

                OleDbDataReader reader = selectIdSpecialization.ExecuteReader();
                reader.Read();
                object IdSpecialization = reader["IdSpecialization"];
                reader.Close();

                if (String.IsNullOrEmpty(NameOfDoctor.Text))
                {
                    selectServices = new OleDbCommand("SELECT DISTINCT Services.IdService, Name, Price FROM Services " +
                                                        "JOIN ServicesDoctors ON Services.IdService = ServicesDoctors.IdService " +
                                                            "LEFT JOIN Doctors ON ServicesDoctors.IdDoctor = Doctors.IdDoctor " +
                                                                "WHERE IdSpecialization = ?", cn);
                    selectServices.Parameters.Add("@Specialization", OleDbType.Integer);
                }
                else
                {
                    selectServices = new OleDbCommand("SELECT DISTINCT Services.IdService, Name, Price FROM Services " +
                                                        "JOIN ServicesDoctors ON Services.IdService = ServicesDoctors.IdService " +
                                                            "LEFT JOIN Doctors ON ServicesDoctors.IdDoctor = Doctors.IdDoctor " +
                                                                "WHERE IdSpecialization = ? AND FIO = ?", cn);
                    selectServices.Parameters.Add("@IdSpecialization", OleDbType.Integer);
                    selectServices.Parameters.Add("@FIO", OleDbType.VarChar);
                    selectServices.Parameters[1].Value = NameOfDoctor.Text;
                }

                selectServices.Parameters[0].Value = IdSpecialization;
            }
            else
            {
                selectServices = new OleDbCommand("SELECT DISTINCT Services.IdService, Name, Price FROM Services " +
                                                   "JOIN ServicesDoctors ON Services.IdService = ServicesDoctors.IdService " +
                                                       "LEFT JOIN Doctors ON ServicesDoctors.IdDoctor = Doctors.IdDoctor " +
                                                           "WHERE FIO = ?", cn);
                selectServices.Parameters.Add("@FIO", OleDbType.VarChar);
                selectServices.Parameters[0].Value = NameOfDoctor.Text;
            }
            selectServices.ExecuteNonQuery();

            OleDbDataReader reader1 = selectServices.ExecuteReader();
            IdService1.Items.Clear();
            IdService2.Items.Clear();
            while (reader1.Read())
            {
                IdService1.Items.Add(reader1["IdService"]);
                IdService2.Items.Add(reader1["IdService"]);
            }
            reader1.Close();
        }

        private void updateServices()
        {
            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Services");
        }

        private void IdService1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteService.Enabled = true;
        }

        private void DeleteService_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameOfDoctor.Text))
            {
                OleDbCommand deleteService = new OleDbCommand("DELETE FROM Services WHERE IdService = ?", cn);
                deleteService.Parameters.Add("@IdService", OleDbType.Integer);
                deleteService.Parameters[0].Value = IdService1.SelectedItem;
                deleteService.ExecuteNonQuery();
            }
            else
            {
                OleDbCommand selectIdDoctor = new OleDbCommand("SELECT IdDoctor FROM Doctors WHERE FIO = ?", cn);
                selectIdDoctor.Parameters.Add("@FIO", OleDbType.VarChar);
                selectIdDoctor.Parameters[0].Value = NameOfDoctor.Text;
                selectIdDoctor.ExecuteNonQuery();

                OleDbCommand deleteFromServicesDoctors = new OleDbCommand("DELETE FROM ServicesDoctors WHERE IdService = ? AND IdDoctor = ?", cn);
                deleteFromServicesDoctors.Parameters.Add("@IdService", OleDbType.Integer);
                deleteFromServicesDoctors.Parameters.Add("@IdDoctor", OleDbType.Integer);
                deleteFromServicesDoctors.Parameters[0].Value = IdService1.SelectedItem;

                OleDbDataReader reader = selectIdDoctor.ExecuteReader();
                reader.Read();
                deleteFromServicesDoctors.Parameters[1].Value = reader["IdDoctor"];
                reader.Close();

                deleteFromServicesDoctors.ExecuteNonQuery();
            }

            IdService1.Text = "";
            DeleteService.Enabled = false;
            updateServices();
            updateIdServices();

            MessageBox.Show("    Услуга удалена!    ");
        }

        private bool getAddServiceEnabled(bool DoctorsEnabled)
        {
            if (DoctorsEnabled)
            {
                return isNameOfService1Selected && isPrice1Selected && areDoctorsSelected;
            }

            return isNameOfService1Selected && isPrice1Selected;
        }

        private object getIdService(String name, String price)
        {
            OleDbCommand selectIdService = new OleDbCommand("SELECT IdService FROM Services WHERE Name = ? AND Price = ?", cn);
            selectIdService.Parameters.Add("@Name", OleDbType.VarChar);
            selectIdService.Parameters.Add("@Price", OleDbType.VarChar);
            selectIdService.Parameters[0].Value = NameOfService1.Text;
            selectIdService.Parameters[1].Value = Price1.Text;
            selectIdService.ExecuteNonQuery();

            object IdService;
            OleDbDataReader reader = selectIdService.ExecuteReader();
            if (reader.Read())
            {
                IdService = reader["IdService"];
                reader.Close();
                return IdService;
            }

            return null;
        }

        private void NameOfSpecialization1_TextChanged(object sender, EventArgs e)
        {
            isNameOfService1Selected = true;

            if (String.IsNullOrEmpty(NameOfService1.Text))
            {
                isNameOfService1Selected = false;
            }

            AddService.Enabled = getAddServiceEnabled(Doctors.Enabled);
        }

        private void Price1_TextChanged(object sender, EventArgs e)
        {
            isPrice1Selected = true;

            if (String.IsNullOrEmpty(Price1.Text))
            {
                isPrice1Selected = false;
            }
            if(Price1.Text.Contains("-") || !Price1.Text.All(char.IsDigit) || Price1.Text.StartsWith("0"))
            {
                isPrice1Selected = false;
                MessageBox.Show("    Некорректная цена!    ");
            }

            AddService.Enabled = getAddServiceEnabled(Doctors.Enabled);
        }

        private void Doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            areDoctorsSelected = true;
            AddService.Enabled = isNameOfService1Selected && isPrice1Selected && areDoctorsSelected;
        }

        private void AddService_Click(object sender, EventArgs e)
        {
            if(getIdService(NameOfService1.Text, Price1.Text) == null)
            {
                OleDbCommand insertIntoServices = new OleDbCommand("INSERT INTO Services (Name, Price) VALUES (?, ?)", cn);
                insertIntoServices.Parameters.Add("@Name", OleDbType.VarChar);
                insertIntoServices.Parameters.Add("@Price", OleDbType.Integer);
                insertIntoServices.Parameters[0].Value = NameOfService1.Text;
                insertIntoServices.Parameters[1].Value = Price1.Text;
                insertIntoServices.ExecuteNonQuery();
            }

            object IdService = getIdService(NameOfService1.Text, Price1.Text);

            if (String.IsNullOrEmpty(NameOfDoctor.Text))
            {
                foreach (object doctor in Doctors.CheckedItems)
                {
                    OleDbCommand selectIdDoctor = new OleDbCommand("SELECT IdDoctor FROM Doctors WHERE FIO = ?", cn);
                    selectIdDoctor.Parameters.Add("@FIO", OleDbType.VarChar);
                    selectIdDoctor.Parameters[0].Value = doctor.ToString();
                    selectIdDoctor.ExecuteNonQuery();

                    OleDbCommand insertIntoServicesDoctors = new OleDbCommand("INSERT INTO ServicesDoctors (IdService, IdDoctor) VALUES (?, ?)", cn);
                    insertIntoServicesDoctors.Parameters.Add("@IdService", OleDbType.VarChar);
                    insertIntoServicesDoctors.Parameters.Add("@IdDoctor", OleDbType.Integer);
                    insertIntoServicesDoctors.Parameters[0].Value = IdService;

                    OleDbDataReader reader = selectIdDoctor.ExecuteReader();
                    reader.Read();
                    insertIntoServicesDoctors.Parameters[1].Value = reader["IdDoctor"];
                    reader.Close();

                    insertIntoServicesDoctors.ExecuteNonQuery();
                }
            }
            else
            {
                OleDbCommand selectIdDoctor = new OleDbCommand("SELECT IdDoctor FROM Doctors WHERE FIO = ?", cn);
                selectIdDoctor.Parameters.Add("@FIO", OleDbType.VarChar);
                selectIdDoctor.Parameters[0].Value = NameOfDoctor.Text;
                selectIdDoctor.ExecuteNonQuery();

                OleDbCommand insertIntoServicesDoctors = new OleDbCommand("INSERT INTO ServicesDoctors (IdService, IdDoctor) VALUES (?, ?)", cn);
                insertIntoServicesDoctors.Parameters.Add("@IdService", OleDbType.Integer);
                insertIntoServicesDoctors.Parameters.Add("@IdDoctor", OleDbType.Integer);
                insertIntoServicesDoctors.Parameters[0].Value = IdService;

                OleDbDataReader reader = selectIdDoctor.ExecuteReader();
                reader.Read();
                insertIntoServicesDoctors.Parameters[1].Value = reader["IdDoctor"];
                reader.Close();

                insertIntoServicesDoctors.ExecuteNonQuery();
            }

            NameOfService1.Text = "";
            Price1.Text = "";
            for(int i = 0; i < Doctors.Items.Count; i++)
            {
                Doctors.SetItemChecked(i, false);
            }

            AddService.Enabled = false;

            updateServices();

            updateIdServices();

            isNameOfService1Selected = false;
            isPrice1Selected = false;
            areDoctorsSelected = false;

            MessageBox.Show("    Услуга добавлена!    ");
        }

        private void IdService2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIdService2Selected = true;
            EditService.Enabled = isIdService2Selected && isNameOfService2Selected && isPrice2Selected;
        }

        private void NameOfSpecialization2_TextChanged(object sender, EventArgs e)
        {
            isNameOfService2Selected = true;

            if (String.IsNullOrEmpty(NameOfService2.Text))
            {
                isNameOfService2Selected = false;
            }

            EditService.Enabled = isIdService2Selected && isNameOfService2Selected && isPrice2Selected;
        }

        private void Price2_TextChanged(object sender, EventArgs e)
        {
            isPrice2Selected = true;

            if (String.IsNullOrEmpty(Price2.Text))
            {
                isPrice2Selected = false;
            }
            if (Price2.Text.Contains("-") || !Price2.Text.All(char.IsDigit) || Price2.Text.StartsWith("0"))
            {
                isPrice1Selected = false;
                MessageBox.Show("    Некорректная цена!    ");
            }

            EditService.Enabled = isIdService2Selected && isNameOfService2Selected && isPrice2Selected;
        }

        private void EditService_Click(object sender, EventArgs e)
        {
            OleDbCommand updateSevices = new OleDbCommand("UPDATE Services SET Name = ?, Price = ? WHERE IdService = ?", cn);
            updateSevices.Parameters.Add("@Name", OleDbType.VarChar);
            updateSevices.Parameters.Add("@Price", OleDbType.Integer);
            updateSevices.Parameters.Add("@IdService", OleDbType.Integer);
            updateSevices.Parameters[0].Value = NameOfService2.Text;
            updateSevices.Parameters[1].Value = Price2.Text;
            updateSevices.Parameters[2].Value = IdService2.SelectedItem;

            updateSevices.ExecuteNonQuery();

            IdService2.Text = "";
            NameOfService2.Text = "";
            Price2.Text = "";

            EditService.Enabled = false;

            updateServices();

            isIdService2Selected = false;
            isNameOfService2Selected = false;
            isPrice2Selected = false;

            MessageBox.Show("    Услуга отредактирована!    ");
        }
    }
}

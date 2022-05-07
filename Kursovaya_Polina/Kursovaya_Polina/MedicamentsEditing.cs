using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class MedicamentsEditing : Form
    {
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;

        private bool isNameOfMedicament1Selected;
        private bool isPrice1Selected;
        private bool isQuantity1Selected;
        private bool isSupplier1Selected;
        private bool isDosageForm1Selected;

        private bool isIdMedicament2Selected;
        private bool isNameOfMedicament2Selected;
        private bool isPrice2Selected;
        private bool isQuantity2Selected;
        private bool isSupplier2Selected;
        private bool isDosageForm2Selected;
        public MedicamentsEditing()
        {
            InitializeComponent();

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable medicaments;
            medicaments = dSet.Tables.Add("Medicaments");
            medicaments.Columns.Add("IdMedicament", typeof(int));
            medicaments.Columns.Add("Name", typeof(string));
            medicaments.Columns.Add("DosageForm", typeof(string));
            medicaments.Columns.Add("Price", typeof(int));
            medicaments.Columns.Add("Quantity", typeof(int));
            medicaments.Columns.Add("Supplier", typeof(string));

            dgMedicaments.SetDataBinding(dSet, "Medicaments");

            OleDbCommand selectMedicaments = new OleDbCommand("SELECT IdMedicament, Medicaments.Name AS Name, DosageForms.Name AS DosageForm, Price, Quantity, Suppliers.Name AS Supplier FROM Medicaments " +
                                                                "JOIN Suppliers ON Medicaments.IdSupplier = Suppliers.IdSupplier " +
                                                                    "JOIN DosageForms ON Medicaments.DosageForm = DosageForms.IdForm", cn);

            selectMedicaments.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectMedicaments;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Medicaments");

            OleDbDataReader reader = selectMedicaments.ExecuteReader();
            while (reader.Read())
            {
                IdMedicament1.Items.Add(reader["IdMedicament"]);
                IdMedicament2.Items.Add(reader["IdMedicament"]);
            }
            reader.Close();

            OleDbCommand selectNameOfSuppliers = new OleDbCommand("SELECT Name FROM Suppliers", cn);
            selectNameOfSuppliers.ExecuteNonQuery();

            reader = selectNameOfSuppliers.ExecuteReader();
            while (reader.Read())
            {
                Supplier1.Items.Add(reader["Name"]);
                Supplier2.Items.Add(reader["Name"]);
            }
            reader.Close();

            OleDbCommand selectDosageForms = new OleDbCommand("SELECT Name FROM DosageForms", cn);
            selectDosageForms.ExecuteNonQuery();

            reader = selectDosageForms.ExecuteReader();
            while (reader.Read())
            {
                DosageForm1.Items.Add(reader["Name"]);
                DosageForm2.Items.Add(reader["Name"]);
            }
            reader.Close();

            DeleteMedicament.Enabled = false;
            AddMedicament.Enabled = false;
            EditMedicament.Enabled = false;

            isNameOfMedicament1Selected = false;
            isPrice1Selected = false;
            isQuantity1Selected = false;
            isSupplier1Selected = false;
            isDosageForm1Selected = false;

            isIdMedicament2Selected = false;
            isNameOfMedicament2Selected = false;
            isPrice2Selected = false;
            isQuantity2Selected = false;
            isSupplier2Selected = false;
            isDosageForm2Selected = false;
        }

        private void MedicamentsEditing_Load(object sender, EventArgs e)
        {

        }

        private void updateIdMedicaments()
        {
            OleDbCommand selectIdMedicament = new OleDbCommand("SELECT IdMedicament FROM Medicaments", cn);
            selectIdMedicament.ExecuteNonQuery();

            OleDbDataReader reader = selectIdMedicament.ExecuteReader();
            IdMedicament1.Items.Clear();
            IdMedicament2.Items.Clear();
            while (reader.Read())
            {
                IdMedicament1.Items.Add(reader["IdMedicament"]);
                IdMedicament2.Items.Add(reader["IdMedicament"]);
            }
            reader.Close();
        }

        private void updateMedicaments()
        {
            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Medicaments");
        }

        private void IdMedicament1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteMedicament.Enabled = true;
        }

        private void DeleteMedicament_Click(object sender, EventArgs e)
        {
            OleDbCommand deleteMedicament = new OleDbCommand("DELETE FROM Medicaments WHERE IdMedicament = ?", cn);
            deleteMedicament.Parameters.Add("@IdMedicament", OleDbType.Integer);
            deleteMedicament.Parameters[0].Value = IdMedicament1.SelectedItem;

            deleteMedicament.ExecuteNonQuery();
            IdMedicament1.Text = "";
            DeleteMedicament.Enabled = false;
            updateMedicaments();
            updateIdMedicaments();
            MessageBox.Show("    Медикамент удалён!    ");
        }

        private void NameOfMedicament1_TextChanged(object sender, EventArgs e)
        {
            isNameOfMedicament1Selected = true;

            if (String.IsNullOrEmpty(NameOfMedicament1.Text))
            {
                isNameOfMedicament1Selected = false;
            }

            AddMedicament.Enabled = isNameOfMedicament1Selected && isPrice1Selected && isQuantity1Selected
                && isSupplier1Selected && isDosageForm1Selected;
        }

        private void Price1_TextChanged(object sender, EventArgs e)
        {
            isPrice1Selected = true;

            if (String.IsNullOrEmpty(Price1.Text))
            {
                isPrice1Selected = false;
            }
            if (Price1.Text.Contains("-") || !Price1.Text.All(char.IsDigit) || Price1.Text.StartsWith("0"))
            {
                isPrice1Selected = false;
                MessageBox.Show("    Некорректная цена!    ");
            }

            AddMedicament.Enabled = isNameOfMedicament1Selected && isPrice1Selected && isQuantity1Selected
                && isSupplier1Selected && isDosageForm1Selected;
        }

        private void Quantity1_TextChanged(object sender, EventArgs e)
        {
            isQuantity1Selected = true;

            if (String.IsNullOrEmpty(Quantity1.Text))
            {
                isQuantity1Selected = false;
            }
            if (Quantity1.Text.Contains("-") || !Quantity1.Text.All(char.IsDigit))
            {
                isQuantity1Selected = false;
                MessageBox.Show("    Некорректное количество!    ");
            }

            AddMedicament.Enabled = isNameOfMedicament1Selected && isPrice1Selected && isQuantity1Selected
                && isSupplier1Selected && isDosageForm1Selected;
        }

        private void Supplier1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSupplier1Selected = true;
            AddMedicament.Enabled = isNameOfMedicament1Selected && isPrice1Selected && isQuantity1Selected
                && isSupplier1Selected && isDosageForm1Selected;
        }

        private void DosageForm1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isDosageForm1Selected = true;
            AddMedicament.Enabled = isNameOfMedicament1Selected && isPrice1Selected && isQuantity1Selected
                && isSupplier1Selected && isDosageForm1Selected;
        }

        private void AddMedicament_Click(object sender, EventArgs e)
        {
            OleDbCommand insertIntoMedicaments = new OleDbCommand("INSERT INTO Medicaments (Name, DosageForm, Price, Quantity, IdSupplier) VALUES (?, ?, ?, ?, ?)", cn);
            insertIntoMedicaments.Parameters.Add("@Name", OleDbType.VarChar);
            insertIntoMedicaments.Parameters.Add("@DosageForm", OleDbType.Integer);
            insertIntoMedicaments.Parameters.Add("@Price", OleDbType.Integer);
            insertIntoMedicaments.Parameters.Add("@Quantity", OleDbType.Integer);
            insertIntoMedicaments.Parameters.Add("@IdSupplier", OleDbType.Integer);
            insertIntoMedicaments.Parameters[0].Value = NameOfMedicament1.Text;
            insertIntoMedicaments.Parameters[2].Value = Price1.Text;
            insertIntoMedicaments.Parameters[3].Value = Quantity1.Text;

            OleDbCommand selectIdForm = new OleDbCommand("SELECT IdForm FROM DosageForms " +
                                                            "WHERE Name = ?", cn);
            selectIdForm.Parameters.Add("@Name", OleDbType.VarChar);
            selectIdForm.Parameters[0].Value = DosageForm1.Text;
            selectIdForm.ExecuteNonQuery();

            OleDbDataReader reader = selectIdForm.ExecuteReader();
            reader.Read();
            insertIntoMedicaments.Parameters[1].Value = reader["IdForm"];
            reader.Close();

            OleDbCommand selectIdSupplier = new OleDbCommand("SELECT IdSupplier FROM Suppliers " +
                                                            "WHERE Name = ?", cn);
            selectIdSupplier.Parameters.Add("@Name", OleDbType.VarChar);
            selectIdSupplier.Parameters[0].Value = Supplier1.Text;
            selectIdSupplier.ExecuteNonQuery();

            reader = selectIdSupplier.ExecuteReader();
            reader.Read();
            insertIntoMedicaments.Parameters[4].Value = reader["IdSupplier"];
            reader.Close();

            insertIntoMedicaments.ExecuteNonQuery();

            NameOfMedicament1.Text = "";
            Price1.Text = "";
            Quantity1.Text = "";
            Supplier1.Text = "";
            DosageForm1.Text = "";

            AddMedicament.Enabled = false;

            updateMedicaments();

            updateIdMedicaments();

            isNameOfMedicament1Selected = false;
            isPrice1Selected = false;
            isQuantity1Selected = false;
            isSupplier1Selected = false;
            isDosageForm1Selected = false;

            MessageBox.Show("    Медикамент добавлен!    ");
        }

        private void IdMedicament2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIdMedicament2Selected = true;
            EditMedicament.Enabled = isIdMedicament2Selected && isNameOfMedicament2Selected && isPrice2Selected
                && isQuantity2Selected && isSupplier2Selected && isDosageForm2Selected;
        }

        private void NameOfMedicament2_TextChanged(object sender, EventArgs e)
        {
            isNameOfMedicament2Selected = true;

            if (NameOfMedicament2.Text == "")
            {
                isNameOfMedicament2Selected = false;
            }

            EditMedicament.Enabled = isIdMedicament2Selected && isNameOfMedicament2Selected && isPrice2Selected
                && isQuantity2Selected && isSupplier2Selected && isDosageForm2Selected;
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
                isPrice2Selected = false;
                MessageBox.Show("    Некорректная цена!    ");
            }

            EditMedicament.Enabled = isIdMedicament2Selected && isNameOfMedicament2Selected && isPrice2Selected
                && isQuantity2Selected && isSupplier2Selected && isDosageForm2Selected;
        }

        private void Quantity2_TextChanged(object sender, EventArgs e)
        {
            isQuantity2Selected = true;

            if (String.IsNullOrEmpty(Quantity2.Text))
            {
                isQuantity2Selected = false;
            }
            if (Quantity2.Text.Contains("-") || !Quantity2.Text.All(char.IsDigit))
            {
                isQuantity2Selected = false;
                MessageBox.Show("    Некорректное количество!    ");
            }

            EditMedicament.Enabled = isIdMedicament2Selected && isNameOfMedicament2Selected && isPrice2Selected
                && isQuantity2Selected && isSupplier2Selected && isDosageForm2Selected;
        }

        private void Supplier2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSupplier2Selected = true;
            EditMedicament.Enabled = isIdMedicament2Selected && isNameOfMedicament2Selected && isPrice2Selected
                && isQuantity2Selected && isSupplier2Selected && isDosageForm2Selected;
        }

        private void DosageForm2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isDosageForm2Selected = true;
            EditMedicament.Enabled = isIdMedicament2Selected && isNameOfMedicament2Selected && isPrice2Selected
                && isQuantity2Selected && isSupplier2Selected && isDosageForm2Selected;
        }

        private void EditMedicament_Click(object sender, EventArgs e)
        {
            OleDbCommand updateMedicaments = new OleDbCommand("UPDATE Medicaments SET Name = ?, DosageForm = ?, Price = ?, " +
                "Quantity = ?, IdSupplier = ? WHERE IdMedicament = ?", cn);
            updateMedicaments.Parameters.Add("@Name", OleDbType.VarChar);
            updateMedicaments.Parameters.Add("@DosageForm", OleDbType.Integer);
            updateMedicaments.Parameters.Add("@Price", OleDbType.Integer);
            updateMedicaments.Parameters.Add("@Quantity", OleDbType.Integer);
            updateMedicaments.Parameters.Add("@IdSupplier", OleDbType.Integer);
            updateMedicaments.Parameters.Add("@IdMedicament", OleDbType.Integer);
            updateMedicaments.Parameters[0].Value = NameOfMedicament2.Text;
            updateMedicaments.Parameters[2].Value = Price2.Text;
            updateMedicaments.Parameters[3].Value = Quantity2.Text;
            updateMedicaments.Parameters[5].Value = IdMedicament2.Text;

            OleDbCommand selectIdForm = new OleDbCommand("SELECT IdForm FROM DosageForms " +
                                                "WHERE Name = ?", cn);
            selectIdForm.Parameters.Add("@Name", OleDbType.VarChar);
            selectIdForm.Parameters[0].Value = DosageForm2.Text;
            selectIdForm.ExecuteNonQuery();

            OleDbDataReader reader = selectIdForm.ExecuteReader();
            reader.Read();
            updateMedicaments.Parameters[1].Value = reader["IdForm"];
            reader.Close();

            OleDbCommand selectIdSupplier = new OleDbCommand("SELECT IdSupplier FROM Suppliers " +
                                                            "WHERE Name = ?", cn);
            selectIdSupplier.Parameters.Add("@Name", OleDbType.VarChar);
            selectIdSupplier.Parameters[0].Value = Supplier2.Text;
            selectIdSupplier.ExecuteNonQuery();

            reader = selectIdSupplier.ExecuteReader();
            reader.Read();
            updateMedicaments.Parameters[4].Value = reader["IdSupplier"];
            reader.Close();

            updateMedicaments.ExecuteNonQuery();

            IdMedicament2.Text = "";
            NameOfMedicament2.Text = "";
            Price2.Text = "";
            Quantity2.Text = "";
            Supplier2.Text = "";
            DosageForm2.Text = "";

            EditMedicament.Enabled = false;

            this.updateMedicaments();

            updateIdMedicaments();

            isNameOfMedicament2Selected = false;
            isPrice2Selected = false;
            isQuantity2Selected = false;
            isSupplier2Selected = false;
            isDosageForm2Selected = false;

            MessageBox.Show("    Медикамент отредактирован!    ");
        }
    }
}

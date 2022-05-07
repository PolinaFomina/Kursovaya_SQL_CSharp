using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovaya_Polina
{
    public partial class SuppliersEditing : Form
    {
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;

        private bool isIdSupplier2Selected;
        private bool isNameOfSupplier2Selected;

        public SuppliersEditing()
        {
            InitializeComponent();

            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursovaya_Polina; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable Suppliers;
            Suppliers = dSet.Tables.Add("Suppliers");
            Suppliers.Columns.Add("IdSupplier", typeof(int));
            Suppliers.Columns.Add("Name", typeof(string));

            dgSuppliers.SetDataBinding(dSet, "Suppliers");

            OleDbCommand selectSuppliers = new OleDbCommand("SELECT IdSupplier, Name FROM Suppliers", cn);

            selectSuppliers.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectSuppliers;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Suppliers");

            OleDbDataReader reader = selectSuppliers.ExecuteReader();
            while (reader.Read())
            {
                IdSupplier1.Items.Add(reader["IdSupplier"]);
                IdSupplier2.Items.Add(reader["IdSupplier"]);
            }
            reader.Close();

            DeleteSupplier.Enabled = false;
            AddSupplier.Enabled = false;
            EditSupplier.Enabled = false;

            isIdSupplier2Selected = false;
            isNameOfSupplier2Selected = false;
        }

        private void SuppliersEditing_Load(object sender, EventArgs e)
        {

        }

        private void updateIdSuppliers()
        {
            OleDbCommand selectIdSuppliers = new OleDbCommand("SELECT IdSupplier FROM Suppliers", cn);
            selectIdSuppliers.ExecuteNonQuery();

            OleDbDataReader reader = selectIdSuppliers.ExecuteReader();
            IdSupplier1.Items.Clear();
            IdSupplier2.Items.Clear();
            while (reader.Read())
            {
                IdSupplier1.Items.Add(reader["IdSupplier"]);
                IdSupplier2.Items.Add(reader["IdSupplier"]);
            }
            reader.Close();
        }

        private void updateSuppliers()
        {
            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Suppliers");
        }

        private void IdSupplier1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteSupplier.Enabled = true;
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            OleDbCommand deleteSupplier = new OleDbCommand("DELETE FROM Suppliers WHERE IdSupplier = ?", cn);
            deleteSupplier.Parameters.Add("@IdSupplier", OleDbType.Integer);
            deleteSupplier.Parameters[0].Value = IdSupplier1.SelectedItem;

            deleteSupplier.ExecuteNonQuery();
            IdSupplier1.Text = "";
            DeleteSupplier.Enabled = false;
            updateSuppliers();
            updateIdSuppliers();
            MessageBox.Show("    Поставщик удален!    ");
        }

        private void NameOfSupplier1_TextChanged(object sender, EventArgs e)
        {
            AddSupplier.Enabled = false;

            if (!String.IsNullOrEmpty(NameOfSupplier1.Text))
            {
                AddSupplier.Enabled = true;
            }
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            OleDbCommand insertIntoSuppliers = new OleDbCommand("INSERT INTO Suppliers (Name) VALUES (?)", cn);
            insertIntoSuppliers.Parameters.Add("@Name", OleDbType.VarChar);
            insertIntoSuppliers.Parameters[0].Value = NameOfSupplier1.Text;
            insertIntoSuppliers.ExecuteNonQuery();

            NameOfSupplier1.Text = "";

            AddSupplier.Enabled = false;

            updateSuppliers();

            updateIdSuppliers();

            MessageBox.Show("    Поставщик добавлен!    ");
        }

        private void IdSupplier2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isIdSupplier2Selected = true;
            EditSupplier.Enabled = isIdSupplier2Selected && isNameOfSupplier2Selected;
        }

        private void NameOfSupplier2_TextChanged(object sender, EventArgs e)
        {
            isNameOfSupplier2Selected = true;

            if (String.IsNullOrEmpty(NameOfSupplier2.Text))
            {
                isNameOfSupplier2Selected = false;
            }

            EditSupplier.Enabled = isIdSupplier2Selected && isNameOfSupplier2Selected;
        }

        private void EditSupplier_Click(object sender, EventArgs e)
        {
            OleDbCommand updateSuppliers = new OleDbCommand("UPDATE Suppliers SET Name = ? WHERE IdSupplier = ?", cn);
            updateSuppliers.Parameters.Add("@Name", OleDbType.VarChar);
            updateSuppliers.Parameters.Add("@IdSupplier", OleDbType.Integer);
            updateSuppliers.Parameters[0].Value = NameOfSupplier2.Text;
            updateSuppliers.Parameters[1].Value = IdSupplier2.SelectedItem;
            updateSuppliers.ExecuteNonQuery();

            IdSupplier2.Text = "";
            NameOfSupplier2.Text = "";

            EditSupplier.Enabled = false;

            this.updateSuppliers();

            isIdSupplier2Selected = false;
            isNameOfSupplier2Selected = false;

            MessageBox.Show("    Поставщик отредактирован!    ");
        }
    }
}


namespace Kursovaya_Polina
{
    partial class MedicamentsEditing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditMedicament = new System.Windows.Forms.Button();
            this.Price2 = new System.Windows.Forms.TextBox();
            this.NameOfMedicament2 = new System.Windows.Forms.TextBox();
            this.IdMedicament2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddMedicament = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgMedicaments = new System.Windows.Forms.DataGrid();
            this.DeleteMedicament = new System.Windows.Forms.Button();
            this.IdMedicament1 = new System.Windows.Forms.ComboBox();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.NameOfMedicament1 = new System.Windows.Forms.TextBox();
            this.DosageForm1 = new System.Windows.Forms.ComboBox();
            this.Price1 = new System.Windows.Forms.TextBox();
            this.Quantity1 = new System.Windows.Forms.TextBox();
            this.Supplier1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DosageForm2 = new System.Windows.Forms.ComboBox();
            this.Supplier2 = new System.Windows.Forms.ComboBox();
            this.Quantity2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicaments)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 76;
            this.label12.Text = "Цена";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Количество";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(625, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Форма выпуска";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Форма выпуска";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Наименование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Наименование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "ID медикамента";
            // 
            // EditMedicament
            // 
            this.EditMedicament.Location = new System.Drawing.Point(693, 333);
            this.EditMedicament.Name = "EditMedicament";
            this.EditMedicament.Size = new System.Drawing.Size(95, 36);
            this.EditMedicament.TabIndex = 68;
            this.EditMedicament.Text = "Редактировать медикамент";
            this.EditMedicament.UseVisualStyleBackColor = true;
            this.EditMedicament.Click += new System.EventHandler(this.EditMedicament_Click);
            // 
            // Price2
            // 
            this.Price2.Location = new System.Drawing.Point(533, 359);
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(140, 20);
            this.Price2.TabIndex = 67;
            this.Price2.TextChanged += new System.EventHandler(this.Price2_TextChanged);
            // 
            // NameOfMedicament2
            // 
            this.NameOfMedicament2.Location = new System.Drawing.Point(533, 330);
            this.NameOfMedicament2.Name = "NameOfMedicament2";
            this.NameOfMedicament2.Size = new System.Drawing.Size(140, 20);
            this.NameOfMedicament2.TabIndex = 66;
            this.NameOfMedicament2.TextChanged += new System.EventHandler(this.NameOfMedicament2_TextChanged);
            // 
            // IdMedicament2
            // 
            this.IdMedicament2.FormattingEnabled = true;
            this.IdMedicament2.Location = new System.Drawing.Point(533, 301);
            this.IdMedicament2.Name = "IdMedicament2";
            this.IdMedicament2.Size = new System.Drawing.Size(67, 21);
            this.IdMedicament2.TabIndex = 65;
            this.IdMedicament2.SelectedIndexChanged += new System.EventHandler(this.IdMedicament2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(434, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "Редактирование медикамента";
            // 
            // AddMedicament
            // 
            this.AddMedicament.Location = new System.Drawing.Point(693, 151);
            this.AddMedicament.Name = "AddMedicament";
            this.AddMedicament.Size = new System.Drawing.Size(95, 36);
            this.AddMedicament.TabIndex = 63;
            this.AddMedicament.Text = "Добавить медикамент";
            this.AddMedicament.UseVisualStyleBackColor = true;
            this.AddMedicament.Click += new System.EventHandler(this.AddMedicament_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(434, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 18);
            this.label2.TabIndex = 61;
            this.label2.Text = "Добавление медикамента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Удаление медикамента";
            // 
            // dgMedicaments
            // 
            this.dgMedicaments.DataMember = "";
            this.dgMedicaments.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgMedicaments.Location = new System.Drawing.Point(2, 2);
            this.dgMedicaments.Name = "dgMedicaments";
            this.dgMedicaments.Size = new System.Drawing.Size(404, 446);
            this.dgMedicaments.TabIndex = 59;
            // 
            // DeleteMedicament
            // 
            this.DeleteMedicament.Location = new System.Drawing.Point(693, 38);
            this.DeleteMedicament.Name = "DeleteMedicament";
            this.DeleteMedicament.Size = new System.Drawing.Size(95, 36);
            this.DeleteMedicament.TabIndex = 58;
            this.DeleteMedicament.Text = "Удалить медикамент";
            this.DeleteMedicament.UseVisualStyleBackColor = true;
            this.DeleteMedicament.Click += new System.EventHandler(this.DeleteMedicament_Click);
            // 
            // IdMedicament1
            // 
            this.IdMedicament1.FormattingEnabled = true;
            this.IdMedicament1.Location = new System.Drawing.Point(533, 44);
            this.IdMedicament1.Name = "IdMedicament1";
            this.IdMedicament1.Size = new System.Drawing.Size(67, 21);
            this.IdMedicament1.TabIndex = 57;
            this.IdMedicament1.SelectedIndexChanged += new System.EventHandler(this.IdMedicament1_SelectedIndexChanged);
            // 
            // NameOfMedicament1
            // 
            this.NameOfMedicament1.Location = new System.Drawing.Point(533, 131);
            this.NameOfMedicament1.Name = "NameOfMedicament1";
            this.NameOfMedicament1.Size = new System.Drawing.Size(140, 20);
            this.NameOfMedicament1.TabIndex = 78;
            this.NameOfMedicament1.TextChanged += new System.EventHandler(this.NameOfMedicament1_TextChanged);
            // 
            // DosageForm1
            // 
            this.DosageForm1.FormattingEnabled = true;
            this.DosageForm1.Location = new System.Drawing.Point(721, 218);
            this.DosageForm1.Name = "DosageForm1";
            this.DosageForm1.Size = new System.Drawing.Size(67, 21);
            this.DosageForm1.TabIndex = 79;
            this.DosageForm1.SelectedIndexChanged += new System.EventHandler(this.DosageForm1_SelectedIndexChanged);
            // 
            // Price1
            // 
            this.Price1.Location = new System.Drawing.Point(533, 160);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(140, 20);
            this.Price1.TabIndex = 80;
            this.Price1.TextChanged += new System.EventHandler(this.Price1_TextChanged);
            // 
            // Quantity1
            // 
            this.Quantity1.Location = new System.Drawing.Point(533, 189);
            this.Quantity1.Name = "Quantity1";
            this.Quantity1.Size = new System.Drawing.Size(140, 20);
            this.Quantity1.TabIndex = 81;
            this.Quantity1.TextChanged += new System.EventHandler(this.Quantity1_TextChanged);
            // 
            // Supplier1
            // 
            this.Supplier1.FormattingEnabled = true;
            this.Supplier1.Location = new System.Drawing.Point(533, 218);
            this.Supplier1.Name = "Supplier1";
            this.Supplier1.Size = new System.Drawing.Size(68, 21);
            this.Supplier1.TabIndex = 82;
            this.Supplier1.SelectedIndexChanged += new System.EventHandler(this.Supplier1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Цена";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Количество";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(434, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 85;
            this.label13.Text = "Поставщик";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(434, 417);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 86;
            this.label14.Text = "Поставщик";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(434, 301);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 87;
            this.label15.Text = "ID медикамента";
            // 
            // DosageForm2
            // 
            this.DosageForm2.FormattingEnabled = true;
            this.DosageForm2.Location = new System.Drawing.Point(721, 417);
            this.DosageForm2.Name = "DosageForm2";
            this.DosageForm2.Size = new System.Drawing.Size(67, 21);
            this.DosageForm2.TabIndex = 88;
            this.DosageForm2.SelectedIndexChanged += new System.EventHandler(this.DosageForm2_SelectedIndexChanged);
            // 
            // Supplier2
            // 
            this.Supplier2.FormattingEnabled = true;
            this.Supplier2.Location = new System.Drawing.Point(533, 417);
            this.Supplier2.Name = "Supplier2";
            this.Supplier2.Size = new System.Drawing.Size(67, 21);
            this.Supplier2.TabIndex = 89;
            this.Supplier2.SelectedIndexChanged += new System.EventHandler(this.Supplier2_SelectedIndexChanged);
            // 
            // Quantity2
            // 
            this.Quantity2.Location = new System.Drawing.Point(533, 388);
            this.Quantity2.Name = "Quantity2";
            this.Quantity2.Size = new System.Drawing.Size(140, 20);
            this.Quantity2.TabIndex = 90;
            this.Quantity2.TextChanged += new System.EventHandler(this.Quantity2_TextChanged);
            // 
            // MedicamentsEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quantity2);
            this.Controls.Add(this.Supplier2);
            this.Controls.Add(this.DosageForm2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Supplier1);
            this.Controls.Add(this.Quantity1);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.DosageForm1);
            this.Controls.Add(this.NameOfMedicament1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditMedicament);
            this.Controls.Add(this.Price2);
            this.Controls.Add(this.NameOfMedicament2);
            this.Controls.Add(this.IdMedicament2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddMedicament);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMedicaments);
            this.Controls.Add(this.DeleteMedicament);
            this.Controls.Add(this.IdMedicament1);
            this.Name = "MedicamentsEditing";
            this.Text = "MedicamentsEditing";
            this.Load += new System.EventHandler(this.MedicamentsEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicaments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditMedicament;
        private System.Windows.Forms.TextBox Price2;
        private System.Windows.Forms.TextBox NameOfMedicament2;
        private System.Windows.Forms.ComboBox IdMedicament2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddMedicament;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dgMedicaments;
        private System.Windows.Forms.Button DeleteMedicament;
        private System.Windows.Forms.ComboBox IdMedicament1;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.TextBox NameOfMedicament1;
        private System.Windows.Forms.ComboBox DosageForm1;
        private System.Windows.Forms.TextBox Price1;
        private System.Windows.Forms.TextBox Quantity1;
        private System.Windows.Forms.ComboBox Supplier1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox DosageForm2;
        private System.Windows.Forms.ComboBox Supplier2;
        private System.Windows.Forms.TextBox Quantity2;
    }
}
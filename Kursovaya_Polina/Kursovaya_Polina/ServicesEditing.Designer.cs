
namespace Kursovaya_Polina
{
    partial class ServicesEditing
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditService = new System.Windows.Forms.Button();
            this.Price2 = new System.Windows.Forms.TextBox();
            this.NameOfService2 = new System.Windows.Forms.TextBox();
            this.IdService2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameOfSpecialization = new System.Windows.Forms.TextBox();
            this.dgServices = new System.Windows.Forms.DataGrid();
            this.DeleteService = new System.Windows.Forms.Button();
            this.IdService1 = new System.Windows.Forms.ComboBox();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.NameOfDoctor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameOfService1 = new System.Windows.Forms.TextBox();
            this.Price1 = new System.Windows.Forms.TextBox();
            this.Doctors = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Стоимость";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Наименование";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Стоимость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Наименование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "ID услуги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "ID услуги";
            // 
            // EditService
            // 
            this.EditService.Location = new System.Drawing.Point(693, 358);
            this.EditService.Name = "EditService";
            this.EditService.Size = new System.Drawing.Size(95, 36);
            this.EditService.TabIndex = 43;
            this.EditService.Text = "Редактировать услугу";
            this.EditService.UseVisualStyleBackColor = true;
            this.EditService.Click += new System.EventHandler(this.EditService_Click);
            // 
            // Price2
            // 
            this.Price2.Location = new System.Drawing.Point(533, 402);
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(140, 20);
            this.Price2.TabIndex = 42;
            this.Price2.TextChanged += new System.EventHandler(this.Price2_TextChanged);
            // 
            // NameOfService2
            // 
            this.NameOfService2.Location = new System.Drawing.Point(533, 370);
            this.NameOfService2.Name = "NameOfService2";
            this.NameOfService2.Size = new System.Drawing.Size(140, 20);
            this.NameOfService2.TabIndex = 41;
            this.NameOfService2.TextChanged += new System.EventHandler(this.NameOfSpecialization2_TextChanged);
            // 
            // IdService2
            // 
            this.IdService2.FormattingEnabled = true;
            this.IdService2.Location = new System.Drawing.Point(533, 338);
            this.IdService2.Name = "IdService2";
            this.IdService2.Size = new System.Drawing.Size(67, 21);
            this.IdService2.TabIndex = 40;
            this.IdService2.SelectedIndexChanged += new System.EventHandler(this.IdService2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(434, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Редактирование услуги";
            // 
            // AddService
            // 
            this.AddService.Location = new System.Drawing.Point(693, 161);
            this.AddService.Name = "AddService";
            this.AddService.Size = new System.Drawing.Size(95, 36);
            this.AddService.TabIndex = 38;
            this.AddService.Text = "Добавить услугу";
            this.AddService.UseVisualStyleBackColor = true;
            this.AddService.Click += new System.EventHandler(this.AddService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(434, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Добавление услуги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Удаление услуги";
            // 
            // NameOfSpecialization
            // 
            this.NameOfSpecialization.Location = new System.Drawing.Point(12, 39);
            this.NameOfSpecialization.Name = "NameOfSpecialization";
            this.NameOfSpecialization.Size = new System.Drawing.Size(259, 20);
            this.NameOfSpecialization.TabIndex = 34;
            // 
            // dgServices
            // 
            this.dgServices.DataMember = "";
            this.dgServices.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgServices.Location = new System.Drawing.Point(2, 114);
            this.dgServices.Name = "dgServices";
            this.dgServices.Size = new System.Drawing.Size(404, 335);
            this.dgServices.TabIndex = 33;
            // 
            // DeleteService
            // 
            this.DeleteService.Location = new System.Drawing.Point(693, 53);
            this.DeleteService.Name = "DeleteService";
            this.DeleteService.Size = new System.Drawing.Size(95, 36);
            this.DeleteService.TabIndex = 32;
            this.DeleteService.Text = "Удалить услугу";
            this.DeleteService.UseVisualStyleBackColor = true;
            this.DeleteService.Click += new System.EventHandler(this.DeleteService_Click);
            // 
            // IdService1
            // 
            this.IdService1.FormattingEnabled = true;
            this.IdService1.Location = new System.Drawing.Point(533, 61);
            this.IdService1.Name = "IdService1";
            this.IdService1.Size = new System.Drawing.Size(67, 21);
            this.IdService1.TabIndex = 31;
            this.IdService1.SelectedIndexChanged += new System.EventHandler(this.IdService1_SelectedIndexChanged);
            // 
            // NameOfDoctor
            // 
            this.NameOfDoctor.Location = new System.Drawing.Point(12, 81);
            this.NameOfDoctor.Name = "NameOfDoctor";
            this.NameOfDoctor.Size = new System.Drawing.Size(259, 20);
            this.NameOfDoctor.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Специализация";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Врач";
            // 
            // NameOfService1
            // 
            this.NameOfService1.Location = new System.Drawing.Point(533, 152);
            this.NameOfService1.Name = "NameOfService1";
            this.NameOfService1.Size = new System.Drawing.Size(140, 20);
            this.NameOfService1.TabIndex = 56;
            this.NameOfService1.TextChanged += new System.EventHandler(this.NameOfSpecialization1_TextChanged);
            // 
            // Price1
            // 
            this.Price1.Location = new System.Drawing.Point(533, 184);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(140, 20);
            this.Price1.TabIndex = 57;
            this.Price1.TextChanged += new System.EventHandler(this.Price1_TextChanged);
            // 
            // Doctors
            // 
            this.Doctors.CheckOnClick = true;
            this.Doctors.FormattingEnabled = true;
            this.Doctors.Location = new System.Drawing.Point(533, 216);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(255, 49);
            this.Doctors.TabIndex = 58;
            this.Doctors.SelectedIndexChanged += new System.EventHandler(this.Doctors_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Врачи";
            // 
            // ServicesEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Doctors);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.NameOfService1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NameOfDoctor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditService);
            this.Controls.Add(this.Price2);
            this.Controls.Add(this.NameOfService2);
            this.Controls.Add(this.IdService2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOfSpecialization);
            this.Controls.Add(this.dgServices);
            this.Controls.Add(this.DeleteService);
            this.Controls.Add(this.IdService1);
            this.Name = "ServicesEditing";
            this.Text = "ServicesEditing";
            this.Load += new System.EventHandler(this.ServicesEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditService;
        private System.Windows.Forms.TextBox Price2;
        private System.Windows.Forms.TextBox NameOfService2;
        private System.Windows.Forms.ComboBox IdService2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameOfSpecialization;
        private System.Windows.Forms.DataGrid dgServices;
        private System.Windows.Forms.Button DeleteService;
        private System.Windows.Forms.ComboBox IdService1;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.TextBox NameOfDoctor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameOfService1;
        private System.Windows.Forms.TextBox Price1;
        private System.Windows.Forms.CheckedListBox Doctors;
        private System.Windows.Forms.Label label12;
    }
}

namespace Kursovaya_Polina
{
    partial class SceduleEditing
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
            this.IdAppointment1 = new System.Windows.Forms.ComboBox();
            this.DeleteAppointment = new System.Windows.Forms.Button();
            this.dgSchedule = new System.Windows.Forms.DataGrid();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateOfAppointment = new System.Windows.Forms.DateTimePicker();
            this.AddAppointment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IdAppointment2 = new System.Windows.Forms.ComboBox();
            this.FioOfPatient = new System.Windows.Forms.TextBox();
            this.EditAppointment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeOfAppointment = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Birthdate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.NameOfDoctor = new System.Windows.Forms.TextBox();
            this.PhoneNumberOfPatient = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // IdAppointment1
            // 
            this.IdAppointment1.FormattingEnabled = true;
            this.IdAppointment1.Location = new System.Drawing.Point(533, 62);
            this.IdAppointment1.Name = "IdAppointment1";
            this.IdAppointment1.Size = new System.Drawing.Size(67, 21);
            this.IdAppointment1.TabIndex = 5;
            this.IdAppointment1.SelectedIndexChanged += new System.EventHandler(this.IdAppointment1_SelectedIndexChanged);
            // 
            // DeleteAppointment
            // 
            this.DeleteAppointment.Location = new System.Drawing.Point(693, 53);
            this.DeleteAppointment.Name = "DeleteAppointment";
            this.DeleteAppointment.Size = new System.Drawing.Size(95, 36);
            this.DeleteAppointment.TabIndex = 6;
            this.DeleteAppointment.Text = "Удалить приём";
            this.DeleteAppointment.UseVisualStyleBackColor = true;
            this.DeleteAppointment.Click += new System.EventHandler(this.DeleteAppointment_Click);
            // 
            // dgSchedule
            // 
            this.dgSchedule.DataMember = "";
            this.dgSchedule.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSchedule.Location = new System.Drawing.Point(2, 72);
            this.dgSchedule.Name = "dgSchedule";
            this.dgSchedule.Size = new System.Drawing.Size(404, 376);
            this.dgSchedule.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Удаление приёма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(434, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Добавление приёма";
            // 
            // DateOfAppointment
            // 
            this.DateOfAppointment.Location = new System.Drawing.Point(533, 172);
            this.DateOfAppointment.Name = "DateOfAppointment";
            this.DateOfAppointment.Size = new System.Drawing.Size(140, 20);
            this.DateOfAppointment.TabIndex = 11;
            this.DateOfAppointment.ValueChanged += new System.EventHandler(this.DateOfAppointment_ValueChanged);
            // 
            // AddAppointment
            // 
            this.AddAppointment.Location = new System.Drawing.Point(693, 180);
            this.AddAppointment.Name = "AddAppointment";
            this.AddAppointment.Size = new System.Drawing.Size(95, 36);
            this.AddAppointment.TabIndex = 14;
            this.AddAppointment.Text = "Добавить приём";
            this.AddAppointment.UseVisualStyleBackColor = true;
            this.AddAppointment.Click += new System.EventHandler(this.AddAppointment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(434, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Редактирование приёма";
            // 
            // IdAppointment2
            // 
            this.IdAppointment2.FormattingEnabled = true;
            this.IdAppointment2.Location = new System.Drawing.Point(533, 298);
            this.IdAppointment2.Name = "IdAppointment2";
            this.IdAppointment2.Size = new System.Drawing.Size(67, 21);
            this.IdAppointment2.TabIndex = 16;
            this.IdAppointment2.SelectedIndexChanged += new System.EventHandler(this.IdAppointment2_SelectedIndexChanged);
            // 
            // FioOfPatient
            // 
            this.FioOfPatient.Location = new System.Drawing.Point(533, 327);
            this.FioOfPatient.Name = "FioOfPatient";
            this.FioOfPatient.Size = new System.Drawing.Size(140, 20);
            this.FioOfPatient.TabIndex = 17;
            this.FioOfPatient.TextChanged += new System.EventHandler(this.FioOfPatient_TextChanged);
            // 
            // EditAppointment
            // 
            this.EditAppointment.Location = new System.Drawing.Point(693, 333);
            this.EditAppointment.Name = "EditAppointment";
            this.EditAppointment.Size = new System.Drawing.Size(95, 36);
            this.EditAppointment.TabIndex = 19;
            this.EditAppointment.Text = "Редактировать приём";
            this.EditAppointment.UseVisualStyleBackColor = true;
            this.EditAppointment.Click += new System.EventHandler(this.EditAppointment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID приёма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID приёма";
            // 
            // TimeOfAppointment
            // 
            this.TimeOfAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeOfAppointment.Location = new System.Drawing.Point(533, 203);
            this.TimeOfAppointment.Name = "TimeOfAppointment";
            this.TimeOfAppointment.ShowUpDown = true;
            this.TimeOfAppointment.Size = new System.Drawing.Size(140, 20);
            this.TimeOfAppointment.TabIndex = 22;
            this.TimeOfAppointment.ValueChanged += new System.EventHandler(this.TimeOfAppointment_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Дата приёма";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Время приёма";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "ФИО пациента";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Номер телефона";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Дата рождения";
            // 
            // Birthdate
            // 
            this.Birthdate.Location = new System.Drawing.Point(533, 356);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(140, 20);
            this.Birthdate.TabIndex = 30;
            this.Birthdate.ValueChanged += new System.EventHandler(this.Birthdate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Врач";
            // 
            // NameOfDoctor
            // 
            this.NameOfDoctor.Location = new System.Drawing.Point(12, 39);
            this.NameOfDoctor.Name = "NameOfDoctor";
            this.NameOfDoctor.Size = new System.Drawing.Size(259, 20);
            this.NameOfDoctor.TabIndex = 55;
            // 
            // PhoneNumberOfPatient
            // 
            this.PhoneNumberOfPatient.Location = new System.Drawing.Point(533, 383);
            this.PhoneNumberOfPatient.Mask = "80000000000";
            this.PhoneNumberOfPatient.Name = "PhoneNumberOfPatient";
            this.PhoneNumberOfPatient.PromptChar = ' ';
            this.PhoneNumberOfPatient.Size = new System.Drawing.Size(140, 20);
            this.PhoneNumberOfPatient.TabIndex = 57;
            this.PhoneNumberOfPatient.TextChanged += new System.EventHandler(this.PhoneNumberOfPatient_TextChanged);
            // 
            // SceduleEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PhoneNumberOfPatient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NameOfDoctor);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimeOfAppointment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditAppointment);
            this.Controls.Add(this.FioOfPatient);
            this.Controls.Add(this.IdAppointment2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddAppointment);
            this.Controls.Add(this.DateOfAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgSchedule);
            this.Controls.Add(this.DeleteAppointment);
            this.Controls.Add(this.IdAppointment1);
            this.Name = "SceduleEditing";
            this.Text = "SceduleEditing";
            this.Load += new System.EventHandler(this.SceduleEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox IdAppointment1;
        private System.Windows.Forms.Button DeleteAppointment;
        private System.Windows.Forms.DataGrid dgSchedule;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateOfAppointment;
        private System.Windows.Forms.Button AddAppointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IdAppointment2;
        private System.Windows.Forms.Button EditAppointment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TimeOfAppointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker Birthdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameOfDoctor;
        private System.Windows.Forms.TextBox FioOfPatient;
        private System.Windows.Forms.MaskedTextBox PhoneNumberOfPatient;
    }
}
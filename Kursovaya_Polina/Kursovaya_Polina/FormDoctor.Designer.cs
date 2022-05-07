
namespace Kursovaya_Polina
{
    partial class FormDoctor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ShowSchedule = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgSchedule = new System.Windows.Forms.DataGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgMedicaments = new System.Windows.Forms.DataGrid();
            this.ShowMedicaments = new System.Windows.Forms.Button();
            this.DosageForms = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Diagnoses = new System.Windows.Forms.CheckedListBox();
            this.SaveInfoAboutAppointment = new System.Windows.Forms.Button();
            this.Recommendations = new System.Windows.Forms.TextBox();
            this.Complaints = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeOfAppointment = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DateOfAppointment = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FioOfDoctor = new System.Windows.Forms.TextBox();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.label10 = new System.Windows.Forms.Label();
            this.Medicaments = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicaments)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ShowSchedule);
            this.tabPage1.Controls.Add(this.Date);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgSchedule);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ShowSchedule
            // 
            this.ShowSchedule.Location = new System.Drawing.Point(302, 13);
            this.ShowSchedule.Name = "ShowSchedule";
            this.ShowSchedule.Size = new System.Drawing.Size(128, 31);
            this.ShowSchedule.TabIndex = 3;
            this.ShowSchedule.Text = "Показать расписание";
            this.ShowSchedule.UseVisualStyleBackColor = true;
            this.ShowSchedule.Click += new System.EventHandler(this.ShowSchedule_Click);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(73, 18);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 2;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // dgSchedule
            // 
            this.dgSchedule.DataMember = "";
            this.dgSchedule.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSchedule.Location = new System.Drawing.Point(0, 55);
            this.dgSchedule.Name = "dgSchedule";
            this.dgSchedule.Size = new System.Drawing.Size(793, 323);
            this.dgSchedule.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgMedicaments);
            this.tabPage2.Controls.Add(this.ShowMedicaments);
            this.tabPage2.Controls.Add(this.DosageForms);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Медикаменты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgMedicaments
            // 
            this.dgMedicaments.DataMember = "";
            this.dgMedicaments.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgMedicaments.Location = new System.Drawing.Point(0, 152);
            this.dgMedicaments.Name = "dgMedicaments";
            this.dgMedicaments.Size = new System.Drawing.Size(793, 226);
            this.dgMedicaments.TabIndex = 16;
            // 
            // ShowMedicaments
            // 
            this.ShowMedicaments.Location = new System.Drawing.Point(251, 59);
            this.ShowMedicaments.Name = "ShowMedicaments";
            this.ShowMedicaments.Size = new System.Drawing.Size(103, 39);
            this.ShowMedicaments.TabIndex = 15;
            this.ShowMedicaments.Text = "Показать список медикаментов";
            this.ShowMedicaments.UseVisualStyleBackColor = true;
            this.ShowMedicaments.Click += new System.EventHandler(this.ShowMedicaments_Click);
            // 
            // DosageForms
            // 
            this.DosageForms.FormattingEnabled = true;
            this.DosageForms.Location = new System.Drawing.Point(53, 69);
            this.DosageForms.Name = "DosageForms";
            this.DosageForms.Size = new System.Drawing.Size(121, 21);
            this.DosageForms.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Форма выпуска";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Medicaments);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.Diagnoses);
            this.tabPage3.Controls.Add(this.SaveInfoAboutAppointment);
            this.tabPage3.Controls.Add(this.Recommendations);
            this.tabPage3.Controls.Add(this.Complaints);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.FIO);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.TimeOfAppointment);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.DateOfAppointment);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(793, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заполненение приёма";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Diagnoses
            // 
            this.Diagnoses.CheckOnClick = true;
            this.Diagnoses.FormattingEnabled = true;
            this.Diagnoses.Location = new System.Drawing.Point(142, 197);
            this.Diagnoses.Name = "Diagnoses";
            this.Diagnoses.Size = new System.Drawing.Size(236, 109);
            this.Diagnoses.TabIndex = 14;
            this.Diagnoses.SelectedIndexChanged += new System.EventHandler(this.Diagnoses_SelectedIndexChanged);
            // 
            // SaveInfoAboutAppointment
            // 
            this.SaveInfoAboutAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveInfoAboutAppointment.Location = new System.Drawing.Point(511, 54);
            this.SaveInfoAboutAppointment.Name = "SaveInfoAboutAppointment";
            this.SaveInfoAboutAppointment.Size = new System.Drawing.Size(92, 36);
            this.SaveInfoAboutAppointment.TabIndex = 12;
            this.SaveInfoAboutAppointment.Text = "Сохранить";
            this.SaveInfoAboutAppointment.UseVisualStyleBackColor = true;
            this.SaveInfoAboutAppointment.Click += new System.EventHandler(this.SaveInfoAboutAppointment_Click);
            // 
            // Recommendations
            // 
            this.Recommendations.Location = new System.Drawing.Point(142, 324);
            this.Recommendations.Name = "Recommendations";
            this.Recommendations.Size = new System.Drawing.Size(610, 20);
            this.Recommendations.TabIndex = 11;
            this.Recommendations.TextChanged += new System.EventHandler(this.Recommendations_TextChanged);
            // 
            // Complaints
            // 
            this.Complaints.Location = new System.Drawing.Point(142, 157);
            this.Complaints.Name = "Complaints";
            this.Complaints.Size = new System.Drawing.Size(610, 20);
            this.Complaints.TabIndex = 9;
            this.Complaints.TextChanged += new System.EventHandler(this.Complaints_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Рекомендации";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Диагноз";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Жалобы";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(142, 117);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(610, 20);
            this.FIO.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "ФИО пациента";
            // 
            // TimeOfAppointment
            // 
            this.TimeOfAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeOfAppointment.Location = new System.Drawing.Point(142, 77);
            this.TimeOfAppointment.Name = "TimeOfAppointment";
            this.TimeOfAppointment.ShowUpDown = true;
            this.TimeOfAppointment.Size = new System.Drawing.Size(200, 20);
            this.TimeOfAppointment.TabIndex = 3;
            this.TimeOfAppointment.ValueChanged += new System.EventHandler(this.TimeOfAppointment_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Время";
            // 
            // DateOfAppointment
            // 
            this.DateOfAppointment.Location = new System.Drawing.Point(142, 37);
            this.DateOfAppointment.Name = "DateOfAppointment";
            this.DateOfAppointment.Size = new System.Drawing.Size(200, 20);
            this.DateOfAppointment.TabIndex = 1;
            this.DateOfAppointment.ValueChanged += new System.EventHandler(this.DateOfAppointment_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // FioOfDoctor
            // 
            this.FioOfDoctor.Location = new System.Drawing.Point(76, 13);
            this.FioOfDoctor.Name = "FioOfDoctor";
            this.FioOfDoctor.Size = new System.Drawing.Size(305, 20);
            this.FioOfDoctor.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Лекарства";
            // 
            // Medicaments
            // 
            this.Medicaments.CheckOnClick = true;
            this.Medicaments.FormattingEnabled = true;
            this.Medicaments.Location = new System.Drawing.Point(516, 197);
            this.Medicaments.Name = "Medicaments";
            this.Medicaments.Size = new System.Drawing.Size(236, 109);
            this.Medicaments.TabIndex = 16;
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FioOfDoctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDoctor";
            this.Text = "FormDoctor";
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicaments)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FioOfDoctor;
        private System.Windows.Forms.DataGrid dgSchedule;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button ShowSchedule;
        private System.Windows.Forms.DataGrid dgMedicaments;
        private System.Windows.Forms.Button ShowMedicaments;
        private System.Windows.Forms.ComboBox DosageForms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker TimeOfAppointment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateOfAppointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveInfoAboutAppointment;
        private System.Windows.Forms.TextBox Recommendations;
        private System.Windows.Forms.TextBox Complaints;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox Diagnoses;
        private System.Windows.Forms.CheckedListBox Medicaments;
        private System.Windows.Forms.Label label10;
    }
}
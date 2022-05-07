
namespace Kursovaya_Polina
{
    partial class FormAdmin
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
            this.EditSchedule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgSchedule = new System.Windows.Forms.DataGrid();
            this.ShowSchedule = new System.Windows.Forms.Button();
            this.Doctors1 = new System.Windows.Forms.ComboBox();
            this.Specializations1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgServices = new System.Windows.Forms.DataGrid();
            this.EditServices = new System.Windows.Forms.Button();
            this.ShowServices = new System.Windows.Forms.Button();
            this.Doctors2 = new System.Windows.Forms.ComboBox();
            this.Specializations2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgMedicaments = new System.Windows.Forms.DataGrid();
            this.EditMedicaments = new System.Windows.Forms.Button();
            this.ShowMedicaments = new System.Windows.Forms.Button();
            this.DosageForms = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.EditDoctors = new System.Windows.Forms.Button();
            this.ShowDoctors = new System.Windows.Forms.Button();
            this.dgDoctors = new System.Windows.Forms.DataGrid();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.EditSpecializations = new System.Windows.Forms.Button();
            this.ShowSpecializations = new System.Windows.Forms.Button();
            this.dgSpecializations = new System.Windows.Forms.DataGrid();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.EditAdministrators = new System.Windows.Forms.Button();
            this.ShowAdministrators = new System.Windows.Forms.Button();
            this.dgAdministrators = new System.Windows.Forms.DataGrid();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.EditDiagnoses = new System.Windows.Forms.Button();
            this.ShowDiagnoses = new System.Windows.Forms.Button();
            this.dgDiagnoses = new System.Windows.Forms.DataGrid();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.EditSuppliers = new System.Windows.Forms.Button();
            this.ShowSuppliers = new System.Windows.Forms.Button();
            this.dgSuppliers = new System.Windows.Forms.DataGrid();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.label6 = new System.Windows.Forms.Label();
            this.FioOfAdministrator = new System.Windows.Forms.TextBox();
            this.EditUsers = new System.Windows.Forms.Button();
            this.ShowUsers = new System.Windows.Forms.Button();
            this.dgUsers = new System.Windows.Forms.DataGrid();
            this.TypeUsers = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicaments)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSpecializations)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdministrators)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnoses)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Location = new System.Drawing.Point(-1, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EditSchedule);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgSchedule);
            this.tabPage1.Controls.Add(this.ShowSchedule);
            this.tabPage1.Controls.Add(this.Doctors1);
            this.tabPage1.Controls.Add(this.Specializations1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EditSchedule
            // 
            this.EditSchedule.Location = new System.Drawing.Point(564, 59);
            this.EditSchedule.Name = "EditSchedule";
            this.EditSchedule.Size = new System.Drawing.Size(93, 39);
            this.EditSchedule.TabIndex = 6;
            this.EditSchedule.Text = "Редактировать расписание";
            this.EditSchedule.UseVisualStyleBackColor = true;
            this.EditSchedule.Click += new System.EventHandler(this.EditSchedule_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Врачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Специализации";
            // 
            // dgSchedule
            // 
            this.dgSchedule.DataMember = "";
            this.dgSchedule.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSchedule.Location = new System.Drawing.Point(0, 152);
            this.dgSchedule.Name = "dgSchedule";
            this.dgSchedule.Size = new System.Drawing.Size(793, 226);
            this.dgSchedule.TabIndex = 3;
            // 
            // ShowSchedule
            // 
            this.ShowSchedule.Location = new System.Drawing.Point(416, 59);
            this.ShowSchedule.Name = "ShowSchedule";
            this.ShowSchedule.Size = new System.Drawing.Size(93, 39);
            this.ShowSchedule.TabIndex = 2;
            this.ShowSchedule.Text = "Показать расписание";
            this.ShowSchedule.UseVisualStyleBackColor = true;
            this.ShowSchedule.Click += new System.EventHandler(this.ShowSchedule_Click);
            // 
            // Doctors1
            // 
            this.Doctors1.FormattingEnabled = true;
            this.Doctors1.Location = new System.Drawing.Point(225, 69);
            this.Doctors1.Name = "Doctors1";
            this.Doctors1.Size = new System.Drawing.Size(121, 21);
            this.Doctors1.TabIndex = 1;
            this.Doctors1.SelectedIndexChanged += new System.EventHandler(this.Doctors1_SelectedIndexChanged);
            // 
            // Specializations1
            // 
            this.Specializations1.FormattingEnabled = true;
            this.Specializations1.Location = new System.Drawing.Point(53, 69);
            this.Specializations1.Name = "Specializations1";
            this.Specializations1.Size = new System.Drawing.Size(121, 21);
            this.Specializations1.TabIndex = 0;
            this.Specializations1.SelectedIndexChanged += new System.EventHandler(this.Specializations1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgServices);
            this.tabPage2.Controls.Add(this.EditServices);
            this.tabPage2.Controls.Add(this.ShowServices);
            this.tabPage2.Controls.Add(this.Doctors2);
            this.tabPage2.Controls.Add(this.Specializations2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Услуги";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgServices
            // 
            this.dgServices.DataMember = "";
            this.dgServices.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgServices.Location = new System.Drawing.Point(0, 152);
            this.dgServices.Name = "dgServices";
            this.dgServices.Size = new System.Drawing.Size(793, 226);
            this.dgServices.TabIndex = 8;
            // 
            // EditServices
            // 
            this.EditServices.Location = new System.Drawing.Point(564, 59);
            this.EditServices.Name = "EditServices";
            this.EditServices.Size = new System.Drawing.Size(93, 39);
            this.EditServices.TabIndex = 7;
            this.EditServices.Text = "Редактировать услуги";
            this.EditServices.UseVisualStyleBackColor = true;
            this.EditServices.Click += new System.EventHandler(this.EditServices_Click);
            // 
            // ShowServices
            // 
            this.ShowServices.Location = new System.Drawing.Point(416, 59);
            this.ShowServices.Name = "ShowServices";
            this.ShowServices.Size = new System.Drawing.Size(93, 39);
            this.ShowServices.TabIndex = 6;
            this.ShowServices.Text = "Показать услуги";
            this.ShowServices.UseVisualStyleBackColor = true;
            this.ShowServices.Click += new System.EventHandler(this.ShowServices_Click);
            // 
            // Doctors2
            // 
            this.Doctors2.FormattingEnabled = true;
            this.Doctors2.Location = new System.Drawing.Point(225, 69);
            this.Doctors2.Name = "Doctors2";
            this.Doctors2.Size = new System.Drawing.Size(121, 21);
            this.Doctors2.TabIndex = 5;
            this.Doctors2.SelectedIndexChanged += new System.EventHandler(this.Doctors2_SelectedIndexChanged);
            // 
            // Specializations2
            // 
            this.Specializations2.FormattingEnabled = true;
            this.Specializations2.Location = new System.Drawing.Point(53, 69);
            this.Specializations2.Name = "Specializations2";
            this.Specializations2.Size = new System.Drawing.Size(121, 21);
            this.Specializations2.TabIndex = 4;
            this.Specializations2.SelectedIndexChanged += new System.EventHandler(this.Specializations2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Врачи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Специализации";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgMedicaments);
            this.tabPage3.Controls.Add(this.EditMedicaments);
            this.tabPage3.Controls.Add(this.ShowMedicaments);
            this.tabPage3.Controls.Add(this.DosageForms);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(793, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Медикаменты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgMedicaments
            // 
            this.dgMedicaments.DataMember = "";
            this.dgMedicaments.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgMedicaments.Location = new System.Drawing.Point(0, 152);
            this.dgMedicaments.Name = "dgMedicaments";
            this.dgMedicaments.Size = new System.Drawing.Size(793, 226);
            this.dgMedicaments.TabIndex = 12;
            // 
            // EditMedicaments
            // 
            this.EditMedicaments.Location = new System.Drawing.Point(399, 59);
            this.EditMedicaments.Name = "EditMedicaments";
            this.EditMedicaments.Size = new System.Drawing.Size(131, 39);
            this.EditMedicaments.TabIndex = 11;
            this.EditMedicaments.Text = "Редактировать список медикаментов";
            this.EditMedicaments.UseVisualStyleBackColor = true;
            this.EditMedicaments.Click += new System.EventHandler(this.EditMedicaments_Click);
            // 
            // ShowMedicaments
            // 
            this.ShowMedicaments.Location = new System.Drawing.Point(251, 59);
            this.ShowMedicaments.Name = "ShowMedicaments";
            this.ShowMedicaments.Size = new System.Drawing.Size(103, 39);
            this.ShowMedicaments.TabIndex = 10;
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
            this.DosageForms.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Форма выпуска";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.EditDoctors);
            this.tabPage4.Controls.Add(this.ShowDoctors);
            this.tabPage4.Controls.Add(this.dgDoctors);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(793, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Врачи";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // EditDoctors
            // 
            this.EditDoctors.Location = new System.Drawing.Point(205, 59);
            this.EditDoctors.Name = "EditDoctors";
            this.EditDoctors.Size = new System.Drawing.Size(131, 39);
            this.EditDoctors.TabIndex = 17;
            this.EditDoctors.Text = "Редактировать список врачей";
            this.EditDoctors.UseVisualStyleBackColor = true;
            this.EditDoctors.Click += new System.EventHandler(this.EditDoctors_Click);
            // 
            // ShowDoctors
            // 
            this.ShowDoctors.Location = new System.Drawing.Point(25, 59);
            this.ShowDoctors.Name = "ShowDoctors";
            this.ShowDoctors.Size = new System.Drawing.Size(131, 39);
            this.ShowDoctors.TabIndex = 16;
            this.ShowDoctors.Text = "Показать список врачей";
            this.ShowDoctors.UseVisualStyleBackColor = true;
            this.ShowDoctors.Click += new System.EventHandler(this.ShowDoctors_Click);
            // 
            // dgDoctors
            // 
            this.dgDoctors.DataMember = "";
            this.dgDoctors.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDoctors.Location = new System.Drawing.Point(0, 152);
            this.dgDoctors.Name = "dgDoctors";
            this.dgDoctors.Size = new System.Drawing.Size(793, 226);
            this.dgDoctors.TabIndex = 15;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.EditSpecializations);
            this.tabPage6.Controls.Add(this.ShowSpecializations);
            this.tabPage6.Controls.Add(this.dgSpecializations);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(793, 374);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Специализации";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // EditSpecializations
            // 
            this.EditSpecializations.Location = new System.Drawing.Point(205, 59);
            this.EditSpecializations.Name = "EditSpecializations";
            this.EditSpecializations.Size = new System.Drawing.Size(131, 39);
            this.EditSpecializations.TabIndex = 23;
            this.EditSpecializations.Text = "Редактировать список специализаций";
            this.EditSpecializations.UseVisualStyleBackColor = true;
            this.EditSpecializations.Click += new System.EventHandler(this.EditSpecializations_Click);
            // 
            // ShowSpecializations
            // 
            this.ShowSpecializations.Location = new System.Drawing.Point(25, 59);
            this.ShowSpecializations.Name = "ShowSpecializations";
            this.ShowSpecializations.Size = new System.Drawing.Size(131, 39);
            this.ShowSpecializations.TabIndex = 22;
            this.ShowSpecializations.Text = "Показать список специализаций";
            this.ShowSpecializations.UseVisualStyleBackColor = true;
            this.ShowSpecializations.Click += new System.EventHandler(this.ShowSpecializations_Click);
            // 
            // dgSpecializations
            // 
            this.dgSpecializations.DataMember = "";
            this.dgSpecializations.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSpecializations.Location = new System.Drawing.Point(0, 152);
            this.dgSpecializations.Name = "dgSpecializations";
            this.dgSpecializations.Size = new System.Drawing.Size(793, 226);
            this.dgSpecializations.TabIndex = 21;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.EditAdministrators);
            this.tabPage5.Controls.Add(this.ShowAdministrators);
            this.tabPage5.Controls.Add(this.dgAdministrators);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(793, 374);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Администраторы";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // EditAdministrators
            // 
            this.EditAdministrators.Location = new System.Drawing.Point(205, 59);
            this.EditAdministrators.Name = "EditAdministrators";
            this.EditAdministrators.Size = new System.Drawing.Size(131, 39);
            this.EditAdministrators.TabIndex = 20;
            this.EditAdministrators.Text = "Редактировать список администраторов";
            this.EditAdministrators.UseVisualStyleBackColor = true;
            this.EditAdministrators.Click += new System.EventHandler(this.EditAdministrators_Click);
            // 
            // ShowAdministrators
            // 
            this.ShowAdministrators.Location = new System.Drawing.Point(25, 59);
            this.ShowAdministrators.Name = "ShowAdministrators";
            this.ShowAdministrators.Size = new System.Drawing.Size(131, 39);
            this.ShowAdministrators.TabIndex = 19;
            this.ShowAdministrators.Text = "Показать список администраторов";
            this.ShowAdministrators.UseVisualStyleBackColor = true;
            this.ShowAdministrators.Click += new System.EventHandler(this.ShowAdministrators_Click);
            // 
            // dgAdministrators
            // 
            this.dgAdministrators.DataMember = "";
            this.dgAdministrators.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgAdministrators.Location = new System.Drawing.Point(0, 152);
            this.dgAdministrators.Name = "dgAdministrators";
            this.dgAdministrators.Size = new System.Drawing.Size(793, 226);
            this.dgAdministrators.TabIndex = 18;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label7);
            this.tabPage8.Controls.Add(this.TypeUsers);
            this.tabPage8.Controls.Add(this.EditUsers);
            this.tabPage8.Controls.Add(this.ShowUsers);
            this.tabPage8.Controls.Add(this.dgUsers);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(793, 374);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Пользователи";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.EditDiagnoses);
            this.tabPage7.Controls.Add(this.ShowDiagnoses);
            this.tabPage7.Controls.Add(this.dgDiagnoses);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(793, 374);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Диагнозы";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // EditDiagnoses
            // 
            this.EditDiagnoses.Location = new System.Drawing.Point(205, 59);
            this.EditDiagnoses.Name = "EditDiagnoses";
            this.EditDiagnoses.Size = new System.Drawing.Size(131, 39);
            this.EditDiagnoses.TabIndex = 23;
            this.EditDiagnoses.Text = "Редактировать список диагнозов";
            this.EditDiagnoses.UseVisualStyleBackColor = true;
            this.EditDiagnoses.Click += new System.EventHandler(this.EditDiagnoses_Click);
            // 
            // ShowDiagnoses
            // 
            this.ShowDiagnoses.Location = new System.Drawing.Point(25, 59);
            this.ShowDiagnoses.Name = "ShowDiagnoses";
            this.ShowDiagnoses.Size = new System.Drawing.Size(131, 39);
            this.ShowDiagnoses.TabIndex = 22;
            this.ShowDiagnoses.Text = "Показать список диагнозов";
            this.ShowDiagnoses.UseVisualStyleBackColor = true;
            this.ShowDiagnoses.Click += new System.EventHandler(this.ShowDiagnoses_Click);
            // 
            // dgDiagnoses
            // 
            this.dgDiagnoses.DataMember = "";
            this.dgDiagnoses.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDiagnoses.Location = new System.Drawing.Point(0, 152);
            this.dgDiagnoses.Name = "dgDiagnoses";
            this.dgDiagnoses.Size = new System.Drawing.Size(793, 226);
            this.dgDiagnoses.TabIndex = 21;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.EditSuppliers);
            this.tabPage10.Controls.Add(this.ShowSuppliers);
            this.tabPage10.Controls.Add(this.dgSuppliers);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(793, 374);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Поставщики";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // EditSuppliers
            // 
            this.EditSuppliers.Location = new System.Drawing.Point(205, 59);
            this.EditSuppliers.Name = "EditSuppliers";
            this.EditSuppliers.Size = new System.Drawing.Size(131, 39);
            this.EditSuppliers.TabIndex = 26;
            this.EditSuppliers.Text = "Редактировать список поставщиков";
            this.EditSuppliers.UseVisualStyleBackColor = true;
            this.EditSuppliers.Click += new System.EventHandler(this.EditSuppliers_Click);
            // 
            // ShowSuppliers
            // 
            this.ShowSuppliers.Location = new System.Drawing.Point(25, 59);
            this.ShowSuppliers.Name = "ShowSuppliers";
            this.ShowSuppliers.Size = new System.Drawing.Size(131, 39);
            this.ShowSuppliers.TabIndex = 25;
            this.ShowSuppliers.Text = "Показать список поставщиков";
            this.ShowSuppliers.UseVisualStyleBackColor = true;
            this.ShowSuppliers.Click += new System.EventHandler(this.ShowSuppliers_Click);
            // 
            // dgSuppliers
            // 
            this.dgSuppliers.DataMember = "";
            this.dgSuppliers.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSuppliers.Location = new System.Drawing.Point(0, 152);
            this.dgSuppliers.Name = "dgSuppliers";
            this.dgSuppliers.Size = new System.Drawing.Size(793, 226);
            this.dgSuppliers.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ФИО";
            // 
            // FioOfAdministrator
            // 
            this.FioOfAdministrator.Location = new System.Drawing.Point(76, 13);
            this.FioOfAdministrator.Name = "FioOfAdministrator";
            this.FioOfAdministrator.Size = new System.Drawing.Size(317, 20);
            this.FioOfAdministrator.TabIndex = 3;
            // 
            // EditUsers
            // 
            this.EditUsers.Location = new System.Drawing.Point(349, 59);
            this.EditUsers.Name = "EditUsers";
            this.EditUsers.Size = new System.Drawing.Size(131, 39);
            this.EditUsers.TabIndex = 26;
            this.EditUsers.Text = "Редактировать список пользователей";
            this.EditUsers.UseVisualStyleBackColor = true;
            this.EditUsers.Click += new System.EventHandler(this.EditUsers_Click);
            // 
            // ShowUsers
            // 
            this.ShowUsers.Location = new System.Drawing.Point(180, 59);
            this.ShowUsers.Name = "ShowUsers";
            this.ShowUsers.Size = new System.Drawing.Size(131, 39);
            this.ShowUsers.TabIndex = 25;
            this.ShowUsers.Text = "Показать список пользователей";
            this.ShowUsers.UseVisualStyleBackColor = true;
            this.ShowUsers.Click += new System.EventHandler(this.ShwUsers_Click);
            // 
            // dgUsers
            // 
            this.dgUsers.DataMember = "";
            this.dgUsers.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgUsers.Location = new System.Drawing.Point(0, 152);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.Size = new System.Drawing.Size(793, 226);
            this.dgUsers.TabIndex = 24;
            // 
            // TypeUsers
            // 
            this.TypeUsers.CheckOnClick = true;
            this.TypeUsers.FormattingEnabled = true;
            this.TypeUsers.Items.AddRange(new object[] {
            "Администратор",
            "Врач",
            "Пациент"});
            this.TypeUsers.Location = new System.Drawing.Point(22, 59);
            this.TypeUsers.Name = "TypeUsers";
            this.TypeUsers.Size = new System.Drawing.Size(120, 49);
            this.TypeUsers.TabIndex = 27;
            this.TypeUsers.SelectedIndexChanged += new System.EventHandler(this.TypeUsers_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Тип пользователя";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FioOfAdministrator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmin";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicaments)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSpecializations)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdministrators)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnoses)).EndInit();
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGrid dgSchedule;
        private System.Windows.Forms.Button ShowSchedule;
        private System.Windows.Forms.ComboBox Doctors1;
        private System.Windows.Forms.ComboBox Specializations1;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditSchedule;
        private System.Windows.Forms.ComboBox Doctors2;
        private System.Windows.Forms.ComboBox Specializations2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowServices;
        private System.Windows.Forms.Button EditServices;
        private System.Windows.Forms.DataGrid dgServices;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGrid dgMedicaments;
        private System.Windows.Forms.Button EditMedicaments;
        private System.Windows.Forms.Button ShowMedicaments;
        private System.Windows.Forms.ComboBox DosageForms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ShowDoctors;
        private System.Windows.Forms.DataGrid dgDoctors;
        private System.Windows.Forms.Button EditDoctors;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button EditAdministrators;
        private System.Windows.Forms.Button ShowAdministrators;
        private System.Windows.Forms.DataGrid dgAdministrators;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FioOfAdministrator;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button EditSpecializations;
        private System.Windows.Forms.Button ShowSpecializations;
        private System.Windows.Forms.DataGrid dgSpecializations;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button EditDiagnoses;
        private System.Windows.Forms.Button ShowDiagnoses;
        private System.Windows.Forms.DataGrid dgDiagnoses;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Button EditSuppliers;
        private System.Windows.Forms.Button ShowSuppliers;
        private System.Windows.Forms.DataGrid dgSuppliers;
        private System.Windows.Forms.Button EditUsers;
        private System.Windows.Forms.Button ShowUsers;
        private System.Windows.Forms.DataGrid dgUsers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox TypeUsers;
    }
}
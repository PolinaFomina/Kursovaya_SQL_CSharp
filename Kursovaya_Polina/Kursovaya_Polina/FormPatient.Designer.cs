
namespace Kursovaya_Polina
{
    partial class FormPatient
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
            this.FioOfPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgSchedule = new System.Windows.Forms.DataGrid();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ShowSchedule = new System.Windows.Forms.Button();
            this.Doctors = new System.Windows.Forms.ComboBox();
            this.Specializations1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgFutureAppointments = new System.Windows.Forms.DataGrid();
            this.dgPastAppointments = new System.Windows.Forms.DataGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgOrders = new System.Windows.Forms.DataGrid();
            this.ResetData = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Quantity5 = new System.Windows.Forms.ComboBox();
            this.Medicament5 = new System.Windows.Forms.ComboBox();
            this.Quantity4 = new System.Windows.Forms.ComboBox();
            this.Medicament4 = new System.Windows.Forms.ComboBox();
            this.Quantity3 = new System.Windows.Forms.ComboBox();
            this.Medicament3 = new System.Windows.Forms.ComboBox();
            this.Quantity2 = new System.Windows.Forms.ComboBox();
            this.Medicament2 = new System.Windows.Forms.ComboBox();
            this.Quantity1 = new System.Windows.Forms.ComboBox();
            this.Medicament1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PlaceOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgAppointments = new System.Windows.Forms.DataGrid();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFutureAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPastAppointments)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // FioOfPatient
            // 
            this.FioOfPatient.Location = new System.Drawing.Point(77, 7);
            this.FioOfPatient.Name = "FioOfPatient";
            this.FioOfPatient.Size = new System.Drawing.Size(305, 20);
            this.FioOfPatient.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgSchedule);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.ShowSchedule);
            this.tabPage1.Controls.Add(this.Doctors);
            this.tabPage1.Controls.Add(this.Specializations1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgSchedule
            // 
            this.dgSchedule.DataMember = "";
            this.dgSchedule.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSchedule.Location = new System.Drawing.Point(0, 81);
            this.dgSchedule.Name = "dgSchedule";
            this.dgSchedule.Size = new System.Drawing.Size(793, 297);
            this.dgSchedule.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Врачи";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Специализации";
            // 
            // ShowSchedule
            // 
            this.ShowSchedule.Location = new System.Drawing.Point(384, 23);
            this.ShowSchedule.Name = "ShowSchedule";
            this.ShowSchedule.Size = new System.Drawing.Size(93, 39);
            this.ShowSchedule.TabIndex = 8;
            this.ShowSchedule.Text = "Показать расписание";
            this.ShowSchedule.UseVisualStyleBackColor = true;
            this.ShowSchedule.Click += new System.EventHandler(this.ShowSchedule_Click);
            // 
            // Doctors
            // 
            this.Doctors.FormattingEnabled = true;
            this.Doctors.Location = new System.Drawing.Point(193, 33);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(121, 21);
            this.Doctors.TabIndex = 7;
            this.Doctors.SelectedIndexChanged += new System.EventHandler(this.Doctors_SelectedIndexChanged);
            // 
            // Specializations1
            // 
            this.Specializations1.FormattingEnabled = true;
            this.Specializations1.Location = new System.Drawing.Point(21, 33);
            this.Specializations1.Name = "Specializations1";
            this.Specializations1.Size = new System.Drawing.Size(121, 21);
            this.Specializations1.TabIndex = 6;
            this.Specializations1.SelectedIndexChanged += new System.EventHandler(this.Specializations_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 400);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.dgFutureAppointments);
            this.tabPage4.Controls.Add(this.dgPastAppointments);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(793, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Мои записи";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(556, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Будущие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(141, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прошедшие";
            // 
            // dgFutureAppointments
            // 
            this.dgFutureAppointments.DataMember = "";
            this.dgFutureAppointments.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgFutureAppointments.Location = new System.Drawing.Point(398, 33);
            this.dgFutureAppointments.Name = "dgFutureAppointments";
            this.dgFutureAppointments.Size = new System.Drawing.Size(395, 345);
            this.dgFutureAppointments.TabIndex = 1;
            // 
            // dgPastAppointments
            // 
            this.dgPastAppointments.DataMember = "";
            this.dgPastAppointments.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgPastAppointments.Location = new System.Drawing.Point(0, 33);
            this.dgPastAppointments.Name = "dgPastAppointments";
            this.dgPastAppointments.Size = new System.Drawing.Size(395, 345);
            this.dgPastAppointments.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgOrders);
            this.tabPage2.Controls.Add(this.ResetData);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.TotalPrice);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.Quantity5);
            this.tabPage2.Controls.Add(this.Medicament5);
            this.tabPage2.Controls.Add(this.Quantity4);
            this.tabPage2.Controls.Add(this.Medicament4);
            this.tabPage2.Controls.Add(this.Quantity3);
            this.tabPage2.Controls.Add(this.Medicament3);
            this.tabPage2.Controls.Add(this.Quantity2);
            this.tabPage2.Controls.Add(this.Medicament2);
            this.tabPage2.Controls.Add(this.Quantity1);
            this.tabPage2.Controls.Add(this.Medicament1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.PlaceOrder);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказ медикаментов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgOrders
            // 
            this.dgOrders.DataMember = "";
            this.dgOrders.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgOrders.Location = new System.Drawing.Point(-4, 26);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.Size = new System.Drawing.Size(395, 345);
            this.dgOrders.TabIndex = 38;
            // 
            // ResetData
            // 
            this.ResetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetData.Location = new System.Drawing.Point(576, 320);
            this.ResetData.Name = "ResetData";
            this.ResetData.Size = new System.Drawing.Size(96, 39);
            this.ResetData.TabIndex = 36;
            this.ResetData.Text = "Сбросить данные";
            this.ResetData.UseVisualStyleBackColor = true;
            this.ResetData.Click += new System.EventHandler(this.ResetData_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(447, 322);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Итог";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Location = new System.Drawing.Point(450, 339);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(107, 20);
            this.TotalPrice.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(618, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Количество";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(447, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Медикаменты";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(542, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Текущий заказ";
            // 
            // Quantity5
            // 
            this.Quantity5.FormattingEnabled = true;
            this.Quantity5.Location = new System.Drawing.Point(621, 275);
            this.Quantity5.Name = "Quantity5";
            this.Quantity5.Size = new System.Drawing.Size(121, 21);
            this.Quantity5.TabIndex = 28;
            this.Quantity5.SelectedIndexChanged += new System.EventHandler(this.Quantity5_SelectedIndexChanged);
            // 
            // Medicament5
            // 
            this.Medicament5.FormattingEnabled = true;
            this.Medicament5.Location = new System.Drawing.Point(450, 275);
            this.Medicament5.Name = "Medicament5";
            this.Medicament5.Size = new System.Drawing.Size(121, 21);
            this.Medicament5.TabIndex = 27;
            this.Medicament5.SelectedIndexChanged += new System.EventHandler(this.Medicament5_SelectedIndexChanged);
            // 
            // Quantity4
            // 
            this.Quantity4.FormattingEnabled = true;
            this.Quantity4.Location = new System.Drawing.Point(621, 225);
            this.Quantity4.Name = "Quantity4";
            this.Quantity4.Size = new System.Drawing.Size(121, 21);
            this.Quantity4.TabIndex = 26;
            this.Quantity4.SelectedIndexChanged += new System.EventHandler(this.Quantity4_SelectedIndexChanged);
            // 
            // Medicament4
            // 
            this.Medicament4.FormattingEnabled = true;
            this.Medicament4.Location = new System.Drawing.Point(450, 225);
            this.Medicament4.Name = "Medicament4";
            this.Medicament4.Size = new System.Drawing.Size(121, 21);
            this.Medicament4.TabIndex = 25;
            this.Medicament4.SelectedIndexChanged += new System.EventHandler(this.Medicament4_SelectedIndexChanged);
            // 
            // Quantity3
            // 
            this.Quantity3.FormattingEnabled = true;
            this.Quantity3.Location = new System.Drawing.Point(621, 175);
            this.Quantity3.Name = "Quantity3";
            this.Quantity3.Size = new System.Drawing.Size(121, 21);
            this.Quantity3.TabIndex = 24;
            this.Quantity3.SelectedIndexChanged += new System.EventHandler(this.Quantity3_SelectedIndexChanged);
            // 
            // Medicament3
            // 
            this.Medicament3.FormattingEnabled = true;
            this.Medicament3.Location = new System.Drawing.Point(450, 175);
            this.Medicament3.Name = "Medicament3";
            this.Medicament3.Size = new System.Drawing.Size(121, 21);
            this.Medicament3.TabIndex = 23;
            this.Medicament3.SelectedIndexChanged += new System.EventHandler(this.Medicament3_SelectedIndexChanged);
            // 
            // Quantity2
            // 
            this.Quantity2.FormattingEnabled = true;
            this.Quantity2.Location = new System.Drawing.Point(621, 125);
            this.Quantity2.Name = "Quantity2";
            this.Quantity2.Size = new System.Drawing.Size(121, 21);
            this.Quantity2.TabIndex = 22;
            this.Quantity2.SelectedIndexChanged += new System.EventHandler(this.Quantity2_SelectedIndexChanged);
            // 
            // Medicament2
            // 
            this.Medicament2.FormattingEnabled = true;
            this.Medicament2.Location = new System.Drawing.Point(450, 125);
            this.Medicament2.Name = "Medicament2";
            this.Medicament2.Size = new System.Drawing.Size(121, 21);
            this.Medicament2.TabIndex = 21;
            this.Medicament2.SelectedIndexChanged += new System.EventHandler(this.Medicament2_SelectedIndexChanged);
            // 
            // Quantity1
            // 
            this.Quantity1.FormattingEnabled = true;
            this.Quantity1.Location = new System.Drawing.Point(621, 75);
            this.Quantity1.Name = "Quantity1";
            this.Quantity1.Size = new System.Drawing.Size(121, 21);
            this.Quantity1.TabIndex = 20;
            this.Quantity1.SelectedIndexChanged += new System.EventHandler(this.Quantity1_SelectedIndexChanged);
            // 
            // Medicament1
            // 
            this.Medicament1.FormattingEnabled = true;
            this.Medicament1.Location = new System.Drawing.Point(450, 75);
            this.Medicament1.Name = "Medicament1";
            this.Medicament1.Size = new System.Drawing.Size(121, 21);
            this.Medicament1.TabIndex = 19;
            this.Medicament1.SelectedIndexChanged += new System.EventHandler(this.Medicament1_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(140, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Мои заказы";
            // 
            // PlaceOrder
            // 
            this.PlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceOrder.Location = new System.Drawing.Point(688, 320);
            this.PlaceOrder.Name = "PlaceOrder";
            this.PlaceOrder.Size = new System.Drawing.Size(96, 39);
            this.PlaceOrder.TabIndex = 15;
            this.PlaceOrder.Text = "Оформить заказ";
            this.PlaceOrder.UseVisualStyleBackColor = true;
            this.PlaceOrder.Click += new System.EventHandler(this.PlaceOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgAppointments);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(793, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Моя медицинская карта";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgAppointments
            // 
            this.dgAppointments.DataMember = "";
            this.dgAppointments.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgAppointments.Location = new System.Drawing.Point(0, 3);
            this.dgAppointments.Name = "dgAppointments";
            this.dgAppointments.Size = new System.Drawing.Size(793, 375);
            this.dgAppointments.TabIndex = 13;
            // 
            // FormPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FioOfPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPatient";
            this.Text = "FormPatient";
            this.Load += new System.EventHandler(this.FormPatient_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFutureAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPastAppointments)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FioOfPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button PlaceOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ShowSchedule;
        private System.Windows.Forms.ComboBox Doctors;
        private System.Windows.Forms.ComboBox Specializations1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGrid dgFutureAppointments;
        private System.Windows.Forms.DataGrid dgPastAppointments;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox Quantity5;
        private System.Windows.Forms.ComboBox Medicament5;
        private System.Windows.Forms.ComboBox Quantity4;
        private System.Windows.Forms.ComboBox Medicament4;
        private System.Windows.Forms.ComboBox Quantity3;
        private System.Windows.Forms.ComboBox Medicament3;
        private System.Windows.Forms.ComboBox Quantity2;
        private System.Windows.Forms.ComboBox Medicament2;
        private System.Windows.Forms.ComboBox Quantity1;
        private System.Windows.Forms.ComboBox Medicament1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ResetData;
        private System.Windows.Forms.DataGrid dgSchedule;
        private System.Windows.Forms.DataGrid dgAppointments;
        private System.Windows.Forms.DataGrid dgOrders;
    }
}
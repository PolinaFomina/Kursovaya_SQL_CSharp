
namespace Kursovaya_Polina
{
    partial class DoctorsEditing
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
            this.dgDoctors = new System.Windows.Forms.DataGrid();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditDoctor = new System.Windows.Forms.Button();
            this.FioOfDoctor2 = new System.Windows.Forms.TextBox();
            this.IdDoctor2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddDoctor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteDoctor = new System.Windows.Forms.Button();
            this.IdDoctor1 = new System.Windows.Forms.ComboBox();
            this.FioOfDoctor1 = new System.Windows.Forms.TextBox();
            this.Specialization1 = new System.Windows.Forms.ComboBox();
            this.Specialization2 = new System.Windows.Forms.ComboBox();
            this.cn = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDoctors
            // 
            this.dgDoctors.DataMember = "";
            this.dgDoctors.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDoctors.Location = new System.Drawing.Point(2, 2);
            this.dgDoctors.Name = "dgDoctors";
            this.dgDoctors.Size = new System.Drawing.Size(404, 446);
            this.dgDoctors.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(432, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 79;
            this.label12.Text = "Специализация";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "ФИО врача";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Специализация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "ФИО врача";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "ID врача";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "ID врача";
            // 
            // EditDoctor
            // 
            this.EditDoctor.Location = new System.Drawing.Point(693, 343);
            this.EditDoctor.Name = "EditDoctor";
            this.EditDoctor.Size = new System.Drawing.Size(95, 36);
            this.EditDoctor.TabIndex = 71;
            this.EditDoctor.Text = "Редактировать врача";
            this.EditDoctor.UseVisualStyleBackColor = true;
            this.EditDoctor.Click += new System.EventHandler(this.EditDoctor_Click);
            // 
            // FioOfDoctor2
            // 
            this.FioOfDoctor2.Location = new System.Drawing.Point(531, 352);
            this.FioOfDoctor2.Name = "FioOfDoctor2";
            this.FioOfDoctor2.Size = new System.Drawing.Size(140, 20);
            this.FioOfDoctor2.TabIndex = 69;
            this.FioOfDoctor2.TextChanged += new System.EventHandler(this.FioOfDoctor2_TextChanged);
            // 
            // IdDoctor2
            // 
            this.IdDoctor2.FormattingEnabled = true;
            this.IdDoctor2.Location = new System.Drawing.Point(531, 323);
            this.IdDoctor2.Name = "IdDoctor2";
            this.IdDoctor2.Size = new System.Drawing.Size(67, 21);
            this.IdDoctor2.TabIndex = 68;
            this.IdDoctor2.SelectedIndexChanged += new System.EventHandler(this.IdDoctor2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(432, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 18);
            this.label3.TabIndex = 67;
            this.label3.Text = "Редактирование врача";
            // 
            // AddDoctor
            // 
            this.AddDoctor.Location = new System.Drawing.Point(693, 184);
            this.AddDoctor.Name = "AddDoctor";
            this.AddDoctor.Size = new System.Drawing.Size(95, 36);
            this.AddDoctor.TabIndex = 66;
            this.AddDoctor.Text = "Добавить врача";
            this.AddDoctor.UseVisualStyleBackColor = true;
            this.AddDoctor.Click += new System.EventHandler(this.AddDoctor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(432, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Добавление врача";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Удаление врача";
            // 
            // DeleteDoctor
            // 
            this.DeleteDoctor.Location = new System.Drawing.Point(693, 53);
            this.DeleteDoctor.Name = "DeleteDoctor";
            this.DeleteDoctor.Size = new System.Drawing.Size(95, 36);
            this.DeleteDoctor.TabIndex = 62;
            this.DeleteDoctor.Text = "Удалить врача";
            this.DeleteDoctor.UseVisualStyleBackColor = true;
            this.DeleteDoctor.Click += new System.EventHandler(this.DeleteDoctor_Click);
            // 
            // IdDoctor1
            // 
            this.IdDoctor1.FormattingEnabled = true;
            this.IdDoctor1.Location = new System.Drawing.Point(533, 62);
            this.IdDoctor1.Name = "IdDoctor1";
            this.IdDoctor1.Size = new System.Drawing.Size(67, 21);
            this.IdDoctor1.TabIndex = 61;
            this.IdDoctor1.SelectedIndexChanged += new System.EventHandler(this.IdDoctor1_SelectedIndexChanged);
            // 
            // FioOfDoctor1
            // 
            this.FioOfDoctor1.Location = new System.Drawing.Point(531, 178);
            this.FioOfDoctor1.Name = "FioOfDoctor1";
            this.FioOfDoctor1.Size = new System.Drawing.Size(140, 20);
            this.FioOfDoctor1.TabIndex = 81;
            this.FioOfDoctor1.TextChanged += new System.EventHandler(this.FioOfDoctor1_TextChanged);
            // 
            // Specialization1
            // 
            this.Specialization1.FormattingEnabled = true;
            this.Specialization1.Location = new System.Drawing.Point(531, 207);
            this.Specialization1.Name = "Specialization1";
            this.Specialization1.Size = new System.Drawing.Size(140, 21);
            this.Specialization1.TabIndex = 82;
            this.Specialization1.SelectedIndexChanged += new System.EventHandler(this.Specialization1_SelectedIndexChanged);
            // 
            // Specialization2
            // 
            this.Specialization2.FormattingEnabled = true;
            this.Specialization2.Location = new System.Drawing.Point(531, 381);
            this.Specialization2.Name = "Specialization2";
            this.Specialization2.Size = new System.Drawing.Size(140, 21);
            this.Specialization2.TabIndex = 83;
            this.Specialization2.SelectedIndexChanged += new System.EventHandler(this.Specialization2_SelectedIndexChanged);
            // 
            // DoctorsEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Specialization2);
            this.Controls.Add(this.Specialization1);
            this.Controls.Add(this.FioOfDoctor1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditDoctor);
            this.Controls.Add(this.FioOfDoctor2);
            this.Controls.Add(this.IdDoctor2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddDoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteDoctor);
            this.Controls.Add(this.IdDoctor1);
            this.Controls.Add(this.dgDoctors);
            this.Name = "DoctorsEditing";
            this.Text = "DoctorsEditing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorsEditing_FormClosed);
            this.Load += new System.EventHandler(this.DoctorsEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGrid dgDoctors;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditDoctor;
        private System.Windows.Forms.TextBox FioOfDoctor2;
        private System.Windows.Forms.ComboBox IdDoctor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteDoctor;
        private System.Windows.Forms.ComboBox IdDoctor1;
        private System.Windows.Forms.TextBox FioOfDoctor1;
        private System.Windows.Forms.ComboBox Specialization1;
        private System.Windows.Forms.ComboBox Specialization2;
        private System.Data.OleDb.OleDbConnection cn;
    }
}
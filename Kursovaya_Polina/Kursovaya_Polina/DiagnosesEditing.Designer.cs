
namespace Kursovaya_Polina
{
    partial class DiagnosesEditing
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
            this.NameOfDiagnose1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditDiagnose = new System.Windows.Forms.Button();
            this.NameOfDiagnose2 = new System.Windows.Forms.TextBox();
            this.IdDiagnose2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddDiagnose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteDiagnose = new System.Windows.Forms.Button();
            this.IdDiagnose1 = new System.Windows.Forms.ComboBox();
            this.dgDiagnoses = new System.Windows.Forms.DataGrid();
            this.label7 = new System.Windows.Forms.Label();
            this.cn = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnoses)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfDiagnose1
            // 
            this.NameOfDiagnose1.Location = new System.Drawing.Point(561, 205);
            this.NameOfDiagnose1.Name = "NameOfDiagnose1";
            this.NameOfDiagnose1.Size = new System.Drawing.Size(120, 20);
            this.NameOfDiagnose1.TabIndex = 115;
            this.NameOfDiagnose1.TextChanged += new System.EventHandler(this.NameOfDiagnose1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "Наименование дианоза";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "ID диагноза";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "ID диагноза";
            // 
            // EditDiagnose
            // 
            this.EditDiagnose.Location = new System.Drawing.Point(692, 353);
            this.EditDiagnose.Name = "EditDiagnose";
            this.EditDiagnose.Size = new System.Drawing.Size(101, 36);
            this.EditDiagnose.TabIndex = 110;
            this.EditDiagnose.Text = "Редактировать диагноз";
            this.EditDiagnose.UseVisualStyleBackColor = true;
            this.EditDiagnose.Click += new System.EventHandler(this.EditDiagnose_Click);
            // 
            // NameOfDiagnose2
            // 
            this.NameOfDiagnose2.Location = new System.Drawing.Point(561, 376);
            this.NameOfDiagnose2.Name = "NameOfDiagnose2";
            this.NameOfDiagnose2.Size = new System.Drawing.Size(120, 20);
            this.NameOfDiagnose2.TabIndex = 109;
            this.NameOfDiagnose2.TextChanged += new System.EventHandler(this.NameOfDiagnose2_TextChanged);
            // 
            // IdDiagnose2
            // 
            this.IdDiagnose2.FormattingEnabled = true;
            this.IdDiagnose2.Location = new System.Drawing.Point(561, 347);
            this.IdDiagnose2.Name = "IdDiagnose2";
            this.IdDiagnose2.Size = new System.Drawing.Size(67, 21);
            this.IdDiagnose2.TabIndex = 108;
            this.IdDiagnose2.SelectedIndexChanged += new System.EventHandler(this.IdDiagnose2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(433, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 18);
            this.label3.TabIndex = 107;
            this.label3.Text = "Редактирование диагноза";
            // 
            // AddDiagnose
            // 
            this.AddDiagnose.Location = new System.Drawing.Point(692, 196);
            this.AddDiagnose.Name = "AddDiagnose";
            this.AddDiagnose.Size = new System.Drawing.Size(101, 36);
            this.AddDiagnose.TabIndex = 106;
            this.AddDiagnose.Text = "Добавить диагноз";
            this.AddDiagnose.UseVisualStyleBackColor = true;
            this.AddDiagnose.Click += new System.EventHandler(this.AddDiagnose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(433, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 105;
            this.label2.Text = "Добавление диагноза";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(433, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 104;
            this.label1.Text = "Удаление диагноза";
            // 
            // DeleteDiagnose
            // 
            this.DeleteDiagnose.Location = new System.Drawing.Point(692, 54);
            this.DeleteDiagnose.Name = "DeleteDiagnose";
            this.DeleteDiagnose.Size = new System.Drawing.Size(101, 36);
            this.DeleteDiagnose.TabIndex = 103;
            this.DeleteDiagnose.Text = "Удалить диагноз";
            this.DeleteDiagnose.UseVisualStyleBackColor = true;
            this.DeleteDiagnose.Click += new System.EventHandler(this.DeleteDiagnose_Click);
            // 
            // IdDiagnose1
            // 
            this.IdDiagnose1.FormattingEnabled = true;
            this.IdDiagnose1.Location = new System.Drawing.Point(561, 63);
            this.IdDiagnose1.Name = "IdDiagnose1";
            this.IdDiagnose1.Size = new System.Drawing.Size(66, 21);
            this.IdDiagnose1.TabIndex = 102;
            this.IdDiagnose1.SelectedIndexChanged += new System.EventHandler(this.IdDiagnose1_SelectedIndexChanged);
            // 
            // dgDiagnoses
            // 
            this.dgDiagnoses.DataMember = "";
            this.dgDiagnoses.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDiagnoses.Location = new System.Drawing.Point(1, 3);
            this.dgDiagnoses.Name = "dgDiagnoses";
            this.dgDiagnoses.Size = new System.Drawing.Size(404, 446);
            this.dgDiagnoses.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 116;
            this.label7.Text = "Наименование дианоза";
            // 
            // DiagnosesEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NameOfDiagnose1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditDiagnose);
            this.Controls.Add(this.NameOfDiagnose2);
            this.Controls.Add(this.IdDiagnose2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddDiagnose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteDiagnose);
            this.Controls.Add(this.IdDiagnose1);
            this.Controls.Add(this.dgDiagnoses);
            this.Name = "DiagnosesEditing";
            this.Text = "DiagnosesEditing";
            this.Load += new System.EventHandler(this.DiagnosesEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnoses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameOfDiagnose1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditDiagnose;
        private System.Windows.Forms.TextBox NameOfDiagnose2;
        private System.Windows.Forms.ComboBox IdDiagnose2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddDiagnose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteDiagnose;
        private System.Windows.Forms.ComboBox IdDiagnose1;
        private System.Windows.Forms.DataGrid dgDiagnoses;
        private System.Windows.Forms.Label label7;
        private System.Data.OleDb.OleDbConnection cn;
    }
}
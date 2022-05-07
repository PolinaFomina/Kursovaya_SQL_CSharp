
namespace Kursovaya_Polina
{
    partial class SpecializationsEditing
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
            this.NameOfSpecialization1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditSpecialization = new System.Windows.Forms.Button();
            this.NameOfSpecialization2 = new System.Windows.Forms.TextBox();
            this.IdSpecialization2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddSpecialization = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteSpecialization = new System.Windows.Forms.Button();
            this.IdSpecialization1 = new System.Windows.Forms.ComboBox();
            this.dgSpecializations = new System.Windows.Forms.DataGrid();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cn = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dgSpecializations)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfSpecialization1
            // 
            this.NameOfSpecialization1.Location = new System.Drawing.Point(562, 211);
            this.NameOfSpecialization1.Name = "NameOfSpecialization1";
            this.NameOfSpecialization1.Size = new System.Drawing.Size(120, 20);
            this.NameOfSpecialization1.TabIndex = 115;
            this.NameOfSpecialization1.TextChanged += new System.EventHandler(this.NameOfSpecialization1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 114;
            this.label10.Text = "Наименование";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "Наименование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "ID специализации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "ID специализации";
            // 
            // EditSpecialization
            // 
            this.EditSpecialization.Location = new System.Drawing.Point(693, 352);
            this.EditSpecialization.Name = "EditSpecialization";
            this.EditSpecialization.Size = new System.Drawing.Size(95, 36);
            this.EditSpecialization.TabIndex = 110;
            this.EditSpecialization.Text = "Редактировать специализацию";
            this.EditSpecialization.UseVisualStyleBackColor = true;
            this.EditSpecialization.Click += new System.EventHandler(this.EditSpecialization_Click);
            // 
            // NameOfSpecialization2
            // 
            this.NameOfSpecialization2.Location = new System.Drawing.Point(562, 381);
            this.NameOfSpecialization2.Name = "NameOfSpecialization2";
            this.NameOfSpecialization2.Size = new System.Drawing.Size(120, 20);
            this.NameOfSpecialization2.TabIndex = 109;
            this.NameOfSpecialization2.TextChanged += new System.EventHandler(this.NameOfSpecialization2_TextChanged);
            // 
            // IdSpecialization2
            // 
            this.IdSpecialization2.FormattingEnabled = true;
            this.IdSpecialization2.Location = new System.Drawing.Point(562, 346);
            this.IdSpecialization2.Name = "IdSpecialization2";
            this.IdSpecialization2.Size = new System.Drawing.Size(67, 21);
            this.IdSpecialization2.TabIndex = 108;
            this.IdSpecialization2.SelectedIndexChanged += new System.EventHandler(this.IdSpecialization2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(434, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 18);
            this.label3.TabIndex = 107;
            this.label3.Text = "Редактирование специализации";
            // 
            // AddSpecialization
            // 
            this.AddSpecialization.Location = new System.Drawing.Point(693, 202);
            this.AddSpecialization.Name = "AddSpecialization";
            this.AddSpecialization.Size = new System.Drawing.Size(95, 36);
            this.AddSpecialization.TabIndex = 106;
            this.AddSpecialization.Text = "Добавить специализацию";
            this.AddSpecialization.UseVisualStyleBackColor = true;
            this.AddSpecialization.Click += new System.EventHandler(this.AddSpecialization_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(434, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 18);
            this.label2.TabIndex = 105;
            this.label2.Text = "Добавление специализации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 104;
            this.label1.Text = "Удаление специализации";
            // 
            // DeleteSpecialization
            // 
            this.DeleteSpecialization.Location = new System.Drawing.Point(693, 53);
            this.DeleteSpecialization.Name = "DeleteSpecialization";
            this.DeleteSpecialization.Size = new System.Drawing.Size(95, 36);
            this.DeleteSpecialization.TabIndex = 103;
            this.DeleteSpecialization.Text = "Удалить специализацию";
            this.DeleteSpecialization.UseVisualStyleBackColor = true;
            this.DeleteSpecialization.Click += new System.EventHandler(this.DeleteSpecialization_Click);
            // 
            // IdSpecialization1
            // 
            this.IdSpecialization1.FormattingEnabled = true;
            this.IdSpecialization1.Location = new System.Drawing.Point(562, 62);
            this.IdSpecialization1.Name = "IdSpecialization1";
            this.IdSpecialization1.Size = new System.Drawing.Size(66, 21);
            this.IdSpecialization1.TabIndex = 102;
            this.IdSpecialization1.SelectedIndexChanged += new System.EventHandler(this.IdSpecialization1_SelectedIndexChanged);
            // 
            // dgSpecializations
            // 
            this.dgSpecializations.DataMember = "";
            this.dgSpecializations.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSpecializations.Location = new System.Drawing.Point(2, 2);
            this.dgSpecializations.Name = "dgSpecializations";
            this.dgSpecializations.Size = new System.Drawing.Size(404, 446);
            this.dgSpecializations.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 116;
            this.label7.Text = "специализации";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 117;
            this.label8.Text = "специализации";
            // 
            // SpecializationsEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NameOfSpecialization1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditSpecialization);
            this.Controls.Add(this.NameOfSpecialization2);
            this.Controls.Add(this.IdSpecialization2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddSpecialization);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteSpecialization);
            this.Controls.Add(this.IdSpecialization1);
            this.Controls.Add(this.dgSpecializations);
            this.Name = "SpecializationsEditing";
            this.Text = "SpecializationsEditing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpecializationsEditing_FormClosed);
            this.Load += new System.EventHandler(this.SpecializationsEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSpecializations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameOfSpecialization1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditSpecialization;
        private System.Windows.Forms.TextBox NameOfSpecialization2;
        private System.Windows.Forms.ComboBox IdSpecialization2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddSpecialization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteSpecialization;
        private System.Windows.Forms.ComboBox IdSpecialization1;
        private System.Windows.Forms.DataGrid dgSpecializations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Data.OleDb.OleDbConnection cn;
    }
}
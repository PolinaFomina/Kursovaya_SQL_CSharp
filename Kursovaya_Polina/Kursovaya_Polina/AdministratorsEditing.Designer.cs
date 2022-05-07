
namespace Kursovaya_Polina
{
    partial class AdministratorsEditing
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
            this.FioOfAdministrator1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditAdministrator = new System.Windows.Forms.Button();
            this.FioOfAdministrator2 = new System.Windows.Forms.TextBox();
            this.IdAdministrator2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddAdministrator = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteAdministrator = new System.Windows.Forms.Button();
            this.IdAdministrator1 = new System.Windows.Forms.ComboBox();
            this.dgAdministrators = new System.Windows.Forms.DataGrid();
            this.cn = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdministrators)).BeginInit();
            this.SuspendLayout();
            // 
            // FioOfAdministrator1
            // 
            this.FioOfAdministrator1.Location = new System.Drawing.Point(562, 204);
            this.FioOfAdministrator1.Name = "FioOfAdministrator1";
            this.FioOfAdministrator1.Size = new System.Drawing.Size(120, 20);
            this.FioOfAdministrator1.TabIndex = 100;
            this.FioOfAdministrator1.TextChanged += new System.EventHandler(this.FioOfAdministrator1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 98;
            this.label10.Text = "ФИО администратора";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "ФИО администратора";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "ID администратора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "ID администратора";
            // 
            // EditAdministrator
            // 
            this.EditAdministrator.Location = new System.Drawing.Point(693, 352);
            this.EditAdministrator.Name = "EditAdministrator";
            this.EditAdministrator.Size = new System.Drawing.Size(101, 36);
            this.EditAdministrator.TabIndex = 93;
            this.EditAdministrator.Text = "Редактировать администратора";
            this.EditAdministrator.UseVisualStyleBackColor = true;
            this.EditAdministrator.Click += new System.EventHandler(this.EditAdministrator_Click);
            // 
            // FioOfAdministrator2
            // 
            this.FioOfAdministrator2.Location = new System.Drawing.Point(562, 375);
            this.FioOfAdministrator2.Name = "FioOfAdministrator2";
            this.FioOfAdministrator2.Size = new System.Drawing.Size(120, 20);
            this.FioOfAdministrator2.TabIndex = 92;
            this.FioOfAdministrator2.TextChanged += new System.EventHandler(this.FioOfAdministrator2_TextChanged);
            // 
            // IdAdministrator2
            // 
            this.IdAdministrator2.FormattingEnabled = true;
            this.IdAdministrator2.Location = new System.Drawing.Point(562, 346);
            this.IdAdministrator2.Name = "IdAdministrator2";
            this.IdAdministrator2.Size = new System.Drawing.Size(67, 21);
            this.IdAdministrator2.TabIndex = 91;
            this.IdAdministrator2.SelectedIndexChanged += new System.EventHandler(this.IdAdministrator2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(434, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 18);
            this.label3.TabIndex = 90;
            this.label3.Text = "Редактирование администратора";
            // 
            // AddAdministrator
            // 
            this.AddAdministrator.Location = new System.Drawing.Point(693, 195);
            this.AddAdministrator.Name = "AddAdministrator";
            this.AddAdministrator.Size = new System.Drawing.Size(101, 36);
            this.AddAdministrator.TabIndex = 89;
            this.AddAdministrator.Text = "Добавить администратора";
            this.AddAdministrator.UseVisualStyleBackColor = true;
            this.AddAdministrator.Click += new System.EventHandler(this.AddAdministrator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(434, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 18);
            this.label2.TabIndex = 88;
            this.label2.Text = "Добавление администратора";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 87;
            this.label1.Text = "Удаление администратора";
            // 
            // DeleteAdministrator
            // 
            this.DeleteAdministrator.Location = new System.Drawing.Point(693, 53);
            this.DeleteAdministrator.Name = "DeleteAdministrator";
            this.DeleteAdministrator.Size = new System.Drawing.Size(101, 36);
            this.DeleteAdministrator.TabIndex = 86;
            this.DeleteAdministrator.Text = "Удалить администратора";
            this.DeleteAdministrator.UseVisualStyleBackColor = true;
            this.DeleteAdministrator.Click += new System.EventHandler(this.DeleteAdministrator_Click);
            // 
            // IdAdministrator1
            // 
            this.IdAdministrator1.FormattingEnabled = true;
            this.IdAdministrator1.Location = new System.Drawing.Point(562, 62);
            this.IdAdministrator1.Name = "IdAdministrator1";
            this.IdAdministrator1.Size = new System.Drawing.Size(66, 21);
            this.IdAdministrator1.TabIndex = 85;
            this.IdAdministrator1.SelectedIndexChanged += new System.EventHandler(this.IdAdministrator1_SelectedIndexChanged);
            // 
            // dgAdministrators
            // 
            this.dgAdministrators.DataMember = "";
            this.dgAdministrators.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgAdministrators.Location = new System.Drawing.Point(2, 2);
            this.dgAdministrators.Name = "dgAdministrators";
            this.dgAdministrators.Size = new System.Drawing.Size(404, 446);
            this.dgAdministrators.TabIndex = 84;
            // 
            // AdministratorsEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FioOfAdministrator1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditAdministrator);
            this.Controls.Add(this.FioOfAdministrator2);
            this.Controls.Add(this.IdAdministrator2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddAdministrator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteAdministrator);
            this.Controls.Add(this.IdAdministrator1);
            this.Controls.Add(this.dgAdministrators);
            this.Name = "AdministratorsEditing";
            this.Text = "AdministratorsEditing";
            this.Load += new System.EventHandler(this.AdministratorsEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdministrators)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FioOfAdministrator1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditAdministrator;
        private System.Windows.Forms.TextBox FioOfAdministrator2;
        private System.Windows.Forms.ComboBox IdAdministrator2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddAdministrator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteAdministrator;
        private System.Windows.Forms.ComboBox IdAdministrator1;
        private System.Windows.Forms.DataGrid dgAdministrators;
        private System.Data.OleDb.OleDbConnection cn;
    }
}
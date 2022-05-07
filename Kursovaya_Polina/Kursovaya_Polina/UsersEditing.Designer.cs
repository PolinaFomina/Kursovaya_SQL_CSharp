
namespace Kursovaya_Polina
{
    partial class UsersEditing
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditUser = new System.Windows.Forms.Button();
            this.Login2 = new System.Windows.Forms.TextBox();
            this.IdUser2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.IdUser1 = new System.Windows.Forms.ComboBox();
            this.dgUsers = new System.Windows.Forms.DataGrid();
            this.label8 = new System.Windows.Forms.Label();
            this.Password2 = new System.Windows.Forms.TextBox();
            this.TypeUsers2 = new System.Windows.Forms.ComboBox();
            this.Password1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Login1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.FIO = new System.Windows.Forms.ComboBox();
            this.TypeUsers1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TypeUsers3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 131;
            this.label7.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 129;
            this.label6.Text = "Тип пользователя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 128;
            this.label5.Text = "ID пользователя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "ID пользователя";
            // 
            // EditUser
            // 
            this.EditUser.Location = new System.Drawing.Point(692, 373);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(101, 36);
            this.EditUser.TabIndex = 126;
            this.EditUser.Text = "Редактировать пользователя";
            this.EditUser.UseVisualStyleBackColor = true;
            this.EditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // Login2
            // 
            this.Login2.Location = new System.Drawing.Point(560, 393);
            this.Login2.Name = "Login2";
            this.Login2.Size = new System.Drawing.Size(120, 20);
            this.Login2.TabIndex = 125;
            this.Login2.TextChanged += new System.EventHandler(this.Login2_TextChanged);
            // 
            // IdUser2
            // 
            this.IdUser2.FormattingEnabled = true;
            this.IdUser2.Location = new System.Drawing.Point(560, 361);
            this.IdUser2.Name = "IdUser2";
            this.IdUser2.Size = new System.Drawing.Size(67, 21);
            this.IdUser2.TabIndex = 124;
            this.IdUser2.SelectedIndexChanged += new System.EventHandler(this.IdUser2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(434, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 18);
            this.label3.TabIndex = 123;
            this.label3.Text = "Редактирование пользователя";
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(692, 199);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(101, 36);
            this.AddUser.TabIndex = 122;
            this.AddUser.Text = "Добавить пользователя";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(434, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 18);
            this.label2.TabIndex = 121;
            this.label2.Text = "Добавление пользователя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 120;
            this.label1.Text = "Удаление пользователя";
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(692, 54);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(101, 36);
            this.DeleteUser.TabIndex = 119;
            this.DeleteUser.Text = "Удалить пользователя";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // IdUser1
            // 
            this.IdUser1.FormattingEnabled = true;
            this.IdUser1.Location = new System.Drawing.Point(560, 77);
            this.IdUser1.Name = "IdUser1";
            this.IdUser1.Size = new System.Drawing.Size(66, 21);
            this.IdUser1.TabIndex = 118;
            this.IdUser1.SelectedIndexChanged += new System.EventHandler(this.IdUser1_SelectedIndexChanged);
            // 
            // dgUsers
            // 
            this.dgUsers.DataMember = "";
            this.dgUsers.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgUsers.Location = new System.Drawing.Point(1, 3);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.Size = new System.Drawing.Size(404, 446);
            this.dgUsers.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 132;
            this.label8.Text = "Пароль";
            // 
            // Password2
            // 
            this.Password2.Location = new System.Drawing.Point(560, 425);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(120, 20);
            this.Password2.TabIndex = 133;
            this.Password2.TextChanged += new System.EventHandler(this.Password2_TextChanged);
            // 
            // TypeUsers2
            // 
            this.TypeUsers2.FormattingEnabled = true;
            this.TypeUsers2.Location = new System.Drawing.Point(560, 155);
            this.TypeUsers2.Name = "TypeUsers2";
            this.TypeUsers2.Size = new System.Drawing.Size(120, 21);
            this.TypeUsers2.TabIndex = 134;
            this.TypeUsers2.SelectedIndexChanged += new System.EventHandler(this.TypeUsers2_SelectedIndexChanged);
            // 
            // Password1
            // 
            this.Password1.Location = new System.Drawing.Point(560, 251);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(120, 20);
            this.Password1.TabIndex = 139;
            this.Password1.TextChanged += new System.EventHandler(this.Password1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 138;
            this.label10.Text = "Пароль";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(433, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 137;
            this.label11.Text = "Логин";
            // 
            // Login1
            // 
            this.Login1.Location = new System.Drawing.Point(560, 219);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(120, 20);
            this.Login1.TabIndex = 136;
            this.Login1.TextChanged += new System.EventHandler(this.Login1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 140;
            this.label9.Text = "ФИО";
            // 
            // FIO
            // 
            this.FIO.FormattingEnabled = true;
            this.FIO.Location = new System.Drawing.Point(560, 187);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(120, 21);
            this.FIO.TabIndex = 141;
            this.FIO.SelectedIndexChanged += new System.EventHandler(this.FIO_SelectedIndexChanged);
            // 
            // TypeUsers1
            // 
            this.TypeUsers1.FormattingEnabled = true;
            this.TypeUsers1.Location = new System.Drawing.Point(560, 45);
            this.TypeUsers1.Name = "TypeUsers1";
            this.TypeUsers1.Size = new System.Drawing.Size(120, 21);
            this.TypeUsers1.TabIndex = 143;
            this.TypeUsers1.SelectedIndexChanged += new System.EventHandler(this.TypeUsers1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 142;
            this.label12.Text = "Тип пользователя";
            // 
            // TypeUsers3
            // 
            this.TypeUsers3.FormattingEnabled = true;
            this.TypeUsers3.Location = new System.Drawing.Point(560, 329);
            this.TypeUsers3.Name = "TypeUsers3";
            this.TypeUsers3.Size = new System.Drawing.Size(120, 21);
            this.TypeUsers3.TabIndex = 145;
            this.TypeUsers3.SelectedIndexChanged += new System.EventHandler(this.TypeUsers3_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(433, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 144;
            this.label13.Text = "Тип пользователя";
            // 
            // UsersEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypeUsers3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TypeUsers1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Password1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Login1);
            this.Controls.Add(this.TypeUsers2);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditUser);
            this.Controls.Add(this.Login2);
            this.Controls.Add(this.IdUser2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.IdUser1);
            this.Controls.Add(this.dgUsers);
            this.Name = "UsersEditing";
            this.Text = "UsersEditing";
            this.Load += new System.EventHandler(this.UsersEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.TextBox Login2;
        private System.Windows.Forms.ComboBox IdUser2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.ComboBox IdUser1;
        private System.Windows.Forms.DataGrid dgUsers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Password2;
        private System.Windows.Forms.ComboBox TypeUsers2;
        private System.Windows.Forms.TextBox Password1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Login1;
        private System.Windows.Forms.Label label9;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.ComboBox FIO;
        private System.Windows.Forms.ComboBox TypeUsers1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox TypeUsers3;
        private System.Windows.Forms.Label label13;
    }
}

namespace Kursovaya_Polina
{
    partial class SuppliersEditing
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
            this.NameOfSupplier1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditSupplier = new System.Windows.Forms.Button();
            this.NameOfSupplier2 = new System.Windows.Forms.TextBox();
            this.IdSupplier2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddSupplier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteSupplier = new System.Windows.Forms.Button();
            this.IdSupplier1 = new System.Windows.Forms.ComboBox();
            this.dgSuppliers = new System.Windows.Forms.DataGrid();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cn = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dgSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 131;
            this.label7.Text = "Наименование";
            // 
            // NameOfSupplier1
            // 
            this.NameOfSupplier1.Location = new System.Drawing.Point(561, 212);
            this.NameOfSupplier1.Name = "NameOfSupplier1";
            this.NameOfSupplier1.Size = new System.Drawing.Size(120, 20);
            this.NameOfSupplier1.TabIndex = 130;
            this.NameOfSupplier1.TextChanged += new System.EventHandler(this.NameOfSupplier1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 129;
            this.label6.Text = "Наименование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 128;
            this.label5.Text = "ID поставщика";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "ID поставщика";
            // 
            // EditSupplier
            // 
            this.EditSupplier.Location = new System.Drawing.Point(692, 359);
            this.EditSupplier.Name = "EditSupplier";
            this.EditSupplier.Size = new System.Drawing.Size(101, 36);
            this.EditSupplier.TabIndex = 126;
            this.EditSupplier.Text = "Редактировать поставщика";
            this.EditSupplier.UseVisualStyleBackColor = true;
            this.EditSupplier.Click += new System.EventHandler(this.EditSupplier_Click);
            // 
            // NameOfSupplier2
            // 
            this.NameOfSupplier2.Location = new System.Drawing.Point(561, 385);
            this.NameOfSupplier2.Name = "NameOfSupplier2";
            this.NameOfSupplier2.Size = new System.Drawing.Size(120, 20);
            this.NameOfSupplier2.TabIndex = 125;
            this.NameOfSupplier2.TextChanged += new System.EventHandler(this.NameOfSupplier2_TextChanged);
            // 
            // IdSupplier2
            // 
            this.IdSupplier2.FormattingEnabled = true;
            this.IdSupplier2.Location = new System.Drawing.Point(561, 347);
            this.IdSupplier2.Name = "IdSupplier2";
            this.IdSupplier2.Size = new System.Drawing.Size(67, 21);
            this.IdSupplier2.TabIndex = 124;
            this.IdSupplier2.SelectedIndexChanged += new System.EventHandler(this.IdSupplier2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(433, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 18);
            this.label3.TabIndex = 123;
            this.label3.Text = "Редактирование поставщика";
            // 
            // AddSupplier
            // 
            this.AddSupplier.Location = new System.Drawing.Point(692, 203);
            this.AddSupplier.Name = "AddSupplier";
            this.AddSupplier.Size = new System.Drawing.Size(101, 36);
            this.AddSupplier.TabIndex = 122;
            this.AddSupplier.Text = "Добавить поставщика";
            this.AddSupplier.UseVisualStyleBackColor = true;
            this.AddSupplier.Click += new System.EventHandler(this.AddSupplier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(433, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 18);
            this.label2.TabIndex = 121;
            this.label2.Text = "Добавление поставщика";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(433, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 120;
            this.label1.Text = "Удаление поставщика";
            // 
            // DeleteSupplier
            // 
            this.DeleteSupplier.Location = new System.Drawing.Point(692, 54);
            this.DeleteSupplier.Name = "DeleteSupplier";
            this.DeleteSupplier.Size = new System.Drawing.Size(101, 36);
            this.DeleteSupplier.TabIndex = 119;
            this.DeleteSupplier.Text = "Удалить поставщика";
            this.DeleteSupplier.UseVisualStyleBackColor = true;
            this.DeleteSupplier.Click += new System.EventHandler(this.DeleteSupplier_Click);
            // 
            // IdSupplier1
            // 
            this.IdSupplier1.FormattingEnabled = true;
            this.IdSupplier1.Location = new System.Drawing.Point(561, 63);
            this.IdSupplier1.Name = "IdSupplier1";
            this.IdSupplier1.Size = new System.Drawing.Size(66, 21);
            this.IdSupplier1.TabIndex = 118;
            this.IdSupplier1.SelectedIndexChanged += new System.EventHandler(this.IdSupplier1_SelectedIndexChanged);
            // 
            // dgSuppliers
            // 
            this.dgSuppliers.DataMember = "";
            this.dgSuppliers.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSuppliers.Location = new System.Drawing.Point(1, 3);
            this.dgSuppliers.Name = "dgSuppliers";
            this.dgSuppliers.Size = new System.Drawing.Size(404, 446);
            this.dgSuppliers.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 132;
            this.label8.Text = "поставщика";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 133;
            this.label9.Text = "поставщика";
            // 
            // SuppliersEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NameOfSupplier1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditSupplier);
            this.Controls.Add(this.NameOfSupplier2);
            this.Controls.Add(this.IdSupplier2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteSupplier);
            this.Controls.Add(this.IdSupplier1);
            this.Controls.Add(this.dgSuppliers);
            this.Name = "SuppliersEditing";
            this.Text = "SuppliersEditing";
            this.Load += new System.EventHandler(this.SuppliersEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameOfSupplier1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditSupplier;
        private System.Windows.Forms.TextBox NameOfSupplier2;
        private System.Windows.Forms.ComboBox IdSupplier2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteSupplier;
        private System.Windows.Forms.ComboBox IdSupplier1;
        private System.Windows.Forms.DataGrid dgSuppliers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Data.OleDb.OleDbConnection cn;
    }
}
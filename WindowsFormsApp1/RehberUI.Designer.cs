namespace WindowsFormsApp1
{
    partial class RehberUI
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
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.rdWoman = new System.Windows.Forms.RadioButton();
            this.rdMan = new System.Windows.Forms.RadioButton();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdPassive = new System.Windows.Forms.RadioButton();
            this.rdActive = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstAllLanguages = new System.Windows.Forms.ListView();
            this.lstGuideLanguages = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(144, 230);
            this.txtPhone.Mask = "00-000-000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 44;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(144, 197);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(158, 20);
            this.dtpBirthDate.TabIndex = 42;
            // 
            // rdWoman
            // 
            this.rdWoman.AutoSize = true;
            this.rdWoman.Location = new System.Drawing.Point(186, 137);
            this.rdWoman.Name = "rdWoman";
            this.rdWoman.Size = new System.Drawing.Size(52, 17);
            this.rdWoman.TabIndex = 41;
            this.rdWoman.TabStop = true;
            this.rdWoman.Text = "Kadın";
            this.rdWoman.UseVisualStyleBackColor = true;
            this.rdWoman.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdWoman_MouseClick);
            // 
            // rdMan
            // 
            this.rdMan.AutoSize = true;
            this.rdMan.Location = new System.Drawing.Point(144, 165);
            this.rdMan.Name = "rdMan";
            this.rdMan.Size = new System.Drawing.Size(53, 17);
            this.rdMan.TabIndex = 40;
            this.rdMan.TabStop = true;
            this.rdMan.Text = "Erkek";
            this.rdMan.UseVisualStyleBackColor = true;
            this.rdMan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdWoman_MouseClick);
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(144, 131);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(158, 20);
            this.txtNationality.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "İletişim Numarası";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Uyruk";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(144, 78);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(158, 20);
            this.txtSurname.TabIndex = 38;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(144, 105);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(158, 20);
            this.txtCountry.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ulke";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ad";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Yellow;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(266, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Bilgileri Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdPassive);
            this.groupBox1.Controls.Add(this.rdActive);
            this.groupBox1.Controls.Add(this.rdWoman);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 263);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // rdPassive
            // 
            this.rdPassive.AutoSize = true;
            this.rdPassive.Location = new System.Drawing.Point(186, 234);
            this.rdPassive.Name = "rdPassive";
            this.rdPassive.Size = new System.Drawing.Size(48, 17);
            this.rdPassive.TabIndex = 33;
            this.rdPassive.TabStop = true;
            this.rdPassive.Text = "Pasif";
            this.rdPassive.UseVisualStyleBackColor = true;
            this.rdPassive.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdActive_MouseClick);
            // 
            // rdActive
            // 
            this.rdActive.AutoSize = true;
            this.rdActive.Location = new System.Drawing.Point(116, 234);
            this.rdActive.Name = "rdActive";
            this.rdActive.Size = new System.Drawing.Size(46, 17);
            this.rdActive.TabIndex = 33;
            this.rdActive.TabStop = true;
            this.rdActive.Text = "Aktif";
            this.rdActive.UseVisualStyleBackColor = true;
            this.rdActive.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdActive_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Aktiflik Durumu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Bilinen Diller";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstGuideLanguages);
            this.groupBox2.Controls.Add(this.lstAllLanguages);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(345, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 263);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dil Menü";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tüm Diller";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(135, 150);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(43, 23);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "Çıkar";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(135, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstAllLanguages
            // 
            this.lstAllLanguages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstAllLanguages.GridLines = true;
            this.lstAllLanguages.Location = new System.Drawing.Point(8, 57);
            this.lstAllLanguages.Name = "lstAllLanguages";
            this.lstAllLanguages.Size = new System.Drawing.Size(121, 200);
            this.lstAllLanguages.TabIndex = 33;
            this.lstAllLanguages.UseCompatibleStateImageBehavior = false;
            this.lstAllLanguages.View = System.Windows.Forms.View.Details;
            // 
            // lstGuideLanguages
            // 
            this.lstGuideLanguages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lstGuideLanguages.GridLines = true;
            this.lstGuideLanguages.Location = new System.Drawing.Point(185, 57);
            this.lstGuideLanguages.Name = "lstGuideLanguages";
            this.lstGuideLanguages.Size = new System.Drawing.Size(121, 200);
            this.lstGuideLanguages.TabIndex = 33;
            this.lstGuideLanguages.UseCompatibleStateImageBehavior = false;
            this.lstGuideLanguages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Diller";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bilinen Diller";
            this.columnHeader2.Width = 117;
            // 
            // RehberUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 332);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.rdMan);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "RehberUI";
            this.Text = "RehberUI";
            this.Load += new System.EventHandler(this.RehberUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.RadioButton rdWoman;
        private System.Windows.Forms.RadioButton rdMan;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdPassive;
        private System.Windows.Forms.RadioButton rdActive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView lstGuideLanguages;
        private System.Windows.Forms.ListView lstAllLanguages;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
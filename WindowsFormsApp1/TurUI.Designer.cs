namespace WindowsFormsApp1
{
    partial class TurUI
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpTourDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTourLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTourPlaces = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstAllGuides = new System.Windows.Forms.ListBox();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Tur Oluştur";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(125, 110);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // dtpTourDate
            // 
            this.dtpTourDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTourDate.Location = new System.Drawing.Point(125, 148);
            this.dtpTourDate.Name = "dtpTourDate";
            this.dtpTourDate.Size = new System.Drawing.Size(121, 20);
            this.dtpTourDate.TabIndex = 3;
            // 
            // cmbTourLanguage
            // 
            this.cmbTourLanguage.FormattingEnabled = true;
            this.cmbTourLanguage.Location = new System.Drawing.Point(125, 188);
            this.cmbTourLanguage.Name = "cmbTourLanguage";
            this.cmbTourLanguage.Size = new System.Drawing.Size(121, 21);
            this.cmbTourLanguage.TabIndex = 4;
            this.cmbTourLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbTourLanguage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tüm Rehberler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ücret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tur Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tur Dili";
            // 
            // cmbTourPlaces
            // 
            this.cmbTourPlaces.FormattingEnabled = true;
            this.cmbTourPlaces.Location = new System.Drawing.Point(125, 73);
            this.cmbTourPlaces.Name = "cmbTourPlaces";
            this.cmbTourPlaces.Size = new System.Drawing.Size(121, 21);
            this.cmbTourPlaces.TabIndex = 1;
            this.cmbTourPlaces.SelectedIndexChanged += new System.EventHandler(this.cmbTourPlaces_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Turistik Yer";
            // 
            // lstAllGuides
            // 
            this.lstAllGuides.FormattingEnabled = true;
            this.lstAllGuides.Location = new System.Drawing.Point(287, 32);
            this.lstAllGuides.Name = "lstAllGuides";
            this.lstAllGuides.Size = new System.Drawing.Size(120, 186);
            this.lstAllGuides.TabIndex = 6;
            // 
            // txtTourName
            // 
            this.txtTourName.Location = new System.Drawing.Point(125, 36);
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.Size = new System.Drawing.Size(121, 20);
            this.txtTourName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tur Adı";
            // 
            // TurUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 276);
            this.Controls.Add(this.txtTourName);
            this.Controls.Add(this.lstAllGuides);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTourLanguage);
            this.Controls.Add(this.dtpTourDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbTourPlaces);
            this.Controls.Add(this.btnSave);
            this.Name = "TurUI";
            this.Text = "TurUI";
            this.Load += new System.EventHandler(this.TurUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpTourDate;
        private System.Windows.Forms.ComboBox cmbTourLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTourPlaces;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstAllGuides;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.Label label6;
    }
}
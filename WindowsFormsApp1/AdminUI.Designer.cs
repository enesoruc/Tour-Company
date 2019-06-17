namespace WindowsFormsApp1
{
    partial class AdminUI
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
            this.newTour = new System.Windows.Forms.Button();
            this.updateTour = new System.Windows.Forms.Button();
            this.addGuide = new System.Windows.Forms.Button();
            this.updateGuide = new System.Windows.Forms.Button();
            this.removeGuide = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeTour = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.newPlace = new System.Windows.Forms.Button();
            this.removePlace = new System.Windows.Forms.Button();
            this.updatePlace = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.newLanguage = new System.Windows.Forms.Button();
            this.removeLanguage = new System.Windows.Forms.Button();
            this.updateLanguage = new System.Windows.Forms.Button();
            this.AddPayType = new System.Windows.Forms.Button();
            this.lstTours = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // newTour
            // 
            this.newTour.Location = new System.Drawing.Point(21, 28);
            this.newTour.Name = "newTour";
            this.newTour.Size = new System.Drawing.Size(109, 23);
            this.newTour.TabIndex = 0;
            this.newTour.Text = "Yeni Tur Düzenle";
            this.newTour.UseVisualStyleBackColor = true;
            this.newTour.Click += new System.EventHandler(this.newTour_Click);
            // 
            // updateTour
            // 
            this.updateTour.Location = new System.Drawing.Point(21, 62);
            this.updateTour.Name = "updateTour";
            this.updateTour.Size = new System.Drawing.Size(109, 23);
            this.updateTour.TabIndex = 0;
            this.updateTour.Text = "Tur Güncelle";
            this.updateTour.UseVisualStyleBackColor = true;
            this.updateTour.Click += new System.EventHandler(this.updateTour_Click);
            // 
            // addGuide
            // 
            this.addGuide.Location = new System.Drawing.Point(21, 28);
            this.addGuide.Name = "addGuide";
            this.addGuide.Size = new System.Drawing.Size(108, 23);
            this.addGuide.TabIndex = 0;
            this.addGuide.Text = "Rehber Ekle";
            this.addGuide.UseVisualStyleBackColor = true;
            this.addGuide.Click += new System.EventHandler(this.addGuide_Click);
            // 
            // updateGuide
            // 
            this.updateGuide.Location = new System.Drawing.Point(21, 62);
            this.updateGuide.Name = "updateGuide";
            this.updateGuide.Size = new System.Drawing.Size(108, 23);
            this.updateGuide.TabIndex = 0;
            this.updateGuide.Text = "Rehber Güncelle";
            this.updateGuide.UseVisualStyleBackColor = true;
            this.updateGuide.Click += new System.EventHandler(this.updateGuide_Click);
            // 
            // removeGuide
            // 
            this.removeGuide.Location = new System.Drawing.Point(21, 95);
            this.removeGuide.Name = "removeGuide";
            this.removeGuide.Size = new System.Drawing.Size(108, 23);
            this.removeGuide.TabIndex = 0;
            this.removeGuide.Text = "Rehber Sil";
            this.removeGuide.UseVisualStyleBackColor = true;
            this.removeGuide.Click += new System.EventHandler(this.removeGuide_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newTour);
            this.groupBox1.Controls.Add(this.removeTour);
            this.groupBox1.Controls.Add(this.updateTour);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tur Menü";
            // 
            // removeTour
            // 
            this.removeTour.Location = new System.Drawing.Point(21, 95);
            this.removeTour.Name = "removeTour";
            this.removeTour.Size = new System.Drawing.Size(109, 23);
            this.removeTour.TabIndex = 0;
            this.removeTour.Text = "Tur İptal";
            this.removeTour.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addGuide);
            this.groupBox2.Controls.Add(this.removeGuide);
            this.groupBox2.Controls.Add(this.updateGuide);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rehber Menü";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.newPlace);
            this.groupBox3.Controls.Add(this.removePlace);
            this.groupBox3.Controls.Add(this.updatePlace);
            this.groupBox3.Location = new System.Drawing.Point(646, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 131);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Turistik Yer Menü";
            // 
            // newPlace
            // 
            this.newPlace.Location = new System.Drawing.Point(21, 28);
            this.newPlace.Name = "newPlace";
            this.newPlace.Size = new System.Drawing.Size(108, 23);
            this.newPlace.TabIndex = 0;
            this.newPlace.Text = "Yeni Yer Ekle";
            this.newPlace.UseVisualStyleBackColor = true;
            this.newPlace.Click += new System.EventHandler(this.newPlace_Click);
            // 
            // removePlace
            // 
            this.removePlace.Location = new System.Drawing.Point(21, 95);
            this.removePlace.Name = "removePlace";
            this.removePlace.Size = new System.Drawing.Size(108, 23);
            this.removePlace.TabIndex = 0;
            this.removePlace.Text = "Yer Sil";
            this.removePlace.UseVisualStyleBackColor = true;
            this.removePlace.Click += new System.EventHandler(this.removePlace_Click);
            // 
            // updatePlace
            // 
            this.updatePlace.Location = new System.Drawing.Point(21, 62);
            this.updatePlace.Name = "updatePlace";
            this.updatePlace.Size = new System.Drawing.Size(108, 23);
            this.updatePlace.TabIndex = 0;
            this.updatePlace.Text = "Yer Güncelle";
            this.updatePlace.UseVisualStyleBackColor = true;
            this.updatePlace.Click += new System.EventHandler(this.updatePlace_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.newLanguage);
            this.groupBox4.Controls.Add(this.removeLanguage);
            this.groupBox4.Controls.Add(this.updateLanguage);
            this.groupBox4.Location = new System.Drawing.Point(646, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(142, 131);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dil Menü";
            // 
            // newLanguage
            // 
            this.newLanguage.Location = new System.Drawing.Point(21, 28);
            this.newLanguage.Name = "newLanguage";
            this.newLanguage.Size = new System.Drawing.Size(108, 23);
            this.newLanguage.TabIndex = 0;
            this.newLanguage.Text = "Dil Ekle";
            this.newLanguage.UseVisualStyleBackColor = true;
            this.newLanguage.Click += new System.EventHandler(this.newLanguage_Click);
            // 
            // removeLanguage
            // 
            this.removeLanguage.Location = new System.Drawing.Point(21, 95);
            this.removeLanguage.Name = "removeLanguage";
            this.removeLanguage.Size = new System.Drawing.Size(108, 23);
            this.removeLanguage.TabIndex = 0;
            this.removeLanguage.Text = "Dil Sil";
            this.removeLanguage.UseVisualStyleBackColor = true;
            // 
            // updateLanguage
            // 
            this.updateLanguage.Location = new System.Drawing.Point(21, 62);
            this.updateLanguage.Name = "updateLanguage";
            this.updateLanguage.Size = new System.Drawing.Size(108, 23);
            this.updateLanguage.TabIndex = 0;
            this.updateLanguage.Text = "Dil Güncelle";
            this.updateLanguage.UseVisualStyleBackColor = true;
            // 
            // AddPayType
            // 
            this.AddPayType.Location = new System.Drawing.Point(359, 12);
            this.AddPayType.Name = "AddPayType";
            this.AddPayType.Size = new System.Drawing.Size(94, 23);
            this.AddPayType.TabIndex = 4;
            this.AddPayType.Text = "Ödeme Tipi Ekle";
            this.AddPayType.UseVisualStyleBackColor = true;
            this.AddPayType.Click += new System.EventHandler(this.AddPayType_Click);
            // 
            // lstTours
            // 
            this.lstTours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader4});
            this.lstTours.FullRowSelect = true;
            this.lstTours.GridLines = true;
            this.lstTours.Location = new System.Drawing.Point(225, 48);
            this.lstTours.Name = "lstTours";
            this.lstTours.Size = new System.Drawing.Size(349, 232);
            this.lstTours.TabIndex = 5;
            this.lstTours.UseCompatibleStateImageBehavior = false;
            this.lstTours.View = System.Windows.Forms.View.Details;
            this.lstTours.SelectedIndexChanged += new System.EventHandler(this.lstTours_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tur Adı";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tur Tarihi";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ücret";
            this.columnHeader4.Width = 62;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this.lstTours);
            this.Controls.Add(this.AddPayType);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminUI";
            this.Text = "AdminUI";
            this.Load += new System.EventHandler(this.AdminUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newTour;
        private System.Windows.Forms.Button updateTour;
        private System.Windows.Forms.Button addGuide;
        private System.Windows.Forms.Button updateGuide;
        private System.Windows.Forms.Button removeGuide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeTour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button newPlace;
        private System.Windows.Forms.Button removePlace;
        private System.Windows.Forms.Button updatePlace;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button newLanguage;
        private System.Windows.Forms.Button removeLanguage;
        private System.Windows.Forms.Button updateLanguage;
        private System.Windows.Forms.Button AddPayType;
        private System.Windows.Forms.ListView lstTours;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
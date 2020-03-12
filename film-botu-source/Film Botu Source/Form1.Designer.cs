namespace Film_Botu_Source
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView_FilmListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_Tirnak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl_Partlar = new System.Windows.Forms.TabControl();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_FilmAciklama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_FilmEtiketler = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_FilmOyuncular = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_FilmYonetmen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_FilmIMDB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_FilmYapim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_FilmKategoriler = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_FilmAfis = new System.Windows.Forms.TextBox();
            this.textBox_FilmAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_durum = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox_FilmAciklama = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Filmleri Çek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView_FilmListesi
            // 
            this.listView_FilmListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_FilmListesi.FullRowSelect = true;
            this.listView_FilmListesi.Location = new System.Drawing.Point(12, 44);
            this.listView_FilmListesi.MultiSelect = false;
            this.listView_FilmListesi.Name = "listView_FilmListesi";
            this.listView_FilmListesi.Size = new System.Drawing.Size(782, 162);
            this.listView_FilmListesi.TabIndex = 1;
            this.listView_FilmListesi.UseCompatibleStateImageBehavior = false;
            this.listView_FilmListesi.View = System.Windows.Forms.View.Details;
            this.listView_FilmListesi.SelectedIndexChanged += new System.EventHandler(this.listView_FilmListesi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Film Adı";
            this.columnHeader1.Width = 340;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Url";
            this.columnHeader2.Width = 420;
            // 
            // textBox_Tirnak
            // 
            this.textBox_Tirnak.Location = new System.Drawing.Point(789, 15);
            this.textBox_Tirnak.Name = "textBox_Tirnak";
            this.textBox_Tirnak.ReadOnly = true;
            this.textBox_Tirnak.Size = new System.Drawing.Size(14, 23);
            this.textBox_Tirnak.TabIndex = 3;
            this.textBox_Tirnak.Text = "\"";
            this.textBox_Tirnak.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Son Güncelleme:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl_Partlar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_FilmAciklama);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_FilmEtiketler);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_FilmOyuncular);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_FilmYonetmen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_FilmIMDB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_FilmYapim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_FilmKategoriler);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox_FilmAfis);
            this.groupBox1.Controls.Add(this.textBox_FilmAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 454);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçili Film";
            // 
            // tabControl_Partlar
            // 
            this.tabControl_Partlar.Location = new System.Drawing.Point(21, 307);
            this.tabControl_Partlar.Name = "tabControl_Partlar";
            this.tabControl_Partlar.SelectedIndex = 0;
            this.tabControl_Partlar.Size = new System.Drawing.Size(743, 130);
            this.tabControl_Partlar.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Partlar";
            // 
            // textBox_FilmAciklama
            // 
            this.textBox_FilmAciklama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmAciklama.Location = new System.Drawing.Point(279, 199);
            this.textBox_FilmAciklama.Multiline = true;
            this.textBox_FilmAciklama.Name = "textBox_FilmAciklama";
            this.textBox_FilmAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_FilmAciklama.Size = new System.Drawing.Size(485, 78);
            this.textBox_FilmAciklama.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Açıklama";
            // 
            // textBox_FilmEtiketler
            // 
            this.textBox_FilmEtiketler.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmEtiketler.Location = new System.Drawing.Point(445, 99);
            this.textBox_FilmEtiketler.Name = "textBox_FilmEtiketler";
            this.textBox_FilmEtiketler.Size = new System.Drawing.Size(319, 23);
            this.textBox_FilmEtiketler.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Etiketler";
            // 
            // textBox_FilmOyuncular
            // 
            this.textBox_FilmOyuncular.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmOyuncular.Location = new System.Drawing.Point(499, 150);
            this.textBox_FilmOyuncular.Name = "textBox_FilmOyuncular";
            this.textBox_FilmOyuncular.Size = new System.Drawing.Size(265, 23);
            this.textBox_FilmOyuncular.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Oyuncular";
            // 
            // textBox_FilmYonetmen
            // 
            this.textBox_FilmYonetmen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmYonetmen.Location = new System.Drawing.Point(279, 150);
            this.textBox_FilmYonetmen.Name = "textBox_FilmYonetmen";
            this.textBox_FilmYonetmen.Size = new System.Drawing.Size(214, 23);
            this.textBox_FilmYonetmen.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Yönetmen";
            // 
            // textBox_FilmIMDB
            // 
            this.textBox_FilmIMDB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmIMDB.Location = new System.Drawing.Point(362, 99);
            this.textBox_FilmIMDB.Name = "textBox_FilmIMDB";
            this.textBox_FilmIMDB.Size = new System.Drawing.Size(77, 23);
            this.textBox_FilmIMDB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "IMDB";
            // 
            // textBox_FilmYapim
            // 
            this.textBox_FilmYapim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmYapim.Location = new System.Drawing.Point(279, 99);
            this.textBox_FilmYapim.Name = "textBox_FilmYapim";
            this.textBox_FilmYapim.Size = new System.Drawing.Size(77, 23);
            this.textBox_FilmYapim.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yapım";
            // 
            // textBox_FilmKategoriler
            // 
            this.textBox_FilmKategoriler.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmKategoriler.Location = new System.Drawing.Point(279, 47);
            this.textBox_FilmKategoriler.Name = "textBox_FilmKategoriler";
            this.textBox_FilmKategoriler.Size = new System.Drawing.Size(485, 23);
            this.textBox_FilmKategoriler.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kategoriler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_FilmAfis
            // 
            this.textBox_FilmAfis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmAfis.Location = new System.Drawing.Point(21, 99);
            this.textBox_FilmAfis.Name = "textBox_FilmAfis";
            this.textBox_FilmAfis.Size = new System.Drawing.Size(252, 23);
            this.textBox_FilmAfis.TabIndex = 3;
            // 
            // textBox_FilmAdi
            // 
            this.textBox_FilmAdi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmAdi.Location = new System.Drawing.Point(21, 47);
            this.textBox_FilmAdi.Name = "textBox_FilmAdi";
            this.textBox_FilmAdi.Size = new System.Drawing.Size(252, 23);
            this.textBox_FilmAdi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Film Afişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Adı";
            // 
            // label_durum
            // 
            this.label_durum.AutoSize = true;
            this.label_durum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_durum.Location = new System.Drawing.Point(335, 18);
            this.label_durum.Name = "label_durum";
            this.label_durum.Size = new System.Drawing.Size(0, 16);
            this.label_durum.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(166, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Filmi Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox_FilmAciklama
            // 
            this.richTextBox_FilmAciklama.Location = new System.Drawing.Point(810, 248);
            this.richTextBox_FilmAciklama.Name = "richTextBox_FilmAciklama";
            this.richTextBox_FilmAciklama.Size = new System.Drawing.Size(317, 241);
            this.richTextBox_FilmAciklama.TabIndex = 0;
            this.richTextBox_FilmAciklama.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1139, 678);
            this.Controls.Add(this.richTextBox_FilmAciklama);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_durum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Tirnak);
            this.Controls.Add(this.listView_FilmListesi);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Botu v1.0 | Osman Yavuz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView_FilmListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox_Tirnak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_durum;
        private System.Windows.Forms.TextBox textBox_FilmAfis;
        private System.Windows.Forms.TextBox textBox_FilmAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_FilmOyuncular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_FilmYonetmen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_FilmIMDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_FilmYapim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_FilmKategoriler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_FilmEtiketler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_FilmAciklama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl_Partlar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox_FilmAciklama;
    }
}


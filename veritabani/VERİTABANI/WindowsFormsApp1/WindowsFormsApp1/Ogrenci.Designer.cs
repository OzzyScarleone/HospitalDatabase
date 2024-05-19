namespace WindowsFormsApp1
{
    partial class Ogrenci
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtOgrTc = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrCinsiyet = new System.Windows.Forms.TextBox();
            this.txtOgrAdres = new System.Windows.Forms.TextBox();
            this.txtOgrTel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOgrEkle = new System.Windows.Forms.Button();
            this.btnOgrSil = new System.Windows.Forms.Button();
            this.btnOgrGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(1100, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci T.C.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğrenci Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Öğrenci Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Öğrenci Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Öğrenci Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Öğrenci Telefon";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // txtOgrTc
            // 
            this.txtOgrTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrTc.Location = new System.Drawing.Point(267, 27);
            this.txtOgrTc.Name = "txtOgrTc";
            this.txtOgrTc.Size = new System.Drawing.Size(200, 26);
            this.txtOgrTc.TabIndex = 10;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrAd.Location = new System.Drawing.Point(267, 56);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(200, 26);
            this.txtOgrAd.TabIndex = 11;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrSoyad.Location = new System.Drawing.Point(267, 85);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(200, 26);
            this.txtOgrSoyad.TabIndex = 12;
            // 
            // txtOgrCinsiyet
            // 
            this.txtOgrCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrCinsiyet.Location = new System.Drawing.Point(267, 142);
            this.txtOgrCinsiyet.Name = "txtOgrCinsiyet";
            this.txtOgrCinsiyet.Size = new System.Drawing.Size(200, 26);
            this.txtOgrCinsiyet.TabIndex = 13;
            // 
            // txtOgrAdres
            // 
            this.txtOgrAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrAdres.Location = new System.Drawing.Point(267, 173);
            this.txtOgrAdres.Name = "txtOgrAdres";
            this.txtOgrAdres.Size = new System.Drawing.Size(200, 26);
            this.txtOgrAdres.TabIndex = 14;
            // 
            // txtOgrTel
            // 
            this.txtOgrTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrTel.Location = new System.Drawing.Point(267, 202);
            this.txtOgrTel.Name = "txtOgrTel";
            this.txtOgrTel.Size = new System.Drawing.Size(200, 26);
            this.txtOgrTel.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 346);
            this.dataGridView1.TabIndex = 16;
           // this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btnOgrEkle
            // 
            this.btnOgrEkle.Location = new System.Drawing.Point(789, 27);
            this.btnOgrEkle.Name = "btnOgrEkle";
            this.btnOgrEkle.Size = new System.Drawing.Size(305, 48);
            this.btnOgrEkle.TabIndex = 17;
            this.btnOgrEkle.Text = "Ekle";
            this.btnOgrEkle.UseVisualStyleBackColor = true;
            this.btnOgrEkle.Click += new System.EventHandler(this.btnOgrEkle_Click);
            // 
            // btnOgrSil
            // 
            this.btnOgrSil.Location = new System.Drawing.Point(789, 99);
            this.btnOgrSil.Name = "btnOgrSil";
            this.btnOgrSil.Size = new System.Drawing.Size(305, 48);
            this.btnOgrSil.TabIndex = 18;
            this.btnOgrSil.Text = "Sil";
            this.btnOgrSil.UseVisualStyleBackColor = true;
            this.btnOgrSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOgrGuncelle
            // 
            this.btnOgrGuncelle.Location = new System.Drawing.Point(789, 163);
            this.btnOgrGuncelle.Name = "btnOgrGuncelle";
            this.btnOgrGuncelle.Size = new System.Drawing.Size(305, 48);
            this.btnOgrGuncelle.TabIndex = 19;
            this.btnOgrGuncelle.Text = "Güncelle";
            this.btnOgrGuncelle.UseVisualStyleBackColor = true;
            this.btnOgrGuncelle.Click += new System.EventHandler(this.btnOgrGuncelle_Click);
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 563);
            this.Controls.Add(this.btnOgrGuncelle);
            this.Controls.Add(this.btnOgrSil);
            this.Controls.Add(this.btnOgrEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtOgrTel);
            this.Controls.Add(this.txtOgrAdres);
            this.Controls.Add(this.txtOgrCinsiyet);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.txtOgrTc);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Ogrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtOgrTc;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrCinsiyet;
        private System.Windows.Forms.TextBox txtOgrAdres;
        private System.Windows.Forms.TextBox txtOgrTel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOgrEkle;
        private System.Windows.Forms.Button btnOgrSil;
        private System.Windows.Forms.Button btnOgrGuncelle;
    }
}
namespace WindowsFormsApp1
{
    partial class Bolum
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
            this.txtBlmTel = new System.Windows.Forms.TextBox();
            this.txtBlmAd = new System.Windows.Forms.TextBox();
            this.txtBlmKod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBlmGuncelle = new System.Windows.Forms.Button();
            this.btnBlmSil = new System.Windows.Forms.Button();
            this.btnBlmEkle = new System.Windows.Forms.Button();
            this.txtFakBilgi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(1145, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBlmTel
            // 
            this.txtBlmTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBlmTel.Location = new System.Drawing.Point(241, 121);
            this.txtBlmTel.Name = "txtBlmTel";
            this.txtBlmTel.Size = new System.Drawing.Size(200, 26);
            this.txtBlmTel.TabIndex = 32;
            // 
            // txtBlmAd
            // 
            this.txtBlmAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBlmAd.Location = new System.Drawing.Point(241, 92);
            this.txtBlmAd.Name = "txtBlmAd";
            this.txtBlmAd.Size = new System.Drawing.Size(200, 26);
            this.txtBlmAd.TabIndex = 31;
            // 
            // txtBlmKod
            // 
            this.txtBlmKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBlmKod.Location = new System.Drawing.Point(241, 63);
            this.txtBlmKod.Name = "txtBlmKod";
            this.txtBlmKod.Size = new System.Drawing.Size(200, 26);
            this.txtBlmKod.TabIndex = 30;
            this.txtBlmKod.TextChanged += new System.EventHandler(this.txtBlmKod_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(58, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Bölüm Telefonu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Bölüm Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Bölüm Kodu";
            // 
            // btnBlmGuncelle
            // 
            this.btnBlmGuncelle.Location = new System.Drawing.Point(756, 181);
            this.btnBlmGuncelle.Name = "btnBlmGuncelle";
            this.btnBlmGuncelle.Size = new System.Drawing.Size(348, 49);
            this.btnBlmGuncelle.TabIndex = 35;
            this.btnBlmGuncelle.Text = "Güncelle";
            this.btnBlmGuncelle.UseVisualStyleBackColor = true;
            this.btnBlmGuncelle.Click += new System.EventHandler(this.btnBlmGuncelle_Click);
            // 
            // btnBlmSil
            // 
            this.btnBlmSil.Location = new System.Drawing.Point(756, 118);
            this.btnBlmSil.Name = "btnBlmSil";
            this.btnBlmSil.Size = new System.Drawing.Size(348, 48);
            this.btnBlmSil.TabIndex = 34;
            this.btnBlmSil.Text = "Sil";
            this.btnBlmSil.UseVisualStyleBackColor = true;
            this.btnBlmSil.Click += new System.EventHandler(this.btnBlmSil_Click);
            // 
            // btnBlmEkle
            // 
            this.btnBlmEkle.Location = new System.Drawing.Point(756, 50);
            this.btnBlmEkle.Name = "btnBlmEkle";
            this.btnBlmEkle.Size = new System.Drawing.Size(348, 48);
            this.btnBlmEkle.TabIndex = 33;
            this.btnBlmEkle.Text = "Ekle";
            this.btnBlmEkle.UseVisualStyleBackColor = true;
            this.btnBlmEkle.Click += new System.EventHandler(this.btnBlmEkle_Click);
            // 
            // txtFakBilgi
            // 
            this.txtFakBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFakBilgi.Location = new System.Drawing.Point(241, 153);
            this.txtFakBilgi.Name = "txtFakBilgi";
            this.txtFakBilgi.Size = new System.Drawing.Size(200, 26);
            this.txtFakBilgi.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fakülte Bilgisi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 346);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Bolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFakBilgi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBlmGuncelle);
            this.Controls.Add(this.btnBlmSil);
            this.Controls.Add(this.btnBlmEkle);
            this.Controls.Add(this.txtBlmTel);
            this.Controls.Add(this.txtBlmAd);
            this.Controls.Add(this.txtBlmKod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Bolum";
            this.Text = "Bolum";
            this.Load += new System.EventHandler(this.Bolum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBlmTel;
        private System.Windows.Forms.TextBox txtBlmAd;
        private System.Windows.Forms.TextBox txtBlmKod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBlmGuncelle;
        private System.Windows.Forms.Button btnBlmSil;
        private System.Windows.Forms.Button btnBlmEkle;
        private System.Windows.Forms.TextBox txtFakBilgi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
namespace WindowsFormsApp1
{
    partial class Ders
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
            this.txtDBolumKod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.txtDersKredi = new System.Windows.Forms.TextBox();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.txtDersNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDOgrETc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(1141, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDBolumKod
            // 
            this.txtDBolumKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDBolumKod.Location = new System.Drawing.Point(305, 122);
            this.txtDBolumKod.Name = "txtDBolumKod";
            this.txtDBolumKod.Size = new System.Drawing.Size(200, 26);
            this.txtDBolumKod.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Bölüm Kodu";
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.Location = new System.Drawing.Point(731, 153);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(369, 49);
            this.btnDersGuncelle.TabIndex = 46;
            this.btnDersGuncelle.Text = "Güncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = true;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // btnDersSil
            // 
            this.btnDersSil.Location = new System.Drawing.Point(731, 89);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(369, 48);
            this.btnDersSil.TabIndex = 45;
            this.btnDersSil.Text = "Sil";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(731, 22);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(369, 48);
            this.btnDersEkle.TabIndex = 44;
            this.btnDersEkle.Text = "Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // txtDersKredi
            // 
            this.txtDersKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDersKredi.Location = new System.Drawing.Point(305, 90);
            this.txtDersKredi.Name = "txtDersKredi";
            this.txtDersKredi.Size = new System.Drawing.Size(200, 26);
            this.txtDersKredi.TabIndex = 43;
            // 
            // txtDersAd
            // 
            this.txtDersAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDersAd.Location = new System.Drawing.Point(305, 61);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(200, 26);
            this.txtDersAd.TabIndex = 42;
            // 
            // txtDersNo
            // 
            this.txtDersNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDersNo.Location = new System.Drawing.Point(305, 32);
            this.txtDersNo.Name = "txtDersNo";
            this.txtDersNo.Size = new System.Drawing.Size(200, 26);
            this.txtDersNo.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ders Kredisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ders Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ders No";
            // 
            // txtDOgrETc
            // 
            this.txtDOgrETc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDOgrETc.Location = new System.Drawing.Point(305, 154);
            this.txtDOgrETc.Name = "txtDOgrETc";
            this.txtDOgrETc.Size = new System.Drawing.Size(200, 26);
            this.txtDOgrETc.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Öğretim Görevlisi T.C.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 373);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Ders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDOgrETc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDBolumKod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDersGuncelle);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.txtDersKredi);
            this.Controls.Add(this.txtDersAd);
            this.Controls.Add(this.txtDersNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Ders";
            this.Text = "Ders";
            this.Load += new System.EventHandler(this.Ders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDBolumKod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDersGuncelle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.TextBox txtDersKredi;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.TextBox txtDersNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDOgrETc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
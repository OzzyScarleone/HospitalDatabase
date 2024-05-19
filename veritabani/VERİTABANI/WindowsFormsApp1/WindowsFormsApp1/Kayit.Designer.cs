namespace WindowsFormsApp1
{
    partial class Kayit
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
            this.txtKNot = new System.Windows.Forms.TextBox();
            this.txtKDersNo = new System.Windows.Forms.TextBox();
            this.txtKOgrTc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayitGuncelle = new System.Windows.Forms.Button();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(1101, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKNot
            // 
            this.txtKNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKNot.Location = new System.Drawing.Point(285, 114);
            this.txtKNot.Name = "txtKNot";
            this.txtKNot.Size = new System.Drawing.Size(200, 26);
            this.txtKNot.TabIndex = 49;
            // 
            // txtKDersNo
            // 
            this.txtKDersNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKDersNo.Location = new System.Drawing.Point(285, 82);
            this.txtKDersNo.Name = "txtKDersNo";
            this.txtKDersNo.Size = new System.Drawing.Size(200, 26);
            this.txtKDersNo.TabIndex = 48;
            // 
            // txtKOgrTc
            // 
            this.txtKOgrTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKOgrTc.Location = new System.Drawing.Point(285, 53);
            this.txtKOgrTc.Name = "txtKOgrTc";
            this.txtKOgrTc.Size = new System.Drawing.Size(200, 26);
            this.txtKOgrTc.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Kayıt Notu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ders No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Öğrenci T.C.";
            // 
            // btnKayitGuncelle
            // 
            this.btnKayitGuncelle.Location = new System.Drawing.Point(732, 156);
            this.btnKayitGuncelle.Name = "btnKayitGuncelle";
            this.btnKayitGuncelle.Size = new System.Drawing.Size(348, 49);
            this.btnKayitGuncelle.TabIndex = 52;
            this.btnKayitGuncelle.Text = "Güncelle";
            this.btnKayitGuncelle.UseVisualStyleBackColor = true;
            this.btnKayitGuncelle.Click += new System.EventHandler(this.btnKayitGuncelle_Click);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Location = new System.Drawing.Point(732, 92);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(348, 48);
            this.btnKayitSil.TabIndex = 51;
            this.btnKayitSil.Text = "Sil";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Location = new System.Drawing.Point(732, 25);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(348, 48);
            this.btnKayitEkle.TabIndex = 50;
            this.btnKayitEkle.Text = "Ekle";
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 373);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 622);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKayitGuncelle);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.btnKayitEkle);
            this.Controls.Add(this.txtKNot);
            this.Controls.Add(this.txtKDersNo);
            this.Controls.Add(this.txtKOgrTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Kayit";
            this.Text = "Kayit";
            this.Load += new System.EventHandler(this.Kayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtKNot;
        private System.Windows.Forms.TextBox txtKDersNo;
        private System.Windows.Forms.TextBox txtKOgrTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKayitGuncelle;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
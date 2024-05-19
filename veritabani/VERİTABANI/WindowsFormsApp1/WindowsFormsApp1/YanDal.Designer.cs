namespace WindowsFormsApp1
{
    partial class YanDal
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
            this.txtYanBolumKod = new System.Windows.Forms.TextBox();
            this.txtYanOgrTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnYanGuncelle = new System.Windows.Forms.Button();
            this.btnYanSil = new System.Windows.Forms.Button();
            this.btnYanEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(1105, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtYanBolumKod
            // 
            this.txtYanBolumKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYanBolumKod.Location = new System.Drawing.Point(204, 71);
            this.txtYanBolumKod.Name = "txtYanBolumKod";
            this.txtYanBolumKod.Size = new System.Drawing.Size(200, 26);
            this.txtYanBolumKod.TabIndex = 52;
            // 
            // txtYanOgrTc
            // 
            this.txtYanOgrTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYanOgrTc.Location = new System.Drawing.Point(204, 42);
            this.txtYanOgrTc.Name = "txtYanOgrTc";
            this.txtYanOgrTc.Size = new System.Drawing.Size(200, 26);
            this.txtYanOgrTc.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Bölüm Kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Öğrenci T.C.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 373);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btnYanGuncelle
            // 
            this.btnYanGuncelle.Location = new System.Drawing.Point(746, 173);
            this.btnYanGuncelle.Name = "btnYanGuncelle";
            this.btnYanGuncelle.Size = new System.Drawing.Size(316, 49);
            this.btnYanGuncelle.TabIndex = 57;
            this.btnYanGuncelle.Text = "Güncelle";
            this.btnYanGuncelle.UseVisualStyleBackColor = true;
            this.btnYanGuncelle.Click += new System.EventHandler(this.btnYanGuncelle_Click);
            // 
            // btnYanSil
            // 
            this.btnYanSil.Location = new System.Drawing.Point(746, 109);
            this.btnYanSil.Name = "btnYanSil";
            this.btnYanSil.Size = new System.Drawing.Size(316, 48);
            this.btnYanSil.TabIndex = 56;
            this.btnYanSil.Text = "Sil";
            this.btnYanSil.UseVisualStyleBackColor = true;
            this.btnYanSil.Click += new System.EventHandler(this.btnYanSil_Click);
            // 
            // btnYanEkle
            // 
            this.btnYanEkle.Location = new System.Drawing.Point(746, 42);
            this.btnYanEkle.Name = "btnYanEkle";
            this.btnYanEkle.Size = new System.Drawing.Size(316, 48);
            this.btnYanEkle.TabIndex = 55;
            this.btnYanEkle.Text = "Ekle";
            this.btnYanEkle.UseVisualStyleBackColor = true;
            this.btnYanEkle.Click += new System.EventHandler(this.btnYanEkle_Click);
            // 
            // YanDal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 625);
            this.Controls.Add(this.btnYanGuncelle);
            this.Controls.Add(this.btnYanSil);
            this.Controls.Add(this.btnYanEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtYanBolumKod);
            this.Controls.Add(this.txtYanOgrTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "YanDal";
            this.Text = "YanDal";
            this.Load += new System.EventHandler(this.YanDal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtYanBolumKod;
        private System.Windows.Forms.TextBox txtYanOgrTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnYanGuncelle;
        private System.Windows.Forms.Button btnYanSil;
        private System.Windows.Forms.Button btnYanEkle;
    }
}
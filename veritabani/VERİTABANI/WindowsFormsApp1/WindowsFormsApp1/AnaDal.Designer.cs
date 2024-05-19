namespace WindowsFormsApp1
{
    partial class AnaDal
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
            this.btnAnaGuncelle = new System.Windows.Forms.Button();
            this.btnAnaSil = new System.Windows.Forms.Button();
            this.btnAnaEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAnaBolumKod = new System.Windows.Forms.TextBox();
            this.txtAnaOgrTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(1076, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnaGuncelle
            // 
            this.btnAnaGuncelle.Location = new System.Drawing.Point(745, 190);
            this.btnAnaGuncelle.Name = "btnAnaGuncelle";
            this.btnAnaGuncelle.Size = new System.Drawing.Size(325, 49);
            this.btnAnaGuncelle.TabIndex = 65;
            this.btnAnaGuncelle.Text = "Güncelle";
            this.btnAnaGuncelle.UseVisualStyleBackColor = true;
            this.btnAnaGuncelle.Click += new System.EventHandler(this.btnAnaGuncelle_Click);
            // 
            // btnAnaSil
            // 
            this.btnAnaSil.Location = new System.Drawing.Point(745, 126);
            this.btnAnaSil.Name = "btnAnaSil";
            this.btnAnaSil.Size = new System.Drawing.Size(325, 48);
            this.btnAnaSil.TabIndex = 64;
            this.btnAnaSil.Text = "Sil";
            this.btnAnaSil.UseVisualStyleBackColor = true;
            this.btnAnaSil.Click += new System.EventHandler(this.btnAnaSil_Click);
            // 
            // btnAnaEkle
            // 
            this.btnAnaEkle.Location = new System.Drawing.Point(745, 59);
            this.btnAnaEkle.Name = "btnAnaEkle";
            this.btnAnaEkle.Size = new System.Drawing.Size(325, 48);
            this.btnAnaEkle.TabIndex = 63;
            this.btnAnaEkle.Text = "Ekle";
            this.btnAnaEkle.UseVisualStyleBackColor = true;
            this.btnAnaEkle.Click += new System.EventHandler(this.btnAnaEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 373);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // txtAnaBolumKod
            // 
            this.txtAnaBolumKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAnaBolumKod.Location = new System.Drawing.Point(227, 178);
            this.txtAnaBolumKod.Name = "txtAnaBolumKod";
            this.txtAnaBolumKod.Size = new System.Drawing.Size(317, 26);
            this.txtAnaBolumKod.TabIndex = 61;
            this.txtAnaBolumKod.TextChanged += new System.EventHandler(this.txtAnaBolumKod_TextChanged);
            // 
            // txtAnaOgrTc
            // 
            this.txtAnaOgrTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAnaOgrTc.Location = new System.Drawing.Point(227, 78);
            this.txtAnaOgrTc.Name = "txtAnaOgrTc";
            this.txtAnaOgrTc.Size = new System.Drawing.Size(317, 26);
            this.txtAnaOgrTc.TabIndex = 60;
            this.txtAnaOgrTc.TextChanged += new System.EventHandler(this.txtAnaOgrTc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 59;
            this.label2.Text = "Bölüm Kodu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "Öğrenci  T.C. No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AnaDal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 629);
            this.Controls.Add(this.btnAnaGuncelle);
            this.Controls.Add(this.btnAnaSil);
            this.Controls.Add(this.btnAnaEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAnaBolumKod);
            this.Controls.Add(this.txtAnaOgrTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AnaDal";
            this.Text = "AnaDal";
            this.Load += new System.EventHandler(this.AnaDal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAnaGuncelle;
        private System.Windows.Forms.Button btnAnaSil;
        private System.Windows.Forms.Button btnAnaEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAnaBolumKod;
        private System.Windows.Forms.TextBox txtAnaOgrTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
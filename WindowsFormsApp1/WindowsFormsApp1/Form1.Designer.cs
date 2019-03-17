namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBAdSoyad = new System.Windows.Forms.TextBox();
            this.TBProje = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MTBTelefon = new System.Windows.Forms.MaskedTextBox();
            this.KAYDET = new System.Windows.Forms.Button();
            this.BUyeler = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBAdSoyad
            // 
            this.TBAdSoyad.Location = new System.Drawing.Point(287, 29);
            this.TBAdSoyad.Name = "TBAdSoyad";
            this.TBAdSoyad.Size = new System.Drawing.Size(272, 22);
            this.TBAdSoyad.TabIndex = 0;
            // 
            // TBProje
            // 
            this.TBProje.Location = new System.Drawing.Point(287, 158);
            this.TBProje.Name = "TBProje";
            this.TBProje.Size = new System.Drawing.Size(272, 22);
            this.TBProje.TabIndex = 1;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(287, 110);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(272, 22);
            this.TBEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefon Numarası:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proje:";
            // 
            // MTBTelefon
            // 
            this.MTBTelefon.Location = new System.Drawing.Point(287, 66);
            this.MTBTelefon.Mask = "(999) 000-0000";
            this.MTBTelefon.Name = "MTBTelefon";
            this.MTBTelefon.Size = new System.Drawing.Size(272, 22);
            this.MTBTelefon.TabIndex = 8;
            // 
            // KAYDET
            // 
            this.KAYDET.Location = new System.Drawing.Point(121, 195);
            this.KAYDET.Name = "KAYDET";
            this.KAYDET.Size = new System.Drawing.Size(142, 49);
            this.KAYDET.TabIndex = 9;
            this.KAYDET.Text = "KAYDET";
            this.KAYDET.UseVisualStyleBackColor = true;
            this.KAYDET.Click += new System.EventHandler(this.KAYDET_Click);
            // 
            // BUyeler
            // 
            this.BUyeler.Location = new System.Drawing.Point(270, 195);
            this.BUyeler.Name = "BUyeler";
            this.BUyeler.Size = new System.Drawing.Size(265, 48);
            this.BUyeler.TabIndex = 10;
            this.BUyeler.Text = "Uyeleri listele";
            this.BUyeler.UseVisualStyleBackColor = true;
            this.BUyeler.Click += new System.EventHandler(this.BUyeler_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 11;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kayıt Bilgileri;";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BUyeler);
            this.Controls.Add(this.KAYDET);
            this.Controls.Add(this.MTBTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBProje);
            this.Controls.Add(this.TBAdSoyad);
            this.Name = "Form1";
            this.Text = "Ymc_V1.01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBAdSoyad;
        private System.Windows.Forms.TextBox TBProje;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MTBTelefon;
        private System.Windows.Forms.Button KAYDET;
        private System.Windows.Forms.Button BUyeler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}


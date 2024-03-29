namespace Taşıt_Vergi
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kdvoran = new System.Windows.Forms.Label();
            this.otvoran = new System.Windows.Forms.Label();
            this.kdvfiyat = new System.Windows.Forms.Label();
            this.otvfiyat = new System.Windows.Forms.Label();
            this.toplamvergifiyat = new System.Windows.Forms.Label();
            this.anahtarfiyat = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "OTOMOBİL",
            "MOTOSİKLET",
            "OTOBÜS",
            "MİDİBÜS",
            "MİNİBÜS",
            "HYBRID",
            "ELEKTRİKLİ"});
            this.comboBox1.Location = new System.Drawing.Point(531, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 32);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(98)))));
            this.button1.Location = new System.Drawing.Point(507, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "FİYAT ÖĞREN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(34, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "KDV ORANI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÖTV ORANI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(36, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "KDV FİYATI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(36, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "ÖTV FİYATI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(33, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "TOPLAM VERGİ TUTARI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(33, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "ANAHTAR TESLİM FİYATI";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(239, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 32);
            this.textBox1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(34, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "ARACIN HAM FİYATI";
            // 
            // kdvoran
            // 
            this.kdvoran.AutoSize = true;
            this.kdvoran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdvoran.ForeColor = System.Drawing.SystemColors.Window;
            this.kdvoran.Location = new System.Drawing.Point(184, 136);
            this.kdvoran.Name = "kdvoran";
            this.kdvoran.Size = new System.Drawing.Size(40, 24);
            this.kdvoran.TabIndex = 5;
            this.kdvoran.Text = "___";
            // 
            // otvoran
            // 
            this.otvoran.AutoSize = true;
            this.otvoran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otvoran.ForeColor = System.Drawing.SystemColors.Window;
            this.otvoran.Location = new System.Drawing.Point(184, 88);
            this.otvoran.Name = "otvoran";
            this.otvoran.Size = new System.Drawing.Size(40, 24);
            this.otvoran.TabIndex = 5;
            this.otvoran.Text = "___";
            // 
            // kdvfiyat
            // 
            this.kdvfiyat.AutoSize = true;
            this.kdvfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdvfiyat.ForeColor = System.Drawing.SystemColors.Window;
            this.kdvfiyat.Location = new System.Drawing.Point(185, 232);
            this.kdvfiyat.Name = "kdvfiyat";
            this.kdvfiyat.Size = new System.Drawing.Size(40, 24);
            this.kdvfiyat.TabIndex = 5;
            this.kdvfiyat.Text = "___";
            // 
            // otvfiyat
            // 
            this.otvfiyat.AutoSize = true;
            this.otvfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otvfiyat.ForeColor = System.Drawing.SystemColors.Window;
            this.otvfiyat.Location = new System.Drawing.Point(186, 184);
            this.otvfiyat.Name = "otvfiyat";
            this.otvfiyat.Size = new System.Drawing.Size(40, 24);
            this.otvfiyat.TabIndex = 5;
            this.otvfiyat.Text = "___";
            // 
            // toplamvergifiyat
            // 
            this.toplamvergifiyat.AutoSize = true;
            this.toplamvergifiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamvergifiyat.ForeColor = System.Drawing.SystemColors.Window;
            this.toplamvergifiyat.Location = new System.Drawing.Point(287, 297);
            this.toplamvergifiyat.Name = "toplamvergifiyat";
            this.toplamvergifiyat.Size = new System.Drawing.Size(40, 24);
            this.toplamvergifiyat.TabIndex = 5;
            this.toplamvergifiyat.Text = "___";
            // 
            // anahtarfiyat
            // 
            this.anahtarfiyat.AutoSize = true;
            this.anahtarfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anahtarfiyat.ForeColor = System.Drawing.SystemColors.Window;
            this.anahtarfiyat.Location = new System.Drawing.Point(287, 349);
            this.anahtarfiyat.Name = "anahtarfiyat";
            this.anahtarfiyat.Size = new System.Drawing.Size(40, 24);
            this.anahtarfiyat.TabIndex = 5;
            this.anahtarfiyat.Text = "___";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(98)))));
            this.button2.Location = new System.Drawing.Point(507, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(398, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "ARAÇ TÜRÜ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(718, 432);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.anahtarfiyat);
            this.Controls.Add(this.toplamvergifiyat);
            this.Controls.Add(this.otvfiyat);
            this.Controls.Add(this.kdvfiyat);
            this.Controls.Add(this.otvoran);
            this.Controls.Add(this.kdvoran);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label kdvoran;
        private System.Windows.Forms.Label otvoran;
        private System.Windows.Forms.Label kdvfiyat;
        private System.Windows.Forms.Label otvfiyat;
        private System.Windows.Forms.Label toplamvergifiyat;
        private System.Windows.Forms.Label anahtarfiyat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
    }
}


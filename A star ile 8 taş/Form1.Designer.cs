namespace A_star_ile_8_taş
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chc_bitis = new System.Windows.Forms.CheckBox();
            this.chc_baslangic = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cikis7 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_cikis6 = new System.Windows.Forms.Button();
            this.btn_cikis1 = new System.Windows.Forms.Button();
            this.btn_cikis3 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_cikis4 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_cikis9 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_cikis5 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_cikis8 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_cikis2 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.baslangıclabel = new System.Windows.Forms.Label();
            this.bitislabel = new System.Windows.Forms.Label();
            this.btn_Astar = new System.Windows.Forms.Button();
            this.textBox_Adimlar = new System.Windows.Forms.TextBox();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.textBox2);
            this.Panel1.Controls.Add(this.textBox1);
            this.Panel1.Controls.Add(this.chc_bitis);
            this.Panel1.Controls.Add(this.chc_baslangic);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.btn_cikis7);
            this.Panel1.Controls.Add(this.btn_7);
            this.Panel1.Controls.Add(this.btn_cikis6);
            this.Panel1.Controls.Add(this.btn_cikis1);
            this.Panel1.Controls.Add(this.btn_cikis3);
            this.Panel1.Controls.Add(this.btn_6);
            this.Panel1.Controls.Add(this.btn_cikis4);
            this.Panel1.Controls.Add(this.btn_4);
            this.Panel1.Controls.Add(this.btn_cikis9);
            this.Panel1.Controls.Add(this.btn_9);
            this.Panel1.Controls.Add(this.btn_cikis5);
            this.Panel1.Controls.Add(this.btn_5);
            this.Panel1.Controls.Add(this.btn_3);
            this.Panel1.Controls.Add(this.btn_cikis8);
            this.Panel1.Controls.Add(this.btn_8);
            this.Panel1.Controls.Add(this.btn_cikis2);
            this.Panel1.Controls.Add(this.btn_2);
            this.Panel1.Controls.Add(this.btn_1);
            this.Panel1.Location = new System.Drawing.Point(13, 13);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(479, 383);
            this.Panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(312, 80);
            this.textBox2.MaxLength = 9;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(126, 32);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(46, 80);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(126, 32);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // chc_bitis
            // 
            this.chc_bitis.AutoSize = true;
            this.chc_bitis.Location = new System.Drawing.Point(312, 42);
            this.chc_bitis.Name = "chc_bitis";
            this.chc_bitis.Size = new System.Drawing.Size(126, 22);
            this.chc_bitis.TabIndex = 1;
            this.chc_bitis.Text = "Manuel Giris";
            this.chc_bitis.UseVisualStyleBackColor = true;
            this.chc_bitis.CheckedChanged += new System.EventHandler(this.chc_bitis_CheckedChanged);
            // 
            // chc_baslangic
            // 
            this.chc_baslangic.AutoSize = true;
            this.chc_baslangic.Location = new System.Drawing.Point(46, 42);
            this.chc_baslangic.Name = "chc_baslangic";
            this.chc_baslangic.Size = new System.Drawing.Size(126, 22);
            this.chc_baslangic.TabIndex = 0;
            this.chc_baslangic.Text = "Manuel Giris";
            this.chc_baslangic.UseVisualStyleBackColor = true;
            this.chc_baslangic.CheckedChanged += new System.EventHandler(this.chc_baslangic_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bitis Durumu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baslangic Durumu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "------------------------------------------------------------------";
            // 
            // btn_cikis7
            // 
            this.btn_cikis7.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_cikis7.Enabled = false;
            this.btn_cikis7.Location = new System.Drawing.Point(252, 289);
            this.btn_cikis7.Name = "btn_cikis7";
            this.btn_cikis7.Size = new System.Drawing.Size(69, 57);
            this.btn_cikis7.TabIndex = 0;
            this.btn_cikis7.Text = "7";
            this.btn_cikis7.UseVisualStyleBackColor = false;
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.Crimson;
            this.btn_7.Enabled = false;
            this.btn_7.Location = new System.Drawing.Point(11, 289);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(69, 57);
            this.btn_7.TabIndex = 0;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            // 
            // btn_cikis6
            // 
            this.btn_cikis6.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_cikis6.Enabled = false;
            this.btn_cikis6.Location = new System.Drawing.Point(402, 226);
            this.btn_cikis6.Name = "btn_cikis6";
            this.btn_cikis6.Size = new System.Drawing.Size(69, 57);
            this.btn_cikis6.TabIndex = 0;
            this.btn_cikis6.Text = "4";
            this.btn_cikis6.UseVisualStyleBackColor = false;
            // 
            // btn_cikis1
            // 
            this.btn_cikis1.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_cikis1.Enabled = false;
            this.btn_cikis1.Location = new System.Drawing.Point(252, 163);
            this.btn_cikis1.Name = "btn_cikis1";
            this.btn_cikis1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_cikis1.Size = new System.Drawing.Size(69, 57);
            this.btn_cikis1.TabIndex = 0;
            this.btn_cikis1.Text = "1";
            this.btn_cikis1.UseVisualStyleBackColor = false;
            // 
            // btn_cikis3
            // 
            this.btn_cikis3.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_cikis3.Enabled = false;
            this.btn_cikis3.Location = new System.Drawing.Point(402, 162);
            this.btn_cikis3.Name = "btn_cikis3";
            this.btn_cikis3.Size = new System.Drawing.Size(69, 57);
            this.btn_cikis3.TabIndex = 0;
            this.btn_cikis3.Text = "3";
            this.btn_cikis3.UseVisualStyleBackColor = false;
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.Crimson;
            this.btn_6.Enabled = false;
            this.btn_6.Location = new System.Drawing.Point(161, 226);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(69, 57);
            this.btn_6.TabIndex = 0;
            this.btn_6.Text = "4";
            this.btn_6.UseVisualStyleBackColor = false;
            // 
            // btn_cikis4
            // 
            this.btn_cikis4.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_cikis4.Enabled = false;
            this.btn_cikis4.Location = new System.Drawing.Point(252, 226);
            this.btn_cikis4.Name = "btn_cikis4";
            this.btn_cikis4.Size = new System.Drawing.Size(69, 57);
            this.btn_cikis4.TabIndex = 0;
            this.btn_cikis4.Text = "8";
            this.btn_cikis4.UseVisualStyleBackColor = false;
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.Crimson;
            this.btn_4.Enabled = false;
            this.btn_4.Location = new System.Drawing.Point(11, 226);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(69, 57);
            this.btn_4.TabIndex = 0;
            this.btn_4.Text = "6";
            this.btn_4.UseVisualStyleBackColor = false;
            // 
            // btn_cikis9
            // 
            this.btn_cikis9.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_cikis9.Enabled = false;
            this.btn_cikis9.Location = new System.Drawing.Point(402, 289);
            this.btn_cikis9.Name = "btn_cikis9";
            this.btn_cikis9.Size = new System.Drawing.Size(69, 57);
            this.btn_cikis9.TabIndex = 0;
            this.btn_cikis9.Text = "5";
            this.btn_cikis9.UseVisualStyleBackColor = false;
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.Crimson;
            this.btn_9.Enabled = false;
            this.btn_9.Location = new System.Drawing.Point(161, 289);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(69, 57);
            this.btn_9.TabIndex = 0;
            this.btn_9.Text = "0";
            this.btn_9.UseVisualStyleBackColor = false;
            // 
            // btn_cikis5
            // 
            this.btn_cikis5.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_cikis5.Enabled = false;
            this.btn_cikis5.Location = new System.Drawing.Point(328, 226);
            this.btn_cikis5.Name = "btn_cikis5";
            this.btn_cikis5.Size = new System.Drawing.Size(69, 57);
            this.btn_cikis5.TabIndex = 0;
            this.btn_cikis5.Text = "0";
            this.btn_cikis5.UseVisualStyleBackColor = false;
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.Crimson;
            this.btn_5.Enabled = false;
            this.btn_5.Location = new System.Drawing.Point(86, 226);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(69, 57);
            this.btn_5.TabIndex = 0;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Crimson;
            this.btn_3.Enabled = false;
            this.btn_3.Location = new System.Drawing.Point(161, 163);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(69, 57);
            this.btn_3.TabIndex = 0;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            // 
            // btn_cikis8
            // 
            this.btn_cikis8.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_cikis8.Enabled = false;
            this.btn_cikis8.Location = new System.Drawing.Point(327, 289);
            this.btn_cikis8.Name = "btn_cikis8";
            this.btn_cikis8.Size = new System.Drawing.Size(69, 57);
            this.btn_cikis8.TabIndex = 0;
            this.btn_cikis8.Text = "6";
            this.btn_cikis8.UseVisualStyleBackColor = false;
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.Crimson;
            this.btn_8.Enabled = false;
            this.btn_8.Location = new System.Drawing.Point(86, 289);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(69, 57);
            this.btn_8.TabIndex = 0;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            // 
            // btn_cikis2
            // 
            this.btn_cikis2.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_cikis2.Enabled = false;
            this.btn_cikis2.Location = new System.Drawing.Point(327, 163);
            this.btn_cikis2.Name = "btn_cikis2";
            this.btn_cikis2.Size = new System.Drawing.Size(69, 57);
            this.btn_cikis2.TabIndex = 0;
            this.btn_cikis2.Text = "2";
            this.btn_cikis2.UseVisualStyleBackColor = false;
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Crimson;
            this.btn_2.Enabled = false;
            this.btn_2.Location = new System.Drawing.Point(86, 163);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(69, 57);
            this.btn_2.TabIndex = 0;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Crimson;
            this.btn_1.Enabled = false;
            this.btn_1.Location = new System.Drawing.Point(11, 163);
            this.btn_1.Name = "btn_1";
            this.btn_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_1.Size = new System.Drawing.Size(69, 57);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            // 
            // baslangıclabel
            // 
            this.baslangıclabel.AutoSize = true;
            this.baslangıclabel.Location = new System.Drawing.Point(900, 58);
            this.baslangıclabel.Name = "baslangıclabel";
            this.baslangıclabel.Size = new System.Drawing.Size(0, 18);
            this.baslangıclabel.TabIndex = 3;
            // 
            // bitislabel
            // 
            this.bitislabel.AutoSize = true;
            this.bitislabel.Location = new System.Drawing.Point(900, 93);
            this.bitislabel.Name = "bitislabel";
            this.bitislabel.Size = new System.Drawing.Size(0, 18);
            this.bitislabel.TabIndex = 3;
            // 
            // btn_Astar
            // 
            this.btn_Astar.BackColor = System.Drawing.Color.MintCream;
            this.btn_Astar.Location = new System.Drawing.Point(13, 417);
            this.btn_Astar.Name = "btn_Astar";
            this.btn_Astar.Size = new System.Drawing.Size(479, 81);
            this.btn_Astar.TabIndex = 1;
            this.btn_Astar.Text = "Başlat";
            this.btn_Astar.UseVisualStyleBackColor = false;
            this.btn_Astar.Click += new System.EventHandler(this.btn_Astar_Click);
            // 
            // textBox_Adimlar
            // 
            this.textBox_Adimlar.Location = new System.Drawing.Point(501, 55);
            this.textBox_Adimlar.Multiline = true;
            this.textBox_Adimlar.Name = "textBox_Adimlar";
            this.textBox_Adimlar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Adimlar.Size = new System.Drawing.Size(145, 443);
            this.textBox_Adimlar.TabIndex = 4;
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.Font = new System.Drawing.Font("MV Boli", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_durum.Location = new System.Drawing.Point(498, 22);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(53, 17);
            this.lbl_durum.TabIndex = 5;
            this.lbl_durum.Text = "Durum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(712, 509);
            this.Controls.Add(this.lbl_durum);
            this.Controls.Add(this.textBox_Adimlar);
            this.Controls.Add(this.baslangıclabel);
            this.Controls.Add(this.btn_Astar);
            this.Controls.Add(this.bitislabel);
            this.Controls.Add(this.Panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "A star uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cikis7;
        private System.Windows.Forms.Button btn_cikis6;
        private System.Windows.Forms.Button btn_cikis4;
        private System.Windows.Forms.Button btn_cikis9;
        private System.Windows.Forms.Button btn_cikis5;
        private System.Windows.Forms.Button btn_cikis3;
        private System.Windows.Forms.Button btn_cikis8;
        private System.Windows.Forms.Button btn_cikis2;
        private System.Windows.Forms.Button btn_cikis1;
        private System.Windows.Forms.Button btn_Astar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chc_bitis;
        private System.Windows.Forms.CheckBox chc_baslangic;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.TextBox textBox_Adimlar;
        private System.Windows.Forms.Label bitislabel;
        private System.Windows.Forms.Label baslangıclabel;
        private System.Windows.Forms.Label lbl_durum;
    }
}


namespace ndp_proje1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_puan = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_sayac = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_orgatik = new System.Windows.Forms.Button();
            this.listBox_orgatik = new System.Windows.Forms.ListBox();
            this.button_orgatikBosalt = new System.Windows.Forms.Button();
            this.progressBar_orgAtik = new System.Windows.Forms.ProgressBar();
            this.progressBar_kagit = new System.Windows.Forms.ProgressBar();
            this.button_kagitBosalt = new System.Windows.Forms.Button();
            this.listBox_kagit = new System.Windows.Forms.ListBox();
            this.button_kagit = new System.Windows.Forms.Button();
            this.progressBar_cam = new System.Windows.Forms.ProgressBar();
            this.button_camBosalt = new System.Windows.Forms.Button();
            this.listBox_cam = new System.Windows.Forms.ListBox();
            this.button_cam = new System.Windows.Forms.Button();
            this.progressBar_metal = new System.Windows.Forms.ProgressBar();
            this.button_metalBosalt = new System.Windows.Forms.Button();
            this.listBox_metal = new System.Windows.Forms.ListBox();
            this.button_metal = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(41, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "YENİ OYUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cikis
            // 
            this.button_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cikis.Location = new System.Drawing.Point(41, 385);
            this.button_cikis.Name = "button_cikis";
            this.button_cikis.Size = new System.Drawing.Size(152, 41);
            this.button_cikis.TabIndex = 3;
            this.button_cikis.Text = "ÇIKIŞ";
            this.button_cikis.UseVisualStyleBackColor = true;
            this.button_cikis.Click += new System.EventHandler(this.button_cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "ATIK KUTULARI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(258, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 51);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button_cikis);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(13, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 449);
            this.panel2.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Maroon;
            this.panel7.Controls.Add(this.label_puan);
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(41, 290);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(152, 58);
            this.panel7.TabIndex = 10;
            // 
            // label_puan
            // 
            this.label_puan.AutoSize = true;
            this.label_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_puan.Location = new System.Drawing.Point(46, 16);
            this.label_puan.Name = "label_puan";
            this.label_puan.Size = new System.Drawing.Size(27, 29);
            this.label_puan.TabIndex = 5;
            this.label_puan.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Controls.Add(this.label_sayac);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(41, 153);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(152, 56);
            this.panel5.TabIndex = 9;
            // 
            // label_sayac
            // 
            this.label_sayac.AutoSize = true;
            this.label_sayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sayac.Location = new System.Drawing.Point(46, 12);
            this.label_sayac.Name = "label_sayac";
            this.label_sayac.Size = new System.Drawing.Size(27, 29);
            this.label_sayac.TabIndex = 5;
            this.label_sayac.Text = "0";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(41, 245);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(152, 39);
            this.panel6.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "PUAN";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(41, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 38);
            this.panel4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SÜRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(13, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 183);
            this.panel3.TabIndex = 8;
            // 
            // button_orgatik
            // 
            this.button_orgatik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_orgatik.Location = new System.Drawing.Point(291, 80);
            this.button_orgatik.Name = "button_orgatik";
            this.button_orgatik.Size = new System.Drawing.Size(158, 36);
            this.button_orgatik.TabIndex = 9;
            this.button_orgatik.Text = "ORGANİK ATIK";
            this.button_orgatik.UseVisualStyleBackColor = true;
            this.button_orgatik.Click += new System.EventHandler(this.button_orgatik_Click);
            // 
            // listBox_orgatik
            // 
            this.listBox_orgatik.FormattingEnabled = true;
            this.listBox_orgatik.ItemHeight = 16;
            this.listBox_orgatik.Location = new System.Drawing.Point(291, 122);
            this.listBox_orgatik.Name = "listBox_orgatik";
            this.listBox_orgatik.Size = new System.Drawing.Size(158, 148);
            this.listBox_orgatik.TabIndex = 10;
            // 
            // button_orgatikBosalt
            // 
            this.button_orgatikBosalt.Location = new System.Drawing.Point(291, 309);
            this.button_orgatikBosalt.Name = "button_orgatikBosalt";
            this.button_orgatikBosalt.Size = new System.Drawing.Size(158, 36);
            this.button_orgatikBosalt.TabIndex = 11;
            this.button_orgatikBosalt.Text = "BOŞALT";
            this.button_orgatikBosalt.UseVisualStyleBackColor = true;
            this.button_orgatikBosalt.Click += new System.EventHandler(this.button_orgatikBosalt_Click);
            // 
            // progressBar_orgAtik
            // 
            this.progressBar_orgAtik.Location = new System.Drawing.Point(291, 280);
            this.progressBar_orgAtik.Name = "progressBar_orgAtik";
            this.progressBar_orgAtik.Size = new System.Drawing.Size(158, 23);
            this.progressBar_orgAtik.TabIndex = 12;
            // 
            // progressBar_kagit
            // 
            this.progressBar_kagit.Location = new System.Drawing.Point(587, 280);
            this.progressBar_kagit.Name = "progressBar_kagit";
            this.progressBar_kagit.Size = new System.Drawing.Size(158, 23);
            this.progressBar_kagit.TabIndex = 16;
            // 
            // button_kagitBosalt
            // 
            this.button_kagitBosalt.Location = new System.Drawing.Point(587, 309);
            this.button_kagitBosalt.Name = "button_kagitBosalt";
            this.button_kagitBosalt.Size = new System.Drawing.Size(158, 36);
            this.button_kagitBosalt.TabIndex = 15;
            this.button_kagitBosalt.Text = "BOŞALT";
            this.button_kagitBosalt.UseVisualStyleBackColor = true;
            this.button_kagitBosalt.Click += new System.EventHandler(this.button_kagitBosalt_Click);
            // 
            // listBox_kagit
            // 
            this.listBox_kagit.FormattingEnabled = true;
            this.listBox_kagit.ItemHeight = 16;
            this.listBox_kagit.Location = new System.Drawing.Point(587, 122);
            this.listBox_kagit.Name = "listBox_kagit";
            this.listBox_kagit.Size = new System.Drawing.Size(158, 148);
            this.listBox_kagit.TabIndex = 14;
            // 
            // button_kagit
            // 
            this.button_kagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kagit.Location = new System.Drawing.Point(587, 80);
            this.button_kagit.Name = "button_kagit";
            this.button_kagit.Size = new System.Drawing.Size(158, 36);
            this.button_kagit.TabIndex = 13;
            this.button_kagit.Text = "KAĞIT";
            this.button_kagit.UseVisualStyleBackColor = true;
            this.button_kagit.Click += new System.EventHandler(this.button_kagit_Click);
            // 
            // progressBar_cam
            // 
            this.progressBar_cam.Location = new System.Drawing.Point(291, 572);
            this.progressBar_cam.Name = "progressBar_cam";
            this.progressBar_cam.Size = new System.Drawing.Size(158, 23);
            this.progressBar_cam.TabIndex = 20;
            // 
            // button_camBosalt
            // 
            this.button_camBosalt.Location = new System.Drawing.Point(291, 604);
            this.button_camBosalt.Name = "button_camBosalt";
            this.button_camBosalt.Size = new System.Drawing.Size(158, 36);
            this.button_camBosalt.TabIndex = 19;
            this.button_camBosalt.Text = "BOŞALT";
            this.button_camBosalt.UseVisualStyleBackColor = true;
            this.button_camBosalt.Click += new System.EventHandler(this.button_camBosalt_Click);
            // 
            // listBox_cam
            // 
            this.listBox_cam.FormattingEnabled = true;
            this.listBox_cam.ItemHeight = 16;
            this.listBox_cam.Location = new System.Drawing.Point(291, 414);
            this.listBox_cam.Name = "listBox_cam";
            this.listBox_cam.Size = new System.Drawing.Size(158, 148);
            this.listBox_cam.TabIndex = 18;
            // 
            // button_cam
            // 
            this.button_cam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cam.Location = new System.Drawing.Point(291, 372);
            this.button_cam.Name = "button_cam";
            this.button_cam.Size = new System.Drawing.Size(158, 36);
            this.button_cam.TabIndex = 17;
            this.button_cam.Text = "CAM";
            this.button_cam.UseVisualStyleBackColor = true;
            this.button_cam.Click += new System.EventHandler(this.button_cam_Click);
            // 
            // progressBar_metal
            // 
            this.progressBar_metal.Location = new System.Drawing.Point(587, 572);
            this.progressBar_metal.Name = "progressBar_metal";
            this.progressBar_metal.Size = new System.Drawing.Size(158, 23);
            this.progressBar_metal.TabIndex = 24;
            // 
            // button_metalBosalt
            // 
            this.button_metalBosalt.Location = new System.Drawing.Point(587, 604);
            this.button_metalBosalt.Name = "button_metalBosalt";
            this.button_metalBosalt.Size = new System.Drawing.Size(158, 36);
            this.button_metalBosalt.TabIndex = 23;
            this.button_metalBosalt.Text = "BOŞALT";
            this.button_metalBosalt.UseVisualStyleBackColor = true;
            this.button_metalBosalt.Click += new System.EventHandler(this.button_metalBosalt_Click);
            // 
            // listBox_metal
            // 
            this.listBox_metal.FormattingEnabled = true;
            this.listBox_metal.ItemHeight = 16;
            this.listBox_metal.Location = new System.Drawing.Point(587, 414);
            this.listBox_metal.Name = "listBox_metal";
            this.listBox_metal.Size = new System.Drawing.Size(158, 148);
            this.listBox_metal.TabIndex = 22;
            // 
            // button_metal
            // 
            this.button_metal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_metal.Location = new System.Drawing.Point(587, 372);
            this.button_metal.Name = "button_metal";
            this.button_metal.Size = new System.Drawing.Size(158, 36);
            this.button_metal.TabIndex = 21;
            this.button_metal.Text = "METAL";
            this.button_metal.UseVisualStyleBackColor = true;
            this.button_metal.Click += new System.EventHandler(this.button_metal_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(807, 659);
            this.Controls.Add(this.progressBar_metal);
            this.Controls.Add(this.button_metalBosalt);
            this.Controls.Add(this.listBox_metal);
            this.Controls.Add(this.button_metal);
            this.Controls.Add(this.progressBar_cam);
            this.Controls.Add(this.button_camBosalt);
            this.Controls.Add(this.listBox_cam);
            this.Controls.Add(this.button_cam);
            this.Controls.Add(this.progressBar_kagit);
            this.Controls.Add(this.button_kagitBosalt);
            this.Controls.Add(this.listBox_kagit);
            this.Controls.Add(this.button_kagit);
            this.Controls.Add(this.progressBar_orgAtik);
            this.Controls.Add(this.button_orgatikBosalt);
            this.Controls.Add(this.listBox_orgatik);
            this.Controls.Add(this.button_orgatik);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ATIK TOPLAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_sayac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_puan;
        private System.Windows.Forms.Button button_orgatik;
        private System.Windows.Forms.ListBox listBox_orgatik;
        private System.Windows.Forms.Button button_orgatikBosalt;
        private System.Windows.Forms.ProgressBar progressBar_orgAtik;
        private System.Windows.Forms.ProgressBar progressBar_kagit;
        private System.Windows.Forms.Button button_kagitBosalt;
        private System.Windows.Forms.ListBox listBox_kagit;
        private System.Windows.Forms.Button button_kagit;
        private System.Windows.Forms.ProgressBar progressBar_cam;
        private System.Windows.Forms.Button button_camBosalt;
        private System.Windows.Forms.ListBox listBox_cam;
        private System.Windows.Forms.Button button_cam;
        private System.Windows.Forms.ProgressBar progressBar_metal;
        private System.Windows.Forms.Button button_metalBosalt;
        private System.Windows.Forms.ListBox listBox_metal;
        private System.Windows.Forms.Button button_metal;
        private System.Windows.Forms.Timer timer1;
    }
}


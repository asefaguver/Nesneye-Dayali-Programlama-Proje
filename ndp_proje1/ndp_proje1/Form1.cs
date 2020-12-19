/****************************************************************************
**				   SAKARYA ÜNİVERSİTESİ
**				   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**				   2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Ahmet Sefa Güver
**				ÖĞRENCİ NUMARASI.......: G181210042
**              DERSİN ALINDIĞI GRUP...: 2-A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_proje1
{
    public partial class Form1 : Form
    {
        Kagit kgt = new Kagit(1200);    // atıkların özelliklerine değer atanır
        OrganikAtik org = new OrganikAtik(700);
        Cam cam = new Cam(2200);
        Metal mtl = new Metal(2300);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button_kagit.Enabled = false;
            button_kagitBosalt.Enabled = false;
            button_orgatik.Enabled = false;
            button_orgatikBosalt.Enabled = false;
            button_metal.Enabled = false;
            button_metalBosalt.Enabled = false;
            button_cam.Enabled = false;
            button_camBosalt.Enabled = false;
        }
        int resim;
        int sayi;

        public void ResimDegisti() // PictureBoxta random resim çıkarılmasını sağlayan fonksiyon
        {
            Random random = new Random(); // random class'ı oluşturuldu
            resim = random.Next(1, 9); // resim değişkenine 1 ile 9 arasında random değerler atanacak

            switch (resim)
            {
                case 1:
                    pictureBox1.ImageLocation = "1.jpg";
                    break;
                case 2:
                    pictureBox1.ImageLocation = "2.jpg";
                    break;
                case 3:
                    pictureBox1.ImageLocation = "3.jpg";
                    break;
                case 4:
                    pictureBox1.ImageLocation = "4.jpg";
                    break;
                case 5:
                    pictureBox1.ImageLocation = "5.jpg";
                    break;
                case 6:
                    pictureBox1.ImageLocation = "6.jpg";
                    break;
                case 7:
                    pictureBox1.ImageLocation = "7.jpg";
                    break;
                case 8:
                    pictureBox1.ImageLocation = "8.jpg";
                    break;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ResimDegisti();

            sayi = 60;
            timer1.Enabled = true; // timer aktif ediliyor
            timer1.Interval = 1000; // Saniyede bir çalışması için interval değeri 1000 girildi
           
            button_cam.Enabled = true;
            button_metal.Enabled = true; // yeni oyun butonuna tıklayınca butonlar aktif ediliyor
            button_kagit.Enabled = true;
            button_orgatik.Enabled = true;
            button_kagitBosalt.Enabled = true;
            button_metalBosalt.Enabled = true;
            button_camBosalt.Enabled = true;
            button_orgatikBosalt.Enabled = true;
            
            listBox_kagit.Items.Clear(); // yeni oyun başlayınca listboxlar temizleniyor
            listBox_orgatik.Items.Clear();
            listBox_cam.Items.Clear();
            listBox_metal.Items.Clear();

            progressBar_kagit.Value = 0; // yeni oyun başlayınca progressBar'lar sıfırlanıyor
            progressBar_orgAtik.Value = 0;
            progressBar_cam.Value = 0;
            progressBar_metal.Value = 0;

            label_puan.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi--;
            label_sayac.Text = sayi.ToString();
            if (sayi == 0)
            {
                timer1.Enabled = false; // süre dolunca butonlar kapanıyor
                button_cam.Enabled = false;
                button_metal.Enabled = false;
                button_kagit.Enabled = false;
                button_orgatik.Enabled = false;
                button_kagitBosalt.Enabled = false;
                button_metalBosalt.Enabled = false;
                button_camBosalt.Enabled = false;
                button_orgatikBosalt.Enabled = false;
            }
        }

        private void button_kagit_Click(object sender, EventArgs e)
        {
            progressBar_kagit.Minimum = 0;  // progressBar'ın max ve min değerleri girildi
            progressBar_kagit.Maximum = kgt.Kapasite;

            if (pictureBox1.ImageLocation == "2.jpg")
            {
                Gazete gz = new Gazete(250, Image.FromFile("2.jpg"));
                listBox_kagit.Items.Add("Gazete (250)");
                progressBar_kagit.Step = gz.Hacim; // gazete hacmi kadar progressBar ilerliyor
                progressBar_kagit.PerformStep();
            }

            else if (pictureBox1.ImageLocation == "1.jpg")
            {
                Dergi dg = new Dergi(200, Image.FromFile("1.jpg"));
                listBox_kagit.Items.Add("Dergi (200)");
                progressBar_kagit.Step = dg.Hacim; // dergi hacmi kadar progressBar ilerliyor
                progressBar_kagit.PerformStep();
            }
            if (progressBar_kagit.Value >= kgt.Kapasite)   // Atıkların hacmi kapasiteyi aşarsa button kapatılacak
            {
                button_kagit.Enabled = false;
            }

            ResimDegisti();

        }

        private void button_kagitBosalt_Click(object sender, EventArgs e)
        {
            kgt.Bosalt();

            if (progressBar_kagit.Value >= 900) // eğer kağıtlar kapasitenin %75 ve üzerinde ise boşaltıyoruz 
            {
                listBox_kagit.Items.Clear();
                int temp = Convert.ToInt32(label_puan.Text);
                temp += kgt.BosaltmaPuani;
                label_puan.Text = Convert.ToString(temp);
                progressBar_kagit.Value = 0;
                button_kagit.Enabled = true;
                sayi += 3;  // boşaltılınca süreye 3 saniye ekleniyor
            }
        }

        private void button_orgatik_Click(object sender, EventArgs e)
        {
            progressBar_orgAtik.Minimum = 0;
            progressBar_orgAtik.Maximum = org.Kapasite;
            if (pictureBox1.ImageLocation == "5.jpg")
            {
                Domates dmt = new Domates(150, Image.FromFile("5.jpg"));
                listBox_orgatik.Items.Add("Domates (150)");
                progressBar_orgAtik.Step = dmt.Hacim; // domates hacmi kadar progressBar ilerliyor
                progressBar_orgAtik.PerformStep();
            }
            else if (pictureBox1.ImageLocation == "6.jpg")
            {
                Salatalik slt = new Salatalik(120, Image.FromFile("6.jpg"));
                listBox_orgatik.Items.Add("Salatalik (120)");
                progressBar_orgAtik.Step = slt.Hacim; // salatalık hacmi kadar progressBar ilerliyor
                progressBar_orgAtik.PerformStep();
            }
            if (progressBar_orgAtik.Value >= org.Kapasite) // Atıkların hacmi kapasiteyi aşarsa button kapatılacak
            {
                button_orgatik.Enabled = false;
            }
            ResimDegisti();

        }

        private void button_orgatikBosalt_Click(object sender, EventArgs e)
        {
            org.Bosalt();
            if (progressBar_orgAtik.Value >= 525)   // eğer organik atıklar kapasitenin %75 ve üzerinde ise boşaltıyoruz
            {
                int temp = Convert.ToInt32(label_puan.Text);
                temp += 0;
                listBox_orgatik.Items.Clear();
                label_puan.Text = Convert.ToString(temp);
                progressBar_orgAtik.Value = 0;
                button_orgatik.Enabled = true;
                sayi += 3;  // boşaltılınca süreye 3 saniye ekleniyor
            }
        }

        private void button_cam_Click(object sender, EventArgs e)
        {
            progressBar_cam.Minimum = 0;
            progressBar_cam.Maximum = cam.Kapasite;
            if (pictureBox1.ImageLocation == "3.jpg")
            {
                Bardak bd = new Bardak(250, Image.FromFile("3.jpg"));
                listBox_cam.Items.Add("Bardak (250)");
                progressBar_cam.Step = bd.Hacim; // bardak hacmi kadar progressBar ilerliyor
                progressBar_cam.PerformStep();
            }
            else if (pictureBox1.ImageLocation == "4.jpg")
            {
                CamSise cs = new CamSise(600, Image.FromFile("4.jpg"));
                listBox_cam.Items.Add("Cam Sise (600)");
                progressBar_cam.Step = cs.Hacim; // cam sise hacmi kadar progressBar ilerliyor
                progressBar_cam.PerformStep();
            }
            if (progressBar_cam.Value>=cam.Kapasite)   // Atıkların hacmi kapasiteyi aşarsa button kapatılacak
            {
                button_cam.Enabled = false;
            }
            ResimDegisti();
        }

        private void button_camBosalt_Click(object sender, EventArgs e)
        {
            cam.Bosalt();
            if (progressBar_cam.Value >= 1650)  // eğer cam atıklar kapasitenin %75 ve üzerinde ise boşaltıyoruz
            {
                int temp = Convert.ToInt32(label_puan.Text);
                temp += cam.BosaltmaPuani;
                listBox_cam.Items.Clear();
                label_puan.Text = Convert.ToString(temp);
                progressBar_cam.Value = 0;
                button_cam.Enabled = true;
                sayi += 3;  // boşaltılınca süreye 3 saniye ekleniyor
            }
        }

        private void button_metal_Click(object sender, EventArgs e)
        {
            progressBar_metal.Minimum = 0;
            progressBar_metal.Maximum = mtl.Kapasite;

            if (pictureBox1.ImageLocation == "7.jpg")
            {
                KolaKutusu kk = new KolaKutusu(350, Image.FromFile("7.jpg"));
                listBox_metal.Items.Add("Kola Kutusu (350)");
                progressBar_metal.Step = kk.Hacim;  // kola kutusu hacmi kadar progressBar ilerliyor
                progressBar_metal.PerformStep();
            }
            else if (pictureBox1.ImageLocation == "8.jpg")
            {
                SalcaKutusu sk = new SalcaKutusu(550, Image.FromFile("8.jpg"));
                listBox_metal.Items.Add("Salca Kutusu (550)");
                progressBar_metal.Step = sk.Hacim; // salca kutusu hacmi kadar progressBar ilerliyor
                progressBar_metal.PerformStep();
            }
            if (progressBar_metal.Value>=mtl.Kapasite) // Atıkların hacmi kapasiteyi aşarsa button kapatılacak
            {
                button_metal.Enabled = false;
            }
            ResimDegisti();
        }

        private void button_metalBosalt_Click(object sender, EventArgs e)
        {
            mtl.Bosalt();
            if (progressBar_metal.Value >= 1725)    // eğer metal atıklar kapasitenin %75 ve üzerinde ise boşaltıyoruz
            {
                int temp = Convert.ToInt32(label_puan.Text);
                temp += mtl.BosaltmaPuani;
                listBox_metal.Items.Clear();
                label_puan.Text = Convert.ToString(temp);
                progressBar_metal.Value = 0;
                button_metal.Enabled = true;
                sayi += 3;  // boşaltılınca süreye 3 saniye ekleniyor
            }
        }

        private void button_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); // program kapanıyor
        }
    }
}

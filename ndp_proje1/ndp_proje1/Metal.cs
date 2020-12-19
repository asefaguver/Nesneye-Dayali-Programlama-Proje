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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje1
{
    class Metal:IDolabilen,IAtikKutusu
    {
        public int Kapasite { get; set; }
        public int DoluHacim { get; set; }
        public int DolulukOrani { get; set; }
        public int BosaltmaPuani { get; set; }
        
        KolaKutusu kk = new KolaKutusu(350, Image.FromFile("7.jpg"));       
        SalcaKutusu sk = new SalcaKutusu(550, Image.FromFile("8.jpg"));

        public Metal(int Kapasite)
        {
            this.Kapasite = Kapasite;
            this.BosaltmaPuani = BosaltmaPuani;
            
            BosaltmaPuani = 800;
        }
        public bool Bosalt()
        {
            if (DolulukOrani == (Kapasite * 3) / 4)
            {
                DoluHacim = 0;

            }
            return true;
        }
        public bool Ekle(IAtik atik)
        {
            if (atik == kk)
            {
                DoluHacim += 350;
            }
            else if (atik == sk)
            {
                DoluHacim += 550;
            }
            return true;
        }
    }
    class KolaKutusu : IAtik
    {
        private int _kolaHacim;
        public Image image7;
        public int Hacim { get { return _kolaHacim; } }
        public Image Image { get { return image7; } }
        public KolaKutusu(int kolaHacim, Image image7)
        {
            this._kolaHacim = kolaHacim;
            
        }
    }
    class SalcaKutusu : IAtik
    {
        private int _salcaHacim;
        public Image image8;
        public int Hacim { get { return _salcaHacim; } }
        public Image Image { get { return image8; } }
        public SalcaKutusu(int salcaHacim, Image image8)
        {
            this._salcaHacim = salcaHacim;
            
        }
    }
}

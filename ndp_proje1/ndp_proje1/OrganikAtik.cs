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
    class OrganikAtik : IDolabilen, IAtikKutusu
    {
        public int Kapasite { get; set; }
        public int DoluHacim { get; set; }
        public int DolulukOrani { get; set; }
        public int BosaltmaPuani { get; set; }

        Domates dmt = new Domates(150, Image.FromFile("5.jpg"));
        Salatalik slt = new Salatalik(120, Image.FromFile("6.jpg"));

        public OrganikAtik(int Kapasite)
        {
            this.Kapasite = Kapasite;
            
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
            if (atik == dmt)
            {
                DoluHacim += 150;
            }
            else if (atik == slt)
            {
                DoluHacim += 120;
            }
            return true;
        }
    }

    class Domates : IAtik
    {
        private int _dmtHacim;
        public Image image5;
        public int Hacim { get { return _dmtHacim; } }
        public Image Image { get { return image5; } }
        public Domates(int dmtHacim, Image image5)
        {
            this._dmtHacim = dmtHacim;
            //dmtHacim = 150;
        }
    }
    class Salatalik : IAtik
    {
        private int _sltHacim;
        public Image image6;
        public int Hacim { get { return _sltHacim; } }
        public Image Image { get { return image6; } }
        public Salatalik(int sltHacim, Image image6)
        {
            this._sltHacim = sltHacim;
            //sltHacim = 120;
        }
    }
}

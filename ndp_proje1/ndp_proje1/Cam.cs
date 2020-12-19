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
    class Cam : IDolabilen, IAtikKutusu
    {
        public int Kapasite { get; set; }
        public int DoluHacim { get; set; }
        public int DolulukOrani { get; set; }
        public int BosaltmaPuani { get; set; }
        
        Bardak brd = new Bardak(250, Image.FromFile("3.jpg"));
        CamSise cs = new CamSise(600, Image.FromFile("4.jpg"));

        public Cam(int Kapasite)
        {
            this.Kapasite = Kapasite;
            this.BosaltmaPuani = BosaltmaPuani;
            
            BosaltmaPuani = 600;
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
            if (atik == brd)
            {
                DoluHacim += 250;
            }
            else if (atik == cs)
            {
                DoluHacim += 600;
            }
            return true;

        }
    }
    class CamSise : IAtik
    {
        private int _camSiseHacim;
        public Image image4;

        public int Hacim { get { return _camSiseHacim; } }
        public Image Image { get { return image4; } }
        public CamSise(int camsiseHacim, Image image4)
        {
            this._camSiseHacim = camsiseHacim;
            
        }
    }
    class Bardak : IAtik
    {
        private int _bardakHacim;
        public Image image3;

        public int Hacim { get { return _bardakHacim; } }
        public Image Image { get { return image3; } }
        public Bardak(int bardakHacim, Image image3)
        {
            this._bardakHacim = bardakHacim;
            
        }
    }
}

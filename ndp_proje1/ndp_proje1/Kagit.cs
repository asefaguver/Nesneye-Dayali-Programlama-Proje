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
    class Kagit : IDolabilen, IAtikKutusu
    {
        public int Kapasite { get; set; }
        public int DoluHacim { get; set; }
        public int DolulukOrani { get; set; }
        public int BosaltmaPuani { get; set; }
        

        Gazete gz = new Gazete(250, Image.FromFile("2.jpg"));
        Dergi dg = new Dergi(200, Image.FromFile("1.jpg"));

        public Kagit(int Kapasite)
        {
            this.Kapasite = Kapasite;
            this.BosaltmaPuani = BosaltmaPuani;
           
            BosaltmaPuani = 1000;
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
           if(atik == gz)
            {
                DoluHacim += 250;
            }
           else if(atik == dg)
            {
                DoluHacim += 200;
            }
            return true;            
        }
    }
    class Gazete : IAtik
    {
        private int _gztHacim;
        public Image image2;
        public int Hacim { get { return _gztHacim; } }
        public Image Image { get { return image2; } }
        public Gazete(int gztHacim, Image image2)
        {
            this._gztHacim = gztHacim;
            
        }
    }
    class Dergi : IAtik
    {
        private int _dergiHacim;
        public Image image1;
        public int Hacim { get { return _dergiHacim; } }
        public Image Image { get { return image1; } }
        public Dergi(int drgHacim, Image image1)
        {
            this._dergiHacim = drgHacim;
            //drgHacim = 200;

        }
    }
}

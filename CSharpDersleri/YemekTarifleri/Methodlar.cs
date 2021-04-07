using System;
using System.Collections.Generic;
using System.Text;
using YemekTarifleri.Models;

namespace YemekTarifleri
{
    public class Methodlar
    {
        public List<Yemek> yemekler = new List<Yemek>();

        
        public void YemekEkle(string yAdi, string yTarifi)
        {
            yemekler.Add(new Yemek { YemekAdi = yAdi, YemekTarifi = yTarifi });
        }

        public bool YemekBul(string yemekAdi)
        {
            var bulunanYemek = yemekler.Find(y => y.YemekAdi == yemekAdi);
            if (bulunanYemek != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void YemekTarifiDüzenle(string yemekAdi, string yeniTarif)
        {
           var bulunanYemek =  yemekler.Find(y => y.YemekAdi == yemekAdi);
           bulunanYemek.YemekTarifi = yeniTarif;
        }

        public void YemekSil(string yAdi)
        {
            var bulunanYemek = yemekler.Find(y => y.YemekAdi == yAdi);
            yemekler.Remove(bulunanYemek);
        }

        public string YemekAra(string yAdi)
        {
            var bulunanYemek = yemekler.Find(y => y.YemekAdi == yAdi);
            return bulunanYemek.YemekTarifi;
        }
        public void YemekleriListele()
        {
            foreach (var yemek in yemekler)
            {
                Console.WriteLine(yemek.YemekAdi);
            }   
        }
    }
}

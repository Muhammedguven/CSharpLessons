using ListsAndClasses.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListsAndClasses
{
    public class Database
    {

        List<Urun> Teknoloji = new List<Urun>();
        List<Ketegori> Ketegoriler = new List<Ketegori>();
        List<Kullanici> Kullanicilar = new List<Kullanici>();
        public Database()
        {
            Teknoloji.Add(new Urun() { UrunId = 1, UrunAdi = "Bilgisayar", StokSayisi = 50 });
            Teknoloji.Add(new Urun() { UrunId = 2, UrunAdi = "Buzdolabı", StokSayisi = 20 });
            Teknoloji.Add(new Urun() { UrunId = 3, UrunAdi = "Çamaşır Makinesi", StokSayisi = 30 });

            Ketegoriler.Add(new Ketegori() { KategoriId = 1, KategoriAdi = "4*4" });
            Ketegoriler.Add(new Ketegori() { KategoriId = 2, KategoriAdi = "Giyim" });

            Kullanicilar.Add(new Kullanici() { KullaniciId = 1, KullaniciAdi = "Muhammed", KullaniciEmail = "muhammed@mgmail.com" });
            Kullanicilar.Add(new Kullanici() { KullaniciId = 2, KullaniciAdi = "Güven", KullaniciEmail = "muhammedgüven@mgmail.com" });
        }

        public void UrunEkle(Urun urun)
        {
            Teknoloji.Add(urun);
        }
        public void UrunSil(Urun urun)
        {
            Teknoloji.Remove(urun);
            
        }
        public void UrunleriGoster()
        {
            foreach (var urun in Teknoloji)
            {
                var urunAdi = urun.UrunAdi;
                Console.WriteLine("Ürün Adı : "+ urunAdi);
            }
        }
        public void KategorileriGoster()
        {
            foreach (var kategori in Ketegoriler)
            {
                var kategoriAdi = kategori.KategoriAdi;
                Console.WriteLine("Kategori Adı : " + kategoriAdi);
            }
        }
        public void KullanicilariGoster()
        {
            foreach (var kullanici in Kullanicilar)
            {
                var kullaniciAdi = kullanici.KullaniciAdi;
                Console.WriteLine("Kullanıcı Adı : " + kullaniciAdi);
                Console.WriteLine("Kullanıcı Email : " + kullanici.KullaniciEmail);
            }
        }
    }
}

using ListsAndClasses.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ListsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
            /*
             Yemek tarifi programı
            1-Yemek Ekle --> Yemek Adi, Yemeğin tarifini gir
            2-Yemek Düzenle --> Yemek Adina göre tarifini düzenle
            3-Yemek Sil --> Yemek adini ve yemeğin tarifini silecek
            4-Yemek Ara -->Yemek adını gir tarifi getirsin
            5-Yemek Listele --> Tüm yemek adlarını listelesin
            6-Çıkış
             */
        }
        static Database database = new Database();
        public static void Menu()
        {
            

            Console.WriteLine("**************");
            Console.WriteLine("1-Ürünleri Göster");
            Console.WriteLine("2-Kategorileri Göster");
            Console.WriteLine("3-Kullanıcıları Göster");
            Console.WriteLine("4-Urun Ekle");
            Console.WriteLine("**************");

            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    database.UrunleriGoster();
                    
                    break;
                case "2":
                    database.KategorileriGoster();
                    break;
                case "3":
                    database.KullanicilariGoster();
                    break;
                case "4":
                    Console.WriteLine("Ürün idsi gir:");
                    var urunId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ürün adi gir:");
                    var urunAdi = Console.ReadLine();
                    Console.WriteLine("Ürün stok gir:");
                    var urunStok = Convert.ToInt32(Console.ReadLine());
                    database.UrunEkle(new Urun() { UrunId = urunId, UrunAdi = urunAdi, StokSayisi = urunStok });
                    Console.WriteLine("Ürün başarıyla eklendi");
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Hatalı giriş");
                    break;
            }
        }
    }
}

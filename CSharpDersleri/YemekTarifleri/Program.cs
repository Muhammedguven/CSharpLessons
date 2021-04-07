using System;
using System.Collections.Generic;

namespace YemekTarifleri
{
    class Program
    {
        /*
             Yemek tarifi programı
            1-Yemek Ekle --> Yemek Adi, Yemeğin tarifini gir
            2-Yemek Düzenle --> Yemek Adina göre tarifini düzenle
            3-Yemek Sil --> Yemek adini ve yemeğin tarifini silecek
            4-Yemek Ara -->Yemek adını gir tarifi getirsin
            5-Yemek Listele --> Tüm yemek adlarını listelesin
            6-Çıkış
             */
        /*List<string> Yemekler = new List<string>();
        List<string> Tarifler = new List<string>();
        Yemekler.Add("fasülye");//[0]
        Tarifler.Add("tarifii");//[0] */

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Methodlar methodlar = new Methodlar();
            while (true)
            {
                Menu();
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Yemek Adını Giriniz");
                        string yemekAdi = Console.ReadLine();
                        Console.WriteLine("Yemek Tarifini Giriniz");
                        string yemekTarifi = Console.ReadLine();
                        methodlar.YemekEkle(yemekAdi, yemekTarifi);
                        break;


                    case 2:
                        Console.WriteLine("Aradığın Yemeğin Adını Yaz:");
                        string aranan=  Console.ReadLine();
                        var sonuc = methodlar.YemekBul(aranan);
                        if (sonuc == true)
                        {
                            Console.WriteLine("Yemek Bulundu Tarifi Yazınız:");
                            string yeniTarifim = Console.ReadLine();
                            methodlar.YemekTarifiDüzenle(aranan, yeniTarifim);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yemek bulunamadı!");
                            break;
                        }
                    case 3:
                        Console.WriteLine("Silmek istediğiniz yemeğin adını giriniz:");
                        string silinmekIstenen = Console.ReadLine();
                        var sonuc2 = methodlar.YemekBul(silinmekIstenen);
                        if (sonuc2)
                        {
                            methodlar.YemekSil(silinmekIstenen);
                            Console.WriteLine("Yemek başarıyla silindi");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yemek bulunamadı");
                            break;
                        }
                    case 4:
                        Console.WriteLine("Aradığın tarifin yemek adını giriniz");
                        string arananYemek = Console.ReadLine();
                        var sonuc3 = methodlar.YemekBul(arananYemek);
                        if (sonuc3)
                        {
                            Console.Write("TARİF: ");
                            Console.WriteLine(methodlar.YemekAra(arananYemek));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yemek bulunamadı");
                            break;
                        }
                        

                    case 5:
                        Console.WriteLine("***KAYITLI YEMEKLER****");
                        methodlar.YemekleriListele();
                        Console.WriteLine("********************");
                        break;

                    case 6:
                      
                        Environment.Exit(0);
                        break;


                }
            }
            
        }

        public static void Menu()
        {
            Console.WriteLine("********MENU********");
            Console.WriteLine("1-Yemek Ekle");
            Console.WriteLine("2-Yemek Tarifi Düzenle");
            Console.WriteLine("3-Yemek Sil");
            Console.WriteLine("4-Yemek Ara");
            Console.WriteLine("5-Yemek Liste");
            Console.WriteLine("6-Çıkış");
            Console.WriteLine("******************");
        }
    }
}

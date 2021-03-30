using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1-Not Ekle");
                Console.WriteLine("2-Notları Göster");
                Console.WriteLine("3-Not Sil");
                Console.WriteLine("Bir işlem seçiniz:");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        NotEkle();
                        break;
                    case "2":
                        NotlariGoster();
                        break;
                    case "3":
                        NotSil();
                        break;
                }
            }
        }

        static List<string> NotDefteri = new List<string>();
        public static void NotEkle()
        {
            Console.WriteLine("Eklemek istediğiniz notu giriniz:");
            
            NotDefteri.Add(Console.ReadLine());
        }
        public static void NotlariGoster()
        {
            Console.WriteLine("*****************");
            for (int i = 0; i < NotDefteri.Count; i++)
            {
                Console.WriteLine( i+ "-" + NotDefteri[i]);
            }
            Console.WriteLine("*****************");
        }
        public static void NotSil()
        {
            Console.WriteLine("Silmek istediğiniz notun indeksini giriniz:");
            int secim = Convert.ToInt32(Console.ReadLine());
            NotDefteri.Remove(NotDefteri[secim]);
        }
    }
}

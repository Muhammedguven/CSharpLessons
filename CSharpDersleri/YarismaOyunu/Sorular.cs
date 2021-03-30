using System;
using System.Collections.Generic;
using System.Text;

namespace YarismaOyunu
{
    public class Sorular
    {
        public int puan = 0;
        public  void Soru1()
        {
            Console.WriteLine("Aşşağıdakilerden hangisi renktir?");
            Console.WriteLine("1-Kedi");
            Console.WriteLine("2-Köpek");
            Console.WriteLine("3-Uçak");
            Console.WriteLine("4-Mürdüm");
            string cevap = Console.ReadLine();
            if (cevap == "4")
            {
                Console.WriteLine("Tebrikler");
                puan++;
            }
            else
            {
                Console.WriteLine("Yanlış cevapladınız :(");
            }
        }
        public  void Soru2()
        {
            Console.WriteLine("Aşşağıdakilerden hangisi hayvandır?");
            Console.WriteLine("1-Bilgisayar");
            Console.WriteLine("2-Köpek");
            Console.WriteLine("3-Uçak");
            Console.WriteLine("4-Mürdüm");
            string cevap = Console.ReadLine();
            if (cevap == "2")
            {
                Console.WriteLine("Tebrikler");
                puan++;
            }
            else
            {
                Console.WriteLine("Yanlış cevapladınız :(");
            }
        }
        public void Soru3()
        {
            Console.WriteLine("Aşşağıdakilerden hangisi köpek türüdür?");
            Console.WriteLine("1-Kedi");
            Console.WriteLine("2-Golden");
            Console.WriteLine("3-Uçak");
            Console.WriteLine("4-Mürdüm");
            string cevap = Console.ReadLine();
            if (cevap == "2")
            {
                Console.WriteLine("Tebrikler");
                puan++;
            }
            else
            {
                Console.WriteLine("Yanlış cevapladınız :(");
            }
        }
        public void Soru4()
        {
            Console.WriteLine("3x5 kaçtır?");
            Console.WriteLine("1-656");
            Console.WriteLine("2-25");
            Console.WriteLine("3-2");
            Console.WriteLine("4-15");
            string cevap = Console.ReadLine();
            if (cevap == "4")
            {
                Console.WriteLine("Tebrikler");
                puan++;
            }
            else
            {
                Console.WriteLine("Yanlış cevapladınız :(");
            }
        }
    }
}

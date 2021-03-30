using System;

namespace YarismaOyunu
{
    class Program
    {

        static void Main(string[] args)
        {
            Sorular benimSorular = new Sorular();//c# da bir classın obje oluşturması
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Yarışmamıza hoşgeldiniz");
            benimSorular.Soru1();
            benimSorular.Soru2();
            benimSorular.Soru3();
            benimSorular.Soru4();
            Console.WriteLine("YARIŞMA BİTTİ PUANINIZ " + benimSorular.puan * 25);

        }


    }
}

using System;

namespace NotUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // pekiyi iyi orta düşük kaldı

            long not = Convert.ToInt32(Console.ReadLine());

            while (true)
            {


                if (not < 100 && not >= 85)
                {
                    Console.WriteLine("Pekiyi");

                }
                else if (not < 85 && not >= 70)
                {
                    Console.WriteLine("İyi");
                }
                else if (not < 70 && not >= 50)
                {
                    Console.WriteLine("Orta");
                }
                else if (not < 50 && not >= 30)
                {
                    Console.WriteLine("Düşük");
                }
                else if (not < 30 && not >= 0)
                {
                    Console.WriteLine("Kaldı");
                }
                else
                {
                    Console.WriteLine("Yalan söyleme öyle bir not olmaz");
                }
                break;
            }
        }
    }
}

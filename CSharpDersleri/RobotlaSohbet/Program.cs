using System;

namespace RobotlaSohbet
{
    class Program
    {
        static void Main(string[] args)
        {
          
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                string mesaj = Console.ReadLine().ToLower();

                switch (mesaj)
                {
                    case "selam":
                        Console.WriteLine("selam naber");
                        break;
                    case "iyilik senden":
                        
                        Console.WriteLine("ben de iyiyim sağol");
                        break;
                    case "adın ne":
                        Console.WriteLine("Benim adım Abdülrezzak senin adın ne :)");
                        break;
                    case "benim adım ibrahim":
                        Console.WriteLine("Tanıştığımıza memnun oldum İbrahim Görüşürüz");
                        break;
                    case "görüşürüz":
                        Console.WriteLine("bb");
                        break;
                    default:
                        Console.WriteLine("ne dedin kanka anlamadım");
                        break;
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Alistirma
{
    class Program
    {
        static void Main(string[] args)
        {


            ConsoleKeyInfo islem;
            Console.WriteLine("Islemi seciniz");
            do
            {
                Console.WriteLine("\n\n\n\tA Maximum Ve Minimum Sayilari");
                Console.WriteLine("\n\n\n\tB Dizide ki sayilari sort yapan islem");
                islem = Console.ReadKey();

                if (islem.Key == ConsoleKey.A)

                {
                    int sayi;
                    Console.Write("Sayi adedini girin=> ");
                    sayi = Convert.ToInt32(Console.ReadLine());

                    int[] sayilar = new int[sayi];

                    for (int i = 0; i < sayilar.Length; i++)
                    {
                        Console.Write("Sayi gir=> ");
                        sayilar[i] = Convert.ToInt32(Console.ReadLine());


                    }
                    Console.WriteLine("Minimum sayi={0}", sayilar.Min());
                    Console.WriteLine("Maximum sayi={0}", sayilar.Max());
                    Console.ReadLine();
                }
                else if (islem.Key == ConsoleKey.B)
                {
                    int sayi;
                    int n;
                    Console.Write("Sayi adedini girin=> ");
                    sayi = Convert.ToInt32(Console.ReadLine());

                    int[] sayilar = new int[sayi];

                    for (int i = 0; i < sayilar.Length; i++)
                    {
                        Console.Write("Sayi gir=> ");
                        sayilar[i] = Convert.ToInt32(Console.ReadLine());
                    }
                        Array.Sort(sayilar);
                    foreach (int j in sayilar)
                    {
                        Console.WriteLine(">>>>{0}>>>>",j);
                        Console.Write("");


                    }
                    Console.WriteLine();
                }
            }
            while (true);
        }
    }
}

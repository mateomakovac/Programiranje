using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicialno_Ponavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAM 1

            //   int a = 100;
            //   int b = 3;
            //   double c = a / b;
            //   double d = a%b;

            //   Console.WriteLine("a dijelimo sa b i rezultat je:" + c);
            //   Console.WriteLine("Ostatak je :" + d);
            //  Console.ReadKey();



            //PROGRAM 2


            //  Console.WriteLine("Unesite niz znakova:");
            // string Zamjeni = Console.ReadLine();

            // Console.WriteLine(Zamjeni.Replace(' ', '_'));
            // Console.ReadKey();


            //PROGRAM 3

            // int a = 10;
            // int b = 7;
            // double c = 12.5;
            // double d = 16.7;

            // Console.WriteLine( (a + b + c + d) / 4 );
            // Console.ReadKey();


            //PROGRAM 4


            // Console.WriteLine("Unesite duljinu stranice x:");
            // if (!double.TryParse(Console.ReadLine(), out double x) || x <= 0)
            // {
            //    Console.WriteLine("Neispravan unos za x. Unesite pozitivan broj.");
            //    return;
            // }

            //    Console.WriteLine("Unesite duljinu stranice y:");
            //   if (!double.TryParse(Console.ReadLine(), out double y) || y <= 0)
            //   {
            //       Console.WriteLine("Neispravan unos za y. Unesite pozitivan broj.");
            //       return;
            //   }

            //     Console.WriteLine("Unesite duljinu hipotenuze z:");
            //    if (!double.TryParse(Console.ReadLine(), out double z) || z <= 0)
            //     {
            //        Console.WriteLine("Neispravan unos za z. Unesite pozitivan broj.");
            //      return;
            //   }

            //   if (JePravokutniTrokut(x, y, z))
            //  {
            //      Console.WriteLine("Uneseni brojevi predstavljaju stranice pravokutnog trokuta.");
            //  }
            //  else
            //   {
            //     Console.WriteLine("Uneseni brojevi ne predstavljaju stranice pravokutnog trokuta.");
            //  }

            // Console.ReadKey();



            //PROGRAM 5


            //String URl =Console.ReadLine();

            // if (URl.StartsWith("www.") && URl.EndsWith(".hr"))
            // {
            //  Console.WriteLine("Tocan URL!");
            // }
            // else
            // {
            //     Console.WriteLine("Netocan URL!");
            //  }



            //PROGRAM 6

            // Console.WriteLine("Unesite broj članova reda:");
            // if (!int.TryParse(Console.ReadLine(), out int brojClanova) || brojClanova <= 0)
            //  {
            //     Console.WriteLine("Neispravno!");
            //     return;
            //  }

            //  double suma = IzracunajSumuReda(brojClanova);

            //  Console.WriteLine($"Suma reda za {brojClanova} članova je: {suma}");
            //  Console.ReadKey();


















            //PROGRAM 7


            // int limit = 100;
            // int brojPrimBrojeva = IzracunajBrojPrimBrojeva(limit);

            //  Console.WriteLine($"Broj prim brojeva manjih od {limit} je: {brojPrimBrojeva}");
            //  Console.ReadKey();









            //PROGRAM 8



            Console.WriteLine("Unesite broj n:");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
            {
                Console.WriteLine("Neispravan unos za n. Unesite pozitivan cijeli broj veći od 0.");
                return;
            }

            int rezultat = IzracunajNtiClanFibonaccija(n);

            Console.WriteLine($"N-ti član Fibonaccijevog niza za n = {n} je: {rezultat}");
            Console.ReadKey();


















            //PROGRAM 9

            //   Console.WriteLine("Unesite članove niza odvojene razmakom:");


            //   string unos = Console.ReadLine();          
            //   string[] unosArray = unos.Split(' ');            
            //   int[] niz = new int[unosArray.Length];

            //    for (int i = 0; i < unosArray.Length; i++)
            //    {
            //        if (!int.TryParse(unosArray[i], out niz[i]))
            //        {
            //            Console.WriteLine("Brojeve unesi Majmune!!!");
            //            return;
            //        }
            //    }         
            //    Array.Sort(niz);
            //   
            //    Console.WriteLine("Sortirani niz:");
            //    foreach (int broj in niz)
            //    {
            //        Console.Write(broj + " ");
            //    }

            //    Console.ReadKey();






        }


        //ZA PROGAM 6
        //  static double IzracunajSumuReda(int brojClanova)
        // {
        //     double suma = 0.0;

        //      for (int i = 1; i <= brojClanova; i++)
        //     {
        //         suma += 1.0 / Math.Pow(3, i);
        //     }

        //     return suma;
        //  }





        // ZA PROGRAM 4
        //   static bool JePravokutniTrokut(double x, double y, double z)
        //   {

        //     double a, b, c;

        //     if (x > y && x > z)
        //     {
        //       c = x;
        //        a = y;
        //        b = z;
        //    }
        //    else if (y > x && y > z)
        //    {
        //        c = y;
        //        a = x;
        //       b = z;
        //    }
        //    else
        //    {
        //        c = z;
        //        a = x;
        //       b = y;
        //     }

        //     return (a * a) + (b * b) == (c * c);
        //   }





        //ZA PROGRAM 7 

        // static bool JePrimBroj(int broj)
        // {
        //    if (broj < 2)
        //       return false;

        //    for (int i = 2; i <= Math.Sqrt(broj); i++)
        //    {
        //        if (broj % i == 0)
        //            return false;
        //    }

        //    return true;
        //  }

        //   static int IzracunajBrojPrimBrojeva(int limit)
        //   {
        //     int brojPrimBrojeva = 0;

        //    for (int i = 2; i < limit; i++)
        //    {
        //       if (JePrimBroj(i))
        //       {
        //           brojPrimBrojeva++;
        //       }
        //   }

        //    return brojPrimBrojeva;
        //  }





        //ZA PROGRAM 8


        static int IzracunajNtiClanFibonaccija(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                int prviClan = 0;
                int drugiClan = 1;
                int rezultat = 0;

                for (int i = 3; i <= n; i++)
                {
                    rezultat = prviClan + drugiClan;
                    prviClan = drugiClan;
                    drugiClan = rezultat;
                }

                return rezultat;
            }
        }



















    }
}  


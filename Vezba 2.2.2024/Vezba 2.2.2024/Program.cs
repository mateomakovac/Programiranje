﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedivanje004
{
    /* internal class Program
     {

         class Biljka
         {

         }

         class Stablo : Biljka
         {
             bool otpadajuListovi;

             public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }

             public Stablo(bool otpadajuListovi)
             {
                 OtpadajuListovi = otpadajuListovi;
             }
         }

         class Cvijet : Biljka { }
         class Bijelogoricno : Stablo
         {
             public Bijelogoricno(bool otpadajuListovi) : base(otpadajuListovi)
             {
             }
         }

         class Crnogoricno : Stablo
         {
             public Crnogoricno(bool otpadajuListovi) : base(otpadajuListovi)
             {
             }
         }
         static void Main(string[] args)
         {
             Bijelogoricno Hrast = new Bijelogoricno(true);

             Crnogoricno Bor = new Crnogoricno(false);
             Console.WriteLine("Hrast otpadaju listovi: " + Hrast.OtpadajuListovi.ToString());
             Console.WriteLine("Bor otpadaju listovi: " + Bor.OtpadajuListovi.ToString());

             Console.ReadKey();
         }
     }
    */

    class GeometrijskiLik
    {
        int brojStranica;
        int[] Stranice = new int[10];

        public int BrojStranica { get => brojStranica; set => brojStranica = value; }
        public int[] Stranice1 { get => Stranice; set => Stranice = value; }

        public void UcitajStranice()
        {
            Console.WriteLine("Upiši duljinu stranica");
            for (int i = 0; i < BrojStranica; i++)
            {
                Console.WriteLine("Stranica br. ", i + 1);
                Stranice1[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public int Opseg(int[] Stranice)
        {
            int opseg = 0;
            for (int i = 0; i < BrojStranica; i++)
            {
                opseg += Stranice[i];
            }
            return opseg;
        }
    }
    class Trokut : GeometrijskiLik
    {
        public Trokut()
        {
            BrojStranica = 3;
        }
    }

    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut()
        {
            BrojStranica = 4;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Trokut tr = new Trokut();
            Cetverokut _4kut = new Cetverokut();

            Console.WriteLine("Trokut");
            tr.UcitajStranice();
            Console.WriteLine("Opseg trokuta je: " + tr.Opseg(tr.Stranice1));

            Console.WriteLine("Cetverokut");
            _4kut.UcitajStranice();
            Console.WriteLine("Opseg četverokute je: " + _4kut.Opseg(_4kut.Stranice1));

            Console.ReadKey();
        }
    }






}

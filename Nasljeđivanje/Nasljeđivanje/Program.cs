using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje
{
    internal class Program
    {
        class Brojevi
        {
            protected double broj;

            public double Broj
            {
                get { return broj; }
                set { broj = value; }
            }

            public virtual double ApsVrijednost()
            {
                return 0;
            }
        }

        class Cijeli : Brojevi
        {
            public override double ApsVrijednost()
            {
                return Math.Abs(broj);
            }
        }

        class Decimalni : Brojevi
        {
            public override double ApsVrijednost()
            {
                return Math.Abs(broj);
            }
        }

        class Pozitivni : Cijeli
        {
            public override double ApsVrijednost()
            {
                return broj;
            }
        }

        class Negativni : Cijeli
        {
            public override double ApsVrijednost()
            {
                return -broj;
            }
        }

        class Program_2
        {
            static void Main()
            {
                Pozitivni x = new Pozitivni();
                x.Broj = 100;

                Negativni y = new Negativni();
                y.Broj = -100;

                Decimalni z = new Decimalni();
                z.Broj = 100.45;

                Console.WriteLine($"Apsolutna vrijednost x: {x.ApsVrijednost()}");
                Console.WriteLine($"Apsolutna vrijednost y: {y.ApsVrijednost()}");
                Console.WriteLine($"Apsolutna vrijednost z: {z.ApsVrijednost()}");
                Console.ReadKey();
            }
        }
    }
}

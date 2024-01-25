using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje
{


    class Cat
    {
        public bool opasna;

        public bool Opasna { get => opasna; set => opasna = value; }



        public virtual void opasnost()
        {
            Opasna = false;
        }


    }



    class Gepard : Cat
    {
        public override void opasnost()
        {
            Opasna = true;
        }

    }






    internal class Program
    {
        static void Main(string[] args)
        {
            Gepard g = new Gepard();
            g.opasnost();

            Console.WriteLine(g.Opasna);
            Console.ReadKey();
        }

        

    }
}

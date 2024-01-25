using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programski_Jezik
{
    internal class Program
    {
       
        static void Main()
        {
            
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            
            UnesiPostotak(x);
            UnesiPostotak(y);
            UnesiPostotak(z);
            

            if (x.Postotak + y.Postotak + z.Postotak != 100)
            {
                Console.WriteLine("Zbroj MORA biti 100 glupavac !!!");
            }   
            else
            {              
                string najzastupljenijaVrsta = NajzastupljenijuVrstu(x, y, z);
                
               Console.WriteLine($"Najzastupljenija vrsta programskog jezika je: {najzastupljenijaVrsta}");            
            }
        }

        static void UnesiPostotak(ProgramskiJezik jezik)
        {
            Console.WriteLine($"Unesite postotak za {jezik.GetType().Name}: ");
            if (double.TryParse(Console.ReadLine(), out double postotak))
            {
                jezik.Postotak = postotak;
            }
            else
            {
                Console.WriteLine("Neispravan unos, Unesi Broj!");
                UnesiPostotak(jezik);
                
            }
        }

        static string NajzastupljenijuVrstu(Proceduralni x, Objektni y, Funkcionalni z)
        {

            Console.WriteLine();

            if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
            {
                return "Proceduralni";
            }
            else if (y.Postotak > x.Postotak && y.Postotak > z.Postotak)
            {
                return "Objektni";
            }
            else
            {
                return "Funkcionalni";
               
            }
        }
    }

    class ProgramskiJezik
    {
        private double postotak;

        public double Postotak
        {
            get { return postotak; }
            set { postotak = value; }
            
        }
    }
    
    class Proceduralni : ProgramskiJezik { }

    class Objektni : ProgramskiJezik { }

    class Funkcionalni : ProgramskiJezik { }

    
    
    
}


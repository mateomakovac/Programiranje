using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kecazaispravit3
{

    class Zrakoplov
    {
        private string Naziv;
        private double SnagaMotora;
        private int DosegLeta;


        public Zrakoplov(string naziv,double motor,int let)
        {
            Naziv = naziv;
            SnagaMotora = motor;
            DosegLeta = let;
        }

    }
    internal class Program
    {
        


        static void Main(string[] args)
        {
            Zrakoplov x360 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);
        }
    }
}

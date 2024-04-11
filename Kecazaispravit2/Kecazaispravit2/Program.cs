using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kecazaispravit2
{
      public class Sport
    {
        private string Naziv;
        private bool IgraLiSeLoptom;
        private byte BrojIgraca;
        
    
        public Sport(string nnaziv)
    {
        Naziv = nnaziv;
    }

    public Sport(string nnaziv,bool igra)
        {
            Naziv = nnaziv;
            IgraLiSeLoptom = igra;
        }


        public Sport(string nnaziv,bool igra,byte igraci)
        {
            Naziv = nnaziv;
            IgraLiSeLoptom = igra;
            BrojIgraca = igraci;
        }




}

internal class Program
    {
        static void Main(string[] args)
        {
            Sport Nogomet = new Sport("Nogomet", true, 20);
            Sport Vaterpolo = new Sport("Vaterpolo", true, 16);
            Sport Curling = new Sport("Curling", false, 60);
        }
    }
}

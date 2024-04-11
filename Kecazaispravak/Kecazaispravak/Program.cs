using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kecazaispravak
{

    public class Vozilo
    {
        public bool JeLiLeti { get; }
        public bool JeLiPlovi { get; }

        public Vozilo(bool leti, bool plovi)
        {
            JeLiLeti = leti;
            JeLiPlovi = plovi;
        }

        public void KudaVozi()
        {
            Console.Write("Ovo vozilo vozi ");
            if (JeLiLeti && JeLiPlovi)
                Console.WriteLine("u zraku i na vodi.");
            else if (JeLiLeti)
                Console.WriteLine("u zraku.");
            else if (JeLiPlovi)
                Console.WriteLine("na vodi.");
            else
                Console.WriteLine("na kopnu.");
        }
    }


    public class Brod : Vozilo
    {
        public Brod() : base(false, true) { }
    }

    public class Zrakoplov : Vozilo
    {
        public Zrakoplov() : base(true, false) { }
    }






    internal class Program
    {
        static void Main(string[] args)
        {
            Brod brod1 = new Brod();
           
            Zrakoplov zrakoplov1 = new Zrakoplov();
            

            Console.WriteLine("Brod  - Leti: " + brod1.JeLiLeti + ", Plovi: " + brod1.JeLiPlovi );
            brod1.KudaVozi();

            Console.WriteLine("Zrakoplov  - Leti: " + zrakoplov1.JeLiLeti + ", Plovi: " + zrakoplov1.JeLiPlovi);
           
            zrakoplov1.KudaVozi();


            Console.ReadKey();
        }
    }
}

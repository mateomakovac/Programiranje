﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebeskoTijelo
{

    class NebeskoTijelo
    {
        protected double BrzinaOkoOsi;
        protected double BrzinaOkOSunca;
    }


        class Planet : NebeskoTijelo
     {
        public Planet(double d1, double d2)
        {
            BrzinaOkoOsi = d1;
            BrzinaOkOSunca = d2;
        }

    }
     class Satelit : NebeskoTijelo
        {
            public Satelit(double d1,double d2)
            {
                BrzinaOkOSunca = d2;
                BrzinaOkoOsi = d1;
            }



        






    }











    internal class Program
    {
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(1000, 2000);
            Satelit Mjesec = new Satelit(100, 200);
        }


    }
}

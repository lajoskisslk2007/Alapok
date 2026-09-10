using System;
using System.Collections.Generic;
using System.Text;

namespace Bankszamla
{
    internal class Bankszla
    {
        private double egyenleg=10000;

        public void befizetés(double osszeg)
        {
            if (osszeg > 0)
            {
                egyenleg += osszeg;
                Console.WriteLine($"Befizetés:{osszeg} Ft. új egyenleg:{egyenleg}");
            }
            else
            {
                Console.WriteLine("A befizetés összege nem lehet negatív.");
            }
        }
        public void kivet(double osszeg)
        {
            if (osszeg > 0 && osszeg <= egyenleg)
            {
                egyenleg -= osszeg;
                Console.WriteLine($"Kifizetés: {osszeg} Ft. új egyenleg: {egyenleg} Ft.");
            }
            else
            {
                Console.WriteLine("A kifizetés összege nem lehete negatív vagy nagyobb, mint az egyenleg");
            }
        }
    }
}

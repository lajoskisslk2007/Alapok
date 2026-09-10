using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Jatekosok
{
    public class Jatekos
    {
        private int elet;
        public string nev { get; set; } 
        public int Elet
        {
            get { return elet; }
            set
            {
                if (value < 0)
                {
                    elet = 0;
                }
                else if (value > 100)
                {
                    elet = 100;
                }
                else
                {
                    elet = value;
                }
            }
        }
    }
}

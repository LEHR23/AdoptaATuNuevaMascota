using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptaATuNuevaMascota
{
    public class ave : Animal
    {
        private String tamañop;
        private double largopic;

        public ave()
        {
            tamañop = "";
            largopic = 0;
        }

        public void settamaño(String t)
        {
            tamañop = t;
        }
        public string gettamaño()
        {
            return tamañop;
        }
        public void setlargo(double n)
        {
            largopic = n;
        }
        public double getlargo()
        {
            return largopic;
        }

    }
}

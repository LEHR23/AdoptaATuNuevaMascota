using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptaATuNuevaMascota
{
    public class Perro : Animal
    {
        private double largoc;
        private int nmanchas;
        public Perro()
        {
            largoc = 0;
            nmanchas = 0;
        }
        public void setlargo(double l)
        {
            largoc = l;
        }
        public double getlargo()
        {
            return largoc;
        }
        public void setmanchas(int n)
        {
            nmanchas = n;
        }
        public int getmanchas()
        {
            return nmanchas;
        }
    }
}

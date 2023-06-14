using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptaATuNuevaMascota
{
    public class Gato : Animal
    {
        private String colorojo;
        private int pelosvi;

        public Gato() {
            colorojo = "";
            pelosvi = 0;
        }
        public void setcolorolo(String color)
        {
            colorojo = color;
        }
        public string getcolorojo()
        {
            return colorojo;
        }
        public void setnpelos(int n)
        {
            pelosvi = n;
        }
        public int getnpelos()
        {
            return pelosvi;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptaATuNuevaMascota
{
    public class cocodrilo : Animal
    {
        private int ndientes;
        
        public cocodrilo()
        {
            ndientes = 0;
        }
        public void setn_dientes(int n)
        {
            ndientes = n;
        }
        public int getdientes()
        {
            return ndientes;
        }
    }
}

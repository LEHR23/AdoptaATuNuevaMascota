using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptaATuNuevaMascota
{
    public class Persona
    {
        int edad;
        String nombre, genero;
        long NumeroTel;

        public Persona()
        {
            this.edad = 0;
            this.nombre = "";
            this.genero = "";
            NumeroTel = 0;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getGenero()
        {
            return genero;
        }

        public void setGenero(String genero)
        {
            this.genero = genero;
        }

        public long getNumerotelefonico()
        {
            return NumeroTel;
        }

        public void setNumerotelefonico(long nt)
        {
            this.NumeroTel = nt;
        }
    }
}

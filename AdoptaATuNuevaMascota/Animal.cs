using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptaATuNuevaMascota
{
    public class Animal
    {

        public String Nombre, fechaRescate, rancho, FechaAdop;
        public int Edad;
        public Boolean adoptado;
        public Persona objpersona;

        public Animal()
        {
            Nombre = "";
            fechaRescate = "";
            rancho = "";
            FechaAdop = "";
            Edad = 0;
            adoptado = false;
            objpersona = new Persona();
        }

        public void setNombre(String nombre)
        {
            Nombre = nombre;
        }

        public String getNombre()
        {
            return Nombre;
        }

        public void setFechaRescate(String FRescate)
        {
            fechaRescate = FRescate;
        }

        public String getFechaRescate()
        {
            return fechaRescate;
        }

        public void setRancho(String rencho)
        {
            rancho = rencho;
        }

        public String getRancho()
        {
            return rancho;
        }

        public void setFechaAdopcion(String FAdop)
        {
            FechaAdop = FAdop;
        }

        public String getFechaAdopcion()
        {
            return FechaAdop;
        }

        public void setEdad(int edad)
        {
            Edad = edad;
        }

        public int getEdad()
        {
            return Edad;
        }

        public void setAdoptado(Boolean si)
        {
            adoptado = si;
        }

        public Boolean getAdoptado()
        {
            return adoptado;
        }

        public void setdueño(Persona p)
        {
            objpersona = p;
        }

        public Persona getdueño()
        {
            return objpersona;
        }
    }
}

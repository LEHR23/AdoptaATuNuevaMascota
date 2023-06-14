using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptaATuNuevaMascota
{
    public class Listas
    {

        private List<Perro> listaperros;
        private List<Gato> listagatos;
        private List<ave> listaaves;
        private List<cocodrilo> listacocodrilos;

        public Listas()
        {
            listagatos = new List<Gato>();
            listaperros = new List<Perro>();
            listaaves = new List<ave>();
            listacocodrilos = new List<cocodrilo>();
        }

        public List<Perro> getListaperros()
        {
            return listaperros;
        }

        public List<Gato> getListagatos()
        {
            return listagatos;
        }

        public List<ave> getListaaves()
        {
            return listaaves;
        }

        public List<cocodrilo> getListacocodrilos()
        {
            return listacocodrilos;
        }

    }
}

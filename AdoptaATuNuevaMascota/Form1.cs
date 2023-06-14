using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdoptaATuNuevaMascota
{
    public partial class Form1 : Form
    {

        private Listas listas;
        private Animales_Recogidos ventanaAnimalesRecogidos;
        private Adoptar_Animal ventanaAdoptaranimal;
        private StreamWriter escribir;
        private StreamReader leer;

        public Form1()
        {
            InitializeComponent();
            ventanaAnimalesRecogidos = null;
            ventanaAdoptaranimal = null;
            listas = new Listas();
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\animales.txt"))
            {
                try
                {
                    leer = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\animales.txt");
                    Boolean leyendo = true;
                    Perro auxp = new Perro();
                    Gato auxg = new Gato();
                    ave auxa = new ave();
                    cocodrilo auxc = new cocodrilo();
                    Persona p = new Persona();
                    do {
                        switch (leer.ReadLine())
                        {
                            case "☺":
                                auxp = new Perro();
                                auxp.setAdoptado(Boolean.Parse(leer.ReadLine()));
                                auxp.setEdad(int.Parse(leer.ReadLine()));
                                auxp.setFechaAdopcion(leer.ReadLine());
                                auxp.setFechaRescate(leer.ReadLine());
                                auxp.setlargo(double.Parse(leer.ReadLine()));
                                auxp.setmanchas(int.Parse(leer.ReadLine()));
                                auxp.setNombre(leer.ReadLine());
                                auxp.setRancho(leer.ReadLine());
                                p = new Persona();
                                p.setEdad(int.Parse(leer.ReadLine()));
                                p.setGenero(leer.ReadLine());
                                p.setNombre(leer.ReadLine());
                                p.setNumerotelefonico(long.Parse(leer.ReadLine()));
                                auxp.setdueño(p);
                                listas.getListaperros().Add(auxp);
                                ; break;
                            case "☻":
                                auxg = new Gato();
                                auxg.setAdoptado(Boolean.Parse(leer.ReadLine()));
                                auxg.setcolorolo(leer.ReadLine());
                                auxg.setEdad(int.Parse(leer.ReadLine()));
                                auxg.setFechaAdopcion(leer.ReadLine());
                                auxg.setFechaRescate(leer.ReadLine());
                                auxg.setNombre(leer.ReadLine());
                                auxg.setnpelos(int.Parse(leer.ReadLine()));
                                auxg.setRancho(leer.ReadLine());
                                p = new Persona();
                                p.setEdad(int.Parse(leer.ReadLine()));
                                p.setGenero(leer.ReadLine());
                                p.setNombre(leer.ReadLine());
                                p.setNumerotelefonico(long.Parse(leer.ReadLine()));
                                auxg.setdueño(p);
                                listas.getListagatos().Add(auxg);
                                ; break;
                            case "♥":
                                auxa = new ave();
                                auxa.setAdoptado(Boolean.Parse(leer.ReadLine()));
                                auxa.setEdad(int.Parse(leer.ReadLine()));
                                auxa.setFechaAdopcion(leer.ReadLine());
                                auxa.setFechaRescate(leer.ReadLine());
                                auxa.setlargo(double.Parse(leer.ReadLine()));
                                auxa.setNombre(leer.ReadLine());
                                auxa.setRancho(leer.ReadLine());
                                auxa.settamaño(leer.ReadLine());
                                p = new Persona();
                                p.setEdad(int.Parse(leer.ReadLine()));
                                p.setGenero(leer.ReadLine());
                                p.setNombre(leer.ReadLine());
                                p.setNumerotelefonico(long.Parse(leer.ReadLine()));
                                auxa.setdueño(p);
                                listas.getListaaves().Add(auxa);
                                ; break;
                            case "♦":
                                auxc = new cocodrilo();
                                auxc.setAdoptado(Boolean.Parse(leer.ReadLine()));
                                auxc.setn_dientes(int.Parse(leer.ReadLine()));
                                auxc.setEdad(int.Parse(leer.ReadLine()));
                                auxc.setFechaAdopcion(leer.ReadLine());
                                auxc.setFechaRescate(leer.ReadLine());
                                auxc.setNombre(leer.ReadLine());
                                auxc.setRancho(leer.ReadLine());
                                p = new Persona();
                                p.setEdad(int.Parse(leer.ReadLine()));
                                p.setGenero(leer.ReadLine());
                                p.setNombre(leer.ReadLine());
                                p.setNumerotelefonico(long.Parse(leer.ReadLine()));
                                auxc.setdueño(p);
                                listas.getListacocodrilos().Add(auxc);
                                ; break;
                            case "♣":
                                leyendo = false;
                                ; break;
                        }
                    } while (leyendo);
                    leer.Close();
                }catch (Exception e)
                {
                    MessageBox.Show("ERROR AL LEER ARCHIVO"+e,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        public void salirdelsistema(object sender,EventArgs e)
        {
            escribir = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\animales.txt",false);
            foreach ( Perro aux in listas.getListaperros())
            {
                escribir.WriteLine("☺");
                escribir.WriteLine(aux.getAdoptado());
                escribir.WriteLine(aux.getEdad());
                escribir.WriteLine(aux.getFechaAdopcion());
                escribir.WriteLine(aux.getFechaRescate());
                escribir.WriteLine(aux.getlargo());
                escribir.WriteLine(aux.getmanchas());
                escribir.WriteLine(aux.getNombre());
                escribir.WriteLine(aux.getRancho());
                escribir.WriteLine(aux.getdueño().getEdad());
                escribir.WriteLine(aux.getdueño().getGenero());
                escribir.WriteLine(aux.getdueño().getNombre());
                escribir.WriteLine(aux.getdueño().getNumerotelefonico());
            }
            foreach (Gato aux in listas.getListagatos())
            {
                escribir.WriteLine("☻");
                escribir.WriteLine(aux.getAdoptado());
                escribir.WriteLine(aux.getcolorojo());
                escribir.WriteLine(aux.getEdad());
                escribir.WriteLine(aux.getFechaAdopcion());
                escribir.WriteLine(aux.getFechaRescate());
                escribir.WriteLine(aux.getNombre());
                escribir.WriteLine(aux.getnpelos());
                escribir.WriteLine(aux.getRancho());
                escribir.WriteLine(aux.getdueño().getEdad());
                escribir.WriteLine(aux.getdueño().getGenero());
                escribir.WriteLine(aux.getdueño().getNombre());
                escribir.WriteLine(aux.getdueño().getNumerotelefonico());
            }
            foreach(ave aux in listas.getListaaves())
            {
                escribir.WriteLine("♥");
                escribir.WriteLine(aux.getAdoptado());
                escribir.WriteLine(aux.getEdad());
                escribir.WriteLine(aux.getFechaAdopcion());
                escribir.WriteLine(aux.getFechaRescate());
                escribir.WriteLine(aux.getlargo());
                escribir.WriteLine(aux.getNombre());
                escribir.WriteLine(aux.getRancho());
                escribir.WriteLine(aux.gettamaño());
                escribir.WriteLine(aux.getdueño().getEdad());
                escribir.WriteLine(aux.getdueño().getGenero());
                escribir.WriteLine(aux.getdueño().getNombre());
                escribir.WriteLine(aux.getdueño().getNumerotelefonico());
            }
            foreach (cocodrilo aux in listas.getListacocodrilos())
            {
                escribir.WriteLine("♦");
                escribir.WriteLine(aux.getAdoptado());
                escribir.WriteLine(aux.getdientes());
                escribir.WriteLine(aux.getEdad());
                escribir.WriteLine(aux.getFechaAdopcion());
                escribir.WriteLine(aux.getFechaRescate());
                escribir.WriteLine(aux.getNombre());
                escribir.WriteLine(aux.getRancho());
                escribir.WriteLine(aux.getdueño().getEdad());
                escribir.WriteLine(aux.getdueño().getGenero());
                escribir.WriteLine(aux.getdueño().getNombre());
                escribir.WriteLine(aux.getdueño().getNumerotelefonico());
            }
            escribir.WriteLine("♣");
            escribir.Close();
            Close();
        }

         public void animalesrecogidos(object sender,EventArgs e)
        {
            if(ventanaAnimalesRecogidos == null)
            {
                ventanaAnimalesRecogidos = new Animales_Recogidos();
            }
            ventanaAnimalesRecogidos.enviarlistass(listas);
            ventanaAnimalesRecogidos.ShowDialog();
        }

        public void adoptarAnimal(object sender, EventArgs e)
        {
            if(ventanaAdoptaranimal == null)
            {
                ventanaAdoptaranimal = new Adoptar_Animal();
                
            }
            ventanaAdoptaranimal.enviarlista(listas);
            ventanaAdoptaranimal.ShowDialog();
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptaATuNuevaMascota
{
    public partial class Adoptar_Animal : Form
    {

        private Listas laslistas;

        public Adoptar_Animal()
        {
            InitializeComponent();
        }

        public void adoptar(object sender,EventArgs e)
        {
            Persona perso = new Persona();
            try
            {
                perso.setNombre(nombrepersona.Text);
                perso.setNumerotelefonico(long.Parse(numtelefo.Text));
                perso.setGenero(genero.SelectedItem.ToString());
                perso.setEdad(int.Parse(edadpersona.Text));
                String[] seleccion = comboBox1.SelectedItem.ToString().Split(' ');
                string nombre = "";
                for (int i = 0; i < seleccion.Length - 1; i++)
                {
                    nombre += " " + seleccion[i];
                }
                Boolean yaseagrego = true;
                foreach (Perro aux in laslistas.getListaperros())
                {
                    if (nombre.Trim().Equals(aux.getNombre()))
                    {
                        aux.setdueño(perso);
                        aux.setAdoptado(true);
                        aux.setFechaAdopcion(DateTime.Now.ToString());
                        yaseagrego = false;
                    }
                }
                if (yaseagrego)
                {
                    foreach (Gato aux in laslistas.getListagatos())
                    {
                        if (nombre.Trim().Equals(aux.getNombre()))
                        {
                            aux.setdueño(perso);
                            aux.setAdoptado(true);
                            aux.setFechaAdopcion(DateTime.Now.ToString());
                            yaseagrego = false;
                        }
                    }
                }
                if (yaseagrego)
                {
                    foreach (ave aux in laslistas.getListaaves())
                    {
                        if (nombre.Trim().Equals(aux.getNombre()))
                        {
                            aux.setdueño(perso);
                            aux.setAdoptado(true);
                            aux.setFechaAdopcion(DateTime.Now.ToString());
                            yaseagrego = false;
                        }
                    }
                }
                if (yaseagrego)
                {
                    foreach (cocodrilo aux in laslistas.getListacocodrilos())
                    {
                        if (nombre.Trim().Equals(aux.getNombre()))
                        {
                            aux.setdueño(perso);
                            aux.setAdoptado(true);
                            aux.setFechaAdopcion(DateTime.Now.ToString());
                            yaseagrego = false;
                        }
                    }
                }
                nombrepersona.Text = "";
                numtelefo.Text = "";
                genero.SelectedIndex = -1;
                genero.Text = "GENERO";
                edadpersona.Text = "";
                comboBox1.Items.Clear();
                animalseleccionado.Text = "NINGUNO SELECCIONADO";
                actualizarlista();
                comboBox1.Text = "LISTA DE ANIMALES EN ADOPCION";
            }
            catch
            {
                MessageBox.Show("Error al ingresar datos verifique que esten bien",
                    "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void enviarlista(Listas la)
        {
            laslistas = la;
            actualizarlista();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] seleccion = comboBox1.SelectedItem.ToString().Split(' ');
            switch (seleccion[seleccion.Length-1])
            {
                case "PERRO":
                    string nombre = "";
                    for (int i = 0; i < seleccion.Length - 1; i++)
                    {
                        nombre += " "+seleccion[i];
                    }
                    foreach (Perro aux in laslistas.getListaperros()) {
                        if (nombre.Trim().Equals(aux.getNombre()))
                        {
                            animalseleccionado.Text = "NOMBRE: " + aux.getNombre()+"\nEDAD: "+
                                aux.getEdad()+"\nFECHA DE RESCATE: "+aux.getFechaRescate()+
                                "\nRANCHO: "+aux.getRancho();
                        }
                    }; break;
                case "GATO":
                    string nombre1 = "";
                    for (int i = 0; i < seleccion.Length - 1; i++)
                    {
                        nombre1 += " "+seleccion[i];
                    }
                    foreach (Gato aux in laslistas.getListagatos()) {
                        if (nombre1.Trim().Equals(aux.getNombre()))
                        {
                            animalseleccionado.Text = "NOMBRE: " + aux.getNombre() + "\nEDAD: " +
                                aux.getEdad() + "\nFECHA DE RESCATE: " + aux.getFechaRescate() +
                                "\nRANCHO: " + aux.getRancho();
                        }
                    }; break;
                case "AVE":

                    string nombre2 = "";
                    for (int i = 0; i < seleccion.Length - 1; i++)
                    {
                        nombre2 += " " + seleccion[i];
                    }
                    foreach (ave aux in laslistas.getListaaves())
                    {
                        if (nombre2.Trim().Equals(aux.getNombre()))
                        {
                            animalseleccionado.Text = "NOMBRE: " + aux.getNombre() + "\nEDAD: " +
                                aux.getEdad() + "\nFECHA DE RESCATE: " + aux.getFechaRescate() +
                                "\nRANCHO: " + aux.getRancho();
                        }
                    }; break;
                case "COCODRILO":

                    string nombre3 = "";
                    for (int i = 0; i < seleccion.Length - 1; i++)
                    {
                        nombre3 += " " + seleccion[i];
                    }
                    foreach (cocodrilo aux in laslistas.getListacocodrilos())
                    {
                        if (nombre3.Trim().Equals(aux.getNombre()))
                        {
                            animalseleccionado.Text = "NOMBRE: " + aux.getNombre() + "\nEDAD: " +
                                aux.getEdad() + "\nFECHA DE RESCATE: " + aux.getFechaRescate() +
                                "\nRANCHO: " + aux.getRancho();
                        }
                    }; break;
            }
        }

        public void salir(object sender,EventArgs e)
        {
            nombrepersona.Text = "";
            numtelefo.Text = "";
            genero.SelectedIndex = -1;
            genero.Text = "GENERO";
            edadpersona.Text = "";
            comboBox1.Items.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "LISTA DE ANIMALES EN ADOPCION";
            animalseleccionado.Text = "NINGUNO SELECCIONADO";
            Close();
        }

        public void actualizarlista()
        {
            foreach (Perro aux in laslistas.getListaperros())
            {
                if (!aux.getAdoptado())
                {
                    comboBox1.Items.Add(aux.getNombre() + " PERRO");
                }
            }
            foreach (Gato aux in laslistas.getListagatos())
            {
                if (!aux.getAdoptado())
                {
                    comboBox1.Items.Add(aux.getNombre() + " GATO");
                }
            }
            foreach (ave aux in laslistas.getListaaves())
            {
                if (!aux.getAdoptado())
                {
                    comboBox1.Items.Add(aux.getNombre() + " AVE");
                }
            }
            foreach (cocodrilo aux in laslistas.getListacocodrilos())
            {
                if (!aux.getAdoptado())
                {
                    comboBox1.Items.Add(aux.getNombre() + " COCODRILO");
                }
            }
            comboBox1.Text = "LISTA DE ANIMALES EN ADOPCION";
        }

    }
}

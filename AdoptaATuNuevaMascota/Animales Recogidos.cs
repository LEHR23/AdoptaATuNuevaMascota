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
    public partial class Animales_Recogidos : Form
    {

        private Listas lalista;

        public Animales_Recogidos()
        {
            InitializeComponent();
            lalista = new Listas();
            for (int i = 1990;i<2050;i++)
            {
                añorescate.Items.Add(i+"");
            }
        }
        //PARTE DE AGREGAR ANIMAL PANEL 1
        private void agregaranimal(object sender,EventArgs e)
        {
            panel4.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            nombreAnimal.Text = "";
            edad.Text = "";
            diarescate.SelectedIndex = -1;
            diarescate.Text = "DIA";
            mesrescate.SelectedIndex = -1;
            mesrescate.Text = "MES";
            añorescate.SelectedIndex = -1;
            añorescate.Text = "AÑO";
            tipodeanimal.SelectedIndex = -1;
            tipodeanimal.Text = "TIPO DE ANIMAL";
            rancho.SelectedIndex = -1;
            rancho.Text = "RANCHOS";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "TAMAÑO DEL PICO";
            comboBox1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBoxAUX2.Visible = false;
            textBoxAUX1.Visible = false;
            textBoxAUX1.Text = "";
            textBoxAUX2.Text = "";
        }

        private void agregar(object sender,EventArgs e)
        {
            try
            {
                String tipoanimal = tipodeanimal.SelectedItem.ToString();
                switch (tipoanimal)
                {
                    case "PERRO":
                        Perro nuevoperro = new Perro();
                        if (!(nombreAnimal.Text.Equals("")))
                        {
                            nuevoperro.setNombre(nombreAnimal.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("campo de nombre vacio","ERROR",
                                MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        if (!(edad.Text.Equals("")))
                        {
                            nuevoperro.setEdad(int.Parse(edad.Text));
                        }
                        else
                        {
                            MessageBox.Show("campo de edad vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (!(textBoxAUX1.Text.Equals("")))
                        {
                            nuevoperro.setlargo(double.Parse(textBoxAUX1.Text));
                        }
                        else
                        {
                            MessageBox.Show("campo de longitud de cola vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (!(textBoxAUX2.Text.Equals("")))
                        {
                            nuevoperro.setmanchas(int.Parse(textBoxAUX2.Text));
                        }
                        else
                        {
                            MessageBox.Show("campo de manchas vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        nuevoperro.setRancho(rancho.SelectedItem.ToString());
                        nuevoperro.setFechaRescate(diarescate.SelectedItem.ToString()+"/"+
                          mesrescate.SelectedItem.ToString()+"/"+
                          añorescate.SelectedItem.ToString());
                        lalista.getListaperros().Add(nuevoperro);
                        MessageBox.Show("¡¡¡ PERRO AGREGADO CON EXITO !!!");
                        nombreAnimal.Text = "";
                        edad.Text = "";
                        diarescate.SelectedIndex = -1;
                        diarescate.Text = "DIA";
                        mesrescate.SelectedIndex = -1;
                        mesrescate.Text = "MES";
                        añorescate.SelectedIndex = -1;
                        añorescate.Text = "AÑO";
                        tipodeanimal.SelectedIndex = -1;
                        tipodeanimal.Text = "TIPO DE ANIMAL";
                        rancho.SelectedIndex = -1;
                        rancho.Text = "RANCHOS";
                        comboBox1.SelectedIndex = -1;
                        comboBox1.Text = "TAMAÑO DEL PICO";
                        comboBox1.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        textBoxAUX2.Visible = false;
                        textBoxAUX1.Visible = false;
                        textBoxAUX1.Text = "";
                        textBoxAUX2.Text = "";
                        ; break;
                    case "GATO":
                        Gato nuevogato = new Gato();
                        if (!(nombreAnimal.Text.Equals("")))
                        {
                            nuevogato.setNombre(nombreAnimal.Text);
                        }
                        else
                        {
                            MessageBox.Show("campo de nombre vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (!(edad.Text.Equals("")))
                        {
                            nuevogato.setEdad(int.Parse(edad.Text));
                        }
                        else
                        {
                            MessageBox.Show("campo de edad vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (!(textBoxAUX1.Text.Equals("")))
                        {
                            nuevogato.setcolorolo(textBoxAUX1.Text);
                        }
                        else
                        {
                            MessageBox.Show("campo de color vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (!(textBoxAUX2.Text.Equals("")))
                        {
                            nuevogato.setnpelos(int.Parse(textBoxAUX2.Text));
                        }
                        else
                        {
                            MessageBox.Show("campo de bigote vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        nuevogato.setRancho(rancho.SelectedItem.ToString());
                        nuevogato.setFechaRescate(diarescate.SelectedItem.ToString() + "/" +
                          mesrescate.SelectedItem.ToString() + "/" +
                          añorescate.SelectedItem.ToString());
                        lalista.getListagatos().Add(nuevogato);
                        MessageBox.Show("¡¡¡ GATO AGREGADO CON EXITO !!!");
                        nombreAnimal.Text = "";
                        edad.Text = "";
                        diarescate.SelectedIndex = -1;
                        diarescate.Text = "DIA";
                        mesrescate.SelectedIndex = -1;
                        mesrescate.Text = "MES";
                        añorescate.SelectedIndex = -1;
                        añorescate.Text = "AÑO";
                        tipodeanimal.SelectedIndex = -1;
                        tipodeanimal.Text = "TIPO DE ANIMAL";
                        rancho.SelectedIndex = -1;
                        rancho.Text = "RANCHOS";
                        comboBox1.SelectedIndex = -1;
                        comboBox1.Text = "TAMAÑO DEL PICO";
                        comboBox1.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        textBoxAUX2.Visible = false;
                        textBoxAUX1.Visible = false;
                        textBoxAUX1.Text = "";
                        textBoxAUX2.Text = "";
                        ; break;
                    case "COCODRILO":
                        cocodrilo nuevococo = new cocodrilo();
                        if (!(nombreAnimal.Text.Equals("")))
                        {
                            nuevococo.setNombre(nombreAnimal.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("campo de nombre vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (!(edad.Text.Equals("")))
                        {
                            nuevococo.setEdad(int.Parse(edad.Text));
                        }
                        else
                        {
                            MessageBox.Show("campo de edad vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (!(textBoxAUX1.Text.Equals("")))
                        {
                            nuevococo.setn_dientes(int.Parse(textBoxAUX1.Text));
                        }
                        else
                        {
                            MessageBox.Show("campo de dientes vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        nuevococo.setRancho(rancho.SelectedItem.ToString());
                        nuevococo.setFechaRescate(diarescate.SelectedItem.ToString() + "/" +
                          mesrescate.SelectedItem.ToString() + "/" +
                          añorescate.SelectedItem.ToString());
                        lalista.getListacocodrilos().Add(nuevococo);
                        MessageBox.Show("¡¡¡ COCODRILO AGREGADO CON EXITO !!!");
                        nombreAnimal.Text = "";
                        edad.Text = "";
                        diarescate.SelectedIndex = -1;
                        diarescate.Text = "DIA";
                        mesrescate.SelectedIndex = -1;
                        mesrescate.Text = "MES";
                        añorescate.SelectedIndex = -1;
                        añorescate.Text = "AÑO";
                        tipodeanimal.SelectedIndex = -1;
                        tipodeanimal.Text = "TIPO DE ANIMAL";
                        rancho.SelectedIndex = -1;
                        rancho.Text = "RANCHOS";
                        comboBox1.SelectedIndex = -1;
                        comboBox1.Text = "TAMAÑO DEL PICO";
                        comboBox1.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        textBoxAUX2.Visible = false;
                        textBoxAUX1.Visible = false;
                        textBoxAUX1.Text = "";
                        textBoxAUX2.Text = ""; ; break;
                    case "AVE":
                        ave nuevaave = new ave();
                        if (!(nombreAnimal.Text.Equals("")))
                        {
                            nuevaave.setNombre(nombreAnimal.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("campo de nombre vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (!(edad.Text.Equals("")))
                        {
                            nuevaave.setEdad(int.Parse(edad.Text));
                        }
                        else
                        {
                            MessageBox.Show("campo de edad vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (!(textBoxAUX2.Text.Equals("")))
                        {
                            nuevaave.setlargo(double.Parse(textBoxAUX2.Text));
                        }
                        else
                        {
                            MessageBox.Show("campo de largo vacio", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        nuevaave.settamaño(comboBox1.SelectedItem.ToString());
                        nuevaave.setRancho(rancho.SelectedItem.ToString());
                        nuevaave.setFechaRescate(diarescate.SelectedItem.ToString() + "/" +
                          mesrescate.SelectedItem.ToString() + "/" +
                          añorescate.SelectedItem.ToString());
                        lalista.getListaaves().Add(nuevaave);
                        MessageBox.Show("¡¡¡ AVE AGREGADA CON EXITO !!!");
                        nombreAnimal.Text = "";
                        edad.Text = "";
                        diarescate.SelectedIndex = -1;
                        diarescate.Text = "DIA";
                        mesrescate.SelectedIndex = -1;
                        mesrescate.Text = "MES";
                        añorescate.SelectedIndex = -1;
                        añorescate.Text = "AÑO";
                        tipodeanimal.SelectedIndex = -1;
                        tipodeanimal.Text = "TIPO DE ANIMAL";
                        rancho.SelectedIndex = -1;
                        rancho.Text = "RANCHOS";
                        comboBox1.SelectedIndex = -1;
                        comboBox1.Text = "TAMAÑO DEL PICO";
                        comboBox1.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        textBoxAUX2.Visible = false;
                        textBoxAUX1.Visible = false;
                        textBoxAUX1.Text = "";
                        textBoxAUX2.Text = ""; ; break ;
                }
            }
            catch
            {
                MessageBox.Show("Error datos invalidos");
            }
        }

        public void cancelaragregar(object sender,EventArgs e)
        {
            panel4.Visible = true;
            nombreAnimal.Text = "";
            edad.Text = "";
            diarescate.SelectedIndex = -1;
            diarescate.Text = "DIA";
            mesrescate.SelectedIndex = -1;
            mesrescate.Text = "MES";
            añorescate.SelectedIndex = -1;
            añorescate.Text = "AÑO";
            tipodeanimal.SelectedIndex = -1;
            tipodeanimal.Text = "TIPO DE ANIMAL";
            rancho.SelectedIndex = -1;
            rancho.Text = "RANCHOS";
            panel1.Visible = false;
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "TAMAÑO DEL PICO";
            comboBox1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBoxAUX2.Visible = false;
            textBoxAUX1.Visible = false;
            textBoxAUX1.Text = "";
            textBoxAUX2.Text = "";
        }

        //termina panel 1 agregar animal

        //comienza mostrar animales panel 2

        public void mostrar(object sender,EventArgs e)
        {
            panel4.Visible = false;
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "TAMAÑO DEL PICO";
            comboBox1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBoxAUX2.Visible = false;
            textBoxAUX1.Visible = false;
            panel2.Visible = true;
            nombreAnimal.Text = "";
            edad.Text = "";
            diarescate.SelectedIndex = -1;
            diarescate.Text = "DIA";
            mesrescate.SelectedIndex = -1;
            mesrescate.Text = "MES";
            añorescate.SelectedIndex = -1;
            añorescate.Text = "AÑO";
            tipodeanimal.SelectedIndex = -1;
            tipodeanimal.Text = "TIPO DE ANIMAL";
            rancho.SelectedIndex = -1;
            rancho.Text = "RANCHOS";
            panel1.Visible = false;
            textBoxAUX1.Text = "";
            textBoxAUX2.Text = "";
            String todoslosanimales = "";
            foreach (Perro aux in lalista.getListaperros())
            {
                todoslosanimales = todoslosanimales+"PERRO"
                    +"\nNOMBRE: "+aux.getNombre()
                    +"\nEDAD: "+aux.getEdad()+" años"
                    +"\nFECHA DE RESCATE: "+aux.getFechaRescate()
                    +"\nRANCHO: "+aux.getRancho()
                    +"\nLONGITUD DE COLA: "+aux.getlargo()+"cm"
                    +"\nNo. MANCHAS: "+aux.getmanchas();
                if (aux.getAdoptado())
                {
                    todoslosanimales = todoslosanimales+"\nADOPTADO ☺\nNOMBRE DEL DUEÑO: "
                        + aux.getdueño().getNombre() + "\nFECHA DE ADOPCION: " +aux.getFechaAdopcion()+
                        "\n--------------------------------------\n\n";
                }
                else
                {
                    todoslosanimales = todoslosanimales+"\nNO ADOPTADO(SIN DUEÑO) :(\n" +
                        "--------------------------------------\n\n";
                }
            }
            foreach (Gato aux in lalista.getListagatos())
            {
                todoslosanimales = todoslosanimales+"GATO"
                    + "\nNOMBRE: " + aux.getNombre()
                    + "\nEDAD: " + aux.getEdad() + " años"
                    + "\nFECHA DE RESCATE: " + aux.getFechaRescate()
                    + "\nRANCHO: " + aux.getRancho()
                    + "\nNo. BIGOTES: "+aux.getnpelos()
                    + "\nCOLOR DE OJOS: "+aux.getcolorojo();
                if (aux.getAdoptado())
                {
                    todoslosanimales = todoslosanimales+"\nADOPTADO ☺\nNOMBRE DEL DUEÑO: " 
                        +aux.getdueño().getNombre()+ "\nFECHA DE ADOPCION: " + aux.getFechaAdopcion() +
                        "\n--------------------------------------\n\n";
                }
                else
                {
                    todoslosanimales = todoslosanimales+"\nNO ADOPTADO(SIN DUEÑO) :(" +
                        "\n--------------------------------------\n\n";
                }
            }
            foreach (ave aux in lalista.getListaaves())
            {
                todoslosanimales = todoslosanimales + "AVE"
                    + "\nNOMBRE: " + aux.getNombre()
                    + "\nEDAD: " + aux.getEdad() + " años"
                    + "\nFECHA DE RESCATE: " + aux.getFechaRescate()
                    + "\nRANCHO: " + aux.getRancho()
                    + "\nTAMAÑO DE PICO: "+aux.gettamaño()
                    + "\nLARGO DE PICO: "+aux.getlargo()+"cm";
                if (aux.getAdoptado())
                {
                    todoslosanimales = todoslosanimales + "\nADOPTADO ☺\nNOMBRE DEL DUEÑO: "
                        + aux.getdueño().getNombre() + "\nFECHA DE ADOPCION: " + aux.getFechaAdopcion() +
                        "\n--------------------------------------\n\n";
                }
                else
                {
                    todoslosanimales = todoslosanimales + "\nNO ADOPTADO(SIN DUEÑO) :(" +
                        "\n--------------------------------------\n\n";
                }
            }
            foreach (cocodrilo aux in lalista.getListacocodrilos())
            {
                todoslosanimales = todoslosanimales + "COCODRILO"
                    + "\nNOMBRE: " + aux.getNombre()
                    + "\nEDAD: " + aux.getEdad() + " años"
                    + "\nFECHA DE RESCATE: " + aux.getFechaRescate()
                    + "\nRANCHO: " + aux.getRancho()
                    + "\nNo. DE DIENTES: "+aux.getdientes();
                if (aux.getAdoptado())
                {
                    todoslosanimales = todoslosanimales + "\nADOPTADO ☺\nNOMBRE DEL DUEÑO: "
                        + aux.getdueño().getNombre() + "\nFECHA DE ADOPCION: " + aux.getFechaAdopcion() +
                        "\n--------------------------------------\n\n";
                }
                else
                {
                    todoslosanimales = todoslosanimales + "\nNO ADOPTADO(SIN DUEÑO) :(" +
                        "\n--------------------------------------\n\n";
                }
            }
            if (!(todoslosanimales.Equals("")))
            {
                laslistas.Text = todoslosanimales;
            }
        }

        //termina mostrar animales

        //regresar menu

        public void regresarmenu(object sender,EventArgs e)
        {
            panel4.Visible = true;
            rancho.Items.Clear();
            Close();
        }

        //fin de boton
        
        public void enviarlistass(Listas las)
        {
            lalista = las;
            panel2.Visible = false;
            panel1.Visible = false;
            StreamReader leer;
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ranchos.txt"))
            {
                    leer = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ranchos.txt");
                try
                {
                    String linea = leer.ReadLine();
                    while (linea != null)
                    {
                        rancho.Items.Add(linea);
                        linea = leer.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR AL LEER ARCHIVO " + e, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    leer.Close();
                }
            }
        }

        private void tipodeanimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String seleccion = tipodeanimal.SelectedItem.ToString();
                switch (seleccion)
                {
                    case "PERRO":
                        comboBox1.Visible = false;
                        label5.Visible = true;
                        label6.Visible = true;
                        textBoxAUX1.Visible = true;
                        textBoxAUX2.Visible = true;
                        label5.Text = "LONGITUD DE LA COLA";
                        label6.Text = "No. MANCHAS";
                        textBoxAUX1.Text = "";
                        textBoxAUX2.Text = "";
                        break;
                    case "GATO":
                        label5.Visible = true;
                        label6.Visible = true;
                        comboBox1.Visible = false;
                        textBoxAUX1.Visible = true;
                        textBoxAUX2.Visible = true;
                        label5.Text = "COLOR DE OJO";
                        label6.Text = "No.BIGOTE";
                        textBoxAUX1.Text = "";
                        textBoxAUX2.Text = ""; break;
                    case "AVE":
                        comboBox1.SelectedIndex = -1;
                        comboBox1.Text = "TAMAÑO DEL PICO";
                        comboBox1.Enabled = true;
                        comboBox1.Visible = true;
                        textBoxAUX1.Visible = false;
                        label6.Visible = true;
                        label5.Visible = false;
                        textBoxAUX2.Visible = true;
                        label6.Text = "LARGO DE PICO";
                        textBoxAUX1.Text = "";
                        textBoxAUX2.Text = ""; break;
                    case "COCODRILO":
                        label5.Visible = true;
                        label6.Visible = false;
                        textBoxAUX2.Visible = false;
                        comboBox1.Visible = false;
                        textBoxAUX1.Visible = true;
                        label5.Text = "No. DE DIENTES";
                        textBoxAUX1.Text = "";
                        textBoxAUX2.Text = ""; break;
                }
            }
            catch
            {

            }
        }

        private void agregarrancho(object sender,EventArgs e)
        {
            String nuevorancho = Microsoft.VisualBasic.Interaction.InputBox("INGRESE EL NOMBRE DEL" +
                "RANCHO QUE DESEA AGREGAR","RANCHO NUEVO","");
            try
            {
                String nuevo = nuevorancho.Trim();
                if (!nuevo.Equals(""))
                {
                    rancho.Items.Add(nuevo);
                    StreamWriter esc = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\ranchos.txt",true);
                    esc.WriteLine(nuevo);
                    esc.Close();
                    MessageBox.Show("RANCHO "+nuevo+" AGREGADO");
                }
            }
            catch
            {

            }
        }
    }
}

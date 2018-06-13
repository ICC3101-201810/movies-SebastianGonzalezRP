using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Movies
{
    public partial class Form1 : Form
    {
        List<Persona> personas = new List<Persona>();
        List<Pelicula> peliculas = new List<Pelicula>();
        List<Estudio> estudios = new List<Estudio>();
        List<PeliculaActor> peliculaActores = new List<PeliculaActor>();
        List<PeliculaProductor> peliculaProductors = new List<PeliculaProductor>();
        BaseDatos BD;

        public Form1()
        {
            InitializeComponent();
            setUpData();
        }

        

        void setUpData()
        {
            personas.Add(new Persona("Sebastian", "Gonzalez", 1996, "a", "Director"));
            personas.Add(new Persona("Michael", "Bay", 1955, "b", "Director"));
            personas.Add(new Persona("Claudio", "Palma", 1981, "c", "Director"));
            personas.Add(new Persona("Claudio", "Rodriguez", 1980, " ", "Actor"));
            personas.Add(new Persona("Fredrick", "Huml", 1981, " ", "Actor"));
            personas.Add(new Persona("Fernando", "Jimenez", 1985, " ", "Productor"));
            estudios.Add(new Estudio("Universal", "Direccion Universal", 1930));
            estudios.Add(new Estudio("Fox Studio", "Direccion Fox", 1910));
            estudios.Add(new Estudio("Mutual", "Direccion Mutual", 1948));
            estudios.Add(new Estudio("Disney", "Direccion Disney", 1895));
            peliculas.Add(new Pelicula("Transformers", "Michael Bay", 2010, "Autobots", 1530000, estudios[1]));
            peliculas.Add(new Pelicula("Transformers 2", "Michael Bay", 2011, "Autobots1", 2530000, estudios[1]));
            peliculas.Add(new Pelicula("Transformers 3", "Michael Bay", 2012, "Autobots2", 3530000, estudios[1]));
            peliculas.Add(new Pelicula("Star Wars 8", "NIDEAD", 2017, "Bad Saga", 2830000, estudios[3]));
            peliculas.Add(new Pelicula("Cenicienta", "Diseny", 1930, "Princesa", 250000, estudios[3]));

            BD = new BaseDatos(personas,peliculas,estudios,peliculaActores,peliculaProductors);

            BinaryFormatter formattere = new BinaryFormatter();
            Stream miStreame = new FileStream("BD.bin", FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
            formattere.Serialize(miStreame, BD);
            miStreame.Close();
        }

        private void BPelicula_Click(object sender, EventArgs e)
        {
            L1.Visible = true;
            L1.Text = "Nombre";
            L2.Visible = true;
            L2.Text = "Director";
            L3.Visible = true;
            L3.Text = "Estreno";
            L4.Visible = true;
            L4.Text = "Descripcion";
            L5.Visible = true;
            L5.Text = "Presupuesto";
            L6.Visible = true;
            L6.Text = "Estudio";

            LB1.Visible = true;
            LB2.Visible = true;
            LB3.Visible = true;
            LB4.Visible = true;
            LB5.Visible = true;
            LB6.Visible = true;

            LB1.Items.Clear();
            LB2.Items.Clear();
            LB3.Items.Clear();
            LB4.Items.Clear();
            LB5.Items.Clear();
            LB6.Items.Clear();
            foreach (Pelicula p in peliculas)
            {
                LB1.Items.Add(p.nombre);
                LB2.Items.Add(p.director);
                LB3.Items.Add(p.fecha_estreno);
                LB4.Items.Add(p.descripcion);
                LB5.Items.Add(p.presupuesto);
                LB6.Items.Add(p.estudio.nombre);
            }
        }

        private void BActores_Click(object sender, EventArgs e)
        {
            L1.Visible = true;
            L1.Text = "Nombre";
            L2.Visible = true;
            L2.Text = "Apellido";
            L3.Visible = true;
            L3.Text = "Nacimiento";
            L4.Visible = true;
            L4.Text = "Biografia";
            L5.Visible = false;
            L5.Text = "";
            L6.Visible = false;
            L6.Text = "";

            LB1.Visible = true;
            LB2.Visible = true;
            LB3.Visible = true;
            LB4.Visible = true;
            LB5.Visible = false;
            LB6.Visible = false;

            LB1.Items.Clear();
            LB2.Items.Clear();
            LB3.Items.Clear();
            LB4.Items.Clear();
            LB5.Items.Clear();
            LB6.Items.Clear();
            foreach (Persona p in personas)
            {
                if (p.cargo == "Actor")
                { 
                LB1.Items.Add(p.nombre);
                LB2.Items.Add(p.apellido);
                LB3.Items.Add(p.nacimiento);
                LB4.Items.Add(p.biografia);
                }
            }
        }

        private void BDirectores_Click(object sender, EventArgs e)
        {
            L1.Visible = true;
            L1.Text = "Nombre";
            L2.Visible = true;
            L2.Text = "Apellido";
            L3.Visible = true;
            L3.Text = "Nacimiento";
            L4.Visible = true;
            L4.Text = "Biografia";
            L5.Visible = false;
            L5.Text = "";
            L6.Visible = false;
            L6.Text = "";

            LB1.Visible = true;
            LB2.Visible = true;
            LB3.Visible = true;
            LB4.Visible = true;
            LB5.Visible = false;
            LB6.Visible = false;

            LB1.Items.Clear();
            LB2.Items.Clear();
            LB3.Items.Clear();
            LB4.Items.Clear();
            LB5.Items.Clear();
            LB6.Items.Clear();
            foreach (Persona p in personas)
            {
                if (p.cargo == "Director")
                {
                    LB1.Items.Add(p.nombre);
                    LB2.Items.Add(p.apellido);
                    LB3.Items.Add(p.nacimiento);
                    LB4.Items.Add(p.biografia);
                }
            }
        }

        private void BProductores_Click(object sender, EventArgs e)
        {
            L1.Visible = true;
            L1.Text = "Nombre";
            L2.Visible = true;
            L2.Text = "Apellido";
            L3.Visible = true;
            L3.Text = "Nacimiento";
            L4.Visible = true;
            L4.Text = "Biografia";
            L5.Visible = false;
            L5.Text = "";
            L6.Visible = false;
            L6.Text = "";

            LB1.Visible = true;
            LB2.Visible = true;
            LB3.Visible = true;
            LB4.Visible = true;
            LB5.Visible = false;
            LB6.Visible = false;

            LB1.Items.Clear();
            LB2.Items.Clear();
            LB3.Items.Clear();
            LB4.Items.Clear();
            LB5.Items.Clear();
            LB6.Items.Clear();
            foreach (Persona p in personas)
            {
                if (p.cargo == "Productor")
                {
                    LB1.Items.Add(p.nombre);
                    LB2.Items.Add(p.apellido);
                    LB3.Items.Add(p.nacimiento);
                    LB4.Items.Add(p.biografia);
                }
            }
        }

        private void BEstudios_Click(object sender, EventArgs e)
        {
            L1.Visible = true;
            L1.Text = "Nombre";
            L2.Visible = true;
            L2.Text = "Direccion";
            L3.Visible = true;
            L3.Text = "Apertura";
            L4.Visible = false;
            L4.Text = "";
            L5.Visible = false;
            L5.Text = "";
            L6.Visible = false;
            L6.Text = "";

            LB1.Visible = true;
            LB2.Visible = true;
            LB3.Visible = true;
            LB4.Visible = false;
            LB5.Visible = false;
            LB6.Visible = false;

            LB1.Items.Clear();
            LB2.Items.Clear();
            LB3.Items.Clear();
            LB4.Items.Clear();
            LB5.Items.Clear();
            LB6.Items.Clear();

            foreach (Estudio es in estudios)
            {
                LB1.Items.Add(es.nombre);
                LB2.Items.Add(es.direccion);
                LB3.Items.Add(es.fecha_apertura);
            }
        }
    }
}

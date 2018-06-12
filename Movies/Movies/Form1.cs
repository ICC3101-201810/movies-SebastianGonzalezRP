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
            
        }

        void setUpData()
        {
            personas.Add(new Persona("Sebastian", "Gonzalez", 1996, " ", "Director"));
            personas.Add(new Persona("Claudio", "Rodriguez", 1980, " ", "Actor"));
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
        }
    }
}

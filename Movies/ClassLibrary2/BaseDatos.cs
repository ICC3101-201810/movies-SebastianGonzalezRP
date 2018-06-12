using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class BaseDatos
    {
        public static List<Persona> personas;
        public static List<Pelicula> peliculas;
        public static List<Estudio> estudios;
        public static List<PeliculaActor> peliculaActores;
        public static List<PeliculaProductor> peliculaProductors;

        public BaseDatos(List<Persona>_personas, List<Pelicula>_peliculas,List<Estudio>_estudios,List<PeliculaActor>_peliculaActores,List<PeliculaProductor>_peliculaProductors)
        {
            personas = _personas;
            peliculas = _peliculas;
            estudios = _estudios;
            peliculaActores = _peliculaActores;
            peliculaProductors = _peliculaProductors;
        }
    }
}

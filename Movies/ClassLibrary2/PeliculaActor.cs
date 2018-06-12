using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    [Serializable]
    public class PeliculaActor
    {
        public Pelicula pelicula;
        public Persona actor;

        public PeliculaActor(Pelicula _pelicula, Persona _actor)
        {
            pelicula = _pelicula;
            actor = _actor;
        }
    }
}

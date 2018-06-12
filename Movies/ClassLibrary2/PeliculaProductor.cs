using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    [Serializable]
    public class PeliculaProductor
    {
        public Pelicula pelicula;
        public Persona productor;

        public PeliculaProductor(Pelicula _pelicula, Persona _productor)
        {
            pelicula = _pelicula;
            productor = _productor;
        }
    }
}

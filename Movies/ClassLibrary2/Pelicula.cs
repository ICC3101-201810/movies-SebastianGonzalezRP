using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    [Serializable]
    public class Pelicula
    {
        public string nombre;
        public string director;
        public int fecha_estreno;
        public string descripcion;
        public int presupuesto;
        public Estudio estudio;

        public Pelicula(string _nombre, string _director, int _fecha_estreno, string _descripcion, int _presupuesto, Estudio _estudio)
        {
            nombre = _nombre;
            director = _director;
            fecha_estreno = _fecha_estreno;
            descripcion = _descripcion;
            presupuesto = _presupuesto;
            estudio = _estudio;
        }
    }
}

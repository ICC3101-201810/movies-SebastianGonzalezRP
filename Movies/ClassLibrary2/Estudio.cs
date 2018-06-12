using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    [Serializable]
    public class Estudio
    {
        public string nombre;
        public string direccion;
        public int fecha_apertura;

        public Estudio(string _nombre, string _direccion, int _fecha_apertura)
        {
            nombre = _nombre;
            direccion = _direccion;
            fecha_apertura = _fecha_apertura;
        }
    }
}

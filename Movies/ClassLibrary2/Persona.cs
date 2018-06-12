using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    [Serializable]
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int nacimiento;
        public string biografia;
        public string cargo;

        public Persona(string _nombre, string _apellido, int _nacimiento, string _biografia, string _cargo)
        {
            nombre = _nombre;
            apellido = _apellido;
            nacimiento = _nacimiento;
            biografia = _biografia;
            cargo = _cargo;
        }

    }
}

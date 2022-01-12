using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    public class Profesor
    {
        public Profesor(string Nombre, string Apellido, string Especialidad) {
            this.Nombre = Nombre;
            this.Apellido = Apellido;   
            this.Especialidad = Especialidad;

        }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Especialidad { get; set; }

    }
}

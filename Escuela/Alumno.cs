using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    public class Alumno
    {

        public Alumno(string nombre, string apellido, string dni, DateTime fechanac, string matricula) {

            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            FechaNac = fechanac;
            Matricula = matricula;
        
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNac { get; set; }
        public string Matricula { get; set; }

    }
}

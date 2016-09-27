using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Clases
{
    class Fallecido
    {
        public string Curp { get; set; }

        public string Nombre { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; }

        public int Edad { get; set; }

        public Fallecido(string curp, string nombre, string paterno, string materno, int edad)
        {
            Curp = curp;
            Nombre = nombre;
            Paterno = paterno;
            Materno = materno;
            Edad = edad;
        }
    }
}

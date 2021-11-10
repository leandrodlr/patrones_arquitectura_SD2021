using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosWindowsFormsApp
{
    public class Contacto
    {
        public Contacto()
        {
            Sexo = ' ';
            ContactoId = 0;
        }

        public int ContactoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public char Sexo { get; set; }
    }
}

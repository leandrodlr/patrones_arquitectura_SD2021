using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosWindowsFormsApp
{
    public interface IContactoDatabase
    {
        //Create Read Update Delete
        void Insertar(Contacto c);
        void Actualizar(Contacto c);
        List<Contacto> Buscar(string texto);
        void Eliminar(int contactoId);

        List<Genero> ObtenerGeneros();
    }
}

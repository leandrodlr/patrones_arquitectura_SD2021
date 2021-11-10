using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosWindowsFormsApp
{
   public class ContactosDataContext
    {
        IContactoDatabase db;
        public ContactosDataContext()
        {

        }
        public ContactosDataContext(IContactoDatabase db)
        {
            this.db = db;
        }
        public void CambiarBaseDatos(IContactoDatabase db)
        {
            this.db = db;
        }

        public void Guardar(Contacto c)
        {
            //Validaciones
            if (String.IsNullOrEmpty(c.Nombres))
                throw new FormatException("El nombre no puede estar vacío");

            if (String.IsNullOrEmpty(c.Apellidos))
                throw new FormatException("El apellido no puede estar vacío");

            if (String.IsNullOrEmpty(c.Telefono.Replace("-","").Trim()))
                throw new FormatException("El Telefono no puede estar vacío");

            if (c.Sexo==' ')
                throw new FormatException("El sexo no puede estar vacío");
            
            //Guardamos en la base de datos
            if (c.ContactoId > 0)
                db.Actualizar(c);
          
            else
                db.Insertar(c);
        }

        public List<Contacto> Buscar(string texto)
        {
            return db.Buscar(texto);
        }

        public List<Genero> ObtenerGeneros()
        {
            return db.ObtenerGeneros();
        }
        public void Eliminar(Contacto c)
        {
            db.Eliminar(c.ContactoId);
        }
    }
}

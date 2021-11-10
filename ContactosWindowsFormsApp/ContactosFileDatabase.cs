using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContactosWindowsFormsApp
{
    class ContactosFileDatabase : IContactoDatabase
    {
        private List<Contacto> contactos = new List<Contacto>();
        public ContactosFileDatabase()
        {

            string file = File.ReadAllText(Environment.CurrentDirectory + "\\ContactosFileDatabase.txt");
            foreach (string line in file.Split('\n'))
            {
                string[] columns = line.Split('|');

                Contacto c = new Contacto();
                c.ContactoId = Convert.ToInt32(columns[0]);
                c.Nombres = columns[1];
                c.Apellidos = columns[2];
                c.Telefono = columns[3];
                c.Sexo = columns[4][0];

                contactos.Add(c);
            }
        }

        private void guardarArchivo()
        {
            //string content = "";

            //for (int i=0; i<contactos.Count;i++)
            //{
            //    Contacto c = contactos[i];
            //    content += c.ContactoId + "|" + c.Nombres + "|" + c.Apellidos + "|" + c.Telefono + "|" + c.Sexo + (i==contactos.Count-1?"": "\n");
            //}

            string content = String.Join("\n", contactos.Select(c => c.ContactoId + "|" + c.Nombres + "|" + c.Apellidos + "|" + c.Telefono + "|" + c.Sexo).ToArray());
            
            File.WriteAllText(Environment.CurrentDirectory + "\\ContactosFileDatabase.txt", content);
        }

        public void Actualizar(Contacto c)
        {
           var contact =  contactos.First(x => x.ContactoId == c.ContactoId);
            contact.Nombres = c.Nombres;
            contact.Apellidos = c.Apellidos;
            contact.Telefono = c.Telefono;
            contact.Sexo = c.Sexo;

            guardarArchivo();
        }

        public List<Contacto> Buscar(string texto)
        {
            return contactos.Where(x => (x.Nombres + x.Apellidos + x.Telefono).ToLower().Contains(texto.ToLower())).ToList();
        }

        public void Eliminar(int contactoId)
        {
            Contacto c = contactos.First(x => x.ContactoId == contactoId);
            contactos.Remove(c);

            guardarArchivo();
        }

        public void Insertar(Contacto c)
        {
            if (contactos.Count == 0)
                c.ContactoId = 1;
            else
                c.ContactoId = contactos.Max(x => x.ContactoId) + 1;

            contactos.Add(c);

            guardarArchivo();
        }
        public List<Genero> ObtenerGeneros()
        {
            List<Genero> lista = new List<Genero>();
            Genero ga = new Genero();
            ga.Sexo = ' ';
            ga.SexoNombre = "- Seleccione -";
            lista.Add(ga);
            lista.Add(new Genero() { Sexo = 'F', SexoNombre = "Femenino" });
            lista.Add(new Genero() { Sexo = 'M', SexoNombre = "Masculino" });
            return lista;
        }
    }
}

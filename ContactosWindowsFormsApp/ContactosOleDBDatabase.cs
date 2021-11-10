using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ContactosWindowsFormsApp
{
    class ContactosOleDBDatabase : IContactoDatabase
    {
        string cnstr = ConfigurationManager.ConnectionStrings["ACCESS_cnstr"].ConnectionString;

        public void Actualizar(Contacto c)
        {

            using (OleDbConnection cn = new OleDbConnection(cnstr))
            {
                cn.Open();
                var cmd = cn.CreateCommand();
                cmd.CommandText = "Update Contactos set Nombres=@Nombres, Apellidos=@Apellidos, Telefono=@Telefono, Sexo=@Sexo where ContactoId=@ContactoId";
                cmd.Parameters.AddWithValue("@Nombres", c.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", c.Apellidos);
                cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@Sexo", c.Sexo);
                cmd.Parameters.AddWithValue("@ContactoId", c.ContactoId);

                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public List<Contacto> Buscar(string texto)
        {
            List<Contacto> contactos = new List<Contacto>();

            using (OleDbConnection cn = new OleDbConnection(cnstr))
            {
                cn.Open();
                var cmd = cn.CreateCommand();
                cmd.CommandText = "Select ContactoId, Nombres, Apellidos, Telefono, Sexo from Contactos where Nombres&Apellidos&Telefono like '%'&@texto&'%'";
                cmd.Parameters.AddWithValue("@texto", texto);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Contacto c = new Contacto();
                    c.ContactoId = Convert.ToInt32(reader["ContactoId"]);
                    c.Nombres = reader.GetString(1);
                    c.Apellidos = reader.GetString(reader.GetOrdinal("Apellidos"));
                    c.Telefono = reader["Telefono"].ToString();
                    c.Sexo = reader.GetString(reader.GetOrdinal("Sexo"))[0];

                    contactos.Add(c);
                }

                cn.Close();
            }

            return contactos;
        }

        public void Eliminar(int contactoId)
        {
            using (OleDbConnection cn = new OleDbConnection(cnstr))
            {
                cn.Open();
                var cmd = cn.CreateCommand();
                cmd.CommandText = "delete from Contactos where ContactoId=?";
                cmd.Parameters.AddWithValue("@ContactoId", contactoId);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void Insertar(Contacto c)
        {
            using (OleDbConnection cn = new OleDbConnection(cnstr))
            {
                cn.Open();
                var cmd = cn.CreateCommand();
                cmd.CommandText = "Insert into Contactos (Nombres, Apellidos,Telefono,Sexo) values (@Nombres, @Apellidos,@Telefono,@Sexo) ";
                cmd.Parameters.AddWithValue("@Nombres", c.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", c.Apellidos);
                cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@Sexo", c.Sexo);


                cmd.ExecuteNonQuery();
                cn.Close();
            }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ContactosWindowsFormsApp
{
    class ContactosSQLServerDatabase : IContactoDatabase
    {
        string cnstr = ConfigurationManager.ConnectionStrings["SQL_cnstr"].ConnectionString;

        public void Actualizar(Contacto c)
        {

            using (SqlConnection cn = new SqlConnection(cnstr))
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

            using (SqlConnection cn = new SqlConnection(cnstr))
            {
                cn.Open();
                var cmd = cn.CreateCommand();
                cmd.CommandText = "ContactosBuscar";
                cmd.CommandType = CommandType.StoredProcedure;
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
            using (SqlConnection cn = new SqlConnection(cnstr))
            {
                cn.Open();
                var cmd = cn.CreateCommand();
                cmd.CommandText = "ContactosDelete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ContactoId", contactoId);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void Insertar(Contacto c)
        {
            using (SqlConnection cn = new SqlConnection(cnstr))
            {
                cn.Open();
                var cmd = cn.CreateCommand();
                cmd.CommandText = "ContactosInsert";
                cmd.CommandType = CommandType.StoredProcedure;
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
            List<Genero> generos = new List<Genero>();
            using (SqlConnection cn = new SqlConnection(cnstr))
            {
                cn.Open();
                var cmd = cn.CreateCommand();
                cmd.CommandText = "Select Sexo, SexoNombre from Generos";
                var reader = cmd.ExecuteReader();
                
                Genero ga = new Genero();
                ga.Sexo = ' ';
                ga.SexoNombre = "- Seleccione -";
                generos.Add(ga);

                while (reader.Read())
                {
                    Genero g = new Genero();
                    g.Sexo = reader.GetString(0)[0];
                    g.SexoNombre = reader.GetString(1);
                    generos.Add(g);
                }
            }

            return generos;
        }
    }
}

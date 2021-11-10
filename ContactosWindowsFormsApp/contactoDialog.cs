using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactosWindowsFormsApp
{
    public partial class contactoDialog : Form
    {
        Contacto c;
        ContactosDataContext db;

        public contactoDialog(Contacto c, ContactosDataContext db)
        {
            InitializeComponent();

            this.c = c;
            this.db = db;

            nombresTextBox.Text = c.Nombres;
            apellidosTextBox.Text = c.Apellidos;
            telefonoMaskedTextBox.Text = c.Telefono;

         
            generoComboBox.DataSource = db.ObtenerGeneros();
            generoComboBox.DisplayMember = "SexoNombre";
            generoComboBox.ValueMember = "Sexo";

            generoComboBox.SelectedValue = c.Sexo;
        }

        private void contactoDialog_Load(object sender, EventArgs e)
        {

        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            c.Nombres = nombresTextBox.Text;
            c.Apellidos = apellidosTextBox.Text;
            c.Telefono = telefonoMaskedTextBox.Text;
            c.Sexo = generoComboBox.SelectedValue.ToString()[0];

            try
            {
                db.Guardar(c);

                DialogResult = DialogResult.OK;
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Faltan datos por completar");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado", "Error");
            }

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactosWindowsFormsApp
{
    public partial class principalForm : Form
    {
        ContactosDataContext db;

        public principalForm()
        {
            InitializeComponent();

            string database = ConfigurationManager.AppSettings["database"];

            db =new ContactosDataContext();

            switch (database)
            {
                case "SQL":
                    {
                        db.CambiarBaseDatos(new ContactosSQLServerDatabase());
                        break;
                    }
                case "ACCESS":
                    {
                        db.CambiarBaseDatos(new ContactosOleDBDatabase());
                        break;
                    }

                case "FILE":
                    {
                        db.CambiarBaseDatos(new ContactosFileDatabase());
                        break;
                    }

                 default:
                    {
                        throw new Exception("Tienes que definir un tipo de base de datos compatible");
                        break;
                    }
            }
            

        }

        private void buscarTextBox_TextChanged(object sender, EventArgs e)
        {
            contactosDataGridView.AutoGenerateColumns = false;
            contactosDataGridView.DataSource = db.Buscar(buscarTextBox.Text);
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            Contacto c = new Contacto();

            contactoDialog dialog = new contactoDialog(c,db);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               

                buscarTextBox_TextChanged(null, null);
            }

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (contactosDataGridView.CurrentRow != null) { 
                Contacto c = contactosDataGridView.CurrentRow.DataBoundItem as Contacto;

                contactoDialog dialog = new contactoDialog(c,db);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
               
                    buscarTextBox_TextChanged(null, null);
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contactosDataGridView.CurrentRow != null)
            {
                Contacto c = contactosDataGridView.CurrentRow.DataBoundItem as Contacto;

               
                if (MessageBox.Show("Estas seguro que quieres eliminar este contacto?","Confirmación", MessageBoxButtons.YesNo)== DialogResult.Yes)  
                {
                    db.Eliminar(c);

                    //Vuelve a cargar los contactos
                    buscarTextBox_TextChanged(null, null);
                }
            }
        }

        private void principalForm_Load(object sender, EventArgs e)
        {

        }
    }
}

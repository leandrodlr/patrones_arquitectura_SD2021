using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADWindowsFormsApp
{



    //Client
    public partial class mainForm : Form
    {


        private List<IFigura> figuras = new List<IFigura>();
        private IFigura figuraActual = null;


        public mainForm()
        {
            InitializeComponent();

            //Esto hace que se dibuje sin delay
            this.DoubleBuffered = true;

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Dibujamos las figuras agregadas
            foreach (IFigura f in figuras)
            {
                f.Dibujar(e.Graphics);
            }

            //Dibujamos la figura actual
            if (figuraActual != null)
                figuraActual.Dibujar(e.Graphics);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Agregamos las figuras iniciales
            figuras.Add(new Cuadrado() { Color = Color.Pink });
            var c = new Circulo();
            c.x = 300;
            c.Color = Color.Blue;

            figuras.Add(c);


        }

        private void circuloButton_Click(object sender, EventArgs e)
        {

            figuraActual = new Circulo();
            figuraActual.Height = (int)altoNumericUpDown.Value;
            figuraActual.Width = (int)anchoNumericUpDown.Value;
            figuraActual.Color = colorButton.BackColor;
        }

        private void cuadradoButton_Click(object sender, EventArgs e)
        {

            figuraActual = new Cuadrado();
            figuraActual.Height = (int)altoNumericUpDown.Value;
            figuraActual.Width = (int)anchoNumericUpDown.Value;
            figuraActual.Color = colorButton.BackColor;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (figuraActual != null)
            {

                figuraActual.x = e.X;
                figuraActual.y = e.Y;


                this.Refresh();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (figuraActual != null)
            {
                figuraActual.x = e.X;
                figuraActual.y = e.Y;
                figuras.Add(figuraActual);
                figuraActual = null;
            }
            else
            {
                foreach (IFigura f in figuras)
                {
                    if (f.Clicked(e.X, e.Y))
                    {
                        if (e.Button == MouseButtons.Right)
                        {
                            //mostramos el menu con el clic derecho
                            menuContextMenuStrip.Show(Cursor.Position);
                            figuraActual = f;

                        }
                        else
                        {
                            //Si es un clic normal seleccionamos la figura para moverla

                            figuraActual = f;

                        }

                        break;
                    }
                }
            }
            this.Refresh();
        }



        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figuras.Remove(figuraActual);
            figuraActual = null;
            this.Refresh();
        }

        private void duplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figuraActual = figuraActual.Clonar();
        }



        private void dibujarButton_Click(object sender, EventArgs e)
        {
            //dibujar();
            Refresh();
        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Left)
                figuraActual = null;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();

            if (d.ShowDialog() == DialogResult.OK)
            {
                colorButton.BackColor = d.Color;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADWindowsFormsApp
{
    //Client
    public partial class Form1 : Form
    {

        List<IFigura> figuras = new List<IFigura>();
        IFigura figuraActual = null;


        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            dibujar();
        }

        
        private void dibujar()
        {
            //this.Invalidate();

            Graphics g = this.CreateGraphics();

            g.Clear(Color.White);

            foreach (IFigura f in figuras)
            {
                f.Dibujar(g);
            }

            if (figuraActual != null)
                figuraActual.Dibujar(g);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            figuras.Add(new Cuadrado());
            var c = new Circulo();
            c.x = 300;
            figuras.Add(c);
           // dibujar();
            
        }

        private void circuloButton_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
           
            if (d.ShowDialog() == DialogResult.OK)
            {
                figuraActual = new Circulo();
                figuraActual.Color = d.Color;
            }

            
        }

        private void cuadradoButton_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();

            if (d.ShowDialog() == DialogResult.OK)
            {
                figuraActual = new Cuadrado();
                figuraActual.Color = d.Color;
            }
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
                        contextMenuStrip1.Show(Cursor.Position);
                        figuraActual = f;
                        break;
                    }
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
          
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figuras.Remove(figuraActual);
            figuraActual = null;
            this.Refresh();
        }

        private void duplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           figuraActual =  figuraActual.Clonar();
        }
    }
}

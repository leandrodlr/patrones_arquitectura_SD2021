using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADWindowsFormsApp
{
    class Circulo : IFigura
    {
        public Color Color { get; set; }

        public Circulo()
        {
            this.Width = 50;
            this.Height = 50;
        }

        public int x { get; set ; }

        public int y { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public bool Clicked(int x, int y)
        {
            return (x >= this.x && x <= this.x + this.Width && y >= this.y && y <= this.y + this.Height);
        }

        public IFigura Clonar()
        {
            return (IFigura)this.MemberwiseClone();
        }

        public void Dibujar(Graphics g)
        {
            Pen color = new Pen(new SolidBrush(this.Color), 3);
            Rectangle rec = new Rectangle(x, y, Width, Height);

            g.DrawArc(color, rec, 0, 360);
        }
    }
}

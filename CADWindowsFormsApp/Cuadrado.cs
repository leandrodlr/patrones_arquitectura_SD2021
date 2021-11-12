using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADWindowsFormsApp
{
    class Cuadrado : IFigura
    {
        public Cuadrado()
        {
            this.Width = 50;
            this.Height = 50;

        }
        public Color Color { get; set; }

        public int x { get; set; }
        public int y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public IFigura Clonar()
        {
            return (IFigura)this.MemberwiseClone();
        }
        public bool Clicked(int x, int y)
        {
            return (x >= this.x && x <= this.x + this.Width && y >= this.y && y <= this.y + this.Height);
        }

        public void Dibujar(Graphics g)
        {
            Pen color = new Pen(new SolidBrush(this.Color), 3);
            g.DrawRectangle(color, new Rectangle(x, y, Width, Height));
        }
    }
}

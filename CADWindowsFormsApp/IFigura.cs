using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADWindowsFormsApp
{
    //Prototype
    interface IFigura
    {
        int x { get; set; }

        int y { get; set; }

        int Width { get; set; }

        int Height { get; set; }
        Color Color { get; set; }

        IFigura Clonar();

        void Dibujar(Graphics g);

        bool Clicked(int x, int y);
    }
}

using System.Collections.Generic;
using System.Drawing;

namespace BitmapVisualizer
{
    class Layout
    {
        private readonly Dictionary<Point, Color> layout;
        private readonly int width;

        public Layout(Dictionary<Point, Color> layout)
        {
            this.layout = layout;

            int biggestX = 0;
            foreach (Point p in layout.Keys)
            {
                if (p.Y > 0)
                    break;
                if (p.X > biggestX)
                    biggestX = p.X;
            }
            width = biggestX;
        }

        public override string ToString()
        {
            string str = "";
            foreach (Point p in layout.Keys)
            {
                str += (IsBlack(layout[p]) ? "x" : " ");
                if (p.X == width)
                    str += "\r\n";
            }
            return str;
        }

        public static bool IsBlack(Color c)
        {
            return (c.R + c.G + c.B) == 0;
        }
    }
}

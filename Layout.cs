using System.Collections.Generic;
using System.Drawing;

namespace BitmapVisualizer {
    class Layout {

        private readonly Dictionary<Point, Color> layout;
        private readonly int width;

        public Layout(Dictionary<Point, Color> layout) {
            this.layout = layout;

            int biggestX = 0;
            foreach (Point p in layout.Keys) {
                if (p.Y > 0)
                    break;
                if (p.X > biggestX)
                    biggestX = p.X;
            }
            width = biggestX;
        }

        public override string ToString() {
            return ToString(Color.Black);
        }

        public string ToString(Color draw) {
            string str = "";
            foreach (Point p in layout.Keys) {
                str += (IsSameColor(layout[p], draw) ? "x" : " ");
                if (p.X == width)
                    str += "\r\n";
            }
            return str;
        }

        public static bool IsSameColor(Color c1, Color c2) {
            return c1.R == c2.R && c1.G == c2.G && c1.B == c2.B;
        }
    }
}

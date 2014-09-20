using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BitmapVisualizer {
    class Layout {

        private readonly Dictionary<Point, Color> layout;

        public Layout(Dictionary<Point, Color> layout) {
            layout.Keys.OrderBy(p => p.Y).ThenBy(p => p.X)
                .ToList().ForEach(p => this.layout.Add(p, layout[p]);
        }

        public override string ToString() {
            return ToString(Color.Black);
        }

        public string ToString(Color draw) {
            string str = "";
            foreach (Point p in layout.Keys) {
                str += (IsSameColor(layout[p], draw) ? "x" : " ");
                if (p.X == layout.Keys.ToList()[layout.Count-1].X)
                    str += "\r\n";
            }
            return str;
        }

        public static bool IsSameColor(Color c1, Color c2) {
            return c1.R == c2.R && c1.G == c2.G && c1.B == c2.B;
        }
    }
}

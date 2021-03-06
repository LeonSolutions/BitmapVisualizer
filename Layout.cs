﻿using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BitmapVisualizer {
    class Layout {

        private readonly Dictionary<Point, Color> layout;

        public Layout(Dictionary<Point, Color> layout) {
            layout.Keys.OrderBy(p => p.Y).ThenBy(p => p.X)
                .ToList().ForEach(p => this.layout.Add(p, layout[p]));
        }

        public static Layout FromBitmap(Bitmap image) { // C# constructors suck
            Dictionary<Point, Color> layout = new Dictionary<Point, Color>();
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    layout.Add(new Point(x, y), image.GetPixel(x, y));
            image.Dispose();
            return new Layout(layout);
        }

        public override string ToString() {
            return ToString(Color.Black);
        }

        public string ToString(Color toDraw) {
            string str = "";
            foreach (Point p in layout.Keys) {
                str += (IsSameColor(layout[p], toDraw) ? "x" : " ");
                if (p.X == layout.Keys.Last().X && p.Y != layout.Keys.Last().Y)
                    str += "\r\n";
            }
            return str;
        }

        public static bool IsSameColor(Color c1, Color c2) {
            return c1.R == c2.R && c1.G == c2.G && c1.B == c2.B;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;

namespace BitmapVisualizer
{
    class Program
    {
        static readonly string stuff = @"C:\Users\Sam\Desktop\gg.bmp";

        static void Main(string[] args)
        {
            Bitmap image = new Bitmap(stuff, true);
            Dictionary<Point, Color> layout = new Dictionary<Point, Color>();

            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    layout.Add(new Point(x, y), image.GetPixel(x, y));

            Console.Write(new Layout(layout).ToString());
            Console.Read();
        }
    }
}

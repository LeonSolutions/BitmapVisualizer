using System;
using System.Collections.Generic;
using System.Drawing;

namespace BitmapVisualizer {
    class Program {

        static void Main(string[] args) {
            if (args.Length > 0) {
                try {
                    Bitmap image = new Bitmap(args[0], true);
                    Dictionary<Point, Color> layout = new Dictionary<Point, Color>();

                    for (int y = 0; y < image.Height; y++)
                        for (int x = 0; x < image.Width; x++)
                            layout.Add(new Point(x, y), image.GetPixel(x, y));
                    image.Dispose();
                    Console.Write(new Layout(layout).ToString());
                } catch {
                    Console.WriteLine("No file called " + args[0] + " found");
                }
            } else
                Console.WriteLine("No args");
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

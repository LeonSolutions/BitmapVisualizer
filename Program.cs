using System;
using System.Collections.Generic;
using System.Drawing;

namespace BitmapVisualizer {
    class Program {

        static void Main(string[] args) {
            if (args.Length > 0) {
                try {
                    Console.Write(Layout.FromBitmap(new Bitmap(args[0], true)).ToString());
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

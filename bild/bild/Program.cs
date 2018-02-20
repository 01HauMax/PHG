using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace bild
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] a = new char[80, 40];
            Console.SetWindowSize(90,50);
            int x = 0, y = 0;
            string b;
            bool tot = false;
            string xy;
            Console.WriteLine("1: Malen");
            Console.WriteLine("2: Lesen");
            
            switch(Console.ReadKey(true).Key)
            {
                    case ConsoleKey.D1:
                    Console.WriteLine("Pfad eingeben:");
                    xy = Console.ReadLine();
                    Console.Clear();
            while (tot==false)
            {
                    StreamReader sr = new StreamReader(xy);
                    b = sr.ReadToEnd();
                    sr.Close();
                for (int i = 0; i < 40; i++)
                {
                    for (int g = 0; g < 80; g++)
                    {
                        Console.Write(a[g, i]);
                    }
                    Console.WriteLine();
                }
            
                Console.SetCursorPosition(x, y);
                var c = Console.ReadKey(true);
                switch (c.Key)
                {
                    case ConsoleKey.UpArrow:
                        y = y - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        y = y + 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        x = x - 1;
                        break;
                    case ConsoleKey.RightArrow:
                        x = x + 1;
                        break;
                    case ConsoleKey.Spacebar:
                        a[x,y]='█';
                        break;
                    case ConsoleKey.Escape:
                        tot = true;
                        break;
                }

                Console.Clear();
                if (a[x, y] == '█')
                {
                    StreamWriter sw = new StreamWriter(xy);
                    sw.Write(b + x + ";" + y + ";");
                    sw.Close();
                }
                
            }
            break;

                case ConsoleKey.D2:
                    Console.WriteLine("Pfad eingeben:");
                    xy = Console.ReadLine();
            Console.Clear();
                StreamReader sr1 = new StreamReader(xy);
                b = sr1.ReadToEnd();
                sr1.Close();

                b = b.TrimEnd(';');
                string[] f = b.Split(';');
                for (int i = 0; i < f.Length; i=i+2)
                {
                    Console.SetCursorPosition(Convert.ToInt32(f[i]), Convert.ToInt32(f[i + 1]));
                    Console.WriteLine('█');
                }

            
            break;
        }
            Console.ReadKey();
        }
    }
}

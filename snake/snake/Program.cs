using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔═══════════════════╗");
            Console.WriteLine("║       Snake       ║");
            Console.WriteLine("║ Hauser Maximilian ║");
            Console.WriteLine("║ Steuerung:        ║");
            Console.WriteLine("║ WSAD oder Pfeile  ║");
            Console.WriteLine("╚═══════════════════╝");
            var c = Console.ReadKey();
            char[,] p = new char[22, 22];
            int[,] s = new int[2, 400];
            Random Rnd = new Random((int)DateTime.Now.Ticks);
            int x = 10, y = 10, g = 1, sleep=200;
            bool m = true, tot = false;
            for (int z = 0; z < 20; z++)
            {
                p[20, z] = '║';
                p[0, z] = '║';
            }
            for (int z = 0; z < 20; z++)
            {
                p[z, 20] = '═';
                p[z, 0] = '═';
            }
            p[20, 20] = '╝';
            p[0, 0] = '╔';
            p[0, 20] = '╚';
            p[20, 0] = '╗';
            while (tot==false)
            {
                if ((g-1) == 10)
                {
                    sleep = 180;
                }
                if ((g - 1) == 20)
                {
                    sleep = 160;
                }
                if ((g - 1) == 30)
                {
                    sleep = 140;
                }
                if ((g - 1) == 50)
                {
                    sleep = 120;
                }
                if(m == true)
                {
                    p[Rnd.Next(1,20),Rnd.Next(1,20)] = '@';                  
                }
                m = true;
                System.Threading.Thread.Sleep(sleep);
                p[x, y] = default(char);
                if (Console.KeyAvailable == true)
                {
                    c = Console.ReadKey();
                }
                Console.Clear();

                for (int i = g-1; i >= 0; i--)
                {
                    if (i + 1 <= g)
                    {
                        s[1, i + 1] = s[1, i];
                    }
                }
                for (int i = g-1; i >= 0; i--)
                {
                    if (i + 1 <= g)
                    {
                        s[0, i + 1] = s[0, i];
                    }
                }
                s[0, 0] = x;
                s[1, 0] = y;
                switch (c.Key)
                {
                    case ConsoleKey.A:
                        if (x > 1)
                        {
                            x = x - 1;
                        }
                        else
                        {
                            tot = true;
                        }
                        break;
                    case ConsoleKey.D:
                        if (x < 20)
                        {
                            x = x + 1;
                        }
                        else
                        {
                            tot = true;
                        }
                        break;
                    case ConsoleKey.W:
                        if (y > 1)
                        {
                            y = y - 1;
                        }
                        else
                        {
                            tot = true;
                        }
                        break;
                    case ConsoleKey.S:
                        if (y < 20)
                        {
                            y = y + 1;
                        }
                        else
                        {
                            tot = true;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 1)
                        {
                            x = x - 1;
                        }
                        else
                        {
                            tot = true;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < 20)
                        {
                            x = x + 1;
                        }
                        else
                        {
                            tot = true;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 1)
                        {
                            y = y - 1;
                        }
                        else
                        {
                            tot = true;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < 20)
                        {
                            y = y + 1;
                        }
                        else
                        {
                            tot = true;
                        }
                        break;
                }
                if (p[x, y] == '@')
                {
                    g = g + 1;
                }
                p[x, y] = 'O';
                for (int i = 0; i < 22; i++)
                {
                    for (int z = 0; z < 22; z++)
                    {
                        for (int l = g - 1; l >= 0; l--)
                        {
                            if (s[0, l] == z && s[1, l] == i)
                            {
                                p[z, i] = 'x';
                            }
                            if (p[x, y] == 'x')
                            {
                                tot = true;
                            }
                        }
                        Console.Write(p[z, i]);
                        if (p[z, i] == 'x')
                        {
                            p[z, i] = ' ';
                        }
                        if(p[z, i] == '@')
                        {
                            m = false;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Punkte: " + (g - 1));
            }
            Console.Clear();
            Console.WriteLine("╔═══════════════════╗");
            Console.WriteLine("║    Snake R.I.P    ║");
            if ((g - 1) < 10)
            {
                Console.WriteLine("║    Punkte: " + (g - 1) + "      ║");
            }
            else if ((g - 1) < 100)
            {
                Console.WriteLine("║    Punkte: " + (g - 1) + "     ║");
            }
            else
            {
                Console.WriteLine("║    Punkte: " + (g - 1) + "    ║");
            }
            Console.WriteLine("║   Name eingabe    ║");
            Console.WriteLine("╚═══════════════════╝");
            Console.Write(": ");
            string name = Console.ReadLine();
            string hs;
            StreamReader sr = new StreamReader("Highscore.txt");
            hs = sr.ReadToEnd();
            sr.Close();
            StreamWriter sw = new StreamWriter("Highscore.txt");
            sw.WriteLine(hs+"\r"+name+": "+(g-1));
            sw.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace mini
{
    class Program
    {
        static void Main(string[] args)
        {
            bool r = false;
            int pu = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            do
            {
                int xx = 0, yy = 0, xg1 = 10, yg1 = 9, g1 = 0, xg2 = 10, yg2 = 9, g2 = 0, xg3 = 10, yg3 = 9, g3 = 0;
                bool ll = false, tot = false, win = false;
                Random Rnd = new Random((int)DateTime.Now.Ticks);

                Console.Clear();
                Console.SetWindowSize(20, 22);
                char[,] p = new char[19, 21];
                p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = ' '; xx++; p[xx, yy] = ' '; xx++; p[xx, yy] = ' '; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = ' '; xx++; p[xx, yy] = ' '; xx++; p[xx, yy] = ' '; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '#'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = ' '; xx++; p[xx, yy] = ' '; xx++; p[xx, yy] = ' '; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '#'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = ' '; xx++; p[xx, yy] = ' '; xx++; p[xx, yy] = ' '; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = ' '; xx++; p[xx, yy] = ' '; xx++; p[xx, yy] = ' '; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = ' '; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '*'; xx++; p[xx, yy] = '█'; xx = 0; yy++;
                p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx++; p[xx, yy] = '█'; xx = 0; yy++;


                int x = 10, y = 15;
                /*Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("███████████████████");
                Console.WriteLine("█********█********█");
                Console.WriteLine("█*██*███*█*███*██*█");
                Console.WriteLine("█*****************█");
                Console.WriteLine("█*██*█*█████*█*██*█");
                Console.WriteLine("█****█***█***█****█");
                Console.WriteLine("████*███*█*███*████");
                Console.WriteLine("   █*█*******█*█");
                Console.WriteLine("████*█*██ ██*█*████");
                Console.WriteLine("*******█   █*******");
                Console.WriteLine("████*█*██ ██*█*████");
                Console.WriteLine("   █*█*******█*█");
                Console.WriteLine("████*█*█████*█*████");
                Console.WriteLine("█********█********█");
                Console.WriteLine("█*██*███*█*███*██*█");
                Console.WriteLine("█**█***********█**█");
                Console.WriteLine("██*█*█*█████*█*█*██");
                Console.WriteLine("█****█***█***█****█");
                Console.WriteLine("█*██████*█*██████*█");
                Console.WriteLine("█*****************█");
                Console.WriteLine("███████████████████");*/
                for (int i = 0; i < 21; i++)
                {
                    for (int g = 0; g < 19; g++)
                    {
                        if (p[g, i] == '█')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (p[g, i] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (p[g, i] == '#')
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        Console.Write(p[g, i]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
                var c = Console.ReadKey(true);
                while (tot == false)
                {

                    bool ss = false;
                    for (int i = 0; i < 21; i++)
                    {
                        for (int g = 0; g < 19; g++)
                        {
                            if (p[g, i] == '*')
                            {
                                ss = true;
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    if (ss == false)
                    {
                        win = true;
                        tot = true;
                    }
                    ss = false;
                    System.Threading.Thread.Sleep(200);
                    if (Console.KeyAvailable == true)
                        c = Console.ReadKey(true);

                    switch (c.Key)
                    {
                        case ConsoleKey.A:
                            if (x == 0 && y == 9)
                            {
                                Console.SetCursorPosition(x, y);
                                Console.Write(' ');
                                x = 18;
                                if (p[x, y] == '*')
                                {
                                    pu++;
                                }
                                p[x, y] = ' ';
                            }
                            else if (p[x - 1, y] != '█')
                            {
                                Console.SetCursorPosition(x, y);
                                Console.Write(' ');
                                x = x - 1;
                                if (p[x, y] == '*')
                                {
                                    pu++;
                                }
                                p[x, y] = ' ';
                            }
                            break;
                        case ConsoleKey.D:
                            if (x == 18 && y == 9)
                            {
                                Console.SetCursorPosition(x, y);
                                Console.Write(' ');
                                x = 0;
                                if (p[x, y] == '*')
                                {
                                    pu++;
                                }
                                p[x, y] = ' ';
                            }
                            else if (p[x + 1, y] != '█')
                            {
                                Console.SetCursorPosition(x, y);
                                Console.Write(' ');
                                x = x + 1;
                                if (p[x, y] == '*')
                                {
                                    pu++;
                                }
                                p[x, y] = ' ';
                            }
                            break;
                        case ConsoleKey.W:
                            if (p[x, y - 1] != '█' && p[x, y - 1] != '#')
                            {
                                Console.SetCursorPosition(x, y);
                                if (p[x, y] == '*')
                                {
                                    pu++;
                                }
                                Console.Write(' ');
                                y = y - 1;
                                p[x, y] = ' ';
                            }

                            break;
                        case ConsoleKey.S:
                            if (p[x, y + 1] != '█' && p[x, y + 1] != '#')
                            {
                                Console.SetCursorPosition(x, y);
                                if (p[x, y] == '*')
                                {
                                    pu++;
                                }
                                Console.Write(' ');
                                y = y + 1;
                                p[x, y] = ' ';
                            }
                            break;
                        case ConsoleKey.P:
                            Console.ReadKey();
                            break;
                    }
                    if (x == xg1 && y == yg1)
                    {
                        tot = true;
                    }
                    if (x == xg2 && y == yg2)
                    {
                        tot = true;
                    }
                    if (x == xg3 && y == yg3)
                    {
                        tot = true;
                    }
                    while (ll == false)
                    {
                        if (xg1 == 0 && yg1 == 9)
                        {
                        }
                        else if (xg1 == 18 && yg1 == 9)
                        {
                        }
                        else if (p[xg1 - 1, yg1] == ' ' && p[xg1 + 1, yg1] == ' ' && p[xg1, yg1 - 1] == '█' && p[xg1, yg1 + 1] == '█')
                        {
                        }
                        else if (p[xg1 - 1, yg1] == '█' && p[xg1 + 1, yg1] == '█' && p[xg1, yg1 - 1] == ' ' && p[xg1, yg1 + 1] == ' ')
                        {
                        }
                        else
                        {
                            bool kk = false;
                            if (kk == false && x == xg1 && yg1 > y && p[xg1, yg1 - 1] != '█' && p[xg1, yg1 - 1] != '@')
                            {
                                g1 = 2;
                                kk = true;
                            }
                            else if (kk == false && x == xg1 && yg1 < y && p[xg1, yg1 + 1] != '█' && p[xg1, yg1 + 1] != '@')
                            {
                                g1 = 3;
                                kk = true;
                            }
                            else if (kk == false && y == yg1 && xg1 > x && p[xg1 - 1, yg1] != '█' && p[xg1 - 1, yg1] != '@')
                            {
                                g1 = 0;
                                kk = true;
                            }
                            else if (kk == false && y == yg1 && xg1 < x && p[xg1 + 1, yg1] != '█' && p[xg1 + 1, yg1] != '@')
                            {
                                g1 = 1;
                                kk = true;
                            }
                            else
                            {
                                g1 = Rnd.Next(0, 4);
                            }
                        }
                        switch (g1)
                        {
                            case 0:
                                if (xg1 == 0 && yg1 == 9)
                                {
                                    Console.SetCursorPosition(xg1, yg1);
                                    if (p[xg1, yg1] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    xg1 = 18;
                                }
                                else if (p[xg1 - 1, yg1] != '█' && p[xg1 - 1, yg1] != '@')
                                {
                                    Console.SetCursorPosition(xg1, yg1);
                                    if (p[xg1, yg1] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    xg1 = xg1 - 1;
                                    ll = true;
                                }
                                break;
                            case 1:
                                if (xg1 == 18 && yg1 == 9)
                                {
                                    Console.SetCursorPosition(xg1, yg1);
                                    if (p[xg1, yg1] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    xg1 = 0;
                                }
                                else if (p[xg1 + 1, yg1] != '█' && p[xg1 + 1, yg1] != '@')
                                {
                                    Console.SetCursorPosition(xg1, yg1);
                                    if (p[xg1, yg1] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    xg1 = xg1 + 1;
                                    ll = true;
                                }
                                break;
                            case 2:
                                if (p[xg1, yg1 - 1] != '█' && p[xg1, yg1 - 1] != '@')
                                {
                                    Console.SetCursorPosition(xg1, yg1);
                                    if (p[xg1, yg1] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    yg1 = yg1 - 1;
                                    ll = true;
                                }
                                break;
                            case 3:
                                if (p[xg1, yg1 + 1] != '█' && p[xg1, yg1 + 1] != '@')
                                {
                                    Console.SetCursorPosition(xg1, yg1);
                                    if (p[xg1, yg1] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    yg1 = yg1 + 1;
                                    ll = true;
                                }
                                break;
                        }
                    }
                    ll = false;
                    while (ll == false)
                    {
                        if (xg2 == 0 && yg2 == 9)
                        {
                        }
                        else if (xg2 == 18 && yg2 == 9)
                        {
                        }
                        else if (p[xg2 - 1, yg2] == ' ' && p[xg2 + 1, yg2] == ' ' && p[xg2, yg2 - 1] == '█' && p[xg2, yg2 + 1] == '█')
                        {
                        }
                        else if (p[xg2 - 1, yg2] == '█' && p[xg2 + 1, yg2] == '█' && p[xg2, yg2 - 1] == ' ' && p[xg2, yg2 + 1] == ' ')
                        {
                        }
                        else
                        {
                            g2 = Rnd.Next(0, 4);

                        }
                        switch (g2)
                        {
                            case 0:
                                if (xg2 == 0 && yg2 == 9)
                                {
                                    Console.SetCursorPosition(xg2, yg2);
                                    if (p[xg2, yg2] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    xg2 = 18;
                                }
                                else if (p[xg2 - 1, yg2] != '█' && p[xg2 - 1, yg2] != '@')
                                {
                                    Console.SetCursorPosition(xg2, yg2);
                                    if (p[xg2, yg2] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    xg2 = xg2 - 1;
                                    ll = true;
                                }
                                break;
                            case 1:
                                if (xg2 == 18 && yg2 == 9)
                                {
                                    Console.SetCursorPosition(xg2, yg2);
                                    if (p[xg2, yg2] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    xg2 = 0;
                                }
                                else if (p[xg2 + 1, yg2] != '█' && p[xg2 + 1, yg2] != '@')
                                {
                                    Console.SetCursorPosition(xg2, yg2);
                                    if (p[xg2, yg2] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    xg2 = xg2 + 1;
                                    ll = true;
                                }
                                break;
                            case 2:
                                if (p[xg2, yg2 - 1] != '█' && p[xg2, yg2 - 1] != '@')
                                {
                                    Console.SetCursorPosition(xg2, yg2);
                                    if (p[xg2, yg2] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    yg2 = yg2 - 1;
                                    ll = true;
                                }
                                break;
                            case 3:
                                if (p[xg2, yg2 + 1] != '█' && p[xg2, yg2 + 1] != '@')
                                {
                                    Console.SetCursorPosition(xg2, yg2);
                                    if (p[xg2, yg2] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    yg2 = yg2 + 1;
                                    ll = true;
                                }
                                break;
                        }
                    }
                    ll = false;

                    while (ll == false)
                    {
                        if (xg3 == 0 && yg3 == 9)
                        {
                        }
                        else if (xg3 == 18 && yg3 == 9)
                        {
                        }
                        else if (p[xg3 - 1, yg3] == ' ' && p[xg3 + 1, yg3] == ' ' && p[xg3, yg3 - 1] == '█' && p[xg3, yg3 + 1] == '█')
                        {
                        }
                        else if (p[xg3 - 1, yg3] == '█' && p[xg3 + 1, yg3] == '█' && p[xg3, yg3 - 1] == ' ' && p[xg3, yg3 + 1] == ' ')
                        {
                        }
                        else
                        {
                            g3 = Rnd.Next(0, 4);

                        }
                        switch (g3)
                        {
                            case 0:
                                if (xg3 == 0 && yg3 == 9)
                                {
                                    Console.SetCursorPosition(xg3, yg3);
                                    if (p[xg3, yg3] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    xg3 = 18;
                                }
                                else if (p[xg3 - 1, yg3] != '█' && p[xg3 - 1, yg3] != '@')
                                {
                                    Console.SetCursorPosition(xg3, yg3);
                                    if (p[xg3, yg3] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    xg3 = xg3 - 1;
                                    ll = true;
                                }
                                break;
                            case 1:
                                if (xg3 == 18 && yg3 == 9)
                                {
                                    Console.SetCursorPosition(xg3, yg3);
                                    if (p[xg3, yg3] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    xg3 = 0;
                                }
                                else if (p[xg3 + 1, yg3] != '█' && p[xg3 + 1, yg3] != '@')
                                {
                                    Console.SetCursorPosition(xg3, yg3);
                                    if (p[xg3, yg3] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    xg3 = xg3 + 1;
                                    ll = true;
                                }
                                break;
                            case 2:
                                if (p[xg3, yg3 - 1] != '█' && p[xg3, yg3 - 1] != '@')
                                {
                                    Console.SetCursorPosition(xg3, yg3);
                                    if (p[xg3, yg3] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    yg3 = yg3 - 1;
                                    ll = true;
                                }
                                break;
                            case 3:
                                if (p[xg3, yg3 + 1] != '█' && p[xg3, yg3 + 1] != '@')
                                {
                                    Console.SetCursorPosition(xg3, yg3);
                                    if (p[xg3, yg3] == '*')
                                    {
                                        Console.Write('*');
                                    }
                                    else
                                    {
                                        Console.Write(' ');
                                    }
                                    yg3 = yg3 + 1;
                                    ll = true;
                                }
                                break;
                        }
                    }
                    ll = false;
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write('O');
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xg1, yg1);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write('@');
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xg2, yg2);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write('@');
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xg3, yg3);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write('@');
                    Console.ForegroundColor = ConsoleColor.White;
                    if (x == xg1 && y == yg1)
                    {
                        tot = true;
                    }
                    if (x == xg2 && y == yg2)
                    {
                        tot = true;
                    }
                }
                Console.Clear();
                if (win == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("GAME OVER");
                    Console.Write(pu+" Punkte");
                }
                else
                {
                    r = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ES GEHT WEITER MIT ENTER!");
                    Console.Write(pu + " Punkte");
                }
                Console.ReadKey();
            } while (r == true);
        }
    }
}

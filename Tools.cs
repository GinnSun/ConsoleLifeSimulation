using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class ConsoleTools
    {
        public static readonly string space = string.Concat(Enumerable.Repeat("=", 210));

        public static void CursorPosition(int x, int y) => Console.SetCursorPosition(x,y);

        public static void Clear() => Console.Clear();

        public static void Sleep(int time) => Thread.Sleep(time);

        public static void ConsoleColors(Colors colors)
        {
            switch (colors)
            {
                case Colors.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Colors.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Colors.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Colors.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case Colors.DarkCyan:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case Colors.DarkRed:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case Colors.DarkYellow:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case Colors.DarkGreen:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case Colors.DarkBlue:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case Colors.DarkMagenta:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                default:
                    Console.ResetColor();
                    break;
            }
        }

        public enum Colors
        {
            White,
            Green,
            Yellow,
            Cyan,
            Red,
            Gray,
            Blue,
            Magenta,
            DarkCyan,
            DarkRed,
            DarkYellow,
            DarkGreen,
            DarkBlue,
            DarkMagenta
        }
    }
}
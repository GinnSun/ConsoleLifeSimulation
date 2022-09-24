using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Tools;
using Simulation;

namespace EnterSimulation
{
    class Program
    {
        static void ChangeColor(string[] colorsName)
        {
            Console.WriteLine("Colors:");
            for (int i = 0; i < colorsName.Length; i++)
            {
                Console.Write(colorsName[i] + " | ");
            }

            Console.WriteLine("\n" + "\n" + ConsoleTools.space + "\n");

            Console.Write("Write color wich you want:\t");

            var userColors = (ConsoleTools.Colors)Enum.Parse(typeof(ConsoleTools.Colors), Console.ReadLine(), ignoreCase: true);

            ConsoleTools.ConsoleColors(userColors);

            Console.WriteLine("I changed color!");

            ConsoleTools.Sleep(800);
            ConsoleTools.Clear();
        }
        static void Main(string[] args)
        {
            string[] colorsName = 
            {
                "White", "Yellow", "Green",
                "Red", "Gray", "Cyan", "Magenta",
                "Blue", "DarkRed", "DarkBlue",
                "DarkGreen", "DarkYellow", "DarkCyan",
                "DarkMagenta"
            };

            ChangeColor(colorsName);

            var loggicsSimulation = new LoggicsSimulation("#");

            if (loggicsSimulation is IPrintEnd printEnd) printEnd.PrintEnd();
        }
    }
}
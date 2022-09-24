using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;


namespace Simulation
{
    interface IPrintEnd
    {
        void PrintEnd();
    }

    struct Points
    {
        public int x;
        public int y;

        public const int minValue = 0;
        public const int maxValueX = 210;
        public const int maxValueY = 49;
    }

    abstract class Loggics : IPrintEnd
    {

        protected Points points;

        protected readonly string symbol;

        protected const string nothingSymbol = " ";

        public Loggics(string symbol) => this.symbol = symbol;

        protected abstract void CreateSimulation();
        public abstract void PrintEnd();
    }

    class LoggicsSimulation : Loggics
    {

        private readonly Random rand = new Random();

        private bool condition { get; set; } = true;

        private bool conditionToExit { get; set; }

        private const long MaxCount = long.MaxValue;

        private int valueForCondition { get; set; }

        private int MaxValueForRandom = 20;

        private int MinValueForRandom = 0;

        private long count;

        private const int value_time_for_create = 150;

        private const int value_time_for_delete = 100;

        private int previosX { get; set; }
        private int previosY { get; set; }

        public LoggicsSimulation(string symbol) : base(symbol) { }

        protected override void CreateSimulation()
        {
            while (true)
            {
                points.x = rand.Next(Points.minValue, Points.maxValueX);
                points.y = rand.Next(Points.minValue, Points.maxValueY);

                conditionToExit = count == MaxCount;

                if (condition)
                {
                    ConsoleTools.CursorPosition(points.x, points.y);
                    Console.Write(symbol);
                    count++;
                    ConsoleTools.Sleep(value_time_for_create);
                    previosX = points.x;
                    previosY = points.y;
                }
                else
                {
                    ConsoleTools.CursorPosition(periosX, previosY);
                    Console.Write(nothingSymbol);
                    count++;
                    ConsoleTools.Sleep(value_time_for_delete);
                }

                if (conditionToExit) break;

                valueForCondition = rand.Next(MinValueForRandom, MaxValueForRandom);

                if (valueForCondition >= 10) condition = true;
                else condition = false;
            }
        }

        public override void PrintEnd()
        {
            CreateSimulation();
        }

    }
}

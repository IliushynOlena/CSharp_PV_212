using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IntroToOOP_Properties
{
    partial class Point
    {
        private int xCoord;
        public int XCoord
        {
            get
            {
                return xCoord;
            }
            set// value
            {
                if (value >= 0)
                    xCoord = value;
                else
                    xCoord = 0;
            }
        }

        private int yCoord;
        public int YCoord
        {
            get
            {
                return yCoord;
            }
            set// value
            {
                if (value >= 0)
                    yCoord = value;
                else
                    yCoord = 0;
            }
        }

    }
    partial class Point
    {
        public void SetX(int x)
        {
            if (x >= 0)
                xCoord = x;
            else
                xCoord = 0;
        }
        public void SetY(int y)
        {
            if (y >= 0)
                yCoord = y;
            else
                yCoord = 0;
        }
        public int getX()
        {
            return xCoord;
        }
        public int getY()
        {
            return yCoord;
        }
    }
    partial class Point
    {
        public void Print()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"X : {xCoord}. Y : {yCoord}");
            Console.ResetColor();
        }
        public override string ToString()
        {
            return $"Name : {Name}. X : {xCoord}. Y : {yCoord}";
        }

    }

   
}

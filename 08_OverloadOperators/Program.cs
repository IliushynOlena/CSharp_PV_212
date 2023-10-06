using System.Security.Cryptography;

namespace _08_OverloadOperators
{

    class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D() : this(0, 0, 0) { }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $" x : {X} , y : {Y} , z {Z}";
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point() : this(0, 0) { }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $" x : {X} , y : {Y}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        //ref out  - not allowed
        //      public static return_type operator[symbol](parameters)
        //      {
        //            //code
        //      }
        #region Унарні оператори
        public static Point operator -(Point p)
        {
            Point pNew = new Point
            {
                X = p.X * -1,
                Y = p.Y * -1
            };
            return pNew;
        }
        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }
        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }
        #endregion

        #region Binary Operators
        public static Point operator +(Point p1, Point p2)
        {
            Point p3 = new Point
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
            return p3;
        }
        public static Point operator -(Point p1, Point p2)
        {
            Point p3 = new Point
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
            return p3;
        }
        public static Point operator *(Point p1, Point p2)
        {
            Point p3 = new Point
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y
            };
            return p3;
        }
        public static Point operator /(Point p1, Point p2)
        {

            Point p3 = new Point
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
            return p3;

        }
        #endregion

        #region Operator Equals
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
           // return p1.X == p2.X && p1.Y == p2.Y;
        }
        //in pair
        public static bool operator !=(Point p1, Point p2)
        {
            //return !p1.Equals(p2);
            // return p1.X != p2.X && p1.Y != p2.Y;
            return !(p1 == p2);
        }
        public static bool operator >(Point p1, Point p2)
        {
            return p1.X + p1.Y > p2.X + p2.Y;
        }
        //in pair
        public static bool operator <(Point p1, Point p2)
        {
            return p1.X + p1.Y < p2.X + p2.Y;
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return p1.X + p1.Y >= p2.X + p2.Y;
        }
        //in pair
        public static bool operator <=(Point p1, Point p2)
        {
            return p1.X + p1.Y <= p2.X + p2.Y;
        }
        #endregion
        #region true/false operators
        public static bool operator true(Point p)
        {
           return p.X != 0 || p.Y != 0;
           //return p != null;
        }
        //in pair
        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0;
            //return p != null;
        }
        #endregion

        #region Type cast
        public static explicit operator int(Point p)
        {
            return p.X + p.Y;
        }

        public static implicit operator double(Point p)
        {
            return p.X + p.Y;
        }
        public static explicit operator Point3D(Point p)
        {
            return new Point3D(p.X, p.Y, 0);
        }
        #endregion
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            double b = 6.7;

            b = a;//int -> double implicit
            a = (int) b;//double -> int  explicit

            Point test = new Point(1, 1);
            Console.WriteLine("Test : " +  test);
            a = (int) test;//explicit
            Console.WriteLine(a);
            b = test;// implicit
            Console.WriteLine(b);
            Point3D point =(Point3D) test;
            Console.WriteLine(point);


            //object obj = new object();//ref address
            //obj.Equals("Hello");
            string str = "Hello";
            string str2 = "Hello";
            //string str3 = "Hello";
            //string str4 = "Hello";
            //string str5 = "Hello";
            //string str6 = "Hello";
            //string str7 = "Hello";
            //str += "!";

           // if ( str.Equals(str2))
           //     Console.WriteLine("Equals");
           //else
           //     Console.WriteLine("Not equals");

           // object.ReferenceEquals(str, str2);

           Point p1 = new Point() { X = 3, Y = 10 };
           Point p2 = new Point() { X = 5, Y = 7 };

            if(p1)
            {
                Console.WriteLine("Point p1 is true");
            }
            else
            {
                Console.WriteLine("Point p1 is false");
            }

           // if (p1.Equals(p2))
           //     Console.WriteLine("Equals");
           // else
           //     Console.WriteLine("Not equals");


            Console.WriteLine(p1);

            Console.WriteLine((-p1).ToString());
            Point res = -p1;
            Console.WriteLine(res.ToString());
            Console.WriteLine(p1++);
            Console.WriteLine(++p1);
            Console.WriteLine(--p1);
            Console.WriteLine(p1--);

            Console.WriteLine($"Point 1 : {p1}");
            Console.WriteLine($"Point 2 : {p2}");
            res = p1 + p2;
            Console.WriteLine(res.ToString());
            res = p1 - p2;
            Console.WriteLine(res.ToString());
            res = p1 * p2;
            Console.WriteLine(res.ToString());
            res = p1 / p2;
            Console.WriteLine(res.ToString());

            if(p1 == p2)
                Console.WriteLine("Point is equals!!!");
            else
                Console.WriteLine("Point is not equals");

            if (p1> p2)
                Console.WriteLine("Point p1 > p2!!!");
            else
                Console.WriteLine("Point p1 < p2");

        }


    }
}
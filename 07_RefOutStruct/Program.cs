

namespace _07_RefOutStruct
{
    using _2D_Objects;
    using System.Collections.Specialized;

    partial struct MyStruct
    {
        public int MyProperty { get; set; }
    }

    partial struct MyStruct
    {
        public int MyProperty1 { get; set; }
    }
    class Point
    {
        public int X { get; set; }//private int x;
        public int Y { get; set; }//private int y;
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public void Print()
        {
            Console.WriteLine($"_07_RefOutStruct . x : {X}, y {Y}");
        }
    }
    /*
    Access Spetifacators
   - private(default for fiels in class)
   - public
   - protected
   - internal
   - protected internal
    */
    //struct Rectangle
    //{
    //    public int Height { get; set; }
    //    public int Width { get; set; }
    //    public Rectangle(int h, int w)
    //    {
    //        Height = h;
    //        Width = w;
    //    }
    //    public void Print()
    //    {
    //        Console.WriteLine($"Rectangle . h : {Height}, w {Width}");
    //    }

    //}
    class Rectangle
    {
        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid height");
                height = value;
            }
        }
        public int Width { get; set; }
        public Rectangle(int h, int w)
        {
            Height = h;
            Width = w;
        }
        public void Print()
        {
            Console.WriteLine($"Rectangle . h : {Height}, w {Width}");
        }

    }
    internal class Program
    {
        //params  - set many parameters
        static void MethodWithParams(string name, params int[]marks)
        {
            Console.WriteLine("------------" + name + "----------");
            foreach (var item in marks)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void MethodWithParams(string name1, string name2, 
            params int[] marks)
        {
            Console.WriteLine("------------" + name1 + "----------");
            foreach (var item in marks)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------" + name2 + "----------");
            foreach (var item in marks)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Modify(ref int num,ref string str, ref Point point)
        {
            num += 1;
            str += "!";
            point.X++;
            point.Y++;           
        }
        //static void  GetCurrentTime(ref int hour,ref int minute,ref int sec)
        //{
        //    hour = DateTime.Now.Hour;
        //    minute = DateTime.Now.Minute;
        //    sec = DateTime.Now.Second;
        //    //return hour, minutes, sec;
        //}
        static void GetCurrentTime(out int hour, out int minute, out int sec)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            sec = DateTime.Now.Second;
            //return hour, minutes, sec;
        }
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(0 , 10);
            rectangle1.Print();

            try
            {
                rectangle1.Height--;
                rectangle1.Print();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argument exeption");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           

            try
            {
                string name = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine(name);
                Console.WriteLine(price);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          
            /*
            Point p;//p = null;
            Rectangle r = new Rectangle();//default construct
            int a;
            
            Point point = new Point();//invoke constructor - references type
            point.Print();

            DateTime now = DateTime.Now;
            DateTime hireDate = new DateTime(2022, 5, 6);
            Rectangle rectangle = new Rectangle(10,15);//value type
            rectangle.Print();
            */
            /*
            //int h = 0, m = 0, s = 0;
            //Console.WriteLine($"Time {h}:{m}:{s}");
            //GetCurrentTime(ref h, ref m, ref s);
            //Console.WriteLine($"Time {h}:{m}:{s}");
            int h, m ,s;
            //Console.WriteLine($"Time {h}:{m}:{s}");
            GetCurrentTime(out h, out m, out s);
            Console.WriteLine($"Time {h}:{m}:{s}");


            int num = 10;
            string str = "Hello academy";
            Point point = new Point{ X = 5, Y = 5};
            Console.WriteLine($"Num = {num}");
            Console.WriteLine($"Str = {str}");
            point.Print();
            Modify(ref num,ref str, ref point);
            Console.WriteLine("---------------------");
            Console.WriteLine($"Num = {num}");
            Console.WriteLine($"Str = {str}");
            point.Print();
            */
            /*
            string name = "Olena";
            int[] marks = { 11, 12, 10, 8, 7, 9, 6 };
            MethodWithParams(name, marks);
            MethodWithParams("Bob", 12, 12, 10, 11, 8, 4,12,12,12,10,4,5,6);//initializer_list
            MethodWithParams("Bob", "Tom", 12, 12, 10, 11, 8, 4,10,12,11,12,10,5,9);
            */
            //Point point = new Point();
            //point.Print();
            ////_2D_Objects.Point point1 = new _2D_Objects.Point();
            //Point point1 = new Point();
            //point1.Print();
        }
    }
}



namespace _2D_Objects
{
    struct Point
    {
        public int X { get; set; }//private int x;
        public int Y { get; set; }//private int y;
        public void Print()
        {
            Console.WriteLine($"_2D_Objects : x : {X}, y {Y}");
        }
    }
}

namespace _3D_Objects
{
    struct Point
    {
        public int X { get; set; }//private int x;
        public int Y { get; set; }//private int y;
        public void Print()
        {
            Console.WriteLine($"_3D_Objects : x : {X}, y {Y}");
        }
    }
}



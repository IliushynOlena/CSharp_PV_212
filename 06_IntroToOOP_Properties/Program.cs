using System.Collections.Specialized;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace _06_IntroToOOP_Properties
{
    /*
     Access Spetifacators
    - private(default for fiels in class)
    - public
    - protected
    - internal
    - protected internal
     */
    public class MyClass //: Object
    {
        //body of class
        protected internal int age;
        private int number;
        private string name ;
        private const float PI = 3.14f;
        private readonly int id;
        public MyClass()
        {
            this.id = 10;
        }
        public void Print()
        {
            Console.WriteLine($"Name : {name}. Id {id}");
        }
        public override string ToString()
        {
            return $"Name : {name}. Id {id}";
        }
    }
    //class MyClass1
    //{

    //}
    //class DerivedClass : MyClass //public
    //{

    //}


    struct _2DPoint
    {
        public int x;
        public int y;
        public void Print()
        {
            Console.WriteLine($"x : {x}, y {y}");
        }
    }
    partial class Point
    {
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //Auto -property -> prop + Tab Tab
        public string Name { get; set; }//private string name;
        public string Type { get; }//readolny property

        public string Color { get; private set; } = "Green";

        //full property - propfull + Tab Tab

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
      
        static int count;
        static Point()
        {
            count = 0;
        }
        public Point(int value) : this(value, value) { count++; }
        //{
        //    this.XCoord = value;
        //    this.YCoord = value;
        //}

        public Point(int x, int y)//-10 -100
        {
            SetX(x);
            SetY(y);
            count++;
        }      
       
    }
    /*
     * value type : 0;
     * references type = null;
     * Boolean type = false;     
     */
    public class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(5, 5);
            Point point = new Point(-10,2);
            point.Print();
            Console.WriteLine(point);

            point.SetX(25);
            point.SetY(-250);
            Console.WriteLine(point);

            Console.WriteLine( $"X = {point.getX()}"); ;   
            Console.WriteLine( $"Y = {point.getY()}"); ;  
            
            point.XCoord = 100;//setter
            Console.WriteLine(point.XCoord);//getter
            Console.WriteLine(point);

            point.Name = "2D Point";
            Console.WriteLine(point.Name);
            Console.WriteLine(point);


            Point point1 = new Point(9);
            Console.WriteLine(point1);

           //MyClass myClass = new MyClass();

           //MyClass @class = new MyClass();
           // @class.Print();
           // Console.WriteLine(@class.ToString());  //cout << point;


        }
    }
}
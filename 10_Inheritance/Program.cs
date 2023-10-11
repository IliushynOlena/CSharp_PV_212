using System.Text;

namespace _10_Inheritance
{
    //private
    //public
    //protected
    //protected internal
    abstract class Person// :Object  inherit from Object
    {
        protected string name;
        private readonly DateTime birthdate;
        public Person()
        {
            name = "no name";
            birthdate = new DateTime(); 
        }
        public Person(string n, DateTime b)
        {
            name = n;
            if (b > DateTime.Now)
                birthdate = new DateTime();
            else
                birthdate = b;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name : {name}\nBirthday : {birthdate.ToLongDateString()}");
        }
        public override string ToString()
        {
            return $"Name : {name}\nBirthday : {birthdate.ToLongDateString()}";
        }
        public abstract void Work();// { Console.WriteLine("I don't know who I am...and I don't know what I do!!"); }
    }
    //class Name : BaseClass, Interface1,Interface2,Interface3,
    class Worker : Person
    {
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set 
            { 
                this.salary = value>= 0 ? value : 0;    
            }
        }
        public Worker(): base()
        {
            Salary = 0;
        }
        public Worker(string n, DateTime b, decimal s): base(n, b) { Salary = s; }
  
        public override void Work()
        {
            Console.WriteLine("Doing some work.......");
        }
        //override - override base member
        //new - create a new method with thw same name
        public override void Print()
        {
            base.Print();  //Person.Print();
            Console.WriteLine($"Salary : {Salary}");
        }
    }
    sealed class Programmer : Worker
    {
        public int CodeLines { get; set; }
        public Programmer() :base()
        {
            CodeLines = 0;
        }
        public Programmer(string n, DateTime b, decimal s) : base(n, b, s) 
        {
            CodeLines = 0;
        }
        public sealed override void Work()
        {
            Console.WriteLine("Wrile lines in C#");
        }
        public override void Print()
        {
            base.Print();  //Person.Print();
            Console.WriteLine($"Code Lines : {CodeLines}");
        }
        public void WriteLines()
        {
            CodeLines++;
        }
    }
    //final - sealed
    class TeamLead : Worker
    {
        public int ProjectCount { get; set; }
        //public override void Work()
        //{
        //    Console.WriteLine("Manage team projects");
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Worker worker = new Worker("Vitia",new DateTime(2007, 5, 12),7350 );
            worker.Print();

            Person[] people = new Person[]
            {
                //new Person(),
                worker,
                new Programmer("Bill", DateTime.Now, 7800)
            };

            foreach (var item in people)
            {
                Console.WriteLine("----------------Info-----------------");
                item.Print();
                item.Work();
            }

            Programmer pr = null;
            //1 - use case (explicit)
            try
            {
                pr = (Programmer)people[1];
                pr.Print();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            //2 - use as

            pr = people[2] as Programmer;
            if (pr == null)
                Console.WriteLine("Incorrect type!!");
            else
                pr.Print();
            //3 - use is with as
            if (people[1] is Programmer)
            { pr = people[1] as Programmer; pr.Print(); }
            else
                Console.WriteLine("Incorrect type!!");


        }
    }
}
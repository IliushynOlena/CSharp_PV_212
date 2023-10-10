namespace _11_InterfacesPr
{
    public interface IWorker
    {
        public bool IsWorking { get; set; }//prop
        public string Work();//method
        public event EventHandler WorkEnded;//event
    }



    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public override string ToString()
        {
            return $"Surname : {LastName}\nName : {FirstName}\nBirthdate : " +
                $"{Birthdate.ToShortDateString()}";
        }
    }
    abstract class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\nPosition {Position}\nSalary : {Salary}\n\n";
        }
    }
    interface IWorkAble//public
    {
        bool IsWorking { get; }
        string Work();
    }
    interface IManager
    {
        List<IWorkAble> ListOfWorkers { get; set; }
        void Organize();
        void MakeBudget();
        void Control();
    }

    class Director : Employee, IManager//implement (realize)
    {
        public List<IWorkAble> ListOfWorkers { get; set; }

        public void Control()
        {
            Console.WriteLine("Controling work.....");
        }

        public void MakeBudget()
        {
            Console.WriteLine("Count money.....");
        }

        public void Organize()
        {
            Console.WriteLine("Organizing work!!!!");
        }
    }
    class Seller : Employee, IWorkAble
    {
        bool isWorking = true;
        public bool IsWorking { get { return isWorking; } }

        public string Work()
        {
            return "Selling product!!!";
        }
    }
    class Cashier : Employee, IWorkAble
    {
        bool isWorking = true;
        public bool IsWorking { get { return isWorking; } }

        public string Work()
        {
            return "Geting pay for product!!!";
        }
    }
    class StoreKeeper : Employee, IWorkAble
    {
        private bool isWorking = true;
        public bool IsWorking => isWorking;
        //public bool IsWorking { get { return isWorking; } }

        public string Work()
        {
            return "Organize product store!!!";
        }
    }
    class Administrator : Employee, IManager, IWorkAble
    {
        public List<IWorkAble> ListOfWorkers { get; set; }

        private bool isWorking = true;
        public bool IsWorking => isWorking;
        //public bool IsWorking { get { return isWorking; } }

        public string Work()
        {
            return "I working((((((";
        }

        public void Control()
        {
            Console.WriteLine("I am a main person in the store");
        }

        public void MakeBudget()
        {
            Console.WriteLine("Xaxaxaxaxaxaxa. I have many money!!!!");
        }

        public void Organize()
        {
            Console.WriteLine("You must obey me!!!!");
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {

            //Director director = new Director
            IManager director = new Director
            {
                LastName = "Tomson",
                FirstName = "Jack",
                Birthdate = new DateTime(1995, 5, 7),
                Position = "Boss",
                Salary = 100000
            };
            Console.WriteLine(director);

            IWorkAble seller = new Seller
            {
                LastName = "Petruk",
                FirstName = "Olga",
                Birthdate = new DateTime(2005, 5, 7),
                Position = "Seller",
                Salary = 7350
            };
            IWorkAble cashier = new Cashier
            {
                LastName = "Petruk",
                FirstName = "Ivan",
                Birthdate = new DateTime(2005, 5, 7),
                Position = "Seller",
                Salary = 7350
            };

            Console.WriteLine(seller.Work()); ;

            if (seller is Seller)
                Console.WriteLine($"Sellers salary : {(seller as Seller)?.Salary}");

            director.ListOfWorkers = new List<IWorkAble>
            {
                seller,
                cashier,
                new StoreKeeper
                {
                     LastName = "Ivanchuk",
                    FirstName = "Pavlina",
                    Birthdate = new DateTime(2002, 2, 17),
                    Position = "StoreKeeper",
                    Salary = 11000
                }
            };

            foreach (var item in director.ListOfWorkers)
            {
                if(item is Cashier)
                    Console.WriteLine("Cashier");

                Console.WriteLine(item);

                if(item.IsWorking)
                    Console.WriteLine(item.Work());

            }
            //Multiple Interface
            Administrator admin = new Administrator();


            IManager manager = admin;
            manager.Organize();

            IWorkAble worker = admin;
            worker.Work();



        }
    }
}
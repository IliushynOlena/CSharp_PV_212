namespace _09_Indexes
{
    public class MultArray
    {
        private int[,] array;
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public MultArray(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            array = new int[rows, cols];
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set { array[r, c] = value; }
        }
    }
    class Laptop
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $" {Model} - Price {Price}";
        }
    }
    class Shop
    {
        Laptop[] laptops;//reference - null
        public Shop(int size)
        {
            laptops = new Laptop[size];
        }
        public int Length
        {
            get { return laptops.Length; }
        }
        public Laptop GetLaptop(int index)
        {
            if (index >= 0 && index < laptops.Length)
                return laptops[index];
            throw new IndexOutOfRangeException();
        }
        public void SetLaptop(int index, Laptop laptop)
        {
            laptops[index] = laptop;
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptops.Length)
                    return laptops[index];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index <= laptops.Length)
                    laptops[index] = value;
            }
        }
        public Laptop this[string name]
        {
            get
            {
                foreach (var item in laptops)//read only
                {
                    if (item.Model == name)
                        return item;
                }
                return null;
            }
            //private set
            //{
            //    for (int i = 0; i < laptops.Length; i++)
            //    {
            //        if (laptops[i].Model == name)
            //        {
            //            laptops[i] = value;
            //            break;
            //        }
            //    }

            //}
        }
        public int FindByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price)
                    return i;   //4
            }
            return -1;
        }

        public Laptop this[double price]
        {
            get
            {
                int index = FindByPrice(price);
                if (index != -1)
                {
                    return laptops[index];
                }
                throw new Exception("Incorrect price!!!");

            }
            set
            {
                int index = FindByPrice(price);
                if (index != -1)
                {
                    laptops[index] = value;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            MultArray multArray = new MultArray(2, 3);

            for (int i = 0; i < multArray.Rows; i++)
            {
                for (int j = 0; j < multArray.Cols; j++)
                {
                    multArray[i, j] = i + j;//indexator - set
                    Console.Write($"{multArray[i, j]} ");//indexator - get
                }
                Console.WriteLine();
            }
            */

            Shop shop = new Shop(3);
            //shop.SetLaptop(0, new Laptop() { Model = "HP", Price = 45785 });
            //var laptop = shop.GetLaptop(0);
            //Console.WriteLine(laptop);
            //set
            shop[0] = new Laptop() { Model = "HP", Price = 45785.33 }; //value
            var laptop = shop[0];//get
            Console.WriteLine(laptop);
            shop[1] = new Laptop() { Model = "Asus", Price = 32000.10 };
            shop[2] = new Laptop() { Model = "MSI", Price = 64000.11 };
            Console.WriteLine("-----------------------------");
            try
            {
                for (int i = 0; i < shop.Length + 1; i++)
                {
                    Console.WriteLine(shop[i]);//get
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Continue.......");


            //shop["HP"] = new Laptop() { Model = "Mac", Price = 100000 };//set
            Console.WriteLine(shop["Mac"]);//get
            for (int i = 0; i < shop.Length; i++)
            {
                Console.WriteLine(shop[i]);//get
            }

            shop[32000.10] = new Laptop() { Model = "Dell", Price = 22123.99 };
            Console.WriteLine(shop[22123.99]);
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < shop.Length; i++)
            {
                Console.WriteLine(shop[i]);//get
            }
        }
    }
}
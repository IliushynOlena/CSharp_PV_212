using System.Text;

namespace _05_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            string str = "Hello";//5b
            Console.WriteLine(str.Length);


            StringBuilder builder = new StringBuilder();
            Console.WriteLine($" Length : {builder.Length}"  );
            Console.WriteLine($" Capacity : {builder.Capacity}"  );

            builder.Append("bla");
            Console.WriteLine($" Length : {builder.Length}");
            Console.WriteLine($" Capacity : {builder.Capacity}");
            builder.Append("bla");
            Console.WriteLine($" Length : {builder.Length}");
            Console.WriteLine($" Capacity : {builder.Capacity}");
            builder.Append("bla");
            Console.WriteLine($" Length : {builder.Length}");
            Console.WriteLine($" Capacity : {builder.Capacity}");
            builder.Append("bla");
            Console.WriteLine($" Length : {builder.Length}");
            Console.WriteLine($" Capacity : {builder.Capacity}");
            builder.Append("bla");
            Console.WriteLine($" Length : {builder.Length}");
            Console.WriteLine($" Capacity : {builder.Capacity}");
            builder.Append("bla");
            Console.WriteLine($" Length : {builder.Length}");
            Console.WriteLine($" Capacity : {builder.Capacity}");
            builder.Append("bla");
            Console.WriteLine($" Length : {builder.Length}");
            Console.WriteLine($" Capacity : {builder.Capacity}");
            builder.AppendLine("bla");
            Console.WriteLine($" Length : {builder.Length}");
            Console.WriteLine($" Capacity : {builder.Capacity}");
            builder.Append("bla");
            builder.Append("bla");
            builder.Append("bla");
            builder.Append("bla");
            Console.WriteLine($" Length : {builder.Length}");
            Console.WriteLine($" Capacity : {builder.Capacity}");
            builder.Append("bla");
            builder.Append("bla");
            builder.Append("bla");
            Console.WriteLine($" Length : {builder.Length}");
            Console.WriteLine($" Capacity : {builder.Capacity}");
            Console.WriteLine(builder);



        }
    }
}
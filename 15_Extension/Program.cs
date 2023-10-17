using System.Runtime.CompilerServices;

namespace _15_Extension
{
    static class ExampleExtansions
    {
        public static int NumbersWord(this string data)
        {
            if(string.IsNullOrEmpty(data))return 0;
            return data.Split(new char[] { ' ','.',',','!',':' }, StringSplitOptions.RemoveEmptyEntries).Length;  
        }
        public static int NumberSymbol(this string data, char s)
        {
            if (string.IsNullOrEmpty(data)) return 0;

            int c = 0;
            foreach (char item in data)
            {
                if (item == s) ++c;
            }
            return c;
        }
        public static char[] CodeString(this string data, int s)
        {
            char[]arr =  data.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    arr[i]++;
                }                
            }
            return arr;
        }

        }
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 155; i++)
            {
                Console.WriteLine((char)i);
            }
            Console.WriteLine("Enter string : ");
            string str = Console.ReadLine();
            Console.WriteLine($"Number of words aaa in the string {str.NumbersWord()}");
            Console.WriteLine($"Number of symbol 'a' in the string {str.NumberSymbol('a')}");

            string str2 = "Hello world";
            Console.WriteLine(str.CodeString(5));
        }
    }
}
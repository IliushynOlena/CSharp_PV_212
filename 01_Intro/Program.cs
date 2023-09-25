using System.Collections.Specialized;
using System.Text;

namespace _01_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //object obj = new object();
            //Console.WriteLine("Hello world");

            //Console.WriteLine("\tHello, \nWorld!");
            //Console.WriteLine("Continue!!!");

            //Console.WriteLine("Enter number : ");
            //string str = Console.ReadLine()!;
            //Console.WriteLine(str + "!!!!");
            //int number = int.Parse(str);
            //Console.WriteLine(number + 5);
            //Console.WriteLine("You number is : " + number + 5 + "!!!");
            //Console.WriteLine("You number is : " + (number + 5) + "!!!");
            //Console.WriteLine($"You number is {number + 5}   !!!! {number }");

            //int a = 0;//not null
            //Console.WriteLine(a);
            //int b = null;//error
            // Nullable<int> b = null;
            //or
            /*
            int? b = null;
            //b = 7;
            string s = null;
            string s2 = s;

            if (s != null)
                s.ToUpper();
            //or
            //? null-conditional operator
            s?.ToUpper();

            ///////////////
            s2 =  (s == null ? "Empty" : s);
            //or
            if(s == null)
            {
                s2 = "Empty";
            }
            else
            {
                s2 = s;
            }
            //or
            //?? null-conditional operator
            s2 = s ?? "Empty";

            Random rnd = new Random();
            Console.WriteLine(rnd.Next());//0...maxInt
            Console.WriteLine(rnd.Next(100));//0...100
            Console.WriteLine(rnd.Next(10,50));//10...49
            Console.WriteLine(rnd.NextDouble());//0...1
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(-10,10));//-10....9
            }
            if(3> 8)
            {
                Console.WriteLine("true");
            }
            for (int i = 0; i < 100; i++)
            {

            }
            while (true)
            {

            }
            do
            {

            } while (true);



            //string address = null;
            //string name = "Ivan";
            //Console.WriteLine(name);
            Console.OutputEncoding = Encoding.UTF8;
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine($"ToShortTimeString : {now.ToShortTimeString()}");
            Console.WriteLine($"ToShortDateString : {now.ToShortDateString()}");
            Console.WriteLine($"ToLongDateString : {now.ToLongDateString()}");
            Console.WriteLine($"ToLongTimeString : {now.ToLongTimeString()}");
            Console.WriteLine($"Custom date : {now.ToString("yyyy-MM-dd")}");

            //explicit
            int a = (int) 3.14;


            float f1 = 4.15F;
            int i1 = 44;
            //implicit
            float f2 = f1 + i1;//48.15
            //implicit
            double d1 = f2;//48.15000000000000
            //implicit
            //int i2 = f2;//48 //error
            //explicit
            int i3 = (int)f2;//48

            Console.WriteLine("Enter number : ");
            string str = Console.ReadLine()!;
            int number = int.Parse(str);
            Console.WriteLine(number);

            number = Convert.ToInt32(str);
            Console.WriteLine(number);

            try
            {
                str = Console.ReadLine()!;
                float number_float = Convert.ToSingle(str); 
                Console.WriteLine(number_float);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }*/


            /////////////////////// Invoke Methods
            //Literals();
            //FormatString();
            ConsoleMethods();
            // Console.WriteLine();    

        }


        static void FormatString()
        {
            Console.OutputEncoding = Encoding.Unicode;
            /////////////////////// Escape Sequences
            /*
                \'      – single quote, needed for character literals
                \"      – double quote, needed for string literals
                \\      – backslash
                \0      – Unicode character 0
                \a      – Alert (character 7)
                \b      – Backspace (character 8)
                \f      – Form feed (character 12)
                \n      – New line (character 10)
                \r      – Carriage return (character 13)
                \t      – Horizontal tab (character 9)
                \v      – Vertical quote (character 11)
                \uxxxx  – Unicode escape sequence for character with hex value xxxx                
            */
            Console.WriteLine("Некоторое простое сообщение\nИещё " +
                "одно простое сообщение на " +
                "новой строке");
            /*выводит в консоль следующее сообщение:
            Некоторое простое сообщение
            И ещё одно простое сообщение на новой строке*/
            Console.WriteLine("Пример табуляции: " +
             "\n1\t2\t3\n4\t5\t6");
            /*выводит в консоль следующее сообщение:
            Пример табуляции:
            1. 2 3
            4. 5 6*/
            Console.WriteLine("kghfdkjgh" +
                "sdjfisdgiusgf" +
                "sdhfiusdgfuisd" +
                "dsihfsdigiusd" +
                "shdgoisdgh  vxcxcb" +
                "fdndlkndknkdf" +
                "kdghdkfhgjkdfgh" +
                "dhgdhgkdhgkdhgk");
            Console.WriteLine(@"C:\Users\helen\Desktop\Work\C#\1");
            /////////////////////// @ - litteral formatting
            Console.WriteLine(@"Пример буква        льного
         hhjfhf
                C:\Users\helen\Desktop\Work\C#\1
             kdfjgoihiodfhoihb
            строкового литерала:
ehoiweiowegtowei
            1 \t 3
            \n 5 6");
            /*выводит в консоль следующее сообщение:
            Пример буква        льного
            
            
            строкового литерала:
            1 \t 3
            \n 5 6*/

            /////////////////////// string concat
            string name = "Bob";
            int day = 29;
            bool isValid = true;

            Console.WriteLine("Hello " + name + " Day: " + day.ToString());
            Console.WriteLine("Hello " + name + " Day: " + day); // ToString() is called automatically
            // string interpolation: $ - operator
            Console.WriteLine($"Hello, {name}\tDay: {day}\nValid: {isValid}{{}}");
            // $ + @
            Console.WriteLine($@"Hello, {name}\tDay: {day}\nValid: {isValid} {{}}");
        }
        static void Literals()
        {
           // float b = 3.33f;
            /*при помощи метода GetType() программа возвращает
            тип данных литералов, демонстрируя действие суффиксов*/
            Console.WriteLine((10).GetType());  /*выводит в консоль: System.Int32 что соответствует типу данных int*/
            Console.WriteLine((10D).GetType()); /*выводит в консоль: System.Double что соответствует типу данных double*/
            Console.WriteLine((10f).GetType()); /*выводит в консоль: System.Single что соответствует типу данных float*/
            Console.WriteLine((10m).GetType()); /*выводит в консоль: System.Decimal что соответствует типу данных decimal*/
            Console.WriteLine((10L).GetType()); /*выводит в консоль: System.Int64 что соответствует типу данных long*/
            Console.WriteLine((10UL).GetType());/*выводит в консоль: System.Uint64 что соответствует типу данных ulong*/
            Console.WriteLine(0xFF);            /*выводит в консоль: 255 шестнадцатиричное число 0xFF соответствуетa десятичному числу 255*/
        }
        static void ConsoleMethods()
        {
            //изменяет заголовок окна консоли
            Console.Title = "Пример использования инструментов класса Console";
            //изменяет цвет фона
            Console.BackgroundColor = ConsoleColor.Green;
            //изменяет цвет текста                      
            Console.ForegroundColor = ConsoleColor.Magenta;
            //получаем размер самого длинного сообщения в рамках нашей программы
            //int length = ("Input Encoding: " + Console.InputEncoding.ToString()).Length + 1;
            Console.WriteLine("Input Encoding: dsnbfdjskjghdfjkghdfkjghdfjkhkjgbksdjghskghskdghkdsjgh");
            int length = ("Input Encoding: dsnbfdjsbsdjghdfjkghdfkjghdfjkhkjgbksdjghskghskdghkdsjgh ").Length + 1;
            Console.SetWindowSize(length, 8);
            //устанавливаем размер окна консоли
            /*устанавливаем размер буфера консоли
            (размер окна должен быть
            соответствующим и должен быть
            установлен до того, как мы изменим
            размер буфера)*/
            //Console.SetBufferSize(length, 8);
            //выводим информацию о кодировке потока ввода
            Console.WriteLine("Input Encoding: " + Console.InputEncoding.ToString());
            //выводим информацию о кодировке потока вывода
            Console.WriteLine("Output Encoding: " + Console.OutputEncoding.ToString());
            //устанавливает зеначение цвета текста в значение по умолчанию
            Console.ResetColor();
            //выводим информацию о том, нажат ли NUM LOCK
            Console.WriteLine("Is NUM LOCK turned on: " + Console.NumberLock.ToString());
            //выводим информацию о том, нажат ли CAPS LOCK
            Console.WriteLine("Is CAPS LOCK turned on: " + Console.CapsLock.ToString());
            /*выводим пользователю сообщение
            о том, что программа ожидает ввода
            некоторой информации*/
            Console.Write("Enter a simpe message: ");
            //получаем от пользователя текстовое сообщение
            string message = Console.ReadLine();
            //выводим сообщение, введённое пользователем
            Console.WriteLine("Your message is: " + message);
            //звук beep
            Console.Beep(300, 3000);
            //очистка консоли
            Console.Clear();
            Console.WriteLine("Your message is: " + message);
        }
    }
}
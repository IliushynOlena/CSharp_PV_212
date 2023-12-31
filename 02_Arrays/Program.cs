﻿using System.Text;

namespace _02_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region OneArray
            /*
             *  int a = 10;
            int size = 5;
            //1
            int[] arr = new int[size];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;

            Console.Write(arr[0] + " ");
            Console.Write(arr[1] + " ");
            Console.Write(arr[2] + " ");
            Console.Write(arr[3] + " ");
            Console.Write(arr[4] + " ");
            Console.WriteLine();

            ///2
            int[] arr2 = new int[5];

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = i * 2;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            ////3
            int[] arr3 = new int[5] { 11, 12, 13, 14, 15 };
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.WriteLine();
            //4
            int[] arr4 = new int[] { 100, 101, 102, 103, 104, 105, 106, 107, 108 };
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.Write(arr4[i] + " ");
            }
            Console.WriteLine();
            //5
            //int - struct Int32 - value type - stack
            /// int[] - Array - class - Heap - references
           
            int[] arr5 = new int[7];
            for (int i = 0; i < arr5.Length; i++)
            {
                Console.Write(arr5[i] + " ");
            }
            Console.WriteLine();

            arr5[1] = 77;
            arr5.SetValue(777, 2);

            foreach (int element in arr5)
            {
                //element = 1;// read only
                Console.Write(element + " ");
            }
            Console.WriteLine();
            int[] arr6 = new int[10];
            arr6 = null;
             */
            #endregion
            #region TwoArray
            /*
            //1

            int[,] arr = new int[3, 3];

            arr[0,0] = 1;   
            arr[0,1] = 2;   
            arr[0,2] = 3;   

            arr[1,0] = 4;   
            arr[1,1] = 5;
            arr[1,2] = 6;

            arr[2,0] = 7;
            arr[2,1] = 8;
            arr[2,2] = 9;

            Console.Write(arr[0, 0] + " ");
            Console.Write(arr[0, 1] + " ");
            Console.Write(arr[0, 2] + " ");
            Console.WriteLine();
            Console.Write(arr[1, 0] + " ");
            Console.Write(arr[1, 1] + " ");
            Console.Write(arr[1, 2] + " ");
            Console.WriteLine();
            Console.Write(arr[2, 0] + " ");
            Console.Write(arr[2, 1] + " ");
            Console.Write(arr[2, 2] + " ");
            Console.WriteLine();

            //2
            int[,] arr2 = new int[3,4];
            Console.WriteLine($"Lenght : {arr2.Length}");
            for (int i = 0; i < arr2.GetLength(0); i++)//3
            {
                for (int j = 0; j < arr2.GetLength(1); j++)//4
                {
                    arr2[i, j] = i * j + 1;
                }
            }

            for (int i = 0; i <= arr2.GetUpperBound(0); i++)//2
            {
                for (int j = 0; j <= arr2.GetUpperBound(1); j++)//3
                {
                    Console.Write($"{arr2[i, j]} "); 
                }
                Console.WriteLine();
            }
          
            int[,] arr3 = {
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
            };
            Console.WriteLine(arr3.Length);
            Console.WriteLine(arr3);

            for (int i = 0; i <= arr3.GetUpperBound(0); i++)//2
            {
                for (int j = 0; j <= arr3.GetUpperBound(1); j++)//3
                {
                    Console.Write($"{arr3[i, j]} ");
                }
                Console.WriteLine();
            }

            */
            #endregion
            #region _3D_Arrays
            /*
              //1
            int[,,] array = new int[3, 3, 3];

            array[0, 0, 0] = 1;
            array[0, 0, 1] = 2;
            array[0, 0, 2] = 3;
            array[0, 1, 0] = 4;
            array[0, 1, 1] = 5;
            array[0, 1, 2] = 6;
            array[0, 2, 0] = 7;
            array[0, 2, 1] = 8;
            array[0, 2, 2] = 9;

            array[1, 0, 0] = 1;
            array[1, 0, 1] = 2;
            array[1, 0, 2] = 3;
            array[1, 1, 0] = 4;
            array[1, 1, 1] = 5;
            array[1, 1, 2] = 6;
            array[1, 2, 0] = 7;
            array[1, 2, 1] = 8;
            array[1, 2, 2] = 9;

            array[2, 0, 0] = 1;
            array[2, 0, 1] = 2;
            array[2, 0, 2] = 3;
            array[2, 1, 0] = 4;
            array[2, 1, 1] = 5;
            array[2, 1, 2] = 6;
            array[2, 2, 0] = 7;
            array[2, 2, 1] = 8;
            array[2, 2, 2] = 9;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("{0} ", array[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }


            //2
            int[,,] array2 =
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} },
                { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} }
            };


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("{0} ", array2[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
             */
            #endregion
            #region _4D_Arrays
            /*
             int[,,,] array = new int[2, 2, 2, 2];

            array[0, 0, 0, 0] = 0x0;
            array[0, 0, 0, 1] = 0x1;
            array[0, 0, 1, 0] = 0x2;
            array[0, 0, 1, 1] = 0x3;

            array[0, 1, 0, 0] = 0x4;
            array[0, 1, 0, 1] = 0x5;
            array[0, 1, 1, 0] = 0x6;
            array[0, 1, 1, 1] = 0x7;

            array[1, 0, 0, 0] = 0x8;
            array[1, 0, 0, 1] = 0x9;
            array[1, 0, 1, 0] = 0xA;
            array[1, 0, 1, 1] = 0xB;

            array[1, 1, 0, 0] = 0xC;
            array[1, 1, 0, 1] = 0xD;
            array[1, 1, 1, 0] = 0xE;
            array[1, 1, 1, 1] = 0xF;


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            Console.Write("{0:X} ", array[i, j, k, l]);
                        }
                        Console.Write('\n');
                    }
                    Console.WriteLine();
                }
                Console.Write("\n");
            }

            //2
            int[,,,] array2 =
             {
              {
                { { 0x0, 0x1 }, {0x2, 0x3 } },
                { { 0x4, 0x5 }, {0x6, 0x7 } }
              },
              {
                { { 0x8, 0x9 }, {0xA, 0xB } },
                { { 0xC, 0xD }, {0xE, 0xF } }
              }
            };


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            Console.Write("{0:X} ", array2[i, j, k, l]);
                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
            */
            #endregion
            #region ArrayMethods
            /*
            Console.OutputEncoding = Encoding.UTF8;
            int[] myArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArr("Массив myArr1", myArr1);
            int[] tempArr = (int[]) myArr1.Clone(); // shallow copy
            PrintArr("Clone", tempArr);                                // cw        
            Array.Reverse(myArr1,5,3);
            PrintArr("Массив myArr1 после реверсирования", myArr1);
            myArr1 = tempArr;
            PrintArr("Массив myArr1 после восстановления", myArr1);
            int[] myArr2 = new int[20];
            PrintArr("Массив myArr2 до копирования", myArr2);
            myArr1.CopyTo(myArr2, 10);
            PrintArr("Массив myArr2 после копирования", myArr2);
            Console.WriteLine(myArr2.Length);
            Console.WriteLine(myArr2.GetLength(0));
            Array.Clear(myArr2, 8, 3);
            PrintArr("Массив myArr2 после чистки: ", myArr2);
            Array.Resize(ref myArr2, 5);
            PrintArr("Массив myArr2 после изменения размера:", myArr2);
            myArr2 = new[] { 1, 5, 3, 2, 8, 9, 6, 10, 7, 4 };
            PrintArr("Несортированый массив myArr2: ", myArr2);
            Array.Sort(myArr2);
            PrintArr("Массив myArr2 после сортировки: ", myArr2);
            Console.WriteLine(Array.IndexOf(myArr1, 5));
            Console.WriteLine("Число 5 находится в массиве на " +
                Array.BinarySearch(myArr2, 5) + " позиции");

            Console.WriteLine("Максимальный элемент в массиве myArr2: " + myArr2.Max());
            Console.WriteLine("Минимальный элемент в массиве myArr2: " + myArr2.Min());
            Console.WriteLine("Среднее арифметическое элементов myArr2: " +
                myArr2.Average());

            Console.WriteLine("Количество измерений массива myArr3: " + myArr2.Rank);
            int[,] myArr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Количество измерений массива myArr3: " + myArr3.Rank);
            */
            #endregion
            #region Jagged_array
            /*
              // зубчастий масив
            int[][]jagged = new int[3][];
            int[]jagged1 = new int[3];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 1, 2, 3, 4, 5 };
            jagged[2] = new int[] { 1, 2, 3 };

            Console.WriteLine(jagged.Length);

            // перебор с помощью цикла for
            for (int i = 0; i < jagged.Length; ++i)//3
            {
                for (int j = 0; j < jagged[i].Length; ++j)
                {
                   // Console.Write($"{i};{j}={     jagged[i][j]     }  ");
                    Console.Write($" {jagged[i][j]}  ");
                }
                Console.Write("\n");
            }

            Console.WriteLine();
            Console.ReadKey(); 

            foreach (int[] item in jagged)
            {
                foreach (int i in item)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }
             */
            #endregion
            #region MethodsWithArray
            /*
            int[] myArray = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine();
            myArray = ModifyArray(myArray, 5);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + ", ");
            }

            Console.ReadKey();
             */
            #endregion
            #region Params
            int[] arr = new int[] { 3, 3, 3, 7, 7, 7 };
            ShowArray(10, arr);
            ShowArray("hello", 10, 15, 14, 47, 2, 3, 6, 9, 8,45,78,99,100);
            //int a = 5;
            //ShowArray(5, new int[] { 3, 3, 3, 7, 7, 7 });
            //// pause
            //Console.ReadKey();
            #endregion
        }
        static void PrintArr(string text, int[] arr)
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static int[] ModifyArray(int[] array, int modifier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * modifier;
                //array[i] *= modifier;
            }

            return array;
        }
        static void ShowArray(int num, int[] array)
        {
            Console.WriteLine(num);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        static void ShowArray(string str, int num, int num1, int num2,
            params int[] array)
        {
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
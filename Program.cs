using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void newsort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int tmp = arr[i];
                int j;
                for (j = i - 1; j >= 0 && arr[j] > tmp; j--)
                    arr[j + 1] = arr[j];
                arr[j + 1] = tmp;
            }
        }
        static void shellSort(int[] arr, ref int time)
        {
            int start = Environment.TickCount;
            int j;
            int step = arr.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (arr.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (arr[j] > arr[j + step]))
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + step];
                        arr[j + step] = tmp;
                        j -= step;
                    }
                }
                step = step / 2;
            }
            time = Environment.TickCount - start;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[m];
            Random n = new Random();
            Console.Write("Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = n.Next();
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int Time = 0;
            shellSort(array, ref Time);
            Console.Write("Отсортированный массив по Шеллу: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("\nВремя сортировки {0} mc", Time);
            Console.WriteLine("===============");
            Console.ReadLine();
            newsort(array);
            Console.Write("Отсортированный массив методом прямого включения: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }

    }
}


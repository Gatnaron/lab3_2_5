using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class lab3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№2\nВведите числа: ");
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                if (arr[i] >= 100 && arr[i] <= 999)
                {
                    count++;
                }
            }
            Console.Write("\nКоличество трёхзначных чисел равно: ");
            Console.WriteLine(count.ToString());
        }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pichugin_Test_UABContourLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ряд чисел через пробел и нажмите Enter:");
            int[] numbersArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(numbersArray);

            List<int> newNumbersList = GetNewNumbersList(numbersArray);

            if (newNumbersList.Count == 0)
            {
                Console.WriteLine("\nВ списке нет непарных чисел!");
            }
            else
            {
                Console.WriteLine("\nНовая строка без парных чисел:");

                foreach (int i in newNumbersList)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
        }

        public static List<int> GetNewNumbersList(int[] numbersArray)
        {
            List<int> newNumbersList = new List<int>();

            for (int i = 0; i < numbersArray.Length - 1; i++)
            {
                // Проверяем пары
                if (numbersArray[i] == numbersArray[i + 1])
                {
                    i++;

                    // Закидываем в List, последний элемент, если для него нет пары
                    if (i == numbersArray.Length - 2)
                    {
                        newNumbersList.Add(numbersArray[i + 1]);
                    }

                    continue;
                }
                else
                {
                    newNumbersList.Add(numbersArray[i]);

                    if (i == numbersArray.Length - 2)
                    {
                        newNumbersList.Add(numbersArray[i + 1]);
                    }
                }
            }

            return newNumbersList;
        }
    }
}
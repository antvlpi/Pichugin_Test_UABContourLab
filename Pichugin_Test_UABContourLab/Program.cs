﻿using System;
using System.Collections.Generic;

namespace Pichugin_Test_UABContourLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ряд чисел через пробел и нажмите Enter:");
            try
            {
                int[] numbersArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Array.Sort(numbersArray);

                if (numbersArray.Length == 1)
                {
                    Console.WriteLine("\nВведенная строка имеет одно число: {0}", numbersArray[0]);
                }
                else
                {
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
                }
            }
            catch
            {
                Console.WriteLine("Строка не соотвутствует требованиям ввода!");
            }

            Console.ReadKey();
        }

        public static List<int> GetNewNumbersList(int[] numbersArray)
        {
            List<int> newNumbersList = new List<int>(); // List т.к. заведомо неизвестно какой размер будет у коллекции

            for (int i = 0; i < numbersArray.Length - 1; i++)
            {
                // Проверяем на парность
                if (numbersArray[i] == numbersArray[i + 1])
                {
                    i++;

                    // Закидываем в List, последний элемент массива, если для него нет пары и предыдущие два числа были Парные
                    if (i == numbersArray.Length - 2)
                    {
                        newNumbersList.Add(numbersArray[i + 1]);
                    }

                    continue;
                }
                else
                {
                    newNumbersList.Add(numbersArray[i]);

                    // Закидываем в List, последний элемент, если для него нет пары и предыдущие два числа Не парные
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
﻿/*Дан массив размера N. Перед каждым положительным элементом массива вставить элемент с нулевым значением.*/
using System;
using System.Linq;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            var r = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(-100,100);
            }

            var newList = arr.ToList();

            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] > 0)
                {
                    newList.Insert(i, 0);
                    i++;
                }
            }

            arr = newList.ToArray();

            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}

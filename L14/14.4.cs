﻿/*Начальный вклад в банке равен 1000 руб. Через каждый месяц размер вклада увеличивается на P процентов от имеющейся 
  суммы (P — вещественное число, 0 < P < 25). По данному P определить, через сколько месяцев размер вклада превысит 1100 руб., 
  и вывести найденное количество месяцев K (целое число) и итоговый размер вклада S (вещественное число).*/
using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            double vklad = 1000;
            double P = Convert.ToDouble(Console.ReadLine());
            int k = 0;
            while (vklad<= 1100)
            {
                vklad +=vklad*(P/100);
                k++;
            }
            Console.WriteLine(k + " " + vklad);
        }
    }
}

﻿/*Дни недели пронумерованы следующим образом: 0 — воскресенье, 1 — понедельник, 2 — вторник, . . . , 6 — суббота.
  Дано целое число K, лежащее в диапазоне 1–365. Определить номер дня недели для K-го дня года, если известно,
  что в этом году 1 января было понедельником*/

#include <iostream> 
#include <locale.h>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Russian");

    int K;
    cin >> K;

    cout <<"Номер дня недели: "<< K % 7 << endl;

    system("pause");
    return 0;
}




﻿/* Напишите программу которая принимает на вход координаты точки (X и Y)
  причем X не равно 0  Y не равно 0 и выдает номер четверти плоскости в которой находится эта точка 

            y
              |
        2     |   1
              |
 _____________|____________
              |           x
              |
        3     |     4
*/              

Console.Clear();

int DataEntryXY(string str)
{
   Console.Write(str);
   int number = int.Parse(Console.ReadLine());
   
   return number;
}
void FindQandrat(int x, int y)
{
    if ((x > 0)&&(y > 0)) Console.WriteLine("это первый квадрат");
    if ((x < 0)&&(y > 0)) Console.WriteLine("это второй квадрат");
    if ((x < 0)&&(y < 0)) Console.WriteLine("это третий квадрат");
    if ((x > 0)&&(y < 0)) Console.WriteLine("это четвертый квадрат");
}






int x = DataEntryXY("Введите координаты x =");
//Console.WriteLine(x);

int y = DataEntryXY("Введите координаты y =");
//Console.WriteLine(y);
FindQandrat(x, y);


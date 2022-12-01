// Напишите программу которая по заданному номеру четверти показывает диапазог возможных координат точек 
//в этой четверти (x y)

Console.Clear();

int Poisk(string str)
{
   Console.WriteLine(str);
   int number = int.Parse(Console.ReadLine());
   return number;
}
void number(int x)
{
    if (x == 1) Console.WriteLine("x > 0, y > 0");
    if (x == 2) Console.WriteLine("x < 0, y < 0");
    if (x == 3) Console.WriteLine("x > 0, y < 0");
    if (x == 4) Console.WriteLine("x < 0, y > 0");
}
int x =  Poisk("Введите номер квадрата");

number(x);
// Напишите программу которая принимант число N и выдаеттаблицу чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

Console.Clear();





void TablePOW2(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        int pow = count*count;
        Console.Write(count*count + " ");
        count++;
    }
    Console.WriteLine();

}

TablePOW2("Введите число N: ");

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Привет! Напиши число: ");
string numberN = Console.ReadLine();
int numberNInt = int.Parse(numberN);
Console.WriteLine($"Итак, наше число равно: {numberN}, получаем интервал: от 1 до {numberN}.");
int result = numberNInt / 2;
int control = result * 2;

 int countNumber = 1+1; // первое четное, исходя из условия
 Console.Write("Четные числа из заданного интервала: ");
 while (countNumber <= numberNInt)
        {
        Console.Write($"{countNumber} ");
        countNumber = countNumber +2;
        };
Console.Write(".");
// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру
// этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
string num = Console.ReadLine();
int numInt  = int.Parse(num);
//Console.WriteLine(num);
int numdiv1 = numInt/10;
//Console.WriteLine(numdiv1);
int numdiv2 = numdiv1%10;
Console.WriteLine($"Вторая цифра числа: {numdiv2}");

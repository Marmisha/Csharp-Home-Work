//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Привет! Вводи первое число:");
string numberA = Console.ReadLine();
int numberAInt = int.Parse(numberA);
Console.WriteLine($"Наше первое число: {numberA}");

Console.WriteLine("Теперь давай узнаем второе число:");
string numberB = Console.ReadLine();
int numberBInt = int.Parse(numberB);
Console.WriteLine($"Итак, второе число: {numberB}");
if (numberAInt > numberBInt)
{
    Console.WriteLine("Смотри-ка, первое число больше второго!");
}
else
{
    Console.WriteLine("Второе число больше!");
}

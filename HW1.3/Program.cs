// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();   

Console.WriteLine("Напишите число");
string number = Console.ReadLine();
Console.WriteLine($"Наше число: {number}");
int numberInt = int.Parse(number);

int result = numberInt / 2;
Console.WriteLine($"Результат деления без остатка равен {result}.");
Console.Write("Проверим, что получается при умножении полученного целого числа на 2? ");
int control = result * 2;
Console.WriteLine("Получается: "+ control);
Console.WriteLine($"Полученное в результате деления нацело {control} равно начальному {numberInt}?");
if (control==numberInt)
{
Console.WriteLine("Равно, значит, число нацело разделилось на 2, оно чётное.");
}
else 
{
Console.WriteLine("Нет. Значит, число поделилось на 2 с остатком, => оно нечётное.");
}
Console.WriteLine("Программа - умничка!");

// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Привет! Давай придумаем три числа.");
Console.Write("Первое: ");
string numberA = Console.ReadLine();
int numberAInt = int.Parse(numberA);
Console.WriteLine("=> Первое число: " + numberA);

Console.Write("Еще одно: ");
string numberB = Console.ReadLine();
int numberBInt = int.Parse(numberB);
Console.WriteLine("=> Второе число: " + numberB);

Console.Write("И еще одно: ");
string numberC = Console.ReadLine();
int numberCInt = int.Parse(numberC);
Console.WriteLine("=> Третье число: " + numberC);

int max = 0;

if (numberAInt > max)
{
max = numberAInt;
}
else
{}
if (numberBInt > max)
{
max = numberBInt;
}
else
{}

if (numberCInt > max)
{
    max = numberCInt;
}
else
{}

Console.WriteLine("Самое большое число " + max);

// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите число от 1 до 7");
string num = Console.ReadLine();
int numInt = int.Parse(num);
Console.WriteLine("Наше число " + numInt + ".");
if (numInt > 7 || numInt < 1)
{
    Console.WriteLine("Неправильное число, придумайте другое");
}
else 

    if (numInt == 6 || numInt == 7)
    {
    Console.WriteLine("Ура, это выходной!");
    }
    else
    {
    Console.WriteLine("Улыбаемся и пашем");
    }

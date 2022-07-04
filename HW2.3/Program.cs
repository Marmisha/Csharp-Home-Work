// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введите число: ");
string num = Console.ReadLine();
int numInt = int.Parse(num);
Console.WriteLine("Наше число: " + numInt);

if (numInt<100 && numInt>-100)
{
    Console.WriteLine("Неверно, число имеет меньше 3 разрядов, третьей цифры нет, придумайте другое");
    
}
else
{
    while(numInt>999 || numInt<-999) 
    {
    numInt = numInt/10;
    }
    Console.WriteLine($"Сокращенное до трех разрядов число: {numInt}");
    int thirdNum = numInt%10;
    Console.WriteLine($"Третья цифра числа: {thirdNum}");
}

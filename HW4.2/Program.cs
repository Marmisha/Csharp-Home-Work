//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//Console.Write("Привет, напиши какое-нибудь число, лучше длинное: ");

Console.Write("Введите число: ");
string number = Console.ReadLine();
Console.WriteLine($"Вы ввели {number}.");

int length = number.Length;
Console.WriteLine($"Количество знаков в числе: {length}.");

int numberInt = int.Parse(number);
int index = 0;
int summary = 0; // пока 0
int temporaryNum=0;
for (index=0; index<length; index ++)
{
  
temporaryNum  = numberInt%10;
numberInt=numberInt/10;
summary = summary+ temporaryNum;
}

Console.WriteLine($"Сумма цифр числа {number} равна {summary}.");




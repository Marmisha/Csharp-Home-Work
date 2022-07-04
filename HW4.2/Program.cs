//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//Console.Write("Привет, напиши какое-нибудь число, лучше длинное: ");

int MethodIntReadLine(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
} // Наша функция предлагает ввести число, съедает его в виде текста и превращает в integer


int number = MethodIntReadLine("Введите число: ");
Console.WriteLine($"Вы ввели {number}.");

int[,]matrix = new int [1,number];
Console.Write(matrix);

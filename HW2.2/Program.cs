// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//Console.WriteLine("Hello, World!");
Console.Clear();
int number = new Random().Next(100,1000);
Console.WriteLine($"Рандомное число {number}");
int num1=number/100;
int num2=number%100/10;
int num3=number%10;
/*
Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);
*/
Console.WriteLine($"Наше число: {num1}{num3}");

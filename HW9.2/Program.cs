//HW9.2
// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30




Console.Clear();



int GetIntFromReadLine(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}




//Метод, выводящий на экран сумму всех натуральных чисел от number1 до number2:
int PrintSumOfAllNaturalNumberBetweenPoints(int number1, int number2)
{
    if (number1 > number2) return 0;
    return PrintSumOfAllNaturalNumberBetweenPoints(number1, number2 - 1) + number2;
}

int M = GetIntFromReadLine("Введите число M: ");
int N = GetIntFromReadLine("Введите число N: ");
int sum = PrintSumOfAllNaturalNumberBetweenPoints(M, N);
System.Console.WriteLine(sum);


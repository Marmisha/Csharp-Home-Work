// HW9.1
// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Clear();


int GetIntFromReadLine(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}




//Метод, выводящий на экран все натуральные четные числа от number1 до number2:
void PrintAllNaturalNumberBetweenPoints(int number1, int number2)
{
    if (number1 > number2) { return; }
    if (number2 % 2 == 1)
    { number2--; }
    PrintAllNaturalNumberBetweenPoints(number1, number2 - 2);
    if (number2 % 2 == 0) { System.Console.Write($"{number2}  "); }

}

int N = GetIntFromReadLine("Введите число N: ");
int M = GetIntFromReadLine("Введите число M: ");
System.Console.WriteLine($"Будем выписывать натуральные числа от {N} до {M}: ");
PrintAllNaturalNumberBetweenPoints(N, M);


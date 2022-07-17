// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double GetNumFromReadLine(string msg)
{
    Console.Write(msg);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double b1 = GetNumFromReadLine("Введите значение для b1: ");
double k1 = GetNumFromReadLine("Введите значение для k1: ");
double b2 = GetNumFromReadLine("Введите значение для b2: ");
double k2 = GetNumFromReadLine("Введите значение для k2: ");
double x = GetNumFromReadLine("Введите значение для x: ");
double coordinate1 = k1 * x + b1;
double coordinate2 = k2 * x + b2;

System.Console.WriteLine($"Пересечение линий будет в координате: {coordinate1}, {coordinate2}");
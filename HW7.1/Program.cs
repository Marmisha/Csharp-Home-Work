//Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами (вариант 2)

Console.Clear();


int GetIntFromReadLine(string message) 
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()); 
}



double[,] CreateAndFillMatrixAlternative(int row, int column, int min, int max)
{
    double[,] matrix = new double[row, column];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max) + new Random().NextDouble();
        }
    }
    return matrix;
}



void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}



int numberMRow = GetIntFromReadLine("Введите число m: ");
int numberNColumn = GetIntFromReadLine("Введите число n: ");
int min = GetIntFromReadLine("Введите минимальное значение для m и n: ");
int max = GetIntFromReadLine("И максимальное: ");
System.Console.WriteLine($"Теперь для метода создания таблицы количество строк (row) будет m = {numberMRow}, количество столбцов (column) n = {numberNColumn}; допустимые же числа для заполнения: от {min} до {max}.");
double[,] myMatrix = CreateAndFillMatrixAlternative(numberMRow, numberNColumn, min, max);
PrintMatrix(myMatrix);
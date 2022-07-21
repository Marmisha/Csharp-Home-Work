//Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();


int GetIntFromReadLine(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}



int[,] CreateMatrix(int row, int column, int min, int max)
{
    var matrix = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}



void PrintMatrix(int[,] matrx)
{
    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        for (int j = 0; j < matrx.GetLength(1); j++)
        {
            Console.Write($"{matrx[i, j] + "\t"}");
        }
        Console.WriteLine();
    }
}



double GetSumOfColumns2(int[,] matr)
{
    double sumByColumn = 0;
    double arithmeticMeanOfColumn = 0;
    for (int column = 0; column < matr.GetLength(1); column++)
    {
        for (int row = 0; row < matr.GetLength(0); row++)
        {
            sumByColumn = sumByColumn + matr[row, column];
            arithmeticMeanOfColumn = sumByColumn / matr.GetLength(0);

        }
        System.Console.Write($"Сумма чисел {column + 1} столбца равна {sumByColumn}.");
        System.Console.Write($" Среднее арифметическое чисел столбца равно {arithmeticMeanOfColumn}");
        System.Console.WriteLine();
        sumByColumn = 0;
    }
    return sumByColumn;
}



int row = GetIntFromReadLine("Введите число строк массива: ");
int column = GetIntFromReadLine("Введите число столбцов массива: ");
int min = GetIntFromReadLine("Введите минимальное значение для чисел массива: ");
int max = GetIntFromReadLine("Введите максимальное значение для чисел массива: ");
int[,] myMatrix = CreateMatrix(row, column, min, max);
PrintMatrix(myMatrix);
System.Console.WriteLine();
double result = GetSumOfColumns2(myMatrix);
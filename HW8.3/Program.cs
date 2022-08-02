//ДЗ 8 Задача 3
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j] + "\t"}");
        }
        Console.WriteLine();
    }
}



// Метод умножения двух двухмерных матриц одинаковой размерности:
int[,] MultiplyMatrix(int[,] matr1, int[,] matr2, int row, int column)
{
    int[,] resultMatrix = new int[row, column];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
            resultMatrix[i, j] = matr1[i, j] * matr2[i, j];
    }
    return resultMatrix;
}



int rows = GetIntFromReadLine("Введите число строк для матриц: ");
int columns = GetIntFromReadLine("Введите число столбцов матриц: ");

int minForBothMatrix = 0; // = GetIntFromReadLine("Введите минимальное число для заполнения матрицы: ");
int maxForBothMatrix = 10; // = GetIntFromReadLine("Введите максимальное число для заполнения матрицы: ");

int[,] myMatrixFirst = CreateMatrix(rows, columns, minForBothMatrix, maxForBothMatrix);
int[,] myMatrixFSecond = CreateMatrix(rows, columns, minForBothMatrix, maxForBothMatrix);

System.Console.WriteLine("Матрица 1:");
PrintMatrix(myMatrixFirst);
System.Console.WriteLine();
System.Console.WriteLine("Матрица 2:");
PrintMatrix(myMatrixFSecond);
System.Console.WriteLine();
System.Console.WriteLine("Результат перемножения матриц:");
int[,] multipliedMatrix = MultiplyMatrix(myMatrixFirst, myMatrixFSecond, rows, columns);
PrintMatrix(multipliedMatrix);

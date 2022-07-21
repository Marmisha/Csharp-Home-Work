//Задача 2: Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. 
// void FindingElementFromPosition
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



void FindingElementFromPosition(int[,] array, int rowIndex, int columnIndex)
{
    if (rowIndex < array.GetLength(0) && columnIndex < array.GetLength(1))
    {
        System.Console.WriteLine($"Число, находящееся в матрице по заданным индексам: {array[rowIndex, columnIndex]}.");
        Environment.Exit(0);
    }
    else if (rowIndex > array.GetLength(0) || columnIndex > array.GetLength(1))
    {
        System.Console.WriteLine("Такой позиции нет в массиве");
        Environment.Exit(0);
    }
}



int row = GetIntFromReadLine("Введите число строк матрицы: ");
int column = GetIntFromReadLine("Введите число столбцов матрицы: ");
int min = 0; // = GetIntFromReadLine("Введите минимальное число для заполнения матрицы: ");
int max = 10; // = GetIntFromReadLine("Введите максимальное число для заполнения матрицы: ");
int myRowIndex = GetIntFromReadLine("Введите индекс строки искомого числа: ");
int myColumnIndex = GetIntFromReadLine("Введите индекс столбца искомого числа: ");
int[,] myMatrix = CreateMatrix(row, column, min, max);
PrintMatrix(myMatrix);
FindingElementFromPosition(myMatrix, myRowIndex, myColumnIndex);
System.Console.WriteLine(FindingElementFromPosition);
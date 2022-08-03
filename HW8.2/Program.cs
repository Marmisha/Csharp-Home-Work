//ДЗ 8 Задача 2 
// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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



// Метод подчета суммы всех чисел строки:
int[] GetSumOfRowElements(int[,] matr)
{
    int[] sumResults = new int[matr.GetLength(0)];
    int sumOfRowElements = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumOfRowElements += matr[i, j];
        }
        sumResults[i] = sumOfRowElements;
        sumOfRowElements = 0;
    }
    return sumResults;
}



// Вывод их на экран:
int[] PrintArray(int[] arr)
{
    System.Console.Write("Суммы строк: ( ");
    for (int i = 0; i < arr.Length; i++)
    {
        //System.Console.Write($"Сумма {i + 1}-й строки равна {arr[i]}. ");
        System.Console.Write($"{arr[i]} ");

    }
    System.Console.Write(")");
    return arr;
}



int FindRowOfMinimalSumOfElements(int[] arr)
{
    int minSumRowIndex = 0;
    int minSum = 99999;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minSum)
        {
            minSum = arr[i];
            minSumRowIndex = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма {minSum} в {minSumRowIndex + 1}-й строке.");
    return minSumRowIndex;
}


int rows = GetIntFromReadLine("Введите число строк для матриц: ");
int columns = GetIntFromReadLine("Введите число столбцов матриц: ");
int min = 0; 
int max = 10; 

int[,] myMatrix = CreateMatrix(rows, columns, min, max);
System.Console.WriteLine("Матрица:");
PrintMatrix(myMatrix);
System.Console.WriteLine();

int[] sumOfRowElements = GetSumOfRowElements(myMatrix);
PrintArray(sumOfRowElements);
System.Console.WriteLine();
int minSumOfRowElementsRow = FindRowOfMinimalSumOfElements(sumOfRowElements);
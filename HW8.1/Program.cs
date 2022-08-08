// ДЗ 8_Задача 1: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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



// Метод расстановки элеентов каждой строки двухмерного массива в убывающем порядке:
int[,] PutRowElementsInDescendingOrder(int[,] matr, int max)
{
    int minElementOfTheRow = max; // пока минимальное значение строки равно максимально возсожному значению в массиве
    for (int columns = matr.GetLength(1) - 1; columns >= 0; columns--)
    {
        //пока не дойдет до конца строки делаем следующее: проверяем минимальное
        int temp = 0;
        for (int rows = 0; rows < matr.GetLength(0) - 1; rows++)
            if (matr[rows, columns] < minElementOfTheRow)
            {
                temp = matr[rows, columns];
                matr[rows, columns] = minElementOfTheRow;
                minElementOfTheRow = temp;
                System.Console.WriteLine(matr);
            }
    }
    return matr;

}




int row = 5;//GetIntFromReadLine("Введите число строк матрицы: ");
int column = 3;//GetIntFromReadLine("Введите число столбцов матрицы: ");
int min = 0; // = GetIntFromReadLine("Введите минимальное число для заполнения матрицы: ");
int max = 9; // = GetIntFromReadLine("Введите максимальное число для заполнения матрицы: ");

int[,] myMatrix = CreateMatrix(row, column, min, max);
System.Console.WriteLine("Исходная матрица:");
PrintMatrix(myMatrix);
System.Console.WriteLine();
System.Console.WriteLine("Матрица с числами, расставленными в строке по убыванию: ");
int[,] newMatrix = PutRowElementsInDescendingOrder(myMatrix, max);
PrintMatrix(newMatrix);
// PrintMatrix(SortingElementsInRowDescending(myMatrix));






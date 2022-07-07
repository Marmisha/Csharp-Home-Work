//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях (нечетных индексах).

Console.Clear();

int[] CreateAndFillArray(int large, int min, int max)
{
    int[] array = new int[large];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}



void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}   ");
    }
    System.Console.WriteLine();
}




int FindOddIndexNumSum(int[] arr) // Метод сложения чисел в массиве, стоящих на нечетных позициях (индексах)
{

    int sum = 0;
    int RemainderOfDiv = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        RemainderOfDiv = i % 2;
        if (RemainderOfDiv == 1) //  делаем вывод о нечетности индекса
        {
            sum = sum + arr[i];//для нечетного индекса увеличиваем сумму элементов
        }
    }
    System.Console.WriteLine($"Сумма элементов, имеющих нечетный индекс: {sum}");
    return sum;
}


// Это мой первоначальный метод:
// int FindOddPositionNumSum(int[] arr) // Метод сложения чисел в массиве, стоящих на нечетных позициях (индексах)
// {
//     int sum = 0;
//     int RemainderOfDiv = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         RemainderOfDiv = (i + 1) % 2;
//         if (RemainderOfDiv == 1) //  делаем вывод о нечетности индекса
//         {
//             sum = sum + arr[i];//для нечетного индекса увеличиваем сумму элементов
//         }
//     }
//     System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
//     return sum;
//}




// Вариант после обратной связи:
int FindOddPositionNumSum(int[] arr) // Метод сложения чисел в массиве, стоящих на нечетных позициях (индексах)
{

    int sum = 0;
    //int RemainderOfDiv = 0;
    for (int i = 0; i < arr.Length; i=i+2)
    {
            sum = sum + arr[i];//для нечетного индекса увеличиваем сумму элементов
    }
    System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
    return sum;
}





int[] myArray = CreateAndFillArray(5, 1, 9);
printArray(myArray);
FindOddIndexNumSum(myArray);
FindOddPositionNumSum(myArray);

System.Console.WriteLine("Не очень понятно задание, поэтому пусть будут оба варианта исчисления=)");
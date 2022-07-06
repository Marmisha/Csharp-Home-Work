//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

// Метод создания массива с определенной длиной и заполнением рандомными числами из отрезка от в промежутке от a (min) до b (max):
int[] CreateAndFillArray(int large, int min, int max)
{
    int[] array = new int[large];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}




// Метод вывода на экран массива:
void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}   ");
    }
    System.Console.WriteLine();
}



int[] myArray = CreateAndFillArray(5, 100, 999);
printArray(myArray);
FindEvenNum (myArray);


int FindEvenNum(int[] arr) // Метод поиска четных чисел в массиве
{
   
int count = 0; // счет четных
    int RemainderOfDiv = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        RemainderOfDiv = myArray[i] % 2; // узнаем, есть ли остаток от деления
        //System.Console.WriteLine(RemainderOfDiv); // остаток вот такой
        if (RemainderOfDiv == 0) //  делаем вывод о четности числа с индексом i
        {
            count++;//для четного увеличиваем кол-во
        }
    }
    System.Console.WriteLine($"Число четных чисел в массиве: {count}");
    return count;
}


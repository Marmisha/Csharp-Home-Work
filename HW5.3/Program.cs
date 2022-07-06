//Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//Вещественные числа - числа, у которых есть дробная часть (в т ч нулевая) => double?


Console.Clear();

double[] CreateAndFillArray(int large, int min, int max)
{
    double[] array = new double[large];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}



void printArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}   ");
    }
    System.Console.WriteLine();
}



double FindMax(double[] arr)
{
    double maxNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNum)
        {
            maxNum = arr[i];
        }
    }
    Console.WriteLine($"Максимальное число в массиве: {maxNum}");
    return maxNum;
}



double FindMin(double[] arr)
{
    double minNum = 20; // Не понимаю, к чеиу привязать начальное минимальное число, чтобы было, куда уменьшаться. 
                        //Поэтому магическое число: 20, равное максимально возможному числу в массиве. Буду благодарна за подсказку
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNum)
        {
            minNum = arr[i];
        }
    }
    Console.WriteLine($"Минимальное число в массиве: {minNum}");
    return minNum;
}




double[] myArray = CreateAndFillArray(10, 1, 20);
printArray(myArray);
double maxNumber = FindMax(myArray);
double minNumber = FindMin(myArray);
double diffBetWeenMaxAndMin = maxNumber - minNumber;
System.Console.WriteLine($"Разница между наибольшим и наименьшим числом равна {diffBetWeenMaxAndMin}.");




//ТАКЖЕ БУДУ БЛАГОДАРНА ЗА ПОДСКАЗКУ, ЧТО НЕ ТАК В СОВМЕСТНОМ МЕТОДЕ ДЛЯ ПОИСКА ОДНОВРЕМЕННО МИН И МАКС НИЖЕ:
/*
double FindMaxAndFindMin(double[] arr)
{
    double maxNum = 0;
    double minNum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNum)
        {
            maxNum = arr[i];
        }
    
    // Console.WriteLine(maxNum);
    return maxNum;

    {
        if (arr[i] < minNum)
        {
            minNum = arr[i];
        }
    }
    Console.WriteLine(minNum);
    return minNum;
}
return maxNum;
return minNum;
System.Console.WriteLine($"{maxNum} + {minNum}");
}

FindMaxAndFindMin(myArray);
*/
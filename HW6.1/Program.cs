//HW6.1 Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int GetNumFromReadLine(string msg) // получение интеджера из введенного ползователем текса
{
    Console.Write(msg);
    int totalQuantityOfNumbers = int.Parse(Console.ReadLine());
    return totalQuantityOfNumbers;
}



int[] InputNumbers(int M) // Получение заданного количества чисел от пользователя
{
    int[] numbers = new int[M];
    for (int i = 0; i < M; i++)
    {
        numbers[i] = GetNumFromReadLine($"Введите {i + 1}-е число из {M}: ");
    }
    return numbers;
}




int CountOfPositiveElements(int[] array)
{
    int counter = 0;
    foreach (int el in array)
    {
        if (el > 0) 
        counter++;
    }
    return counter;
}

int M = GetNumFromReadLine("Сколько чисел будем вводить? => ");
int[] myNumbers = InputNumbers(M);
System.Console.WriteLine($"Число положительных элементов = {CountOfPositiveElements(myNumbers)}");
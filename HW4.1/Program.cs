//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Создаем метод, макрос:
int MethodIntReadLine(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

// Включаем работу метода (дважды):
int numA = MethodIntReadLine("Введите два числа. Первое: ");
int numB = MethodIntReadLine("Второе: ");
Console.Write("Ваши числа: " + numA + " и " + numB + ".");

//Возводим в степень:
int i = 0;//счетчик
int degree = 1;//степень, пока она равна 1
for (i = 1; i <= numB; i++) //пока значение степени меньше значения второго числа, продолжаем умножать первое число на себя 
{
    degree = degree * numA;//поскольку нам надо хранить где-то значение, мы считаем в ddegree.

}
Console.WriteLine();
Console.WriteLine($"Итак, {numA} в степени {numB} равно {degree}.");
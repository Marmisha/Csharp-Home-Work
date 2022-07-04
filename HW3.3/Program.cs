//Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27.
//5 -> 1, 8, 27, 64, 125

//3 было на семинаре или на лекции
 
 Console.Clear();

int Prompt(string message)
{
    Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);// Иными словами: что мы введем, вернется как int.
}
int N = Prompt("Введите число N: ");
Console.WriteLine($"Вы ввели число {N}. Наши кубы:");

int i = 0; 

while (i < N)
{
    i++;
     Console.WriteLine(i * i * i);
}

//Задача 2: Напишите программу, которая принимает на вход координаты трех точек и находит расстояние между ними в 3D пространстве.
/*
2 аналогичное делали на семинаре
*/


int Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x1 = Prompt("Введите координату x1 первой точки: ");
int y1 = Prompt("Введите координату y1 первой точки: ");
int z1 = Prompt("Введите координату z1 первой точки: ");
//Console.WriteLine($"Координаты первой точки: ({x1},{y1},{z1}).");

int x2 = Prompt("Введите координату x2 второй точки: ");
int y2 = Prompt("Введите координату y2 второй точки: ");
int z2 = Prompt("Введите координату z2 второй точки: ");
//Console.WriteLine($"Координаты второй точки: ({x2},{y2},{z2}).");

Console.WriteLine($"Координаты точек: ({x1},{y1},{z1}) и ({x2},{y2},{z2}).");

int d1=x1-x2;
int d2=y1-y2;
int d3=z1-z2;

double e = Math.Sqrt(d1*d1 +d2*d2 + d3*d3); 
Console.WriteLine($"Расстояние между точками равно {e}");

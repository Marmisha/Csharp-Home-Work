// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Можно через массив, можно иначе. Придумать (отдельным документом), как сделать с числом любой разрядности.

    Console.WriteLine("Введите пятизначное число: ");
    string numString = Console.ReadLine();
    int num = int.Parse(numString);
    Console.WriteLine($"Вы ввели {num}.");
       if (num /100000 ==0) {
        //Console.WriteLine($"Вы ввели пятизначное число {num}.");
        
        int num0=num/10000;
       // Console.WriteLine(num0);
   
        int num1=num%10000/1000;
       // Console.WriteLine(num1);
    
         int num2=num%1000/100;
     // Console.WriteLine(num2);
    
     int num3=num%100/10;
       //  Console.WriteLine(num3);
   int num4=num%10/1;
   // Console.WriteLine(num4);
        
    if (num0 == num4) {
    //Console.WriteLine("Равны, продолжаем");
    }
    else {
    //Console.WriteLine("Не полиндром!");
    }
    if ((num1 == num3)) Console.WriteLine("Полиндром!");
    else {
    Console.WriteLine("Не полиндром!");
    }
        }
        else {
        Console.WriteLine("Придумайте другое число (пятизначное).");  
        }

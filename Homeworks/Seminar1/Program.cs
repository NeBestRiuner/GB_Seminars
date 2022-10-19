// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32( Console.ReadLine());
if(a>b)
{
    Console.WriteLine($"{a} больше {b}");
}
else
{
    if(a==b)
    {
        Console.WriteLine($"{a} равно {b}");
    }
    else
    {
         Console.WriteLine($"{a} меньше {b}");
    }
}
*/
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32( Console.ReadLine());
int max = a;
if(max<b)
{
    max = b;
}
if(max<c)
{
    max = c;
}
Console.WriteLine($"max = {max}");
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if(a%2!=0){Console.WriteLine("Число нечётное");}
else{Console.WriteLine("Число чётное");}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
if(N>2){
    while(i<=N)
    {
         Console.WriteLine($"{i}");
        i+=2;
    }
}
else{Console.WriteLine("Таких чисел нет.");}
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumber(int N)
{
    if(N>=1)
    {
        Console.Write($" {N} ");
        ShowNumber(N-1);
    }
}
Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumber(N);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int FunkSum(int N, int M)
{   int Sum=M;
    if(N>=M)
    {
        return  Sum += FunkSum(N,M+1);
    } else 
    {
        return 0;
    }
}
Console.WriteLine("Введите значение M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
int Res = FunkSum(N,M);
Console.WriteLine($"Сумма натуральных элементов от {M} до {N} равна: {Res}");
*/
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
int Accerman(int M, int N)
{   int Acc = N+1;
    if((M>0) & (N>0))
    {
        return  Accerman(M-1,Accerman(M,N-1));
    }
    if((M>0) & (N==0))
    {
        return  Accerman(M-1,1);
    }
    else {return Acc;}
}
Console.WriteLine("Введите значение M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
int Res = Accerman(M,N);
Console.WriteLine($"Функция Аккермана ({M},{N}) равна: {Res}");
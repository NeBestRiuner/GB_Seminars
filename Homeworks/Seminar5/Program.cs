// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateArr(int ArrLen)
{
    int[] Arr = new int[ArrLen];
    int i = 0;
    while(i<ArrLen)
    {
        Arr[i]= new Random().Next(100,1000);
        i++;
    }
    return Arr;
}
void ShowArr(int[] Arr, int ArrLen)
{
    Console.Write($"[ {Arr[0]} ,");
    int i = 1;
    while(i<ArrLen-1)
    {
        Console.Write($" {Arr[i]} ,");
        i++;
    }
    Console.WriteLine($" {Arr[i]} ]");
}
void ShowEvenCount(int [] Arr, int ArrLen)
{
    int i = 0;
    int Count = 0;
    while(i<ArrLen)
    {
        if(Arr[i]%2==0)
        {
            Count +=1;
        }
        i++;
    }
    Console.WriteLine($"Количество чётных элементов в массиве: {Count}");
}
Console.WriteLine("Введите размер массива:");
int Len = Convert.ToInt32(Console.ReadLine());
int [] Arr = CreateArr(Len);
ShowArr(Arr,Len);
ShowEvenCount(Arr,Len);
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreateArr(int ArrLen)
{
    int[] Arr = new int[ArrLen];
    int i = 0;
    while(i<ArrLen)
    {
        Arr[i]= new Random().Next(0,10000);
        i++;
    }
    return Arr;
}
void ShowArr(int[] Arr, int ArrLen)
{
    Console.Write($"[ {Arr[0]} ,");
    int i = 1;
    while(i<ArrLen-1)
    {
        Console.Write($" {Arr[i]} ,");
        i++;
    }
    Console.WriteLine($" {Arr[i]} ]");
}
int SumOdd(int[] Arr, int ArrLen)
{   
    int Sum = 0;
    for(int i =0; i<ArrLen; i++)
    {
        if((i%2)!=0)
        {
            Sum+=Arr[i];
        }
    }
    return Sum;
}
Console.WriteLine("Введите размер массива:");
int Len = Convert.ToInt32(Console.ReadLine());
int[] Arr = CreateArr(Len);
int Result = SumOdd(Arr,Len);
ShowArr(Arr, Len);
Console.WriteLine($"Сумма нечётных элементов: {Result}");
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double [] CreateArr(int ArrLen,int MinNum, int MaxNum )
{
    double[] Arr = new double[ArrLen];
    int i = 0;
    while(i<ArrLen)
    {
        Arr[i]= new Random().NextDouble()+ new Random().Next(MinNum,MaxNum+1);
        i++;
    }
    return Arr;
}
void ShowArr(double[] Arr, int ArrLen)
{
    Console.Write($"[ {Arr[0]} ,");
    int i = 1;
    while(i<ArrLen-1)
    {
        Console.Write($" {Arr[i]} ,");
        i++;
    }
    Console.WriteLine($" {Arr[i]} ]");
}
double MinMaxDiff(double[] Arr, int ArrLen)
{
    int i =0;
    double Max = Arr[i];
    double Min = Arr[i];
    for( i =1;i<ArrLen;i++)
    {
        if(Max<Arr[i]) Max = Arr[i];
        if(Min>Arr[i]) Min = Arr[i];
    }
    return Max - Min;
    
}
Console.WriteLine("Введите размер массива:");
int Len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве:");
int MaxNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число в массиве:");
int MinNum = Convert.ToInt32(Console.ReadLine());
double[] Arr = CreateArr(Len, MinNum,MaxNum);
ShowArr(Arr, Len);
double Result = MinMaxDiff(Arr, Len);
Console.WriteLine($"Разница между максимальным эллементом и минимальным: {Result}");
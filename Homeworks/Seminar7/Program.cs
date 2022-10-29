//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] Create2DArray(int m, int n)
{
    double [,] Array2D = new double[m,n];
    for(int i = 0; i<m ;i++)
    {
        for(int j = 0; j<n; j++)
        {
            Array2D[i,j] = new Random().Next(0,100)+ new Random().NextDouble();
        }
    }
    return Array2D;

}
void Show2DArray(double [,] Array2D)
{
    for(int i = 0; i<Array2D.GetLength(0);i++)
    {
        for(int j = 0; j<Array2D.GetLength(1); j++)
        {
            Console.Write($" {Array2D[i,j]} ");
        }
        Console.Write("\n");
    }
}
Console.WriteLine("Введите количество столбцов в двумерном массиве:");
int Column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в двумерном массиве:");
int Row = Convert.ToInt32(Console.ReadLine());
double[,] Arr2d = Create2DArray(Row,Column);
Show2DArray(Arr2d);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] Create2DArray(int m, int n)
{
    int [,] Array2D = new int[m,n];
    for(int i = 0; i<m ;i++)
    {
        for(int j = 0; j<n; j++)
        {
            Array2D[i,j] = new Random().Next(0,100);
        }
    }
    return Array2D;

}
void Show2DArray(int [,] Array2D)
{
    for(int i = 0; i<Array2D.GetLength(0);i++)
    {
        for(int j = 0; j<Array2D.GetLength(1); j++)
        {
            Console.Write($" {Array2D[i,j]} ");
        }
        Console.Write("\n");
    }
}
void NumberContain(int[,] Array2D,int NColumn,int NRow)
{
    if(Array2D.GetLength(0)>NRow-1 && Array2D.GetLength(1)>NColumn-1)
    {
        Console.WriteLine($"Элемента по этим индексам: {Array2D[NRow-1,NColumn-1]}");
    }
    else Console.WriteLine("Элемента по таким индексам не существует!!!!");
}
Console.WriteLine("Введите количество столбцов в двумерном массиве:");
int Column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в двумерном массиве:");
int Row = Convert.ToInt32(Console.ReadLine());
int[,] Arr2d = Create2DArray(Row,Column);
Show2DArray(Arr2d);
Console.WriteLine("Введите столбец нужного элемента:");
int NColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите строку нужного элемента:");
int NRow = Convert.ToInt32(Console.ReadLine());
NumberContain(Arr2d,NColumn, NRow);
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] Create2DArray(int m, int n)
{
    int [,] Array2D = new int[m,n];
    for(int i = 0; i<m ;i++)
    {
        for(int j = 0; j<n; j++)
        {
            Array2D[i,j] = new Random().Next(0,100);
        }
    }
    return Array2D;

}
void Show2DArray(int [,] Array2D)
{
    for(int i = 0; i<Array2D.GetLength(0);i++)
    {
        for(int j = 0; j<Array2D.GetLength(1); j++)
        {
            Console.Write($" {Array2D[i,j]} ");
        }
        Console.Write("\n");
    }
}

double[] AverageColumn(int[,]Arr2D)
{   double[] AvgArr = new double[Arr2D.GetLength(1)];
    for(int i = 0; i<Arr2D.GetLength(1);i++)
    {
        int Sum = 0;
         for(int j = 0; j<Arr2D.GetLength(0);j++)
         {
            Sum += Arr2D[j,i];
         }
        AvgArr[i] = (double)Sum/Arr2D.GetLength(0);
    }
    return AvgArr;
}
Console.WriteLine("Введите количество столбцов в двумерном массиве:");
int Column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в двумерном массиве:");
int Row = Convert.ToInt32(Console.ReadLine());
int[,] Arr2d = Create2DArray(Row,Column);
Show2DArray(Arr2d);
double [] AvgArr = AverageColumn(Arr2d);
Console.Write("\n Column Averages:");
for(int i =0; i<AvgArr.GetLength(0);i++)
    Console.Write($" {AvgArr[i]} ");
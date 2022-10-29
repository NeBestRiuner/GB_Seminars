//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
int [,] SortArr(int[,] Arr2D)
{
    for(int j =0; j < Arr2D.GetLength(0); j++)
    {
        for(int m = 0; m < Arr2D.GetLength(1); m++)
        {
            for(int i = 0; i < Arr2D.GetLength(1)-1; i++)
            {
                if(Arr2D[j,i]<Arr2D[j,i+1])
                {
                    int b = Arr2D[j,i];
                    Arr2D[j,i]=Arr2D[j,i+1];
                    Arr2D[j,i+1]=b;
                }
            }
        }
    }
    return Arr2D;
}

Console.WriteLine("Введите количество столбцов в двумерном массиве:");
int Column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в двумерном массиве:");
int Row = Convert.ToInt32(Console.ReadLine());
int[,] Arr2d = Create2DArray(Row,Column);
Show2DArray(Arr2d);
Console.WriteLine();
int[,] Arr2d1 = SortArr(Arr2d);
Show2DArray(Arr2d1);
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
void MinRow(int[,]Arr2D)
{   
    int MinSum=0;
    int MinPos=0;
    for(int i = 0; i<Arr2D.GetLength(0);i++)
    {
        int Sum=0;
        for(int j = 0; j<Arr2D.GetLength(1); j++)
        {
            Sum+=Arr2D[i,j];
        }
        if(i==0){MinSum=Sum; MinPos=i;}
        else
        {if(MinSum>Sum){MinSum=Sum; MinPos=i;}}
    }
    Console.WriteLine($"Строка с минимальной суммой - это {MinPos+1} строка");
}
Console.WriteLine("Введите количество столбцов в двумерном массиве:");
int Column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в двумерном массиве:");
int Row = Convert.ToInt32(Console.ReadLine());
int[,] Arr2d = Create2DArray(Row,Column);
Show2DArray(Arr2d);
Console.WriteLine();
MinRow(Arr2d);
*/
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int [,] Create2DArray(int m, int n)
{
    int [,] Array2D = new int[m,n];
    for(int i = 0; i<m ;i++)
    {
        for(int j = 0; j<n; j++)
        {
            Array2D[i,j] = new Random().Next(0,10);
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
int[,] ArrayMulti(int [,] Arr2D1, int[,] Arr2D2)
{
    if(Arr2D1.GetLength(1)==Arr2D2.GetLength(0))
    {
        int [,] Arr2D3 = new int[Arr2D1.GetLength(0),Arr2D2.GetLength(1)];
        for(int i = 0; i<Arr2D3.GetLength(0);i++)
        {
            for(int j = 0; j<Arr2D3.GetLength(1); j++)
            {
                int Res = 0;
                for(int m = 0; m<Arr2D1.GetLength(1);m++)
                {
                    Res+=(Arr2D1[i,m]*Arr2D2[m,j]);
                }
                Arr2D3[i,j]=Res;
            }
           
        }
        return Arr2D3;
    }
    else 
    {
        Console.WriteLine("С матрицами такого размера нельзя выполнить умножение");
        int [,] Arr2D3 = new int[1,1];
        Arr2D3[0,0]=0;
        return Arr2D3;
    }
}
Console.WriteLine("Введите количество столбцов в первом двумерном массиве:");
int Column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в первом двумерном массиве:");
int Row = Convert.ToInt32(Console.ReadLine());
int[,] Arr2d1 = Create2DArray(Row,Column);
Console.WriteLine("Введите количество столбцов во втором двумерном массиве:");
int Column2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк во втором двумерном массиве:");
int Row2 = Convert.ToInt32(Console.ReadLine());
int[,] Arr2d2 = Create2DArray(Row2,Column2);
Show2DArray(Arr2d1);
Console.Write("\n");
Show2DArray(Arr2d2);
int[,] Arr2d3 = ArrayMulti(Arr2d1,Arr2d2);
Console.Write("\n");
Show2DArray(Arr2d3);
*/
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int [,,] Create3DArray(int m, int n,int k)
{
    if(m*n*k<100)
    {
    int [,,] Array3D = new int[m,n,k];
    int num = 0;
    for(int i = 0; i<m ;i++)
    {
        for(int j = 0; j<n; j++)
        {   for(int g = 0; g<k; g++)
            {
                 Array3D[i,j,g] = 10+num;
                 num++;
            }   
           
        }
    }
    return Array3D;
    }
    else
    {
        Console.WriteLine("Нельзя создать массив с уникальными двузначными значенями, если ячеек больше 100");
        int [,,] Array3D = new int[1,1,1];
        Array3D[0,0,0]=0;
        return Array3D;
    }

}
void Show3DArray(int [,,] Array3D)
{
    for(int i = 0; i<Array3D.GetLength(0);i++)
    {
        for(int j = 0; j<Array3D.GetLength(1); j++)
        {
            for(int g = 0; g<Array3D.GetLength(2); g++)
            {
                Console.Write($" {Array3D[i,j,g]} ({i},{j},{g}), ");
            }
        }
    }
}
Console.WriteLine("Введите количество ячеек по оси x в трёхмерном массиве:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество ячеек по оси y в трёхмерном массиве:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество ячеек по оси z в трёхмерном массиве:");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] Arr3d = Create3DArray(x,y,z);
Show3DArray(Arr3d);
*/
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
int [,] Create2DArray()
{
    int m = 4;
    int n = m;
    int [,] Array2D = new int[m,n];
    int num = 1;
    int i = 0;
    int j = 0;
    while(i<n)
    {
        Array2D[j,i] = num;
        num++;
        i++;
    }
    i--;
    j++;
    while(j<m)
    {
        Array2D[j,i] = num;
        num++;
        j++;
    }
    j--;
    i--;
    while(i>=0)
    {
        Array2D[j,i] = num;
        num++;
        i--;
    }
    i++;
    j--;
    while(j>0)
    {
        Array2D[j,i] = num;
        num++;
        j--;
    }
    j++;
    i++;
    while(i<3)
    {
        Array2D[j,i] = num;
        num++;
        i++;
    }
    Array2D[2,2]=num;
    num++;
    Array2D[2,1]=num;
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

int[,] Arr2d1 = Create2DArray();
Show2DArray(Arr2d1);

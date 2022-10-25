// * Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов.
//  Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         System.Console.Write($"{matrix[i,j]}");   
        }
    System.Console.WriteLine();
    }
}

void FillArray(int [,] matrix )
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          matrix[i,j] = new Random().Next(1,10);
        }
    }
}
int [,] matr = new int [2,3];
FillArray(matr);
PrintArray(matr);


int MaxLine1 (int [,] matr)
{
    int max1 = matr[0,0];
    for(int j = 0; j < mart.GetLength(1); j++)
    {
        if(matr[0,j]>max1)
        {
            max1 = matr[1,j];
        }
    }
    return max1;
}
int m1 =MaxLine1(mart);

int MaxLine2 (int [,] matr)
{
    int max2 = matr[1,0];
    for(int j = 0; j < mart.GetLength(1); j++)
    {
        if(matr[1,j]>max2)
        {
            max2 = matr[1,j];
        }
    }
    return max2;
}
int m2 =MaxLine2(mart);

int SumMaxNumberLines(int [,] matr)
{   
    sumMax =0;
    sumMax = m1 + m2;
}

int MinColum1 (int [,] matr)       
    {
    int min1 = matr[0,0];
    for(int i = 0; i < mart.GetLength(0); i++)
    {
        if(matr[i,0]<min1)
        {
            min1 = matr[i,0];
        }
    }
    return min1;
    }
int mn1 =MinColum1(matr);

int MinColum2 (int [,] matr)  
    {
    int min2 = matr[0,1];
    for(int i = 0; i < mart.GetLength(0); i++)
    {
        if(matr[i,1]<min2)
        {
            min2 = matr[i,1];
        }
    }
    return min2;
    }
int mn2 =MinColum2(matr); 

int MinColum3 (int [,] matr)  
    {
    int min3 = matr[0,2];
    for(int i = 0; i < mart.GetLength(0); i++)
    {
        if(matr[i,2]<min2)
        {
            min3 = matr[i,2];
        }
    }
    return min3;
    }
int mn3 =MinColum3(matr);

int  SumMinNumberColums(int [,] matr)
{   
    int sumMin=0;
    sumMin= mn1 + mn2 + mn3;
}


int a = SumMaxNumberLines(matr);
int b = SumMinNumberColums(matr);
int resalt = a-b;
System.Console.WriteLine($"Результат: {a} - {b} = {resalt}");
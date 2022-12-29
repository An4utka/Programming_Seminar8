// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int col=new Random().Next(2,10);
int row=new Random().Next(2,10);
int[,] array = FillArray(row, col, 0, 10);
PrintArray(array);
Console.WriteLine();
int sum=0;
int sumMin=10*col;
int rowMin=0;
 for (int i = 0; i < row; i++)
    {
sum=0;
        for (int j = 0; j < col; j++)
        {
            sum=sum+array[i,j];
}
if (sum<sumMin)
{
sumMin=sum;
rowMin=i;
        }
        // Console.WriteLine();
    }

Console.WriteLine("Строка с наименьшей суммой элементов: "+rowMin);


// Задача 58: Задайте два двумерных массива (от 0 до 10). 
// Напишите программу, которая будет находить произведение двух массивов (поэлементное).

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

int col = new Random().Next(1, 10);
int row = new Random().Next(1, 10);
int[,] array1 = FillArray(row, col, 0, 10);
int[,] array2 = FillArray(row, col, 0, 10);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
int[,] arrayResult = new int[row, col];

for (int i = 0; i < row; i++)
{
    int sum = 0;
    for (int j = 0; j < col; j++)
    {
        arrayResult[i, j] = array1[i, j] * array2[i, j];
    }
}
Console.WriteLine();

PrintArray(arrayResult);

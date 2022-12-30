// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

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

int col = new Random().Next(2, 10);
int row = new Random().Next(2, 10);
int[,] array = FillArray(row, col, 0, 10);
PrintArray(array);
Console.WriteLine();
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
        for (int k = col - 1; k > j; k--)
        {
            {
                if (array[i, k] > array[i, k - 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k - 1];
                    array[i, k - 1] = temp;
                }
            }
        }
}
Console.WriteLine();

PrintArray(array);
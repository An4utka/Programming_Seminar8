// Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array3d = new int[2, 2, 2];
for (int i = 0; i < array3d.GetLength(0); i++)
{
    for (int j = 0; j < array3d.GetLength(1); j++)
    {
        for (int k = 0; k < array3d.GetLength(2); k++)
        {
            array3d[i, j, k] = new Random().Next(0, 100);
            Console.Write($"{array3d[i, j, k]} ({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
    // Console.WriteLine();
}

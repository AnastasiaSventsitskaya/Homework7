// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("write first index: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write second index: ");
int column = Convert.ToInt32(Console.ReadLine());

int maxrow = 3;
int maxcolumn = 4;

int [,] matrix = new int [maxrow, maxcolumn];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,12);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}


if (0 < row && row < maxrow && 0 < column && column < maxcolumn)
{
    Console.WriteLine("Найденное число: "+matrix[row, column]);
}
else
{
    Console.WriteLine("Такого элемента в массиве нет");
}



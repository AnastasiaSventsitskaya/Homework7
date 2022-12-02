// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] matrix = new int [5, 6];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,3);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}



int row = 5;
double avarage = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
       sum += matrix[j,i];
       
    }
    avarage = sum/row;
 Console.Write(avarage+" ");   
}


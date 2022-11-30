// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("write number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int min = 2;
int max = 20;
double [,] matrix = new double [rows,columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = Math.Round((new Random().NextDouble()) * 18 + 2 , 2);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}

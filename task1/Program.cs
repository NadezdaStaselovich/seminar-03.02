//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

double[,] Generate2DArray(int m, int n)
{
  double[,] result = new double[m, n];
  Random rand = new Random();
  for(int i = 0; i < result.GetLength(0); i++)
  {
    for(int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = Math.Round(rand.Next(-10, 50)*0.1, 1);
    }
  }
  return result;
}

void Print2DArray(double[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
}

Print2DArray(Generate2DArray(3, 4));


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] Generate2DArray(int m, int n)
{
  int[,] result = new int[m, n];

  for(int i = 0; i < result.GetLength(0); i++)
  {
    for(int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = new Random().Next(1, 100);
    }
  }
  return result;
}

void Print2DArray(int[,] arr)
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

int[,] arr = Generate2DArray(3, 4);
Print2DArray(arr);
System.Console.WriteLine();
GetAverageColumn(arr);

void GetAverageColumn(int[,] arr)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  {
      double sum = 0;
      for (int i = 0; i < arr.GetLength(0); i++)
      {
          sum += arr[i, j];
      }
      Console.Write($"{ sum / arr.GetLength(0)}; ");
  } 
}
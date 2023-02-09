// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Generate2DArray(int m, int n)
{
  int[,] result = new int[m, n];

  for(int i = 0; i < result.GetLength(0); i++)
  {
    for(int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = new Random().Next(-10, 50);
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
FoundElementArray(arr);

void FoundElementArray(int[,] arr)
{
  Console.Write("Введите индекс строки:");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите индекс столбеца:");
  int colums = Convert.ToInt32(Console.ReadLine());

  if (rows < arr.GetLength(0) && colums < arr.GetLength(1)) Console.WriteLine(arr[rows, colums]);
  else Console.WriteLine($"[{rows},{colums}] -> такого элемента в массиве нет");
}


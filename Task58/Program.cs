Console.Clear();
Console.Write("Введи количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array1 = new int[m,n];
int[,] array2 = new int[m,n];

Console.WriteLine($"\nМатрица №1: ");
FillArray(array1);
Print(array1);
Console.WriteLine($"\nМатрица №2: ");
FillArray(array2);
Print(array2);

int[,] result = new int[m,n];

MultiplyMatrix(array1, array2, result);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
Print(result);

void MultiplyMatrix(int[,] array1, int[,] array2, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      result[i,j] = sum;
    }
  }
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);;
    }
  }
}

void Print(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}



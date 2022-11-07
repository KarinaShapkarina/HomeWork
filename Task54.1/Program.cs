Console.Clear();
Console.Write("Введи количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(1,10);;
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

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1)-1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

void OrderArrayColumn(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
          for (int g = 0; g < array.GetLength(0)-1; g++)
          {
             if (array[g, j] < array[g+1, j])
              {
                  int temp = array[g+1,j];
                  array[g+1,j] = array[g, j];
                  array[g, j] = temp;
              }
          }
      }
    }
}

Console.WriteLine($"\nРандомный массив: ");
FillArray(array);
Print(array);
Console.WriteLine($"\nОтсортированный массив по строчно: ");
OrderArrayLines(array);
Print(array);
Console.WriteLine($"\nОтсортированный массив по столбцам: ");
OrderArrayColumn(array);
Print(array);
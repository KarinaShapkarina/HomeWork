Console.Clear();
Console.Write("Введи n: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введи m: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введи l: ");
int l = int.Parse(Console.ReadLine());

int[,,] array = new int[m, n, l];

FillArray(array);
Print(array);

void FillArray(int[,,] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int m = 0; m < array.GetLength(0); m++)
  {
    for (int n = 0; n < array.GetLength(1); n++)
    {
      for (int l = 0; l < array.GetLength(2); l++)
      {
        array[m, n, l] = temp[count];
        count++;
      }
    }
  }
}

void Print (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"{array[i,j,k]}({i},{j},{k}); ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
Console.WriteLine("Введите длинну массива:");
int N =int.Parse(Console.ReadLine());
int[] arr = new int[N];

void newArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
     {
        array[i] = new Random().Next(0, 10);
     }
}

void printArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length-1)) Console.Write($", ");
    }
    Console.WriteLine();
}

newArray(arr);
printArray(arr);
Console.WriteLine("Введите длинну массива:");
int N =int.Parse(Console.ReadLine());
int[] arr = new int[N];

void newArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
     {
        array[i] = new Random().Next(100, 999);
     }
}

void printArray(int[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length-1)) 
        {
            Console.Write($", ");
        }
    }
    Console.WriteLine();
}

int Number(int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
           count++; 
        }
    }
    return count;
}

newArray(arr);
printArray(arr);
System.Console.WriteLine(Number(arr));
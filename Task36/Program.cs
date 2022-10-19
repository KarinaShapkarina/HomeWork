Console.WriteLine("Введите длинну массива:");
int N =int.Parse(Console.ReadLine());
int[] arr = new int[N];

void newArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
     {
        array[i] = new Random().Next(0, 50);
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

int Sum(int[] array)
{   
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

newArray(arr);
printArray(arr);
System.Console.WriteLine($"Сумма равна: {Sum(arr)}");

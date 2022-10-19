Console.WriteLine("Введите длинну массива:");
int N =int.Parse(Console.ReadLine());
double[] arr = new double[N];

double[] newArray(double[] array)
{
    for (int i=0; i < array.Length; i++)
     {
        array[i] = new Random().Next(0, 100) + Convert.ToDouble(new Random().Next(11)/10.0);
     }
     return array;
}

void printArray(double[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length-1)) 
        {
            Console.Write($" , ");
        }
    }
    Console.WriteLine();
}

double MinMaxDiff(double[] array)
{   
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return max-min;
}

System.Console.WriteLine(newArray(arr));
printArray(arr);
System.Console.WriteLine($"Разность мах и мин равна: {MinMaxDiff(arr)}");


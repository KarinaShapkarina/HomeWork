bool Cube = true;
while (Cube)
{
    try
    {
        Console.Write("Укажи количество цифр: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Укажи числа:");      
        int[] array = new int[N];

        int[] Arr(int[] array)
        {
        for (int i=0; i < array.Length; i++)
        {
            bool Number = true;
            while (Number)
            {
                try
                {
                    array[i] = int.Parse(Console.ReadLine());
                    Number = false;
                }
                catch
                {
                Console.WriteLine("Это не число. Повтори:");
                }
            }
        }
        return array;
        }

        void printArray(int[] array)
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

        int amountOfNumbers(int[] array)
        {   
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            count++;
            
        }
        return count;
        }

        System.Console.WriteLine(Arr(array));
        Console.WriteLine("Твои числа:");
        printArray(array);
        System.Console.WriteLine($"Количество чисел больше 0: {amountOfNumbers(array)}");

        Cube = false;
    }
    catch
    {
        Console.WriteLine("Моя твоя не понимайт. Повтори:");
    }
}













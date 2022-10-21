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











// int[] array1 = new Int32[8];
// int[] array2 = new Int32[8];

// randomFilling(array1, min:0,  max: 100);
// arrayOutput(array1);
// copy(array1, array2);
// arrayOutput(array2);

// void copy(int[] array1, int[] array2)
// {
//     for (int i = 0; i < array1.Length; i++)
//     {
//         array2[i] = array1[i] ;
//     }
// }



// void randomFilling(int[] arr, int min, int max)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(min, max);
//     }
// }

// void arrayOutput(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}");
//         if (i < (arr.Length -1)) Console.Write($", ");
//     }
//     Console.WriteLine(" ");
// }

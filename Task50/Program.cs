Console.Write("Введи количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

void FillArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            matr[i, j] = new Random().Next(1,10);   
        }
    }
}

void Print(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            Console.Write(matr[i,j]+" ");   
        }
    Console.WriteLine();   
    }
}


void number(int[,] matr)
{
    Console.Write("Введи номер строки: ");
    int numberString = int.Parse(Console.ReadLine());
    Console.Write("Введи номер столбца: ");
    int numberColumn = int.Parse(Console.ReadLine());
    if(numberString > m || numberColumn > n)
        {
            Console.WriteLine("Элемента с координатами ["+numberString+", "+numberColumn+"] в массиве нет.");    
        }
    else 
    {
        Console.WriteLine("Элемент с координатами ["+numberString+", "+numberColumn+"] = "+matr[numberString, numberColumn]);
    }

       
    Console.WriteLine();  
}

FillArray(array);
Print(array);
number(array);
Console.Write("Введи количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

int[,] FillArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            matr[i, j] = new Random().Next(1,10);   
        }
    }
    return matr;
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

void MidSumm(int[,]matr)
{
    for (int j = 0; j < matr.GetLength(1); j++){
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++){
            sum += matr[i,j];  
        } 
    double mid = sum / m;
    Console.Write($"{Math.Round(mid, 2)} ");     
    }
    Console.WriteLine(); 
}


FillArray(array);
Print(array);
MidSumm(array);
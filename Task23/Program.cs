Console.WriteLine("Укажи число для вывода таблицы кубов:");
Console.WriteLine();
bool Cube = true;
while (Cube)
{
    try
    {
        Console.Write("N = ");
        int N = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <= N; i++)
        
        Console.WriteLine("Таблица кубов: " +Math.Pow(i, 3));
        
        Cube = false;
    }
    catch
    {
        Console.WriteLine("Моя твоя не понимайт. Повтори:");
    }
}

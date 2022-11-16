Console.WriteLine("Введи число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи число n");
int n = Convert.ToInt32(Console.ReadLine());

int functionAckerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAckerman} ");

int Ack(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (n == 0) 
    {
        return Ack(m - 1, 1);
    }
    else 
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}
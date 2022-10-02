Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write(a);
}
else
{
    if(a == b) //Ну, а вдруг?
    {
        Console.Write("Числа равны! Думал(а) попадусь? =Ь"); 
    }
    else
    {
        Console.Write(b);
    }
}

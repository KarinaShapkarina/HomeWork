Console.WriteLine("Привет, я - терминал!");

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    if(a > c)
    {
        Console.Write(a);
        if(a == c)
        {
            Console.WriteLine("Числа ");
            Console.WriteLine(a);
            Console.WriteLine("и ");
            Console.WriteLine(c);
            Console.WriteLine(" равны. Терминал не обдуришь!");
        }
    }
    else
    {
       Console.Write(c); 
    }
}
else
{
    if(a == b)
    {
        Console.WriteLine("Числа ");
        Console.WriteLine(a);
        Console.WriteLine("и ");
        Console.WriteLine(b);
        Console.WriteLine(" равны! Ну, нельзя так мучить терминал!");
    }
    else
    {
        if(b > c)
        {
            Console.Write(b);
            if(b == c)
            {
                Console.WriteLine("Числа ");
                Console.WriteLine(b);
                Console.WriteLine("и ");
                Console.WriteLine(c);
                Console.WriteLine(" равны... Как не стыдно!"); 
            }
            else
            {
                Console.Write(c); 
            }
        }
    }
}



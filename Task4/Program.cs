//Код будет дорабатываться. Цель заставить терминал ругаться сразу на 3 равных числа.

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
    }
    else
    {
        if(a == c)
        {
            Console.Write("Числа ");
            Console.Write(a);
            Console.Write(" и ");
            Console.Write(c);
            Console.Write(" равны. Терминал не обдуришь!");
        }
        else
        {
            Console.Write(c);
        }
    }
}
else
{
    if(a == b)
    {
        Console.Write("Числа ");
        Console.Write(a);
        Console.Write(" и ");
        Console.Write(b);
        Console.Write(" равны! Ну, нельзя так мучить терминал!");
    }
    else
    {
        if(b > c)
        {
            Console.Write(b);
        }
        else
        {
            if(b == c)
            {
                Console.Write("Числа ");
                Console.Write(b);
                Console.Write(" и ");
                Console.Write(c);
                Console.Write(" равны... Как не стыдно!"); 
            }
            else
            {
                Console.Write(c); 
            }
        }
    }
}



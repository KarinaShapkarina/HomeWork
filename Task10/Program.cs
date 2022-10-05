﻿Console.WriteLine("Привет, я - терминал!");
Console.WriteLine(" Моя задача найти для тебя второе число целого трехзначного числа.");
Console.WriteLine("     Правило простое: ты мне целого трехзначное число, я тебе результат.");
Console.WriteLine("         И, пожалуйста, НЕ надо проверять терминал на прочность!");

Console.WriteLine("Введи целое число трехзначное число:");
string? number = Console.ReadLine();

if (Int32.TryParse(number, out int n))
{
    if( n >= 100 && n < 1000)
    {
        int remainderOfNumber = n % 100 / 10;
        Console.Write("Вторым числом " + n + " является " + remainderOfNumber + "! Терминал заслужил печеньку!");    
    }
    else
    {
        if( n < 100 )
        {
            Console.Write("Ага! Терминал - не дурак! Терминал разгадал твою задумку! "+ n +" - не трехзначное!");     
        }
        if( n >= 1000 )
        {
            Console.Write("А кто тут у нас захотел поссориться с терминалом?! ^_^ "+ n +" - явно слишком большое, не находишь?");     
        }
    }
}
else
{
    Console.WriteLine("Так вот почему Терминатор восстал... Это был, скорее всего, такой же усталый терминал... I'll be back!!!");
}



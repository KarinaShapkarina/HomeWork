System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US"); //для корректной работы с дробными числами "," , "."

Console.WriteLine("Привет! Я - терминал!");
Console.WriteLine(" Моя задача найти для тебя третье по счету цифру из твоего числа, либо сказать, что третьей цифры нет.");
Console.WriteLine("     На этот раз я не буду просить тебя вводить только целые и положительные числа. Ведь терминал не злопамятный и все понимает ^_^");
Console.WriteLine("         Только у терминала есть одна просьба, пожалуйста, НЕ вводи слова! Терминал прекрасно умеет читать!");
Console.WriteLine("Итак, твое число:");

string? number = Console.ReadLine();
number = number?.Replace(",", "."); //автоматически конветирует запятую в точку при неправильном вводе дробного числа

if (Double.TryParse(number, out double n)) //преобразует 4ю строку в число дробного типа (работает с целым)
{
    if(Math.Abs(n) >= 100) //дает возможность испльзовать отрицательное число на ввод
    {
        string convertNumber = Math.Abs(n).ToString().Substring(2 , 1);  //конвертирует число в строку и выдает 3ю цифру (символ) с длиной в 1 символ
        Console.Write("Цифра " + convertNumber + " на барабане!");
    }
    else
    {
        Console.Write("Число " + number + " меньше 100 и не имеет третьей по счету цифры!");
    }
}
else //ругаемся на буквы и сиволы
{
    Console.Write("Берегись! Восстание машин не за горами!");
}

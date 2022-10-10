Console.Clear();
Console.WriteLine("Привет! Я - терминал. Задача на палиндромность.");
bool Palindrom = true;
while (Palindrom)
{
    try
    {
        Console.WriteLine("Введи пятизначное число:");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = n / 1000;                                        //правое двухзначное число         
        int b = n % 100;                                         // левое двузначное число
        int c = b % 10;                                        // крайняя цифра слева
        int MidNumber = n % 1000/ 100;                         // середина
        int ReverceNumber = c*100 + b - c  + MidNumber;         // реверс числа
        int RightSide = n / 100;                                // первые 3 цифры
        if (RightSide == ReverceNumber)
        {
            Console.WriteLine("Палиндром");
        }
        else
        {
            Console.WriteLine("Не палиндром");
        }
        Palindrom = false;
    }
    catch
    {
        Console.WriteLine("Моя твоя не понимайт. Повтори:");
    }
}

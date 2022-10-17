Console.WriteLine("Нахождение суммы чисел в заданом числе.");

int Message(string message)
{
   System.Console.WriteLine(message);
   string resultRead = System.Console.ReadLine();
   int result = int.Parse(resultRead);
   return result;
}

int number = Message("Укажи число:");

int SumOfNuber(int number)
{
int sum = 0;
while (number > 0)
     {
        sum += number % 10;
        number = number / 10;
     }
      return sum;
}

System.Console.WriteLine($"Результат {SumOfNuber(number)}");

Console.WriteLine("Возведение числа A в степень B.");

int Message(string message)
{
   System.Console.WriteLine(message);
   string resultRead = System.Console.ReadLine();
   int result = int.Parse(resultRead);
   return result;
}

int a = Message("Укажи число А:");
int b = Message("Укажи степень B:");

int Cycle(int a, int b)
{
int c = 1;
for (int i = 1; i <= b; i++)
     {
        c *= a;
     }
      return c;
}

System.Console.WriteLine($"Результат {Cycle(a,b)}");
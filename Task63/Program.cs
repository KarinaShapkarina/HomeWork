Console.WriteLine("Введи число");

int number = Convert.ToInt32(Console.ReadLine());

printNaturalNumbers(number);

void printNaturalNumbers(int n)
{
   int number = 1;
    if(n == number)
    {
      Console.Write(n);  
    }
    else 
    {
      Console.Write(n);  
      printNaturalNumbers(n - 1);
    }   
}

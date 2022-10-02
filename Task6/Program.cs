Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
int c = (a % 2);

if(c == 0)
{
    Console.Write("Четное");
}
else
{
    Console.Write("Нечетное");
}
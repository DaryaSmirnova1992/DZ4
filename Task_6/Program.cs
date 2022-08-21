Console.WriteLine ("Введите число");
int number1 = int.Parse(Console.ReadLine());
int even = number1 % 2;

if(even == 0)
{
    Console.Write("Четное число");
}
else
{Console.Write("Нечетное число");
}
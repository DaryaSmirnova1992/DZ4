Console.WriteLine ("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Наибольшее значение: ");
if(number1 > number2)
{
    Console.Write("максимальное "+ number1 + ", минимальное " + number2);
}
else
{
    Console.Write("максимальное "+ number2 + ", минимальное " + number1);
}
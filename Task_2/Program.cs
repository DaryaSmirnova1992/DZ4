Console.WriteLine ("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Наибольшее значение: ");
if(number1 > number2)
{
    Console.Write(number1);
}
else
{
    Console.Write(number2);
}
Console.WriteLine ("Введите число");
int number1 = int.Parse(Console.ReadLine());
int i = 2;
while(i <= number1)
{
    Console.Write(i);
    Console.Write(", ");
    i = i + 2;
}

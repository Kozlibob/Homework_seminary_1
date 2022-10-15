Console.WriteLine("Введите первое число ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
double b = double.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("MAX - " + a);
    Console.WriteLine("MIN - " + b);
}
else if (b > a)
{
    Console.WriteLine("MAX - " + b);
    Console.WriteLine("MIN - " + a);
}

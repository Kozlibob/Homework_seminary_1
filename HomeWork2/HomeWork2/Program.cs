Console.WriteLine("Введите первое число ");
double a= double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
double b= double.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число ");
double c= double.Parse(Console.ReadLine());
if (a>b && a>c)
{
    Console.WriteLine("MAX - " + a);
}
else if (b>a && b>c)
{
    Console.WriteLine("MAX - " + b);
}
else Console.WriteLine("MAX - " + c);
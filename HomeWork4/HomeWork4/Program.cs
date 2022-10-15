Console.Write("Введите число - ");
int a = int.Parse(Console.ReadLine());
for(int j = 1; j <= a; j++)
{
    if ((j % 2) == 0)
    {
        Console.WriteLine("Четные числа до Вашего " + j);
    }
}
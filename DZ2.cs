Console.WriteLine("Введите первое число: ");
int current1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int current2 = int.Parse(Console.ReadLine());

if (current1 == current2*current2)
{
    Console.WriteLine("Первое число является квадрантом второго");
}
else if (current1 != current2*current2)
{
    Console.WriteLine("Первое число не является квадрантом второго");
}
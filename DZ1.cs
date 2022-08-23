int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine("Введите номер недели: ");
int current = int.Parse(Console.ReadLine());

if (current >= numbers[0] && current <= numbers[4] )
{
    Console.WriteLine("Введен номер буднего дня");
}
if (current >= numbers[5] && current <= numbers[6])
{
    Console.WriteLine("Введен номер выходного дня");
}
if (current > numbers[6])
{
    Console.WriteLine("Введен номер вне интервала");
}
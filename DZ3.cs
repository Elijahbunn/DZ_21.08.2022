Console.WriteLine("Впишите номер четверти");
int coord_plane = int.Parse(Console.ReadLine());

if (coord_plane == 1)
{
    Console.WriteLine("Доступные координаты по оси Х: от 0 до ∞");
    Console.WriteLine("Доступные координаты по оси У: от 0 до ∞");
}
else if(coord_plane == 2)
{
    Console.WriteLine("Доступные координаты по оси Х: от 0 до -∞");
    Console.WriteLine("Доступные координаты по оси У: от 0 до ∞");
}
else if(coord_plane == 3)
{
    Console.WriteLine("Доступные координаты по оси Х: от 0 до -∞");
    Console.WriteLine("Доступные координаты по оси У: от 0 до -∞");
}
else if(coord_plane == 4)
{
    Console.WriteLine("Доступные координаты по оси Х: от 0 до ∞");
    Console.WriteLine("Доступные координаты по оси У: от 0 до -∞");
}
else
{
    Console.WriteLine("Введите адекватный номер коордитнатной пласкости");
} 
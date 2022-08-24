Console.WriteLine("Введите координаты первой точки на оси X: ");
double X1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты первой точки на оси Y: ");
double Y1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты первой точки на оси Z: ");    // убрать эту строку, для вычисления расстояния в 2D
double Z1 = double.Parse(Console.ReadLine() ?? "0");                // убрать эту строку, для вычисления расстояния в 2D

Console.WriteLine("Введите координаты второй точки на оси X: ");
double X2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты второй точки на оси Y: ");
double Y2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты второй точки на оси Z: ");    // убрать эту строку, для вычисления расстояния в 2D
double Z2 = double.Parse(Console.ReadLine() ?? "0");                // убрать эту строку, для вычисления расстояния в 2D

double DeepX = Math.Pow((X2 - X1), 2);
double DeepY = Math.Pow((Y2 - Y1), 2);
double DeepZ = Math.Pow((Z2 - Z1), 2);                              // убрать эту строку, для вычисления расстояния в 2D

double sum = DeepX + DeepY + DeepZ;                                 // убрать переменную "DeepZ" из строки для вычисления расстояния в 2D
//Console.WriteLine(sum);

double result = Math.Sqrt(sum);
Console.WriteLine("Расстояние между точками в трехмерном пространстве равно: ");    /* Заменить фразу в скобках на:
                                                                                       "Расстояние между точками в двуххмерном пространстве равно: "
                                                                                       для вычисления расстояния в 2D */
Console.WriteLine(result);
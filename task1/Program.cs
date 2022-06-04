// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Write("Введите число b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "0");
int x = 0;
int y = 0;
// Из системы 2х уравнений: x = (b2 - b1) / (k1 - k2)
x = (b2 - b1) / (k1 - k2);
y = k2 * x + b2;
Console.WriteLine($"Координаты точки пересечения двух прямых x = {x}, y = {y}");
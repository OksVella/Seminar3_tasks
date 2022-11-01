// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1 = getCoordinate("x", "A");
int y1 = getCoordinate("y", "A");
int z1 = getCoordinate("z", "A");
int x2 = getCoordinate("x", "B");
int y2 = getCoordinate("y", "B");
int z2 = getCoordinate("z", "B");

double distance = Math.Round(calculateDistance(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine(distance);

int getCoordinate(string coordinateName, string pointName)
{
    Console.Write($"Enter coordinate {coordinateName} point {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double calculateDistance(double x1, double x2, 
                         double y1, double y2, 
                         double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}
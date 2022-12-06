// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double ab=0;
double [] point = new double[6];                // 0 1 2      3  4  5
Console.WriteLine("Введите координаты двух точек A(x,y,z) и B(x1,y1,z1):");
for (int i=0;i<point.Length;i++)
   point[i]= Convert.ToDouble(Console.ReadLine());
ab=Math.Sqrt((point[0]-point[3])*(point[0]-point[3]) + (point[1]-point[4])*(point[1]-point[4]) + (point[2]-point[5])*(point[2]-point[5]));
Console.WriteLine(ab);
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Введите чиcло N");
int n = Convert.ToInt32 (Console.ReadLine());
if (n>0)
{
    int r=1;
    for (int i=1;i<=n;i++)
    {
        r=i*i*i;
        Console.Write(" "+r);
    }
}
else
    Console.WriteLine("Введено не натуральное чило");
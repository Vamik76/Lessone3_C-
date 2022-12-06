// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine ("Введите пятизначное чиcло");
int a = Convert.ToInt32 (Console.ReadLine ());

if (a>9999&&a<100000)
{
    Console.WriteLine ("пятизначное!!!");
    string b = Convert.ToString(a);
    if (b[0]==b[4]&&b[1]==b[3])
        Console.Write ("палиндромом!!!");
    else
        Console.Write ("НО не палиндромом!!!"); 
}
else
    Console.WriteLine("Введенное число не пятизначное!!!");
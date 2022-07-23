// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.




int PrintArray( int n1, int n2, int n3, int n4, int n5)
{
    if(n1 == n5 && n2 == n4) return 1;
    return -1;
}

Console.Write("Input n1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n3: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n4: ");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n5: ");
int n5 = Convert.ToInt32(Console.ReadLine());
int num = PrintArray(n1, n2, n3, n4, n5);
if (num == -1)
    Console.WriteLine(n1+""+n2+""+n3+""+n4+""+n5+""+" " + "НЕ является палиндромом ");
else
    Console.WriteLine(n1+""+n2+""+n3+""+n4+""+n5+""+" " + "является палиндромом ");
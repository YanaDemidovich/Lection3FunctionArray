// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


/*int PrintArray( int n1, int n2, int n3, int n4, int n5)
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
    Console.WriteLine(n1+""+n2+""+n3+""+n4+""+n5+""+" " + "является палиндромом ");*/

// более правильный вариант

/*void Palindrom()
{
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 | number > 99999)
{
    Console.WriteLine("Число не входит в диапазон, введите 5-значное число");
}
else if (number % 10 == number / 10000 && (number % 100) / 10 == (number / 1000) % 10)
{
    Console.WriteLine("Число является палиндроном");
}
else 
{
Console.WriteLine("Число не является палиндроном");
}
}
Palindrom();*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.

/* double Pifagor(double x1, double y1, double x2, double y2, double x3, double y3)

{    
    double gipotenuza = Math.Sqrt((x1-x2)*(x1-x2)* + (y1-y2)*(y1-y2) + (x2-x3)*(x2-x3)* + (y2-y3)*(y2-y3));
    return gipotenuza;
}

Console.Write("Input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x3: ");
double x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y3: ");
double y3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ansver is " + Pifagor(x1, y1, x2, y2, x3, y3));*/

// более правильное решение

/* void Rasstoynie()
{
    int[] array1 = new int[3];
    int[] array2 = new int[3];
    for (int i = 0;i<3;i++)
    {
      Console.WriteLine("Введите координату первой точки");
      array1[i] = Convert.ToInt32(Console.ReadLine());
    }
for (int i = 0;i<3;i++)
{
    Console.WriteLine("Введите координату второй точки");
      array2[i] = Convert.ToInt32(Console.ReadLine());
}
double result = Math. Sqrt((Math.Pow((array2[0] - array1[0]), 2) + Math.Pow((array2[1] - array1[1]), 2) + Math.Pow((array2[2] - array1[2]), 2)));
result = Math.Round(result, 2);
Console.WriteLine("Расстояние между двумя точками = " + result);
}
Rasstoynie();*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*void Kub(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i * i * i + " ");
    }
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
Kub(n);*/

// или другой вариант решения

void Kybs()
{
    Console.WriteLine("Введите число");
    int  number = Convert.ToInt32(Console.ReadLine());
    int[] array1 = new int[number];
    for (int i = 0;i<number;i++)
    {
        array1[i] = (i+1) * (i+1) * (i+1);
    }
    for (int i = 0;i<number;i++)
    {
        Console.Write (" " + array1[i]);
    }
}
Kybs();

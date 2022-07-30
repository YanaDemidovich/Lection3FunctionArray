// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int a)
{
    int result = 0;
    while(a > 0)
    {
        result += a % 10;
        a = a / 10;
    }
    return result;
}

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр в числе равна " + Sum(n1));

// другой вариант решения задачи

int Summa( int number)
{
int sum = 0;
int N = 0;
int number1 = number;
while (number1>0)
{
    number1 = number1 / 10;
    N++;
}
while (number>0)
{
    int a = 0;
    a = number % 10;
    number = number / 10;
    sum = sum + a;
}
    return sum;
}
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int result = Summa(a);
Console.WriteLine("Сумма цифр числа = " + result);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Massiv()
{
    
    int[] array = new int[8];
    Random myRandom = new Random();
 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(0, 9);
        Console.Write("{0} ", array[i]);
    }
}
Massiv();

// другой вариант решения задачи

void Massiv()
{
    int N = 8;
    int[] array = new int[N];
    Random rand = new Random();
    Console.WriteLine("Массив чисел: ");
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = rand.Next();
        Console.Write(" " + array[i]);
    }
} 
Massiv();

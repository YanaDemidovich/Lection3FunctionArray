// Принимает на вход число "a" и возвращает сумму чисел от 1 до "a".

/* int FindSum(int a)
{
    int current = 1, sum = 0;
    while(current <= a)
    {
        sum+= current;
        current++;
    }
    return sum;    
}

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма чисел равна " + FindSum(num));*/

// Задача 1: Принимает число "a"и возвращает кол-во цифр в числе.

/*int Kol(int a)
{
    int b = 0;
    while(a > 0)
    {
        b++;
        a = a/10;
    }
    return b;
}

Console.Write("Введите целое положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество цифр " + Kol(a));*/


// Задача 2: Принимает число "n" и выдаст произведение чисел от 1 до "n" (факториал)

/* int Factorial(int a)
{
    int current = 1, f = 1;
    while(current <= a)
    {
        f = f * current;
        current++;
    }
    return f;    
}

Console.Write("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Факториал = " + Factorial(n));*/

// Задача 3: Принимает 2 числа "a" и "b" и возводит число "a" в натуральную степень "b".

/* int Stepen(int a, int b)

{
    int i = 1;
    int c = 1;
    while(i <= b)
    {
        c = c * a;
        i++;
    }
    return c;
}

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Первое число в степени второго равно " + Stepen(n1, n2));*/
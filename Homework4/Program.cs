// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int a)
{
    int current = 0, sum = 0;
    while(current < a)
    {
        sum = a % 10;
        a = a/10;
        current++;
    }
    return sum;
}

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма цифр в числе равна " + Sum(n1));


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

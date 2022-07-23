// ====== К какой четверти относится заданная координата? ======
/* int FindQuart(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x > 0 && y < 0) return 3;
    if(x < 0 && y < 0) return 4;
    return -1;
}

Console.Write("Input X coord: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coord: ");
int y = Convert.ToInt32(Console.ReadLine());

int quart = FindQuart(x,y);
if (quart == -1)
    Console.WriteLine("Point on the axes!");
else
    Console.WriteLine("Number of quart for out point is " + quart);
*/

// Задача1. Вводим номер четверти координат, на вывод определяем диапазон чисел. 
// Например: вводим №1, на ввод "х больше 0 и y больше 0"

/* void QuarterNumber(int quart)
{
    if(quart == 1) Console.WriteLine("x больше 0, y больше 0");
    if(quart == 2) Console.WriteLine("x меньше 0, y больше 0");
    if(quart == 3) Console.WriteLine("x больше 0, y меньше 0");
    if(quart == 4) Console.WriteLine("x меньше 0, y меньше 0");
    if(quart > 4 || quart < 1) Console.WriteLine("Такой четверти не существует");
}
Console.Write("Input quarter: ");
int quart = Convert.ToInt32(Console.ReadLine());

QuarterNumber(quart);*/
// === или ===
/*void QuarterNumber(int x)
{
    if(x == 1) Console.WriteLine("x больше 0, y больше 0");
    if(x == 2) Console.WriteLine("x меньше 0, y больше 0");
    if(x == 3) Console.WriteLine("x больше 0, y меньше 0");
    if(x == 4) Console.WriteLine("x меньше 0, y меньше 0");
    if(x > 4 || x < 1) Console.WriteLine("Такой четверти не существует");
}

Console.Write("Input quarter: ");
int x = Convert.ToInt32(Console.ReadLine());
QuarterNumber( x);*/


// Задача 2. Принимаем число n, а на вывод квадраты чисел от 1 до введенного числа n.

/* void Kvadrat(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i * i + " ");
    }
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
Kvadrat(n);*/

// Задача 3. Найти расстояние между двумя точками А и В в плоскости.

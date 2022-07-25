// Метод вызова вещественных чисел (те, что с плавающей запятой)

// генерируем новое рандомное целое число  + новую дробную часть
// double num = (new Random().Next(1, 10)) + new Random().NextDouble();
                                                    // NextDouble() генерирует дробную часть

/* int[] CreateRandomArray(int size, int min, int max) // метод который создает массив
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    return array;
}

int[] myArray = CreateRandomArray(4, -3, 3);
double num = (new Random().Next(1, 10)) + new Random().NextDouble();
Console.WriteLine(num); */
// можно отформатировать вывод дробного числа, чтобы выводилось определенное кол-во символов после запятой


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/* int[] CreateRandomArray(int size, int min, int max) // метод который создает массив

{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    return array;
}

int EvenNumber(int[] array) // метод поиска четных числел в массиве
{
    int a = 0;
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == a) sum++; // определяем число четное или нет
    }
    return sum;
}

void Print(int[] array) // метод, который выводит массив
{

    for(int i = 0; i < array.Length; i++) // до тех пор пока "for" (i=0 - первое число массива = индекс 0; пока индекс меньше длинны массива; добавялем +1 шаг)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(4, 100, 999); // указываем параметры массива: 4 чисел, от 100, до 999
Print(myArray); // выводим рандомные числа массива
Console.WriteLine("Кол-во четных чисел = " + EvenNumber(myArray)); */ // выводим кол-во четных чисел

// Задача 36: Задайте массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

/* int[] CreateRandomArray(int size, int min, int max) // метод который создает массив

{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    return array;
}

int NumberOddIndex(int[] array) // метод поиска нечетных индексов: 1, 3 и т.д.
{
    int a = 0;
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 > a) sum += array[i]; // определяем элемент с нечетным индексом и суммируем его
    }
    return sum;
}

void Print(int[] array) // метод, который выводит массив
{

    for(int i = 0; i < array.Length; i++) // до тех пор пока "for" (i=0 - первое число массива = индекс 0; пока индекс меньше длинны массива; добавялем +1 шаг)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(5, 1, 10); // указываем параметры массива: кол-во чисел, от min, до max
Print(myArray); // выводим рандомные числа массива
Console.WriteLine("Сумма элементов стоящих на нечетных позициях = " + NumberOddIndex(myArray)); // выводим сумму */

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.


// Немного не поняла как применить счетчик рандомных вещественных чисел(((




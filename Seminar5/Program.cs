// Ввести массив из 9 рандомных чисел от -9 до 9 и сложить отдельно отрицательные и положительные.

/* int[] CreateRandomArray(int size, int min, int max) // метод который создает массив
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    return array;
}

void ShowArray(int[] array) // метод, который выводит массив
{

    for(int i = 0; i < array.Length; i++) // до тех пор пока "for" (i=0 - первое число массива = индекс 0; пока индекс меньше длинны массива; добавялем +1 шаг)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindPositiveSum(int[] array) // метод поиска суммы положительных чисел
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i]; // проверка на положителное число
    }
    return sum;
}

int FindNegativeSum(int[] array) // метод поиска суммы отрицательных чисел
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i]; // проверка на отрицательное число
    }
    return sum;
}
                            // int sise, min, max
int[] myArray = CreateRandomArray(12, -9, 9); // в () указано 12 элементов, min -9, max 9
ShowArray(myArray);
Console.WriteLine("Сумма положительных " + FindPositiveSum(myArray) + " " + "Сумма отрицательных " + FindNegativeSum(myArray)); */


// Задача 1. Необходимо написать программу для замены элементов массива с отрицательных на положительные числа
// Аргументом будет массив

/* int[] CreateRandomArray(int size, int min, int max) // метод который создает массив
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    return array;
}

int[] RechangeArray(int[] myArray) // метод замены положительного значения на отрицательное и наоборот
{
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = myArray[i] * (-1); // умножение на -1
    }
    return myArray;
}

void Print(int[] myArray) // метод, который выводит массив
{

    for(int i = 0; i < myArray.Length; i++) // до тех пор пока "for" (i=0 - первое число массива = индекс 0; пока индекс меньше длинны массива; добавялем +1 шаг)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
}


int[] myArray = CreateRandomArray(12, -9, 9); // в () указано 12 элементов, min -9, max 9
Print(myArray);
Print(RechangeArray(myArray));  */


// Задача 2. Необходимо написать программу которая опредеяет присутствует ли заданное число в массиве
// Первым аргументом будет массив, вторым число, которое надо найти. 
// Возвращать будет: индекс соответствующей позиции в массиве, либо ошибку; bool - да/нет


// Задача 3. Необходимо задать массив из 20 случайных чисел и найти кол-во элементов массива, значение которых от 9 до 99
// На вход рандомный массив, на возврат - число (кол-во)


/* int[] CreateRandomArray(int size, int min, int max) // метод который создает массив
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    return array;
}

int KolNum(int[] array) // метод поиска двухзначного числа
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 9 && array[i] <= 99) // проверка на двухзначное число
        sum++; 
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

int[] myArray = CreateRandomArray(10, 1, 1000); // указываем параметры массива: 10 чисел, от 1, до 100
Print(myArray); // выводим рандомные числа массива
Console.WriteLine("Кол-во двухзначных чисел = " + KolNum(myArray)); */ // выводим результам метода поиска двухзначных чисел

